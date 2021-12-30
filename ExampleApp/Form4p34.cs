namespace ExampleApp
{
    // p34:如何用鼠标选择图像的特征区域(ROI)
    // p35:如何用ROI处理图像的一部分
    // p36:EmguCV中的模板匹配
    // p37:多尺度模板匹配
    // p38:基于特征的图像匹配
    public partial class Form4p34 : Form
    {
        Dictionary<string, Image<Bgr, byte>> imgList;
        Rectangle rect;
        Point StartROI;
        bool Selecting;
        bool MouseDown;

        public Form4p34()
        {
            InitializeComponent();
            Selecting = false;
            rect = Rectangle.Empty;
            imgList = new();
        }

        private void Form4p34_FormClosed(object sender, FormClosedEventArgs e)
        {
            //StartROI?.Dis
        }

        // 菜单项 - 文件 - 打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog ofd = new();
                ofd.Filter = "图像(*.jpg,*.jpeg)|*.jpeg;*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var img = new Image<Bgr, byte>(ofd.FileName);
                    AddImage(img, "Input");
                    pictureBox1.Image = img.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 文件 - 退出
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 处理ROI - 选择ROI
        private void menuItemSelectROI_Click(object sender, EventArgs e)
        {
            Selecting = true;
        }

        // 菜单项 - 处理 - 处理ROI - 获取ROI区域
        private void menuItemGetRegionOfROI_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    return;
                }

                if (rect == Rectangle.Empty)
                {
                    return;
                }

                using var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                var imgROI = img.Copy();
                img.ROI = Rectangle.Empty;

                pictureBox1.Image = imgROI.AsBitmap();
                AddImage(imgROI, "ROI Image");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                MouseDown = true;
                StartROI = e.Location;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                int width = Math.Max(StartROI.X, e.X) - Math.Min(StartROI.X, e.X);
                int height = Math.Max(StartROI.Y, e.Y) - Math.Min(StartROI.Y, e.Y);
                rect = new(Math.Min(StartROI.X, e.X), Math.Min(StartROI.Y, e.Y), width, height);
                Refresh();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (MouseDown)
            {
                using var pen = new Pen(Color.Red, 3);
                e.Graphics.DrawRectangle(pen, rect);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (Selecting)
            {
                Selecting = false;
                MouseDown = false;
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                pictureBox1.Image = imgList[e.Node.Text].AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="img"></param>
        /// <param name="keyName"></param>
        private void AddImage(Image<Bgr, byte> img, string keyName)
        {
            if (!treeView1.Nodes.ContainsKey(keyName))
            {
                var node = new TreeNode(keyName);
                node.Name = keyName;
                treeView1.Nodes.Add(node);
                treeView1.SelectedNode = node;
            }

            if (!imgList.ContainsKey(keyName))
            {
                imgList.Add(keyName, img);
            }
            else
            {
                imgList[keyName] = img;
            }
        }

        // 菜单项 - 处理 - 处理ROI - 高斯模糊ROI
        private void menuItemGaussianBlurROI_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null)
                {
                    return;
                }

                if (rect == Rectangle.Empty)
                {
                    return;
                }

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                using var img2 = img.Copy();
                using var imgSmooth = img2.SmoothGaussian(25);

                img.SetValue(new Bgr(1, 1, 1));
                img._Mul(imgSmooth);
                img.ROI = Rectangle.Empty;

                pictureBox1.Image = img.AsBitmap();

                AddImage(img, "GaussianBlur");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 处理ROI - Canny边缘ROI
        private void menuItemCannyEdgesROI_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || rect == Rectangle.Empty)
                {

                    return;
                }

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img.ROI = rect;
                using var img2 = img.Copy();
                using var imgCanny = img2.SmoothGaussian(5).Canny(100, 50);
                using var imgBgr = imgCanny.Convert<Bgr, byte>();

                img.SetValue(new Bgr(1, 1, 1));
                img._Mul(imgBgr);
                img.ROI = Rectangle.Empty;

                pictureBox1.Image = img.AsBitmap();

                AddImage(img, "Canny Edge");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 模板匹配 - 匹配
        private void menuItemMatching_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || rect == Rectangle.Empty)
                {

                    return;
                }

                var imgScene = imgList["Input"].Clone();
                using var template = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                using var imgout = new Mat();

                CvInvoke.MatchTemplate(imgScene, template, imgout, TemplateMatchingType.CcoeffNormed);

                double minVal = 0.0;
                double maxVal = 0.0;
                var minLoc = new Point();
                var maxLoc = new Point();

                CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);
                Rectangle r = new Rectangle(maxLoc, template.Size);

                CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 转换 - 重设大小
        private void menuItemResize_Click(object sender, EventArgs e)
        {
            try
            {
                if (!imgList.ContainsKey("ROI Image"))
                {
                    MessageBox.Show("请选择一个模板", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img = img.Resize(1.25, Inter.Cubic);
                pictureBox1.Image = img.AsBitmap();
                AddImage(img, "Template Resized");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 转换 - 变换
        private void menuItemRotaions_Click(object sender, EventArgs e)
        {
            try
            {
                if (!imgList.ContainsKey("ROI Image"))
                {
                    MessageBox.Show("请选择一个模板", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var img = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                img = img.Rotate(90, new Bgr(0, 0, 0), false);
                pictureBox1.Image = img.AsBitmap();
                AddImage(img, "Template Rotated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 模板匹配 - 多尺度模板匹配
        private void menuItemMultiScaleMatching_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || rect == Rectangle.Empty)
                {

                    return;
                }

                var imgScene = imgList["Input"].Clone();
                using var template = new Bitmap(pictureBox1.Image).ToImage<Bgr, byte>();

                Rectangle r = Rectangle.Empty;
                double globalMinVal = float.MaxValue;

                for (double scale = 0.5f; scale <= 1.50; scale+= 0.25f)
                {
                    var temp = template.Resize(scale,Inter.Cubic);
                    using var imgout = new Mat();
                    CvInvoke.MatchTemplate(imgScene, temp, imgout, TemplateMatchingType.Sqdiff);

                    double minVal = 0;
                    double maxVal = 0;
                    Point minLoc = new();
                    Point maxLoc = new();

                    CvInvoke.MinMaxLoc(imgout, ref minVal, ref maxVal, ref minLoc, ref maxLoc);

                    double prob = minVal / (imgout.ToImage<Gray, byte>().GetSum().Intensity);

                    if (prob < globalMinVal)
                    {
                        globalMinVal = prob;
                        r = new Rectangle(minLoc,temp.Size);
                    }
                }

                if (r != Rectangle.Empty)
                {
                    CvInvoke.Rectangle(imgScene, r, new MCvScalar(255, 0, 0), 3);
                        pictureBox1.Image = imgScene.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 处理 - 特征匹配
        private void menuItemFeatureMatching_Click(object sender, EventArgs e)
        {
            try
            {
                if (pictureBox1.Image == null || rect == Rectangle.Empty)
                {

                    return;
                }

                var imgScene = imgList["Input"].Clone();
                var template = new Bitmap(pictureBox1.Image).ToImage<Gray,byte>();

                var vp = ProcessImage(template, imgScene.Convert<Gray, byte>());
                if (vp != null)
                {
                    CvInvoke.Polylines(imgScene, vp, true, new MCvScalar(0, 0, 255), 5);
                }

                pictureBox1.Image = imgScene.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static VectorOfPoint ProcessImage(Image<Gray,byte> template, Image<Gray,byte> sceneImage)
        {
            try
            {
                VectorOfPoint finalPoint = null;
                Mat homeGraphy = null;
                using VectorOfKeyPoint templateKeyPoints = new();
                using VectorOfKeyPoint sceneKeyPoints = new();

                using Mat templateDescriptor = new();
                using Mat sceneDescriptor = new();
                Mat mask;
                int k = 2;
                double uniquenessthreshold = 0.80;
                using VectorOfVectorOfDMatch matches = new();

                // 特征检测和描述
                Brisk featureDetector = new();
                featureDetector.DetectAndCompute(template, null, templateKeyPoints, templateDescriptor, false);
                featureDetector.DetectAndCompute(sceneImage, null, sceneKeyPoints, sceneDescriptor, false);

                // 匹配
                BFMatcher matcher = new(DistanceType.Hamming);
                matcher.Add(templateDescriptor);
                matcher.KnnMatch(sceneDescriptor, matches, k);

                mask = new(matches.Size, 1, DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));

                Features2DToolbox.VoteForUniqueness(matches, uniquenessthreshold, mask);

                int count =  Features2DToolbox.VoteForSizeAndOrientation(templateKeyPoints, sceneKeyPoints, matches, mask, 1.5, 20);

                if (count >= 4)
                {
                    homeGraphy = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(templateKeyPoints, sceneKeyPoints, matches, mask, 5);
                }

                if (homeGraphy != null)
                {
                    Rectangle rect = new(Point.Empty,template.Size);
                    PointF[] pts = new PointF[]
                    {
                        new PointF(rect.Left, rect.Bottom),
                        new PointF(rect.Right, rect.Bottom),
                        new PointF(rect.Left, rect.Top),
                        new PointF(rect.Right, rect.Top)
                    };

                    pts = CvInvoke.PerspectiveTransform(pts, homeGraphy);
                    Point[] points = Array.ConvertAll<PointF,Point>(pts,Point.Round);
                    finalPoint = new VectorOfPoint(points);
                }

                return finalPoint;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
using System.Text.RegularExpressions;

namespace ExampleApp
{
    // p19:在EmguCV中从视频中实时检测文本
    public partial class Form4p19 : Form
    {
        VideoCapture capture;
        bool Pause = false;

        public Form4p19()
        {
            InitializeComponent();
        }

        private void Form4p18_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pause = true;
            capture?.Dispose();
        }

        // 菜单项 - 打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    capture = new VideoCapture(ofd.FileName);
                    using Mat m = new();
                    capture.Read(m);
                    pictureBox1.Image = m.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 检测文本
        private async void menuItemDetectText_Click(object sender, EventArgs e)
        {
            if (capture  == null)
            {
                return;
            }

            try
            {
                using Mat m = new();
                while (true)
                {
                    capture.Read(m);

                    if (!m.IsEmpty)
                    {
                        pictureBox1.Image = m.ToBitmap();
                        DetecText(m.ToImage<Bgr,byte>());
                        double fps = capture.Get(CapProp.Fps);
                        await Task.Delay(1000/Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DetecText(Image<Bgr,byte> img)
        {
            /*
             * 1.边缘检测(Sobel)
             * 2.膨胀Dilation(10,1)处理
             * 3.找出轮廓
             * 4.应用几何约束
             */
            using Image<Gray, byte> sobel = img.Convert<Gray,byte>().Sobel(1, 0, 3).AbsDiff(new Gray(0.0)).Convert<Gray,byte>().ThresholdBinary(new Gray(20),new Gray(255));

            using Mat SE = CvInvoke.GetStructuringElement(ElementShape.Rectangle, new Size(10, 1), new Point(-1, -1));
            sobel.MorphologyEx(MorphOp.Dilate,SE,new Point(-1,-1),10, BorderType.Reflect, new MCvScalar(255));
            using VectorOfVectorOfPoint contours = new();
            using Mat m = new();

            CvInvoke.FindContours(sobel, contours, m, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            List<Rectangle> list = new();
            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle brect = CvInvoke.BoundingRectangle(contours[i]);

                double ar = brect.Width / brect.Height;
                if (ar > 1 && brect.Width > 15 && brect.Height > 8 && brect.Height < 100)
                {
                    list.Add(brect); 
                }
            }

            using Image<Bgr, byte> imgOut = img.CopyBlank();
            foreach (var r in list)
            {
                CvInvoke.Rectangle(img, r, new MCvScalar(0, 0, 255), 2);
                CvInvoke.Rectangle(imgOut, r, new MCvScalar(0, 255, 255), 2);
            }
            imgOut._And(img);
            pictureBox1.Image = img.AsBitmap();
            pictureBox2.Image = imgOut.AsBitmap();
        }
    }
}

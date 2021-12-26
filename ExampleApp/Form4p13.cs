namespace ExampleApp
{
    // p13:用EmguCV做形态学处理
    public partial class Form4p13 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p13()
        {
            InitializeComponent();
        }

        // 菜单项：文件->打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new(ofd.FileName);
                    pictureBox1.Image = imgInput.AsBitmap();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        // 菜单项：形态学->腐蚀
        private void menuItemErosion_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            pictureBox2.Image = imgInput.Erode(1).AsBitmap();
        }

        // 菜单项：形态学->膨胀
        private void menuItemDilation_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            pictureBox2.Image = imgInput.Dilate(1).AsBitmap();
        }

        // 菜单项：形态学->开运算
        private void menuItemOpening_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
            var dst = imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Open, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1, 0));
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->闭运算
        private void menuItemClosing_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
            var dst = imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Close, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1, 0)); ;
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->梯度
        private void menuItemGradient_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
            var dst = imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Gradient, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1, 0));
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->顶帽
        private void menuItemTopHat_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
            var dst = imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Tophat, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1, 0));
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->黑帽
        private void menuItemBlackHat_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
            var dst = imgInput.MorphologyEx(Emgu.CV.CvEnum.MorphOp.Blackhat, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new MCvScalar(1, 0));
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->二值化腐蚀
        private void menuItemErosionOnBinary_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            var dst = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(120), new Gray(255)).Erode(1);
            pictureBox2.Image = dst.AsBitmap();
        }

        // 菜单项：形态学->二值化膨胀
        private void menuItemDilationOnBinary_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            var dst = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(120), new Gray(255)).Dilate(1);
            pictureBox2.Image = dst.AsBitmap();
        }

        private void Form4p13_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput.Dispose();
        }
    }
}

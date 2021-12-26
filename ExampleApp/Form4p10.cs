namespace ExampleApp
{
    // p10:图像颜色转换
    public partial class Form4p10 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p10()
        {
            InitializeComponent();
        }

        // 菜单项 - 打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                if (imgInput == null)
                {
                    return;
                }
                pictureBox1.Image = imgInput.AsBitmap();
            }
        }

        // 菜单项 - 关闭
        private void menuItemClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 菜单项 - BGR转Gray
        private void menuItemOpenBGR2Gray_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Gray, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            //imgOutput = imgInput.Convert<Gray, byte>();

            CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            pictureBox2.Image = imgOutput.AsBitmap();
        }

        // 菜单项 - BGR转YCrCb
        private void menuItemOpenBGR2YCrCb_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Ycc, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            imgOutput = imgInput.Convert<Ycc, byte>();
            Image<Bgr, byte> imgFinalOutput = new(imgInput.Width, imgInput.Height);

            //CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2YCrCb);

            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.AsBitmap();

            //CvInvoke.Imshow("YCrCb图",imgOutput);
        }

        // 菜单项 - BGR转HSV
        private void menuItemOpenBGR2HSV_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Hsv, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            imgOutput = imgInput.Convert<Hsv, byte>();
            Image<Bgr, byte> imgFinalOutput = new(imgInput.Width, imgInput.Height);

            //CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.AsBitmap();
        }

        // 菜单项 - BGR转LUV
        private void menuItemOpenBGR2LUV_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Luv, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            imgOutput = imgInput.Convert<Luv, byte>();
            Image<Bgr, byte> imgFinalOutput = new(imgInput.Width, imgInput.Height);

            //CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Luv);

            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.AsBitmap();
        }

        // 菜单项 - BGR转Lab
        private void menuItemOpenBGR2Lab_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Lab, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            imgOutput = imgInput.Convert<Lab, byte>();
            Image<Bgr, byte> imgFinalOutput = new(imgInput.Width, imgInput.Height);

            //CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Lab);

            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.AsBitmap();
        }

        // 菜单项 - BGR转HLS
        private void menuItemOpenBGR2HLS_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Image<Hls, byte> imgOutput = new(imgInput.Width, imgInput.Height);
            imgOutput = imgInput.Convert<Hls, byte>();
            Image<Bgr, byte> imgFinalOutput = new(imgInput.Width, imgInput.Height);

            //CvInvoke.CvtColor(imgInput, imgOutput, Emgu.CV.CvEnum.ColorConversion.Bgr2Hls);

            imgFinalOutput.Data = imgOutput.Data;
            pictureBox2.Image = imgFinalOutput.AsBitmap();
        }
    }
}

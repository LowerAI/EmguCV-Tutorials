using Emgu.CV;
using Emgu.CV.Structure;

namespace ExampleApp
{
    // p6:图像二值化：简单阈值、Otsu阈值
    public partial class Form4p6 : Form
    {
        Image<Bgr,byte> imgInput;
        Image<Gray, byte> imgGray;
        Image<Gray, byte> imgBinarize;

        public Form4p6()
        {
            InitializeComponent();
        }

        // 菜单项-打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imgInput = new Image<Bgr, byte>(ofd.FileName);
                pictureBox1.Image = imgInput.AsBitmap();
            }
        }

        // 菜单项-简单二值化
        private void menuItemBinarize_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            imgGray = imgInput.Convert<Gray, byte>();
            pictureBox1.Image = imgGray.AsBitmap();

            imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));

            // 只要有白色的就让它全白到极致，只要有黑色的就让它黑到极致？
            double threshold = CvInvoke.Threshold(imgGray, imgBinarize, 50, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
            pictureBox2.Image = imgBinarize.AsBitmap();
            lblThreahold.Text = threshold.ToString();
        }

        // 菜单项-Otsu二值化
        private void menuItemOtsuBinarize_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            imgGray = imgInput.Convert<Gray, byte>();
            pictureBox1.Image = imgGray.AsBitmap();

            imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));

            // 只要接近白色的就让它全白到极致，只要接近黑色的就让它黑到极致？
            double threshold = CvInvoke.Threshold(imgGray, imgBinarize, 500, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
            pictureBox2.Image = imgBinarize.AsBitmap();
            lblThreahold.Text = threshold.ToString();
        }
    }
}

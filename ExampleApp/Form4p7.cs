using Emgu.CV;
using Emgu.CV.Structure;

namespace ExampleApp
{
    // p7:自适应阈值：使用自适应阈值的图像二值化
    public partial class Form4p7 : Form
    {
        Image<Bgr,byte> imgInput;
        Image<Gray, byte> imgGray;
        Image<Gray, byte> imgBinarize;

        public Form4p7()
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

        // 菜单项-MeanC二值化
        private void menuItemMeanBinarize_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            imgGray = imgInput.Convert<Gray, byte>();
            pictureBox1.Image = imgGray.AsBitmap();

            imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));

            // 只要有白色的就让它全白到极致，只要有黑色的就让它黑到极致？
            CvInvoke.AdaptiveThreshold(imgGray, imgBinarize, 255, Emgu.CV.CvEnum.AdaptiveThresholdType.MeanC, Emgu.CV.CvEnum.ThresholdType.Binary, 5, 0.0);
            pictureBox2.Image = imgBinarize.AsBitmap();
            //lblThreahold.Text = threshold.ToString();
        }

        // 菜单项-GaussianC二值化
        private void menuItemGaussianCBinarize_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            imgGray = imgInput.Convert<Gray, byte>();
            pictureBox1.Image = imgGray.AsBitmap();

            imgBinarize = new Image<Gray, byte>(imgGray.Width, imgGray.Height, new Gray(0));

            // 只要接近白色的就让它全白到极致，只要接近黑色的就让它黑到极致？
            CvInvoke.AdaptiveThreshold(imgGray, imgBinarize,  255, Emgu.CV.CvEnum.AdaptiveThresholdType.GaussianC, Emgu.CV.CvEnum.ThresholdType.Binary ,5,0.0);
            pictureBox2.Image = imgBinarize.AsBitmap();
            //lblThreahold.Text = threshold.ToString();
        }
    }
}

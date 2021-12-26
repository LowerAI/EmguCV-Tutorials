using System.Threading;

namespace ExampleApp
{
    // p17:分隔字符
    public partial class Form4p17 : Form
    {
        Image<Bgr, byte> imgInput;
        Bitmap img;
        bool show = false;

        public Form4p17()
        {
            InitializeComponent();
        }

        // 菜单项 - 打开
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 分割字符串 
        private async void menuItemSegmentCharachters_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using Image<Gray, byte> imgout = imgInput.Convert<Gray, byte>().Not().ThresholdBinary(new Gray(50), new Gray(255)); // 注意此处的"Not()"，由于选取的图片是白底黑字，转换成灰度图之后需要取反让其变成黑底白字才能取出来字
            using VectorOfVectorOfPoint contours = new();
            using Mat hier = new();

            CvInvoke.FindContours(imgout, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            show = true;
            for (int i = 0; i < contours.Size; i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                imgInput.ROI = rect; // 给imgInput设置特征区域

                img = imgInput.Copy().AsBitmap();
                imgInput.ROI = Rectangle.Empty;
                this.Invalidate();

                await Task.Delay(500);
            }
            show = false;
        }

        private void Form4p17_Paint(object sender, PaintEventArgs e)
        {
            if (show)
            {
                pictureBox2.Image = img;
            }
        }

        private void Form4p17_FormClosed(object sender, FormClosedEventArgs e)
        {
            img?.Dispose();
            imgInput?.Dispose();
        }
    }
}

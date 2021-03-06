using System;
namespace ExampleApp
{
    // p30:连接组件标签
    public partial class Form4p30 : Form
    {
        Image<Bgr, byte> imgInput;
        Image<Gray, byte> CC;

        public Form4p30()
        {
            InitializeComponent();
        }

        private void Form4p30_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
            CC?.Dispose();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog ofd = new();
                ofd.Filter = "图像(*.jpg,*.jpeg)|*.jpeg;*.jpg;*.png";
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

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }

            try
            {
                using var temp = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(100), new Gray(255)).Dilate(1).Erode(1); // 转换为灰度图->阈值二值化->膨胀->腐蚀

                using Mat labels = new();
                int totalNumber = CvInvoke.ConnectedComponents(temp, labels);

                CC = labels.ToImage<Gray, byte>();
                pictureBox2.Image = temp.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (CC == null)
            {
                return;
            }

            try
            {
                if (e.X > CC.Cols || e.Y > CC.Rows)
                {
                    return;
                }
                int label = (int)CC[e.Y, e.X].Intensity;
                if (label != 0)
                {
                    using var temp = CC.InRange(new Gray(label), new Gray(label));
                    pictureBox2.Image = temp.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

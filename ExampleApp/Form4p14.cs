using System.Windows.Forms;

namespace ExampleApp
{
    // p14:图像分割和叠加
    public partial class Form4p14 : Form
    {
        (int min, int max) para = (20, 200);

        Image<Bgr, byte> imgInput;
        Image<Gray, byte> imgOutput;

        public Form4p14()
        {
            InitializeComponent();
        }

        private void Form4p14_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
            imgOutput?.Dispose();
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

        // 菜单项 - 范围过滤
        private void menuItemRangeFilter_Click(object sender, EventArgs e)
        {
            DlgParameters parameters = new (ApplyRangeFilter);
            parameters.ShowDialog();
        }

        // 菜单项 - 叠加
        private void menuItemOverlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    return;
                }

                Image<Bgr, byte> temp = imgInput.Clone();
                temp.SetValue(new Bgr(0, 0, 255), imgOutput);

                pictureBox2.Image = temp.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 应用范围过滤
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        private void ApplyRangeFilter(int min, int max)
        {
            try
            {
                // 过滤出像素值在0~200之间的部分
                imgOutput = imgInput.Convert<Gray, byte>().InRange(new Gray(min), new Gray(max)).Canny(10,50);

                pictureBox2.Image = imgOutput.AsBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

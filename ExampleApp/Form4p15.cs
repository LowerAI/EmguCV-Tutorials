using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    // p15:提取图像轮廓
    public partial class Form4p15 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p15()
        {
            InitializeComponent();
        }

        private void Form4p15_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
        }

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

        private void menuItemFindContour_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using Image<Gray, byte> imgOutput = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(100),new Gray(255));
            Emgu.CV.Util.VectorOfVectorOfPoint contours = new(); // 用于存储轮廓等点向量的集合
            using Mat hier = new(); // 存储层级结构等与拓扑信息

            using Image<Gray, byte> imgOut = new Image<Gray, byte>(imgInput.Width, imgInput.Height, new Gray(0));

            CvInvoke.FindContours(imgOutput, contours, hier, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);
            CvInvoke.DrawContours(imgOut, contours, -1, new MCvScalar(255, 0, 0));

            pictureBox2.Image = imgOut.AsBitmap();
        }
    }
}

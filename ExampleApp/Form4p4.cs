using Emgu.CV;
using Emgu.CV.Structure;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleApp
{
    // p4:边缘检测：Canny、Sobel和拉普拉斯边缘检测
    public partial class Form4p4 : Form
    {
        Image<Bgr, byte> _imgInput;
        ValueTuple<double, double> cannyParas = (50,20);
        public Form4p4()
        {
            InitializeComponent();
        }

        #region    事件响应 start
        // 菜单项-打开
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imgInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = _imgInput;
            }
        }

        // 菜单项-关闭
        private void menuItemClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定关闭吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        // 菜单项-Canny边缘检测
        private void menuItemCanny_Click(object sender, EventArgs e)
        {
            ApplyCanny(cannyParas);
        }

        // 菜单项-Sobel边缘检测
        private void menuItemSobel_Click(object sender, EventArgs e)
        {
            if (_imgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgGray = _imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgSobel = new Image<Gray, float>(_imgInput.Width, _imgInput.Height, new Gray(0));

            _imgSobel = _imgGray.Sobel(1, 1, 3);
            imageBox1.Image = _imgSobel;
        }

        // 菜单项-Laplacian边缘检测
        private void menuItemLaplacian_Click(object sender, EventArgs e)
        {
            if (_imgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgGray = _imgInput.Convert<Gray, byte>();
            Image<Gray, float> _imgLaplacian = new Image<Gray, float>(_imgInput.Width, _imgInput.Height, new Gray(0));

            _imgLaplacian = _imgGray.Laplace(7);
            imageBox1.Image = _imgLaplacian;
        }

        // 菜单项-Canny参数设定
        private void menuItemCannyParameters_Click(object sender, EventArgs e)
        {
            DlgCannyParameters cp = new DlgCannyParameters(cannyParas);
            if (cp.ShowDialog() == DialogResult.OK)
            {
                if (cp.Tag != null)
                {
                    cannyParas = (ValueTuple<double, double>)cp.Tag;
                    ApplyCanny(cannyParas);
                }
            }
        }
        #endregion 事件响应 start

        #region    方法 start
        /// <summary>
        /// 应用参数并进行Canny检测
        /// </summary>
        public void ApplyCanny((double thresh, double threshLinking) cannyParas)
        {
            if (_imgInput == null)
            {
                return;
            }

            Image<Gray, byte> _imgCanny = new Image<Gray, byte>(_imgInput.Width, _imgInput.Height, new Gray(0));

            _imgCanny = _imgInput.Canny(cannyParas.thresh, cannyParas.threshLinking);
            imageBox1.Image = _imgCanny;
        }
        #endregion 方法 end
    }
}

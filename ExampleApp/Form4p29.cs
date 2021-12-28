namespace ExampleApp
{
    // p29:用轮廓进行形状检测
    public partial class Form4p29 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p29()
        {
            InitializeComponent();
        }

        private void Form4p29_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
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

        private void menuItemDetectShape_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }

            try
            {
                var temp = imgInput.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(230), new Gray(255)); // 平滑高斯模糊->转灰度图->二值化(小于230的像素值被替换为255，使得背景为白色)

                using var contours = new VectorOfVectorOfPoint();
                using var m = new Mat();

                CvInvoke.FindContours(temp, contours, m, RetrType.External, ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    double perimeter = CvInvoke.ArcLength(contours[i], true);
                    using var approx = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * perimeter, true);

                    CvInvoke.DrawContours(imgInput, contours, i, new MCvScalar(0, 0, 255), 2);
                    // pictureBox2.Image = imgInput.AsBitmap(); // 此时只能找到整个图片的边框

                    // monents 形状的质心
                    var moments = CvInvoke.Moments(contours[i]);
                    int x = (int)(moments.M10 / moments.M00);
                    int y = (int)(moments.M01 / moments.M00);

                    string tip = null;
                    switch (approx.Size)
                    {
                        case 3:
                            tip = "Triangle";
                            break;
                        case 4:
                            var rect = CvInvoke.BoundingRectangle(contours[i]);
                            double ar = (double)rect.Width / rect.Height;
                            tip = ar == 1.0 ? "Square" : "Rectangle";
                            break;
                        case 5:
                            tip = "Pentagon";
                            break;
                        case 6:
                            tip = "Hexagon";
                            break;
                        default:
                            if (approx.Size > 6)
                            {
                                tip = "Circle";
                            }
                            break;
                    }
                    if (tip is { Length: > 0 })
                    {
                        CvInvoke.PutText(imgInput, tip, new Point(x, y), FontFace.HersheySimplex, 0.5, new MCvScalar(255, 0, 0), 2);
                    }

                    pictureBox2.Image = imgInput.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

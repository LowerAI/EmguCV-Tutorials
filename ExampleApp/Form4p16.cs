namespace ExampleApp
{
    // p16:基于边框区域的轮廓排序
    public partial class Form4p16 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p16()
        {
            InitializeComponent();
        }

        private void Form4p16_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
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

        // 菜单项 - 查找轮廓
        private void menuItemFindContour_Click(object sender, EventArgs e)
        {
            if (imgInput == null)
            {
                MessageBox.Show("请选择一张图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using Image<Gray, byte> imgOut = imgInput.Convert<Gray, byte>().ThresholdBinary(new Gray(50), new Gray(255));
            using VectorOfVectorOfPoint contours = new(); // 用于存储轮廓等点向量的集合
            using Mat hier = new(); // 存储层级结构等与拓扑信息

            CvInvoke.FindContours(imgOut, contours, hier, RetrType.External, ChainApproxMethod.ChainApproxSimple);

            List<double> ctrlst = new();
            if (contours.Size > 0)
            {
                for (int i = 0; i < contours.Size; i++)
                {
                    double area = CvInvoke.ContourArea(contours[i]);
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    //if (rect.Width > 50 && rect.Height > 10 && area > 2000)
                    //{
                        ctrlst.Add(area); 
                    //}
                }
            }

            var items = ctrlst.OrderByDescending(v => v);
            using Image<Bgr,byte> imgOut1 = new Image<Bgr, byte>(imgInput.Width,imgInput.Height,new Bgr(0,0,0));

            for (int i = 0; i < items.Count(); i++)
            {
                Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);

                CvInvoke.Rectangle(imgOut1, rect, new MCvScalar(255, 255, 255),3);
                //CvInvoke.DrawContours(imgInput, contours, i, new MCvScalar(255, 255, 255));
            }

            pictureBox2.Image = imgOut1.AsBitmap();
        }
    }
}

namespace ExampleApp
{
    // p27:图像混合|创建滑块显示效果
    public partial class Form4p27 : Form
    {
        Image<Bgr, byte> imgInput1;
        Image<Bgr, byte> imgInput2;

        public Form4p27()
        {
            InitializeComponent();
        }

        private void Form4p27_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput1?.Dispose();
            imgInput2?.Dispose();
        }

        private void menuItemOpenImage_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog ofd = new();
                ofd.Multiselect = true;
                ofd.Filter = "图像(*.jpg,*.jpeg)|*.jpg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var fileNames = ofd.FileNames;
                    if (fileNames.Length < 2)
                    {
                        MessageBox.Show("请选择至少两张图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    imgInput1 = new(fileNames[0]);
                    imgInput2 = new(fileNames[1]);

                    pictureBox1.Image = imgInput1.AsBitmap();
                    pictureBox2.Image = imgInput2.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemBlendImage_Click(object sender, EventArgs e)
        {
            if (imgInput1 == null || imgInput2 == null)
            {
                return;
            }

            (Image<Bgr, byte> imgOut1, Image<Bgr, byte> imgOut2) = GetIntersectionImage(imgInput1, imgInput2);

            double alpha = (double)numericUpDown1.Value;
            pictureBox2.Image = imgOut1.AddWeighted(imgOut2, alpha, (1 - alpha), 0).AsBitmap();
        }

        private async void menuItemSildeShow_Click(object sender, EventArgs e)
        {
            using var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //var fileNames = Directory.GetFiles(fbd.SelectedPath, "*.jpg;*.png"); // searchPattern不支持多个匹配模式

                var fileNames = new string[] { "*.jpg", "*.png" }
    .SelectMany(pattern => Directory.EnumerateFiles(fbd.SelectedPath, pattern))
    .ToArray();

                var listImages = new List<Image<Bgr, byte>>();
                foreach (var file in fileNames)
                {
                    listImages.Add(new Image<Bgr, byte>(file));
                }
                double maxValue = (double)numericUpDown1.Value;
                for (int i = 0; i <= listImages.Count - 2; i++)
                {
                    for (double alpha = 0.0; alpha <= maxValue; alpha += 0.01)
                    {
                        (Image<Bgr, byte> imgOut1, Image<Bgr, byte> imgOut2) = GetIntersectionImage(listImages[i + 1], listImages[i]);

                        pictureBox2.Image = imgOut1.AddWeighted(imgOut2, alpha, (1 - alpha), 0).AsBitmap();
                        await Task.Delay(25);
                    }
                }
            }
        }

        /// <summary>
        /// 返回两个图像各自均符合它们矩阵交集大小的图像
        /// </summary>
        /// <param name="imgIn1">图像1</param>
        /// <param name="imgIn2">图像2</param>
        /// <returns></returns>
        private (Image<Bgr, byte> imgOut1, Image<Bgr, byte> imgOut2) GetIntersectionImage(Image<Bgr, byte> imgIn1, Image<Bgr, byte> imgIn2)
        {
            // 找出imgInput1和imgInput2的长宽的交集
            (int width, int height) = (0, 0);
            width = imgIn1.Width > imgIn2.Width ? imgIn2.Width : imgIn1.Width;
            height = imgIn1.Height > imgIn2.Height ? imgIn2.Height : imgIn1.Height;

            // 取出imgInput1和imgInput2的矩阵的交集并分给存入imgTemp1和imgTemp2
            Rectangle rect = new(0, 0, width, height);
            imgIn1.ROI = rect;
            imgIn2.ROI = rect;
            Image<Bgr, byte> imgTemp1 = new(width, height);
            Image<Bgr, byte> imgTemp2 = new(width, height);
            imgIn1.CopyTo(imgTemp1);
            imgIn2.CopyTo(imgTemp2);
            imgIn1.ROI = Rectangle.Empty;
            imgIn2.ROI = Rectangle.Empty;

            return (imgTemp1, imgTemp2);
        }
    }
}

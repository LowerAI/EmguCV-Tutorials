namespace ExampleApp
{
    // p9:图像直方图
    public partial class Form4p09 : Form
    {
        Image<Bgr, byte> _inputimage;
        Image<Gray, byte> R;
        Image<Gray, byte> G;
        Image<Gray, byte> B;

        public Form4p09()
        {
            InitializeComponent();
        }

        private void btnReadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _inputimage = new Image<Bgr, byte>(ofd.FileName);
                if (_inputimage == null)
                {
                    return;
                }
                B = _inputimage[0];
                G = _inputimage[1];
                R = _inputimage[2];
                imageBox1.Image = R;
                imageBox2.Image = G;
                imageBox3.Image = B;
            }
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            if (_inputimage == null)
            {
                MessageBox.Show("请选择一张图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();

            histogramBox1.GenerateHistograms(R, 256);
            histogramBox2.GenerateHistograms(G, 256);
            histogramBox3.GenerateHistograms(B, 256);

            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();
        }

        // 密集直方图
        private void btnDenseHistogram_Click(object sender, EventArgs e)
        {
            if (_inputimage == null)
            {
                MessageBox.Show("请选择一张图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GetDenseHistogram(R, histogramBox1, "Red Channel Histogram", Color.Red);
            GetDenseHistogram(G, histogramBox2, "Green Channel Histogram", Color.Green);
            GetDenseHistogram(B, histogramBox3, "Blue Channel Histogram", Color.Blue);
        }

        /// <summary>
        /// 生成密集直方图并显示
        /// </summary>
        /// <param name="img"> 单通道图像(灰度图)</param>
        /// <param name="histogramBox">直方图像框</param>
        /// <param name="channelName">通道名</param>
        /// <param name="color">颜色</param>
        private void GetDenseHistogram(Image<Gray, byte> img, HistogramBox histogramBox,string channelName,Color color)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0.0F, 255.0f));
            hist.Calculate(new Image<Gray, byte>[] { img }, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            histogramBox.ClearHistogram();
            histogramBox.Image = HistogramBox.GenerateHistogram(channelName, color, m, 256, new float[] { 0f, 255f });
            histogramBox.Refresh();
        }
    }
}

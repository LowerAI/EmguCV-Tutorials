namespace ExampleApp
{
    // p3:直方图图像框和平移与缩放框
    public partial class Form4p03 : Form
    {
        Image<Bgr, byte> _Inputimage;
        Image<Gray, byte> _Grayimage;

        public Form4p03()
        {
            InitializeComponent();
        }

        // 加载图片
        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            string fileName = "F:\\美女演示图0.png";
            _Inputimage = new Image<Bgr, byte>(fileName);

            if (_Inputimage == null)
            {
                MessageBox.Show("图片加载失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            imageBox1.Image = _Inputimage;
            imageBox1.FunctionalMode = ImageBox.FunctionalModeOption.Everything;
        }

        // 获取灰度图
        private void btnGetGrayIMage_Click(object sender, EventArgs e)
        {
            _Grayimage = _Inputimage.Convert<Gray, byte>(); // 转换为灰度图
            panAndZoomPictureBox1.Image = _Grayimage.AsBitmap();
        }

        // 获取彩色直方图
        private void btnColorHist_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _Inputimage[0] }, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            Mat dst = HistogramBox.GenerateHistogram("蓝色通道直方图", Color.Blue, m,256, new float[] { 0, 256 });
            histogramBox1.Image = dst;
        }

        // 获取灰度直方图
        private void btnGrayHist_Click(object sender, EventArgs e)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 255));
            hist.Calculate(new Image<Gray, byte>[] { _Grayimage }, false, null);

            Mat m = new Mat();
            hist.CopyTo(m);

            Mat dst = HistogramBox.GenerateHistogram("灰度放缩方图", Color.Blue, m, 256, new float[] { 0, 256 });
            histogramBox2.Image = dst;
        }
    }
}

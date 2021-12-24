namespace ExampleApp
{
    // p8:均值平移切割
    public partial class Form4p8 : Form
    {
        (int spatialWindowRadius,int colorWindowRadius, int minimumSegmentSize, int maxIteration) para = (15,30,50,10);

        public Form4p8()
        {
            InitializeComponent();
        }

        private void Form4p8_Load(object sender, EventArgs e)
        {
            try
            {
                //this.numericSpatialWindowRadius.DataBindings.Add("Value", para, "spatialWindowRadius");
                //this.numericColorWindowRadius.DataBindings.Add("Value", para, "colorWindowRadius");
                //this.numericMinimumSegmentSize.DataBindings.Add("Value", para, "minimumSegmentSize");
                //this.numericMaxIteration.DataBindings.Add("Value", para, "maxIteration");
                numericSpatialWindowRadius.Value = para.spatialWindowRadius;
                numericColorWindowRadius.Value = para.colorWindowRadius;
                numericMinimumSegmentSize.Value = para.minimumSegmentSize;
                numericMaxIteration.Value = para.maxIteration;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMeanShiftSegmentation_Click(object sender, EventArgs e)
        {
            try
            {
                Image<Bgra, byte> imgInput = new Image<Bgra, byte>("F:\\tr_12231357.png");
                if (imgInput == null)
                {
                    MessageBox.Show("加载图片失败!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Image<Bgra, byte> imgOutput = new Image<Bgra, byte>(imgInput.Size);

                CudaImage<Bgra, byte> cudaImage = new CudaImage<Bgra, byte>(imgInput);

                para = ((int)numericSpatialWindowRadius.Value, (int)numericColorWindowRadius.Value, (int)numericMinimumSegmentSize.Value, (int)numericMaxIteration.Value);

                // 此句无论如何调整始终异常
                CudaInvoke.MeanShiftSegmentation(cudaImage, imgOutput, para.spatialWindowRadius, para.colorWindowRadius, para.minimumSegmentSize, new MCvTermCriteria(para.maxIteration), null);

                pictureBox1.Image = imgInput.AsBitmap();
                pictureBox2.Image = imgOutput.AsBitmap();
            }
            catch (Exception ex)
            {
                // 异常内容：
                // 1.The type initializer for 'Emgu.CV.CvInvoke' threw an exception.
                // 2.OpenCV:Invalid Texture
                (string title, string info) = ("提示", ex.Message);
                string[] infos = info.Split(':');
                if (infos.Length >= 2)
                {
                    title = infos[0];
                    info = infos[1];
                }
                MessageBox.Show(info, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

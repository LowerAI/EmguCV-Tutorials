namespace ExampleApp
{
    // p20:用EmguCV截取视频中的特定帧
    public partial class Form4p20 : Form
    {
        double TotalFrame;
        double Fps;
        int FrameNo;
        bool IsReadingFrame;
        VideoCapture capture;

        public Form4p20()
        {
            InitializeComponent();
        }

        private void Form4p20_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture?.Dispose();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    capture = new VideoCapture(ofd.FileName);
                    using Mat m = new();
                    capture.Read(m);
                    pictureBox1.Image = m.ToBitmap();

                    TotalFrame = capture.Get(CapProp.FrameCount); // 获取视频总帧数
                    Fps = capture.Get(CapProp.Fps);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }
            IsReadingFrame = true;
            ReadAllFrame();
        }

        private async void ReadAllFrame()
        {
            Mat m = new();
            while (IsReadingFrame && FrameNo < TotalFrame)
            {
                FrameNo += Convert.ToInt16(numericUpDown1.Value);
                capture.Set(CapProp.PosFrames, FrameNo);
                capture.Read(m);
                pictureBox1.Image = m.ToBitmap();
                await Task.Delay(1000 / Convert.ToInt16(Fps));
                label1.Text = $"当前帧：{FrameNo}/总帧数：{TotalFrame}";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            IsReadingFrame = false;
        }

        private void Form4p20_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsReadingFrame = false;
        }
    }
}

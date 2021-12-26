namespace ExampleApp
{
    // p21:用EmguCV写视频
    public partial class Form4p21 : Form
    {
        double Fps;
        int FrameNo;
        VideoCapture capture;

        public Form4p21()
        {
            InitializeComponent();
        }

        private void Form4p21_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture?.Dispose();
        }

        // 菜单项 - 读视频
        private void menuItemReadVideo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    capture = new VideoCapture(ofd.FileName);
                    using Mat m = new();
                    capture.Read(m);
                    pictureBox1.Image = m.ToBitmap();

                    //TotalFrame = capture.Get(CapProp.FrameCount); // 获取视频总帧数
                    Fps = capture.Get(CapProp.Fps);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 写视频
        private void menuItemWriteVideo_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }

            using SaveFileDialog sfd = new();
            sfd.Filter = "mp4 | *.mp4";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                int fourcc = Convert.ToInt32(capture.Get(CapProp.FourCC));
                int Width = Convert.ToInt32(capture.Get(CapProp.FrameWidth));
                int Height = Convert.ToInt32(capture.Get(CapProp.FrameHeight));

                using VideoWriter writer = new VideoWriter(sfd.FileName, fourcc, Fps, new Size(Width, Height),true);


                using Image<Bgr, byte> logo = Properties.Resources.中国结.ToImage<Bgr, byte>();
                using Mat m = new();
                
                while (FrameNo < 500)
                {
                    capture.Read(m);
                    using Image<Bgr, byte> img = m.ToImage<Bgr, byte>();
                    img.ROI = new Rectangle(100, 10, logo.Width, logo.Height);
                    logo.CopyTo(img);
                    img.ROI = Rectangle.Empty;

                    writer.Write(img.Mat);
                    FrameNo++;
                }
                
                MessageBox.Show("写入完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

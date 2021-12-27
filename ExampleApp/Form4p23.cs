using System.Text.RegularExpressions;

namespace ExampleApp
{
    // p23:在EmguCV 3.3 中如何直接加载和播放视频
    public partial class Form4p23 : Form
    {
        VideoCapture videoCapture;
        bool IsPlaying = false;
        int TotalFrames;
        int CurrentFrameNo;
        Mat CurrentFrame;
        int FPS;      


        public Form4p23()
        {
            InitializeComponent();
        }

        private void Form4p23_FormClosed(object sender, FormClosedEventArgs e)
        {
            CurrentFrame.Dispose();
            videoCapture?.Dispose();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new();
                ofd.Filter = "视频文件(*.mp4,*.flv)|*.mp4;*.flv";
                if (ofd.ShowDialog() == DialogResult.OK)
{
                    videoCapture = new (ofd.FileName);
using Mat m = new();
                    
                    TotalFrames = Convert.ToInt32(videoCapture.Get(CapProp.FrameCount)); // 获取视频总帧数
                    FPS = Convert.ToInt32(videoCapture.Get(CapProp.Fps));
                    IsPlaying = true;
                    CurrentFrame = new();
                    CurrentFrameNo = 0;
                    trackBar1.Maximum = TotalFrames - 1;
                    PlayVideo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PlayVideo()
        {
            if (videoCapture == null)
            {
                return;
            }

            try
            {
                while (IsPlaying && CurrentFrameNo < TotalFrames)
                {
                    videoCapture.Set(CapProp.PosFrames, CurrentFrameNo);
                    videoCapture.Read(CurrentFrame);
                    pictureBox1.Image = CurrentFrame.ToBitmap();
                    trackBar1.Value = CurrentFrameNo;
                    CurrentFrameNo += 1;
                    await Task.Delay(1000/FPS);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                IsPlaying = true;
                PlayVideo();
            }
            else
            {
                IsPlaying = false;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            IsPlaying = false;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            IsPlaying = false;
            CurrentFrameNo = 0;
            trackBar1.Value =0;
            pictureBox1.Image = null;
            pictureBox1.Invalidate();
        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            if (videoCapture != null && CurrentFrame != null)
            {
                CurrentFrame.Save($"F:\\{CurrentFrameNo}.jpg");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                CurrentFrameNo = trackBar1.Value;
            }
        }
    }
}

using System.Windows.Forms;

namespace ExampleApp
{
    // p11:在EmguCV中捕获相机和视频
    public partial class Form4p11 : Form
    {
        VideoCapture videoCapture;

        public Form4p11()
        {
            InitializeComponent();
        }

        // 菜单项 - 启动相机
        private void menuItemStartCamrea_Click(object sender, EventArgs e)
        {
            if (videoCapture == null)
            {
                videoCapture = new (0); // 0表示系统中排在第一位的相机
            }
            videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed; // 捕获图像事件
            videoCapture.Start();
        }

        private void VideoCapture_ImageGrabbed(object? sender, EventArgs e)
        {
            try
            {
                Mat m = new Mat();
                videoCapture.Retrieve(m);
                pictureBox1.Invoke(() =>
                {
                    pictureBox1.Image = m.ToImage<Bgr, byte>().AsBitmap();
                    Thread.Sleep((int)videoCapture.Get(Emgu.CV.CvEnum.CapProp.Fps)); // 帧率控制，否则播放速度太快了
                });                
            }
            catch (Exception)
            {
                //throw;
            }
        }

        // 菜单项 - 暂停相机
        private void menuItemPauseCamrea_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Pause();
            }
        }

        // 菜单项 - 停止相机
        private void menuItemStopCamrea_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture.Dispose();
            }
        }

        // 菜单项 - 开始播放视频
        private void menuItemStartVideo_Click(object sender, EventArgs e)
        {
            if (videoCapture == null)
            {
                OpenFileDialog ofd = new();
                ofd.Filter = "Video Files |*.mp4";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    videoCapture = new(ofd.FileName);
                    videoCapture.ImageGrabbed += VideoCapture_ImageGrabbed;
                    videoCapture.Start();
                }
            }
        }

        // 菜单项 - 暂停播放视频
        private void menuItemPauseVideo_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Pause();
            }
        }

        // 菜单项 - 停止播放视频
        private void menuItemStopVideo_Click(object sender, EventArgs e)
        {
            if (videoCapture != null)
            {
                videoCapture.Stop();
                videoCapture.Dispose();
            }
        }
    }
}

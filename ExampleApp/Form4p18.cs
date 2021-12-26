using System.Text.RegularExpressions;

namespace ExampleApp
{
    // p18:EmguCV 3.3 中的视频截取
    public partial class Form4p18 : Form
    {
        VideoCapture capture;
        bool Pause = false;

        public Form4p18()
        {
            InitializeComponent();
        }

        private void Form4p18_FormClosed(object sender, FormClosedEventArgs e)
        {
            Pause = true;
            capture?.Dispose();
        }

        // 菜单项 - 打开
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
                }

                //capture = new VideoCapture("http://admin:3629442@192.168.0.4:8080");
                //using Mat m = new();
                //capture.Read(m);
                //pictureBox1.Image = m.ToBitmap();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 播放
        private async void menuItemPlay_Click(object sender, EventArgs e)
        {
            if (capture  == null)
            {
                return;
            }

            try
            {
                Pause = false;
                using Mat m = new();
                while (!Pause)
                {
                    capture.Read(m);

                    if (!m.IsEmpty)
                    {
                        pictureBox2.Image = m.ToBitmap();
                        double fps = capture.Get(CapProp.Fps);
                        await Task.Delay(1000/Convert.ToInt32(fps));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 菜单项 - 暂停
        private void menuItemPause_Click(object sender, EventArgs e)
        {
            if (capture == null)
            {
                return;
            }
            Pause = true;
        }
    }
}

namespace ExampleApp
{
    // p12:在EmguCV中异步读取大图
    public partial class Form4p12 : Form
    {
        Image<Bgr, byte> imgInput;

        public Form4p12()
        {
            InitializeComponent();
        }

        // 菜单项 - 同步打开
        private void menuItemOpenWithSync_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "选择Tif | *.tif";
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

        // 菜单项 - 异步打开
        private void menuItemOpenWithASync_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "选择Tif | *.tif";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BackgroundWorker bw = new();
                    bw.WorkerReportsProgress = false;
                    bw.WorkerSupportsCancellation = false;
                    bw.DoWork += (object? sender, DoWorkEventArgs e) =>
                    {
                        imgInput = new(ofd.FileName);
                    };

                    bw.RunWorkerCompleted += (object? sender, RunWorkerCompletedEventArgs e) =>
                        {
                            pictureBox1.Image = imgInput.AsBitmap();
                        };
                    bw.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

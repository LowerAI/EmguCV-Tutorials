namespace ExampleApp
{
    // p2:��ȡ����ʾͼ��
    public partial class Form4p2 : Form
    {
        public Form4p2()
        {
            InitializeComponent();
        }

        private void menuItem_Open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Image<Bgr,byte> imgInput = new Image<Bgr,byte>(ofd.FileName);
                    pictureBox1.Image = imgInput.AsBitmap<Bgr,byte>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"��ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void menuItem_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
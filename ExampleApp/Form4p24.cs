using System.Windows.Forms;

namespace ExampleApp
{
    // p24:在EmguCV中如何用鼠标选择裁剪图像
    public partial class Form4p24 : Form
    {
        Image<Bgr, byte> imgInput;
        Rectangle rect;
        Point StartLocation;
        Point EndLocation;
        bool IsMosuDown = false;

        public Form4p24()
        {
            InitializeComponent();
        }

        private void Form4p24_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgInput = new(ofd.FileName);
                    pictureBox1.Invalidate();
                    pictureBox1.Image = imgInput.AsBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (imgInput ==  null)
            {
                return;
            }
            Cursor = Cursors.Cross;
            IsMosuDown = true;
            StartLocation = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            if (IsMosuDown)
            {
                EndLocation = e.Location;
                rect = GetRectangle();
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            if (IsMosuDown && rect != Rectangle.Empty)
            {
                e.Graphics.DrawRectangle(Pens.Red, rect);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (imgInput == null)
            {
                return;
            }
            Cursor = Cursors.Default;
            if (IsMosuDown && imgInput != null)
            {
                EndLocation = e.Location;
                
                if (rect != Rectangle.Empty)
                {
                    imgInput.ROI = rect;
                    using Image<Bgr,byte> temp = imgInput.CopyBlank();
                    imgInput.CopyTo(temp);
                    imgInput.ROI = Rectangle.Empty;
                    pictureBox1.Invalidate();
                    pictureBox2.Image = temp.AsBitmap();
                }
            }
            IsMosuDown = false;
        }

        private Rectangle GetRectangle()
        {
            rect = new();
            rect.X = Math.Min(StartLocation.X, EndLocation.X);
            rect.Y = Math.Min(StartLocation.Y, EndLocation.Y);
            rect.Width = Math.Abs(StartLocation.X - EndLocation.X);
            rect.Height = Math.Abs(StartLocation.Y - EndLocation.Y);
            return rect;
        }
    }
}

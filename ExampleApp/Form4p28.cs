using System.Windows.Forms;

namespace ExampleApp
{
    // p28:使用级联分类器：Haar和LBP的人脸检测
    public partial class Form4p28 : Form
    {
        static string ProjectPath = $"{Application.StartupPath}data";
        string HaarCasCade4FacePath = $"{ProjectPath}\\haarcascade_frontalface_default.xml";
        string HaarCasCade4EyePath = $"{ProjectPath}\\haarcascade_eye.xml";
        string LBPCasCadePath = $"{ProjectPath}\\lbpcascade_frontalface.xml";
        Image<Bgr, byte> imgInput;

        public Form4p28()
        {
            InitializeComponent();
        }

        private void Form4p28_FormClosed(object sender, FormClosedEventArgs e)
        {
            imgInput?.Dispose();
        }

        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using OpenFileDialog ofd = new();
                ofd.Filter = "图像(*.jpg,*.jpeg)|*.jpeg;*.jpg;*.png";
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

        private void menuItemDetectFaceHaar_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    return;
                }
                DetectFaceHaar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuItemDetectFaceLBP_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgInput == null)
                {
                    return;
                }
                DetectFaceLBP();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 用Haar级联分类器检测面部
        /// </summary>
        public void DetectFaceHaar()
        {
            try
            {
                using var classifierFace = new CascadeClassifier(HaarCasCade4FacePath);
                using var classifierEye = new CascadeClassifier(HaarCasCade4EyePath);

                using var imgGray = imgInput.Convert<Gray, byte>();
                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(0, 0, 255), 2);

                    imgGray.ROI = face;
                    Rectangle[] eyes = classifierEye.DetectMultiScale(imgGray, 1.1, 4);
                    foreach (var eye in eyes)
                    {
                        var e = eye;
                        e.X += face.X;
                        e.Y += face.Y;
                        imgInput.Draw(e, new Bgr(0, 255, 0), 2);
                    }
                }
                pictureBox1.Image = imgInput.AsBitmap();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 用LBP级联分类器检测面部
        /// </summary>
        public void DetectFaceLBP()
        {
            try
            {
                using var classifierFace = new CascadeClassifier(LBPCasCadePath);

                using var imgGray = imgInput.Convert<Gray, byte>();
                Rectangle[] faces = classifierFace.DetectMultiScale(imgGray, 1.1, 4);
                foreach (var face in faces)
                {
                    imgInput.Draw(face, new Bgr(255, 0, 2505), 2);
                }
                pictureBox1.Image = imgInput.AsBitmap();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

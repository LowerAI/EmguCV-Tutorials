// See https://aka.ms/new-console-template for more information
using Emgu.CV;
using Emgu.CV.Structure;

// p1:下载、安装和配置EmguCV
string fileName = "F:\\美女演示图0.png";
Image<Bgr,byte> imf = new Image<Bgr,byte>(fileName);
CvInvoke.Imshow("Image",imf);

CvInvoke.WaitKey(0);
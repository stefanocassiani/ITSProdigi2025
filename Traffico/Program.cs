using System.Data;
using Emgu.CV;
using System.Drawing.Imaging;
//MJPEGStream video = new MJPEGStream("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-28.mp4");

VideoCapture video = new VideoCapture("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-28.mp4");

//questo link si autogenera-e autoaggiorna. e siamo in una sandbox. che ci rende cose interessanti 
Mat sfondo = new Mat("");

Mat grigi = new Mat(, grigi, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
CvInvoke.CvtColor(grigi, immagine);
grigi.Save("grigio.jpg");





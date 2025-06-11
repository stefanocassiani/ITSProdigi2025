using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;

namespace CRM
{
    public partial class Sintetica : Form
    {
        public Sintetica()
        {
            InitializeComponent();
        }

        VideoCapture video = new VideoCapture("https://video.autostrade.it/video-mp4_hq/dt4/53c1cb2d-9a8d-4882-b3e5-dab0528ebe5d-29.mp4");


        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void PctBox_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreaSintetiche_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists("sintetiche"))
                Directory.CreateDirectory("sintetiche");

            Mat sfondo = new Mat();
            int i = 0;
            while (video.Grab())
            {
                Mat frame = new Mat();
                video.Retrieve(frame);
                CvInvoke.CvtColor(frame, frame, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);

                if (!sfondo.IsEmpty)
                {
                    Mat differenza = new Mat();
                    CvInvoke.AbsDiff(frame, sfondo, differenza);
                    CvInvoke.Threshold(differenza, differenza, TrkFiltro.Value, 255, Emgu.CV.CvEnum.ThresholdType.Otsu);
                    differenza
                        .ToBitmap()
                        .Save(
                            Path.Combine("sintetiche", $"f_{i}.jpg"),
                            ImageFormat.Jpeg
                        );
                }
                i++;
                sfondo = frame;
            }

        }

        private void BtnAnteprima_Click(object sender, EventArgs e)
        {

        }

        private void BtnScegliPercorso_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK) 
            {
                string percorsoFile = DlgApri.FileName; //TODO funzione che estrapola il path e lo salva.
            }
        }
    }
}

using System.Drawing.Imaging;
using System.Diagnostics;


namespace computerVision2
{
    public partial class Form1 : Form
    {
        private Image selezionata;
        private Bitmap sintetica;
        public Form1()
        {
            InitializeComponent();
        }


        private void BtnApri_Click(object sender, EventArgs e)
        {
            if (DlgApriFile.ShowDialog() == DialogResult.OK)
            {
                selezionata = Image.FromFile(DlgApriFile.FileName);
                PctPreview.Image = selezionata;
            }
        }

        private void BtnAnalizza_Click(object sender, EventArgs e)
        {
            Bitmap originale = (Bitmap)selezionata;
            sintetica = new Bitmap(originale.Width, originale.Height);
            for (int x = 0; x < originale.Size.Width; x++)
            {
                for (int y = 1; y < originale.Size.Height; y++)
                {
                    Color colore = originale.GetPixel(x, y);
                    float hue = colore.GetHue();
                    float lumiosita = colore.GetBrightness() * 100;
                    if (hue > TrkMinimo.Value && hue < TrkMassimo.Value && lumiosita < TrkLight.Value)
                    {
                        sintetica.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        sintetica.SetPixel(x, y, Color.Black);
                    }
                }
            }
            sintetica.Save("sintentica.jpg", ImageFormat.Jpeg);
            PctPreview.Image = sintetica;
        }


        private Bitmap Scomponi(Bitmap target)
        {
            Bitmap risultato = new Bitmap(target.Width, target.Height);

            int luminosita = TrkLight.Value;
            int hueMin = TrkMinimo.Value;
            int hueMax = TrkMassimo.Value;

            for (int x = 0; x < target.Width; x++)
            {
                for (int y = 0; y < target.Height; y++)
                {
                    Color casella = target.GetPixel(x, y);
                    float hue = casella.GetHue();

                    if (hue >= hueMin && hue <= hueMax)
                    {
                        risultato.SetPixel(x, y, Color.White);
                    }
                    else
                    {
                        risultato.SetPixel(x, y, Color.Black);
                    }
                }
            }
            return risultato;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PctPreview_Click(object sender, EventArgs e)
        {

        }

        private void BtnContorni_Click(object sender, EventArgs e)
        {
            if (sintetica == null)
            {
                MessageBox.Show("Sarà prima il caso che tu analizzi un'immagine");
                return;
            }

            Bitmap bordi = new Bitmap(sintetica.Width, sintetica.Height);

            for (int y = 1; y < sintetica.Height; y++)
            {
                for (int x = 1; x < sintetica.Width; x++)
                {
                    //delta = attuale - precedente
                    Color attuale = sintetica.GetPixel(x, y);

                    Color orizzontale = sintetica.GetPixel(x - 1 , y);  //Orizzontale
                    int deltaorizzontale = attuale.R - orizzontale.R; // Abs(-255 >> 0 >> 255) => (0 >> 255)
                    
                    Color verticale = sintetica.GetPixel(x , y - 1);  //Orizzontale
                    int deltaverticale = attuale.R - orizzontale.R;
                    if (deltaorizzontale != 0 || deltaverticale != 0)
                        bordi.SetPixel(x, y, Color.White);
                    else
                        bordi.SetPixel(x, y, Color.Black);
                }
            }
            PctPreview.Image = bordi;
        }
    }
}



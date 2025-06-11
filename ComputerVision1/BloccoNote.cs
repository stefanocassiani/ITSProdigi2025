using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerVision1
{
    public partial class BloccoNote : Form
    {

        public BloccoNote()
        {
            InitializeComponent();
        }

        private void BloccoNote_Load(object sender, EventArgs e)
        {

        }

        private void Nuovo_Click(object sender, EventArgs e)
        {
            TxtRisultato.Clear();
        }

        private void BtnApri_Click(object sender, EventArgs e)
        {
            if (DlgApri.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Hai scelto di aprire il file {DlgApri.FileName}!");
                if (DlgApri.FileName.EndsWith(".txt"))
                {
                    TxtRisultato.Text = File.ReadAllText(DlgApri.FileName);
                }
                else
                {
                    MessageBox.Show("Per favore, seleziona un file di testo (.txt).");
                }
            }
        }



        //private void BtnSalva_Click(object sender, EventArgs e)
        //{

        //    SaveFileDialog saveFileDialog = new();
        //}

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*"; // Set the filter for file types
                saveFileDialog.Title = "Salva il file";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the content of TxtRisultato to the selected file
                    File.WriteAllText(saveFileDialog.FileName, TxtRisultato.Text);
                    MessageBox.Show($"File salvato come {saveFileDialog.FileName}!");
                }
            }
        }


        // sfrutta il DialogREsult// di ritorno dal fattto che lutente ha premuto il  bottone. in piu hai anche                 //MessageBoxButtons;

        private void BloccoNote_FormClosing(object sender, FormClosingEventArgs e) // qui ti intrometto al click nella x e ti intrometti.
        {
            e.Cancel = true;

            var result = MessageBox.Show(
         "Vuoi salvare le modifiche prima di uscire?",
         "Conferma uscita",
         MessageBoxButtons.YesNoCancel,
         MessageBoxIcon.Question,
         MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                // User chose "Salva"
                BtnSalva_Click(null, null); // Call save method
                e.Cancel = false; // After saving, allow closing
            }
            else if (result == DialogResult.No)
            {
                // User chose "Non Salvare"
                e.Cancel = false; // Allow closing without saving
            }
            else if (result == DialogResult.Cancel)
            {
                // User chose "Annulla"
                e.Cancel = true; // Cancel closing
            }
        }

        private void DlgApri_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}

using CRM3.Strutture;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Linq;

namespace CRM3
{
    public partial class Form1 : Form
    {
        List<Contatto> contatti = new List<Contatto>();
        string filePath = "contatti.json";

        public Form1()
        {
            InitializeComponent();
            BtnCarica_Click(null, EventArgs.Empty);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var contatto = new Contatto
            {
                Nome = TxtNome.Text,
                Cognome = TxtCognome.Text,
                Email = TxtEmail.Text

            };

            contatti.Add(contatto);
            LstBox.Items.Add(contatto.ToString());

            TxtNome.Clear();
            TxtCognome.Clear();
            TxtEmail.Clear();

        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            string json =
                JsonSerializer.Serialize(contatti);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Contatti salvati con successo!");
        }

        public void BtnCarica_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                contatti = JsonSerializer.Deserialize<List<Contatto>>(json);

                LstBox.Items.Clear();
                foreach (var contatto in contatti)
                {
                    LstBox.Items.Add(contatto.ToString());
                }

                MessageBox.Show("Contatti caricati!");
            }
            else
            {
                MessageBox.Show("File non trovato!");
            }
        }

        private void BtnModifica_Click(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;
            if (index >= 0 && index < contatti.Count)
            {
                contatti[index].Nome = TxtNome.Text;
                contatti[index].Email = TxtEmail.Text;
                contatti[index].Cognome = TxtCognome.Text;

                // Aggiorna la lista visiva
                LstBox.Items[index] = $"{contatti[index].Nome} - {contatti[index].Email} - {contatti[index].Cognome}";

                MessageBox.Show("Contatto aggiornato!");
            }
            else
            {
                MessageBox.Show("Seleziona un contatto da modificare.");
            }
        }

        private void LstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;
            if (index >= 0 && index < contatti.Count)
            {
                var contatto = contatti[index];
                TxtNome.Text = contatto.Nome;
                TxtEmail.Text = contatto.Email;
                TxtCognome.Text = contatto.Cognome;
            }
        }

        private void BtnElimina_Click(object sender, EventArgs e)
        {
            int index = LstBox.SelectedIndex;
            if (index >= 0 && index < contatti.Count)
            {
                var result = MessageBox.Show("Sei sicuro di voler eliminare questo contatto?", "Conferma", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    contatti.RemoveAt(index);
                    LstBox.Items.RemoveAt(index);
                    TxtNome.Clear();
                    TxtCognome.Clear();
                    TxtEmail.Clear();
                    MessageBox.Show("Contatto eliminato!");
                }
            }
            else
            {
                MessageBox.Show("Seleziona un contatto da eliminare.");
            }
        }

        // TODO DELETE E MODIFICA



    }
}

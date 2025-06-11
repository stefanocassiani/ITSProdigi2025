using CRM.Strutture;


namespace CRM
{
    public partial class Form1 : Form
    {
        private readonly Database1 db;
        public Form1(Database1 bancaDati)
        {
            db = bancaDati;
            InitializeComponent();
            this.Load += Form1_Load;
            BtnAggiungi.Click += BtnAggiungi_Click; //Create
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            AggiornaListBox();
        }

        private void AggiornaListBox()
        {
            LstContatti.DataSource = null;
            LstContatti.DataSource = db.Contatti.ToList();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAggiungi_Click(object sender, EventArgs e)
        {
            var nuovo = new Contatto
            {
                Nome = TxtNome.Text.Trim(),
                Cognome = TxtCognome.Text.Trim(),
                Email = TxtEmail.Text.Trim(),
            };
            db.Contatti.Add(nuovo);
            AggiornaListBox();
            //SvuotaCampi(); 
        }

        private void BtnSalva_Click(object sender, EventArgs e)
        {
            LstContatti.Items.Clear();
            LstContatti.Items.Add("casa");
            //LstContatti.SelectedItem;
        }

        private void LeggiContatti() {
            TxtNome.Text = string.Empty;
            TxtCognome.Text = string.Empty;
            TxtEmail.Text = string.Empty;
        }
        private void RiempiListaContatti()
        {
            LstContatti.Items.Clear();
            var contatti = db.LeggiContatti();
            foreach (var contatto in contatti)
            {
                LstContatti.Items.Add(contatto);
            }
        }

    }
}

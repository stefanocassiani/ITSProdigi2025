namespace TerzaApp.Dati.Strutture
{
    class Prodotto
    {
        public int IdProdotto { get; set; } = 0;
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public double Prezzo { get; set; } = 0;
        public int IdCategoria { get; set; } = 0;
        public string Currency => $"{this.Prezzo:C2}";
        
        public override string ToString()
        {
            return Nome;
        }
    }
}

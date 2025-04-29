namespace TerzaApp.Dati.Strutture
{
    class Prodotto
    {
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public double Prezzo { get; set; } = 0;
        public Categoria? categoria { get; set; }
        public string Currency => $"{this.Prezzo:C2}";
        
        public override string ToString()
        {
            return Nome;
        }
    }
}

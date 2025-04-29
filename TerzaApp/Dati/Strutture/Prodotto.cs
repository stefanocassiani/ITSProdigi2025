namespace TerzaApp.Dati.Strutture
{
    public class Prodotto
    {
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public double Prezzo { get; set; } = 0;
        public string Currency => $"{this.Prezzo:C2}";
    }
}

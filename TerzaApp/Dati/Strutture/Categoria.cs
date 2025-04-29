namespace TerzaApp.Dati.Strutture
{
    public class Categoria
    {
        public string Nome { get; set; } = "";
        public string Descrizione { get; set; } = "";
        public DateTime Creazione { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return Nome;
        }
    }
}

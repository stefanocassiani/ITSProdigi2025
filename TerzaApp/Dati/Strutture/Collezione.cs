namespace TerzaApp.Dati.Strutture
{
    public class Collezione
    {
        public int IdCollezione { get; set; } = 0;
        public string Nome { get; set; } = "";
        public DateTime Creazione { get; set; } = DateTime.Now;
        public override string ToString()
        {
            return Nome;
        }
    }
}

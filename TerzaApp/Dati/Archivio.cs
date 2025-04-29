using System.Text.Json;
using TerzaApp.Dati.Strutture;

namespace TerzaApp.Dati
{
    public class Archivio
    {
        public List<Prodotto> prodotti { get; set; }

        public Archivio() {
            if (File.Exists("prodotti.json"))
            {
                string json = File.ReadAllText("prodotti.json");
                prodotti = JsonSerializer.Deserialize<List<Prodotto>>(json);
            }
            else
            {
                prodotti = new List<Prodotto>();
            }
        }

        public void Salva()
        {
            string json = JsonSerializer.Serialize(prodotti);
            File.WriteAllText("prodotti.json", json);
        }
    }
}

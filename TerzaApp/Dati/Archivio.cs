using System.Text.Json;
using TerzaApp.Dati.Strutture;

namespace TerzaApp.Dati
{
    public class Archivio
    {
        public List<Prodotto> prodotti { get; set; } = new List<Prodotto>();
        public List<Categoria> categorie { get; set; } = new List<Categoria>();

        public Archivio() {
            
        }

        public void Recupera()
        {
            if (File.Exists("archivio.json"))
            {
                string json = File.ReadAllText("archivio.json");
                Archivio vecchio = JsonSerializer.Deserialize<Archivio>(json);
                if (vecchio != null)
                {
                    this.prodotti = vecchio.prodotti;
                    this.categorie = vecchio.categorie;
                }
            }
        }

        public void Salva()
        {
            string json = JsonSerializer.Serialize(this);
            File.WriteAllText("archivio.json", json);
        }
    }
}

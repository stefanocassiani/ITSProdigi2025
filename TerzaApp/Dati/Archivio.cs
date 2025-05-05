using System.Text.Json;
using System.Text.Json.Serialization;
using TerzaApp.Dati.Strutture;

namespace TerzaApp.Dati
{
    class Archivio
    {
        public List<Prodotto> prodotti { get; set; } = new List<Prodotto>();
        public List<Categoria> categorie { get; set; } = new List<Categoria>();

        public Archivio() {
            
        }

        public void AddProdotto(Prodotto singolo)
        {
            foreach(Prodotto inDB in prodotti)
            {
                singolo.IdProdotto = Math.Max(singolo.IdProdotto, inDB.IdProdotto);
            }
            singolo.IdProdotto++;
            prodotti.Add(singolo);
        }

        public void AddCategoria(Categoria singola)
        {
            foreach (Categoria inDB in categorie)
            {
                singola.IdCategoria = Math.Max(singola.IdCategoria, inDB.IdCategoria);
            }
            singola.IdCategoria++;
            categorie.Add(singola);
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
            JsonSerializerOptions opzioni = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = JsonSerializer.Serialize(this, opzioni);
            File.WriteAllText("archivio.json", json);
        }
    }
}

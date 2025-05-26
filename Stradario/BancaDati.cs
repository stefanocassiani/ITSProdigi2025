using Microsoft.EntityFrameworkCore;
using Stradario.Strutture;

namespace Stradario
{
    /*
        dotnet tool install --global dotnet-ef
        dotnet ef
        dotnet ef migrations add Prima (...o Seconda...)
        dotnet ef database update
     */
    public class BancaDati : DbContext
    {
        public DbSet<Nodo> Nodi {  get; set; }
        public DbSet<Arco> Archi { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=mappa.sqlite");
            base.OnConfiguring(optionsBuilder);
        }

        public void TrovaPercorso(Nodo inizio, Nodo fine, List<Nodo> percorso, Nodo[] giàVisitati)
        {
            // 1) valutazione di riuscita o fallimento
            // 1.a) sono arrivato
            if(inizio == fine)
            {
                percorso.AddRange(giàVisitati);
                return;
            }
            // 1.b) sono arrivato secondo => deve essere lo stesso per tutti
            if(percorso.Count > 0)
            {
                return;
            }
            // 1.c) non ho più strade percorribili => ricordarmi dove sono passato, è un informazione solo mia
            uint[] prossimiPassi = Archi
                                    .Where(x => x.A == inizio.idNodo)
                                    .Select(x => x.B)
                                    .ToArray();
            List<Nodo> buoni = new List<Nodo>();
            foreach (uint potenziale in prossimiPassi)
            {
                if(!giàVisitati.Any(x => x.idNodo == potenziale))
                {
                    buoni.Add( Nodi.First(x => x.idNodo == potenziale) );
                }
            }
            if (buoni.Count == 0)
                return;

            // 2) mi sposto alla casella successiva
            Dictionary<Nodo, float> distanze = new Dictionary<Nodo, float>();
            foreach(Nodo inAnalisi in buoni)
            {
                distanze.Add(inAnalisi, inAnalisi.CalcolaDistanza(fine));
            }

            distanze = distanze.OrderBy(x => x.Value).ToDictionary();
            // 3) attivando i miei successori per prossimità al target
            foreach(KeyValuePair<Nodo, float> voce in distanze)
            {
                TrovaPercorso(voce.Key, fine, percorso, giàVisitati.Append(inizio).ToArray());
            }


        }

        public bool Importa(string percorsoMappa)
        {
            try
            {
                Nodi.RemoveRange(  Nodi );
                Archi.RemoveRange(  Archi );
                SaveChanges();
                string buffer = File.ReadAllText(percorsoMappa);
                string[] righe = buffer.Split('\n');
                foreach (string riga in righe)
                {
                    string[] celle = riga.Split('\t');
                    uint p1 = CreaNodo(celle[0]);
                    uint p2 = CreaNodo(celle[1]);
                    uint distanza = uint.Parse(celle[2]);
                    if (!Archi.Any(arc => arc.A == p1 && arc.B == p2))
                        Archi.Add(new Arco() { A = p1, B = p2, Distanza = distanza });
                    if (!Archi.Any(arc => arc.A == p2 && arc.B == p1))
                        Archi.Add(new Arco() { A = p2, B = p1, Distanza = distanza });
                }
                foreach (Nodo singolo in this.Nodi)
                {
                    Nominatim.RecuperaHTTP(singolo);
                }
                this.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        public uint CreaNodo(string nome)
        {
            Nodo? precedente = this.Nodi.FirstOrDefault( x => x.nome == nome );
            if (precedente != null)
                return precedente.idNodo;

            Nodo nuovo = new Nodo() { nome = nome };
            this.Nodi.Add(nuovo);
            this.SaveChanges();
            return nuovo.idNodo;
        }
    }
}

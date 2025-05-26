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

        public void TrovaPercorso(Nodo inizio, Nodo fine)
        {
            Dictionary<Nodo, float> distanze = new Dictionary<Nodo, float>();
            foreach(Nodo inAnalisi in Nodi)
            {
                distanze.Add(inAnalisi, inAnalisi.CalcolaDistanza(fine));
            }

            List<Nodo> giàVisitati = new List<Nodo>();

            foreach(Arco strada in Archi.Where(x => x.A == inizio.idNodo))
            {
                Nodo arrivo = Nodi.First(x => x.idNodo == strada.B);

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

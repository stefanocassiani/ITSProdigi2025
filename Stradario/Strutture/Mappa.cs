using System.Diagnostics.Contracts;

namespace Stradario.Strutture
{
    public class Mappa
    {
        public List<Nodo> Nodi { get; set; }
        public List<Arco> Archi { get; set; }

        public Mappa(string percorsoMappa)
        {
            string buffer = File.ReadAllText(percorsoMappa);
            string[] righe = buffer.Split('\n');
            foreach(string riga in righe)
            {
                string[] celle = riga.Split('\t');
                int p1 = CreaNodo(celle[0]);
                int p2 = CreaNodo(celle[1]);
                int distanza = int.Parse(celle[2]);
                if(!Archi.Any(arc => arc.A == p1 && arc.B == p2))
                    Archi.Add(new Arco() { A=p1, B=p2, Distanza=distanza });
                if(!Archi.Any(arc => arc.A == p2 && arc.B == p1))
                    Archi.Add(new Arco() { A=p2, B=p1, Distanza=distanza });
            }
        }

        public int CreaNodo(string nome)
        {
            if(Nodi.Any(n => n.nome == nome))
            {
                return Nodi.First(n => n.nome == nome).idNodo;
            } else
            {
                int nuovoId = 1;
                if(Nodi.Count > 0)
                {
                    nuovoId = Nodi.Last().idNodo + 1;
                }
                Nodi.Add(new Nodo() { idNodo=nuovoId, nome=nome });
                return nuovoId;
            }
        }
    }
}

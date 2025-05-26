using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    [Table("nodi")]
    public class Nodo : Sicurezza
    {
        [Key]
        public uint idNodo { get; set; }
        [Required]
        public string nome { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public override string ToString()
        {
            return this.nome;
        }

        public float CalcolaDistanza(Nodo target)
        {
            // calcolare la distanza tra i due nodi
            float deltaX = this.X - target.X;
            float deltaY = this.Y - target.Y;
            float distanza = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            return distanza;
        }
    }
}

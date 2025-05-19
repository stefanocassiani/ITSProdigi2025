using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    [Table("nodi")]
    public class Nodo : Sicurezza
    {
        [Key]
        public int idNodo { get; set; }
        [Required]
        public string nome { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
}

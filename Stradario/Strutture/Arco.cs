using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    [Table("archi")]
    public class Arco : Sicurezza
    {
        [Required]
        public int A { get; set; }
        [Required]
        public int B { get; set; }
        public int Distanza { get; set; } = 0;
    }
}

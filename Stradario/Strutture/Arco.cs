using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Stradario.Strutture
{
    [Table("archi")]
    public class Arco : Sicurezza
    {
        [Key]
        public int IdArco { get; set; }
        [Required]
        public uint A { get; set; }
        [Required]
        public uint B { get; set; }
        public uint Distanza { get; set; } = 0;
    }
}

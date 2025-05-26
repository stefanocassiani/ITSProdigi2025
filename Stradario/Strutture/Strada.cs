using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Stradario.Strutture
{
    [Table("strade")]
    public class Strada
    {
        [Key]
        public uint IdStrada { get; set; }
        [Required]
        public Nodo A { get; set; }
        [Required]
        public Nodo B { get; set; }
        public float Lunghezza => A.CalcolaDistanza(B);
        public override string ToString()
        {
            return $"{A.nome} > {B.nome} : {Lunghezza}";
        }
    }
}

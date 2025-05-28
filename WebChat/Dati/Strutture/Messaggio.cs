using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebChat.Dati.Strutture
{
    [Table("messaggi")]
    public class Messaggio
    {
        [Key]
        public uint IdMessaggio { get; set; }
        public Utente? Mittente { get; set; } = null;
        public Utente? Destinatario { get; set; } = null;
        [Required]
        public string Corpo { get; set; } = string.Empty;
        [Required]
        public DateTime Quando { get; set; } = DateTime.Now;
    }
}

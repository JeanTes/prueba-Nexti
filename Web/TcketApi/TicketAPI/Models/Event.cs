using System.ComponentModel.DataAnnotations;

namespace TicketAPI.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime FechaEvento { get; set; }

        [Required]
        [MaxLength(200)]
        public string Lugar { get; set; }

        [Required]
        public int NEntrada { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Descripcion { get; set; }

        [Required]
        public decimal Precio { get; set; }

        public bool IsDeleted { get; set; }
    }
}

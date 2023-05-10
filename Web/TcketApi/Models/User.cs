using System.ComponentModel.DataAnnotations;

namespace TcketApi.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Correo { get; set; }

        [MaxLength(10)]
        public string Telefono { get; set; }
    }
}

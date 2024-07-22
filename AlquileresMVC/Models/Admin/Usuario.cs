using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido1 { get; set; } = string.Empty;
        public string Apellido2 { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string DNI { get; set; } = string.Empty;
        public string carnetFechaExpedicion { get; set; } = string.Empty;
        public DateOnly FechaNacimiento { get; set; }
        public string Correo { get; set; } = string.Empty;
    }
}

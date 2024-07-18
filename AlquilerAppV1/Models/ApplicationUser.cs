using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AlquilerAppV1.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [MaxLength(55)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength (50)]
        public string Apellidos { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [MaxLength (150)]
        public string Direccion { get; set; }

        [MaxLength(50)]
        public string Ciudad { get; set; }

        [MaxLength(20)]
        public string Pais { get; set; }

        [MaxLength(20)]
        public string CodigoPostal { get; set; }
    }
}

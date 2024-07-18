using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerAppV1.Models
{
    public class Extra
    {
        [Key]
        public int ExtraId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerAppV1.Models
{
    public class Vehiculo
    {
        [Key]
        public int VehiculoId { get; set; }

        [Required]
        [StringLength(50)]
        public string Provincia { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [Required]
        [MaxLength(10)]
        public string Matricula { get; set; }

        [Required]
        [MaxLength(20)]
        public string Color { get; set; }


        public int ExtraId { get; set; }
        public int MarcaId { get; set; }

        [MaxLength(200)]
        public string Image { get; set; }

        public Extra Extra { get; set; }
        public Marca Marca { get; set; }
        public ICollection<Pedido> Pedidos { get; set; }
    }
}

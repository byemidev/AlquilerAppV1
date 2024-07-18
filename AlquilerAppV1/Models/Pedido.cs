using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquilerAppV1.Models
{
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        public DateTime FechaRecogida { get; set; }
        public DateTime FechaEntrega { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioTotal { get; set; }

        [Required]
        [MaxLength(50)]
        public string MetodoPago { get; set; }


        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(20)]
        public string EstatusPedido { get; set; }

        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }

    }
}

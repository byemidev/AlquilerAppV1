using System.ComponentModel.DataAnnotations;

namespace AlquilerAppV1.Models
{
    public class Marca
    {
        [Key]
        public int MarcaId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(200)]
        public string Logo { get; set; }


        public int ModeloId { get; set; }

        public Modelo Modelo { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}

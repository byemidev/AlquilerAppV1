using System.ComponentModel.DataAnnotations;

namespace AlquilerAppV1.Models
{
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(70)]
        public string Apellidos { get; set; }

        [Required]
        [MaxLength(20)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(10)]
        public string Dni { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public bool EsNovel { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int Puntos { get; set; }
        public string Nivel {  get; set; }


        public ICollection<Pedido> Pedidos { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AlquileresMVC.Models {
    public class Vehiculo {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string? modelo { get; set; }
        public string? marca { get; set; }
        public string? descripcion { get; set; }
        public double? precioDia { get; set; }
        public int reservaId { get; set; }

        [ForeignKey(nameof(reservaId))]
        public Reserva reserva { get; set; }
    }
}
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;



namespace AlquileresMVC.Models {
    public class Extra {
        [Key]
        public int Id { get; set;}
        public int reservaId { get; set;}
        public string descripcion { get; set; }

        [ForeignKey(nameof(reservaId))]
        public Reserva reserva { get; set; }
    }
}
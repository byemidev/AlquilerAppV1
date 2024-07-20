namespace AlquileresMVC.Models {
    public class MetodoPago {
        [Key]
        public int id { get; set;}
        public int reservaId { get; set;}
        public string nombre { get; set; }

        [ForeignKey(nameof(reservaId))]
        public Reserva reserva { get; set; }
    }
}
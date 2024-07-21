using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class ReservaExtras
    {
        [ForeignKey("reserva")]
        public int FKIdReserva { get; set; }
        public Reserva reserva { get; set; }

        [ForeignKey("extra")]
        public int FKIdExtra { get; set; }
        public Extras extra { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class ReservaExtras
    {
        public int FKreservaId { get; set; }
        [ForeignKey(nameof(FKreservaId))]
        public Reserva reserva { get; set; }

        public int FKextraId { get; set; }
        [ForeignKey(nameof(FKextraId))]
        public Extra extra { get; set; }
    }
}

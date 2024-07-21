using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservaId { get; set; }
        public DateOnly FechaEntrada { get; set; }

        public DateOnly FechaSalida { get; set; }

        [ForeignKey("usuario")]
        public int FKIdUsuario { get; set; }
       
        public Usuario usuario { get; set; }

        [ForeignKey("vehiculo")]
        public int FKIdVehiculo { get; set; }

        public Vehiculo vehiculo { get; set; }

        public virtual List<ReservaExtras> ExtrasReserva { get; set; } = new List<ReservaExtras>();


    }
}

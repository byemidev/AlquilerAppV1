using Microsoft.Build.ObjectModelRemoting;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateOnly FechaEntrada { get; set; }

        public DateOnly FechaSalida { get; set; }
        
        public int FKusuarioId { get; set; }
       
        [ForeignKey(nameof(FKusuarioId))]
        public Usuario usuario { get; set; }

        
        public int FKvehiculoId { get; set; }
        [ForeignKey(nameof(FKvehiculoId))]
        public Vehiculo vehiculo { get; set; }

        public int FKmetodoId { get; set; }

        [ForeignKey(nameof(FKmetodoId))]
        public MetodoPago metodo { get; set; }


        public virtual List<ReservaExtras> ExtrasReserva { get; set; } = new List<ReservaExtras>();

    }
}

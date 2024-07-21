using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AlquileresMVC.Models {
    public class Reserva {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}

        public DateOnly incio { get; set; }

        public DateOnly fin { get; set; }

        public int idCliente { get; set;} 

        [ForeignKey(nameof(idCliente))]
        public Usuario usuario { get; set; }

        public int getID(){ //por si necesito recoger el id sin tener que llamar a DAO
            return this.Id;
        }

        public DateOnly getFinReserva (){ //por si necesito recuperar sin llamar desde DAO para JavaScript la fecha del objeto
            return this.fin;
        }
    }
}
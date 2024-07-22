using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlquileresMVC.Models.Admin
{
    public class Extra
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;        
        public string Descripcion { get; set; } = string.Empty;
        public int Precio { get; set; }
        public virtual List<ReservaExtras> OrderExtras { get; set; } = new List<ReservaExtras>();

    }
}

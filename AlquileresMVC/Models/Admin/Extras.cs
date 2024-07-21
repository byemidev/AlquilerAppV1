using System.ComponentModel.DataAnnotations;

namespace AlquileresMVC.Models.Admin
{
    public class Extras
    {
        [Key]
        public int ExtraId { get; set; }
        public string Nombre { get; set; } = string.Empty;        
        public string Descripcion { get; set; } = string.Empty;
        public int Precio { get; set; }
        public virtual List<ReservaExtras> OrderExtras { get; set; } = new List<ReservaExtras>();

        
    }
}

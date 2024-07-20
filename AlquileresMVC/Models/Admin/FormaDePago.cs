using System.ComponentModel.DataAnnotations;

namespace AlquileresMVC.Models.Admin
{
    public class FormaDePago
    {
        [Key]
        public int FormaDePagoId { get; set; }
        public int reservaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}

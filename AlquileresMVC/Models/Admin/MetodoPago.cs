using System.ComponentModel.DataAnnotations;

namespace AlquileresMVC.Models.Admin
{
    public class MetodoPago
    {
        [Key]
        public int Id { get; set; }
        public int reservaId { get; set; }
        public string Nombre { get; set; } = string.Empty;
    }
}

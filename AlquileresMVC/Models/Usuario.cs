using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace AlquileresMVC.Models
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string? nombre { get; set; } 
        public string? apellido1 { get; set; } 
        public string? apellido2 { get; set; } 
        public string? dir { get; set; } 
        public int? edad { get; set; } 
        public string? correo { get; set; }
        public string? phone { get; set; }
        public string? nif { get; set;}
        public string? carnetFechaExpedicion { get; set;}
    }
}

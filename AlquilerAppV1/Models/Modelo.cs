using System.ComponentModel.DataAnnotations;

namespace AlquilerAppV1.Models
{
    public class Modelo
    {
        [Key]
        public int ModeloId { get; set; }
        public int Puertas { get; set; }
        public int Asientos { get; set; }
        public bool AireAcondicionado { get; set; }
        public bool EsManual { get; set; }

        [Required]
        [MaxLength(25)]
        public string TipoConbustible { get; set; }

        public ICollection<Marca> Marcas { get; set; }

    }
}

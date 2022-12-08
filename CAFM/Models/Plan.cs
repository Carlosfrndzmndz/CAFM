using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public int Precio { get; set; }
        [Required]
        public DateTime FechaAlta { get; set; }
        [Required]
        public DateTime FechaBaja { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

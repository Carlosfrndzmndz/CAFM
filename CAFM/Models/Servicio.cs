using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Servicio
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

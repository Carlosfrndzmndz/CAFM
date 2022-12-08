using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class ServiciosPlan
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdPlan { get; set; }
        [Required]
        public int IdServicio { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

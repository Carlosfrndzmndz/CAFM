using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class RolesUsuario
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

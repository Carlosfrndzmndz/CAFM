using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAFM.Models
{
    public class PermisosRol
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdRol { get; set; }
        [Required]
        public int IdPermiso { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

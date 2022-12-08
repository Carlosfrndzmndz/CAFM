using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Permiso
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(20)]
        public string Nombre { get; set; }
        [Required][StringLength(50)]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

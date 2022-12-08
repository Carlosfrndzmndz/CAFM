using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Rol
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(25)]
        public string Nombre { get; set; }
        [Required][StringLength(80)]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

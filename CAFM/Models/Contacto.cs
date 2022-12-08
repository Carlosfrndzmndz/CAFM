using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required][StringLength(50)]
        public string Apellido { get; set; }
        [Required][StringLength(80)]
        public string Email { get; set; }
        [Required][StringLength(20)]
        public string Telefono { get; set; }
        [Required][StringLength(20)]
        public string Celular { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

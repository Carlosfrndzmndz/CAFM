using System.ComponentModel.DataAnnotations;

namespace CAFM.Models.Dtos
{
    public class UsuarioDto_cs
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo apellido es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo apellido no puede tener más de 50 caracteres.")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El campo email es obligatorio.")]
        [MaxLength(80, ErrorMessage = "El campo email no puede tener más de 80 caracteres.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo password es obligatorio.")]
        [MaxLength(20, ErrorMessage = "El campo password no puede tener más de 20 caracteres.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "El campo rol es obligatorio.")]
        public int RolId { get; set; }
    }
}

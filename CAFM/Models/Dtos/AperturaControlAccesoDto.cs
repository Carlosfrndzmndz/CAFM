using System.ComponentModel.DataAnnotations;

namespace CAFM.Models.Dtos
{
    public class AperturaControlAccesoDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo nombre no puede tener más de 50 caracteres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo nombre no puede tener más de 50 caracteres.")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public bool Activo { get; set; }
    }
}

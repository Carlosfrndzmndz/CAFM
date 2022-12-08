using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class ReconocimientoControlAcceso
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(50)]
        public string Nombre { get; set; }
        [Required][StringLength(80)]
        public string Descripcion { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

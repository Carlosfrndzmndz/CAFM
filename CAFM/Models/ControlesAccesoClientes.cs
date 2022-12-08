using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class ControlesAccesoClientes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdReconocimiento { get; set; }
        [Required]
        public int IdApertura { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

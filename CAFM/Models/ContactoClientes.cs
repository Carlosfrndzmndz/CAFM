using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class ContactoClientes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdCliente { get; set; }
        [Required]
        public int IdContacto { get; set; }
        [Required][StringLength(50)]
        public string Cargo { get; set; }
        [Required]
        public bool Activo { get; set; }
    }
}

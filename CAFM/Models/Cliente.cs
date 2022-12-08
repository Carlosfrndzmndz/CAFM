using System;
using System.ComponentModel.DataAnnotations;

namespace CAFM.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(255)]
        public string RazonSocial { get; set; }
        [Required][StringLength(255)]
        public string Nombre { get; set; }
        [Required][StringLength(80)]
        public string Codigo { get; set; }
        [Required]
        public bool Activo { get; set; }
        [Required]
        public bool Abonado { get; set; }
        [Required]
        public int IdModalidad { get; set; }
        [Required]
        public DateTime FechaVencAbono { get; set; }
        [Required]
        public DateTime FechaAlta { get; set; }
        [Required]
        public DateTime FechaBaja { get; set; }
        [Required]
        public string Cuit { get; set; }
        [Required]
        public DateTime FechaVencCertFact { get; set; }
        [Required]
        public int PuntoDeVenta { get; set; }
        [Required]
        public string CertificadoNombre { get; set; }
        [Required]
        public string CertificadoPassword { get; set; }
    }
}

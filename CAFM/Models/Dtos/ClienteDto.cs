using System.ComponentModel.DataAnnotations;

namespace CAFM.Models.Dtos
{
    public class ClienteDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Razon Social es obligatorio.")]
        [MaxLength(255, ErrorMessage = "El campo Razon Social no puede tener más de 255 caracteres.")]
        public string RazonSocial { get; set; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        [MaxLength(80, ErrorMessage = "El campo nombre no puede tener más de 80 caracteres.")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "El campo código es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo código no puede tener más de 50 caracteres.")]
        public string Codigo { get; set; }
        [Required(ErrorMessage = "El campo país es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo país no puede tener más de 50 caracteres.")]
        public string Pais { get; set; }
        [Required(ErrorMessage = "El campo provincia es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo provincia no puede tener más de 50 caracteres.")]
        public string Provincia { get; set; }
        [Required(ErrorMessage = "El campo localidad es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo localidad no puede tener más de 50 caracteres.")]
        public string Localidad { get; set; }
        [Required(ErrorMessage = "El campo dirección es obligatorio.")]
        [MaxLength(50, ErrorMessage = "El campo dirección no puede tener más de 50 caracteres.")]
        public string Direccion { get; set; }
        [Required(ErrorMessage = "El campo IdPlan es obligatorio.")]
        public int IdPlan { get; set; }
        [Required(ErrorMessage = "El campo Activo es obligatorio.")]
        public bool Activo { get; set; }
        [Required(ErrorMessage = "El campo Abonado es obligatorio.")]
        public bool Abonado { get; set; }
        [Required(ErrorMessage = "El campo IdModalidad es obligatorio.")]
        public int IdModalidad { get; set; }
        [Required(ErrorMessage = "El campo FechaVencAbono es obligatorio.")]
        public DateTime FechaVencAbono { get; set; }
        [Required(ErrorMessage = "El campo FechaAlta es obligatorio.")]
        public DateTime FechaAlta { get; set; }
        [Required(ErrorMessage = "El campo FechaBaja es obligatorio.")]
        public DateTime FechaBaja { get; set; }
        [Required(ErrorMessage = "El campo Cuit es obligatorio.")]
        public string Cuit { get; set; }
        [Required(ErrorMessage = "El campo FechaVencCertFact es obligatorio.")]
        public DateTime FechaVencCertFact { get; set; }
        [Required(ErrorMessage = "El campo PuntoDeVenta es obligatorio.")]
        public int PuntoDeVenta { get; set; }
        [Required(ErrorMessage = "El campo CertificadoNombre es obligatorio.")]
        public string CertificadoNombre { get; set; }
        [Required(ErrorMessage = "El campo CertificadoPassword es obligatorio.")]
        public string CertificadoPassword { get; set; }
    }
}

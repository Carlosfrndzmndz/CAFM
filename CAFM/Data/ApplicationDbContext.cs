using CAFM.Models;
using Microsoft.EntityFrameworkCore;

namespace CAFM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<AperturaControlAcceso> AperturaControlAcceso { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<ContactoClientes> ContactoClientes { get; set; }
        public DbSet<ControlesAccesoClientes> ControlesAccesoClientes { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<PermisosRol> PermisosRol { get; set; }
        public DbSet<Plan> Plan { get; set; }
        public DbSet<ReconocimientoControlAcceso> ReconocimientoControlAcceso { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<RolesUsuario> RolesUsuario { get; set; }
        public DbSet<Servicio> Servicio { get; set; }
        public DbSet<ServiciosPlan> ServiciosPlan { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        
    }
}

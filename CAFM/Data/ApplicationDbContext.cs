using CAFM.Models;
using Microsoft.EntityFrameworkCore;

namespace CAFM.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<PermisosRol> PermisosRol { get; set; }
        public DbSet<RolesUsuario> RolesUsuario { get; set; }
        public DbSet<Permiso> Permiso { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
    }
}

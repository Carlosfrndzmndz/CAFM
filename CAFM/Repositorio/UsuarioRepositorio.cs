using CAFM.Data;
using CAFM.Models;
using CAFM.Repositorio.IRepositorio;

namespace CAFM.Repositorio
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly ApplicationDbContext _bd;

        public UsuarioRepositorio(ApplicationDbContext bd)
        {
            _bd = bd;
        } 
        public bool Actualizar(Usuario usuario)
        {
            _bd.Usuario.Update(usuario);
            return Guardar();
        }

        public bool Borrar(Usuario usuario)
        {
            _bd.Usuario.Remove(usuario);
            return Guardar();
        }

        public bool Crear(Usuario usuario)
        {
            _bd.Usuario.Add(usuario);
            return Guardar();
        }

        public bool Existe(string email)
        {
            return _bd.Usuario.Any(u => u.Email.ToLower().Trim() == email.ToLower().Trim());
        }

        public bool Existe(int id)
        {
            return _bd.Usuario.Any(u => u.Id == id);
        }

        public bool Guardar()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }

        public Usuario Obtener(int id)
        {
            return _bd.Usuario.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<Usuario> ObtenerTodos()
        {
            return _bd.Usuario.OrderBy(u => u.Nombre).ToList();
        }
    }
}

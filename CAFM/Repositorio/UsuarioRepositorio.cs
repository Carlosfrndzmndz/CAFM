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
        public bool UpdateUsuario(Usuario usuario)
        {
            _bd.Usuario.Update(usuario);
            return SaveUsuario();
        }

        public bool DeleteUsuario(Usuario usuario)
        {
            _bd.Usuario.Remove(usuario);
            return SaveUsuario();
        }

        public bool CreateUsuario(Usuario usuario)
        {
            _bd.Usuario.Add(usuario);
            return SaveUsuario();
        }

        public bool ExistUsuario(string email)
        {
            return _bd.Usuario.Any(u => u.Email.ToLower().Trim() == email.ToLower().Trim());
        }

        public bool ExistUsuario(int id)
        {
            return _bd.Usuario.Any(u => u.Id == id);
        }

        public bool SaveUsuario()
        {
            return _bd.SaveChanges() >= 0 ? true : false;
        }

        public Usuario GetUsuario(int id)
        {
            return _bd.Usuario.FirstOrDefault(u => u.Id == id);
        }

        public ICollection<Usuario> GetUsuarios()
        {
            return _bd.Usuario.OrderBy(u => u.Nombre).ToList();
        }
    }
}

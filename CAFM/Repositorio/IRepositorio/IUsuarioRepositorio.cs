using CAFM.Models;

namespace CAFM.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        bool CreateUsuario(Usuario usuario);
        bool UpdateUsuario(Usuario usuario);
        bool DeleteUsuario(Usuario usuario);
        Usuario GetUsuario(int id);
        ICollection<Usuario> GetUsuario();
        bool ExistUsuario(string email);
        bool ExistUsuario(int id);
        bool SaveUsuario();
    }
}

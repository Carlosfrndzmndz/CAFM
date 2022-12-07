using CAFM.Models;

namespace CAFM.Repositorio.IRepositorio
{
    public interface IUsuarioRepositorio
    {
        bool Crear(Usuario usuario);
        bool Actualizar(Usuario usuario);
        bool Borrar(Usuario usuario);
        Usuario Obtener(int id);
        ICollection<Usuario> ObtenerTodos();
        bool Existe(string email);
        bool Existe(int id);
        bool Guardar();
    }
}

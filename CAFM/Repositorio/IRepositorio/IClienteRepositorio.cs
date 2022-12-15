using CAFM.Models;

namespace CAFM.Repositorio.IRepositorio
{
    public interface IClienteRepositorio
    {
        bool CreateCliente(Cliente cliente);
        bool UpdateCliente(Cliente cliente);
        bool DeleteCliente(Cliente cliente);
        Cliente GetCliente(int id);
        Cliente GetCliente(string codigo);
        ICollection<Cliente> GetCliente();
        bool ExistCliente(string codigo);
        bool ExistCliente(int id);
        bool SaveCliente();
    }
}

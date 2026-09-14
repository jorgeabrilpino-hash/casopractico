using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface IClienteService
{
    Task<IEnumerable<Cliente>> GetAll();
    Task<Cliente?> GetById(int id);
    Task Post(Cliente cliente);
    Task Put(Cliente cliente);
    Task Delete(int id);
}
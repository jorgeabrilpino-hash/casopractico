using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface IMesaService
{
    Task<IEnumerable<Mesa>> GetAll();
    Task<Mesa?> GetById(int id);
    Task Post(Mesa mesa);
    Task Put(Mesa mesa);
    Task Delete(int id);
}
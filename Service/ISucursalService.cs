using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface ISucursalService
{
    Task<IEnumerable<Sucursal>> GetAll();
    Task<Sucursal?> GetById(int id);
    Task Post(Sucursal sucursal);
    Task Put(Sucursal sucursal);
    Task Delete(int id);
}
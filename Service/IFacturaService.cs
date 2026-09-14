using CasoPractico01.Models;

namespace CasoPractico01.Service.Implementacion;

public interface IFacturaService
{
    Task<IEnumerable<Factura>> GetAll();
    Task<Factura?> GetById(int id);
    Task Post(Factura factura);
    Task Put(Factura factura);
    Task Delete(int id);
}
using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface IPedidoService
{
    Task<IEnumerable<Pedido>> GetAll();
    Task<Pedido?> GetById(int id);
    Task Post(Pedido pedido);
    Task Put(Pedido pedido);
    Task Delete(int id);
}
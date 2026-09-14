using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface IReservaService
{
    Task<IEnumerable<Reserva>> GetAll();
    Task<Reserva?> GetById(int id);
    Task Post(Reserva reserva);
    Task Put(Reserva reserva);
    Task Delete(int id);
}
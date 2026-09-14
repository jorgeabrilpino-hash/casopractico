using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class ReservaService : IReservaService
{
    private readonly IUnitOfWork _unitOfWork;

    public ReservaService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Reserva>> GetAll()
    {
        return await _unitOfWork.Reserva.GetAll();
    }

    public async Task<Reserva?> GetById(int id)
    {
        return await _unitOfWork.Reserva.GetById(id);
    }

    public async Task Post(Reserva reserva)
    {
        await _unitOfWork.Reserva.Post(reserva);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Reserva reserva)
    {
        _unitOfWork.Reserva.Put(reserva);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var reserva = await _unitOfWork.Reserva.GetById(id);
        if (reserva != null)
        {
            _unitOfWork.Reserva.Delete(reserva);
            await _unitOfWork.Guardar();
        }
    }
}
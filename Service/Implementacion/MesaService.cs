using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class MesaService : IMesaService
{
    private readonly IUnitOfWork _unitOfWork;

    public MesaService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Mesa>> GetAll()
    {
        return await _unitOfWork.Mesa.GetAll();
    }

    public async Task<Mesa?> GetById(int id)
    {
        return await _unitOfWork.Mesa.GetById(id);
    }
    public async Task Post(Mesa mesa)
    {
        await _unitOfWork.Mesa.Post(mesa);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Mesa mesa)
    {
        _unitOfWork.Mesa.Put(mesa);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var mesa = await _unitOfWork.Mesa.GetById(id);

        if (mesa != null)
        {
            _unitOfWork.Mesa.Delete(mesa);
            await _unitOfWork.Guardar();
        }
    }
}
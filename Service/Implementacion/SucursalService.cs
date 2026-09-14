using CasoPractico01.Models;
using CasoPractico01.Repository;
using CasoPractico01.Service;


namespace CasoPractico01.Services.Implementations;

public class SucursalService : ISucursalService
{
    private readonly IUnitOfWork _unitOfWork;

    public SucursalService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Sucursal>> GetAll()
    {
        return await _unitOfWork.Sucursal.GetAll();
    }

    public async Task<Sucursal?> GetById(int id)
    {
        return await _unitOfWork.Sucursal.GetById(id);
    }

    public async Task Post(Sucursal sucursal)
    {
        await _unitOfWork.Sucursal.Post(sucursal);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Sucursal sucursal)
    {
        _unitOfWork.Sucursal.Put(sucursal);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var sucursal = await _unitOfWork.Sucursal.GetById(id);

        if (sucursal != null)
        {
            _unitOfWork.Sucursal.Delete(sucursal);
            await _unitOfWork.Guardar();
        }
    }
}
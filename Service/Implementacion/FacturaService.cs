using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class FacturaService : IFacturaService
{
    private readonly IUnitOfWork _unitOfWork;

    public FacturaService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Factura>> GetAll()
    {
        return await _unitOfWork.Factura.GetAll();
    }

    public async Task<Factura?> GetById(int id)
    {
        return await _unitOfWork.Factura.GetById(id);
    }

    public async Task Post(Factura factura)
    {
        await _unitOfWork.Factura.Post(factura);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Factura factura)
    {
        _unitOfWork.Factura.Put(factura);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var factura = await _unitOfWork.Factura.GetById(id);

        if (factura != null)
        {
            _unitOfWork.Factura.Delete(factura);
            await _unitOfWork.Guardar();
        }
    }
}
using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class PedidoService : IPedidoService
{
    private readonly IUnitOfWork _unitOfWork;
    public PedidoService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Pedido>> GetAll()
    {
        return await _unitOfWork.Pedido.GetAll();
    }

    public async Task<Pedido?> GetById(int id)
    {
        return await _unitOfWork.Pedido.GetById(id);
    }
    public async Task Post(Pedido pedido)
    {
        await _unitOfWork.Pedido.Post(pedido);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Pedido pedido)
    {
        _unitOfWork.Pedido.Put(pedido);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var pedido = await _unitOfWork.Pedido.GetById(id);

        if (pedido != null)
        {
            _unitOfWork.Pedido.Delete(pedido);
            await _unitOfWork.Guardar();
        }
    }
}
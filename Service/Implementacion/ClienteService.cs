using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class ClienteService : IClienteService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClienteService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Cliente>> GetAll()
    {
        return await _unitOfWork.Cliente.GetAll();
    }

    public async Task<Cliente?> GetById(int id)
    {
        return await _unitOfWork.Cliente.GetById(id);
    }

    public async Task Post(Cliente cliente)
    {
        await _unitOfWork.Cliente.Post(cliente);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Cliente cliente)
    {
        _unitOfWork.Cliente.Put(cliente);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var cliente = await _unitOfWork.Cliente.GetById(id);

        if (cliente != null)
        {
            _unitOfWork.Cliente.Delete(cliente);
            await _unitOfWork.Guardar();
        }
    }
}
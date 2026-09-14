using CasoPractico01.Models;
using CasoPractico01.Repository;

namespace CasoPractico01.Service.Implementacion;

public class IngredienteService : IIngredienteService
{
    private readonly IUnitOfWork _unitOfWork;

    public IngredienteService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Ingrediente>> GetAll()
    {
        return await _unitOfWork.Ingrediente.GetAll();
    }
    public async Task<Ingrediente?> GetById(int id)
    {
        return await _unitOfWork.Ingrediente.GetById(id);
    }

    public async Task Post(Ingrediente ingrediente)
    {
        await _unitOfWork.Ingrediente.Post(ingrediente);
        await _unitOfWork.Guardar();
    }

    public async Task Put(Ingrediente ingrediente)
    {
        _unitOfWork.Ingrediente.Put(ingrediente);
        await _unitOfWork.Guardar();
    }

    public async Task Delete(int id)
    {
        var ingrediente = await _unitOfWork.Ingrediente.GetById(id);
        if (ingrediente != null)
        {
            _unitOfWork.Ingrediente.Delete(ingrediente);
            await _unitOfWork.Guardar();
        }
    }
}
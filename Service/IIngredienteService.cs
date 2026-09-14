using CasoPractico01.Models;

namespace CasoPractico01.Service;

public interface IIngredienteService
{
    Task<IEnumerable<Ingrediente>> GetAll();
    Task<Ingrediente?> GetById(int id);
    Task Post(Ingrediente ingrediente);
    Task Put(Ingrediente ingrediente);
    Task Delete(int id);
}
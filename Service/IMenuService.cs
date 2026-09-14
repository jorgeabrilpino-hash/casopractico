using CasoPractico01.Models;

namespace CasoPractico01.Service.Implementacion;

public interface IMenuService
{
    Task<IEnumerable<Menu>> GetAll();
    Task<Menu?> GetById(int id);
    Task Post(Menu menu);
    Task Put(Menu menu);
    Task Delete(int id);
}
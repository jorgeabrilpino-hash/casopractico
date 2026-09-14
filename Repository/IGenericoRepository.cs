using System.Linq.Expressions;

namespace CasoPractico01.Repository;

public interface IGenericoRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAll();

    Task<T?> GetById(int id);

    Task Post(T entidad);

    void Put(T entidad);

    void Delete(T entidad);
}
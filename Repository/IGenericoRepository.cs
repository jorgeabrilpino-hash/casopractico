using System.Linq.Expressions;

namespace CasoPractico01.Repository;

public interface IGenericoRepository
{
    public interface IGenerico<T> where T : class
    {
        Task<IEnumerable<T>> ObtenerTodos();

        Task<T?> ObtenerPorId(int id);

        Task<IEnumerable<T>> Buscar(
            Expression<Func<T, bool>> condicion);

        Task Agregar(T entidad);

        void Actualizar(T entidad);

        void Eliminar(T entidad);
    }
}
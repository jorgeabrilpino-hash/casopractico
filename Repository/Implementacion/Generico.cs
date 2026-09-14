using CasoPractico01.Data;
using Microsoft.EntityFrameworkCore;

namespace CasoPractico01.Repository.Implementacion
{
    public class Generico<T> : IGenericoRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Generico(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Post(T entidad)
        {
            await _dbSet.AddAsync(entidad);
        }

        public void Put(T entidad)
        {
            _dbSet.Update(entidad);
        }

        public void Delete(T entidad)
        {
            _dbSet.Remove(entidad);
        }
    }
}
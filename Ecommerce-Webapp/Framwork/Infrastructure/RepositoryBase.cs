using ECS.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECS.Framework.Infrastructure
{
    public abstract class RepositoryBase<TKey, T> : IRepositoryBase<TKey, T> where T : class
    {
        private readonly DbContext _context;

        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public async Task Create(T entity)
        {
            await _context.AddAsync<T>(entity);
        }

        public async Task<bool> Exist(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetAsync(TKey id)
        {
            return await _context.FindAsync<T>(id);
        }

        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }
    }
}

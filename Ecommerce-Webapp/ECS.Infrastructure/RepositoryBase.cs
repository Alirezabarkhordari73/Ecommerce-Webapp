using ECS.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ECS.Infrastructure
{
    public class RepositoryBase<TKEY, T> : IRepositoryBase<TKEY, T> where T : class
    {
        private readonly DbContext _context;
        
        public RepositoryBase(DbContext context)
        {
            _context = context;
        }

        public void Create(T entity)
        {
            _context.Add(entity);
        }

        public bool Exist(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Any(expression);
        }

        public T Get(TKEY id)
        {
           return _context.Find<T>(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}

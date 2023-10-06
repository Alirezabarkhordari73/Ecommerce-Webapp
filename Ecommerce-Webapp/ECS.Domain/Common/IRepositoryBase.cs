using System.Linq.Expressions;

namespace ECS.Domain.Common
{
    public interface IRepositoryBase<TKey,T> where T : class
    {
        Task<T> GetAsync(TKey id);
        Task<IEnumerable<T>> GetAllAsync();
        Task Create(T entity);
        Task<bool> Exist(Expression<Func<T,bool>>expression);
        Task SaveChanges();

    }
}

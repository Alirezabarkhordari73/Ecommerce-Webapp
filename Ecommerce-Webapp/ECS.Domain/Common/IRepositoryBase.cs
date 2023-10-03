using System.Linq.Expressions;

namespace ECS.Domain.Common
{
    public interface IRepositoryBase<TKey,T> where T : class
    {
        T Get(TKey id);
        IEnumerable<T> GetAll();
        void Create(T entity);
        bool Exist(Expression<Func<T,bool>>expression);
        void SaveChanges();

    }
}

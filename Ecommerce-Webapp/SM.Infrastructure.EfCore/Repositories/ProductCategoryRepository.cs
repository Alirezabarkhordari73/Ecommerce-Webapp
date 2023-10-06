using ECS.Domain.ShopManagement.ProductCategoryAgg;
using ECS.Framework.Infrastructure;

namespace SM.Infrastructure.EfCore.Repositories
{
    public class ProductCategoryRepository : RepositoryBase<int , ProductCategory> , IProductCategoryRepository
    {
    }
}

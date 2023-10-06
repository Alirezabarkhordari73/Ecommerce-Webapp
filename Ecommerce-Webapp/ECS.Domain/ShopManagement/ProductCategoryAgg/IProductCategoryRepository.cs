using ECS.Domain.Common;

namespace ECS.Domain.ShopManagement.ProductCategoryAgg
{
    public interface IProductCategoryRepository : IRepositoryBase<long,ProductCategory>  
    {
        EditProductCategoryDto GetDetails(long id);
        List<ShowProductCategoryDto> Search(SearchProductCategoryDto searchModel);
    }
}

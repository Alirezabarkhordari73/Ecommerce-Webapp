using ECS.Domain.ShopManagement.ProductCategoryAgg;
using ECS.Framework.Application;

namespace ShopManagementApplicationContracts.ProductCategory
{
    public interface IProductCategoryApplication
    {
        OperationResults Create(CreateProductCategoryDto productCategoryDto);
        OperationResults Edit(EditProductCategoryDto productCategoryDto);
        List<ShowProductCategoryDto> Search(SearchProductCategoryDto searchProductCategoryDto);
        EditProductCategoryDto GetDetails(long id);
    }
}

using ECS.Domain.ShopManagement.ProductCategoryAgg;
using ECS.Framework.Application;
using ShopManagementApplicationContracts.ProductCategory;

namespace ShopManagementApplication 
{
    public class ProductCategoryApplication : IProductCategoryApplication
    {
        private readonly IProductCategoryRepository _productCategoryRepository;

        public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
        {
            _productCategoryRepository = productCategoryRepository;
        }

        public OperationResults Create(CreateProductCategoryDto productCategoryDto)
        {

        }

        public OperationResults Edit(EditProductCategoryDto productCategoryDto)
        {
            throw new NotImplementedException();
        }

        public ProductCategory GetDetails(long id)
        {
            throw new NotImplementedException();
        }

        public List<ShowProductCategoryDto> Search(SearchProductCategoryDto searchProductCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}

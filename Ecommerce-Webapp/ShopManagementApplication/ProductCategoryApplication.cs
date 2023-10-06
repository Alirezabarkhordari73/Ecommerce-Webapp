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
            var operations = new OperationResults();

            if(_productCategoryRepository.Exist(x => x.Name == productCategoryDto.Name).Result) 
            {
                return operations.Failed(OperationsMessages.DuplicatedRecord);
            }

            var Slug = productCategoryDto.Slug.Slugify();

            var productCategory = new ProductCategory() 
            {
                Name = productCategoryDto.Name,
                Description = productCategoryDto.Description,
                Keyword = productCategoryDto.Keyword,
                Picture = productCategoryDto.Picture,
                PictureAlt = productCategoryDto.PictureAlt,
                PictureTitle = productCategoryDto.PictureTitle,
                Slug = Slug
            };

            _productCategoryRepository.Create(productCategory);
            _productCategoryRepository.SaveChanges();

            return operations.Succedded();
        }

        public OperationResults Edit(EditProductCategoryDto productCategoryDto)
        {
            var operations = new OperationResults();

            var productCategory = _productCategoryRepository.GetAsync(productCategoryDto.Id).Result;
            if (productCategory == null) 
            {
                operations.Failed(OperationsMessages.RecordNotFound);
            }

            var Slug = productCategoryDto.Slug.Slugify();

            productCategory.Name = productCategoryDto.Name;
            productCategory.Description = productCategoryDto.Description;
            productCategory.Keyword = productCategoryDto.Keyword;
            productCategory.Picture = productCategoryDto.Picture;
            productCategory.PictureAlt = productCategoryDto.PictureAlt;
            productCategory.PictureTitle = productCategoryDto.PictureTitle;
            productCategory.Slug = Slug;

            return operations.Succedded();
        }

        public EditProductCategoryDto GetDetails(long id)
        {
            return _productCategoryRepository.GetDetails(id);
        }

        public List<ShowProductCategoryDto> Search(SearchProductCategoryDto searchProductCategoryDto)
        {
            return _productCategoryRepository.Search(searchProductCategoryDto);
        }
    }
}

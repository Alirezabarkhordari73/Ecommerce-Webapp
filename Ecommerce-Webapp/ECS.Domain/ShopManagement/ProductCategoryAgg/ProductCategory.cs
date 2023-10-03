using ECS.Domain.Common;

namespace ECS.Domain.ShopManagement.ProductCategoryAgg
{
    public class ProductCategory : EntityBase
    {
        public string Name { get;  set; }
        public string? Description { get; set; }
        public string? Keyword { get; set; }
        public string? Picture { get; set; }
        public string? PictureAlt { get; set; }
        public string? PictureTitle { get; set; }
        public string? Slug { get; set; }

        public ProductCategory()
        {           
        }
    }    
}

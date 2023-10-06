namespace ShopManagementApplicationContracts.ProductCategory
{  
    public class CreateProductCategoryDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Keyword { get; set; }
        public string Picture { get; set; }
        public string PictureAlt { get; set; }
        public string PictureTitle { get; set; }
        public string Slug { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class EditProductCategoryDto : CreateProductCategoryDto
    {
        public long Id { get; set; }
    }

    public class ShowProductCategoryDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string CreationDate { get; set; }
    }

    public class SearchProductCategoryDto
    {
        public string Name { get; set; }
    }
}

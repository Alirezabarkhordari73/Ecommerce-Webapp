using ECS.Domain.ShopManagement.ProductCategoryAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace SM.Infrastructure.EfCore.Mapping
{
    public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.ToTable("ProductCategories");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name).HasMaxLength(255).IsUnicode().IsRequired();
            builder.Property(x => x.Description).HasMaxLength(500).IsUnicode();
            builder.Property(x => x.Picture).HasMaxLength(1000);
            builder.Property(x => x.PictureAlt).HasMaxLength(255);
            builder.Property(x => x.PictureTitle).HasMaxLength(500);
            builder.Property(x => x.Keyword).HasMaxLength(80).IsUnicode().IsRequired();
            builder.Property(x => x.Slug).HasMaxLength(300).IsUnicode().IsRequired();
            builder.HasQueryFilter(x => !x.IsDeleted);       
        }
    }
}

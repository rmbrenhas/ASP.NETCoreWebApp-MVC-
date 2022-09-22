using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using POSWEBMVC.Models;

namespace POSWEBMVC.EntitiesConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(t => t.CategoryID);
            builder.Property(p => p.Name).HasMaxLength(100).IsRequired();

            //builder.HasData(
            //    new Category(1, "Material Escolar"),
            //    new Category(2, "Eletrónicos"),
            //    new Category(3, "Acessórios"));
        }
    }
}

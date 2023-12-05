using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.DAL.Configurations
{
    public class ProductConfigs : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(c => c.ProductName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(c => c.Price).IsRequired();
            builder.Property(c => c.Amount).IsRequired();

            builder.HasOne<Category>(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(c => c.CategoryId);
        }
    }
}

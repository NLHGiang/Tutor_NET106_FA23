using Microsoft.EntityFrameworkCore;
using Tutor_NET106.DAL.Configurations;
using Tutor_NET106.DAL.Models;

namespace Tutor_NET106.DAL.ApplicationDbContext
{
    partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MSI\\SQLExpress;Database=Tutor_NET106;User Id=GiangNLH;Password=giang123@;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfigs());
            modelBuilder.ApplyConfiguration(new ProductConfigs());

            SeedingData(modelBuilder);
        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }

        void SeedingData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                    Name = "Cate 1"
                }
                );
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Pro 1",
                    Price = 1000.500f,
                    Amount = 100,
                    CategoryId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ProductName = "Pro 2",
                    Price = 2000.500f,
                    Amount = 200,
                    CategoryId = Guid.Parse("a0191258-172c-42ea-81b9-c71cd98b047b"),
                }
                );
        }
    }
}

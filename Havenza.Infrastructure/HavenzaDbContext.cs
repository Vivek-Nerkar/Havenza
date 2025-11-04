using Havenza.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace Havenza.Infrastructure
{
    public class HavenzaDbContext : DbContext
    {
        public HavenzaDbContext(DbContextOptions<HavenzaDbContext> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed demo categories for development/testing
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Furniture" },
                new Category { Id = 2, Name = "Decor" },
                new Category { Id = 3, Name = "Lighting" },
                new Category { Id = 4, Name = "Textiles" },
                new Category { Id = 5, Name = "Living Decor" }
                );

            // Seed demo products (each Product points to a Category)
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Luxury Sofa",
                    Description = "Elegant, comfortable sofa for your living room.",
                    Price = 1250.00m,
                    CategoryId = 1,
                    ImageUrl = "~/images/luxury_sofa.jpg",
                    Stock = 5
                },
                new Product
                {
                    Id = 2,
                    Name = "Modern Table Lamp",
                    Description = "Warm lighting with elegant design.",
                    Price = 120.00m,
                    CategoryId = 2,
                    ImageUrl = "images/lamp.jpg",
                    Stock = 50
                }
            );
        }
    }
}

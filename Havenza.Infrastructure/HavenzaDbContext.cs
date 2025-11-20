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
            // The full product seed data for MockDataService (or DbContext if you were using one)

            modelBuilder.Entity<Product>().HasData(
                // --------------------------------------------------------------------------
                // 1. FURNITURE (CategoryId = 1) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    ProductId = 1,
                    Name = "Mid-Century Walnut Sofa",
                    CategoryId = 1,
                    Price = 1299.99m,
                    Stock = 5,
                    //Rating = 4.8M,
                    Description = "A timeless three-seater sofa with a solid walnut base and linen-blend fabric. Perfect for modern living rooms.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/2.png"
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Round Marble Dining Table",
                    CategoryId = 1,
                    Price = 749.50m,
                    Stock = 3,
                    //Rating = 4.5M,
                    Description = "Compact 4-seater dining table with a genuine white marble top and sleek black metal legs.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/3.png"
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Linen Upholstered Bed Frame",
                    CategoryId = 1,
                    Price = 899.00m,
                    Stock = 7,
                    //Rating = 4.9M,
                    Description = "Queen-sized bed with a high, tufted headboard, upholstered in a light beige, durable linen fabric.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/4.png"
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Minimalist Office Desk",
                    CategoryId = 1,
                    Price = 345.99m,
                    Stock = 12,
                    //Rating = 4.3M,
                    Description = "Simple and robust writing desk with two drawers, designed for a clean and focused workspace.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/5.png"
                },
                new Product
                {
                    ProductId = 5,
                    Name = "Modular Storage Cabinet",
                    CategoryId = 1,
                    Price = 520.00m,
                    Stock = 6,
                    //Rating = 4.6M,
                    Description = "Versatile storage unit with adjustable shelves, finished in a matte dark gray lacquer.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/6.png"
                },

                // 2. DECOR (CategoryId = 2) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    ProductId = 6,
                    Name = "Abstract Canvas Wall Art",
                    CategoryId = 2,
                    Price = 119.99m,
                    Stock = 15,
                    //Rating = 4.7M,
                    Description = "Large, hand-painted abstract canvas piece with muted blue and warm tan tones.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/7.png"
                },
                new Product
                {
                    ProductId = 7,
                    Name = "Curved Metal Floor Mirror",
                    CategoryId = 2,
                    Price = 185.00m,
                    Stock = 8,
                    //Rating = 4.6M,
                    Description = "Full-length standing mirror with a thin, brass-finished curved metal frame.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/8.png"
                },
                new Product
                {
                    ProductId = 8,
                    Name = "Set of 5 Minimalist Photo Frames",
                    CategoryId = 2,
                    Price = 45.99m,
                    Stock = 20,
                    //Rating = 4.4M,
                    Description = "A collection of five mixed-size frames (3x5, 4x6, 5x7) with natural oak finish and shatter-proof glass. Perfect for creating a gallery wall.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/9.png"
                },
                new Product
                {
                    ProductId = 9,
                    Name = "Minimalist Wooden Clock",
                    CategoryId = 2,
                    Price = 59.50m,
                    Stock = 18,
                    //Rating = 4.8M,
                    Description = "Silent wall clock featuring an unfinished wood face and simple black hands.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/10.png"
                },
                new Product
                {
                    ProductId = 10,
                    Name = "Transparent Glass Vase",
                    CategoryId = 2,
                    Price = 35.00m,
                    Stock = 30,
                    //Rating = 4.5M,
                    Description = "Hand-blown glass vase with a subtle transparent texture, perfect for fresh flowers or as a standalone piece.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/11.png"
                },

                // --------------------------------------------------------------------------
                // 3. LIGHTING (CategoryId = 3) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    ProductId = 11,
                    Name = "Industrial Black Pendant Light",
                    CategoryId = 3,
                    Price = 95.00m,
                    Stock = 10,
                    //Rating = 4.7M,
                    Description = "Single-bulb ceiling pendant with a matte black metal cage design, adjustable cord length.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/12.png"
                },
                new Product
                {
                    ProductId = 12,
                    Name = "Brass & Linen Table Lamp",
                    CategoryId = 3,
                    Price = 65.99m,
                    Stock = 15,
                    //Rating = 4.8M,
                    Description = "A classic table lamp featuring a solid brass base and a soft, white linen drum shade.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/13.png"
                },
                new Product
                {
                    ProductId = 13,
                    Name = "Arched Reading Floor Lamp",
                    CategoryId = 3,
                    Price = 130.00m,
                    Stock = 9,
                    //Rating = 4.5M,
                    Description = "Tall, arched floor lamp designed to hang over a sofa or chair for optimal reading light.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/14.png"
                },
                new Product
                {
                    ProductId = 14,
                    Name = "Minimalist LED Strip Light",
                    CategoryId = 3,
                    Price = 45.00m,
                    Stock = 25,
                    //Rating = 4.3M,
                    Description = "Under-cabinet or shelf-mounted LED light strip for subtle accent illumination.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/15.png"
                },
                new Product
                {
                    ProductId = 15,
                    Name = "Crystal Cluster Chandelier",
                    CategoryId = 3,
                    Price = 499.99m,
                    Stock = 4,
                    //Rating = 4.9M,
                    Description = "Elegant chandelier with cascading crystal clusters, perfect for dining rooms or entryways.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/16.png"
                },

                // 4. TEXTILES (CategoryId = 4) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    ProductId = 16,
                    Name = "Hand-Woven Wool Rug (8'x10')",
                    CategoryId = 4,
                    Price = 399.00m,
                    Stock = 7,
                    //Rating = 4.8M,
                    Description = "Large area rug made of ethically sourced wool with a subtle geometric pattern in neutral tones.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/17.png"
                },
                new Product
                {
                    ProductId = 17,
                    Name = "Chunky Knit Throw Blanket",
                    CategoryId = 4,
                    Price = 85.00m,
                    Stock = 22,
                    //Rating = 4.9M,
                    Description = "Ultra-soft acrylic throw blanket with a thick, chunky knit texture, perfect for cozy evenings.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/18.png"
                },
                new Product
                {
                    ProductId = 18,
                    Name = "Set of 2 Velvet Cushion Covers",
                    CategoryId = 4,
                    Price = 29.99m,
                    Stock = 35,
                    //Rating = 4.5M,
                    Description = "Pair of luxurious velvet cushion covers (18x18 inches) in a deep forest green.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/19.png"
                },
                new Product
                {
                    ProductId = 19,
                    Name = "Blackout Linen Curtains",
                    CategoryId = 4,
                    Price = 55.00m,
                    Stock = 14,
                    //Rating = 4.6M,
                    Description = "Single panel linen curtains with a full blackout lining, 84 inches long.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/20.png"
                },
                new Product
                {
                    ProductId = 20,
                    Name = "Egyptian Cotton Duvet Cover Set",
                    CategoryId = 4,
                    Price = 110.00m,
                    Stock = 11,
                    //Rating = 4.7M,
                    Description = "Queen size duvet cover and sham set made from ultra-soft 600-thread count Egyptian cotton.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/21.png"
                },

                // 5. LIVING DECOR (CategoryId = 5) - 5 Products (Plants/Pots Focus)
                // --------------------------------------------------------------------------
                new Product
                {
                    ProductId = 21,
                    Name = "Large Fiddle-Leaf Fig (Faux)",
                    CategoryId = 5,
                    Price = 159.99m,
                    Stock = 9,
                    //Rating = 4.9M,
                    Description = "A realistic, high-quality faux fiddle-leaf fig tree (6 ft tall), perfect for low-light spaces.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/22.png"
                },
                new Product
                {
                    ProductId = 22,
                    Name = "Geometric Ceramic Planter",
                    CategoryId = 5,
                    Price = 29.00m,
                    Stock = 40,
                    //Rating = 4.6M,
                    Description = "Modern white ceramic planter with a geometric diamond texture, suitable for 6-inch plants.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/23.png"
                },
                new Product
                {
                    ProductId = 23,
                    Name = "Hanging Macrame Plant Holder",
                    CategoryId = 5,
                    Price = 19.50m,
                    Stock = 50,
                    //Rating = 4.5M,
                    Description = "Hand-knotted macrame hanger made from natural cotton rope for small to medium pots.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/24.png"
                },
                new Product
                {
                    ProductId = 24,
                    Name = "Succulent Terrariums",
                    CategoryId = 5,
                    Price = 75.00m,
                    Stock = 18,
                    //Rating = 4.7M,
                    Description = "Low-maintenance succulent gardens in glass terrariums.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/25.png"
                },
                new Product
                {
                    ProductId = 25,
                    Name = "Tall Metal Plant Stand",
                    CategoryId = 5,
                    Price = 49.99m,
                    Stock = 16,
                    //Rating = 4.4M,
                    Description = "Sleek, black powder-coated metal stand, elevating plants to better catch light.",
                    ImageUrl = "Havenza.Web/Havenza.Web/wwwroot/images/products/26.png"
                }
            );
        }
    }
}

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
                    Id = 001,
                    Name = "Mid-Century Walnut Sofa",
                    CategoryId = 1,
                    Price = 1299.99M,
                    Stock = 5,
                    //Rating = 4.8M,
                    Description = "A timeless three-seater sofa with a solid walnut base and linen-blend fabric. Perfect for modern living rooms.",
                    ImageUrl = "https://placehold.co/600x400/E2A16F/FFF?text=Walnut+Sofa"
                },
                new Product
                {
                    Id = 002,
                    Name = "Round Marble Dining Table",
                    CategoryId = 1,
                    Price = 749.50M,
                    Stock = 3,
                    //Rating = 4.5M,
                    Description = "Compact 4-seater dining table with a genuine white marble top and sleek black metal legs.",
                    ImageUrl = "https://placehold.co/600x400/E2A16F/FFF?text=Marble+Table"
                },
                new Product
                {
                    Id = 003,
                    Name = "Linen Upholstered Bed Frame",
                    CategoryId = 1,
                    Price = 899.00M,
                    Stock = 7,
                    //Rating = 4.9M,
                    Description = "Queen-sized bed with a high, tufted headboard, upholstered in a light beige, durable linen fabric.",
                    ImageUrl = "https://placehold.co/600x400/E2A16F/FFF?text=Linen+Bed"
                },
                new Product
                {
                    Id = 004,
                    Name = "Minimalist Office Desk",
                    CategoryId = 1,
                    Price = 345.99M,
                    Stock = 12,
                    //Rating = 4.3M,
                    Description = "Simple and robust writing desk with two drawers, designed for a clean and focused workspace.",
                    ImageUrl = "https://placehold.co/600x400/E2A16F/FFF?text=Office+Desk"
                },
                new Product
                {
                    Id = 005,
                    Name = "Modular Storage Cabinet",
                    CategoryId = 1,
                    Price = 520.00M,
                    Stock = 6,
                    //Rating = 4.6M,
                    Description = "Versatile storage unit with adjustable shelves, finished in a matte dark gray lacquer.",
                    ImageUrl = "https://placehold.co/600x400/E2A16F/FFF?text=Storage+Cabinet"
                },

                // 2. DECOR (CategoryId = 2) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    Id = 006,
                    Name = "Abstract Canvas Wall Art",
                    CategoryId = 2,
                    Price = 119.99M,
                    Stock = 15,
                    //Rating = 4.7M,
                    Description = "Large, hand-painted abstract canvas piece with muted blue and warm tan tones.",
                    ImageUrl = "https://placehold.co/600x400/86B0BD/FFF?text=Abstract+Art"
                },
                new Product
                {
                    Id = 007,
                    Name = "Curved Metal Floor Mirror",
                    CategoryId = 2,
                    Price = 185.00M,
                    Stock = 8,
                    //Rating = 4.6M,
                    Description = "Full-length standing mirror with a thin, brass-finished curved metal frame.",
                    ImageUrl = "https://placehold.co/600x400/86B0BD/FFF?text=Floor+Mirror"
                },
                new Product
                {
                    Id = 008,
                    Name = "Set of 5 Minimalist Photo Frames",
                    CategoryId = 2,
                    Price = 45.99M,
                    Stock = 20,
                    //Rating = 4.4M,
                    Description = "A collection of five mixed-size frames (3x5, 4x6, 5x7) with natural oak finish and shatter-proof glass. Perfect for creating a gallery wall.",
                    ImageUrl = "https://placehold.co/600x400/86B0BD/FFF?text=Sculptures"
                },
                new Product
                {
                    Id = 009,
                    Name = "Minimalist Wooden Clock",
                    CategoryId = 2,
                    Price = 59.50M,
                    Stock = 18,
                    //Rating = 4.8M,
                    Description = "Silent wall clock featuring an unfinished wood face and simple black hands.",
                    ImageUrl = "https://placehold.co/600x400/86B0BD/FFF?text=Wood+Clock"
                },
                new Product
                {
                    Id = 010,
                    Name = "Transparent Glass Vase",
                    CategoryId = 2,
                    Price = 35.00M,
                    Stock = 30,
                    //Rating = 4.5M,
                    Description = "Hand-blown glass vase with a subtle transparent texture, perfect for fresh flowers or as a standalone piece.",
                    ImageUrl = "https://placehold.co/600x400/86B0BD/FFF?text=Glass+Vase"
                },

                // --------------------------------------------------------------------------
                // 3. LIGHTING (CategoryId = 3) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    Id = 011,
                    Name = "Industrial Black Pendant Light",
                    CategoryId = 3,
                    Price = 95.00M,
                    Stock = 10,
                    //Rating = 4.7M,
                    Description = "Single-bulb ceiling pendant with a matte black metal cage design, adjustable cord length.",
                    ImageUrl = "https://placehold.co/600x400/2C2C2C/FFF?text=Pendant+Light"
                },
                new Product
                {
                    Id = 012,
                    Name = "Brass & Linen Table Lamp",
                    CategoryId = 3,
                    Price = 65.99M,
                    Stock = 15,
                    //Rating = 4.8M,
                    Description = "A classic table lamp featuring a solid brass base and a soft, white linen drum shade.",
                    ImageUrl = "https://placehold.co/600x400/2C2C2C/FFF?text=Table+Lamp"
                },
                new Product
                {
                    Id = 013,
                    Name = "Arched Reading Floor Lamp",
                    CategoryId = 3,
                    Price = 130.00M,
                    Stock = 9,
                    //Rating = 4.5M,
                    Description = "Tall, arched floor lamp designed to hang over a sofa or chair for optimal reading light.",
                    ImageUrl = "https://placehold.co/600x400/2C2C2C/FFF?text=Floor+Lamp"
                },
                new Product
                {
                    Id = 014,
                    Name = "Minimalist LED Strip Light",
                    CategoryId = 3,
                    Price = 45.00M,
                    Stock = 25,
                    //Rating = 4.3M,
                    Description = "Under-cabinet or shelf-mounted LED light strip for subtle accent illumination.",
                    ImageUrl = "https://placehold.co/600x400/2C2C2C/FFF?text=LED+Strip"
                },
                new Product
                {
                    Id = 015,
                    Name = "Crystal Cluster Chandelier",
                    CategoryId = 3,
                    Price = 499.99M,
                    Stock = 4,
                    //Rating = 4.9M,
                    Description = "Elegant chandelier with cascading crystal clusters, perfect for dining rooms or entryways.",
                    ImageUrl = "https://placehold.co/600x400/2C2C2C/FFF?text=Chandelier"
                },

                // 4. TEXTILES (CategoryId = 4) - 5 Products
                // --------------------------------------------------------------------------
                new Product
                {
                    Id = 016,
                    Name = "Hand-Woven Wool Rug (8'x10')",
                    CategoryId = 4,
                    Price = 399.00M,
                    Stock = 7,
                    //Rating = 4.8M,
                    Description = "Large area rug made of ethically sourced wool with a subtle geometric pattern in neutral tones.",
                    ImageUrl = "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Wool+Rug"
                },
                new Product
                {
                    Id = 017,
                    Name = "Chunky Knit Throw Blanket",
                    CategoryId = 4,
                    Price = 85.00M,
                    Stock = 22,
                    //Rating = 4.9M,
                    Description = "Ultra-soft acrylic throw blanket with a thick, chunky knit texture, perfect for cozy evenings.",
                    ImageUrl = "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Knit+Throw"
                },
                new Product
                {
                    Id = 018,
                    Name = "Set of 2 Velvet Cushion Covers",
                    CategoryId = 4,
                    Price = 29.99M,
                    Stock = 35,
                    //Rating = 4.5M,
                    Description = "Pair of luxurious velvet cushion covers (18x18 inches) in a deep forest green.",
                    ImageUrl = "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Velvet+Cushions"
                },
                new Product
                {
                    Id = 019,
                    Name = "Blackout Linen Curtains",
                    CategoryId = 4,
                    Price = 55.00M,
                    Stock = 14,
                    //Rating = 4.6M,
                    Description = "Single panel linen curtains with a full blackout lining, 84 inches long.",
                    ImageUrl = "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Linen+Curtains"
                },
                new Product
                {
                    Id = 020,
                    Name = "Egyptian Cotton Duvet Cover Set",
                    CategoryId = 4,
                    Price = 110.00M,
                    Stock = 11,
                    //Rating = 4.7M,
                    Description = "Queen size duvet cover and sham set made from ultra-soft 600-thread count Egyptian cotton.",
                    ImageUrl = "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Duvet+Set"
                },

                // 5. LIVING DECOR (CategoryId = 5) - 5 Products (Plants/Pots Focus)
                // --------------------------------------------------------------------------
                new Product
                {
                    Id = 021,
                    Name = "Large Fiddle-Leaf Fig (Faux)",
                    CategoryId = 5,
                    Price = 159.99M,
                    Stock = 9,
                    //Rating = 4.9M,
                    Description = "A realistic, high-quality faux fiddle-leaf fig tree (6 ft tall), perfect for low-light spaces.",
                    ImageUrl = "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Fiddle+Leaf"
                },
                new Product
                {
                    Id = 022,
                    Name = "Geometric Ceramic Planter",
                    CategoryId = 5,
                    Price = 29.00M,
                    Stock = 40,
                    //Rating = 4.6M,
                    Description = "Modern white ceramic planter with a geometric diamond texture, suitable for 6-inch plants.",
                    ImageUrl = "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Planter"
                },
                new Product
                {
                    Id = 023,
                    Name = "Hanging Macrame Plant Holder",
                    CategoryId = 5,
                    Price = 19.50M,
                    Stock = 50,
                    //Rating = 4.5M,
                    Description = "Hand-knotted macrame hanger made from natural cotton rope for small to medium pots.",
                    ImageUrl = "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Macrame"
                },
                new Product
                {
                    Id = 024,
                    Name = "Succulent Terrariums",
                    CategoryId = 5,
                    Price = 75.00M,
                    Stock = 18,
                    //Rating = 4.7M,
                    Description = "Low-maintenance succulent gardens in glass terrariums.",
                    ImageUrl = "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Terrariums"
                },
                new Product
                {
                    Id = 025,
                    Name = "Tall Metal Plant Stand",
                    CategoryId = 5,
                    Price = 49.99M,
                    Stock = 16,
                    //Rating = 4.4M,
                    Description = "Sleek, black powder-coated metal stand, elevating plants to better catch light.",
                    ImageUrl = "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Plant+Stand"
                }
            );
        }
    }
}

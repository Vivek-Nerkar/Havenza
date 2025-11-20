using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Havenza.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Furniture" },
                    { 2, "Decor" },
                    { 3, "Lighting" },
                    { 4, "Textiles" },
                    { 5, "Living Decor" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "A timeless three-seater sofa with a solid walnut base and linen-blend fabric. Perfect for modern living rooms.", "Havenza.Web/Havenza.Web/wwwroot/images/products/2.png", "Mid-Century Walnut Sofa", 1299.99m, 5 },
                    { 2, 1, "Compact 4-seater dining table with a genuine white marble top and sleek black metal legs.", "Havenza.Web/Havenza.Web/wwwroot/images/products/3.png", "Round Marble Dining Table", 749.50m, 3 },
                    { 3, 1, "Queen-sized bed with a high, tufted headboard, upholstered in a light beige, durable linen fabric.", "Havenza.Web/Havenza.Web/wwwroot/images/products/4.png", "Linen Upholstered Bed Frame", 899.00m, 7 },
                    { 4, 1, "Simple and robust writing desk with two drawers, designed for a clean and focused workspace.", "Havenza.Web/Havenza.Web/wwwroot/images/products/5.png", "Minimalist Office Desk", 345.99m, 12 },
                    { 5, 1, "Versatile storage unit with adjustable shelves, finished in a matte dark gray lacquer.", "Havenza.Web/Havenza.Web/wwwroot/images/products/6.png", "Modular Storage Cabinet", 520.00m, 6 },
                    { 6, 2, "Large, hand-painted abstract canvas piece with muted blue and warm tan tones.", "Havenza.Web/Havenza.Web/wwwroot/images/products/7.png", "Abstract Canvas Wall Art", 119.99m, 15 },
                    { 7, 2, "Full-length standing mirror with a thin, brass-finished curved metal frame.", "Havenza.Web/Havenza.Web/wwwroot/images/products/8.png", "Curved Metal Floor Mirror", 185.00m, 8 },
                    { 8, 2, "A collection of five mixed-size frames (3x5, 4x6, 5x7) with natural oak finish and shatter-proof glass. Perfect for creating a gallery wall.", "Havenza.Web/Havenza.Web/wwwroot/images/products/9.png", "Set of 5 Minimalist Photo Frames", 45.99m, 20 },
                    { 9, 2, "Silent wall clock featuring an unfinished wood face and simple black hands.", "Havenza.Web/Havenza.Web/wwwroot/images/products/10.png", "Minimalist Wooden Clock", 59.50m, 18 },
                    { 10, 2, "Hand-blown glass vase with a subtle transparent texture, perfect for fresh flowers or as a standalone piece.", "Havenza.Web/Havenza.Web/wwwroot/images/products/11.png", "Transparent Glass Vase", 35.00m, 30 },
                    { 11, 3, "Single-bulb ceiling pendant with a matte black metal cage design, adjustable cord length.", "Havenza.Web/Havenza.Web/wwwroot/images/products/12.png", "Industrial Black Pendant Light", 95.00m, 10 },
                    { 12, 3, "A classic table lamp featuring a solid brass base and a soft, white linen drum shade.", "Havenza.Web/Havenza.Web/wwwroot/images/products/13.png", "Brass & Linen Table Lamp", 65.99m, 15 },
                    { 13, 3, "Tall, arched floor lamp designed to hang over a sofa or chair for optimal reading light.", "Havenza.Web/Havenza.Web/wwwroot/images/products/14.png", "Arched Reading Floor Lamp", 130.00m, 9 },
                    { 14, 3, "Under-cabinet or shelf-mounted LED light strip for subtle accent illumination.", "Havenza.Web/Havenza.Web/wwwroot/images/products/15.png", "Minimalist LED Strip Light", 45.00m, 25 },
                    { 15, 3, "Elegant chandelier with cascading crystal clusters, perfect for dining rooms or entryways.", "Havenza.Web/Havenza.Web/wwwroot/images/products/16.png", "Crystal Cluster Chandelier", 499.99m, 4 },
                    { 16, 4, "Large area rug made of ethically sourced wool with a subtle geometric pattern in neutral tones.", "Havenza.Web/Havenza.Web/wwwroot/images/products/17.png", "Hand-Woven Wool Rug (8'x10')", 399.00m, 7 },
                    { 17, 4, "Ultra-soft acrylic throw blanket with a thick, chunky knit texture, perfect for cozy evenings.", "Havenza.Web/Havenza.Web/wwwroot/images/products/18.png", "Chunky Knit Throw Blanket", 85.00m, 22 },
                    { 18, 4, "Pair of luxurious velvet cushion covers (18x18 inches) in a deep forest green.", "Havenza.Web/Havenza.Web/wwwroot/images/products/19.png", "Set of 2 Velvet Cushion Covers", 29.99m, 35 },
                    { 19, 4, "Single panel linen curtains with a full blackout lining, 84 inches long.", "Havenza.Web/Havenza.Web/wwwroot/images/products/20.png", "Blackout Linen Curtains", 55.00m, 14 },
                    { 20, 4, "Queen size duvet cover and sham set made from ultra-soft 600-thread count Egyptian cotton.", "Havenza.Web/Havenza.Web/wwwroot/images/products/21.png", "Egyptian Cotton Duvet Cover Set", 110.00m, 11 },
                    { 21, 5, "A realistic, high-quality faux fiddle-leaf fig tree (6 ft tall), perfect for low-light spaces.", "Havenza.Web/Havenza.Web/wwwroot/images/products/22.png", "Large Fiddle-Leaf Fig (Faux)", 159.99m, 9 },
                    { 22, 5, "Modern white ceramic planter with a geometric diamond texture, suitable for 6-inch plants.", "Havenza.Web/Havenza.Web/wwwroot/images/products/23.png", "Geometric Ceramic Planter", 29.00m, 40 },
                    { 23, 5, "Hand-knotted macrame hanger made from natural cotton rope for small to medium pots.", "Havenza.Web/Havenza.Web/wwwroot/images/products/24.png", "Hanging Macrame Plant Holder", 19.50m, 50 },
                    { 24, 5, "Low-maintenance succulent gardens in glass terrariums.", "Havenza.Web/Havenza.Web/wwwroot/images/products/25.png", "Succulent Terrariums", 75.00m, 18 },
                    { 25, 5, "Sleek, black powder-coated metal stand, elevating plants to better catch light.", "Havenza.Web/Havenza.Web/wwwroot/images/products/26.png", "Tall Metal Plant Stand", 49.99m, 16 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

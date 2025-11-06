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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
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
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "A timeless three-seater sofa with a solid walnut base and linen-blend fabric. Perfect for modern living rooms.", "https://placehold.co/600x400/E2A16F/FFF?text=Walnut+Sofa", "Mid-Century Walnut Sofa", 1299.99, 5 },
                    { 2, 1, "Compact 4-seater dining table with a genuine white marble top and sleek black metal legs.", "https://placehold.co/600x400/E2A16F/FFF?text=Marble+Table", "Round Marble Dining Table", 749.5, 3 },
                    { 3, 1, "Queen-sized bed with a high, tufted headboard, upholstered in a light beige, durable linen fabric.", "https://placehold.co/600x400/E2A16F/FFF?text=Linen+Bed", "Linen Upholstered Bed Frame", 899.0, 7 },
                    { 4, 1, "Simple and robust writing desk with two drawers, designed for a clean and focused workspace.", "https://placehold.co/600x400/E2A16F/FFF?text=Office+Desk", "Minimalist Office Desk", 345.99000000000001, 12 },
                    { 5, 1, "Versatile storage unit with adjustable shelves, finished in a matte dark gray lacquer.", "https://placehold.co/600x400/E2A16F/FFF?text=Storage+Cabinet", "Modular Storage Cabinet", 520.0, 6 },
                    { 6, 2, "Large, hand-painted abstract canvas piece with muted blue and warm tan tones.", "https://placehold.co/600x400/86B0BD/FFF?text=Abstract+Art", "Abstract Canvas Wall Art", 119.98999999999999, 15 },
                    { 7, 2, "Full-length standing mirror with a thin, brass-finished curved metal frame.", "https://placehold.co/600x400/86B0BD/FFF?text=Floor+Mirror", "Curved Metal Floor Mirror", 185.0, 8 },
                    { 8, 2, "A collection of five mixed-size frames (3x5, 4x6, 5x7) with natural oak finish and shatter-proof glass. Perfect for creating a gallery wall.", "https://placehold.co/600x400/86B0BD/FFF?text=Sculptures", "Set of 5 Minimalist Photo Frames", 45.990000000000002, 20 },
                    { 9, 2, "Silent wall clock featuring an unfinished wood face and simple black hands.", "https://placehold.co/600x400/86B0BD/FFF?text=Wood+Clock", "Minimalist Wooden Clock", 59.5, 18 },
                    { 10, 2, "Hand-blown glass vase with a subtle transparent texture, perfect for fresh flowers or as a standalone piece.", "https://placehold.co/600x400/86B0BD/FFF?text=Glass+Vase", "Transparent Glass Vase", 35.0, 30 },
                    { 11, 3, "Single-bulb ceiling pendant with a matte black metal cage design, adjustable cord length.", "https://placehold.co/600x400/2C2C2C/FFF?text=Pendant+Light", "Industrial Black Pendant Light", 95.0, 10 },
                    { 12, 3, "A classic table lamp featuring a solid brass base and a soft, white linen drum shade.", "https://placehold.co/600x400/2C2C2C/FFF?text=Table+Lamp", "Brass & Linen Table Lamp", 65.989999999999995, 15 },
                    { 13, 3, "Tall, arched floor lamp designed to hang over a sofa or chair for optimal reading light.", "https://placehold.co/600x400/2C2C2C/FFF?text=Floor+Lamp", "Arched Reading Floor Lamp", 130.0, 9 },
                    { 14, 3, "Under-cabinet or shelf-mounted LED light strip for subtle accent illumination.", "https://placehold.co/600x400/2C2C2C/FFF?text=LED+Strip", "Minimalist LED Strip Light", 45.0, 25 },
                    { 15, 3, "Elegant chandelier with cascading crystal clusters, perfect for dining rooms or entryways.", "https://placehold.co/600x400/2C2C2C/FFF?text=Chandelier", "Crystal Cluster Chandelier", 499.99000000000001, 4 },
                    { 16, 4, "Large area rug made of ethically sourced wool with a subtle geometric pattern in neutral tones.", "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Wool+Rug", "Hand-Woven Wool Rug (8'x10')", 399.0, 7 },
                    { 17, 4, "Ultra-soft acrylic throw blanket with a thick, chunky knit texture, perfect for cozy evenings.", "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Knit+Throw", "Chunky Knit Throw Blanket", 85.0, 22 },
                    { 18, 4, "Pair of luxurious velvet cushion covers (18x18 inches) in a deep forest green.", "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Velvet+Cushions", "Set of 2 Velvet Cushion Covers", 29.989999999999998, 35 },
                    { 19, 4, "Single panel linen curtains with a full blackout lining, 84 inches long.", "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Linen+Curtains", "Blackout Linen Curtains", 55.0, 14 },
                    { 20, 4, "Queen size duvet cover and sham set made from ultra-soft 600-thread count Egyptian cotton.", "https://placehold.co/600x400/FFF0DD/2C2C2C?text=Duvet+Set", "Egyptian Cotton Duvet Cover Set", 110.0, 11 },
                    { 21, 5, "A realistic, high-quality faux fiddle-leaf fig tree (6 ft tall), perfect for low-light spaces.", "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Fiddle+Leaf", "Large Fiddle-Leaf Fig (Faux)", 159.99000000000001, 9 },
                    { 22, 5, "Modern white ceramic planter with a geometric diamond texture, suitable for 6-inch plants.", "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Planter", "Geometric Ceramic Planter", 29.0, 40 },
                    { 23, 5, "Hand-knotted macrame hanger made from natural cotton rope for small to medium pots.", "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Macrame", "Hanging Macrame Plant Holder", 19.5, 50 },
                    { 24, 5, "Low-maintenance succulent gardens in glass terrariums.", "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Terrariums", "Succulent Terrariums", 75.0, 18 },
                    { 25, 5, "Sleek, black powder-coated metal stand, elevating plants to better catch light.", "https://placehold.co/600x400/D1D3D4/2C2C2C?text=Plant+Stand", "Tall Metal Plant Stand", 49.990000000000002, 16 }
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

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace E_Commerce.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class ProductDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    new_price = table.Column<double>(type: "float", nullable: false),
                    old_price = table.Column<double>(type: "float", nullable: false),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "category", "image", "name", "new_price", "old_price" },
                values: new object[,]
                {
                    { 1, "women", "p1_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 50.0, 80.5 },
                    { 2, "women", "p2_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 3, "women", "p3_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 60.0, 100.5 },
                    { 4, "women", "p4_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 100.0, 150.0 },
                    { 5, "women", "p5_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 6, "women", "p6_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 7, "women", "p7_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 8, "women", "p8_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 9, "women", "p9_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 10, "women", "p10_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 11, "women", "p11_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 12, "women", "p12_img", "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse", 85.0, 120.5 },
                    { 13, "men", "p13_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 14, "men", "p14_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 15, "men", "p15_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 16, "men", "p16_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 17, "men", "p17_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 18, "men", "p18_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 19, "men", "p19_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 20, "men", "p20_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 21, "men", "p21_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 22, "men", "p22_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 23, "men", "p23_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 24, "men", "p24_img", "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket", 85.0, 120.5 },
                    { 25, "kid", "p25_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 26, "kid", "p26_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 27, "kid", "p27_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 28, "kid", "p28_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 29, "kid", "p29_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 30, "kid", "p30_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 31, "kid", "p31_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 32, "kid", "p32_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 33, "kid", "p33_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 34, "kid", "p34_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 35, "kid", "p35_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 },
                    { 36, "kid", "p36_img", "Boys Orange Colourblocked Hooded Sweatshirt", 85.0, 120.5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}

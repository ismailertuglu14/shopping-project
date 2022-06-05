using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Colours",
                columns: table => new
                {
                    ColourId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColourName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colours", x => x.ColourId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ColourId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colours_ColourId",
                        column: x => x.ColourId,
                        principalTable: "Colours",
                        principalColumn: "ColourId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Tişört" },
                    { 2, "Şort" },
                    { 3, "Gömlek" },
                    { 4, "Eşofman" },
                    { 5, "Pantolon" },
                    { 6, "Ceket" },
                    { 7, "Jeans" },
                    { 8, "Yelek" },
                    { 9, "Kazak" },
                    { 10, "Mont" },
                    { 11, "Sweatshirt" },
                    { 12, "Takım Elbise" }
                });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "ColourId", "ColourName" },
                values: new object[,]
                {
                    { 1, "Blue" },
                    { 2, "Red" },
                    { 3, "Green" },
                    { 4, "Brown" },
                    { 5, "Purple" },
                    { 6, "Black" },
                    { 7, "Turquiose" },
                    { 8, "Orange" },
                    { 9, "Yellow" },
                    { 10, "Pink" },
                    { 11, "Gray" },
                    { 12, "Beige" },
                    { 13, "Khaki" },
                    { 14, "Ecru" },
                    { 15, "Navy Blue" },
                    { 16, "Indigo" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColourId", "Description", "Price", "ProductName" },
                values: new object[] { 1, 1, 2, "Slim Fit Bisiklet Yaka Tişört", 99.900000000000006, "Kısa Kollu Tişört" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColourId", "Description", "Price", "ProductName" },
                values: new object[] { 2, 2, 15, "Regular fit Basketbolcu Şort", 105.98999999999999, "Şort" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ColourId", "Description", "Price", "ProductName" },
                values: new object[] { 3, 3, 6, "Oversize Ekoseli Oduncu Gömliği", 176.99000000000001, "Oduncu Gömleği" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColourId",
                table: "Products",
                column: "ColourId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colours");
        }
    }
}

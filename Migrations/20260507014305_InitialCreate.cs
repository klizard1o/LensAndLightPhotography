using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LensAndLight.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[] { 1, "Forever starts here.", "Weddings" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, "High quality shots.", null, 101m, "Package 1" },
                    { 2, 1, "High quality shots.", null, 102m, "Package 2" },
                    { 3, 1, "High quality shots.", null, 103m, "Package 3" },
                    { 4, 1, "High quality shots.", null, 104m, "Package 4" },
                    { 5, 1, "High quality shots.", null, 105m, "Package 5" },
                    { 6, 1, "High quality shots.", null, 106m, "Package 6" },
                    { 7, 1, "High quality shots.", null, 107m, "Package 7" },
                    { 8, 1, "High quality shots.", null, 108m, "Package 8" },
                    { 9, 1, "High quality shots.", null, 109m, "Package 9" },
                    { 10, 1, "High quality shots.", null, 110m, "Package 10" },
                    { 11, 1, "High quality shots.", null, 111m, "Package 11" },
                    { 12, 1, "High quality shots.", null, 112m, "Package 12" },
                    { 13, 1, "High quality shots.", null, 113m, "Package 13" },
                    { 14, 1, "High quality shots.", null, 114m, "Package 14" },
                    { 15, 1, "High quality shots.", null, 115m, "Package 15" },
                    { 16, 1, "High quality shots.", null, 116m, "Package 16" },
                    { 17, 1, "High quality shots.", null, 117m, "Package 17" },
                    { 18, 1, "High quality shots.", null, 118m, "Package 18" },
                    { 19, 1, "High quality shots.", null, 119m, "Package 19" },
                    { 20, 1, "High quality shots.", null, 120m, "Package 20" },
                    { 21, 1, "High quality shots.", null, 121m, "Package 21" },
                    { 22, 1, "High quality shots.", null, 122m, "Package 22" },
                    { 23, 1, "High quality shots.", null, 123m, "Package 23" },
                    { 24, 1, "High quality shots.", null, 124m, "Package 24" },
                    { 25, 1, "High quality shots.", null, 125m, "Package 25" },
                    { 26, 1, "High quality shots.", null, 126m, "Package 26" },
                    { 27, 1, "High quality shots.", null, 127m, "Package 27" },
                    { 28, 1, "High quality shots.", null, 128m, "Package 28" },
                    { 29, 1, "High quality shots.", null, 129m, "Package 29" },
                    { 30, 1, "High quality shots.", null, 130m, "Package 30" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
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

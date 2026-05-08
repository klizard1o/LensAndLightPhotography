using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LensAndLight.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedDataWithImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Capturing your 'I Do' moments forever.");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Description", "Name" },
                values: new object[,]
                {
                    { 2, "Celebrate your hard-earned milestone.", "Graduation" },
                    { 3, "Single person and family lifestyle sessions.", "Portraits" },
                    { 4, "Proms, parties, and special gatherings.", "Events" },
                    { 5, "Sweet, tiny memories for new parents.", "Newborn" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 160.00m, "Elegant Wedding Vol 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 170.00m, "Elegant Wedding Vol 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 180.00m, "Elegant Wedding Vol 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 190.00m, "Elegant Wedding Vol 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 200.00m, "Elegant Wedding Vol 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Full day coverage with a romantic, airy edit.", "/images/wedding.jpg", 210.00m, "Elegant Wedding Vol 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 220.00m, "Senior Glow Grad 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 230.00m, "Senior Glow Grad 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 240.00m, "Senior Glow Grad 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 250.00m, "Senior Glow Grad 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 260.00m, "Senior Glow Grad 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Celebrate your graduation with sunshine and smiles!", "/images/grad.jpg", 270.00m, "Senior Glow Grad 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 280.00m, "Classic Portrait 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 290.00m, "Classic Portrait 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 300.00m, "Classic Portrait 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 310.00m, "Classic Portrait 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 320.00m, "Classic Portrait 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Perfect for LinkedIn, social media, or just because!", "/images/portrait.jpg", 330.00m, "Classic Portrait 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 340.00m, "Prom Night Magic 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 350.00m, "Prom Night Magic 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 360.00m, "Prom Night Magic 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 370.00m, "Prom Night Magic 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 380.00m, "Prom Night Magic 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Capture the sparkle of your big night with friends.", "/images/prom.jpg", 390.00m, "Prom Night Magic 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 400.00m, "Tiny Toes Newborn 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 410.00m, "Tiny Toes Newborn 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 420.00m, "Tiny Toes Newborn 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 430.00m, "Tiny Toes Newborn 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 440.00m, "Tiny Toes Newborn 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Soft, cozy shots of your newest little love.", "/images/newborn.jpg", 450.00m, "Tiny Toes Newborn 6" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: 1,
                column: "Description",
                value: "Forever starts here.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 101m, "Package 1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 102m, "Package 2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 103m, "Package 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 4,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 104m, "Package 4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 5,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 105m, "Package 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "High quality shots.", null, 106m, "Package 6" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 7,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 107m, "Package 7" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 8,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 108m, "Package 8" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 9,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 109m, "Package 9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 10,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 110m, "Package 10" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 11,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 111m, "Package 11" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 12,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 112m, "Package 12" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 13,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 113m, "Package 13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 14,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 114m, "Package 14" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 15,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 115m, "Package 15" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 16,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 116m, "Package 16" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 17,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 117m, "Package 17" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 18,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 118m, "Package 18" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 19,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 119m, "Package 19" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 20,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 120m, "Package 20" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 21,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 121m, "Package 21" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 22,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 122m, "Package 22" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 23,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 123m, "Package 23" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 24,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 124m, "Package 24" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 25,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 125m, "Package 25" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 26,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 126m, "Package 26" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 27,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 127m, "Package 27" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 28,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 128m, "Package 28" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 29,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 129m, "Package 29" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductID",
                keyValue: 30,
                columns: new[] { "CategoryID", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "High quality shots.", null, 130m, "Package 30" });
        }
    }
}

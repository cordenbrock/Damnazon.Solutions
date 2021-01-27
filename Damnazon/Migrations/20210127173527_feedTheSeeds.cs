using Microsoft.EntityFrameworkCore.Migrations;

namespace Damnazon.Migrations
{
    public partial class feedTheSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryDescription",
                value: "Shop Jeff Bezos financial assets!");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryDescription",
                value: "Shop Jeff Bezos properties!");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryDescription",
                value: "Shop Jeff Bezos vehicles!");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName", "ThumbnailImage" },
                values: new object[] { 4, "Shop Jeff Bezos personal items!", "Items", "\\img\\clock.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { "Blue Origin, LLC is an American privately funded aerospace manufacturer and sub-orbital spaceflight services company headquartered in Kent, Washington.", "Blue Origin", 20000000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 1, "The Washington Post is an ancient newspaper dating back to 1877, adapting and transforming to fit the modern era. Nowadays, the Post is primarily a popular online news source featuring reliant information and a touch of tradition.", "Washington Post", 250000000m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 1, "\\img\\wholeFoods.jpg", false, true, "Whole Foods Market, Inc. is an American multinational supermarket chain headquartered in Austin, Texas, which sells products free from hydrogenated fats and artificial colors, flavors, and preservatives.", "Whole Foods", 14000000000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "IsInStock", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 4, 2, "\\img\\seattleLakehouse.jpg", false, true, false, "One of his most popular homes is this Seattle mansion, located less than a mile from one of Bill Gates's favorite houses.", "Seattle Lake House", 10000000m },
                    { 5, 2, "\\img\\seattleLakehouse.jpg", false, true, false, "The gigantic mansion used to be a textile museum and features a bold, extravagant exterior perfect for a man of Bezos’ stature.", "Largest house in Washington D.C.", 23000000m },
                    { 6, 3, "\\img\\gulfstreamPrivateJet.jpg", true, false, false, "Gulfstream G-650ER one of the fastest in the world, but it’s also all decked out to resemble a Michelin-starred restaurant more than a plane.", "Gulfstream Private Jet", 65000000m },
                    { 7, 3, "\\img\\hondaAccord.jpg", false, true, false, "This was the first car purchase by Amazon boss, This 1997 Honda Accord  four-cylinder engine, air conditioning, AM/FM/cassette radio, automatic transmission, power locks and windows", "1997 Honda Accord", 4000m }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "IsInStock", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 8, 4, "\\img\\clock.jpg", false, true, false, "this clock is unique because it is designed to keep time for 10,000 years. Jeff Bezos invested in this in order to have the means to embody the abstract longevity of time itself", "10,000-Year Clock", 42000000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "IsInStock", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 9, 4, "\\img\\watch.jpg", false, true, false, "Overly priced Rolex that once belonged to Jeff Bezos.", "Rolex", 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CategoryDescription",
                value: "This is a tab for all of Jeff Bezos finacial assets.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CategoryDescription",
                value: "This is a tab for all of Jeff Bezos properties.");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CategoryDescription",
                value: "This is a tab for all of Jeff Bezos vehicles.");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { "Space bugs, everywhere, hurry, buy blue origin stock today, fight cosmic insects!", "Lorem Blue Origin Stocksum", 5.25m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "CategoryId", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 2, "Real news based on real true facts", "Lorem Washerington Pest", 4.10m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 3, "\\img\\gulfstreamPrivateJet.jpg", true, false, "WOOOOOOOOOOOO", "Lorem Bezos Jetticus jettison", 2.5m });
        }
    }
}

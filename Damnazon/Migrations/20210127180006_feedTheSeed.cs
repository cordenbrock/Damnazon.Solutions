using Microsoft.EntityFrameworkCore.Migrations;

namespace Damnazon.Migrations
{
    public partial class feedTheSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "ThumbnailImage",
                value: "\\img\\assett2.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "ThumbnailImage",
                value: "\\img\\properties.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "ThumbnailImage",
                value: "\\img\\vehicles.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ThumbnailImage",
                value: "\\img\\items.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "\\img\\largestHouseInDc.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "ThumbnailImage",
                value: "\\img\\asset.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "ThumbnailImage",
                value: "\\img\\seattleLakehouse.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "ThumbnailImage",
                value: "\\img\\hondaAccord.jpg");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4,
                column: "ThumbnailImage",
                value: "\\img\\clock.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "Image",
                value: "\\img\\seattleLakehouse.jpg");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Damnazon.Migrations
{
    public partial class addProductFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Products",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDamnazonSlime",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDamnazonsChoice",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "ProductDescription", "ProductName" },
                values: new object[] { "", true, true, "Space bugs, everywhere, hurry, buy blue origin stock today, fight cosmic insects!", "Lorem Blue Origin Stocksum" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "Image", "IsDamnazonsChoice", "ProductDescription", "ProductName" },
                values: new object[] { "", true, "Real news based on real true facts", "Lorem Washerington Pest" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "Image", "IsDamnazonSlime", "ProductDescription", "ProductName" },
                values: new object[] { "", true, "WOOOOOOOOOOOO", "Lorem Bezos Bicyclusum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDamnazonSlime",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsDamnazonsChoice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "EXAMPLE", "EXAMPLE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "EXAMPLE", "EXAMPLE" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                columns: new[] { "ProductDescription", "ProductName" },
                values: new object[] { "EXAMPLE", "EXAMPLE" });
        }
    }
}

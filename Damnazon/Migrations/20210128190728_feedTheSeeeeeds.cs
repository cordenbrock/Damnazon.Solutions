using Microsoft.EntityFrameworkCore.Migrations;

namespace Damnazon.Migrations
{
    public partial class feedTheSeeeeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Image", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 4, "\\img\\dog.png", "The pooch's name is SpotMini. 55 pounds and 3ft tall.", "Robot Dog", 50000m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Image", "IsDamnazonSlime", "IsDamnazonsChoice", "IsInStock", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 11, 1, "\\img\\amzonrobotics.png", false, true, false, "Originally Kiva Systems, the robotics company was renamed as Amazon Robotics after Amazon acquired it for $775 million in March 2012. The company uses package-carrying robots at logistic centres and warehouses of Amazon.", "Amazon Robotics", 750000000m },
                    { 12, 3, "\\img\\bugatti.jpg", false, true, false, "Jeff Bezos's favourite car. The Bugatti Veyron Mansory is a hypercar without limits. Take the unparalleled specs of the Veyron and unsparingly use top-scale leather and carbon fiber throughout out the body of the car.", "Bugatti Veyron Mansory", 4000000000m },
                    { 13, 3, "\\img\\lykan.jpg", false, true, false, "Lykan Hypersport is a Lebanese limited production sports car manufactured by W Motors, a United Arab Emirates based company, founded in 2012 in Lebanon with the collaboration of Lebanese and Italian engineers. It is the first sports car to be designed and produced indigenously in the Middle East.", "W Motors Lykan Hypersport", 4000000m },
                    { 14, 2, "\\img\\ny.png", false, true, false, "A fancy 10,000 square feet apartment in New York’s upscale Central Park West area, Bezos owns three linked apartments that are spread over 10,000 square feet.", "NY Apartment", 17000000m },
                    { 15, 2, "\\img\\beverlyhills.png", false, true, false, "Spanish style mansion in Beverly Hills, California. According to a report by Business Insider, the seven-bedroom seven-bathroom home has a greenhouse, a sunken and lighted tennis court, a huge swimming pool, four fountains, and a six-car garage.", "Beverly Hills Home", 24000000m },
                    { 16, 4, "\\img\\goldcomb.jpg", false, true, false, "Used; Like New", "Gold Comb", 1000000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10,
                columns: new[] { "CategoryId", "Image", "ProductDescription", "ProductName", "ProductPrice" },
                values: new object[] { 3, "\\img\\watch.jpg", "Overly priced Rolex that once belonged to Jeff Bezos.", "Rolex", 200000m });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Server.Migrations
{
    public partial class ProductSeeding2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "https://th.bing.com/th/id/OIP.qXcocaHp2V8brplkQX9a0gHaE7?rs=1&pid=ImgDetMain", 77.5m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImageUrl", "Price" },
                values: new object[] { "https://en.wikipedia.org/wiki/Computer#/media/File:Gamecube-console.jpg", 99.5m });
        }
    }
}

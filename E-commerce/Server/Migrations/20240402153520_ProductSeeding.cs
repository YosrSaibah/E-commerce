using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "A handheld personal computer (PC), typically built around either a clamshell form factor or a gaming form factor with a gamepad integrated for video games, is a mobile device that is significantly smaller than any standard personal computer (PC), but based on the same principles as PCs. The clamshell form factor is sometimes referred to as a palmtop computer, not to be confused with Palmtop PC which was a name used mainly by Hewlett-Packard.", "https://th.bing.com/th/id/OIP.qXcocaHp2V8brplkQX9a0gHaE7?rs=1&pid=ImgDetMain", 77.5m, "Handheld PC" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "The Hitchhiker's Guide to the Galaxy[a][b] is a comedy science fiction franchise created by Douglas Adams. Originally a 1978 radio comedy broadcast on BBC Radio 4, it was later adapted to other formats, including novels, stage shows, comic books, a 1981 TV series, a 1984 text adventure game, and 2005 feature film.", "https://www.themoviedb.org/t/p/original/hmGMMcehDlTdiBEnq3fAc5QOkS1.jpg", 75.4m, "The Hitchhiker's Guide to the Galaxy" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Ready Player One is a 2018 American science fiction action film based on Ernest Cline's novel of the same name. The film was co-produced and directed by Steven Spielberg, written by Cline and Zak Penn, and stars Tye Sheridan, Olivia Cooke, Ben Mendelsohn, Lena Waithe, T.J. Miller, Simon Pegg, and Mark Rylance.", "https://theculturednerd.org/wp-content/uploads/2020/04/1_Nzaxn52WDFE7BTois8ZQ7w-1382x2048.jpeg", 88.5m, "Ready Player One (film)" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class AddClannadCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Creator", "DateofCreation", "Name" },
                values: new object[] { 2, "Key", new DateTime(2004, 4, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Clannad" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 216, "https://beta.vndb.org/ch/30/27930.jpg", 2, "Ichinose Kotomi", 0 },
                    { 217, "https://beta.vndb.org/ch/83/55083.jpg", 2, "Okazaki Tomoya", 0 },
                    { 218, "https://beta.vndb.org/ch/28/27928.jpg", 2, "Furukawa Nagisa", 0 },
                    { 219, "https://beta.vndb.org/ch/31/27931.jpg", 2, "Sakagami Tomoyo", 0 },
                    { 220, "https://beta.vndb.org/ch/29/27929.jpg", 2, "Ibuki Fuuko", 0 },
                    { 221, "https://beta.vndb.org/ch/27/27927.jpg", 2, "Fujibayashi Kyou", 0 },
                    { 222, "https://beta.vndb.org/ch/34/27934.jpg", 2, "Sunohara Youhei", 0 },
                    { 223, "https://beta.vndb.org/ch/33/27933.jpg", 2, "Fujibayashi Ryou", 0 },
                    { 224, "https://beta.vndb.org/ch/76/55076.jpg", 2, "Sakagami Takafumi", 0 },
                    { 225, "https://beta.vndb.org/ch/32/27932.jpg", 2, "Miyazawa Yukine", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class AddSteinsGate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Creator", "DateofCreation", "Name" },
                values: new object[,]
                {
                    { 3, "5pb", new DateTime(2009, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Steins; Gate" },
                    { 4, "07th Expansion", new DateTime(2007, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Umineko" },
                    { 5, "Gainax", new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gurren Lagann" },
                    { 6, "Studio Gokumi", new DateTime(2014, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yuuki Yuuna's a Hero" }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 226, "https://beta.vndb.org/ch/34/97234.jpg", 3, "Makise Kurisu", 0 },
                    { 227, "https://beta.vndb.org/ch/95/97195.jpg", 3, "Shiina Mayuri", 0 },
                    { 228, "https://beta.vndb.org/ch/36/97236.jpg", 3, "Amane Suzuha", 0 },
                    { 229, "https://beta.vndb.org/ch/38/97238.jpg", 3, "Hashida Itaru", 0 },
                    { 230, "https://beta.vndb.org/ch/35/97235.jpg", 3, "Akiha Rumiho", 0 },
                    { 231, "https://beta.vndb.org/ch/46/28046.jpg", 3, "Tennouji Yuugo", 0 },
                    { 232, "https://beta.vndb.org/ch/38/28038.jpg", 3, "Kiryuu Moeka", 0 },
                    { 233, "https://beta.vndb.org/ch/44/28044.jpg", 3, "Urushibara Ruka", 0 },
                    { 234, "https://beta.vndb.org/ch/29/10729.jpg", 3, "Okabe Rintarou", 0 },
                    { 235, "https://beta.vndb.org/ch/29/97229.jpg", 3, "Tennouji Nae", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Franchises",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class AddYuukiYuuna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 336, "https://cdn.myanimelist.net/images/characters/3/497602.jpg", 6, "Yuuna Yuuki", 0 },
                    { 337, "https://cdn.myanimelist.net/images/characters/6/497679.jpg", 6, "Fuu Inubouzaki", 0 },
                    { 338, "https://cdn.myanimelist.net/images/characters/8/497601.jpg", 6, "Itsuki Inubouzaki", 0 },
                    { 339, "https://cdn.myanimelist.net/images/characters/5/497599.jpg", 6, "Mimori Tougou", 0 },
                    { 340, "https://cdn.myanimelist.net/images/characters/13/497603.jpg", 6, "Karin Miyoshi", 0 },
                    { 341, "https://cdn.myanimelist.net/images/characters/7/497600.jpg", 6, "Sonoko Nogi", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 341);
        }
    }
}

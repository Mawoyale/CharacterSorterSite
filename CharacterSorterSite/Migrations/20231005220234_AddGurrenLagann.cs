using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class AddGurrenLagann : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 298, "https://cdn.myanimelist.net/images/characters/14/34848.jpg", 5, "Yoko Littner", 0 },
                    { 299, "https://cdn.myanimelist.net/images/characters/7/83946.jpg", 5, "Kamina ", 0 },
                    { 300, "https://cdn.myanimelist.net/images/characters/10/28353.jpg", 5, "Simon ", 0 },
                    { 301, "https://cdn.myanimelist.net/images/characters/15/46497.jpg", 5, "Leeron Littner", 0 },
                    { 302, "https://cdn.myanimelist.net/images/characters/15/32812.jpg", 5, "Rossiu Adai", 0 },
                    { 303, "https://cdn.myanimelist.net/images/characters/16/153853.jpg", 5, "Viral ", 0 },
                    { 304, "https://cdn.myanimelist.net/images/characters/7/50690.jpg", 5, "Nia Teppelin", 0 },
                    { 305, "https://cdn.myanimelist.net/images/characters/7/79235.jpg", 5, "Adiane ", 0 },
                    { 306, "https://cdn.myanimelist.net/images/characters/10/67420.jpg", 5, "Cytomander ", 0 },
                    { 307, "https://cdn.myanimelist.net/images/characters/12/67392.jpg", 5, "Guame ", 0 },
                    { 308, "https://cdn.myanimelist.net/images/characters/4/67371.jpg", 5, "Gimmy Adai", 0 },
                    { 309, "https://cdn.myanimelist.net/images/characters/7/79497.jpg", 5, "Darry Adai", 0 },
                    { 310, "https://cdn.myanimelist.net/images/characters/8/70781.jpg", 5, "Kittan Bachika", 0 },
                    { 311, "https://cdn.myanimelist.net/images/characters/14/53979.jpg", 5, "Kiyoh Littner", 0 },
                    { 312, "https://cdn.myanimelist.net/images/characters/13/53977.jpg", 5, "Kinon Bachika", 0 },
                    { 313, "https://cdn.myanimelist.net/images/characters/10/53978.jpg", 5, "Kiyal Bachika", 0 },
                    { 314, "https://cdn.myanimelist.net/images/characters/9/67375.jpg", 5, "Boota ", 0 },
                    { 315, "https://cdn.myanimelist.net/images/characters/14/55742.jpg", 5, "Anti-Spiral ", 0 },
                    { 316, "https://cdn.myanimelist.net/images/characters/14/30604.jpg", 5, "Lordgenome ", 0 },
                    { 317, "https://cdn.myanimelist.net/images/characters/13/70779.jpg", 5, "Old Coco ", 0 },
                    { 318, "https://cdn.myanimelist.net/images/characters/4/67386.jpg", 5, "Attenborough Cortich", 0 },
                    { 319, "https://cdn.myanimelist.net/images/characters/3/79493.jpg", 5, "Leite Jokin", 0 },
                    { 320, "https://cdn.myanimelist.net/images/characters/9/67393.jpg", 5, "Thymilph ", 0 },
                    { 321, "https://cdn.myanimelist.net/images/characters/8/67396.jpg", 5, "Magin ", 0 },
                    { 322, "https://cdn.myanimelist.net/images/characters/6/67377.jpg", 5, "Zoushi Kanai", 0 },
                    { 323, "https://cdn.myanimelist.net/images/characters/7/67287.jpg", 5, "Gabal Docker", 0 },
                    { 324, "https://cdn.myanimelist.net/images/characters/8/67384.jpg", 5, "Kid Coega", 0 },
                    { 325, "https://cdn.myanimelist.net/images/characters/7/67385.jpg", 5, "Iraak Coega", 0 },
                    { 326, "https://cdn.myanimelist.net/images/characters/13/67390.jpg", 5, "Tetsukan Littner", 0 },
                    { 327, "https://cdn.myanimelist.net/images/characters/5/83947.jpg", 5, "Dayakka Littner", 0 },
                    { 328, "https://cdn.myanimelist.net/images/characters/16/79035.jpg", 5, "Jorgun Bakusa", 0 },
                    { 329, "https://cdn.myanimelist.net/images/characters/6/79036.jpg", 5, "Balinbow Bakusa", 0 },
                    { 330, "https://cdn.myanimelist.net/images/characters/12/67286.jpg", 5, "Makken Jokin", 0 },
                    { 331, "https://cdn.myanimelist.net/images/characters/9/67402.jpg", 5, "Cybela Kuto", 0 },
                    { 332, "https://cdn.myanimelist.net/images/characters/6/67290.jpg", 5, "Guinble Kaito", 0 },
                    { 333, "https://cdn.myanimelist.net/images/characters/15/67468.jpg", 5, "Anne Littner", 0 },
                    { 334, "https://cdn.myanimelist.net/images/characters/5/82808.jpg", 5, "Tsuuma ", 0 },
                    { 335, "https://cdn.myanimelist.net/images/characters/16/82814.jpg", 5, "Memu ", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 335);
        }
    }
}

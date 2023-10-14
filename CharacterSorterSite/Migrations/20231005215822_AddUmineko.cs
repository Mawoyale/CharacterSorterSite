using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class AddUmineko : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 236, "https://beta.vndb.org/ch/97/32097.jpg", 4, "Ushiromiya Battler", 0 },
                    { 237, "https://beta.vndb.org/ch/12/32112.jpg", 4, "Ushiromiya Jessica", 0 },
                    { 238, "https://beta.vndb.org/ch/10/32110.jpg", 4, "Ushiromiya George", 0 },
                    { 239, "https://beta.vndb.org/ch/16/32116.jpg", 4, "Ushiromiya Maria", 0 },
                    { 240, "https://beta.vndb.org/ch/13/32113.jpg", 4, "Ushiromiya Kinzou", 0 },
                    { 241, "https://beta.vndb.org/ch/08/32108.jpg", 4, "Shannon", 0 },
                    { 242, "https://beta.vndb.org/ch/02/32102.jpg", 4, "Kanon", 0 },
                    { 243, "https://beta.vndb.org/ch/18/32118.jpg", 4, "Ushiromiya Rosa", 0 },
                    { 244, "https://beta.vndb.org/ch/19/32119.jpg", 4, "Ushiromiya Rudolf", 0 },
                    { 245, "https://beta.vndb.org/ch/09/32109.jpg", 4, "Ushiromiya Eva", 0 },
                    { 246, "https://beta.vndb.org/ch/11/32111.jpg", 4, "Ushiromiya Hideyoshi", 0 },
                    { 247, "https://beta.vndb.org/ch/07/32107.jpg", 4, "Ronoue Genji", 0 },
                    { 248, "https://beta.vndb.org/ch/01/32101.jpg", 4, "Gouda Toshirou", 0 },
                    { 249, "https://beta.vndb.org/ch/03/32103.jpg", 4, "Kumasawa Chiyo", 0 },
                    { 250, "https://beta.vndb.org/ch/14/32114.jpg", 4, "Ushiromiya Krauss", 0 },
                    { 251, "https://beta.vndb.org/ch/17/32117.jpg", 4, "Ushiromiya Natsuhi", 0 },
                    { 252, "https://beta.vndb.org/ch/99/32099.jpg", 4, "Beatrice", 0 },
                    { 253, "https://beta.vndb.org/ch/06/32106.jpg", 4, "Nanjou Terumasa", 0 },
                    { 254, "https://beta.vndb.org/ch/15/32115.jpg", 4, "Ushiromiya Kyrie", 0 },
                    { 255, "https://beta.vndb.org/ch/75/86175.jpg", 4, "Bernkastel", 0 },
                    { 256, "https://beta.vndb.org/ch/30/32130.jpg", 4, "Lambdadelta", 0 },
                    { 257, "https://beta.vndb.org/ch/68/32168.jpg", 4, "Furfur", 0 },
                    { 258, "https://beta.vndb.org/ch/98/32098.jpg", 4, "Ushiromiya Ange", 0 },
                    { 259, "https://beta.vndb.org/ch/63/32163.jpg", 4, "Furudo Erika", 0 },
                    { 260, "https://beta.vndb.org/ch/65/32165.jpg", 4, "Willard H. Wright", 0 },
                    { 261, "https://beta.vndb.org/ch/64/32164.jpg", 4, "Ushiromiya Lion", 0 },
                    { 262, "https://beta.vndb.org/ch/71/32171.jpg", 4, "Zepar", 0 },
                    { 263, "https://beta.vndb.org/ch/36/32136.jpg", 4, "Ronove", 0 },
                    { 264, "https://beta.vndb.org/ch/29/32129.jpg", 4, "Gaap", 0 },
                    { 265, "https://beta.vndb.org/ch/20/32120.jpg", 4, "Virgilia", 0 },
                    { 266, "https://beta.vndb.org/ch/00/32100.jpg", 4, "EVA-Beatrice", 0 },
                    { 267, "https://beta.vndb.org/ch/34/32134.jpg", 4, "Lucifer", 0 },
                    { 268, "https://beta.vndb.org/ch/31/32131.jpg", 4, "Leviathan", 0 },
                    { 269, "https://beta.vndb.org/ch/38/32138.jpg", 4, "Satan", 0 },
                    { 270, "https://beta.vndb.org/ch/26/32126.jpg", 4, "Belphegor", 0 },
                    { 271, "https://beta.vndb.org/ch/04/32104.jpg", 4, "Mammon", 0 },
                    { 272, "https://beta.vndb.org/ch/24/32124.jpg", 4, "Beelzebub", 0 },
                    { 273, "https://beta.vndb.org/ch/22/32122.jpg", 4, "Asmodeus", 0 },
                    { 274, "https://beta.vndb.org/ch/62/32162.jpg", 4, "Dlanor A. Knox", 0 },
                    { 275, "https://beta.vndb.org/ch/21/32121.jpg", 4, "Amakusa Juuza", 0 },
                    { 276, "https://beta.vndb.org/ch/45/32145.jpg", 4, "Beatrice Castiglioni", 0 },
                    { 277, "https://beta.vndb.org/ch/66/32166.jpg", 4, "Cornelia", 0 },
                    { 278, "https://beta.vndb.org/ch/69/32169.jpg", 4, "Gertrude", 0 },
                    { 279, "https://beta.vndb.org/ch/67/32167.jpg", 4, "Featherine Augustus Aurora", 0 },
                    { 280, "https://beta.vndb.org/ch/70/32170.jpg", 4, "Hachijou Ikuko", 0 },
                    { 281, "https://beta.vndb.org/ch/42/32142.jpg", 4, "Ushiromiya Beatrice", 0 },
                    { 282, "https://beta.vndb.org/ch/41/32141.jpg", 4, "Okonogi Tetsurou", 0 },
                    { 283, "https://beta.vndb.org/ch/37/32137.jpg", 4, "Sakutarou", 0 },
                    { 284, "https://beta.vndb.org/ch/61/32161.jpg", 4, "Clair Vaux Bernardus", 0 },
                    { 285, "https://beta.vndb.org/ch/05/32105.jpg", 4, "Manon", 0 },
                    { 286, "https://beta.vndb.org/ch/23/32123.jpg", 4, "Asune", 0 },
                    { 287, "https://beta.vndb.org/ch/25/32125.jpg", 4, "Berune", 0 },
                    { 288, "https://beta.vndb.org/ch/27/32127.jpg", 4, "Benon", 0 },
                    { 289, "https://beta.vndb.org/ch/33/32133.jpg", 4, "Renon", 0 },
                    { 290, "https://beta.vndb.org/ch/35/32135.jpg", 4, "Runon", 0 },
                    { 291, "https://beta.vndb.org/ch/39/32139.jpg", 4, "Sanon", 0 },
                    { 292, "https://beta.vndb.org/ch/72/32172.jpg", 4, "Chiester 410", 0 },
                    { 293, "https://beta.vndb.org/ch/73/32173.jpg", 4, "Chiester 45", 0 },
                    { 294, "https://beta.vndb.org/ch/74/32174.jpg", 4, "Chiester 00", 0 },
                    { 295, "https://beta.vndb.org/ch/76/32176.jpg", 4, "Ootsuki", 0 },
                    { 296, "https://beta.vndb.org/ch/77/32177.jpg", 4, "Kawabata", 0 },
                    { 297, "https://beta.vndb.org/ch/78/32178.jpg", 4, "Hachijou Tooya", 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 297);
        }
    }
}

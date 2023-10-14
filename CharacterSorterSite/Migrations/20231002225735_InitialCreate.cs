using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CharacterSorterSite.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Franchises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Creator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateofCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Franchises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FranchiseId = table.Column<int>(type: "int", nullable: false),
                    VoteCount = table.Column<int>(type: "int", nullable: false),
                    CharacterImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Franchises_FranchiseId",
                        column: x => x.FranchiseId,
                        principalTable: "Franchises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CharacterThatWonId = table.Column<int>(type: "int", nullable: false),
                    CharacterThatLostId = table.Column<int>(type: "int", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Matches_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Franchises",
                columns: new[] { "Id", "Creator", "DateofCreation", "Name" },
                values: new object[] { 1, "Masashi Kishimoto", new DateTime(1999, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Naruto" });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "CharacterImage", "FranchiseId", "Name", "VoteCount" },
                values: new object[,]
                {
                    { 1, "https://cdn.myanimelist.net/images/characters/9/131317.jpg", 1, "Sasuke Uchiha", 0 },
                    { 2, "https://cdn.myanimelist.net/images/characters/9/284122.jpg", 1, "Itachi Uchiha", 0 },
                    { 3, "https://cdn.myanimelist.net/images/characters/2/284121.jpg", 1, "Naruto Uzumaki", 0 },
                    { 4, "https://cdn.myanimelist.net/images/characters/7/284129.jpg", 1, "Kakashi Hatake", 0 },
                    { 5, "https://cdn.myanimelist.net/images/characters/9/69275.jpg", 1, "Sakura Haruno", 0 },
                    { 6, "https://cdn.myanimelist.net/images/characters/13/433353.jpg", 1, "Rock Lee", 0 },
                    { 7, "https://cdn.myanimelist.net/images/characters/16/103576.jpg", 1, "Guy Might", 0 },
                    { 8, "https://cdn.myanimelist.net/images/characters/14/103706.jpg", 1, "Zabuza Momochi", 0 },
                    { 9, "https://cdn.myanimelist.net/images/characters/8/66177.jpg", 1, "Anko Mitarashi", 0 },
                    { 10, "https://cdn.myanimelist.net/images/characters/6/278736.jpg", 1, "Hinata Hyuuga", 0 },
                    { 11, "https://cdn.myanimelist.net/images/characters/10/293375.jpg", 1, "Gaara ", 0 },
                    { 12, "https://cdn.myanimelist.net/images/characters/2/105538.jpg", 1, "Neji Hyuuga", 0 },
                    { 13, "https://cdn.myanimelist.net/images/characters/9/131319.jpg", 1, "Deidara ", 0 },
                    { 14, "https://cdn.myanimelist.net/images/characters/3/131315.jpg", 1, "Shikamaru Nara", 0 },
                    { 15, "https://cdn.myanimelist.net/images/characters/9/105421.jpg", 1, "Chouji Akimichi", 0 },
                    { 16, "https://cdn.myanimelist.net/images/characters/9/60062.jpg", 1, "Ino Yamanaka", 0 },
                    { 17, "https://cdn.myanimelist.net/images/characters/10/100216.jpg", 1, "Iruka Umino", 0 },
                    { 18, "https://cdn.myanimelist.net/images/characters/10/103707.jpg", 1, "Haku ", 0 },
                    { 19, "https://cdn.myanimelist.net/images/characters/13/292452.jpg", 1, "Temari ", 0 },
                    { 20, "https://cdn.myanimelist.net/images/characters/14/82459.jpg", 1, "Kabuto Yakushi", 0 },
                    { 21, "https://cdn.myanimelist.net/images/characters/15/68618.jpg", 1, "Jiraiya ", 0 },
                    { 22, "https://cdn.myanimelist.net/images/characters/3/162089.jpg", 1, "Orochimaru ", 0 },
                    { 23, "https://cdn.myanimelist.net/images/characters/14/128074.jpg", 1, "Minato Namikaze", 0 },
                    { 24, "https://cdn.myanimelist.net/images/characters/11/433351.jpg", 1, "Kisame Hoshigaki", 0 },
                    { 25, "https://cdn.myanimelist.net/images/characters/13/54922.jpg", 1, "Pakkun ", 0 },
                    { 26, "https://cdn.myanimelist.net/images/characters/9/282663.jpg", 1, "Tsunade ", 0 },
                    { 27, "https://cdn.myanimelist.net/images/characters/10/295205.jpg", 1, "Tayuya ", 0 },
                    { 28, "https://cdn.myanimelist.net/images/characters/11/76260.jpg", 1, "Zetsu ", 0 },
                    { 29, "https://cdn.myanimelist.net/images/characters/16/292449.jpg", 1, "Shino Aburame", 0 },
                    { 30, "https://cdn.myanimelist.net/images/characters/13/103598.jpg", 1, "Kimimaro ", 0 },
                    { 31, "https://cdn.myanimelist.net/images/characters/11/131217.jpg", 1, "Kiba Inuzuka", 0 },
                    { 32, "https://cdn.myanimelist.net/images/characters/16/110946.jpg", 1, "Tenten ", 0 },
                    { 33, "https://cdn.myanimelist.net/images/characters/3/104664.jpg", 1, "Genma Shiranui", 0 },
                    { 34, "https://cdn.myanimelist.net/images/characters/7/109419.jpg", 1, "Konohamaru Sarutobi", 0 },
                    { 35, "https://cdn.myanimelist.net/images/characters/6/70846.jpg", 1, "Gamabunta ", 0 },
                    { 36, "https://cdn.myanimelist.net/images/characters/3/103794.jpg", 1, "Shizune ", 0 },
                    { 37, "https://cdn.myanimelist.net/images/characters/7/68615.jpg", 1, "Kankurou ", 0 },
                    { 38, "https://cdn.myanimelist.net/images/characters/8/103797.jpg", 1, "Kurenai Yuuhi", 0 },
                    { 39, "https://cdn.myanimelist.net/images/characters/13/82538.jpg", 1, "Asuma Sarutobi", 0 },
                    { 40, "https://cdn.myanimelist.net/images/characters/6/58197.jpg", 1, "Akamaru ", 0 },
                    { 41, "https://cdn.myanimelist.net/images/characters/16/62784.jpg", 1, "Isaribi ", 0 },
                    { 42, "https://cdn.myanimelist.net/images/characters/5/57902.jpg", 1, "Aoi Rokushou", 0 },
                    { 43, "https://cdn.myanimelist.net/images/characters/6/57963.jpg", 1, "Matsuri ", 0 },
                    { 44, "https://cdn.myanimelist.net/images/characters/5/232183.jpg", 1, "Kurama ", 0 },
                    { 45, "https://cdn.myanimelist.net/images/characters/2/68520.jpg", 1, "Hiruzen Sarutobi", 0 },
                    { 46, "https://cdn.myanimelist.net/images/characters/11/103624.jpg", 1, "Katsuyu ", 0 },
                    { 47, "https://cdn.myanimelist.net/images/characters/10/104665.jpg", 1, "Hayate Gekkou", 0 },
                    { 48, "https://cdn.myanimelist.net/images/characters/15/103579.jpg", 1, "Jiroubou ", 0 },
                    { 49, "https://cdn.myanimelist.net/images/characters/4/103588.jpg", 1, "Kidoumaru ", 0 },
                    { 50, "https://cdn.myanimelist.net/images/characters/15/105422.jpg", 1, "Sakon ", 0 },
                    { 51, "https://cdn.myanimelist.net/images/characters/2/55519.jpg", 1, "Raiga Kurosuki", 0 },
                    { 52, "https://cdn.myanimelist.net/images/characters/5/57869.jpg", 1, "Menma ", 0 },
                    { 53, "https://cdn.myanimelist.net/images/characters/3/36355.jpg", 1, "Zaku Abumi", 0 },
                    { 54, "https://cdn.myanimelist.net/images/characters/14/36354.jpg", 1, "Dosu Kinuta", 0 },
                    { 55, "https://cdn.myanimelist.net/images/characters/7/66504.jpg", 1, "Kin Tsuchi", 0 },
                    { 56, "https://cdn.myanimelist.net/images/characters/12/104668.jpg", 1, "Yoroi Akado", 0 },
                    { 57, "https://cdn.myanimelist.net/images/characters/16/58450.jpg", 1, "Seimei ", 0 },
                    { 58, "https://cdn.myanimelist.net/images/characters/15/103841.jpg", 1, "Shibi Aburame", 0 },
                    { 59, "https://cdn.myanimelist.net/images/characters/7/57543.jpg", 1, "Akahoshi ", 0 },
                    { 60, "https://cdn.myanimelist.net/images/characters/16/103839.jpg", 1, "Chouza Akimichi", 0 },
                    { 61, "https://cdn.myanimelist.net/images/characters/13/62769.jpg", 1, "Akio ", 0 },
                    { 62, "https://cdn.myanimelist.net/images/characters/7/104660.jpg", 1, "Ebisu ", 0 },
                    { 63, "https://cdn.myanimelist.net/images/characters/16/62812.jpg", 1, "Shukaku ", 0 },
                    { 64, "https://cdn.myanimelist.net/images/characters/10/34809.jpg", 1, "Hashirama Senju", 0 },
                    { 65, "https://cdn.myanimelist.net/images/characters/2/293367.jpg", 1, "Tobirama Senju", 0 },
                    { 66, "https://cdn.myanimelist.net/images/characters/16/292518.jpg", 1, "Hanabi Hyuuga", 0 },
                    { 67, "https://cdn.myanimelist.net/images/characters/13/103943.jpg", 1, "Yashamaru ", 0 },
                    { 68, "https://cdn.myanimelist.net/images/characters/16/110944.jpg", 1, "Moegi Kazamatsuri", 0 },
                    { 69, "https://cdn.myanimelist.net/images/characters/12/104663.jpg", 1, "Izumo Kamizuki", 0 },
                    { 70, "https://cdn.myanimelist.net/images/characters/11/103836.jpg", 1, "Hiashi Hyuuga", 0 },
                    { 71, "https://cdn.myanimelist.net/images/characters/15/232233.jpg", 1, "Yugao Uzuki", 0 },
                    { 72, "https://cdn.myanimelist.net/images/characters/10/103837.jpg", 1, "Inoichi Yamanaka", 0 },
                    { 73, "https://cdn.myanimelist.net/images/characters/15/166499.jpg", 1, "Hana Inuzuka", 0 },
                    { 74, "https://cdn.myanimelist.net/images/characters/12/103831.jpg", 1, "Tsume Inuzuka", 0 },
                    { 75, "https://cdn.myanimelist.net/images/characters/16/58401.jpg", 1, "Tsunami ", 0 },
                    { 76, "https://cdn.myanimelist.net/images/characters/3/103833.jpg", 1, "Baki ", 0 },
                    { 77, "https://cdn.myanimelist.net/images/characters/5/62787.jpg", 1, "Yotaka ", 0 },
                    { 78, "https://cdn.myanimelist.net/images/characters/13/63709.jpg", 1, "Kamikiri Fuuma", 0 },
                    { 79, "https://cdn.myanimelist.net/images/characters/10/57172.jpg", 1, "Sasame Fuuma", 0 },
                    { 80, "https://cdn.myanimelist.net/images/characters/13/66168.jpg", 1, "Haruna ", 0 },
                    { 81, "https://cdn.myanimelist.net/images/characters/14/110943.jpg", 1, "Shigure ", 0 },
                    { 82, "https://cdn.myanimelist.net/images/characters/2/158745.jpg", 1, "Enma ", 0 },
                    { 83, "https://cdn.myanimelist.net/images/characters/8/62804.jpg", 1, "Mizura ", 0 },
                    { 84, "https://cdn.myanimelist.net/images/characters/16/74497.jpg", 1, "Gouzu ", 0 },
                    { 85, "https://cdn.myanimelist.net/images/characters/16/74494.jpg", 1, "Meizu ", 0 },
                    { 86, "https://cdn.myanimelist.net/images/characters/4/104662.jpg", 1, "Kotetsu Hagane", 0 },
                    { 87, "https://cdn.myanimelist.net/images/characters/16/57642.jpg", 1, "Toki ", 0 },
                    { 88, "https://cdn.myanimelist.net/images/characters/13/62776.jpg", 1, "Gamatatsu ", 0 },
                    { 89, "https://cdn.myanimelist.net/images/characters/12/103948.jpg", 1, "Fugaku Uchiha", 0 },
                    { 90, "https://cdn.myanimelist.net/images/characters/8/58258.jpg", 1, "Mubi ", 0 },
                    { 91, "https://cdn.myanimelist.net/images/characters/13/66171.jpg", 1, "Oki ", 0 },
                    { 92, "https://cdn.myanimelist.net/images/characters/16/56420.jpg", 1, "Jirouchou Wasabi", 0 },
                    { 93, "https://cdn.myanimelist.net/images/characters/13/54034.jpg", 1, "Gamakichi ", 0 },
                    { 94, "https://cdn.myanimelist.net/images/characters/9/63540.jpg", 1, "Chishima ", 0 },
                    { 95, "https://cdn.myanimelist.net/images/characters/15/53360.jpg", 1, "Tazuna ", 0 },
                    { 96, "https://cdn.myanimelist.net/images/characters/8/62778.jpg", 1, "Genno ", 0 },
                    { 97, "https://cdn.myanimelist.net/images/characters/3/66166.jpg", 1, "Todoroki ", 0 },
                    { 98, "https://cdn.myanimelist.net/images/characters/10/61075.jpg", 1, "Raidou Namiashi", 0 },
                    { 99, "https://cdn.myanimelist.net/images/characters/13/57107.jpg", 1, "Karashi ", 0 },
                    { 100, "https://cdn.myanimelist.net/images/characters/3/57108.jpg", 1, "Ryuugan ", 0 },
                    { 101, "https://cdn.myanimelist.net/images/characters/14/66517.jpg", 1, "Fukusuke Hikyakuya", 0 },
                    { 102, "https://cdn.myanimelist.net/images/characters/11/130515.jpg", 1, "Ayame ", 0 },
                    { 103, "https://cdn.myanimelist.net/images/characters/14/62801.jpg", 1, "Teuchi ", 0 },
                    { 104, "https://cdn.myanimelist.net/images/characters/3/66518.jpg", 1, "Jigumo Fuuma", 0 },
                    { 105, "https://cdn.myanimelist.net/images/characters/8/57469.jpg", 1, "Arashi Fuuma", 0 },
                    { 106, "https://cdn.myanimelist.net/images/characters/11/55003.jpg", 1, "Ranmaru ", 0 },
                    { 107, "https://cdn.myanimelist.net/images/characters/14/62767.jpg", 1, "Hokushin ", 0 },
                    { 108, "https://cdn.myanimelist.net/images/characters/8/58241.jpg", 1, "Renga ", 0 },
                    { 109, "https://cdn.myanimelist.net/images/characters/4/66172.jpg", 1, "Genzou ", 0 },
                    { 110, "https://cdn.myanimelist.net/images/characters/13/63539.jpg", 1, "Gatsu ", 0 },
                    { 111, "https://cdn.myanimelist.net/images/characters/4/86780.jpg", 1, "Dengaku ", 0 },
                    { 112, "https://cdn.myanimelist.net/images/characters/2/86790.jpg", 1, "Manabu Akado", 0 },
                    { 113, "https://cdn.myanimelist.net/images/characters/9/63538.jpg", 1, "Hokuto ", 0 },
                    { 114, "https://cdn.myanimelist.net/images/characters/15/86791.jpg", 1, "Mondai ", 0 },
                    { 115, "https://cdn.myanimelist.net/images/characters/15/66488.jpg", 1, "Nagare ", 0 },
                    { 116, "https://cdn.myanimelist.net/images/characters/7/63537.jpg", 1, "Nanafushi ", 0 },
                    { 117, "https://cdn.myanimelist.net/images/characters/8/140157.jpg", 1, "Nan ", 0 },
                    { 118, "https://cdn.myanimelist.net/images/characters/13/66158.jpg", 1, "Kazabune ", 0 },
                    { 119, "https://cdn.myanimelist.net/images/characters/16/66508.jpg", 1, "Yakumo Kurama", 0 },
                    { 120, "https://cdn.myanimelist.net/images/characters/8/63536.jpg", 1, "Sazanami ", 0 },
                    { 121, "https://cdn.myanimelist.net/images/characters/13/57857.jpg", 1, "Senta ", 0 },
                    { 122, "https://cdn.myanimelist.net/images/characters/12/66159.jpg", 1, "Shin'emon ", 0 },
                    { 123, "https://cdn.myanimelist.net/images/characters/6/86778.jpg", 1, "Yajirobee ", 0 },
                    { 124, "https://cdn.myanimelist.net/images/characters/8/66173.jpg", 1, "Tanzou ", 0 },
                    { 125, "https://cdn.myanimelist.net/images/characters/9/66174.jpg", 1, "Waraji ", 0 },
                    { 126, "https://cdn.myanimelist.net/images/characters/10/158739.jpg", 1, "Aoba Yamashiro", 0 },
                    { 127, "https://cdn.myanimelist.net/images/characters/8/63378.jpg", 1, "Jibachi Kamizuru", 0 },
                    { 128, "https://cdn.myanimelist.net/images/characters/3/62795.jpg", 1, "Oboro ", 0 },
                    { 129, "https://cdn.myanimelist.net/images/characters/11/66175.jpg", 1, "Tsubaki ", 0 },
                    { 130, "https://cdn.myanimelist.net/images/characters/2/100214.jpg", 1, "Shikaku Nara", 0 },
                    { 131, "https://cdn.myanimelist.net/images/characters/9/57467.jpg", 1, "Mizuki Touji", 0 },
                    { 132, "https://cdn.myanimelist.net/images/characters/3/66545.jpg", 1, "Giichi ", 0 },
                    { 133, "https://cdn.myanimelist.net/images/characters/11/46484.jpg", 1, "Jantou ", 0 },
                    { 134, "https://cdn.myanimelist.net/images/characters/12/86782.jpg", 1, "Kusabi ", 0 },
                    { 135, "https://cdn.myanimelist.net/images/characters/9/115731.jpg", 1, "Hachidai ", 0 },
                    { 136, "https://cdn.myanimelist.net/images/characters/6/66540.jpg", 1, "Hakkaku ", 0 },
                    { 137, "https://cdn.myanimelist.net/images/characters/11/66541.jpg", 1, "Akane ", 0 },
                    { 138, "https://cdn.myanimelist.net/images/characters/6/103949.jpg", 1, "Mikoto Uchiha", 0 },
                    { 139, "https://cdn.myanimelist.net/images/characters/8/66542.jpg", 1, "Inari ", 0 },
                    { 140, "https://cdn.myanimelist.net/images/characters/9/62786.jpg", 1, "Yoshino Nara", 0 },
                    { 141, "https://cdn.myanimelist.net/images/characters/16/225775.jpg", 1, "Karura ", 0 },
                    { 142, "https://cdn.myanimelist.net/images/characters/16/103955.jpg", 1, "Homura Mitokado", 0 },
                    { 143, "https://cdn.myanimelist.net/images/characters/3/103956.jpg", 1, "Koharu Utatane", 0 },
                    { 144, "https://cdn.myanimelist.net/images/characters/15/103946.jpg", 1, "Dan Katou", 0 },
                    { 145, "https://cdn.myanimelist.net/images/characters/10/103835.jpg", 1, "Hizashi Hyuuga", 0 },
                    { 146, "https://cdn.myanimelist.net/images/characters/7/103834.jpg", 1, "Kuromaru ", 0 },
                    { 147, "https://cdn.myanimelist.net/images/characters/3/103950.jpg", 1, "Nawaki ", 0 },
                    { 148, "https://cdn.myanimelist.net/images/characters/8/86796.jpg", 1, "Tekka Uchiha", 0 },
                    { 149, "https://cdn.myanimelist.net/images/characters/11/66477.jpg", 1, "Inabi Uchiha", 0 },
                    { 150, "https://cdn.myanimelist.net/images/characters/3/63710.jpg", 1, "Yashiro Uchiha", 0 },
                    { 151, "https://cdn.myanimelist.net/images/characters/3/103604.jpg", 1, "Rasa ", 0 },
                    { 152, "https://cdn.myanimelist.net/images/characters/10/104667.jpg", 1, "Misumi Tsurugi", 0 },
                    { 153, "https://cdn.myanimelist.net/images/characters/8/66533.jpg", 1, "Genyuumaru ", 0 },
                    { 154, "https://cdn.myanimelist.net/images/characters/11/104672.jpg", 1, "Ibiki Morino", 0 },
                    { 155, "https://cdn.myanimelist.net/images/characters/6/62818.jpg", 1, "Zouri ", 0 },
                    { 156, "https://cdn.myanimelist.net/images/characters/2/66536.jpg", 1, "Kaiza ", 0 },
                    { 157, "https://cdn.myanimelist.net/images/characters/8/66497.jpg", 1, "Ami ", 0 },
                    { 158, "https://cdn.myanimelist.net/images/characters/2/91366.jpg", 1, "Udon Ise", 0 },
                    { 159, "https://cdn.myanimelist.net/images/characters/14/66498.jpg", 1, "Kagari ", 0 },
                    { 160, "https://cdn.myanimelist.net/images/characters/8/66499.jpg", 1, "Baiu ", 0 },
                    { 161, "https://cdn.myanimelist.net/images/characters/9/86793.jpg", 1, "Midare ", 0 },
                    { 162, "https://cdn.myanimelist.net/images/characters/3/86803.jpg", 1, "Tonbo Tobitake", 0 },
                    { 163, "https://cdn.myanimelist.net/images/characters/11/66479.jpg", 1, "Teyaki Uchiha", 0 },
                    { 164, "https://cdn.myanimelist.net/images/characters/8/66478.jpg", 1, "Uruchi Uchiha", 0 },
                    { 165, "https://cdn.myanimelist.net/images/characters/10/86804.jpg", 1, "Tsuba ", 0 },
                    { 166, "https://cdn.myanimelist.net/images/characters/10/66502.jpg", 1, "Shiore ", 0 },
                    { 167, "https://cdn.myanimelist.net/images/characters/2/104661.jpg", 1, "Suzume ", 0 },
                    { 168, "https://cdn.myanimelist.net/images/characters/9/86788.jpg", 1, "Shimon Hijiri", 0 },
                    { 169, "https://cdn.myanimelist.net/images/characters/10/66501.jpg", 1, "Shibire ", 0 },
                    { 170, "https://cdn.myanimelist.net/images/characters/6/86794.jpg", 1, "Sagi ", 0 },
                    { 171, "https://cdn.myanimelist.net/images/characters/8/66154.jpg", 1, "Guruko ", 0 },
                    { 172, "https://cdn.myanimelist.net/images/characters/9/66507.jpg", 1, "Iwashi Tatami", 0 },
                    { 173, "https://cdn.myanimelist.net/images/characters/12/66500.jpg", 1, "Tobio ", 0 },
                    { 174, "https://cdn.myanimelist.net/images/characters/10/70340.jpg", 1, "Kotohime Fuuma", 0 },
                    { 175, "https://cdn.myanimelist.net/images/characters/8/86789.jpg", 1, "Idate Morino", 0 },
                    { 176, "https://cdn.myanimelist.net/images/characters/16/92486.jpg", 1, "Bisuke ", 0 },
                    { 177, "https://cdn.myanimelist.net/images/characters/10/103617.jpg", 1, "Manda ", 0 },
                    { 178, "https://cdn.myanimelist.net/images/characters/3/112579.jpg", 1, "Ukon ", 0 },
                    { 179, "https://cdn.myanimelist.net/images/characters/4/120598.jpg", 1, "Kunihisa ", 0 },
                    { 180, "https://cdn.myanimelist.net/images/characters/3/120599.jpg", 1, "Kunijirou ", 0 },
                    { 181, "https://cdn.myanimelist.net/images/characters/3/120890.jpg", 1, "Matsuri ", 0 },
                    { 182, "https://cdn.myanimelist.net/images/characters/13/140139.jpg", 1, "Ran ", 0 },
                    { 183, "https://cdn.myanimelist.net/images/characters/13/168503.jpg", 1, "Gatou ", 0 },
                    { 184, "https://cdn.myanimelist.net/images/characters/13/175237.jpg", 1, "Mebuki Haruno", 0 },
                    { 185, "https://cdn.myanimelist.net/images/characters/9/193691.jpg", 1, "Natsuhi ", 0 },
                    { 186, "https://cdn.myanimelist.net/images/characters/15/202941.jpg", 1, "Sumaru ", 0 },
                    { 187, "https://cdn.myanimelist.net/images/characters/11/205357.jpg", 1, "Gantetsu ", 0 },
                    { 188, "https://cdn.myanimelist.net/images/characters/9/214103.jpg", 1, "Haku's Mother ", 0 },
                    { 189, "https://cdn.myanimelist.net/images/characters/4/218401.jpg", 1, "Tonton ", 0 },
                    { 190, "https://cdn.myanimelist.net/images/characters/3/218873.jpg", 1, "Kujaku ", 0 },
                    { 191, "https://cdn.myanimelist.net/images/characters/6/283833.jpg", 1, "Unkai Kurama", 0 },
                    { 192, "https://cdn.myanimelist.net/images/characters/12/325684.jpg", 1, "Iwana Akame", 0 },
                    { 193, "https://cdn.myanimelist.net/images/characters/6/325683.jpg", 1, "Bekkou ", 0 },
                    { 194, "https://cdn.myanimelist.net/images/characters/14/325681.jpg", 1, "Ibara ", 0 },
                    { 195, "https://cdn.myanimelist.net/images/characters/13/325682.jpg", 1, "Tsubaki ", 0 },
                    { 196, "https://cdn.myanimelist.net/images/characters/12/355456.jpg", 1, "Fukuyokana ", 0 },
                    { 197, "https://cdn.myanimelist.net/images/characters/15/355457.jpg", 1, "Shinayakana ", 0 },
                    { 198, "https://cdn.myanimelist.net/images/characters/7/464787.jpg", 1, "Sanshou ", 0 },
                    { 199, "https://cdn.myanimelist.net/images/characters/6/444635.jpg", 1, "Kurobachi Kamizuru", 0 },
                    { 200, "https://cdn.myanimelist.net/images/characters/13/444636.jpg", 1, "Suzumebachi Kamizuru", 0 },
                    { 201, "https://cdn.myanimelist.net/images/characters/15/464788.jpg", 1, "Momiji ", 0 },
                    { 202, "https://cdn.myanimelist.net/images/characters/9/464790.jpg", 1, "Kagero ", 0 },
                    { 203, "https://cdn.myanimelist.net/images/characters/16/464791.jpg", 1, "Raijin ", 0 },
                    { 204, "https://cdn.myanimelist.net/images/characters/15/464793.jpg", 1, "Fuujin ", 0 },
                    { 205, "https://cdn.myanimelist.net/images/characters/10/464794.jpg", 1, "Koumei ", 0 },
                    { 206, "https://cdn.myanimelist.net/images/characters/3/464795.jpg", 1, "Ruiga ", 0 },
                    { 207, "https://cdn.myanimelist.net/images/characters/8/508743.jpg", 1, "Futa Kagetsu", 0 },
                    { 208, "https://cdn.myanimelist.net/images/characters/12/508744.jpg", 1, "Toubei Kagetsu", 0 },
                    { 209, "https://cdn.myanimelist.net/images/characters/5/508745.jpg", 1, "Tsukiko Kagetsu", 0 },
                    { 210, "https://cdn.myanimelist.net/images/characters/7/508742.jpg", 1, "Mai Kagetsu", 0 },
                    { 211, "https://cdn.myanimelist.net/images/characters/6/508741.jpg", 1, "Kikunojou ", 0 },
                    { 212, "https://cdn.myanimelist.net/images/characters/11/508740.jpg", 1, "Shura Sanjurou", 0 },
                    { 213, "https://cdn.myanimelist.net/images/characters/2/508923.jpg", 1, "Yurinojou ", 0 },
                    { 214, "https://cdn.myanimelist.net/images/characters/3/508924.jpg", 1, "Hanzaki ", 0 },
                    { 215, "https://cdn.myanimelist.net/images/characters/2/508925.jpg", 1, "Houki ", 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_FranchiseId",
                table: "Characters",
                column: "FranchiseId");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_CharacterId",
                table: "Matches",
                column: "CharacterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Franchises");
        }
    }
}

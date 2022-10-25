using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationCore.Migrations
{
    public partial class SeedCheck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Texts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Texts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TextId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Texts_TextId",
                        column: x => x.TextId,
                        principalTable: "Texts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SymbolsPerMinute = table.Column<float>(type: "real", nullable: false),
                    Accuracy = table.Column<float>(type: "real", nullable: false),
                    NumberOfMistakes = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SharedVia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TextId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statistics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statistics_Texts_TextId",
                        column: x => x.TextId,
                        principalTable: "Texts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Statistics_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StatisticsAVG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    AvgSymbolsPerMin = table.Column<float>(type: "real", nullable: false),
                    AvgAccuracy = table.Column<float>(type: "real", nullable: false),
                    AvgTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextsCount = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatisticsAVG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatisticsAVG_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    SignUpAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThemeColors = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInfos_Users_Id",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Texts",
                columns: new[] { "Id", "Author", "CreatedAt", "CreatedBy", "Language", "LastModifiedAt", "LastModifiedBy", "Level", "TextContent" },
                values: new object[,]
                {
                    { 1, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9870), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 4, "this is a simple found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho" },
                    { 2, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9875), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 5, "this is a simple paragraph that is meant to be nice and easy to type which is why there will be mommas no periods or any capital letters so i guess this means that it cannot really be considered a paragraph but just a series of run on sentences this should help you get faster at typing as im trying not to use too many difficult words in it although i think that i might start making it hard by including some more difficult letters I'm typing pretty quickly so forgive me for any mistakes i think that i will not just tell you a story about the time i went to the zoo and found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho" },
                    { 3, "Author3", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9878), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Romanian", null, null, 4, "Orice persoana are dreptul la învăţătură. Invăţămîntul trebuie să fie gratuit, cel puţin în ceea ce priveşte invăţămîntul elementar şi general. Invăţămîntul elementar trebuie să fie obligatoriu. Invăţămîntul tehnic şi profesional trebuie să fie la îndemîna tuturor, iar învăţămîntul superior trebuie să fie de asemenea egal, accesibil tuturora, pe bază de merit." },
                    { 4, "Author3", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9880), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Romanian", null, null, 3, "Fiecare om are dreptul la ocrotirea intereselor morale şi materiale care decurg din orice lucrare ştiinţifică, literară sau artistică al cărei autor este." },
                    { 5, "Author3", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9883), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Romanian", null, null, 2, "Părinţii au dreptul de prioritate în alegerea felului de învăţămînt pentru copiii lor minori." },
                    { 6, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9886), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 5, "Everyone has the right to education. Education shall be free, at least in the elementary and fundamental stages. Elementary education shall be compulsory. Technical and professional education shall be made generally available and higher education shall be equally accessible to all on the basis of merit." },
                    { 7, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9889), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 3, "Everyone has the right freely to participate in the cultural life of the community, to enjoy the arts and to share in scientific advancement and its benefits." },
                    { 8, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9891), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 2, "Parents have a prior right to choose the kind of education that shall be given to their children." },
                    { 9, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9894), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 4, "Reading and comprehension are very important in Romanian. Once you're done with Romanian Reading, you might want to check the rest of our Romanian lessons here: Learn Romanian. Don't forget to bookmark this page." },
                    { 10, "Author1", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9897), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, 1, "The links above are only a small sample of our lessons, please open the left side menu to see all links." },
                    { 11, "Author2", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9900), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, 4, "Колобок полежал, полежал, взял да и покатился — с окна на лавку, с лавки на пол, по полу к двери, прыг через порог — да в сени, из сеней на крыльцо, с крыльца на двор, со двора за ворота, дальше и дальше." },
                    { 12, "Author2", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9902), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, 5, "Затрещал теремок, упал набок и весь развалился. Еле-еле успели из него выскочить мышка-норушка, лягушка-квакушка, зайчик-побегайчик, лисичка-сестричка, волчок-серый бочок — все целы и невредимы." },
                    { 13, "Author2", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9905), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, 3, "Волку делать нечего. Пошел он в кузницу и велел себе горло перековать, чтоб петь тонюсеньким голосом. Кузнец ему горло перековал. Волк опять побежал к избушке и спрятался за куст." },
                    { 14, "Author2", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9907), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, 5, "Три медведя — сказка о девочке, которая заблудилась в лесу и попала в домик медведей. Там она повела себя очень невоспитанно: без разрешения поела из каждой чашки, посидела на каждом стульчике, полежала в каждой кроватке, что очень разозлило вернувшихся домой медведей. Сказка представлена в изложении Л.Н. Толстого." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Age", "CreatedAt", "CreatedBy", "Email", "FirstName", "Gender", "IsAdmin", "LastModifiedAt", "LastModifiedBy", "LastName", "Password" },
                values: new object[,]
                {
                    { 1, 22, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2811), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "admin@admin.com", "Admin", "M", true, null, null, "Admin", "adminadmin" },
                    { 2, 23, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2835), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "dinalups@google.com", "Dina", "F", false, null, null, "Lupsha", "32rg342k3" },
                    { 3, 25, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2839), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "lenkapenka@yahoo.com", "Elena", "F", false, null, null, "Yarynych", "vvkkkdan" },
                    { 4, 31, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2842), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "svetkach@mail.ru", "Svetlana", "F", false, null, null, "Soltic", "chuwinss" },
                    { 5, 41, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2844), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "vasssty@google.com", "Igor", "M", false, null, null, "Ejov", "ejejejeje" },
                    { 6, 27, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2848), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "nastinasti@yahoo.com", "Anastasia", "F", false, null, null, "Pantelei", "barbarbar" },
                    { 7, 45, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2851), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "sergosergo@simpals.md", "Serghei", "M", false, null, null, "Romanenco", "barbarbar" },
                    { 8, 30, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2854), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "ivaia@google.com", "Ivan", "M", false, null, null, "Veselov", "veseloveselo" },
                    { 9, 36, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2857), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "serenawww@yahoo.com", "Serena", "F", false, null, null, "Williams", "tennistennis" },
                    { 10, 41, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2860), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "nadinadi@mail.ru", "Nadejda", "F", false, null, null, "Romanenco", "habibihabibi" },
                    { 11, 24, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2863), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "ionvasisis@google.com", "Ivan", "M", false, null, null, "Vasilashco", "internintern" },
                    { 12, 26, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2866), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "yankinan@google.com", "Anastasia", "F", false, null, null, "Yankina", "photophoto" },
                    { 13, 22, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2868), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "adriadri@yahoo.com", "Adriana", "F", false, null, null, "Rindunica", "ffwf43rf4" },
                    { 14, 22, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2871), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "ponama@mail.ru", "Daria", "F", false, null, null, "Ponomarenko", "artartart" }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageTitle", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3075), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://typostorage.blob.core.windows.net/avatars/avatar0.png", null, null, 1 },
                    { 2, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3080), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=JtJaspHm&id=25BA92485437ADD293D9BBF75B532069F59D5076&thid=OIP.JtJaspHmOW0-1H3eitKsjAAAAA&mediaurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.26d25ab291e6396d3ed47dde8ad2ac8c%3Frik%3DdlCd9WkgU1v3uw%26riu%3Dhttp%253a%252f%252finaga-api.or.id%252fasset%252fbackend%252fupload%252ftheboard%252fBoD_no_photo_f2.jpg%26ehk%3DAJFE9VB1TP75iGSvo8dy3R7n%252f5U0gR0eb9p0xdoLR2M%253d%26risl%3D%26pid%3DImgRaw%26r%3D0&exph=520&expw=474&q=avatars+for+sites+woman&simid=608054944566876018&form=IRPRST&ck=0AEC1786E5825A9BBB8A870A4320126E&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_FbkxL9bA*cp_AD984D00405C718B3A6D04AD566BE045*mid_1999E3C273B3A08BFCB743F2AC51C281B030F9C9*simid_608014030705879451*thid_OIP.FbkxL9bAzFsI4gYWt1AU5AAAAA&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0", null, null, 2 },
                    { 3, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3083), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=0m3pRsk%2B&id=FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714&thid=OIP.0m3pRsk-byuSMJLki7OR4AHaIP&mediaurl=https%3A%2F%2Fwww.justwomanthings.com%2Fwp-content%2Fuploads%2F2017%2F10%2Ffavicon.png&exph=664&expw=597&q=avatars+for+sites+woman&simid=608018377213875942&form=IRPRST&ck=EAD721E1E55EB3116BF38FD907D672D5&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_JtJaspHm*cp_0AEC1786E5825A9BBB8A870A4320126E*mid_25BA92485437ADD293D9BBF75B532069F59D5076*simid_608054944566876018*thid_OIP.JtJaspHmOW0-1H3eitKsjAAAAA&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.d26de946c93e6f2b923092e48bb391e0%3Frik%3DFBcetPTVnM9B3g%26pid%3DImgRaw%26r%3D0&ajaxhist=0&ajaxserp=0", null, null, 3 },
                    { 4, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3085), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=tvgdD7R%2B&id=DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4&thid=OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Fpeppyicons%2F512%2Fwomen_red-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8C0B660E5459F765CCA7B23AACD5864B&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_0m3pRsk%252B*cp_EAD721E1E55EB3116BF38FD907D672D5*mid_FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714*simid_608018377213875942*thid_OIP.0m3pRsk-byuSMJLki7OR4AHaIP&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.b6f81d0fb47e74317d8dcc5471db7e98%3Frik%3D1BB9znSCiPjbgA%26pid%3DImgRaw%26r%3D0", null, null, 4 },
                    { 5, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3088), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=k5drJ44P&id=EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36&thid=OIP.k5drJ44P_6vXHJjKuuTaYwHaHW&mediaurl=https%3a%2f%2flaunchwebsitedesign.com%2fwp-content%2fuploads%2f2017%2f09%2fjosh-d-avatar.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.93976b278e0fffabd71c98cabae4da63%3frik%3dNgy07nZ1xa834Q%26pid%3dImgRaw%26r%3d0&exph=656&expw=661&q=avatars+for+sites&simid=607992242342948935&FORM=IRPRST&ck=9F5B9425E6390AD08E36568A701BC0A8&selectedIndex=0&ajaxhist=0&ajaxserp=0", null, null, 5 },
                    { 6, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3091), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=QXxS8HEX&id=652F714CDD9E207902418767156C2A75B8F1DB60&thid=OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Fjetflat-2-people%2F60%2F005_036_woman_girl_user_human_avatar-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8227DE09D92787ADB2D381C3EA426A63&selectedindex=7&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_tvgdD7R%252B*cp_8C0B660E5459F765CCA7B23AACD5864B*mid_DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4*thid_OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.417c52f07117a1e9175cb468d41cf03c%3Frik%3DYNvxuHUqbBVnhw%26pid%3DImgRaw%26r%3D0", null, null, 6 },
                    { 7, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3093), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=2n8TROKP&id=74C616EF6C56DCEDEF60D9B50077E10BA10320B0&thid=OIP.2n8TROKPogruE84yLS6_AwHaHa&mediaurl=https%3A%2F%2Fwww.cashygo.in%2Fstatic%2Fweb%2Fimages%2Fexecutive.png&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.da7f1344e28fa20aee13ce322d2ebf03%3Frik%3DsCADoQvhdwC12Q%26pid%3DImgRaw%26r%3D0&exph=512&expw=512&q=avatars+for+sites&form=IRPRST&ck=299DBFCAFF10B3D5A73A91EF93153F1D&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_k5drJ44P*cp_9F5B9425E6390AD08E36568A701BC0A8*mid_EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36*simid_607992242342948935*thid_OIP.k5drJ44P!_6vXHJjKuuTaYwHaHW&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0", null, null, 7 },
                    { 8, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3096), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=iN2B0esp&id=A38E6B6419DCB48C099DF633ED08A32D6677EC8C&thid=OIP.iN2B0espKShXbt0BZmC_mwHaHa&mediaurl=https%3A%2F%2Fyt3.ggpht.com%2Fa%2FAATXAJwd0xEzFWMgYTJxhEzDgR2jsBhr38rVVYLGrA%3Ds900-c-k-c0xffffffff-no-rj-mo&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.88dd81d1eb292928576edd016660bf9b%3Frik%3DjOx3Zi2jCO0z9g%26pid%3DImgRaw%26r%3D0&exph=900&expw=900&q=avatars+for+sites&form=IRPRST&ck=89EE8126ADA32A92A48F04A90093C618&selectedindex=10&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_2n8TROKP*cp_299DBFCAFF10B3D5A73A91EF93153F1D*mid_74C616EF6C56DCEDEF60D9B50077E10BA10320B0*thid_OIP.2n8TROKPogruE84yLS6!_AwHaHa&vt=0&sim=11&iss=VSI&simid=608019931989018767&ajaxhist=0&ajaxserp=0", null, null, 8 },
                    { 9, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3098), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=gUWziU4q&id=575E4366F81F16B6E1150B93A05A24C28C951F88&thid=OIP.gUWziU4qIlj65_ptewq-9gHaJH&mediaurl=https%3A%2F%2Fwww.netclipart.com%2Fpp%2Fm%2F324-3244180_clean-madurai-housekeeping-services-lady-icon-png.png&exph=1132&expw=920&q=avatars+for+sites+woman&form=IRPRST&ck=AA7620D583CFF2F9185EFFFBE6F8C2B1&selectedindex=22&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.8145b3894e2a2258fae7fa6d7b0abef6%3Frik%3DiB%252bVjMIkWqCTCw%26pid%3DImgRaw%26r%3D0&simid=607994102039707919", null, null, 9 },
                    { 10, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3101), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=gQAod8xN&id=5C062313C68BB599A936E6DD7A9AC1661166D13A&thid=OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&mediaurl=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F74%2Fda%2F07%2F74da07214279d76f9809b9c3943f23e6.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=9E1ECE6649A7EFDF03D173C8E6E75746&selectedindex=11&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.81002877cc4d4ce2736f0e2fe58d621b%3Frik%3DOtFmEWbBmnrd5g%26pid%3DImgRaw%26r%3D0", null, null, 10 },
                    { 11, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3104), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=ovgXQqWa&id=AB355EFFA65C532F535225C443639DD144DF6333&thid=OIP.ovgXQqWaC82lHgt2V2vxvQHaHa&mediaurl=https%3A%2F%2Fvectorified.com%2Fimage%2Fminimalist-vector-25.jpg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.a2f81742a59a0bcda51e0b76576bf1bd%3Frik%3DM2PfRNGdY0PEJQ%26pid%3DImgRaw%26r%3D0&exph=600&expw=600&q=avatars+for+sites&form=IRPRST&ck=10855C420BF2DC89C6C6AA947D217B5C&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_iN2B0esp*cp_89EE8126ADA32A92A48F04A90093C618*mid_A38E6B6419DCB48C099DF633ED08A32D6677EC8C*simid_608019931989018767*thid_OIP.iN2B0espKShXbt0BZmC!_mwHaHa&vt=0&sim=11&iss=VSI&simid=607995094195911121&ajaxhist=0&ajaxserp=0", null, null, 11 },
                    { 12, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3106), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=GSoBhvI8&id=1D47E63784BA983FC0BEA2430B49F43EFFAA5424&thid=OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Ffamous-character-vol-2-flat%2F48%2FAvatar_Famous_Characters-08-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=4379DFD07D7557F3593324DBE13D5E6F&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_gQAod8xN*cp_9E1ECE6649A7EFDF03D173C8E6E75746*mid_5C062313C68BB599A936E6DD7A9AC1661166D13A*thid_OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.192a0186f23ca4d080a7d13818024523%3Frik%3DJFSq%252fz70SQtDog%26pid%3DImgRaw%26r%3D0&simid=608047059002875774", null, null, 12 },
                    { 13, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3109), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=UTiUwZi%2B&id=6DB608234240B457D5271CE6F4F7EE64990AE485&thid=OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&mediaurl=https%3A%2F%2Fcdn3.iconfinder.com%2Fdata%2Ficons%2Favatars-collection%2F256%2F35-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=1BEDCB9CA70115141BE0AF964A1B7F0E&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_GSoBhvI8*cp_4379DFD07D7557F3593324DBE13D5E6F*mid_1D47E63784BA983FC0BEA2430B49F43EFFAA5424*simid_608047059002875774*thid_OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.513894c198bee425a7c4db4bea3ba4e1%3Frik%3DheQKmWTu9%252fTmHA%26pid%3DImgRaw%26r%3D0&simid=608055017578107125", null, null, 13 },
                    { 14, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3111), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=xcUOt8Fa&id=FA221020C09F8D44E5FA6469ABDE90A35E306CC5&thid=OIP.xcUOt8FaKZgLEY3G3O0VlgHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Favatars-2-7%2F128%2F47-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=F8412316D65B44228F183A4F546C0D97&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_UTiUwZi%252B*cp_1BEDCB9CA70115141BE0AF964A1B7F0E*mid_6DB608234240B457D5271CE6F4F7EE64990AE485*simid_608055017578107125*thid_OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.c5c50eb7c15a29980b118dc6dced1596%3Frik%3DxWwwXqOQ3qtpZA%26pid%3DImgRaw%26r%3D0&simid=608043257958332659", null, null, 14 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "ReviewContent", "TextId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9965), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content1", 1, 1 },
                    { 2, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9970), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content2", 2, 2 },
                    { 3, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9973), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content3", 3, 3 },
                    { 4, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9975), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content4", 4, 4 },
                    { 5, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9978), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content5", 5, 5 },
                    { 6, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9981), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content6", 6, 6 },
                    { 7, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9984), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content7", 7, 7 },
                    { 8, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9986), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content8", 8, 8 },
                    { 9, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9989), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content9", 9, 9 },
                    { 10, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9992), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content10", 10, 10 },
                    { 11, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9994), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content11", 11, 11 },
                    { 12, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9997), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content12", 12, 12 },
                    { 13, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9999), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content13", 13, 13 },
                    { 14, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, "Content14", 14, 14 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "Accuracy", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "NumberOfMistakes", "SharedVia", "SymbolsPerMinute", "TextId", "Time", "UserId" },
                values: new object[,]
                {
                    { 1, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2976), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 1, "02:30", 1 },
                    { 2, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 2, "02:30", 2 },
                    { 3, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2985), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 3, "02:30", 3 },
                    { 4, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2988), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 4, "02:30", 4 },
                    { 5, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2990), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 5, "02:30", 5 },
                    { 6, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2994), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 6, "02:30", 6 },
                    { 7, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2997), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 7, "02:30", 7 },
                    { 8, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(2999), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 8, "02:30", 8 },
                    { 9, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3002), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 9, "02:30", 9 },
                    { 10, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3005), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 10, "02:30", 10 },
                    { 11, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3008), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 11, "02:30", 11 },
                    { 12, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3011), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 12, "02:30", 12 },
                    { 13, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3013), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 13, "02:30", 13 },
                    { 14, 68.7f, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(3016), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 14, "02:30", 14 }
                });

            migrationBuilder.InsertData(
                table: "StatisticsAVG",
                columns: new[] { "Id", "AvgAccuracy", "AvgSymbolsPerMin", "AvgTime", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "TextsCount" },
                values: new object[,]
                {
                    { 1, 57f, 32.43f, "03:12", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(67), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 21 },
                    { 2, 68f, 42.21f, "02:48", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(72), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 3 },
                    { 3, 78f, 55.01f, "04:24", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(75), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 32 },
                    { 4, 83f, 121.17f, "03:04", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(77), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 81 },
                    { 5, 67f, 45.91f, "05:35", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(80), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 17 },
                    { 6, 80f, 51.56f, "03:00", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(83), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 26 },
                    { 7, 61f, 48.42f, "03:28", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(85), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 6 },
                    { 8, 73f, 65.23f, "06:27", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(88), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 25 },
                    { 9, 72f, 54.25f, "03:53", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(90), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 43 },
                    { 10, 57f, 43.63f, "03:03", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(94), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 24 },
                    { 11, 79f, 67.56f, "03:33", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(96), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 58 },
                    { 12, 74f, 54.23f, "02:09", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(99), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 99 },
                    { 13, 62f, 34f, "03:34", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(101), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 51 },
                    { 14, 19f, 58.28f, "04:39", new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 233, DateTimeKind.Unspecified).AddTicks(104), new TimeSpan(0, 3, 0, 0, 0)), "Seed", null, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Language", "LastModifiedAt", "LastModifiedBy", "SignUpAt", "ThemeColors" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9675), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9639), null },
                    { 2, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9698), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9696), null },
                    { 3, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9702), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9701), null },
                    { 4, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9706), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9705), null },
                    { 5, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9709), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9708), null },
                    { 6, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9715), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9714), null },
                    { 7, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9719), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Romanian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9718), null },
                    { 8, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9722), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9721), null },
                    { 9, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9726), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9725), null },
                    { 10, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9730), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9729), null },
                    { 11, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9733), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9732), null },
                    { 12, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9736), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9735), null },
                    { 13, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9761), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9760), null },
                    { 14, new DateTimeOffset(new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Unspecified).AddTicks(9765), new TimeSpan(0, 3, 0, 0, 0)), "Seed", "Romanian", null, null, new DateTime(2022, 10, 25, 17, 53, 3, 232, DateTimeKind.Local).AddTicks(9764), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserId",
                table: "Images",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_TextId",
                table: "Reviews",
                column: "TextId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_TextId",
                table: "Statistics",
                column: "TextId");

            migrationBuilder.CreateIndex(
                name: "IX_Statistics_UserId",
                table: "Statistics",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Statistics");

            migrationBuilder.DropTable(
                name: "StatisticsAVG");

            migrationBuilder.DropTable(
                name: "UserInfos");

            migrationBuilder.DropTable(
                name: "Texts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

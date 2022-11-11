using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApplicationCore.Migrations
{
    public partial class Init : Migration
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
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    RowVersion = table.Column<byte[]>(type: "rowversion", rowVersion: true, nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
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
                    { 1, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2078), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 4, "this is a simple found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho" },
                    { 2, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2088), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 5, "this is a simple paragraph that is meant to be nice and easy to type which is why there will be mommas no periods or any capital letters so i guess this means that it cannot really be considered a paragraph but just a series of run on sentences this should help you get faster at typing as im trying not to use too many difficult words in it although i think that i might start making it hard by including some more difficult letters I'm typing pretty quickly so forgive me for any mistakes i think that i will not just tell you a story about the time i went to the zoo and found a monkey and a fox playing together they were so cute and i think that they were not supposed to be in the same cage but they someho" },
                    { 3, "Author3", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2091), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Romanian", null, null, 4, "Orice persoana are dreptul la învăţătură. Invăţămîntul trebuie să fie gratuit, cel puţin în ceea ce priveşte invăţămîntul elementar şi general. Invăţămîntul elementar trebuie să fie obligatoriu. Invăţămîntul tehnic şi profesional trebuie să fie la îndemîna tuturor, iar învăţămîntul superior trebuie să fie de asemenea egal, accesibil tuturora, pe bază de merit." },
                    { 4, "Author3", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2094), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Romanian", null, null, 3, "Fiecare om are dreptul la ocrotirea intereselor morale şi materiale care decurg din orice lucrare ştiinţifică, literară sau artistică al cărei autor este." },
                    { 5, "Author3", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2096), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Romanian", null, null, 2, "Părinţii au dreptul de prioritate în alegerea felului de învăţămînt pentru copiii lor minori." },
                    { 6, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2100), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 5, "Everyone has the right to education. Education shall be free, at least in the elementary and fundamental stages. Elementary education shall be compulsory. Technical and professional education shall be made generally available and higher education shall be equally accessible to all on the basis of merit." },
                    { 7, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2102), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 3, "Everyone has the right freely to participate in the cultural life of the community, to enjoy the arts and to share in scientific advancement and its benefits." },
                    { 8, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2105), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 2, "Parents have a prior right to choose the kind of education that shall be given to their children." },
                    { 9, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2108), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 4, "Reading and comprehension are very important in Romanian. Once you're done with Romanian Reading, you might want to check the rest of our Romanian lessons here: Learn Romanian. Don't forget to bookmark this page." },
                    { 10, "Author1", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2111), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, 1, "The links above are only a small sample of our lessons, please open the left side menu to see all links." },
                    { 11, "Author2", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2113), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, 4, "Колобок полежал, полежал, взял да и покатился — с окна на лавку, с лавки на пол, по полу к двери, прыг через порог — да в сени, из сеней на крыльцо, с крыльца на двор, со двора за ворота, дальше и дальше." },
                    { 12, "Author2", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2116), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, 5, "Затрещал теремок, упал набок и весь развалился. Еле-еле успели из него выскочить мышка-норушка, лягушка-квакушка, зайчик-побегайчик, лисичка-сестричка, волчок-серый бочок — все целы и невредимы." },
                    { 13, "Author2", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2119), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, 3, "Волку делать нечего. Пошел он в кузницу и велел себе горло перековать, чтоб петь тонюсеньким голосом. Кузнец ему горло перековал. Волк опять побежал к избушке и спрятался за куст." },
                    { 14, "Author2", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2121), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, 5, "Три медведя — сказка о девочке, которая заблудилась в лесу и попала в домик медведей. Там она повела себя очень невоспитанно: без разрешения поела из каждой чашки, посидела на каждом стульчике, полежала в каждой кроватке, что очень разозлило вернувшихся домой медведей. Сказка представлена в изложении Л.Н. Толстого." }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Age", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Email", "EmailConfirmed", "FirstName", "Gender", "IsAdmin", "LastModifiedAt", "LastModifiedBy", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, 22, "5f9d19a6-65b1-40e8-938b-08c6a3f87030", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5350), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "admin@admin.com", false, "Admin", "M", true, null, null, "Admin", false, null, null, null, "adminadmin", null, null, false, null, false, null },
                    { 2, 0, 23, "09e05d3b-a0a0-4252-a216-00a9811a2890", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5370), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "dinalups@google.com", false, "Dina", "F", false, null, null, "Lupsha", false, null, null, null, "32rg342k3", null, null, false, null, false, null },
                    { 3, 0, 25, "aef1e644-2f5e-4083-ada7-1dbf46799dae", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5386), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "lenkapenka@yahoo.com", false, "Elena", "F", false, null, null, "Yarynych", false, null, null, null, "vvkkkdan", null, null, false, null, false, null },
                    { 4, 0, 31, "f9c00313-5b54-4ae5-8253-25ac8c5e28df", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5391), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "svetkach@mail.ru", false, "Svetlana", "F", false, null, null, "Soltic", false, null, null, null, "chuwinss", null, null, false, null, false, null },
                    { 5, 0, 41, "01b92d57-7f2c-48b3-a19a-e285112a4a8d", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5395), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "vasssty@google.com", false, "Igor", "M", false, null, null, "Ejov", false, null, null, null, "ejejejeje", null, null, false, null, false, null },
                    { 6, 0, 27, "f8bba011-61cc-48a4-a00d-e0b66d62bf48", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5401), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "nastinasti@yahoo.com", false, "Anastasia", "F", false, null, null, "Pantelei", false, null, null, null, "barbarbar", null, null, false, null, false, null },
                    { 7, 0, 45, "05684f37-a7dd-4bf0-8d0e-f95ef0006777", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5405), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "sergosergo@simpals.md", false, "Serghei", "M", false, null, null, "Romanenco", false, null, null, null, "barbarbar", null, null, false, null, false, null },
                    { 8, 0, 30, "f171f120-5ed4-422f-96e8-2409089f70c2", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5409), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "ivaia@google.com", false, "Ivan", "M", false, null, null, "Veselov", false, null, null, null, "veseloveselo", null, null, false, null, false, null },
                    { 9, 0, 36, "eb92eef9-3035-4198-a1f4-2fcbcb6abb18", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5413), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "serenawww@yahoo.com", false, "Serena", "F", false, null, null, "Williams", false, null, null, null, "tennistennis", null, null, false, null, false, null },
                    { 10, 0, 41, "f3acfdb4-dfc1-41cb-a481-aa8b5fa6f118", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5419), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "nadinadi@mail.ru", false, "Nadejda", "F", false, null, null, "Romanenco", false, null, null, null, "habibihabibi", null, null, false, null, false, null },
                    { 11, 0, 24, "ded7f47e-52f9-4724-8678-14e574085183", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5425), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "ionvasisis@google.com", false, "Ivan", "M", false, null, null, "Vasilashco", false, null, null, null, "internintern", null, null, false, null, false, null },
                    { 12, 0, 26, "5f83da96-4a94-40ee-8e16-066287dddece", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5429), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "yankinan@google.com", false, "Anastasia", "F", false, null, null, "Yankina", false, null, null, null, "photophoto", null, null, false, null, false, null },
                    { 13, 0, 22, "7ac7378c-72cb-45b8-8de4-1ba8e924a1f8", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5433), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "adriadri@yahoo.com", false, "Adriana", "F", false, null, null, "Rindunica", false, null, null, null, "ffwf43rf4", null, null, false, null, false, null },
                    { 14, 0, 22, "07109412-a265-4d48-8839-ddb9d9021aa3", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5438), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "ponama@mail.ru", false, "Daria", "F", false, null, null, "Ponomarenko", false, null, null, null, "artartart", null, null, false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ImageTitle", "LastModifiedAt", "LastModifiedBy", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5664), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://typostorage.blob.core.windows.net/avatars/avatar0.png", null, null, 1 },
                    { 2, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5668), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=JtJaspHm&id=25BA92485437ADD293D9BBF75B532069F59D5076&thid=OIP.JtJaspHmOW0-1H3eitKsjAAAAA&mediaurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.26d25ab291e6396d3ed47dde8ad2ac8c%3Frik%3DdlCd9WkgU1v3uw%26riu%3Dhttp%253a%252f%252finaga-api.or.id%252fasset%252fbackend%252fupload%252ftheboard%252fBoD_no_photo_f2.jpg%26ehk%3DAJFE9VB1TP75iGSvo8dy3R7n%252f5U0gR0eb9p0xdoLR2M%253d%26risl%3D%26pid%3DImgRaw%26r%3D0&exph=520&expw=474&q=avatars+for+sites+woman&simid=608054944566876018&form=IRPRST&ck=0AEC1786E5825A9BBB8A870A4320126E&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_FbkxL9bA*cp_AD984D00405C718B3A6D04AD566BE045*mid_1999E3C273B3A08BFCB743F2AC51C281B030F9C9*simid_608014030705879451*thid_OIP.FbkxL9bAzFsI4gYWt1AU5AAAAA&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0", null, null, 2 },
                    { 3, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5671), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=0m3pRsk%2B&id=FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714&thid=OIP.0m3pRsk-byuSMJLki7OR4AHaIP&mediaurl=https%3A%2F%2Fwww.justwomanthings.com%2Fwp-content%2Fuploads%2F2017%2F10%2Ffavicon.png&exph=664&expw=597&q=avatars+for+sites+woman&simid=608018377213875942&form=IRPRST&ck=EAD721E1E55EB3116BF38FD907D672D5&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_JtJaspHm*cp_0AEC1786E5825A9BBB8A870A4320126E*mid_25BA92485437ADD293D9BBF75B532069F59D5076*simid_608054944566876018*thid_OIP.JtJaspHmOW0-1H3eitKsjAAAAA&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.d26de946c93e6f2b923092e48bb391e0%3Frik%3DFBcetPTVnM9B3g%26pid%3DImgRaw%26r%3D0&ajaxhist=0&ajaxserp=0", null, null, 3 },
                    { 4, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5673), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=tvgdD7R%2B&id=DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4&thid=OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Fpeppyicons%2F512%2Fwomen_red-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8C0B660E5459F765CCA7B23AACD5864B&selectedindex=5&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_0m3pRsk%252B*cp_EAD721E1E55EB3116BF38FD907D672D5*mid_FC1097DBC6F62EFAC0C5DE41CF9CD5F4B41E1714*simid_608018377213875942*thid_OIP.0m3pRsk-byuSMJLki7OR4AHaIP&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.b6f81d0fb47e74317d8dcc5471db7e98%3Frik%3D1BB9znSCiPjbgA%26pid%3DImgRaw%26r%3D0", null, null, 4 },
                    { 5, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5675), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=k5drJ44P&id=EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36&thid=OIP.k5drJ44P_6vXHJjKuuTaYwHaHW&mediaurl=https%3a%2f%2flaunchwebsitedesign.com%2fwp-content%2fuploads%2f2017%2f09%2fjosh-d-avatar.jpg&cdnurl=https%3a%2f%2fth.bing.com%2fth%2fid%2fR.93976b278e0fffabd71c98cabae4da63%3frik%3dNgy07nZ1xa834Q%26pid%3dImgRaw%26r%3d0&exph=656&expw=661&q=avatars+for+sites&simid=607992242342948935&FORM=IRPRST&ck=9F5B9425E6390AD08E36568A701BC0A8&selectedIndex=0&ajaxhist=0&ajaxserp=0", null, null, 5 },
                    { 6, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5678), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=QXxS8HEX&id=652F714CDD9E207902418767156C2A75B8F1DB60&thid=OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Fjetflat-2-people%2F60%2F005_036_woman_girl_user_human_avatar-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=8227DE09D92787ADB2D381C3EA426A63&selectedindex=7&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_tvgdD7R%252B*cp_8C0B660E5459F765CCA7B23AACD5864B*mid_DF7EF5F4FD90852E21CD80DBF8888274CE7D10D4*thid_OIP.tvgdD7R-dDF9jcxUcdt-mAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.417c52f07117a1e9175cb468d41cf03c%3Frik%3DYNvxuHUqbBVnhw%26pid%3DImgRaw%26r%3D0", null, null, 6 },
                    { 7, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5681), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=2n8TROKP&id=74C616EF6C56DCEDEF60D9B50077E10BA10320B0&thid=OIP.2n8TROKPogruE84yLS6_AwHaHa&mediaurl=https%3A%2F%2Fwww.cashygo.in%2Fstatic%2Fweb%2Fimages%2Fexecutive.png&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.da7f1344e28fa20aee13ce322d2ebf03%3Frik%3DsCADoQvhdwC12Q%26pid%3DImgRaw%26r%3D0&exph=512&expw=512&q=avatars+for+sites&form=IRPRST&ck=299DBFCAFF10B3D5A73A91EF93153F1D&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_k5drJ44P*cp_9F5B9425E6390AD08E36568A701BC0A8*mid_EDE3CE4F8CE5BEA29C35E137AFC57576EEB40C36*simid_607992242342948935*thid_OIP.k5drJ44P!_6vXHJjKuuTaYwHaHW&vt=0&sim=11&iss=VSI&ajaxhist=0&ajaxserp=0", null, null, 7 },
                    { 8, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5683), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=iN2B0esp&id=A38E6B6419DCB48C099DF633ED08A32D6677EC8C&thid=OIP.iN2B0espKShXbt0BZmC_mwHaHa&mediaurl=https%3A%2F%2Fyt3.ggpht.com%2Fa%2FAATXAJwd0xEzFWMgYTJxhEzDgR2jsBhr38rVVYLGrA%3Ds900-c-k-c0xffffffff-no-rj-mo&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.88dd81d1eb292928576edd016660bf9b%3Frik%3DjOx3Zi2jCO0z9g%26pid%3DImgRaw%26r%3D0&exph=900&expw=900&q=avatars+for+sites&form=IRPRST&ck=89EE8126ADA32A92A48F04A90093C618&selectedindex=10&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_2n8TROKP*cp_299DBFCAFF10B3D5A73A91EF93153F1D*mid_74C616EF6C56DCEDEF60D9B50077E10BA10320B0*thid_OIP.2n8TROKPogruE84yLS6!_AwHaHa&vt=0&sim=11&iss=VSI&simid=608019931989018767&ajaxhist=0&ajaxserp=0", null, null, 8 },
                    { 9, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5686), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=gUWziU4q&id=575E4366F81F16B6E1150B93A05A24C28C951F88&thid=OIP.gUWziU4qIlj65_ptewq-9gHaJH&mediaurl=https%3A%2F%2Fwww.netclipart.com%2Fpp%2Fm%2F324-3244180_clean-madurai-housekeeping-services-lady-icon-png.png&exph=1132&expw=920&q=avatars+for+sites+woman&form=IRPRST&ck=AA7620D583CFF2F9185EFFFBE6F8C2B1&selectedindex=22&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.8145b3894e2a2258fae7fa6d7b0abef6%3Frik%3DiB%252bVjMIkWqCTCw%26pid%3DImgRaw%26r%3D0&simid=607994102039707919", null, null, 9 },
                    { 10, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5688), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=gQAod8xN&id=5C062313C68BB599A936E6DD7A9AC1661166D13A&thid=OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&mediaurl=https%3A%2F%2Fi.pinimg.com%2Foriginals%2F74%2Fda%2F07%2F74da07214279d76f9809b9c3943f23e6.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=9E1ECE6649A7EFDF03D173C8E6E75746&selectedindex=11&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_QXxS8HEX*cp_8227DE09D92787ADB2D381C3EA426A63*mid_652F714CDD9E207902418767156C2A75B8F1DB60*thid_OIP.QXxS8HEXoekXXLRo1BzwPAHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.81002877cc4d4ce2736f0e2fe58d621b%3Frik%3DOtFmEWbBmnrd5g%26pid%3DImgRaw%26r%3D0", null, null, 10 },
                    { 11, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5691), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=ovgXQqWa&id=AB355EFFA65C532F535225C443639DD144DF6333&thid=OIP.ovgXQqWaC82lHgt2V2vxvQHaHa&mediaurl=https%3A%2F%2Fvectorified.com%2Fimage%2Fminimalist-vector-25.jpg&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.a2f81742a59a0bcda51e0b76576bf1bd%3Frik%3DM2PfRNGdY0PEJQ%26pid%3DImgRaw%26r%3D0&exph=600&expw=600&q=avatars+for+sites&form=IRPRST&ck=10855C420BF2DC89C6C6AA947D217B5C&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_iN2B0esp*cp_89EE8126ADA32A92A48F04A90093C618*mid_A38E6B6419DCB48C099DF633ED08A32D6677EC8C*simid_608019931989018767*thid_OIP.iN2B0espKShXbt0BZmC!_mwHaHa&vt=0&sim=11&iss=VSI&simid=607995094195911121&ajaxhist=0&ajaxserp=0", null, null, 11 },
                    { 12, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5693), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=GSoBhvI8&id=1D47E63784BA983FC0BEA2430B49F43EFFAA5424&thid=OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&mediaurl=https%3A%2F%2Fcdn4.iconfinder.com%2Fdata%2Ficons%2Ffamous-character-vol-2-flat%2F48%2FAvatar_Famous_Characters-08-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=4379DFD07D7557F3593324DBE13D5E6F&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_gQAod8xN*cp_9E1ECE6649A7EFDF03D173C8E6E75746*mid_5C062313C68BB599A936E6DD7A9AC1661166D13A*thid_OIP.gQAod8xNTOJzbw4v5Y1iGwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.192a0186f23ca4d080a7d13818024523%3Frik%3DJFSq%252fz70SQtDog%26pid%3DImgRaw%26r%3D0&simid=608047059002875774", null, null, 12 },
                    { 13, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5695), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=UTiUwZi%2B&id=6DB608234240B457D5271CE6F4F7EE64990AE485&thid=OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&mediaurl=https%3A%2F%2Fcdn3.iconfinder.com%2Fdata%2Ficons%2Favatars-collection%2F256%2F35-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=1BEDCB9CA70115141BE0AF964A1B7F0E&selectedindex=2&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_GSoBhvI8*cp_4379DFD07D7557F3593324DBE13D5E6F*mid_1D47E63784BA983FC0BEA2430B49F43EFFAA5424*simid_608047059002875774*thid_OIP.GSoBhvI8pNCAp9E4GAJFIwHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.513894c198bee425a7c4db4bea3ba4e1%3Frik%3DheQKmWTu9%252fTmHA%26pid%3DImgRaw%26r%3D0&simid=608055017578107125", null, null, 13 },
                    { 14, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5697), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "https://www.bing.com/images/search?view=detailV2&ccid=xcUOt8Fa&id=FA221020C09F8D44E5FA6469ABDE90A35E306CC5&thid=OIP.xcUOt8FaKZgLEY3G3O0VlgHaHa&mediaurl=https%3A%2F%2Fcdn2.iconfinder.com%2Fdata%2Ficons%2Favatars-2-7%2F128%2F47-512.png&exph=512&expw=512&q=avatars+for+sites+woman&form=IRPRST&ck=F8412316D65B44228F183A4F546C0D97&selectedindex=3&ajaxhist=0&ajaxserp=0&pivotparams=insightsToken%3Dccid_UTiUwZi%252B*cp_1BEDCB9CA70115141BE0AF964A1B7F0E*mid_6DB608234240B457D5271CE6F4F7EE64990AE485*simid_608055017578107125*thid_OIP.UTiUwZi-5CWnxNtL6juk4QHaHa&vt=0&sim=11&iss=VSI&cdnurl=https%3A%2F%2Fth.bing.com%2Fth%2Fid%2FR.c5c50eb7c15a29980b118dc6dced1596%3Frik%3DxWwwXqOQ3qtpZA%26pid%3DImgRaw%26r%3D0&simid=608043257958332659", null, null, 14 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "ReviewContent", "TextId", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2177), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content1", 1, 1 },
                    { 2, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2182), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content2", 2, 2 },
                    { 3, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2185), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content3", 3, 3 },
                    { 4, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2187), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content4", 4, 4 },
                    { 5, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2190), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content5", 5, 5 },
                    { 6, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content6", 6, 6 },
                    { 7, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2195), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content7", 7, 7 },
                    { 8, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2198), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content8", 8, 8 },
                    { 9, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2200), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content9", 9, 9 },
                    { 10, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2203), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content10", 10, 10 },
                    { 11, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2206), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content11", 11, 11 },
                    { 12, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2208), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content12", 12, 12 },
                    { 13, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2211), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content13", 13, 13 },
                    { 14, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2213), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, "Content14", 14, 14 }
                });

            migrationBuilder.InsertData(
                table: "Statistics",
                columns: new[] { "Id", "Accuracy", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "NumberOfMistakes", "SharedVia", "SymbolsPerMinute", "TextId", "Time", "UserId" },
                values: new object[,]
                {
                    { 1, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5558), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 1, "02:30", 1 },
                    { 2, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5563), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 2, "02:30", 2 },
                    { 3, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5565), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 3, "02:30", 3 },
                    { 4, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5568), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 4, "02:30", 4 },
                    { 5, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5570), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 5, "02:30", 5 },
                    { 6, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5574), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 6, "02:30", 6 },
                    { 7, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5576), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 7, "02:30", 7 },
                    { 8, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5579), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 8, "02:30", 8 },
                    { 9, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5581), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 9, "02:30", 9 },
                    { 10, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5585), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 10, "02:30", 10 },
                    { 11, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5588), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 11, "02:30", 11 },
                    { 12, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5590), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 12, "02:30", 12 },
                    { 13, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5611), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 13, "02:30", 13 },
                    { 14, 68.7f, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(5614), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3, "VK", 54f, 14, "02:30", 14 }
                });

            migrationBuilder.InsertData(
                table: "StatisticsAVG",
                columns: new[] { "Id", "AvgAccuracy", "AvgSymbolsPerMin", "AvgTime", "CreatedAt", "CreatedBy", "LastModifiedAt", "LastModifiedBy", "TextsCount" },
                values: new object[,]
                {
                    { 1, 57f, 32.43f, "03:12", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2277), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 21 },
                    { 2, 68f, 42.21f, "02:48", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2282), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 3 },
                    { 3, 78f, 55.01f, "04:24", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2284), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 32 },
                    { 4, 83f, 121.17f, "03:04", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2287), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 81 },
                    { 5, 67f, 45.91f, "05:35", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2289), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 17 },
                    { 6, 80f, 51.56f, "03:00", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2292), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 26 },
                    { 7, 61f, 48.42f, "03:28", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 6 },
                    { 8, 73f, 65.23f, "06:27", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2297), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 25 },
                    { 9, 72f, 54.25f, "03:53", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2300), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 43 },
                    { 10, 57f, 43.63f, "03:03", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2303), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 24 },
                    { 11, 79f, 67.56f, "03:33", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2305), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 58 },
                    { 12, 74f, 54.23f, "02:09", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2308), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 99 },
                    { 13, 62f, 34f, "03:34", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2310), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 51 },
                    { 14, 19f, 58.28f, "04:39", new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(2313), new TimeSpan(0, 2, 0, 0, 0)), "Seed", null, null, 7 }
                });

            migrationBuilder.InsertData(
                table: "UserInfos",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "Language", "LastModifiedAt", "LastModifiedBy", "SignUpAt", "ThemeColors" },
                values: new object[,]
                {
                    { 1, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1923), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1887), null },
                    { 2, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1950), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1949), null },
                    { 3, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1954), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1953), null },
                    { 4, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1957), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1956), null },
                    { 5, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1961), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1960), null },
                    { 6, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1965), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1964), null },
                    { 7, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1968), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Romanian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1967), null },
                    { 8, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1971), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1970), null },
                    { 9, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1974), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1973), null },
                    { 10, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1978), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1977), null },
                    { 11, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1982), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1981), null },
                    { 12, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1985), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Russian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1984), null },
                    { 13, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1988), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "English", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1987), null },
                    { 14, new DateTimeOffset(new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Unspecified).AddTicks(1992), new TimeSpan(0, 2, 0, 0, 0)), "Seed", "Romanian", null, null, new DateTime(2022, 11, 10, 22, 2, 21, 57, DateTimeKind.Local).AddTicks(1991), null }
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
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

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

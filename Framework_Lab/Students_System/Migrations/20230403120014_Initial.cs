using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Students_System.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Students_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Students_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Students_birthday = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Students_mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Students_birthday", "Students_email", "Students_mobile", "Students_name" },
                values: new object[,]
                {
                    { new Guid("0431123a-a9bf-4008-bff8-73d8d5b5b66c"), new DateTime(2022, 11, 19, 16, 8, 59, 643, DateTimeKind.Local).AddTicks(8046), "DameonHegmann_Davis51@gmail.com", "+(38)-063-028-9437", "Dameon Hegmann" },
                    { new Guid("07a392ad-b67e-4975-b613-072f2c75ac6c"), new DateTime(2022, 5, 17, 4, 6, 39, 423, DateTimeKind.Local).AddTicks(5182), "CandidaCummerata.Brakus50@gmail.com", "+(38)-075-740-4872", "Candida Cummerata" },
                    { new Guid("08688bf3-29be-40cb-8fec-f8f1dc423278"), new DateTime(2022, 10, 5, 7, 10, 47, 42, DateTimeKind.Local).AddTicks(1886), "ClemmieKub.Schroeder@yahoo.com", "+(38)-011-033-0168", "Clemmie Kub" },
                    { new Guid("0a698407-6615-408e-9de2-eaf475329191"), new DateTime(2022, 12, 30, 23, 43, 2, 946, DateTimeKind.Local).AddTicks(3789), "VernaBecker.Kiehn71@hotmail.com", "+(38)-044-253-3083", "Verna Becker" },
                    { new Guid("0a6d093d-32f6-40a9-af50-d16f7b4c389e"), new DateTime(2023, 3, 26, 9, 53, 13, 655, DateTimeKind.Local).AddTicks(7559), "AleenVon.Willms99@yahoo.com", "+(38)-006-698-7879", "Aleen Von" },
                    { new Guid("0b05e2bd-26b4-43fa-9bd3-1bde5e38869f"), new DateTime(2023, 3, 30, 19, 21, 54, 638, DateTimeKind.Local).AddTicks(9274), "FredaBeatty.Quigley@hotmail.com", "+(38)-050-924-4047", "Freda Beatty" },
                    { new Guid("0c4dbfa3-093a-416c-aa93-78ad9a2959d7"), new DateTime(2022, 10, 27, 3, 57, 29, 92, DateTimeKind.Local).AddTicks(9262), "MorrisAbernathy_Lowe87@yahoo.com", "+(38)-086-912-8565", "Morris Abernathy" },
                    { new Guid("1651b921-c8ab-422e-8443-0658fc54c176"), new DateTime(2023, 2, 20, 3, 3, 45, 844, DateTimeKind.Local).AddTicks(1312), "DaynaGusikowski_Ward@gmail.com", "+(38)-053-338-7883", "Dayna Gusikowski" },
                    { new Guid("165aaa5b-6042-44b3-bcfd-ff950c9e5b15"), new DateTime(2023, 2, 19, 5, 50, 14, 714, DateTimeKind.Local).AddTicks(2033), "DaijaBernhard_Kirlin22@gmail.com", "+(38)-073-488-7794", "Daija Bernhard" },
                    { new Guid("1761352e-7935-43f9-9ea2-de67547eb200"), new DateTime(2022, 7, 3, 10, 35, 43, 115, DateTimeKind.Local).AddTicks(4161), "AugustBecker.VonRueden@gmail.com", "+(38)-091-242-1516", "August Becker" },
                    { new Guid("1896d4c0-5cdc-43cf-aed0-056d7e7d5232"), new DateTime(2023, 1, 14, 9, 4, 36, 629, DateTimeKind.Local).AddTicks(4259), "ShyannKris92@gmail.com", "+(38)-091-894-5388", "Shyann Kris" },
                    { new Guid("1aa685ae-4538-4450-a63f-a5d0f24f0c7a"), new DateTime(2023, 2, 19, 12, 30, 57, 359, DateTimeKind.Local).AddTicks(9211), "GeovannyKshlerin.Hammes@yahoo.com", "+(38)-002-881-0850", "Geovanny Kshlerin" },
                    { new Guid("20037083-b099-4ede-9157-22a9a45d6df5"), new DateTime(2023, 3, 28, 22, 6, 25, 197, DateTimeKind.Local).AddTicks(2220), "RomaineStracke_Davis@yahoo.com", "+(38)-051-029-8641", "Romaine Stracke" },
                    { new Guid("24e96ea8-f537-4220-8a5c-1386f2b57109"), new DateTime(2022, 5, 22, 15, 36, 23, 50, DateTimeKind.Local).AddTicks(7949), "FreddieNikolaus_Beahan36@yahoo.com", "+(38)-080-130-4376", "Freddie Nikolaus" },
                    { new Guid("26720409-92f3-4a6d-ac14-8ce26e082083"), new DateTime(2022, 7, 1, 9, 16, 19, 814, DateTimeKind.Local).AddTicks(8781), "EmanuelJerde56@hotmail.com", "+(38)-020-914-8156", "Emanuel Jerde" },
                    { new Guid("29dfde14-2409-4b84-871e-c8485c51860a"), new DateTime(2022, 7, 5, 20, 20, 41, 347, DateTimeKind.Local).AddTicks(4261), "MedaSpinka15@gmail.com", "+(38)-006-707-6951", "Meda Spinka" },
                    { new Guid("2d97f817-d7b1-4ed2-b530-0b5066aa2f14"), new DateTime(2022, 12, 28, 9, 31, 38, 260, DateTimeKind.Local).AddTicks(192), "OsbaldoSawayn_Wintheiser63@hotmail.com", "+(38)-065-006-4805", "Osbaldo Sawayn" },
                    { new Guid("2e208688-8e83-445a-b022-6b3099cb412e"), new DateTime(2022, 4, 13, 18, 17, 44, 377, DateTimeKind.Local).AddTicks(6745), "LilianaHeaney_Satterfield@hotmail.com", "+(38)-022-930-6104", "Liliana Heaney" },
                    { new Guid("35cc8601-5773-4592-81f1-9d66a08795c3"), new DateTime(2022, 4, 6, 21, 41, 27, 210, DateTimeKind.Local).AddTicks(6086), "EloisaLang64@hotmail.com", "+(38)-014-879-7297", "Eloisa Lang" },
                    { new Guid("363e88fc-dfd7-4da0-a7b2-08632bc4cda0"), new DateTime(2022, 6, 13, 5, 55, 50, 394, DateTimeKind.Local).AddTicks(7291), "ChloeOrn1@yahoo.com", "+(38)-064-735-5847", "Chloe Orn" },
                    { new Guid("3ac476a4-51e8-4340-9eeb-9b815b923062"), new DateTime(2022, 8, 28, 11, 23, 59, 539, DateTimeKind.Local).AddTicks(4954), "FloridaSchroeder_Walker0@hotmail.com", "+(38)-002-045-6690", "Florida Schroeder" },
                    { new Guid("3e036e37-851d-4fdb-a344-0ac000f47dfd"), new DateTime(2022, 5, 14, 11, 12, 10, 13, DateTimeKind.Local).AddTicks(5301), "RebekahWilliamson_Monahan@gmail.com", "+(38)-091-940-5979", "Rebekah Williamson" },
                    { new Guid("430a6376-4463-4dd7-b0c3-571e1aebb736"), new DateTime(2023, 3, 28, 23, 53, 9, 385, DateTimeKind.Local).AddTicks(9026), "LavonSchmeler_McClure41@hotmail.com", "+(38)-029-439-5078", "Lavon Schmeler" },
                    { new Guid("43dfd8ee-eb06-444f-9e85-aa40a6e41d21"), new DateTime(2022, 11, 14, 2, 30, 23, 432, DateTimeKind.Local).AddTicks(6400), "CaesarUllrich85@hotmail.com", "+(38)-078-785-8821", "Caesar Ullrich" },
                    { new Guid("43dffade-063a-4a00-b680-94c869e1e2be"), new DateTime(2022, 7, 5, 14, 35, 33, 365, DateTimeKind.Local).AddTicks(4087), "KevonBauch_Murphy@gmail.com", "+(38)-064-471-5702", "Kevon Bauch" },
                    { new Guid("4a8fc5dc-2605-4a38-9ad9-3cc53b52c501"), new DateTime(2022, 11, 1, 14, 7, 36, 146, DateTimeKind.Local).AddTicks(5964), "JodieLind_Nienow@gmail.com", "+(38)-080-597-7472", "Jodie Lind" },
                    { new Guid("4c338f1a-e3b0-421b-b4be-390774af5d69"), new DateTime(2022, 9, 5, 21, 17, 31, 177, DateTimeKind.Local).AddTicks(2696), "ConnieWeissnat.Kuphal@yahoo.com", "+(38)-023-288-7946", "Connie Weissnat" },
                    { new Guid("514dfbe3-be31-4125-90a6-48356ba9b9ae"), new DateTime(2022, 11, 13, 2, 40, 55, 270, DateTimeKind.Local).AddTicks(2316), "KiraBoehm72@hotmail.com", "+(38)-030-364-0378", "Kira Boehm" },
                    { new Guid("5201e1b1-117c-4795-87cc-e8d46b29ad50"), new DateTime(2022, 9, 24, 5, 36, 14, 365, DateTimeKind.Local).AddTicks(1155), "DeonteSenger_Ortiz8@gmail.com", "+(38)-087-934-1251", "Deonte Senger" },
                    { new Guid("53048b48-d72b-42d4-ba33-7ea78899a4e6"), new DateTime(2022, 5, 23, 7, 16, 18, 447, DateTimeKind.Local).AddTicks(3324), "FredrickSporer_Conroy@hotmail.com", "+(38)-087-276-9797", "Fredrick Sporer" },
                    { new Guid("54020903-e30b-4d7f-a257-dc30dd4d97d1"), new DateTime(2022, 7, 3, 18, 28, 58, 412, DateTimeKind.Local).AddTicks(1859), "JeramyStrosin.Mayer11@gmail.com", "+(38)-002-032-9807", "Jeramy Strosin" },
                    { new Guid("599cb364-0161-43d1-a43f-693c8e910f8b"), new DateTime(2022, 8, 2, 18, 16, 13, 503, DateTimeKind.Local).AddTicks(5267), "EverettMante44@yahoo.com", "+(38)-025-891-1799", "Everett Mante" },
                    { new Guid("5a59ddae-5738-4c7c-8f94-340922c66f49"), new DateTime(2022, 12, 29, 3, 24, 34, 172, DateTimeKind.Local).AddTicks(3621), "AshlynnHegmann_Carroll27@gmail.com", "+(38)-040-244-7697", "Ashlynn Hegmann" },
                    { new Guid("5c907e34-f477-448b-a005-c5eb9ab1f36c"), new DateTime(2023, 2, 12, 1, 51, 29, 677, DateTimeKind.Local).AddTicks(6806), "JamelSawayn47@hotmail.com", "+(38)-050-612-6415", "Jamel Sawayn" },
                    { new Guid("5ebd0090-247f-48d7-845f-0364d89c1b6b"), new DateTime(2023, 2, 26, 19, 44, 51, 479, DateTimeKind.Local).AddTicks(9196), "EthylRunte.Hagenes@yahoo.com", "+(38)-098-323-2565", "Ethyl Runte" },
                    { new Guid("6300d2eb-6b16-4308-a90c-f73b0b3c0e01"), new DateTime(2022, 9, 25, 14, 28, 45, 324, DateTimeKind.Local).AddTicks(1680), "ElwynRath_Kertzmann@hotmail.com", "+(38)-058-435-1378", "Elwyn Rath" },
                    { new Guid("703e10fa-0b9a-415c-9d06-6d6af7197aca"), new DateTime(2022, 11, 19, 6, 10, 46, 870, DateTimeKind.Local).AddTicks(8738), "NyasiaHerman87@hotmail.com", "+(38)-007-935-5365", "Nyasia Herman" },
                    { new Guid("70787203-2511-4137-9f94-06bdde5084dd"), new DateTime(2023, 2, 7, 5, 31, 39, 458, DateTimeKind.Local).AddTicks(808), "MyrtisNolan_Davis21@yahoo.com", "+(38)-079-304-0251", "Myrtis Nolan" },
                    { new Guid("76d46be4-feb5-47de-9d98-9bb6505dae83"), new DateTime(2022, 9, 6, 0, 41, 8, 625, DateTimeKind.Local).AddTicks(9195), "AntoninaCollins4@hotmail.com", "+(38)-048-045-5376", "Antonina Collins" },
                    { new Guid("77608084-45d4-48aa-9de8-5ab0176fb9fe"), new DateTime(2022, 9, 15, 10, 31, 42, 333, DateTimeKind.Local).AddTicks(3992), "MaxieLarson30@gmail.com", "+(38)-064-063-5168", "Maxie Larson" },
                    { new Guid("7e792f9a-1310-4f1e-875e-2e16a18027fa"), new DateTime(2022, 11, 19, 12, 10, 43, 9, DateTimeKind.Local).AddTicks(9089), "RashadSchroeder.Lockman10@yahoo.com", "+(38)-047-591-3396", "Rashad Schroeder" },
                    { new Guid("7ec9e710-dafe-450c-89c4-e6fa783597fc"), new DateTime(2022, 8, 30, 8, 11, 4, 705, DateTimeKind.Local).AddTicks(6779), "LavonCartwright_Huel@yahoo.com", "+(38)-095-277-0675", "Lavon Cartwright" },
                    { new Guid("80d90720-f8a8-4cfb-8ee2-ab3c0d22e132"), new DateTime(2022, 4, 23, 6, 46, 9, 158, DateTimeKind.Local).AddTicks(7606), "RaeganKunde.Deckow10@yahoo.com", "+(38)-047-040-0657", "Raegan Kunde" },
                    { new Guid("8104eaf0-623c-4ad5-9fc6-f8e4b135cdd9"), new DateTime(2022, 11, 27, 21, 52, 48, 113, DateTimeKind.Local).AddTicks(9292), "CoryFriesen_Marvin@yahoo.com", "+(38)-076-312-9690", "Cory Friesen" },
                    { new Guid("831c0de9-f175-4c34-9fa6-8ba81b0af77a"), new DateTime(2023, 3, 29, 14, 41, 39, 916, DateTimeKind.Local).AddTicks(5199), "LeslyGibson_Sawayn@hotmail.com", "+(38)-025-993-1270", "Lesly Gibson" },
                    { new Guid("85f89acb-5212-4525-b35c-59f5c165eab8"), new DateTime(2022, 7, 24, 23, 29, 34, 686, DateTimeKind.Local).AddTicks(452), "RollinEbert.Hessel35@yahoo.com", "+(38)-069-613-0070", "Rollin Ebert" },
                    { new Guid("86e1615d-f75c-4de4-a29d-d042ba1a8289"), new DateTime(2022, 9, 28, 10, 24, 45, 721, DateTimeKind.Local).AddTicks(3808), "BrigitteRuecker_Gislason@gmail.com", "+(38)-087-467-0405", "Brigitte Ruecker" },
                    { new Guid("880d4e13-b62a-4c49-9d9c-5838aaf2a635"), new DateTime(2022, 10, 30, 5, 16, 35, 735, DateTimeKind.Local).AddTicks(4477), "KurtBrekke0@hotmail.com", "+(38)-083-437-6870", "Kurt Brekke" },
                    { new Guid("8c0fce32-db48-4e0c-8bbe-2da87e54e674"), new DateTime(2022, 12, 7, 20, 33, 19, 520, DateTimeKind.Local).AddTicks(2303), "IsabelSchimmel48@yahoo.com", "+(38)-040-588-7478", "Isabel Schimmel" },
                    { new Guid("8c38e816-cebe-494a-8da9-c1e95346e825"), new DateTime(2022, 11, 6, 3, 9, 41, 795, DateTimeKind.Local).AddTicks(3090), "ErickaHegmann_Gerlach31@gmail.com", "+(38)-064-666-2911", "Ericka Hegmann" },
                    { new Guid("900955bf-73af-4c0f-9020-bdc6295067f0"), new DateTime(2022, 4, 28, 22, 32, 19, 545, DateTimeKind.Local).AddTicks(1115), "JuwanKiehn.Dickinson@yahoo.com", "+(38)-049-686-7867", "Juwan Kiehn" },
                    { new Guid("9137292c-753f-479c-9125-54d981ca2381"), new DateTime(2022, 9, 23, 3, 25, 3, 949, DateTimeKind.Local).AddTicks(7119), "MarquisOrtiz17@hotmail.com", "+(38)-039-332-6207", "Marquis Ortiz" },
                    { new Guid("92cae278-6e83-4db2-8a02-cda0de7fb92e"), new DateTime(2022, 10, 13, 11, 48, 15, 248, DateTimeKind.Local).AddTicks(3753), "PearlieAltenwerth4@hotmail.com", "+(38)-032-182-3603", "Pearlie Altenwerth" },
                    { new Guid("96841b83-d8b2-4b3e-b12a-7b5f00b21747"), new DateTime(2022, 4, 10, 11, 6, 52, 959, DateTimeKind.Local).AddTicks(9044), "PierreBaumbach.Turcotte7@yahoo.com", "+(38)-031-017-5465", "Pierre Baumbach" },
                    { new Guid("9c90384b-f753-4601-bb3d-715101ac91ad"), new DateTime(2022, 5, 17, 9, 34, 33, 872, DateTimeKind.Local).AddTicks(7953), "RomaWatsica33@hotmail.com", "+(38)-003-408-7871", "Roma Watsica" },
                    { new Guid("9d95b7f8-5e4c-4c95-a620-1164a4f53275"), new DateTime(2022, 6, 7, 16, 39, 27, 476, DateTimeKind.Local).AddTicks(1602), "KasandraZieme_Champlin@hotmail.com", "+(38)-095-218-1059", "Kasandra Zieme" },
                    { new Guid("a0604c03-cf07-47e1-b482-0b07b3921fbc"), new DateTime(2022, 7, 16, 11, 1, 26, 40, DateTimeKind.Local).AddTicks(6443), "BessieTreutel_Bartoletti70@gmail.com", "+(38)-077-210-8051", "Bessie Treutel" },
                    { new Guid("a3e7a974-7454-44c8-a9a1-6bffac2d6465"), new DateTime(2023, 3, 3, 11, 54, 6, 644, DateTimeKind.Local).AddTicks(5901), "AngeloErnser34@hotmail.com", "+(38)-031-562-3126", "Angelo Ernser" },
                    { new Guid("a4e24f68-ec95-4716-9d98-06ed2f0ad575"), new DateTime(2022, 10, 16, 18, 10, 51, 635, DateTimeKind.Local).AddTicks(5894), "MinaRussel27@yahoo.com", "+(38)-026-312-5757", "Mina Russel" },
                    { new Guid("a5689514-6dbb-4e41-a4b5-6edb22a064f6"), new DateTime(2023, 1, 7, 21, 45, 22, 63, DateTimeKind.Local).AddTicks(5877), "TedKozey87@hotmail.com", "+(38)-046-427-4643", "Ted Kozey" },
                    { new Guid("a706ce3a-d671-490e-ba5e-e6e67776b6e6"), new DateTime(2022, 5, 24, 19, 20, 3, 395, DateTimeKind.Local).AddTicks(7934), "EmmaReilly.Lebsack@gmail.com", "+(38)-087-135-5760", "Emma Reilly" },
                    { new Guid("a7e60179-f3c8-4787-bd47-9186426fc38d"), new DateTime(2023, 1, 25, 2, 53, 38, 260, DateTimeKind.Local).AddTicks(9857), "NorvalLedner_Hyatt65@yahoo.com", "+(38)-098-234-7504", "Norval Ledner" },
                    { new Guid("a93e977f-3965-4066-8db4-82eb13d86e3f"), new DateTime(2023, 3, 27, 21, 5, 28, 206, DateTimeKind.Local).AddTicks(9084), "MaybellBayer52@yahoo.com", "+(38)-019-852-4058", "Maybell Bayer" },
                    { new Guid("aed472d0-3883-4c95-9076-616b7a3885ca"), new DateTime(2022, 6, 5, 18, 51, 54, 461, DateTimeKind.Local).AddTicks(2397), "MarinaMiller.Oberbrunner@gmail.com", "+(38)-029-185-9628", "Marina Miller" },
                    { new Guid("b02dfce1-5a97-4a2d-baab-24dc827aefb3"), new DateTime(2023, 3, 22, 22, 56, 25, 853, DateTimeKind.Local).AddTicks(3079), "LoyalYost.Marks22@yahoo.com", "+(38)-020-284-0792", "Loyal Yost" },
                    { new Guid("b174c883-b50f-4f29-8f8c-7cf7997eaf16"), new DateTime(2022, 4, 6, 9, 20, 10, 35, DateTimeKind.Local).AddTicks(9789), "AlfonsoDenesik70@gmail.com", "+(38)-039-256-0777", "Alfonso Denesik" },
                    { new Guid("b1ba4fd7-2aa6-46f5-8179-353931d87c23"), new DateTime(2022, 5, 27, 4, 30, 16, 126, DateTimeKind.Local).AddTicks(7960), "MetaDooley_Corkery@hotmail.com", "+(38)-078-714-3385", "Meta Dooley" },
                    { new Guid("b4ff34a8-2715-45c4-9e8f-c3fad30e1d7e"), new DateTime(2023, 3, 10, 14, 58, 3, 289, DateTimeKind.Local).AddTicks(1157), "MadisonStoltenberg_Leuschke@yahoo.com", "+(38)-045-762-3516", "Madison Stoltenberg" },
                    { new Guid("b5ab20c5-e50f-4b49-b059-c576f57d4b8f"), new DateTime(2023, 2, 20, 18, 39, 35, 76, DateTimeKind.Local).AddTicks(6663), "SavannaParisian.Zieme46@hotmail.com", "+(38)-050-335-7045", "Savanna Parisian" },
                    { new Guid("b7cc8537-560d-41bb-aa35-d81d5c38ee67"), new DateTime(2023, 3, 27, 17, 35, 39, 233, DateTimeKind.Local).AddTicks(1445), "PollyHoeger.Jacobs@hotmail.com", "+(38)-078-780-5014", "Polly Hoeger" },
                    { new Guid("b8a1a5d9-5af4-42cb-a4e9-06f539816caa"), new DateTime(2023, 3, 14, 5, 17, 58, 909, DateTimeKind.Local).AddTicks(2511), "AlvinaLindgren91@gmail.com", "+(38)-050-561-3558", "Alvina Lindgren" },
                    { new Guid("bd334183-2fcb-41b8-bce6-0190e95984c9"), new DateTime(2022, 4, 15, 21, 59, 27, 971, DateTimeKind.Local).AddTicks(3465), "ElliotSchamberger.Emmerich4@yahoo.com", "+(38)-092-043-1894", "Elliot Schamberger" },
                    { new Guid("bf4cb4ac-e717-45b3-ba62-f649ad7a0886"), new DateTime(2022, 7, 15, 11, 16, 59, 823, DateTimeKind.Local).AddTicks(3171), "MikaylaLesch5@hotmail.com", "+(38)-072-285-8778", "Mikayla Lesch" },
                    { new Guid("c22d64bf-f194-4d0d-aeb8-45caf7bd3069"), new DateTime(2022, 5, 13, 5, 37, 12, 972, DateTimeKind.Local).AddTicks(1333), "TedBatz.Trantow94@yahoo.com", "+(38)-099-156-9931", "Ted Batz" },
                    { new Guid("c2470726-0baf-42e6-830e-55ef5f4c9bc0"), new DateTime(2022, 10, 23, 9, 55, 13, 820, DateTimeKind.Local).AddTicks(5744), "ThaddeusKeeling_Bosco@gmail.com", "+(38)-020-524-5685", "Thaddeus Keeling" },
                    { new Guid("ceed2d75-c5e2-4a49-b95c-2ea1a1679923"), new DateTime(2023, 1, 27, 22, 52, 43, 353, DateTimeKind.Local).AddTicks(6005), "DeborahWehner.Harber@hotmail.com", "+(38)-082-404-3231", "Deborah Wehner" },
                    { new Guid("cfc28280-38bf-49da-800e-ea77da11718c"), new DateTime(2023, 3, 15, 8, 32, 49, 967, DateTimeKind.Local).AddTicks(1134), "PrestonHyatt48@gmail.com", "+(38)-023-665-6190", "Preston Hyatt" },
                    { new Guid("d17a4430-26fb-4c77-b0c3-c75f765ee8e7"), new DateTime(2022, 12, 13, 7, 35, 35, 785, DateTimeKind.Local).AddTicks(2786), "BrandiMcKenzie_Walter99@yahoo.com", "+(38)-021-029-1500", "Brandi McKenzie" },
                    { new Guid("d1b58c19-d4ec-4e6a-b391-4d1b7a100822"), new DateTime(2023, 2, 24, 4, 6, 27, 49, DateTimeKind.Local).AddTicks(155), "KadinRyan_Nader9@gmail.com", "+(38)-070-038-9920", "Kadin Ryan" },
                    { new Guid("d1cc4b90-255c-401a-ad33-7f26312c5380"), new DateTime(2022, 6, 27, 21, 18, 36, 753, DateTimeKind.Local).AddTicks(1302), "MadonnaChamplin.Parker@hotmail.com", "+(38)-088-245-5230", "Madonna Champlin" },
                    { new Guid("d6ab73bb-c6e0-45b3-b41f-5ef59bc3b0d2"), new DateTime(2022, 6, 26, 15, 21, 22, 652, DateTimeKind.Local).AddTicks(9923), "CatherineRippin_Sipes@yahoo.com", "+(38)-086-057-3930", "Catherine Rippin" },
                    { new Guid("d717d175-11cc-4a94-b540-a75c1799b93c"), new DateTime(2022, 7, 21, 9, 58, 58, 200, DateTimeKind.Local).AddTicks(2228), "NigelReinger.Runolfsson14@gmail.com", "+(38)-048-161-8513", "Nigel Reinger" },
                    { new Guid("d7dd7068-6855-4e44-ae9e-2c1a314eb94d"), new DateTime(2022, 4, 21, 14, 55, 29, 614, DateTimeKind.Local).AddTicks(9901), "JakeLindgren_Armstrong81@hotmail.com", "+(38)-040-966-8092", "Jake Lindgren" },
                    { new Guid("d9480bc1-d6ee-44b5-8ea6-748d77ca0e51"), new DateTime(2022, 5, 26, 11, 19, 9, 440, DateTimeKind.Local).AddTicks(805), "KatrineWiza78@hotmail.com", "+(38)-066-244-9158", "Katrine Wiza" },
                    { new Guid("da2008b2-0817-4e6a-8000-94a48ed59678"), new DateTime(2022, 7, 9, 15, 26, 48, 273, DateTimeKind.Local).AddTicks(1651), "JessikaKiehn.Corkery90@gmail.com", "+(38)-039-833-6115", "Jessika Kiehn" },
                    { new Guid("db1caea1-8ccb-41bb-b71b-c2cf14679202"), new DateTime(2022, 9, 2, 4, 43, 1, 839, DateTimeKind.Local).AddTicks(5547), "SchuylerHessel37@gmail.com", "+(38)-052-692-4947", "Schuyler Hessel" },
                    { new Guid("db38221b-7a78-41b2-bf0d-a406241b749c"), new DateTime(2022, 4, 20, 4, 22, 39, 216, DateTimeKind.Local).AddTicks(393), "ChelseaProhaska_Jacobi@gmail.com", "+(38)-008-634-7056", "Chelsea Prohaska" },
                    { new Guid("dd393c14-8dbb-42bb-859b-d611e2b1dc66"), new DateTime(2022, 8, 15, 15, 26, 21, 972, DateTimeKind.Local).AddTicks(9164), "RowanMcClure65@gmail.com", "+(38)-014-798-9910", "Rowan McClure" },
                    { new Guid("def6f0b6-5439-47c4-9f8f-2f1aa0c30521"), new DateTime(2022, 8, 29, 7, 21, 26, 328, DateTimeKind.Local).AddTicks(7539), "LeonoraLegros.Dicki@hotmail.com", "+(38)-035-666-0570", "Leonora Legros" },
                    { new Guid("e0080a01-4157-4687-9be6-7f4b2069d8c0"), new DateTime(2022, 10, 12, 23, 53, 46, 307, DateTimeKind.Local).AddTicks(9166), "MichaelHuels_Stanton@gmail.com", "+(38)-019-515-6412", "Michael Huels" },
                    { new Guid("e289db94-f628-4956-b9a7-b0e1e256930a"), new DateTime(2022, 10, 18, 11, 28, 4, 731, DateTimeKind.Local).AddTicks(3391), "AdrienneMacejkovic_Hickle@yahoo.com", "+(38)-005-718-9904", "Adrienne Macejkovic" },
                    { new Guid("e3ff0f09-5166-4092-a5f0-d1a133723ca0"), new DateTime(2023, 3, 6, 13, 11, 21, 595, DateTimeKind.Local).AddTicks(4296), "DarrelMaggio_Simonis6@gmail.com", "+(38)-093-349-2614", "Darrel Maggio" },
                    { new Guid("e66ffa33-4223-49e2-a8d7-95802149b04b"), new DateTime(2022, 5, 28, 11, 3, 51, 224, DateTimeKind.Local).AddTicks(7015), "CedrickBergstrom35@hotmail.com", "+(38)-020-432-9932", "Cedrick Bergstrom" },
                    { new Guid("ebbf72bd-1935-4942-b725-8e68c4b84aae"), new DateTime(2022, 11, 22, 17, 11, 47, 649, DateTimeKind.Local).AddTicks(5124), "WestleyReichel.Mills38@hotmail.com", "+(38)-089-891-8224", "Westley Reichel" },
                    { new Guid("eecc4a4d-79b8-4d43-b3f2-1345d5452a28"), new DateTime(2022, 7, 4, 9, 42, 53, 702, DateTimeKind.Local).AddTicks(9453), "EstherHodkiewicz95@yahoo.com", "+(38)-081-374-0269", "Esther Hodkiewicz" },
                    { new Guid("f3d53e07-4afe-4602-bbd2-b07113dfe9f9"), new DateTime(2022, 4, 5, 19, 30, 10, 529, DateTimeKind.Local).AddTicks(1403), "DorisZemlak35@gmail.com", "+(38)-011-752-7370", "Doris Zemlak" },
                    { new Guid("f5ac62bd-d54e-495c-84c9-53a22c6f1375"), new DateTime(2023, 1, 13, 20, 35, 2, 526, DateTimeKind.Local).AddTicks(1935), "OrionZboncak_Schuppe@hotmail.com", "+(38)-019-626-3594", "Orion Zboncak" },
                    { new Guid("f5ce3ae1-d098-44fe-8a45-3a1b5a6c9386"), new DateTime(2022, 4, 11, 5, 47, 5, 57, DateTimeKind.Local).AddTicks(9474), "HiltonHoeger70@hotmail.com", "+(38)-095-872-3905", "Hilton Hoeger" },
                    { new Guid("fb055f4d-f89d-4321-9c8e-1a35502c424d"), new DateTime(2022, 9, 9, 14, 7, 41, 601, DateTimeKind.Local).AddTicks(4002), "MeaghanHane_Witting@hotmail.com", "+(38)-039-501-7148", "Meaghan Hane" },
                    { new Guid("ffa85bb8-28c3-4e4c-9c66-8c486ec74476"), new DateTime(2022, 10, 6, 0, 5, 38, 714, DateTimeKind.Local).AddTicks(9867), "JonathonWeissnat_Langworth@yahoo.com", "+(38)-028-874-1106", "Jonathon Weissnat" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}

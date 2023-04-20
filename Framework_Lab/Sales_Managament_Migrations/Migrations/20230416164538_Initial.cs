using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Customers_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customers_email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Products_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Products_count = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Stores_title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Stores_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Customers_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Products_ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Customers_to_Sales",
                        column: x => x.Customers_ID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_to_Sales",
                        column: x => x.Products_ID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stores_to_Sales",
                        column: x => x.Stores_ID,
                        principalTable: "Stores",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Customers_email", "Customers_title" },
                values: new object[,]
                {
                    { new Guid("0204c9c5-110d-4575-a7b5-26900814e248"), "RosaRolfson.Kohler@yahoo.com", "Rosa Rolfson" },
                    { new Guid("05e516c5-d7b6-4cdc-928b-d66881482b0c"), "DoloresKautzer22@yahoo.com", "Dolores Kautzer" },
                    { new Guid("08c63d8e-88ec-4ea2-b2f6-9ce1fb25a5df"), "ArturoSimonis.Kris92@gmail.com", "Arturo Simonis" },
                    { new Guid("09db64f2-42da-4dfc-8e26-8fb9c93c03fa"), "RudySawayn10@yahoo.com", "Rudy Sawayn" },
                    { new Guid("0b096a5a-166a-4c69-b7a3-1d116d52c02c"), "SallyHayes80@gmail.com", "Sally Hayes" },
                    { new Guid("0b47859c-9506-48d1-9d9c-f02f4f43d686"), "AngieArmstrong20@hotmail.com", "Angie Armstrong" },
                    { new Guid("11cbd6ff-7630-4d73-b7a0-2095e7a0c7f8"), "OraFeeney75@hotmail.com", "Ora Feeney" },
                    { new Guid("1cf311c6-7a11-4815-8059-9bdf4ff37579"), "SheldonDooley_Bogan48@yahoo.com", "Sheldon Dooley" },
                    { new Guid("206602e7-b6f6-43e5-8bb8-d18e0685f319"), "AustinLeannon_Mills@hotmail.com", "Austin Leannon" },
                    { new Guid("2a96ba46-0a4a-4db0-8dc5-353bd4085d77"), "BarbaraWilderman.OReilly70@gmail.com", "Barbara Wilderman" },
                    { new Guid("2b11cbd2-6551-4450-a3c9-96fa8d25dc9e"), "AshleyBalistreri46@hotmail.com", "Ashley Balistreri" },
                    { new Guid("2b52e55b-b7fe-4cab-9492-1e9472868478"), "AlfredoBarrows60@gmail.com", "Alfredo Barrows" },
                    { new Guid("2bf6b142-027b-48d3-a1c7-43b1d541a721"), "MargaretLesch77@gmail.com", "Margaret Lesch" },
                    { new Guid("308853c2-3060-42a0-bb2c-b528d11361c9"), "AndreaRussel_Rogahn@hotmail.com", "Andrea Russel" },
                    { new Guid("3339d9b6-deb0-4d49-a75b-316d25757fab"), "DamonBrekke_Morissette41@gmail.com", "Damon Brekke" },
                    { new Guid("3dc41bee-189e-46b4-b1fd-a202a5e70633"), "PatYundt13@gmail.com", "Pat Yundt" },
                    { new Guid("3fd687a6-18bd-4805-bdfc-2218d2d01108"), "BobbieAnkunding_King@hotmail.com", "Bobbie Ankunding" },
                    { new Guid("44e881da-6816-4edb-b454-cc2cab92281d"), "PaulVolkman.White@gmail.com", "Paul Volkman" },
                    { new Guid("46cfcedf-8689-4eda-ab8c-b6e530f91227"), "TonyaDonnelly.Kihn@gmail.com", "Tonya Donnelly" },
                    { new Guid("490f9f51-76c1-4fae-bd3b-92b82c71351f"), "AllenWindler45@yahoo.com", "Allen Windler" },
                    { new Guid("4bd7a06c-6889-425a-8b17-c731e0aa4f46"), "JosephineKoch60@gmail.com", "Josephine Koch" },
                    { new Guid("5086139d-4320-451a-b41b-d57d007b1ece"), "FeliciaCasper42@yahoo.com", "Felicia Casper" },
                    { new Guid("5b40a833-ced1-4a76-af6c-cd7145d7032e"), "KristaRatke.Mitchell@yahoo.com", "Krista Ratke" },
                    { new Guid("5c3db425-e518-45cb-9bc8-6d3db3bcdf1b"), "RodolfoKozey_Powlowski@hotmail.com", "Rodolfo Kozey" },
                    { new Guid("64ca9622-6522-4de6-80da-30bdeba0fdae"), "AngieKunze98@gmail.com", "Angie Kunze" },
                    { new Guid("65e975a5-d4a2-4c2b-9836-e3c8365e7e84"), "BerniceWeissnat.Windler23@yahoo.com", "Bernice Weissnat" },
                    { new Guid("7be294eb-e299-41ef-8da4-0be8fd040db1"), "TraceyLangosh.Nienow52@yahoo.com", "Tracey Langosh" },
                    { new Guid("7cf9ec82-52e5-44aa-bdae-83bdd2e70791"), "WesleyLesch91@yahoo.com", "Wesley Lesch" },
                    { new Guid("828ed59f-7550-43d4-968f-a6bda1e0f829"), "SilviaSawayn68@hotmail.com", "Silvia Sawayn" },
                    { new Guid("899e7917-4083-4944-9925-74d441ef76c5"), "CorneliusHayes51@gmail.com", "Cornelius Hayes" },
                    { new Guid("8af23ad1-078d-47a6-b24b-9ca35c724e29"), "JanPfeffer.Hammes@hotmail.com", "Jan Pfeffer" },
                    { new Guid("8e90a947-3b31-4a8c-9624-02b3032065b8"), "SilviaCummings.Kovacek61@gmail.com", "Silvia Cummings" },
                    { new Guid("9a5cef5f-c345-4bbc-98ef-fdf7fee6f0d7"), "JeremiahMacGyver39@yahoo.com", "Jeremiah MacGyver" },
                    { new Guid("afa1d854-a3f6-468e-8374-ab99f9c3aca4"), "TimothyDach50@gmail.com", "Timothy Dach" },
                    { new Guid("b00d24fc-3156-4fbd-8343-087df4293491"), "JackDaugherty.Krajcik57@hotmail.com", "Jack Daugherty" },
                    { new Guid("b3ee5fe8-9e91-45a7-b012-5352aa89315e"), "NathanielAnderson_Keeling30@yahoo.com", "Nathaniel Anderson" },
                    { new Guid("b46e30c1-634d-414b-bb28-a50e00dc35fe"), "RhondaZboncak.Yost@yahoo.com", "Rhonda Zboncak" },
                    { new Guid("b5af5f8a-a3e0-447d-98ab-7547c10b7727"), "GeraldBradtke.Murray@hotmail.com", "Gerald Bradtke" },
                    { new Guid("bcf10a47-d1f9-4078-b0ea-cccb081162c7"), "RachaelKunde70@hotmail.com", "Rachael Kunde" },
                    { new Guid("c80c9ee1-86e9-455a-ba3a-e1af307e0e56"), "GustavoOndricka55@hotmail.com", "Gustavo Ondricka" },
                    { new Guid("cad8a276-665a-42fa-9ec6-e5ca2c7e9d5a"), "DexterDenesik.Connelly@yahoo.com", "Dexter Denesik" },
                    { new Guid("dcbb8492-2d91-4b70-9f26-ad445370482a"), "DarrylTurner_Swaniawski@yahoo.com", "Darryl Turner" },
                    { new Guid("e2186b15-6e18-46b5-96f7-1bb1e87ee285"), "LorenLangosh.Ferry44@hotmail.com", "Loren Langosh" },
                    { new Guid("e60e17e0-7eb3-49b0-a2aa-ce9191f073fe"), "EstelleBartell33@gmail.com", "Estelle Bartell" },
                    { new Guid("e61eb903-1afa-4f56-b6e5-89930ffca51e"), "MaxHartmann50@yahoo.com", "Max Hartmann" },
                    { new Guid("e655d9cd-917d-45f1-a185-f6deda22ebe4"), "EstelleFerry_Fahey@hotmail.com", "Estelle Ferry" },
                    { new Guid("eac914af-7f71-4b23-8c57-d9f64246b585"), "GlennHahn.Tillman52@hotmail.com", "Glenn Hahn" },
                    { new Guid("eb83e2ba-09b4-418c-9e4c-f2200c6f8328"), "DrewMcKenzie.Daniel@hotmail.com", "Drew McKenzie" },
                    { new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"), "WinstonReilly_Grant22@yahoo.com", "Winston Reilly" },
                    { new Guid("fd844061-c2b7-4eaa-9ae2-9f1adf3ba316"), "DeanSatterfield_Hilpert@gmail.com", "Dean Satterfield" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Products_count", "Products_title" },
                values: new object[,]
                {
                    { new Guid("0274b5ed-db1c-436e-80ed-f1f99a895cca"), 54739257, "Tuna" },
                    { new Guid("0296fcf0-a37a-4fca-90b9-5eeb6c753fc4"), 266670128, "Fish" },
                    { new Guid("042d3886-f264-4d55-acab-b91d5f846d54"), 1900293941, "Keyboard" },
                    { new Guid("0c4df2ba-0555-480f-a5e3-7f0fc575119f"), -934930497, "Shoes" },
                    { new Guid("153fb67f-0cf9-4bbb-a880-49ec2551e16f"), 245577753, "Tuna" },
                    { new Guid("1625108a-6937-4b80-96be-a790e08fc4da"), -1525592446, "Salad" },
                    { new Guid("1ecae5fb-d2bf-4bc8-adfb-03154a03f6c6"), 1891248678, "Keyboard" },
                    { new Guid("217ea179-d9a1-4f62-bfc6-becb0124daee"), 1128107613, "Towels" },
                    { new Guid("26b48feb-2f6f-4dc5-82dc-4e487aaeec92"), 530318222, "Computer" },
                    { new Guid("2a810134-4381-4a1c-80a0-ed0db9343679"), -718820522, "Pants" },
                    { new Guid("2f7fcd57-50cd-452a-beb0-d36c92d36e29"), 578445011, "Chair" },
                    { new Guid("2ffbe657-6cd2-455b-8ebd-56fa54371b8c"), 245197452, "Keyboard" },
                    { new Guid("358ec356-8c24-4de0-a040-f40185713ea0"), 916958332, "Pants" },
                    { new Guid("3830ee40-497b-4e6c-b6ed-10255293212e"), -2142796212, "Mouse" },
                    { new Guid("39d3e759-5f9c-4c1c-8bb3-fac84f18c90c"), -668492672, "Bacon" },
                    { new Guid("3d885358-6c71-46ff-8f77-2783c06a91f8"), -253898937, "Ball" },
                    { new Guid("3f75ed22-2c21-49b6-872e-f56aca923794"), 194831948, "Ball" },
                    { new Guid("43864080-b9a9-4dc8-9e26-d1442c450779"), 2097275633, "Ball" },
                    { new Guid("4dc89d24-4057-48ff-be05-3d45d31718ac"), -622443342, "Chips" },
                    { new Guid("503df924-531c-42a2-b250-90ae3c5fcf9b"), -724590877, "Sausages" },
                    { new Guid("53440321-8b7b-4d0d-8a0b-6c7305ef0fbf"), -747229963, "Pants" },
                    { new Guid("57e45f70-c65f-448c-89c3-50d3ec16f9a2"), -1378897589, "Car" },
                    { new Guid("5c365456-f233-4f94-8157-661200aea27c"), -827632772, "Fish" },
                    { new Guid("5f91fd92-2f47-4a59-b8d6-6f4a9f388b1e"), -1689645387, "Car" },
                    { new Guid("60793dfb-2aa7-436c-83b8-236d05df8275"), -980436413, "Car" },
                    { new Guid("62efee04-029f-4f57-8449-897a9ce58b82"), -522632828, "Car" },
                    { new Guid("662bb844-2803-4ffe-ad4d-59f2a0f2e913"), 1355213549, "Mouse" },
                    { new Guid("6be52a56-4c7d-447d-a656-82b34bbb39ef"), 1446028297, "Mouse" },
                    { new Guid("6d65f6a1-a72f-4594-9d86-3f3a009c97fb"), 69405658, "Gloves" },
                    { new Guid("6f903cd3-5f61-4d32-881b-7a480b625352"), 409802628, "Sausages" },
                    { new Guid("723a39f2-459b-43b5-99e8-fd800a051a3c"), 1111869835, "Bike" },
                    { new Guid("7246c8ac-8a2e-4192-acb5-edf34139f28e"), 1334885025, "Car" },
                    { new Guid("7667bfa1-9d94-43ee-bcd6-3863322a107e"), 752070937, "Bacon" },
                    { new Guid("7743928e-beec-4726-8c87-0bea36f52007"), 1305178522, "Chair" },
                    { new Guid("7be2d4d6-fbed-421f-8729-c858de9cac7f"), 36159203, "Bacon" },
                    { new Guid("7d059e04-124e-4ebd-b57b-128d2f4d242e"), 1859436688, "Soap" },
                    { new Guid("7e5c95b1-8e7d-4128-a674-fcad82b91abb"), -97725523, "Fish" },
                    { new Guid("83b51db4-ee8a-439d-8da3-3480a281c4c2"), -1443498076, "Chicken" },
                    { new Guid("84cde055-8d1d-4ab0-bcc4-0d6fc91f38f9"), 1514485295, "Shirt" },
                    { new Guid("90aa5c2e-c45c-49a7-8826-2770a8e80e16"), -779867332, "Car" },
                    { new Guid("952d546b-b734-47a5-95ae-b1e6bbcfcfbd"), 445561553, "Shirt" },
                    { new Guid("9b4388aa-a64d-4afd-a7d6-65a8b6338dc3"), 370158378, "Chicken" },
                    { new Guid("9ca9299c-a910-464f-a8d0-766d7c0ded86"), -1333793576, "Ball" },
                    { new Guid("a0f36f68-f732-4f88-97bf-306746c9ac18"), -1505249307, "Cheese" },
                    { new Guid("a1fa29e1-5764-4e9f-a662-91008f1de8c2"), 363361933, "Car" },
                    { new Guid("a612ccb1-70ce-42ad-89d8-36ed204ff2b3"), 308080774, "Shoes" },
                    { new Guid("a7831ff4-f926-4357-a8b0-0848ef770ab2"), 345463391, "Bike" },
                    { new Guid("a8bcbbe9-69c1-481a-97af-b38d8c55823b"), -1535517061, "Tuna" },
                    { new Guid("a92d0917-eb06-46a6-808f-da2158554fb1"), -659320071, "Shoes" },
                    { new Guid("ab64c6b7-c7b6-4d19-b2c0-007d3d338449"), 1763114228, "Shoes" },
                    { new Guid("abd7447f-6860-490e-94d7-ae92bc779ef0"), -2128495606, "Salad" },
                    { new Guid("adc9426d-3431-424d-9d5e-8c4b1bbdbb86"), 541122768, "Hat" },
                    { new Guid("aee9f00e-5b74-4144-aab9-880e590c4e7b"), -1797903340, "Shoes" },
                    { new Guid("af91b910-4037-41df-b297-c988bf857c01"), -282343694, "Pizza" },
                    { new Guid("b9a5b797-4e3c-4e5e-80a4-367f86151dd0"), -1452400319, "Car" },
                    { new Guid("b9e99852-9043-448a-bcd5-17a2d5ff85cf"), -567597787, "Chicken" },
                    { new Guid("bf85ae8e-8c29-49e8-b562-9b412e673b09"), -1408593299, "Sausages" },
                    { new Guid("c3ae9cd1-ee0f-4a5c-a920-76eb82f9fc1e"), 838582190, "Salad" },
                    { new Guid("c4df4dc4-70dd-459c-90a3-2d42a0e4ff67"), 1667515128, "Pizza" },
                    { new Guid("c5bab8ae-8059-4e60-84ca-72cf5b0d547a"), 92668374, "Sausages" },
                    { new Guid("ce60e88d-6126-44f1-bc10-18735d2e9f0f"), -1180175853, "Fish" },
                    { new Guid("d3cff0b4-9f82-400e-b852-b7d28fe89bc8"), 266489183, "Ball" },
                    { new Guid("d6d45cbf-6a48-426b-b38a-fcd6553c5e1f"), -1403375145, "Chair" },
                    { new Guid("d70b6bd0-b634-492d-88df-9e06cfbcf3ef"), 1926546405, "Computer" },
                    { new Guid("d963768d-74cc-4c23-9758-f7c973ecf8ad"), -157698087, "Hat" },
                    { new Guid("daec52e1-0a40-4ec5-884a-117ebefd420c"), 1651114863, "Bike" },
                    { new Guid("dbee5958-2fc3-41e6-97f8-28998dfe3266"), 1104710316, "Mouse" },
                    { new Guid("dee2236b-29a5-4261-92d3-be5cf78c7526"), 1636812566, "Computer" },
                    { new Guid("e50f8e70-c57c-434d-a7a2-97226f4ec467"), 1627197131, "Fish" },
                    { new Guid("eaf0f09e-dad3-45e7-8930-0ddab618e956"), -839542981, "Keyboard" },
                    { new Guid("ec729070-2ad2-4acf-ba8d-aadc0bdf62bf"), 214112123, "Shirt" },
                    { new Guid("ed01c539-c8cb-43bd-95a5-b17550c2ca37"), 1845277201, "Gloves" },
                    { new Guid("ee288e2a-833b-4ca6-8e53-139a87942e83"), -2030178709, "Car" },
                    { new Guid("ee620fd1-a634-4180-9558-ccfd1427a795"), 368329661, "Computer" },
                    { new Guid("ff16214b-9056-4f57-a368-7629095d77ed"), -150440806, "Soap" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "ID", "Stores_title" },
                values: new object[,]
                {
                    { new Guid("0751c19c-dfd7-4570-8613-84733ec28449"), "Kids, Home & Health" },
                    { new Guid("09d27f7b-2556-44cf-8947-64e2b33d8c2d"), "Industrial" },
                    { new Guid("0f3763de-8774-4406-a832-7ce5fc8d73e4"), "Computers, Grocery & Outdoors" },
                    { new Guid("11bf6f33-b5a8-40bf-8702-fc7530382512"), "Books" },
                    { new Guid("1b2e1169-4449-4668-8ae9-4e4e412c1322"), "Grocery, Health & Movies" },
                    { new Guid("1fcd6652-ff1a-4bab-8482-c0669102b61f"), "Music" },
                    { new Guid("2bed4197-33d0-4caa-9ce0-a3599bb9b3a7"), "Shoes, Health & Automotive" },
                    { new Guid("2e8cb047-c922-4a2e-a552-ef22f800ce28"), "Health, Jewelery & Home" },
                    { new Guid("35e983f7-b551-4833-8b45-e96f178d44e5"), "Toys, Grocery & Music" },
                    { new Guid("3704073d-3d2c-4360-945c-a81c4028f592"), "Industrial, Beauty & Outdoors" },
                    { new Guid("38ee9d87-6f1d-4cbc-97b8-87024796c8cf"), "Sports & Toys" },
                    { new Guid("38fefa72-2135-43aa-a01f-865e8c2ad0fd"), "Tools, Baby & Games" },
                    { new Guid("3e4e2b5a-219d-4c15-86ed-8ebd355c5019"), "Automotive" },
                    { new Guid("49ea3eff-c22a-41e4-9276-5d95a82de59d"), "Games" },
                    { new Guid("54ab24a5-109a-47f5-9803-b08289d9871e"), "Home, Baby & Health" },
                    { new Guid("565b0562-49d5-43b4-9649-a10489dfb1a7"), "Jewelery & Electronics" },
                    { new Guid("5681b108-289f-4147-a7ff-c6f0c372f255"), "Grocery" },
                    { new Guid("5e7d2f14-8a27-421b-87d6-68f8cea52752"), "Sports" },
                    { new Guid("5fc33523-d212-4fcb-8a3c-c8f5b6fed999"), "Baby & Outdoors" },
                    { new Guid("639990b1-38c1-4746-8b09-f97157984fd9"), "Sports & Toys" },
                    { new Guid("680c2d94-b0ec-4040-b558-32b56f0eb1d5"), "Sports" },
                    { new Guid("6de84fd8-04ae-4b48-bf03-43342aa8058d"), "Garden" },
                    { new Guid("7859ac9a-66b1-4dac-8cb1-3e27e92b3e9a"), "Industrial" },
                    { new Guid("7c62f168-4277-473e-94ec-db522622594d"), "Tools" },
                    { new Guid("7dacf76a-a1a3-4c31-a3d0-5e0395cbe538"), "Sports" },
                    { new Guid("7dcd0e9f-6608-4450-b6fb-1e1ef32332d7"), "Music" },
                    { new Guid("7ddf2cf6-095c-4c5c-9739-9093b2699dbe"), "Books" },
                    { new Guid("7f66d2c6-29ce-42b5-bdf0-dd699863cdfb"), "Beauty, Games & Health" },
                    { new Guid("9459ab24-9949-4aa3-b2e9-206345e812d0"), "Kids, Music & Health" },
                    { new Guid("a15a04b7-7189-4fbb-a5ba-fa112d5a925e"), "Home, Kids & Sports" },
                    { new Guid("a3c73526-c96e-4e5d-b8bd-6cc392eba74d"), "Clothing" },
                    { new Guid("a549ad99-74b4-4fe0-9971-c7f611bbe5ba"), "Clothing" },
                    { new Guid("abcc2e41-d8b5-47a8-9b89-d4265fbbb9c3"), "Shoes & Shoes" },
                    { new Guid("b8851927-1480-414b-93d1-c7580130b692"), "Automotive, Garden & Electronics" },
                    { new Guid("b9638634-db3b-48ee-915a-399de5059305"), "Tools & Music" },
                    { new Guid("bfec6453-922f-4f13-9033-96387c951a7e"), "Home, Sports & Computers" },
                    { new Guid("c86dbd47-d43d-4e11-8f83-934042b8a404"), "Electronics" },
                    { new Guid("cb0cf49d-5cda-41d2-aaeb-3f78caeffcce"), "Baby" },
                    { new Guid("cb428e7f-2688-4a0b-beba-eefa98f74ad1"), "Shoes, Sports & Industrial" },
                    { new Guid("cd8ae90f-a87c-4553-bc03-7f903d957b5c"), "Shoes & Industrial" },
                    { new Guid("d22bf60e-ace9-4a0f-a798-0d0be984d5d8"), "Health" },
                    { new Guid("d7d12601-6297-44a8-b8b6-72b0dfaf2da3"), "Health, Industrial & Garden" },
                    { new Guid("e2c18bf5-b741-4085-b577-d0e8471b653d"), "Garden & Movies" },
                    { new Guid("e367008c-d5a5-49ca-b54b-3e3e21d9e94c"), "Shoes & Outdoors" },
                    { new Guid("e58a1188-18d4-4e7c-81f2-ace04272ab16"), "Music & Music" },
                    { new Guid("ed2ee2d1-86b4-47e1-b504-be3558e20d79"), "Sports & Industrial" },
                    { new Guid("edd14fc6-2103-4c14-b89a-75a4959cccea"), "Beauty, Home & Garden" },
                    { new Guid("f4692d14-1c95-4cd6-b135-0442665833c5"), "Music" },
                    { new Guid("f86e8f1b-3082-474c-88ce-7dd0ea2ed064"), "Movies, Kids & Beauty" },
                    { new Guid("fba93935-21a7-489b-92c3-6e55fb411b19"), "Automotive" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "ID", "Customers_ID", "Date", "Products_ID", "Stores_ID" },
                values: new object[,]
                {
                    { new Guid("03997ad5-9715-4fd2-adb9-cfc616383d0d"), new Guid("206602e7-b6f6-43e5-8bb8-d18e0685f319"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83b51db4-ee8a-439d-8da3-3480a281c4c2"), new Guid("1fcd6652-ff1a-4bab-8482-c0669102b61f") },
                    { new Guid("085d908c-8655-4f62-9b90-8b6a4109e1c0"), new Guid("7cf9ec82-52e5-44aa-bdae-83bdd2e70791"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ce60e88d-6126-44f1-bc10-18735d2e9f0f"), new Guid("edd14fc6-2103-4c14-b89a-75a4959cccea") },
                    { new Guid("2fd9ea37-b358-4c8f-9a06-51585934730e"), new Guid("09db64f2-42da-4dfc-8e26-8fb9c93c03fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83b51db4-ee8a-439d-8da3-3480a281c4c2"), new Guid("f86e8f1b-3082-474c-88ce-7dd0ea2ed064") },
                    { new Guid("345f3cc4-9989-415c-90ad-18474298a5cb"), new Guid("8af23ad1-078d-47a6-b24b-9ca35c724e29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d885358-6c71-46ff-8f77-2783c06a91f8"), new Guid("11bf6f33-b5a8-40bf-8702-fc7530382512") },
                    { new Guid("42b8fff8-9de7-4905-bff2-1c5fe6220e6a"), new Guid("0b47859c-9506-48d1-9d9c-f02f4f43d686"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ee288e2a-833b-4ca6-8e53-139a87942e83"), new Guid("f86e8f1b-3082-474c-88ce-7dd0ea2ed064") },
                    { new Guid("46a7da08-7fc8-4ff1-8854-810d1f07a372"), new Guid("e60e17e0-7eb3-49b0-a2aa-ce9191f073fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ab64c6b7-c7b6-4d19-b2c0-007d3d338449"), new Guid("11bf6f33-b5a8-40bf-8702-fc7530382512") },
                    { new Guid("4d2fa749-bd6b-470a-bafe-39a74491f6af"), new Guid("2bf6b142-027b-48d3-a1c7-43b1d541a721"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d65f6a1-a72f-4594-9d86-3f3a009c97fb"), new Guid("a3c73526-c96e-4e5d-b8bd-6cc392eba74d") },
                    { new Guid("55246ac8-6df2-4279-a423-4a8e8958ac08"), new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9ca9299c-a910-464f-a8d0-766d7c0ded86"), new Guid("abcc2e41-d8b5-47a8-9b89-d4265fbbb9c3") },
                    { new Guid("641fe2b8-5dfc-4e98-b63b-4fd8a8af45ad"), new Guid("3fd687a6-18bd-4805-bdfc-2218d2d01108"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7246c8ac-8a2e-4192-acb5-edf34139f28e"), new Guid("d22bf60e-ace9-4a0f-a798-0d0be984d5d8") },
                    { new Guid("6d437a86-f9e3-4d5e-ac4a-98ee97ce6381"), new Guid("490f9f51-76c1-4fae-bd3b-92b82c71351f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3f75ed22-2c21-49b6-872e-f56aca923794"), new Guid("f86e8f1b-3082-474c-88ce-7dd0ea2ed064") },
                    { new Guid("754ecd26-4123-4e7e-97a3-77a8e61c1ad2"), new Guid("0b47859c-9506-48d1-9d9c-f02f4f43d686"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("43864080-b9a9-4dc8-9e26-d1442c450779"), new Guid("bfec6453-922f-4f13-9033-96387c951a7e") },
                    { new Guid("75ccfc43-16ed-46b6-bb6b-8d3faa15ce08"), new Guid("308853c2-3060-42a0-bb2c-b528d11361c9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("abd7447f-6860-490e-94d7-ae92bc779ef0"), new Guid("c86dbd47-d43d-4e11-8f83-934042b8a404") },
                    { new Guid("80c2a2c9-8307-4ccd-92f3-56bbee6af839"), new Guid("0b096a5a-166a-4c69-b7a3-1d116d52c02c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7246c8ac-8a2e-4192-acb5-edf34139f28e"), new Guid("abcc2e41-d8b5-47a8-9b89-d4265fbbb9c3") },
                    { new Guid("8fcbe916-8c59-48fe-889c-b7f5aab8a5c5"), new Guid("3fd687a6-18bd-4805-bdfc-2218d2d01108"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("153fb67f-0cf9-4bbb-a880-49ec2551e16f"), new Guid("3704073d-3d2c-4360-945c-a81c4028f592") },
                    { new Guid("91c3fec7-a228-4f8a-813d-5dfa25a07434"), new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4dc89d24-4057-48ff-be05-3d45d31718ac"), new Guid("cb0cf49d-5cda-41d2-aaeb-3f78caeffcce") },
                    { new Guid("99fa8941-6703-4418-9108-fcf05389a034"), new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c365456-f233-4f94-8157-661200aea27c"), new Guid("b9638634-db3b-48ee-915a-399de5059305") },
                    { new Guid("a4962aa1-3eb5-4d6c-8e6f-33d58aaf8541"), new Guid("0204c9c5-110d-4575-a7b5-26900814e248"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aee9f00e-5b74-4144-aab9-880e590c4e7b"), new Guid("edd14fc6-2103-4c14-b89a-75a4959cccea") },
                    { new Guid("c5fb9b2d-e619-420c-a8de-fc9585d96d73"), new Guid("46cfcedf-8689-4eda-ab8c-b6e530f91227"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aee9f00e-5b74-4144-aab9-880e590c4e7b"), new Guid("7c62f168-4277-473e-94ec-db522622594d") },
                    { new Guid("c64ef65f-eaea-4b76-bfbc-1d283ced608d"), new Guid("9a5cef5f-c345-4bbc-98ef-fdf7fee6f0d7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("90aa5c2e-c45c-49a7-8826-2770a8e80e16"), new Guid("d22bf60e-ace9-4a0f-a798-0d0be984d5d8") },
                    { new Guid("db85a5d6-c664-408b-8a17-e941695d458e"), new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7d059e04-124e-4ebd-b57b-128d2f4d242e"), new Guid("cd8ae90f-a87c-4553-bc03-7f903d957b5c") },
                    { new Guid("e6f26733-fa21-4ea8-b202-e670124ef81b"), new Guid("0b47859c-9506-48d1-9d9c-f02f4f43d686"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1fa29e1-5764-4e9f-a662-91008f1de8c2"), new Guid("5e7d2f14-8a27-421b-87d6-68f8cea52752") },
                    { new Guid("e7e1dbbe-9466-4d36-afa4-e8b7132b46ef"), new Guid("828ed59f-7550-43d4-968f-a6bda1e0f829"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2a810134-4381-4a1c-80a0-ed0db9343679"), new Guid("49ea3eff-c22a-41e4-9276-5d95a82de59d") },
                    { new Guid("e8d143bd-c11e-4980-9b7a-27983f84058e"), new Guid("1cf311c6-7a11-4815-8059-9bdf4ff37579"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83b51db4-ee8a-439d-8da3-3480a281c4c2"), new Guid("54ab24a5-109a-47f5-9803-b08289d9871e") },
                    { new Guid("e9bf91ca-abb9-48d0-bf49-11075f6b0476"), new Guid("afa1d854-a3f6-468e-8374-ab99f9c3aca4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3d885358-6c71-46ff-8f77-2783c06a91f8"), new Guid("54ab24a5-109a-47f5-9803-b08289d9871e") },
                    { new Guid("f4ae4c2f-ff28-47c9-90bf-025365ed821d"), new Guid("05e516c5-d7b6-4cdc-928b-d66881482b0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a1fa29e1-5764-4e9f-a662-91008f1de8c2"), new Guid("b8851927-1480-414b-93d1-c7580130b692") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Customers_ID",
                table: "Sales",
                column: "Customers_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Products_ID",
                table: "Sales",
                column: "Products_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_Stores_ID",
                table: "Sales",
                column: "Stores_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}

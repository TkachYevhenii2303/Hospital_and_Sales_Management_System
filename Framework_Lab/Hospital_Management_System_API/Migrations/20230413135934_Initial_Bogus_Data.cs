using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Bogus_Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "ID", "Doctors_name", "Email", "Password_hash", "Specialty" },
                values: new object[,]
                {
                    { new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), "Roberto Bechtelar", "RobertoBechtelar.McCullough@hotmail.com", "9fYO0WwrXT", 1 },
                    { new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), "Shania Wintheiser", "ShaniaWintheiser64@gmail.com", "7s3_F_PhvB", 1 },
                    { new Guid("23bade39-5f05-45ac-80f8-608b424cc913"), "Robert Ondricka", "RobertOndricka_Crist@yahoo.com", "aydEkvzJPJ", 1 },
                    { new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), "Ariel Langworth", "ArielLangworth.Lesch33@gmail.com", "VKSnjpgxKv", 4 },
                    { new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"), "Hosea Johnston", "HoseaJohnston.Kunze@yahoo.com", "bzqVK6qprB", 3 },
                    { new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), "Palma Cummings", "PalmaCummings.Legros27@yahoo.com", "oRb6Pz05CI", 0 },
                    { new Guid("33a33b3e-14e6-4fca-8b8f-b3002c27b683"), "Rodolfo Monahan", "RodolfoMonahan.Smith@yahoo.com", "Pdm8qRr_KM", 2 },
                    { new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"), "Helene Goodwin", "HeleneGoodwin_Hansen80@hotmail.com", "XIAv712eIB", 1 },
                    { new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), "Daija Nitzsche", "DaijaNitzsche.Collins@hotmail.com", "dUOAirpErp", 1 },
                    { new Guid("3a798297-c07b-467c-b983-639062b9853b"), "Laurine Fisher", "LaurineFisher8@gmail.com", "B3CfO62tM_", 3 },
                    { new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"), "Eleonore Wiegand", "EleonoreWiegand.Bruen45@yahoo.com", "0MR8R7AWif", 3 },
                    { new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), "Myles Durgan", "MylesDurgan.Ryan@gmail.com", "tP3OLj1oGQ", 1 },
                    { new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), "Jamil Beatty", "JamilBeatty.Pouros@yahoo.com", "pFvzg7YuP7", 2 },
                    { new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"), "Ivory Pacocha", "IvoryPacocha_Reichert@yahoo.com", "WnKgUbN5Ys", 2 },
                    { new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), "Elenor Ebert", "ElenorEbert.Jones@yahoo.com", "qtqjJ6FcOl", 2 },
                    { new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"), "Jeromy Kling", "JeromyKling_Bartell@yahoo.com", "c3dQ0F7Hp7", 2 },
                    { new Guid("8e3d5e40-1032-4321-b7f5-9b6c92f7910d"), "Demetris Sporer", "DemetrisSporer_Cole@yahoo.com", "2clsfWEv2c", 5 },
                    { new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), "Jarred Volkman", "JarredVolkman97@gmail.com", "YrfJ3OlVQX", 4 },
                    { new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), "Marjory Macejkovic", "MarjoryMacejkovic.Hoeger@hotmail.com", "aaVmn6spaL", 0 },
                    { new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), "Herminio Carroll", "HerminioCarroll15@hotmail.com", "JXcvbyXNTW", 0 },
                    { new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), "Aron Hegmann", "AronHegmann_Mills94@hotmail.com", "y7NqL7NaJz", 3 },
                    { new Guid("e086b229-59cd-4b2b-b073-a85c32fa80b8"), "Rosalinda Cronin", "RosalindaCronin56@gmail.com", "vlDrvgQFd4", 1 },
                    { new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), "Lamar Feeney", "LamarFeeney_Cruickshank93@gmail.com", "NJyV8pQBrS", 0 },
                    { new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), "Dale Russel", "DaleRussel_Beer@hotmail.com", "8L7WOCE7mL", 4 },
                    { new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), "Delia Schamberger", "DeliaSchamberger84@yahoo.com", "94NokZldKq", 1 }
                });

            migrationBuilder.InsertData(
                table: "Medicaments",
                columns: new[] { "ID", "Medicaments_title" },
                values: new object[,]
                {
                    { new Guid("0658d7a5-3a63-4fd8-92be-78323d48333d"), "Soap" },
                    { new Guid("066ccb51-2c1a-45c9-8c26-071594ddeb98"), "Cheese" },
                    { new Guid("0881bac1-bd97-47fe-829e-7095f66d69a0"), "Chicken" },
                    { new Guid("0d13452b-8b26-4560-b6ed-dd635136e782"), "Fish" },
                    { new Guid("14ac274d-07ae-4ab9-91f0-38ac3ab00d7d"), "Chips" },
                    { new Guid("14bc4d79-d380-499f-bbaf-4c52b384ec88"), "Chips" },
                    { new Guid("18f0c16c-40f0-4595-8616-9415a8c05b7a"), "Gloves" },
                    { new Guid("1ceb9127-2c3e-475a-b5cf-501b94dd7808"), "Chips" },
                    { new Guid("1fe87f28-915c-4a61-b3a8-2e110efe4def"), "Sausages" },
                    { new Guid("24c88ec7-6fa0-45ad-93da-1808ccbf6d97"), "Computer" },
                    { new Guid("2745251c-46d2-4bf5-a84e-04768802d37b"), "Bacon" },
                    { new Guid("280e3441-babb-4956-b625-d126930f6f2d"), "Gloves" },
                    { new Guid("28958a55-393d-4aa1-9eb4-82c91dbfdc56"), "Hat" },
                    { new Guid("2a3f9202-94b3-4335-b821-d2dffbd22421"), "Car" },
                    { new Guid("2f31713c-4650-443e-83fc-26b6add67249"), "Car" },
                    { new Guid("3046cb46-ea0a-442a-91e5-c3a76d8e2390"), "Ball" },
                    { new Guid("30a8ad38-d4c7-4ba2-8402-a00288e951a6"), "Cheese" },
                    { new Guid("31e2bfc5-c31c-4b7b-a25a-a8317f91e2c6"), "Salad" },
                    { new Guid("37224f72-08a6-4559-ab12-4a572529325f"), "Chicken" },
                    { new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), "Soap" },
                    { new Guid("40335856-0f38-4a7f-9f5c-1435215356af"), "Table" },
                    { new Guid("44299736-eb6a-4b66-ac86-6c5932aa334b"), "Shirt" },
                    { new Guid("46ef0907-619c-4e9e-9d76-85a57ae262e9"), "Shirt" },
                    { new Guid("4de83fa4-818f-446d-9dd0-bb56f1e5a4fb"), "Towels" },
                    { new Guid("5dc1326a-0978-408c-8571-95a18ba04b8d"), "Fish" },
                    { new Guid("5f569f58-320b-4570-9fbf-94d93bc1ecc2"), "Ball" },
                    { new Guid("6122f9ae-e52f-4154-9ec6-38666b139177"), "Ball" },
                    { new Guid("692b75d4-bf15-4c09-80b0-46b787877e89"), "Cheese" },
                    { new Guid("6950b27c-2e9c-419b-be53-49d591446f8b"), "Soap" },
                    { new Guid("69dcc256-13f2-4b50-882a-613eae8190b3"), "Shirt" },
                    { new Guid("6dba3389-2057-439d-b5ea-81975c772a44"), "Soap" },
                    { new Guid("6dfa833d-fa98-4c38-9e09-a6f8483cb1a4"), "Towels" },
                    { new Guid("70fd3b60-2faa-459d-88d2-8bfeb89944ff"), "Tuna" },
                    { new Guid("76decd0d-3630-4aad-9447-2d33d90c7332"), "Soap" },
                    { new Guid("7758402a-2259-438f-af10-2c5262d1b0f8"), "Shirt" },
                    { new Guid("7b07f4ab-d666-4713-a4b4-53f8175da156"), "Fish" },
                    { new Guid("7ca51590-4c1e-4785-88a2-94b87f98b135"), "Shirt" },
                    { new Guid("7d672779-3b56-4ce0-adcd-9c5c06847c76"), "Salad" },
                    { new Guid("84030ce3-295a-4a5d-ac29-9bfb534e050f"), "Cheese" },
                    { new Guid("84e38bb4-d6da-4fe8-9655-f03637f099f9"), "Sausages" },
                    { new Guid("84fe8e37-472a-4723-9597-91a49edcda31"), "Chips" },
                    { new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"), "Tuna" },
                    { new Guid("8a49ab12-0b03-4555-aca3-fda84cc9b9e6"), "Chips" },
                    { new Guid("9803a13c-cb55-442d-9bfa-e674ea87fe22"), "Computer" },
                    { new Guid("993ca5ca-b6ac-4f41-bbb0-1b165678598e"), "Pants" },
                    { new Guid("9b2bd6d3-0da9-45e7-a2dc-f706f0391980"), "Pants" },
                    { new Guid("9bdef98a-2baf-41bd-8563-9910d59d934d"), "Soap" },
                    { new Guid("9c5071d5-7670-4efe-9899-64c8f09c61b0"), "Bacon" },
                    { new Guid("9e4d2b80-29f9-437b-b3b1-b676bccf615f"), "Mouse" },
                    { new Guid("9f6db193-a0d7-4bc4-bb04-48dd4a2ef3c6"), "Computer" },
                    { new Guid("af8ca68f-a655-4131-a595-cc0547f29d90"), "Car" },
                    { new Guid("afe1843b-2134-4ea4-b4b7-d86e0b124f1c"), "Sausages" },
                    { new Guid("b93b0114-ed73-4ba9-ba6e-090444dd2f19"), "Chips" },
                    { new Guid("ba982841-ddd1-4fde-b1db-d5e563fea40c"), "Mouse" },
                    { new Guid("c11ba176-fd9a-4d60-8f60-74f1e5bbb62a"), "Gloves" },
                    { new Guid("ca4c9f80-079c-481d-9c6d-26522267c98f"), "Shirt" },
                    { new Guid("d25e56ba-97b2-479a-8f4f-b7e8e33e6b21"), "Gloves" },
                    { new Guid("d33664d4-f683-43a6-80b3-76212979e328"), "Mouse" },
                    { new Guid("d675cbbb-eda1-4088-890c-0dec83e55736"), "Tuna" },
                    { new Guid("ddc28224-bb14-4eec-9337-5da6fafe0b74"), "Pants" },
                    { new Guid("e1cbdd21-1c98-4444-82ed-799ad66639b3"), "Table" },
                    { new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"), "Bike" },
                    { new Guid("e2a46cc9-0ae1-44b5-a9d4-2be26bf87e32"), "Table" },
                    { new Guid("e2e6abfa-fdd6-420f-b99a-1d328a964cbe"), "Shoes" },
                    { new Guid("e2f0386b-b9bd-4866-8910-bf797a2c415f"), "Sausages" },
                    { new Guid("e676bdb7-a88d-476c-82a5-cca3bc3a63b3"), "Shoes" },
                    { new Guid("e7163fa2-ec63-4f0c-907f-87abdfa94d9e"), "Sausages" },
                    { new Guid("e85ccb66-2736-4ef8-a340-388e5c2ad622"), "Ball" },
                    { new Guid("e9ef7615-81b6-493d-8fed-fa9e1f2fa954"), "Fish" },
                    { new Guid("ec5604b0-1a8b-4480-9692-c6b726a35bdd"), "Bacon" },
                    { new Guid("ee918af8-48f6-4d2e-914d-515db1ffa9ab"), "Chicken" },
                    { new Guid("ef55a6f8-7722-4af0-952c-5eb2138ed3da"), "Ball" },
                    { new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"), "Hat" },
                    { new Guid("ff0f76ce-2272-45ce-bc47-074779d2598f"), "Car" },
                    { new Guid("ffa45e51-7417-4700-9dcf-017e9d00292e"), "Hat" }
                });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "ID", "Address", "Email", "Has_Insuranse", "Patients_first_name", "Patients_last_name" },
                values: new object[,]
                {
                    { new Guid("0208a602-21bd-4533-95d0-45d8908eea16"), "The address: 9751 Jevon Knolls, Lake Mervinberg, Burkina Faso", "Vince63@yahoo.com", false, "Vince", "Jakubowski" },
                    { new Guid("0465ca14-a869-4f69-9929-e39a7675170f"), "The address: 799 Linda Motorway, Stephanieport, Kiribati", "Marilie.Wolff@gmail.com", false, "Marilie", "Wolff" },
                    { new Guid("051a2363-9054-4dc3-a108-f8c845bdeba7"), "The address: 58529 Gutkowski Highway, West Columbus, Slovakia (Slovak Republic)", "Rosetta52@hotmail.com", false, "Rosetta", "Mohr" },
                    { new Guid("056e56a8-3da8-4472-b7f9-095c23d71833"), "The address: 651 Bogisich Run, Hammesland, Burundi", "Darron_Feest99@hotmail.com", true, "Darron", "Feest" },
                    { new Guid("060e6b87-19b9-450c-b3f8-b8bce9433e47"), "The address: 442 Connor Summit, Baronton, Afghanistan", "Leland.Rempel83@yahoo.com", true, "Leland", "Rempel" },
                    { new Guid("07243997-27dc-44fb-91e8-78b79c12a365"), "The address: 4881 Octavia Valley, Rogersport, French Southern Territories", "Julien_Glover@hotmail.com", true, "Julien", "Glover" },
                    { new Guid("07a2c9f0-336c-4a87-bf1c-427ceffba480"), "The address: 434 Hildegard Ports, North Branson, Lesotho", "Laila.Kub24@yahoo.com", false, "Laila", "Kub" },
                    { new Guid("0894e3c6-bf19-4294-a7a6-44fabb7e53e4"), "The address: 87108 Zachary Mountains, Baileyport, Tanzania", "Alexandro_Zulauf@yahoo.com", false, "Alexandro", "Zulauf" },
                    { new Guid("09bfad34-85cf-49ff-a63e-a03e11b4032d"), "The address: 2465 Urban Shore, West Tatummouth, Mayotte", "Anastacio_Kunde38@hotmail.com", true, "Anastacio", "Kunde" },
                    { new Guid("0bfcf543-3355-4715-b2ad-17fba1d5a263"), "The address: 163 Will Curve, Miguelville, Ecuador", "Angel.Kuphal@yahoo.com", false, "Angel", "Kuphal" },
                    { new Guid("0c166491-4c73-4064-93da-08284afda695"), "The address: 2729 Trantow Shore, Port Estelleton, Denmark", "Daphnee_Batz@gmail.com", true, "Daphnee", "Batz" },
                    { new Guid("0d928f2a-4c26-4382-96b5-2636b3b0698d"), "The address: 7649 Cassie Divide, McKenzieshire, Greece", "Cleora.Steuber@yahoo.com", true, "Cleora", "Steuber" },
                    { new Guid("0dc2a631-4457-41f7-921d-a4444d635166"), "The address: 0268 Quitzon Mill, Milofort, United States of America", "Zane79@gmail.com", false, "Zane", "Luettgen" },
                    { new Guid("0ecd8487-f43a-46f8-a409-14934fe06ce0"), "The address: 3178 Anthony Orchard, North Eusebioport, South Georgia and the South Sandwich Islands", "Hazle.Hauck@gmail.com", true, "Hazle", "Hauck" },
                    { new Guid("0eeecb7e-4eb0-4ff5-a37a-7a67e06fd026"), "The address: 4262 Isabella Burgs, Creminmouth, Saint Barthelemy", "Ethan.Welch@yahoo.com", true, "Ethan", "Welch" },
                    { new Guid("11b875d5-8031-4662-af6f-81a9459c0537"), "The address: 0314 Percival Skyway, Bartolettifurt, French Polynesia", "Cyrus.Bogisich51@gmail.com", true, "Cyrus", "Bogisich" },
                    { new Guid("129c1071-9d4e-4cbd-9e1d-c05536a2c0e6"), "The address: 5708 Kay Ville, Austenmouth, Mauritius", "Reid_McKenzie24@yahoo.com", true, "Reid", "McKenzie" },
                    { new Guid("12b4e896-154c-471d-99df-2ed343213784"), "The address: 4144 Nova Throughway, Dibbertville, Yemen", "Nels56@hotmail.com", true, "Nels", "Monahan" },
                    { new Guid("13623fcc-d7b4-4fb7-9c48-58b2015c9d82"), "The address: 6252 Alisa Green, MacGyverchester, Costa Rica", "Theodora_Abernathy@yahoo.com", true, "Theodora", "Abernathy" },
                    { new Guid("156cc60f-95d4-42bd-a7f0-8bc433dad5a9"), "The address: 316 Madisen Station, Lake Rachaelstad, Slovenia", "Jayme_Dare@gmail.com", false, "Jayme", "Dare" },
                    { new Guid("157fca20-9e2d-4e80-b44f-7415f83471d2"), "The address: 244 Hills Mews, Port Alishahaven, Botswana", "Barry_Johnson@hotmail.com", false, "Barry", "Johnson" },
                    { new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e"), "The address: 00356 Graham Viaduct, New Marian, Afghanistan", "Kaylie89@gmail.com", true, "Kaylie", "Stehr" },
                    { new Guid("1d7d3c84-2713-4914-ae91-9981ec51a936"), "The address: 84181 Hardy Track, Port Claude, San Marino", "Mary.Beatty@gmail.com", false, "Mary", "Beatty" },
                    { new Guid("1f53d9fa-a550-4086-ba2e-911a1853be0e"), "The address: 9338 Olson Pike, Port Adolph, Burkina Faso", "Nedra74@gmail.com", false, "Nedra", "Yost" },
                    { new Guid("2012c563-324f-4db6-a478-dff4c8379690"), "The address: 5923 Gabriella Fall, West Diegochester, Kazakhstan", "Justine.Luettgen38@yahoo.com", false, "Justine", "Luettgen" },
                    { new Guid("213b5a60-d8a9-48f2-9341-56b7ea5fd98d"), "The address: 57574 King Meadows, Kubville, Tonga", "Brigitte.Mante62@gmail.com", true, "Brigitte", "Mante" },
                    { new Guid("213c336a-4f3a-4d1a-8161-11baf29cfa42"), "The address: 12503 Volkman Greens, Lake Waynehaven, Costa Rica", "Simone40@gmail.com", false, "Simone", "Hirthe" },
                    { new Guid("24e31d9e-ce06-4f29-b99e-3f80664a0fa4"), "The address: 36813 Alisha Lodge, Arthurmouth, Seychelles", "Fredrick.Haag71@hotmail.com", false, "Fredrick", "Haag" },
                    { new Guid("26029586-c8d2-4f17-84c5-6796078b420c"), "The address: 982 Hayes Estates, Bettebury, Jamaica", "Maximus.Walker79@gmail.com", false, "Maximus", "Walker" },
                    { new Guid("27da5463-f04c-4cd7-b1d6-76e6d52471fb"), "The address: 895 Zboncak Lakes, Berenicestad, South Georgia and the South Sandwich Islands", "Reyna.Gutmann@yahoo.com", true, "Reyna", "Gutmann" },
                    { new Guid("28256e0b-cfe6-48ea-a034-8896358289ff"), "The address: 26862 Satterfield Viaduct, North Raeganchester, Mexico", "Lila15@gmail.com", false, "Lila", "Reinger" },
                    { new Guid("2b96c93c-88aa-4a63-b61c-9f13278cc8c9"), "The address: 33140 Gennaro Key, West Santa, Virgin Islands, U.S.", "Elfrieda_Buckridge@yahoo.com", true, "Elfrieda", "Buckridge" },
                    { new Guid("2bf97bed-f1bc-4226-9f75-7d667c166a25"), "The address: 2941 Larson Ports, Nicolasbury, Dominican Republic", "Craig.Boyer@hotmail.com", true, "Craig", "Boyer" },
                    { new Guid("2bfc3e7c-f045-413f-95f9-f9375a338435"), "The address: 42796 Stokes Drives, South Gregory, Oman", "Karolann_Bahringer42@hotmail.com", true, "Karolann", "Bahringer" },
                    { new Guid("2c27f180-fd4f-4bf0-b4e7-3c4f72abd8dd"), "The address: 7508 Heller Loaf, Brittanytown, Belarus", "Ewell.Fay5@yahoo.com", true, "Ewell", "Fay" },
                    { new Guid("2d6bd052-0b8f-4c96-ab7d-fd8cfff356fe"), "The address: 2772 Edythe Fork, Boganland, Latvia", "Keshaun32@yahoo.com", true, "Keshaun", "Thiel" },
                    { new Guid("2ee20b64-f6a9-4c36-928e-2b17b18c1415"), "The address: 2828 Schroeder Expressway, Joshuaside, Myanmar", "Mollie.Hessel79@yahoo.com", true, "Mollie", "Hessel" },
                    { new Guid("30a30531-0e2e-4d61-acb5-183c3e2f7602"), "The address: 821 Prosacco Lodge, Konopelskiberg, Comoros", "Travon.Kling@gmail.com", true, "Travon", "Kling" },
                    { new Guid("359f3c6a-d30b-4cfe-ade5-f0cd78f9dc52"), "The address: 341 Lueilwitz Loop, Romagueraton, Jordan", "Krystel_Gibson94@gmail.com", true, "Krystel", "Gibson" },
                    { new Guid("374093a3-bfaa-4a73-b1c0-bb8eb0d75ba9"), "The address: 60257 Louvenia Ports, West Jessika, Macedonia", "Janessa_Waelchi@gmail.com", false, "Janessa", "Waelchi" },
                    { new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7"), "The address: 590 Glen Knoll, Boehmton, El Salvador", "Shany41@yahoo.com", true, "Shany", "Stracke" },
                    { new Guid("3a756c63-5430-42f4-814f-1e37e12a3ad1"), "The address: 9167 Abshire Knoll, Gwenfort, South Africa", "Jarrell.Mohr49@yahoo.com", false, "Jarrell", "Mohr" },
                    { new Guid("3c319cfe-9452-4e16-826b-a4a9c012eebf"), "The address: 9602 Gulgowski Cove, Larsonstad, Iceland", "Ellis47@hotmail.com", false, "Ellis", "Ward" },
                    { new Guid("3c8d81ec-c16e-4473-ac68-c9100b222485"), "The address: 711 Walsh Shoals, New Sophia, Pakistan", "Molly_Ortiz@hotmail.com", true, "Molly", "Ortiz" },
                    { new Guid("3c9c7b28-e55e-40e6-9a33-c8a2da7f6b96"), "The address: 47342 Jacobson Stream, Lake Arlie, Tanzania", "Dennis22@yahoo.com", true, "Dennis", "Haley" },
                    { new Guid("3daad96f-7de7-4964-8065-056fe321eeb0"), "The address: 7714 Walter Locks, West Aleneland, Denmark", "Bonita_Zboncak45@yahoo.com", false, "Bonita", "Zboncak" },
                    { new Guid("3e9143b0-5667-473a-b0de-b65984e02e5b"), "The address: 965 Joanie Greens, Towneside, El Salvador", "Ansley_Leuschke@gmail.com", true, "Ansley", "Leuschke" },
                    { new Guid("3e97e0a4-cdf4-4a5b-9698-6420a9dd6770"), "The address: 817 Ezequiel Locks, Russelfurt, Pitcairn Islands", "Cyrus72@hotmail.com", false, "Cyrus", "Schaden" },
                    { new Guid("3fa1547f-a5cc-48d1-bab0-cbc3de0dbc2d"), "The address: 450 Yvonne Crest, Mayertborough, Bahamas", "Ettie_Lueilwitz25@yahoo.com", false, "Ettie", "Lueilwitz" },
                    { new Guid("3ff556af-19d8-4f11-9609-af144dbd709e"), "The address: 636 Julian Tunnel, South General, Ethiopia", "Gretchen_Yundt@hotmail.com", false, "Gretchen", "Yundt" },
                    { new Guid("4072b127-2891-4ac6-8b0a-baef95b325f4"), "The address: 7779 Travis Trail, New Melliemouth, Albania", "Moises_Zemlak16@hotmail.com", false, "Moises", "Zemlak" },
                    { new Guid("42504898-86e2-4510-a02a-8063eb338b8a"), "The address: 69429 Barrows Forest, New Fernport, Hong Kong", "Deonte.Prohaska7@yahoo.com", true, "Deonte", "Prohaska" },
                    { new Guid("426356a4-e7ce-49ac-8d74-5ae599a6e116"), "The address: 5421 Cathy Point, West Pierre, Tuvalu", "Citlalli.Strosin94@yahoo.com", false, "Citlalli", "Strosin" },
                    { new Guid("43881999-d5c9-4da9-9c5a-739548f8720c"), "The address: 9548 Bogan Mountain, New Deannahaven, Svalbard & Jan Mayen Islands", "Tevin13@hotmail.com", true, "Tevin", "Tromp" },
                    { new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684"), "The address: 027 Nienow Ford, West Breanaburgh, Moldova", "Annie.Zieme@hotmail.com", false, "Annie", "Zieme" },
                    { new Guid("4452b1c6-8b89-42aa-9d59-d64ddaaa8d9d"), "The address: 29977 Runolfsdottir Highway, Sylviastad, Puerto Rico", "Isac_Kris2@gmail.com", false, "Isac", "Kris" },
                    { new Guid("44c19fc2-112f-4dc3-ad0f-3e147fa7d18d"), "The address: 5851 Else Trail, North Raina, Guernsey", "Gerald_Okuneva@gmail.com", false, "Gerald", "Okuneva" },
                    { new Guid("45732846-cb07-42d6-8bb9-72a9e28dcea0"), "The address: 5577 Bins Village, West Marlenport, Lebanon", "Mathias.Harris@hotmail.com", false, "Mathias", "Harris" },
                    { new Guid("457a85ea-235e-46bd-9c7c-127755bfaae2"), "The address: 3084 Lonny Cape, New Gregoria, Kyrgyz Republic", "Gennaro_Zboncak@yahoo.com", true, "Gennaro", "Zboncak" },
                    { new Guid("4630f1fa-8a65-4058-a8ad-824aa75c3769"), "The address: 34551 Barrows Gateway, West Elsie, Cuba", "Hulda41@hotmail.com", true, "Hulda", "Flatley" },
                    { new Guid("478f0c75-2c9f-4a85-963f-86b6c0aeef58"), "The address: 458 Hayley Mountain, Gracielaside, Senegal", "Bartholome13@hotmail.com", false, "Bartholome", "Leuschke" },
                    { new Guid("47cff722-e4c4-4f48-9e18-6f88cd6b8f4b"), "The address: 741 Breitenberg Hollow, Harberport, Swaziland", "Isac.Hackett@gmail.com", true, "Isac", "Hackett" },
                    { new Guid("49d699c4-e8ba-42f5-b634-c41b579937b0"), "The address: 688 Wisoky Island, West Alvah, Ukraine", "Gerard.Baumbach@gmail.com", false, "Gerard", "Baumbach" },
                    { new Guid("4b763573-b537-4005-ab95-25c0a81a6d33"), "The address: 343 Kirsten Parkways, New Vena, Burkina Faso", "Abagail_Carroll16@gmail.com", true, "Abagail", "Carroll" },
                    { new Guid("4d263298-1780-4eb2-b7d6-b69b6f3484e9"), "The address: 5768 Enrico Landing, Reingerton, Mongolia", "Loyal.Adams55@hotmail.com", true, "Loyal", "Adams" },
                    { new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059"), "The address: 2001 Runte Freeway, South Joshuahfurt, Cocos (Keeling) Islands", "Kaci0@gmail.com", true, "Kaci", "Rice" },
                    { new Guid("4fa018dd-091f-481b-b905-4856e7795e63"), "The address: 1823 Barry Creek, Port Janick, Equatorial Guinea", "Willa_King@yahoo.com", false, "Willa", "King" },
                    { new Guid("5080ec34-d105-477e-8be1-094862c9e390"), "The address: 072 Wilma Dale, Port Troy, Dominican Republic", "Kristopher_Ortiz40@hotmail.com", true, "Kristopher", "Ortiz" },
                    { new Guid("511b2e18-efc3-44c7-9819-ab389144f943"), "The address: 070 Cathy Hill, North Meghanfurt, El Salvador", "Tressa_Macejkovic@gmail.com", true, "Tressa", "Macejkovic" },
                    { new Guid("5154c326-bdd9-4e2c-82cd-6e902c2bb58a"), "The address: 8632 Annabell Meadow, New Danaland, United States Minor Outlying Islands", "Kavon.Breitenberg@hotmail.com", false, "Kavon", "Breitenberg" },
                    { new Guid("525d056b-9c97-496b-9b1d-b42d6533c919"), "The address: 6050 Wendy Mall, Edmouth, Guinea-Bissau", "Agustin_Kihn54@gmail.com", false, "Agustin", "Kihn" },
                    { new Guid("52f53071-9ec3-40b6-a804-8414d817edf3"), "The address: 9990 Wolff Gardens, Lindhaven, Puerto Rico", "Walker_Ferry@yahoo.com", false, "Walker", "Ferry" },
                    { new Guid("554194df-5afa-4232-b461-132182c64a1b"), "The address: 96184 Schamberger Manors, Ryleyport, Denmark", "Seth_Franecki61@hotmail.com", false, "Seth", "Franecki" },
                    { new Guid("55e0e6e5-eae4-454a-9457-7d1baedde998"), "The address: 576 Jannie Junctions, Morissettemouth, Philippines", "Christy.Dickinson78@yahoo.com", false, "Christy", "Dickinson" },
                    { new Guid("59456922-edf5-4643-9854-124ae496a1d5"), "The address: 930 Oberbrunner Ports, Port Daphne, Czech Republic", "Thelma.VonRueden76@hotmail.com", true, "Thelma", "VonRueden" },
                    { new Guid("5ab15f1c-3352-40e6-918d-51d69903dba4"), "The address: 400 Carole Tunnel, Lake Jermaineburgh, Costa Rica", "Kamron46@gmail.com", true, "Kamron", "Howe" },
                    { new Guid("5ba3b2ea-74c9-4581-8468-4831a3365be1"), "The address: 413 Renner Union, Murrayshire, Australia", "Louie.Bartoletti@hotmail.com", false, "Louie", "Bartoletti" },
                    { new Guid("5c9b1c64-1c30-4013-9183-5a9e970b6349"), "The address: 397 Batz Forks, Port Gloria, Greece", "Gracie_Carroll5@gmail.com", true, "Gracie", "Carroll" },
                    { new Guid("5d6136ba-9604-47f8-882a-0913acc43e4b"), "The address: 385 Von Club, Mablefort, Netherlands Antilles", "Delaney87@yahoo.com", false, "Delaney", "DuBuque" },
                    { new Guid("5ddb8e45-7ec9-49b0-8865-a3d6175be718"), "The address: 2960 Kautzer Villages, Lake Garrisonport, Grenada", "Reece_Quigley68@gmail.com", true, "Reece", "Quigley" },
                    { new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115"), "The address: 88327 Welch Run, Destinichester, Liberia", "Ladarius.Gutmann@yahoo.com", true, "Ladarius", "Gutmann" },
                    { new Guid("5f3e9730-5372-4711-a812-d467b1cb144b"), "The address: 91820 Ernest Port, Evaville, Slovenia", "Melody_Little45@gmail.com", false, "Melody", "Little" },
                    { new Guid("627b9f5b-62ea-4e50-8646-0471c2cfbbfc"), "The address: 4050 Thiel Turnpike, Littleport, Bolivia", "Lupe_OConner@gmail.com", false, "Lupe", "O'Conner" },
                    { new Guid("634f3997-7f5c-49dc-a4ef-e4072fcc8f56"), "The address: 6477 Florencio Road, Geovanychester, Cuba", "Lura38@gmail.com", true, "Lura", "Stracke" },
                    { new Guid("64ef5204-68fa-4f85-81b3-89fdfb01a6c1"), "The address: 15203 Koepp Ramp, East Anissafort, Belarus", "Chanel_OConnell82@gmail.com", true, "Chanel", "O'Connell" },
                    { new Guid("65b4175b-fc0b-451c-8ecb-a2f80750f2e0"), "The address: 41176 Stokes Inlet, Hilpertberg, French Polynesia", "Krystel71@yahoo.com", true, "Krystel", "Purdy" },
                    { new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735"), "The address: 8900 Geo Course, Port Coty, Nigeria", "Burnice.Rice@yahoo.com", false, "Burnice", "Rice" },
                    { new Guid("6a2e13be-4a7e-4475-ade9-837eb81690d3"), "The address: 351 Price Dam, Mullerberg, Aruba", "Alaina.Herman@gmail.com", false, "Alaina", "Herman" },
                    { new Guid("6a376686-556a-43f9-8285-428abbfcdcad"), "The address: 64826 Kuvalis Mountain, North Alfredoborough, Yemen", "Louisa_Morissette23@hotmail.com", true, "Louisa", "Morissette" },
                    { new Guid("6bdc0ab5-6380-49f4-8e58-6b8380c8304c"), "The address: 078 Gregg Lakes, Everardoland, Yemen", "Cecile5@yahoo.com", true, "Cecile", "Rosenbaum" },
                    { new Guid("6c98aaee-4c17-43fd-9558-13228f4988c9"), "The address: 7587 Schultz Summit, North Colby, Saint Lucia", "Jamar.Jacobs@hotmail.com", true, "Jamar", "Jacobs" },
                    { new Guid("6cc4cf48-e085-434f-a862-7362f18110dd"), "The address: 8557 Marina Station, New Wymanberg, Timor-Leste", "Keely89@yahoo.com", false, "Keely", "Gaylord" },
                    { new Guid("6df27f42-990d-4e8b-b3a8-ce14647b21a1"), "The address: 02484 Cormier Dale, Kingfurt, Guyana", "Hans_Orn@gmail.com", false, "Hans", "Orn" },
                    { new Guid("71dab545-e32d-40a7-ad88-cf613e24af80"), "The address: 417 Orn Forges, Milanshire, Namibia", "Trenton_Spinka@gmail.com", false, "Trenton", "Spinka" },
                    { new Guid("71e13137-4234-4351-8988-f6cc67a6bf1b"), "The address: 386 Huel Dale, West Bradyberg, Mauritius", "Natalie.Pacocha@hotmail.com", true, "Natalie", "Pacocha" },
                    { new Guid("726b16e7-efd2-439e-af51-c7db5c0767ef"), "The address: 573 Coy Brooks, Jalonborough, Cape Verde", "Hildegard.Zulauf39@hotmail.com", true, "Hildegard", "Zulauf" },
                    { new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4"), "The address: 72350 Manuel Garden, West Hannahport, Saint Pierre and Miquelon", "Jayda.Oberbrunner14@yahoo.com", true, "Jayda", "Oberbrunner" },
                    { new Guid("744b7b47-c075-4158-81ba-a8dd8b76c4ee"), "The address: 672 Bartoletti Village, Runolfsdottirmouth, Liechtenstein", "Kris_Christiansen@yahoo.com", true, "Kris", "Christiansen" },
                    { new Guid("756247ae-bd2e-4300-a8b9-531f88248ac1"), "The address: 84896 Kimberly Neck, Faheyshire, Macao", "Jeanie.Gusikowski84@yahoo.com", true, "Jeanie", "Gusikowski" },
                    { new Guid("762411cc-845f-4172-8c18-161a49f5d9c8"), "The address: 690 Maryjane Rapids, Port Jaidahaven, Central African Republic", "Alexa28@gmail.com", false, "Alexa", "Block" },
                    { new Guid("7821c1ab-2cbe-42b8-a861-4f3840382a16"), "The address: 740 Bins Isle, Bartellmouth, Pakistan", "Meghan.Mueller@yahoo.com", true, "Meghan", "Mueller" },
                    { new Guid("78cb0444-844f-49f7-a5cc-dc17fe50117b"), "The address: 6706 Barton Mission, Urielport, Palestinian Territory", "Abbigail74@hotmail.com", false, "Abbigail", "Turcotte" },
                    { new Guid("790a3927-f12e-42fe-94e0-2d22da9e5bd5"), "The address: 70665 Hintz Courts, Port Elbertburgh, Virgin Islands, U.S.", "Madyson.Crist59@yahoo.com", false, "Madyson", "Crist" },
                    { new Guid("7912e932-c885-4dc4-a258-7505c40bb959"), "The address: 755 Marcel Shoals, South Lorena, Cote d'Ivoire", "Morgan_Ledner@hotmail.com", false, "Morgan", "Ledner" },
                    { new Guid("794b85ff-393e-4564-993b-cdcb9718d128"), "The address: 23331 Eloisa Cape, South Alfonso, Switzerland", "Lavada.Kerluke77@gmail.com", true, "Lavada", "Kerluke" },
                    { new Guid("798f293d-6f50-47f3-9a15-88a2945a4ee2"), "The address: 323 Mitchell Corner, South Savanna, Wallis and Futuna", "Callie.Crooks@yahoo.com", false, "Callie", "Crooks" },
                    { new Guid("79b8948c-0f6e-4350-8bae-99666feb169d"), "The address: 8601 Padberg Vista, Spencerberg, Democratic People's Republic of Korea", "Margarita_Wilkinson@hotmail.com", true, "Margarita", "Wilkinson" },
                    { new Guid("7a0a4358-5130-49f3-badf-b4bbeed382cf"), "The address: 32053 Braun Port, Purdyview, Mozambique", "Juliana_Medhurst6@yahoo.com", true, "Juliana", "Medhurst" },
                    { new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853"), "The address: 95025 Candace Plaza, Port Linniefurt, Jordan", "Jace72@yahoo.com", false, "Jace", "Blanda" },
                    { new Guid("7c994242-8c36-4776-84cd-ca241ca48dd2"), "The address: 075 Reinhold Track, Jacobstown, United States of America", "Baron56@yahoo.com", true, "Baron", "Romaguera" },
                    { new Guid("7da3faea-318b-4ad4-a66d-62be34dfd6bc"), "The address: 3787 Polly Trafficway, Port Merlehaven, Virgin Islands, British", "Robbie69@hotmail.com", true, "Robbie", "Kozey" },
                    { new Guid("7e4dd588-b35e-4477-848f-75b082e57c25"), "The address: 1337 Stiedemann Alley, Chettown, Lithuania", "Ada.Feil95@yahoo.com", false, "Ada", "Feil" },
                    { new Guid("7efa7a93-621c-438b-aa92-e547ea51a297"), "The address: 856 Blick Harbors, Port Caleighview, Monaco", "Wilson77@hotmail.com", true, "Wilson", "Orn" },
                    { new Guid("80105bf0-db71-4b11-a006-87ee3449b929"), "The address: 072 Grayce Cove, Jalentown, Lesotho", "Mckenzie.Abbott48@gmail.com", false, "Mckenzie", "Abbott" },
                    { new Guid("81a9284b-7e16-4a66-8182-2e8932483261"), "The address: 4664 Aliya Center, East Ladarius, South Africa", "Amanda_Mills51@gmail.com", false, "Amanda", "Mills" },
                    { new Guid("81c14a06-36c0-4b3e-8a34-ae99e5b61e97"), "The address: 5795 Pouros Highway, Delilahview, Micronesia", "Emmy.DuBuque2@hotmail.com", true, "Emmy", "DuBuque" },
                    { new Guid("8352a3b5-4933-49f6-904e-be1daf133d75"), "The address: 93875 Helmer Parks, South Vena, Fiji", "Sylvia.Bartell75@gmail.com", true, "Sylvia", "Bartell" },
                    { new Guid("854e328c-d95a-44af-8ede-110adde91323"), "The address: 0987 Berge Ford, Euniceland, Hong Kong", "London_Schimmel89@gmail.com", false, "London", "Schimmel" },
                    { new Guid("85d0b25c-94c6-41d9-a1f4-4f83ff2d93fa"), "The address: 24305 Alysha Lodge, Baileyton, Moldova", "Daisha74@gmail.com", false, "Daisha", "Hansen" },
                    { new Guid("8675aa5b-df90-468d-b451-120d3d5a332d"), "The address: 8664 Josianne Dam, Lake Eldorabury, Albania", "Dean86@gmail.com", false, "Dean", "Hintz" },
                    { new Guid("89d37238-1f2f-4d0b-a737-dc6f46d0993f"), "The address: 374 Keven Freeway, East Lorenzashire, China", "Belle.Hayes19@yahoo.com", true, "Belle", "Hayes" },
                    { new Guid("89f89cae-a29d-4f16-91ca-ffeb950136d8"), "The address: 28284 Labadie Street, Kolechester, Benin", "Jaylan_Friesen47@yahoo.com", false, "Jaylan", "Friesen" },
                    { new Guid("8b5e0f4b-9e6f-436b-bc22-2b24960608f0"), "The address: 04440 Runolfsdottir Ford, Batzside, Venezuela", "Jan7@gmail.com", true, "Jan", "Raynor" },
                    { new Guid("8b9a5d8e-e058-4155-bebf-cdc65acf35d1"), "The address: 6534 Rice Tunnel, Donnellyshire, Finland", "Quinton.Mueller9@yahoo.com", false, "Quinton", "Mueller" },
                    { new Guid("8c2d0541-c11e-4f99-9eed-a52b3b1815e0"), "The address: 628 Corkery Mills, West Dayna, Bhutan", "Cordell94@gmail.com", true, "Cordell", "Halvorson" },
                    { new Guid("8cd4c3c7-e2d3-4473-aa36-52d1aa8a3a2c"), "The address: 502 Casper Freeway, Johanville, Puerto Rico", "Otilia90@gmail.com", false, "Otilia", "Green" },
                    { new Guid("8e78d04f-8085-4584-9d1e-23ec4c1c8bfe"), "The address: 527 Emard Ramp, Dareside, Colombia", "Bennie.Gorczany@yahoo.com", true, "Bennie", "Gorczany" },
                    { new Guid("8fd7ece0-d65b-4e1c-b92d-354fa80c633a"), "The address: 4722 Beatty View, New Andrew, Nepal", "Rita69@yahoo.com", false, "Rita", "Stehr" },
                    { new Guid("90568c68-f32a-429d-a3f2-d57a64d510f0"), "The address: 68225 Hilll Gardens, Binsville, Marshall Islands", "Tyshawn.Gleason@yahoo.com", true, "Tyshawn", "Gleason" },
                    { new Guid("91488e9c-c340-4a09-a5df-46d578966741"), "The address: 14863 Rodriguez Oval, North Ora, Liechtenstein", "Sierra73@gmail.com", true, "Sierra", "Ernser" },
                    { new Guid("92ed03e2-7197-4767-b987-b50c1ad188b4"), "The address: 146 Schaefer Brook, Amiyatown, Cocos (Keeling) Islands", "Morgan.Bayer@yahoo.com", true, "Morgan", "Bayer" },
                    { new Guid("950b48d1-e21b-46cb-b479-07ca0c9255d7"), "The address: 862 Zelma Bridge, Marleyhaven, Iran", "Tamara25@hotmail.com", false, "Tamara", "Stiedemann" },
                    { new Guid("9548f4ad-7dc0-4f3b-b449-65a0838cb673"), "The address: 9146 Jerry Valley, Hartmannfurt, Saint Helena", "Ethel_Armstrong@yahoo.com", true, "Ethel", "Armstrong" },
                    { new Guid("95514ec5-6eac-45c9-a340-75dea1c7695f"), "The address: 550 Powlowski Fork, Heaneyland, Liberia", "Alex.Gulgowski@yahoo.com", false, "Alex", "Gulgowski" },
                    { new Guid("95eff680-028a-431f-8db5-bef2752d2a2c"), "The address: 326 Marianna Vista, Littelshire, Maldives", "Janis13@gmail.com", false, "Janis", "Carter" },
                    { new Guid("96a9702a-fb6d-45b4-a36c-377141fec3e2"), "The address: 9149 Orrin Loaf, Lake Mariah, Cocos (Keeling) Islands", "Marisol92@gmail.com", true, "Marisol", "Hoeger" },
                    { new Guid("993c8327-b902-4c8f-a8fc-b65b22ea425d"), "The address: 3709 Krajcik Parkways, New Lonzofort, Antarctica (the territory South of 60 deg S)", "Jaron11@hotmail.com", true, "Jaron", "Daugherty" },
                    { new Guid("9bdbbe5e-61d1-4100-a6c1-96ad062c179d"), "The address: 763 Nitzsche Mews, Jalynside, Antarctica (the territory South of 60 deg S)", "Nelda.Hudson@yahoo.com", false, "Nelda", "Hudson" },
                    { new Guid("9bfb10f7-5a46-41ff-a465-574158ced91f"), "The address: 76182 Theresia Spring, Georgianaton, Seychelles", "Margarete_Beahan4@hotmail.com", true, "Margarete", "Beahan" },
                    { new Guid("a0bebdff-3dce-4b8b-b66e-e7375927ca2c"), "The address: 204 Gregorio Centers, Kosston, Ethiopia", "Enoch71@yahoo.com", true, "Enoch", "Pollich" },
                    { new Guid("a0cf1958-6b82-47cb-aca9-49f9dbe6da77"), "The address: 482 Abernathy Neck, Cobyburgh, Albania", "Dino.Crist@yahoo.com", false, "Dino", "Crist" },
                    { new Guid("a1209db0-3aae-4123-ae46-7450420fd136"), "The address: 66300 Denis Gardens, Jamisonfurt, Iraq", "Alexandre_Skiles23@hotmail.com", true, "Alexandre", "Skiles" },
                    { new Guid("a28a28a6-7783-4265-949f-b0437f00615d"), "The address: 28219 Hauck Causeway, Paulatown, Croatia", "Dewayne5@gmail.com", false, "Dewayne", "Leuschke" },
                    { new Guid("a8a84041-4148-4bff-a2fa-6e8ed8ef73bd"), "The address: 66074 Bailey Inlet, Dallinport, Pakistan", "Joyce12@gmail.com", false, "Joyce", "Douglas" },
                    { new Guid("a9a936a1-a87d-4aae-98c3-e39884784161"), "The address: 6389 Kaelyn Trail, Samantamouth, Bahrain", "Ellie_Walter@gmail.com", false, "Ellie", "Walter" },
                    { new Guid("ac9b1803-f789-4bba-8ade-66cf62191ff3"), "The address: 6545 Beth Crossing, South Lionelchester, Morocco", "Matt.Kiehn@gmail.com", true, "Matt", "Kiehn" },
                    { new Guid("aeccd29e-a493-4d9b-a3c6-21053fd3f9a8"), "The address: 9226 Stark Stravenue, Port Tierra, British Indian Ocean Territory (Chagos Archipelago)", "Rosie_Kirlin@yahoo.com", true, "Rosie", "Kirlin" },
                    { new Guid("aed6c6eb-05b3-417f-9675-cc7035590569"), "The address: 2728 Leannon Passage, North Justina, Ukraine", "Laurie.Prosacco@yahoo.com", true, "Laurie", "Prosacco" },
                    { new Guid("b18a63af-e07f-4406-bc28-6ced50da67de"), "The address: 0822 Sammie Valley, Luettgenfort, Ukraine", "Arno_Orn@gmail.com", true, "Arno", "Orn" },
                    { new Guid("b29a6eee-c316-46bf-b2c9-4e521554b08b"), "The address: 13849 Ezequiel Tunnel, Port Orland, Netherlands Antilles", "Abbey.Carter30@yahoo.com", true, "Abbey", "Carter" },
                    { new Guid("b2d87fd0-6e53-421f-8d6f-1f4c5cbd786c"), "The address: 495 Rory Village, New Wendellshire, Philippines", "Morgan81@hotmail.com", false, "Morgan", "Bernier" },
                    { new Guid("b39605a4-8057-46d3-975b-2c79d1e7ea06"), "The address: 49075 Parisian Port, North Kaliburgh, Aruba", "Travon.Hills@hotmail.com", true, "Travon", "Hills" },
                    { new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c"), "The address: 74099 Howell Gardens, South Danikafort, Burkina Faso", "Edgardo_Fay@gmail.com", false, "Edgardo", "Fay" },
                    { new Guid("b52d3ce3-9aa7-4a23-9236-14f1179dd645"), "The address: 138 Devan Track, Lake Jenningsfurt, Togo", "Ashtyn81@hotmail.com", false, "Ashtyn", "Bayer" },
                    { new Guid("b589a934-628a-45fb-813e-e75938a11641"), "The address: 4544 Reichel Lodge, Heloisestad, Slovenia", "Destiney91@yahoo.com", true, "Destiney", "Okuneva" },
                    { new Guid("b730576a-5145-474a-9539-4254a2a938fb"), "The address: 716 Buckridge Shores, New Fidelville, Malta", "Eulah_Tillman67@gmail.com", false, "Eulah", "Tillman" },
                    { new Guid("b8db88d0-b2aa-4f6b-9ac8-5011f7afc548"), "The address: 423 Alejandrin Fort, West Chaneltown, Macedonia", "Selina_Berge@hotmail.com", true, "Selina", "Berge" },
                    { new Guid("b9b4b1fd-0312-413f-b8ea-5bbf54fa844f"), "The address: 6459 Michel Fords, Clementinaside, Kuwait", "Darrick87@hotmail.com", false, "Darrick", "Hane" },
                    { new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0"), "The address: 11259 Mueller Groves, North Rossie, Central African Republic", "Marcelle52@gmail.com", true, "Marcelle", "Parker" },
                    { new Guid("c39a4212-ddb9-497d-bd59-03788900ad2b"), "The address: 8760 Durgan Lock, South Kaci, Timor-Leste", "Domenico_Smith54@gmail.com", false, "Domenico", "Smith" },
                    { new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a"), "The address: 6728 Harvey Highway, Chetburgh, French Polynesia", "Terence_Baumbach@gmail.com", false, "Terence", "Baumbach" },
                    { new Guid("c6cac74f-61ce-46f1-8519-2c920c3c7854"), "The address: 35976 Jaime Run, Gideonberg, Liechtenstein", "Eda_Ernser74@yahoo.com", false, "Eda", "Ernser" },
                    { new Guid("ca0ae93b-5168-4b28-bdef-df3ae8ad24a1"), "The address: 2341 Swaniawski Fork, Jaceymouth, Uzbekistan", "Wendell_Watsica9@yahoo.com", true, "Wendell", "Watsica" },
                    { new Guid("cda28c2f-338d-4dc0-9c5c-049f6929b4e6"), "The address: 649 Reba Loop, West Clarissa, Dominican Republic", "Peter15@gmail.com", true, "Peter", "Wiza" },
                    { new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da"), "The address: 97369 Hermann Common, West Jamal, Tuvalu", "Makenzie_Hickle@gmail.com", false, "Makenzie", "Hickle" },
                    { new Guid("d2d70fb2-ca50-4d2b-bf27-57824ac87347"), "The address: 2504 Klein Junctions, Lake Tess, Lithuania", "Anissa33@gmail.com", true, "Anissa", "Murray" },
                    { new Guid("d453349a-cf15-45a7-ac65-50c83b5b20ef"), "The address: 72590 Boyer Ways, Alexanneshire, Svalbard & Jan Mayen Islands", "Vance_OKon43@yahoo.com", false, "Vance", "O'Kon" },
                    { new Guid("d78ae6ce-ecfd-4bb6-a6da-431d4169e6e4"), "The address: 387 Will Greens, East Bartholomeberg, Saint Barthelemy", "Nathen_Pfeffer@yahoo.com", false, "Nathen", "Pfeffer" },
                    { new Guid("d9297d5c-74f9-4326-8753-06611ccb364b"), "The address: 185 Brannon Wall, Wisozkmouth, Heard Island and McDonald Islands", "Lenore_Fay12@gmail.com", false, "Lenore", "Fay" },
                    { new Guid("d9a98cef-b581-4017-9172-b8bd03707337"), "The address: 3189 Neil Islands, Ullrichhaven, New Zealand", "Princess_Thompson98@hotmail.com", false, "Princess", "Thompson" },
                    { new Guid("da3d6f5b-c8a4-4310-b684-86061fc826b3"), "The address: 2229 Boyd Neck, Graciebury, Guadeloupe", "Piper.Schoen36@gmail.com", false, "Piper", "Schoen" },
                    { new Guid("db633c4e-1db7-4da2-9b8f-8b9bb0fb2d3f"), "The address: 24742 Treutel Manors, North Bridget, Antigua and Barbuda", "Solon44@gmail.com", false, "Solon", "Bode" },
                    { new Guid("dc2fe4eb-9a75-40d7-925c-3730e81acbd8"), "The address: 93633 Kunze Road, Steubertown, Macao", "Patricia39@yahoo.com", false, "Patricia", "Schneider" },
                    { new Guid("dca46baf-b1d4-4300-99ed-a77c6992bb67"), "The address: 161 Kilback Summit, Zboncakfurt, Gibraltar", "Donnell_Volkman38@yahoo.com", true, "Donnell", "Volkman" },
                    { new Guid("dca75398-c29e-48c8-88cc-87770163b4f8"), "The address: 337 Ivah Ville, Dooleyport, Pakistan", "Angie50@gmail.com", true, "Angie", "Parisian" },
                    { new Guid("dd0339d4-4fd5-4ff8-8778-51e3939084bc"), "The address: 181 Braulio Meadows, Port Micah, Estonia", "Mellie39@gmail.com", false, "Mellie", "Yost" },
                    { new Guid("de2bfbf4-5c54-4f9f-98a4-0d99bed2725e"), "The address: 114 Labadie Court, Zettachester, Afghanistan", "Pasquale_Hane57@hotmail.com", false, "Pasquale", "Hane" },
                    { new Guid("de6bd080-74fa-4b79-946e-37c0cca85171"), "The address: 93877 Fadel Curve, New Maurice, Rwanda", "Yessenia.Quigley61@yahoo.com", false, "Yessenia", "Quigley" },
                    { new Guid("e0263431-c820-4c52-b3f5-5a7e70f3eca7"), "The address: 587 Johnnie Forest, Jettfurt, Indonesia", "Cesar_Swaniawski28@hotmail.com", true, "Cesar", "Swaniawski" },
                    { new Guid("e0be58e2-d7d1-46aa-a9e4-42dbcfc7053c"), "The address: 43925 Larkin Circles, Binston, Burkina Faso", "Donnie.Heller79@yahoo.com", true, "Donnie", "Heller" },
                    { new Guid("e145a512-f2b4-47cb-8dbb-bd036534b0e3"), "The address: 42407 Mason Lodge, Kohlerside, Iran", "Claudia.Franecki@gmail.com", false, "Claudia", "Franecki" },
                    { new Guid("e5888cb2-cc6a-428e-bc51-34d71518af07"), "The address: 97522 Stephen Parkway, Lebsackhaven, Japan", "Issac.Collier82@yahoo.com", false, "Issac", "Collier" },
                    { new Guid("e6648517-0d32-4624-a7ec-6731d6b806b1"), "The address: 54354 Zula Oval, Erdmanchester, Martinique", "Dane36@gmail.com", true, "Dane", "Wiza" },
                    { new Guid("e66d8c0d-fbc4-4e16-b53f-68ac990d86bc"), "The address: 472 Hollie Divide, Cronastad, Bhutan", "Tracy_Price3@yahoo.com", false, "Tracy", "Price" },
                    { new Guid("ea4481aa-7f8b-4f4b-933e-ea3d8bff524b"), "The address: 2463 Evan Island, Rueckerborough, Spain", "Karina44@yahoo.com", true, "Karina", "Champlin" },
                    { new Guid("ea990230-ebd9-4035-b5cc-7689c339ea2e"), "The address: 440 Hansen Avenue, Jacobsonport, Cape Verde", "Emanuel_Torp99@hotmail.com", false, "Emanuel", "Torp" },
                    { new Guid("ee88c0b5-841c-4e6e-82b7-b549b5765d45"), "The address: 093 Libbie Lakes, East Dedricfort, Northern Mariana Islands", "Alex4@hotmail.com", false, "Alex", "Cartwright" },
                    { new Guid("ee952a2e-d590-47c4-b520-e4d5f12c1b46"), "The address: 52707 Lindgren Ridge, New Larissa, El Salvador", "Ricardo_Bailey62@hotmail.com", true, "Ricardo", "Bailey" },
                    { new Guid("f083cb79-831c-4d55-acc4-ce122564dcd2"), "The address: 141 Kenna Squares, Crystalside, Liechtenstein", "Yolanda.Murray@yahoo.com", true, "Yolanda", "Murray" },
                    { new Guid("f1aa4a6b-05a6-4a5f-926e-3ede3ded1935"), "The address: 7239 Kamren Light, Ashlynnshire, South Georgia and the South Sandwich Islands", "Flavie_Boyer@yahoo.com", false, "Flavie", "Boyer" },
                    { new Guid("f1b30695-15ce-4944-99cf-1b4b6f437667"), "The address: 7307 Stark Valleys, Florianburgh, Bulgaria", "Nolan45@gmail.com", true, "Nolan", "Kuhic" },
                    { new Guid("f237bc17-bb36-4d96-9444-eefa69d519d2"), "The address: 83572 Nader Pass, Lake Cyriltown, Saint Vincent and the Grenadines", "Brant.Yundt55@yahoo.com", true, "Brant", "Yundt" },
                    { new Guid("f411932a-7302-4042-a48e-a2aa76d87f81"), "The address: 856 Rogahn Stravenue, Port Garryburgh, Gabon", "Mattie_Christiansen42@gmail.com", true, "Mattie", "Christiansen" },
                    { new Guid("f48032f1-313e-4492-b7e5-6fddb3085109"), "The address: 86231 Armstrong Shoals, West Queen, Ghana", "Lukas.Morissette@gmail.com", true, "Lukas", "Morissette" },
                    { new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856"), "The address: 3698 Wendell Dam, Port Rebekahport, Gabon", "Jasper.Jakubowski@gmail.com", false, "Jasper", "Jakubowski" },
                    { new Guid("f6abc171-8892-4a6d-8c8e-b65d695ea322"), "The address: 3812 Kohler Manor, Schroederhaven, Vietnam", "Sherman_Rau86@gmail.com", true, "Sherman", "Rau" },
                    { new Guid("f850772c-69f3-4df5-ac20-20de8872499a"), "The address: 824 Carlotta Falls, Lake Ethan, French Polynesia", "Coy0@yahoo.com", false, "Coy", "Kuphal" },
                    { new Guid("fa24756e-9fd9-4a83-854f-6d87b77d2a92"), "The address: 5524 Price Coves, South Cathrinemouth, Central African Republic", "Benedict_Torp60@gmail.com", true, "Benedict", "Torp" },
                    { new Guid("fbf90cc0-3d57-4714-acb4-e4d94442f049"), "The address: 13937 Koch Terrace, Warrenstad, Equatorial Guinea", "Jeanne.Koss39@yahoo.com", false, "Jeanne", "Koss" },
                    { new Guid("fe37ab27-21ef-4995-94eb-dc17b46e8669"), "The address: 2457 Lang Parkways, Lake Edwin, Puerto Rico", "Eda_Cronin16@hotmail.com", false, "Eda", "Cronin" }
                });

            migrationBuilder.InsertData(
                table: "Diagnoses",
                columns: new[] { "ID", "Comments", "Diagnoses_title", "Patiens_ID" },
                values: new object[,]
                {
                    { new Guid("032df801-14bb-4141-950c-829cbba38668"), "Cupiditate suscipit voluptatem laudantium placeat ex sed.", "Keyboard", new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853") },
                    { new Guid("038c8a12-2148-4fdd-b3f6-a1115ab939e9"), "Earum minus molestiae autem sequi eum tempore molestiae quae consequatur.", "Pizza", new Guid("511b2e18-efc3-44c7-9819-ab389144f943") },
                    { new Guid("04afdbbc-9354-4807-a56f-5c470040c34e"), "Quis molestias veniam hic sed illo nihil aut qui.", "Ball", new Guid("09bfad34-85cf-49ff-a63e-a03e11b4032d") },
                    { new Guid("073c3c75-976a-4962-91e7-382d880e0c01"), "Neque vitae et id tenetur ut quia.", "Mouse", new Guid("762411cc-845f-4172-8c18-161a49f5d9c8") },
                    { new Guid("135d45f2-5906-42f3-9718-bdac299340c7"), "Vel minus mollitia quae omnis aut voluptatibus dolorum et.", "Computer", new Guid("634f3997-7f5c-49dc-a4ef-e4072fcc8f56") },
                    { new Guid("14ea0121-dd47-4740-bd05-d99926361518"), "Molestias dolores occaecati in.", "Pants", new Guid("7c994242-8c36-4776-84cd-ca241ca48dd2") },
                    { new Guid("1ae9eff5-d91f-4ebd-89a8-2454157af236"), "Blanditiis eos consectetur qui unde natus ut autem eum.", "Cheese", new Guid("f237bc17-bb36-4d96-9444-eefa69d519d2") },
                    { new Guid("1cce0f51-4036-4c4e-8b34-a51dfa054bf4"), "Ea magni accusantium animi quia doloribus suscipit et.", "Chicken", new Guid("28256e0b-cfe6-48ea-a034-8896358289ff") },
                    { new Guid("219e5585-90c3-4d69-9679-2576569663c0"), "Eveniet hic et ex.", "Tuna", new Guid("993c8327-b902-4c8f-a8fc-b65b22ea425d") },
                    { new Guid("271413b9-03ac-4128-b602-5063f5d5bb2d"), "Recusandae earum quisquam voluptatem tempore mollitia dolores deleniti.", "Car", new Guid("92ed03e2-7197-4767-b987-b50c1ad188b4") },
                    { new Guid("32d1ae9a-2d5c-4c00-b091-7e7f1dc785af"), "Quo rerum non saepe doloremque harum mollitia quia.", "Bacon", new Guid("9bfb10f7-5a46-41ff-a465-574158ced91f") },
                    { new Guid("33b871ba-1eec-445f-a219-9c8474a25ad0"), "Consequuntur dolorum expedita vel ut nihil explicabo debitis et at.", "Car", new Guid("71dab545-e32d-40a7-ad88-cf613e24af80") },
                    { new Guid("34363072-fb88-4d6e-9b26-b48b4d5401de"), "Dolorum quia placeat.", "Chips", new Guid("0d928f2a-4c26-4382-96b5-2636b3b0698d") },
                    { new Guid("462afcea-ddbc-4e82-a88b-76208809204b"), "Ex consequatur possimus.", "Fish", new Guid("854e328c-d95a-44af-8ede-110adde91323") },
                    { new Guid("48c1cb7b-585a-4cf5-927c-57f694149733"), "Tempora laboriosam qui.", "Bacon", new Guid("7e4dd588-b35e-4477-848f-75b082e57c25") },
                    { new Guid("4ae2ec2a-0638-49c8-bafb-965c55726a2a"), "Accusamus temporibus sequi blanditiis fuga labore.", "Chair", new Guid("42504898-86e2-4510-a02a-8063eb338b8a") },
                    { new Guid("57fea372-da42-4cf7-b375-ed57548baf43"), "Dignissimos est repellat maiores quia neque reiciendis provident sed et.", "Ball", new Guid("64ef5204-68fa-4f85-81b3-89fdfb01a6c1") },
                    { new Guid("58c8ee74-7e7e-454c-a292-8a10bed23b8b"), "Occaecati occaecati est temporibus ipsam et fugiat.", "Chips", new Guid("b2d87fd0-6e53-421f-8d6f-1f4c5cbd786c") },
                    { new Guid("5c28bc97-6e26-4b2a-a9c4-0e8cef879db0"), "Illum aut sint excepturi tempore eligendi libero cumque optio.", "Keyboard", new Guid("45732846-cb07-42d6-8bb9-72a9e28dcea0") },
                    { new Guid("5c658c5e-ffa6-4836-899e-7bf4e3f8d04c"), "Exercitationem aliquid et quaerat rem rerum eligendi a.", "Tuna", new Guid("d78ae6ce-ecfd-4bb6-a6da-431d4169e6e4") },
                    { new Guid("66d8313b-f515-4538-95a0-53d9036d23f1"), "Est blanditiis ex inventore ipsa.", "Mouse", new Guid("2bfc3e7c-f045-413f-95f9-f9375a338435") },
                    { new Guid("6e3b5df4-22fa-441b-b42d-b320f20e146d"), "Est est rerum sint nemo rerum.", "Tuna", new Guid("aed6c6eb-05b3-417f-9675-cc7035590569") },
                    { new Guid("70e7779e-eb41-493c-9dde-bb7d75fcf53c"), "Ut fugit quo vel debitis odit aut.", "Gloves", new Guid("8352a3b5-4933-49f6-904e-be1daf133d75") },
                    { new Guid("76209ca7-9f2a-4cbf-a90e-18d5632b74ba"), "Fugit distinctio qui consequatur vel ratione magnam.", "Mouse", new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7") },
                    { new Guid("801c704b-ab07-4c9b-9f17-a3b68d0f1f60"), "Iusto animi ducimus quod qui.", "Gloves", new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a") },
                    { new Guid("81446e2e-1fac-4100-bc92-1b21d1729809"), "Nostrum magni suscipit voluptates eos distinctio.", "Computer", new Guid("0bfcf543-3355-4715-b2ad-17fba1d5a263") },
                    { new Guid("8321cec2-b23f-42bc-be3e-b1bdcae86cd5"), "Dolorem omnis praesentium dolorum et nobis provident qui.", "Pizza", new Guid("e0263431-c820-4c52-b3f5-5a7e70f3eca7") },
                    { new Guid("8a7dc554-8bec-40b0-aee6-c4a62c82b316"), "A dolor magni pariatur qui.", "Tuna", new Guid("da3d6f5b-c8a4-4310-b684-86061fc826b3") },
                    { new Guid("8c58a4e7-c107-4f4d-81c7-bad323b37083"), "Eius nulla ut praesentium error qui.", "Shoes", new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0") },
                    { new Guid("8d65d850-2d75-417a-b739-b6728f5a5c5d"), "Consequuntur accusamus at amet assumenda.", "Shirt", new Guid("0ecd8487-f43a-46f8-a409-14934fe06ce0") },
                    { new Guid("8d889b62-1ec8-4548-80ba-68b1e45c4f1c"), "Quam est quia quos quos vel numquam enim cum.", "Shoes", new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4") },
                    { new Guid("92b347f1-499b-4dfd-ade3-27ab2998db30"), "Commodi commodi suscipit ut nihil.", "Pants", new Guid("b39605a4-8057-46d3-975b-2c79d1e7ea06") },
                    { new Guid("92e43f70-2910-495b-a20a-47eaa79ce9c3"), "Sunt veniam voluptatibus sit voluptas mollitia placeat nam in.", "Gloves", new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059") },
                    { new Guid("992699ad-fd40-49ce-8339-914cb1708c02"), "Cumque amet debitis consequatur neque aperiam omnis atque accusantium eveniet.", "Salad", new Guid("e0be58e2-d7d1-46aa-a9e4-42dbcfc7053c") },
                    { new Guid("9ae21dae-c898-4457-a72a-9877f630bd91"), "Qui dignissimos maiores.", "Pizza", new Guid("5c9b1c64-1c30-4013-9183-5a9e970b6349") },
                    { new Guid("a2569140-495a-43ac-9f60-5459d7a114e2"), "Qui qui vero vel ipsam eius hic.", "Soap", new Guid("6a2e13be-4a7e-4475-ade9-837eb81690d3") },
                    { new Guid("aa1c4468-fee6-46d8-8ddd-9f3a43a12074"), "Et tempora sint facere culpa quam eligendi accusantium.", "Pants", new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7") },
                    { new Guid("ab26f02a-8b07-4cb8-8ef8-b6a304f761cc"), "Aliquid atque unde facere nobis quo ullam.", "Gloves", new Guid("de6bd080-74fa-4b79-946e-37c0cca85171") },
                    { new Guid("aeb3f881-21b3-4f31-bf6a-d0d68b8d0da2"), "Qui dolorem non et quam fugit excepturi ipsum minima accusantium.", "Chair", new Guid("790a3927-f12e-42fe-94e0-2d22da9e5bd5") },
                    { new Guid("c47825b5-8685-4c12-901e-92723d63118f"), "Est ullam aliquid incidunt.", "Pizza", new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735") },
                    { new Guid("c5019ec4-c3fd-43ad-9eb2-2de1c7a15a7f"), "Possimus aut rerum et culpa non architecto enim aut non.", "Mouse", new Guid("051a2363-9054-4dc3-a108-f8c845bdeba7") },
                    { new Guid("cd27a9b1-ea48-4604-8f80-ad00cdaef003"), "Nemo rem error alias hic.", "Pizza", new Guid("a8a84041-4148-4bff-a2fa-6e8ed8ef73bd") },
                    { new Guid("d8821b00-1dd3-465d-bdd5-53733a5a56ac"), "Assumenda reiciendis fugiat corporis est odio eius.", "Chips", new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735") },
                    { new Guid("d8ccab85-7c46-47bf-910b-207b164c6ff5"), "Consequatur excepturi voluptatem reiciendis libero id enim.", "Pants", new Guid("e5888cb2-cc6a-428e-bc51-34d71518af07") },
                    { new Guid("ded3b4b2-42e6-4693-9a9f-c64b584760fb"), "Qui illo laborum nihil dolorum dolorem inventore voluptas.", "Hat", new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115") },
                    { new Guid("e6f5530a-ae89-48cf-9ea7-0a7bb413954c"), "Quibusdam voluptatum in voluptatum sint ut beatae sint autem.", "Shirt", new Guid("1f53d9fa-a550-4086-ba2e-911a1853be0e") },
                    { new Guid("eafc0ecf-3ebf-48c7-9776-f96604b88d0b"), "Nostrum dolor ut.", "Sausages", new Guid("24e31d9e-ce06-4f29-b99e-3f80664a0fa4") },
                    { new Guid("edfdd9fc-94e1-4d00-b9ad-870f5249c387"), "Sit atque et omnis eum.", "Bacon", new Guid("26029586-c8d2-4f17-84c5-6796078b420c") },
                    { new Guid("f14d46b7-9c31-4e4f-a60f-4a8d4cb6d569"), "Aliquam vero vero velit velit beatae aspernatur non.", "Ball", new Guid("d2d70fb2-ca50-4d2b-bf27-57824ac87347") },
                    { new Guid("f4342d08-9234-4605-be69-d989183cc623"), "Iusto enim reprehenderit architecto voluptatum et facilis autem commodi.", "Chair", new Guid("96a9702a-fb6d-45b4-a36c-377141fec3e2") }
                });

            migrationBuilder.InsertData(
                table: "Prescription_Medicaments",
                columns: new[] { "ID", "Medicaments_ID", "Patients_ID" },
                values: new object[,]
                {
                    { new Guid("03422d88-888c-4a15-af65-68e90a2cd5bf"), new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"), new Guid("0d928f2a-4c26-4382-96b5-2636b3b0698d") },
                    { new Guid("061a00f7-92a1-466e-85ae-45a00d909598"), new Guid("af8ca68f-a655-4131-a595-cc0547f29d90"), new Guid("3e97e0a4-cdf4-4a5b-9698-6420a9dd6770") },
                    { new Guid("06629a1f-44c0-48aa-be5a-ac3026e020ee"), new Guid("d25e56ba-97b2-479a-8f4f-b7e8e33e6b21"), new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e") },
                    { new Guid("07539dd5-98f8-4be0-bfeb-05cc79f62fb7"), new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"), new Guid("dca75398-c29e-48c8-88cc-87770163b4f8") },
                    { new Guid("106869a8-341e-49c7-8d26-3a2e1a13ef0b"), new Guid("e9ef7615-81b6-493d-8fed-fa9e1f2fa954"), new Guid("5f3e9730-5372-4711-a812-d467b1cb144b") },
                    { new Guid("1281d807-10d7-419b-8a26-1d84af1e5107"), new Guid("84fe8e37-472a-4723-9597-91a49edcda31"), new Guid("359f3c6a-d30b-4cfe-ade5-f0cd78f9dc52") },
                    { new Guid("12af909f-7a48-440a-9e1f-aadc2d86d0cc"), new Guid("24c88ec7-6fa0-45ad-93da-1808ccbf6d97"), new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c") },
                    { new Guid("158cae2b-b415-4343-bb6e-3e30e2f9e4ea"), new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"), new Guid("213c336a-4f3a-4d1a-8161-11baf29cfa42") },
                    { new Guid("18c45d5d-8219-4cb2-a192-8ab8c8c67f11"), new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"), new Guid("e0263431-c820-4c52-b3f5-5a7e70f3eca7") },
                    { new Guid("1d158a2f-93bd-4366-b55d-beba7832fd72"), new Guid("0658d7a5-3a63-4fd8-92be-78323d48333d"), new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735") },
                    { new Guid("21391265-55e6-4edc-957b-49851c9301dc"), new Guid("76decd0d-3630-4aad-9447-2d33d90c7332"), new Guid("9bdbbe5e-61d1-4100-a6c1-96ad062c179d") },
                    { new Guid("21e28521-2b67-4ed7-928d-0282c2e574a1"), new Guid("84030ce3-295a-4a5d-ac29-9bfb534e050f"), new Guid("dc2fe4eb-9a75-40d7-925c-3730e81acbd8") },
                    { new Guid("2404804d-9fbe-4841-816c-c2cd3229803a"), new Guid("0658d7a5-3a63-4fd8-92be-78323d48333d"), new Guid("b39605a4-8057-46d3-975b-2c79d1e7ea06") },
                    { new Guid("292b8ac1-a805-40a9-ab8d-ddee1553e55d"), new Guid("afe1843b-2134-4ea4-b4b7-d86e0b124f1c"), new Guid("b39605a4-8057-46d3-975b-2c79d1e7ea06") },
                    { new Guid("2a46de9b-a67b-400d-aa2b-9ee6ef9309cf"), new Guid("0881bac1-bd97-47fe-829e-7095f66d69a0"), new Guid("92ed03e2-7197-4767-b987-b50c1ad188b4") },
                    { new Guid("30614bac-a386-437b-bb2c-147cb4a71f78"), new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"), new Guid("5ab15f1c-3352-40e6-918d-51d69903dba4") },
                    { new Guid("30b5c875-b7cd-4e77-a4df-cbd73932da85"), new Guid("ef55a6f8-7722-4af0-952c-5eb2138ed3da"), new Guid("8fd7ece0-d65b-4e1c-b92d-354fa80c633a") },
                    { new Guid("33a82393-9319-42aa-8276-a51c664ec80a"), new Guid("d675cbbb-eda1-4088-890c-0dec83e55736"), new Guid("de2bfbf4-5c54-4f9f-98a4-0d99bed2725e") },
                    { new Guid("3413c032-be66-4186-b42e-2dfdeab5dc76"), new Guid("5f569f58-320b-4570-9fbf-94d93bc1ecc2"), new Guid("7a0a4358-5130-49f3-badf-b4bbeed382cf") },
                    { new Guid("3574d4c9-2983-474b-9f6a-363e74cbe8e9"), new Guid("1ceb9127-2c3e-475a-b5cf-501b94dd7808"), new Guid("f1aa4a6b-05a6-4a5f-926e-3ede3ded1935") },
                    { new Guid("3680c1b1-8fbd-4250-9e01-23594cc90a63"), new Guid("0d13452b-8b26-4560-b6ed-dd635136e782"), new Guid("2012c563-324f-4db6-a478-dff4c8379690") },
                    { new Guid("37d1fd78-ab39-4dc2-ab21-5bbf98ae67c1"), new Guid("ee918af8-48f6-4d2e-914d-515db1ffa9ab"), new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c") },
                    { new Guid("3839a80b-a010-4238-a21b-da7b62df2e3f"), new Guid("e85ccb66-2736-4ef8-a340-388e5c2ad622"), new Guid("92ed03e2-7197-4767-b987-b50c1ad188b4") },
                    { new Guid("3885b979-bf50-490e-a196-062b81b6be21"), new Guid("6dfa833d-fa98-4c38-9e09-a6f8483cb1a4"), new Guid("8352a3b5-4933-49f6-904e-be1daf133d75") },
                    { new Guid("38be90de-9c70-4152-b21c-07d9de385342"), new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"), new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0") },
                    { new Guid("3f1eb1aa-9d57-4b40-a287-5e6455095192"), new Guid("e2f0386b-b9bd-4866-8910-bf797a2c415f"), new Guid("d9a98cef-b581-4017-9172-b8bd03707337") },
                    { new Guid("3f53c39f-cfea-484b-9578-3d977cdad194"), new Guid("066ccb51-2c1a-45c9-8c26-071594ddeb98"), new Guid("dca75398-c29e-48c8-88cc-87770163b4f8") },
                    { new Guid("4043d876-2605-49b0-86e2-6cb29a010ee6"), new Guid("ef55a6f8-7722-4af0-952c-5eb2138ed3da"), new Guid("0894e3c6-bf19-4294-a7a6-44fabb7e53e4") },
                    { new Guid("417c9186-2d38-4cb2-a76f-ceb6b6cbb858"), new Guid("9803a13c-cb55-442d-9bfa-e674ea87fe22"), new Guid("11b875d5-8031-4662-af6f-81a9459c0537") },
                    { new Guid("43156cc8-337f-4d3f-b063-808680306213"), new Guid("d33664d4-f683-43a6-80b3-76212979e328"), new Guid("d453349a-cf15-45a7-ac65-50c83b5b20ef") },
                    { new Guid("454ffe1e-8abb-4967-84cd-29941ee11506"), new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), new Guid("ee952a2e-d590-47c4-b520-e4d5f12c1b46") },
                    { new Guid("45eb45b7-c9d5-477c-ac0a-a5f1a07d36f5"), new Guid("e2e6abfa-fdd6-420f-b99a-1d328a964cbe"), new Guid("26029586-c8d2-4f17-84c5-6796078b420c") },
                    { new Guid("482d4578-1629-4b49-a11f-7f27a548f823"), new Guid("30a8ad38-d4c7-4ba2-8402-a00288e951a6"), new Guid("0c166491-4c73-4064-93da-08284afda695") },
                    { new Guid("4bfa2ba1-2e64-46b3-9573-575a3f40d5ee"), new Guid("6dba3389-2057-439d-b5ea-81975c772a44"), new Guid("0dc2a631-4457-41f7-921d-a4444d635166") },
                    { new Guid("4d1e3156-3572-42dd-8f25-8f8b57e0966a"), new Guid("c11ba176-fd9a-4d60-8f60-74f1e5bbb62a"), new Guid("d453349a-cf15-45a7-ac65-50c83b5b20ef") },
                    { new Guid("5259830d-30ba-4d0d-9a54-8376193afc46"), new Guid("ec5604b0-1a8b-4480-9692-c6b726a35bdd"), new Guid("3c8d81ec-c16e-4473-ac68-c9100b222485") },
                    { new Guid("52b99ef7-4282-4a6c-b9c6-53e84bf1b562"), new Guid("afe1843b-2134-4ea4-b4b7-d86e0b124f1c"), new Guid("a8a84041-4148-4bff-a2fa-6e8ed8ef73bd") },
                    { new Guid("53547d22-de3c-4d73-a334-cce9208d1d9d"), new Guid("2745251c-46d2-4bf5-a84e-04768802d37b"), new Guid("d453349a-cf15-45a7-ac65-50c83b5b20ef") },
                    { new Guid("5bbbbe97-1e2f-449c-979d-ed85ef9996e2"), new Guid("0658d7a5-3a63-4fd8-92be-78323d48333d"), new Guid("de6bd080-74fa-4b79-946e-37c0cca85171") },
                    { new Guid("5bd5e210-1260-44bd-a9ba-56e315aaf8fe"), new Guid("e2a46cc9-0ae1-44b5-a9d4-2be26bf87e32"), new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c") },
                    { new Guid("647370bb-3cee-4245-8b75-bdb1e1d256cc"), new Guid("ee918af8-48f6-4d2e-914d-515db1ffa9ab"), new Guid("8352a3b5-4933-49f6-904e-be1daf133d75") },
                    { new Guid("6b58d645-3bd1-4fe4-95b6-da1bac2d05f4"), new Guid("5f569f58-320b-4570-9fbf-94d93bc1ecc2"), new Guid("f083cb79-831c-4d55-acc4-ce122564dcd2") },
                    { new Guid("6baa04d5-ab46-4ce9-a54f-b00f3be5629d"), new Guid("9e4d2b80-29f9-437b-b3b1-b676bccf615f"), new Guid("554194df-5afa-4232-b461-132182c64a1b") },
                    { new Guid("7078c94a-3564-498a-8d0f-8ab58739ac92"), new Guid("37224f72-08a6-4559-ab12-4a572529325f"), new Guid("55e0e6e5-eae4-454a-9457-7d1baedde998") },
                    { new Guid("70f3ef3b-0ee1-43fc-b15f-036ddd1789d3"), new Guid("7758402a-2259-438f-af10-2c5262d1b0f8"), new Guid("f48032f1-313e-4492-b7e5-6fddb3085109") },
                    { new Guid("720b22b7-14bb-41c5-b1fd-6f90c141afbb"), new Guid("066ccb51-2c1a-45c9-8c26-071594ddeb98"), new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735") },
                    { new Guid("728050e7-f85c-4a98-88ba-ded3a37f54d6"), new Guid("ddc28224-bb14-4eec-9337-5da6fafe0b74"), new Guid("c39a4212-ddb9-497d-bd59-03788900ad2b") },
                    { new Guid("78b8bdbf-78fa-4362-a63c-7227386fc808"), new Guid("8a49ab12-0b03-4555-aca3-fda84cc9b9e6"), new Guid("056e56a8-3da8-4472-b7f9-095c23d71833") },
                    { new Guid("79b491f7-9e0c-4882-a688-43833629292b"), new Guid("40335856-0f38-4a7f-9f5c-1435215356af"), new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853") },
                    { new Guid("87eefa48-ac2c-44db-93d8-b31ae15d6a18"), new Guid("d33664d4-f683-43a6-80b3-76212979e328"), new Guid("511b2e18-efc3-44c7-9819-ab389144f943") },
                    { new Guid("88693298-91c6-4253-bbc3-31173033c18e"), new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"), new Guid("cda28c2f-338d-4dc0-9c5c-049f6929b4e6") },
                    { new Guid("8887384c-916a-4feb-b7af-aa9f6ca24857"), new Guid("7758402a-2259-438f-af10-2c5262d1b0f8"), new Guid("71dab545-e32d-40a7-ad88-cf613e24af80") },
                    { new Guid("8a43480e-aa8c-4b4f-8b9e-04970e02f24b"), new Guid("e2f0386b-b9bd-4866-8910-bf797a2c415f"), new Guid("cda28c2f-338d-4dc0-9c5c-049f6929b4e6") },
                    { new Guid("8a8da0aa-cb95-42aa-be80-fbc77819f438"), new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"), new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e") },
                    { new Guid("8c43d504-c4e7-4ec7-9e0f-3743829fc3d1"), new Guid("2f31713c-4650-443e-83fc-26b6add67249"), new Guid("156cc60f-95d4-42bd-a7f0-8bc433dad5a9") },
                    { new Guid("8d014fff-4b35-44c6-b184-88700c40040a"), new Guid("84fe8e37-472a-4723-9597-91a49edcda31"), new Guid("5080ec34-d105-477e-8be1-094862c9e390") },
                    { new Guid("8f884fdc-c77c-46b7-bab0-c965a5340704"), new Guid("ca4c9f80-079c-481d-9c6d-26522267c98f"), new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4") },
                    { new Guid("900d3a1b-84af-49ae-bb8a-1015cdcaee59"), new Guid("280e3441-babb-4956-b625-d126930f6f2d"), new Guid("45732846-cb07-42d6-8bb9-72a9e28dcea0") },
                    { new Guid("9686d2b3-5a41-4e14-8e1e-232f4912f7d1"), new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), new Guid("90568c68-f32a-429d-a3f2-d57a64d510f0") },
                    { new Guid("973da73c-8a58-4e6c-8ac6-6675a91a60d0"), new Guid("e85ccb66-2736-4ef8-a340-388e5c2ad622"), new Guid("f083cb79-831c-4d55-acc4-ce122564dcd2") },
                    { new Guid("975198dc-c6bc-4ab4-9b9e-57079a00f4d8"), new Guid("7b07f4ab-d666-4713-a4b4-53f8175da156"), new Guid("f48032f1-313e-4492-b7e5-6fddb3085109") },
                    { new Guid("9783ec2d-d892-4f13-a255-01d32b06d673"), new Guid("28958a55-393d-4aa1-9eb4-82c91dbfdc56"), new Guid("d9297d5c-74f9-4326-8753-06611ccb364b") },
                    { new Guid("985e70e1-10a7-4fa8-8557-c05929d3858f"), new Guid("44299736-eb6a-4b66-ac86-6c5932aa334b"), new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684") },
                    { new Guid("9979d187-2ecb-4deb-8e50-75192abdc910"), new Guid("afe1843b-2134-4ea4-b4b7-d86e0b124f1c"), new Guid("a0cf1958-6b82-47cb-aca9-49f9dbe6da77") },
                    { new Guid("9de1a826-f324-4a87-9dd7-50cb3fffbd79"), new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), new Guid("b8db88d0-b2aa-4f6b-9ac8-5011f7afc548") },
                    { new Guid("9f3c2721-faeb-4309-a9f5-ffa4a95661a8"), new Guid("0d13452b-8b26-4560-b6ed-dd635136e782"), new Guid("8b5e0f4b-9e6f-436b-bc22-2b24960608f0") },
                    { new Guid("a091f9d5-1202-4162-89b5-a464b53fe218"), new Guid("e2a46cc9-0ae1-44b5-a9d4-2be26bf87e32"), new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684") },
                    { new Guid("a69df4bc-9c5f-4814-8828-ea508bbb43eb"), new Guid("9f6db193-a0d7-4bc4-bb04-48dd4a2ef3c6"), new Guid("7821c1ab-2cbe-42b8-a861-4f3840382a16") },
                    { new Guid("aae6a534-1e72-4c34-b16c-88475e8684af"), new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"), new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da") },
                    { new Guid("ad567cd4-0766-494c-a298-09fc56d8ef58"), new Guid("14ac274d-07ae-4ab9-91f0-38ac3ab00d7d"), new Guid("81c14a06-36c0-4b3e-8a34-ae99e5b61e97") },
                    { new Guid("adc87044-8b88-4440-8e9d-023a5314d82c"), new Guid("84030ce3-295a-4a5d-ac29-9bfb534e050f"), new Guid("90568c68-f32a-429d-a3f2-d57a64d510f0") },
                    { new Guid("b5c9d295-7c7f-4d2d-a366-a356fe23603d"), new Guid("d25e56ba-97b2-479a-8f4f-b7e8e33e6b21"), new Guid("aed6c6eb-05b3-417f-9675-cc7035590569") },
                    { new Guid("b77f4bab-9c3c-4fb8-b39f-8ec6a7ac4350"), new Guid("44299736-eb6a-4b66-ac86-6c5932aa334b"), new Guid("81a9284b-7e16-4a66-8182-2e8932483261") },
                    { new Guid("b80160d2-f99c-4766-a903-5ea10d4ac536"), new Guid("9bdef98a-2baf-41bd-8563-9910d59d934d"), new Guid("950b48d1-e21b-46cb-b479-07ca0c9255d7") },
                    { new Guid("b9f30dd9-2b60-4752-a95d-7cf6a925d2ad"), new Guid("14ac274d-07ae-4ab9-91f0-38ac3ab00d7d"), new Guid("f1aa4a6b-05a6-4a5f-926e-3ede3ded1935") },
                    { new Guid("b9f8539e-3d96-443d-8e6c-4cd945a9e846"), new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"), new Guid("45732846-cb07-42d6-8bb9-72a9e28dcea0") },
                    { new Guid("bc9f4642-c249-440a-bd9b-5334849d0bf5"), new Guid("70fd3b60-2faa-459d-88d2-8bfeb89944ff"), new Guid("726b16e7-efd2-439e-af51-c7db5c0767ef") },
                    { new Guid("be524d58-1b95-4070-94a1-2163fffc680a"), new Guid("2f31713c-4650-443e-83fc-26b6add67249"), new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735") },
                    { new Guid("c4e2c23d-618d-4c8d-b328-ada6462618d1"), new Guid("40335856-0f38-4a7f-9f5c-1435215356af"), new Guid("798f293d-6f50-47f3-9a15-88a2945a4ee2") },
                    { new Guid("c6ff4e3a-879e-4fa8-865a-926c8f3c1a19"), new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), new Guid("dc2fe4eb-9a75-40d7-925c-3730e81acbd8") },
                    { new Guid("c972ec18-5da7-44e2-b395-674e5762164e"), new Guid("9e4d2b80-29f9-437b-b3b1-b676bccf615f"), new Guid("13623fcc-d7b4-4fb7-9c48-58b2015c9d82") },
                    { new Guid("cbd232ce-fdf2-46f6-be7c-da1f7672f666"), new Guid("e7163fa2-ec63-4f0c-907f-87abdfa94d9e"), new Guid("f237bc17-bb36-4d96-9444-eefa69d519d2") },
                    { new Guid("cccee2a2-3c52-4b3f-9c0e-9ac4390d7275"), new Guid("7b07f4ab-d666-4713-a4b4-53f8175da156"), new Guid("ca0ae93b-5168-4b28-bdef-df3ae8ad24a1") },
                    { new Guid("cf838f66-ba5f-46ef-8eb1-d2c62665ea8e"), new Guid("1fe87f28-915c-4a61-b3a8-2e110efe4def"), new Guid("ee88c0b5-841c-4e6e-82b7-b549b5765d45") },
                    { new Guid("d1da957b-0344-409e-b754-44632ecf8771"), new Guid("9f6db193-a0d7-4bc4-bb04-48dd4a2ef3c6"), new Guid("0dc2a631-4457-41f7-921d-a4444d635166") },
                    { new Guid("d3b3e4af-6c9e-4bb7-b7e8-3e55cc258587"), new Guid("e1cbdd21-1c98-4444-82ed-799ad66639b3"), new Guid("f850772c-69f3-4df5-ac20-20de8872499a") },
                    { new Guid("d9ecfd88-96c2-4a0d-af9d-331f5dbf78c7"), new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"), new Guid("8352a3b5-4933-49f6-904e-be1daf133d75") },
                    { new Guid("df97429d-db6b-426e-98d5-52c743a9bde4"), new Guid("9b2bd6d3-0da9-45e7-a2dc-f706f0391980"), new Guid("213c336a-4f3a-4d1a-8161-11baf29cfa42") },
                    { new Guid("e613df7f-1675-4b87-a8e8-c339af2fa561"), new Guid("6dba3389-2057-439d-b5ea-81975c772a44"), new Guid("744b7b47-c075-4158-81ba-a8dd8b76c4ee") },
                    { new Guid("eb62ad2a-ef9f-490e-a242-ca845dea58eb"), new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"), new Guid("0894e3c6-bf19-4294-a7a6-44fabb7e53e4") },
                    { new Guid("ec5dbbff-ab8b-4bf5-a243-95ab97e1591a"), new Guid("44299736-eb6a-4b66-ac86-6c5932aa334b"), new Guid("b52d3ce3-9aa7-4a23-9236-14f1179dd645") },
                    { new Guid("f072ec8f-f0c4-433d-aa56-602339d6d2d1"), new Guid("40335856-0f38-4a7f-9f5c-1435215356af"), new Guid("3daad96f-7de7-4964-8065-056fe321eeb0") },
                    { new Guid("f0b3a3db-9cc7-4762-8fa5-876ecf6777d9"), new Guid("37224f72-08a6-4559-ab12-4a572529325f"), new Guid("756247ae-bd2e-4300-a8b9-531f88248ac1") },
                    { new Guid("f1679c79-b854-4b1e-bdfa-a31e03692321"), new Guid("46ef0907-619c-4e9e-9d76-85a57ae262e9"), new Guid("47cff722-e4c4-4f48-9e18-6f88cd6b8f4b") },
                    { new Guid("f293d589-2f97-4a42-a38c-cab28a472643"), new Guid("e9ef7615-81b6-493d-8fed-fa9e1f2fa954"), new Guid("4b763573-b537-4005-ab95-25c0a81a6d33") },
                    { new Guid("f3e2824b-8a63-449a-819a-9ba6f16aafcd"), new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"), new Guid("5c9b1c64-1c30-4013-9183-5a9e970b6349") },
                    { new Guid("fc3e7466-7d19-4679-808e-0dec360eee5d"), new Guid("280e3441-babb-4956-b625-d126930f6f2d"), new Guid("db633c4e-1db7-4da2-9b8f-8b9bb0fb2d3f") },
                    { new Guid("fd014d2b-d188-4ab0-94c0-8218317f66a5"), new Guid("7ca51590-4c1e-4785-88a2-94b87f98b135"), new Guid("3e9143b0-5667-473a-b0de-b65984e02e5b") },
                    { new Guid("ff572f2b-965d-480d-9f1b-4d432a1f6a20"), new Guid("e2a46cc9-0ae1-44b5-a9d4-2be26bf87e32"), new Guid("3c8d81ec-c16e-4473-ac68-c9100b222485") },
                    { new Guid("fff883e4-1443-4bfc-a119-7a5be750c46c"), new Guid("8a49ab12-0b03-4555-aca3-fda84cc9b9e6"), new Guid("fbf90cc0-3d57-4714-acb4-e4d94442f049") }
                });

            migrationBuilder.InsertData(
                table: "Visitations",
                columns: new[] { "ID", "Comments", "Date", "Doctors_ID", "Patients_ID" },
                values: new object[,]
                {
                    { new Guid("00336c5f-13bc-47f5-8ab8-0b541759075d"), "Unde eveniet incidunt corrupti et placeat velit facere.", new DateTime(2024, 1, 7, 8, 5, 54, 768, DateTimeKind.Local).AddTicks(9759), new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"), new Guid("6df27f42-990d-4e8b-b3a8-ce14647b21a1") },
                    { new Guid("02407ae9-9abb-4132-a5d0-52ab45ca4e8f"), "Quo nobis aspernatur ipsa est eveniet ex doloremque id.", new DateTime(2023, 7, 17, 9, 49, 19, 748, DateTimeKind.Local).AddTicks(5973), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("2ee20b64-f6a9-4c36-928e-2b17b18c1415") },
                    { new Guid("03c7a3f9-c1cf-40e6-9c27-3d7f292b4efc"), "Cum minus sed quis eligendi alias sit laboriosam.", new DateTime(2023, 5, 20, 8, 32, 50, 303, DateTimeKind.Local).AddTicks(8307), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a") },
                    { new Guid("03d0df5b-81ed-4546-ae84-b0a41a1432f7"), "Praesentium eos cum quisquam quo ratione quam architecto et praesentium.", new DateTime(2023, 9, 5, 7, 47, 2, 368, DateTimeKind.Local).AddTicks(5744), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115") },
                    { new Guid("040e7c24-e739-4a94-866a-bc2d3c124723"), "Et nesciunt reprehenderit ut quo ea.", new DateTime(2023, 5, 20, 20, 44, 41, 339, DateTimeKind.Local).AddTicks(3577), new Guid("33a33b3e-14e6-4fca-8b8f-b3002c27b683"), new Guid("79b8948c-0f6e-4350-8bae-99666feb169d") },
                    { new Guid("04525541-1b6f-4c11-84b5-a4197ebdd446"), "Sed fuga placeat rerum blanditiis.", new DateTime(2023, 7, 13, 0, 53, 38, 988, DateTimeKind.Local).AddTicks(887), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("7efa7a93-621c-438b-aa92-e547ea51a297") },
                    { new Guid("054740c4-0e57-4155-8b2d-9933af3295ca"), "Quas cupiditate voluptatum labore rem quidem.", new DateTime(2023, 9, 30, 14, 52, 49, 97, DateTimeKind.Local).AddTicks(1307), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("7821c1ab-2cbe-42b8-a861-4f3840382a16") },
                    { new Guid("069b7bb1-e1dc-4081-a158-0e057343b2c5"), "Dignissimos adipisci sit.", new DateTime(2023, 12, 29, 7, 29, 54, 881, DateTimeKind.Local).AddTicks(3119), new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), new Guid("2c27f180-fd4f-4bf0-b4e7-3c4f72abd8dd") },
                    { new Guid("07169430-39db-4031-8149-455db23499a2"), "Rem aspernatur sit.", new DateTime(2024, 2, 29, 9, 42, 1, 919, DateTimeKind.Local).AddTicks(1902), new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), new Guid("dca75398-c29e-48c8-88cc-87770163b4f8") },
                    { new Guid("088ee268-7ab8-46fc-98f0-40729a0d21ee"), "Qui reprehenderit earum enim ipsum labore qui.", new DateTime(2023, 6, 15, 4, 46, 14, 120, DateTimeKind.Local).AddTicks(3163), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("0bfcf543-3355-4715-b2ad-17fba1d5a263") },
                    { new Guid("089c7f6d-051b-41dc-8143-38b5cd5ee32e"), "Qui totam vitae eos voluptatibus rerum quaerat hic et cumque.", new DateTime(2023, 7, 19, 11, 48, 10, 368, DateTimeKind.Local).AddTicks(9303), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("12b4e896-154c-471d-99df-2ed343213784") },
                    { new Guid("08e4a67f-37d6-4c50-86e4-7b0cdbd57abd"), "Omnis minus iste repellat velit aut.", new DateTime(2023, 6, 3, 7, 18, 50, 435, DateTimeKind.Local).AddTicks(4396), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("1d7d3c84-2713-4914-ae91-9981ec51a936") },
                    { new Guid("09ead1bd-4b68-4f67-8071-204cf5b27e04"), "Perspiciatis officiis et.", new DateTime(2023, 4, 21, 15, 42, 12, 266, DateTimeKind.Local).AddTicks(7878), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("7da3faea-318b-4ad4-a66d-62be34dfd6bc") },
                    { new Guid("0a53acba-838d-49fd-9aea-44c8d891d9fb"), "Cumque id a quasi architecto debitis eum ratione sed.", new DateTime(2023, 12, 23, 19, 35, 35, 954, DateTimeKind.Local).AddTicks(536), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856") },
                    { new Guid("0b3b482b-cbce-4ae5-840f-7563c50bc80a"), "Laboriosam nobis quis illo ipsum reprehenderit.", new DateTime(2024, 2, 26, 4, 7, 56, 950, DateTimeKind.Local).AddTicks(2668), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("6bdc0ab5-6380-49f4-8e58-6b8380c8304c") },
                    { new Guid("0c5b5b0e-3c02-4cfc-a838-a02dce03dc8e"), "Amet placeat recusandae atque.", new DateTime(2023, 12, 3, 7, 56, 15, 261, DateTimeKind.Local).AddTicks(3744), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("07a2c9f0-336c-4a87-bf1c-427ceffba480") },
                    { new Guid("1437b1b3-1b46-4843-900c-7aa7a21770db"), "Voluptatem quia voluptas voluptatum voluptatum qui minima architecto fugiat.", new DateTime(2024, 1, 20, 13, 9, 44, 590, DateTimeKind.Local).AddTicks(4122), new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"), new Guid("89f89cae-a29d-4f16-91ca-ffeb950136d8") },
                    { new Guid("157a5d9d-18a6-489e-b1e8-4f43721a580c"), "Et est sit et unde sapiente repellendus.", new DateTime(2023, 5, 29, 15, 56, 37, 723, DateTimeKind.Local).AddTicks(418), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856") },
                    { new Guid("1a205e18-f71d-4c5d-9c00-b1eafbddb266"), "Molestias dolore est quibusdam quia odio nihil.", new DateTime(2023, 10, 10, 23, 24, 7, 326, DateTimeKind.Local).AddTicks(2169), new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), new Guid("5d6136ba-9604-47f8-882a-0913acc43e4b") },
                    { new Guid("1a97da5f-4454-49d3-bab2-edaca48fa121"), "Nihil fugiat esse blanditiis repudiandae accusantium tempore veritatis architecto et.", new DateTime(2023, 7, 6, 15, 27, 29, 288, DateTimeKind.Local).AddTicks(6630), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("b730576a-5145-474a-9539-4254a2a938fb") },
                    { new Guid("1ba32a3b-74dd-4832-85e0-35331385d565"), "Nesciunt cum facere.", new DateTime(2023, 5, 7, 19, 37, 24, 849, DateTimeKind.Local).AddTicks(4223), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0") },
                    { new Guid("1f4c72e4-f06f-45a1-a3f1-ff3b0ee1b5ae"), "Quaerat commodi deleniti et dolor sit molestias quis.", new DateTime(2023, 9, 28, 0, 33, 41, 505, DateTimeKind.Local).AddTicks(4814), new Guid("33a33b3e-14e6-4fca-8b8f-b3002c27b683"), new Guid("11b875d5-8031-4662-af6f-81a9459c0537") },
                    { new Guid("247abaf1-7c17-42b8-ac6d-7fffa01973a5"), "Porro reprehenderit et quia occaecati dolor deserunt aut.", new DateTime(2023, 10, 31, 13, 28, 57, 439, DateTimeKind.Local).AddTicks(1240), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("634f3997-7f5c-49dc-a4ef-e4072fcc8f56") },
                    { new Guid("25d0896e-22fe-4d71-b259-0d9a4d8c8a7c"), "Sint odio perferendis qui odit assumenda consequatur cumque dolorem reprehenderit.", new DateTime(2024, 2, 9, 15, 20, 26, 324, DateTimeKind.Local).AddTicks(2229), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4") },
                    { new Guid("27b2a906-d3b0-4637-a729-0ec97008da0f"), "Sunt aperiam id consectetur a eum ab itaque.", new DateTime(2023, 12, 17, 18, 1, 11, 184, DateTimeKind.Local).AddTicks(2668), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("78cb0444-844f-49f7-a5cc-dc17fe50117b") },
                    { new Guid("27fd6a5f-6017-4d6d-b329-a90792c235ad"), "Facere eum atque.", new DateTime(2023, 5, 11, 21, 32, 10, 293, DateTimeKind.Local).AddTicks(519), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("051a2363-9054-4dc3-a108-f8c845bdeba7") },
                    { new Guid("29940e01-5b2b-48c2-827a-4fe2fc0618e1"), "Sed doloremque voluptate ipsa perferendis qui cum voluptate saepe.", new DateTime(2023, 4, 30, 0, 19, 53, 829, DateTimeKind.Local).AddTicks(3955), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("8fd7ece0-d65b-4e1c-b92d-354fa80c633a") },
                    { new Guid("2ef0bc7f-5c51-4042-848b-466b0d13bf01"), "Adipisci quis minus corrupti molestiae ipsum deleniti voluptatibus.", new DateTime(2024, 3, 12, 15, 26, 56, 27, DateTimeKind.Local).AddTicks(9789), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059") },
                    { new Guid("3055e47c-795c-487f-bfbe-77ed70739c85"), "Dolor molestiae ab et.", new DateTime(2024, 3, 7, 1, 14, 50, 687, DateTimeKind.Local).AddTicks(9990), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7") },
                    { new Guid("30af5471-0988-491c-a01d-ececcdae18b5"), "Culpa quisquam autem ut facere laudantium hic reprehenderit.", new DateTime(2023, 12, 13, 3, 6, 24, 49, DateTimeKind.Local).AddTicks(131), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("157fca20-9e2d-4e80-b44f-7415f83471d2") },
                    { new Guid("333578df-a262-43fc-b80a-ab81077425f1"), "Nulla eos totam.", new DateTime(2023, 5, 3, 22, 11, 49, 363, DateTimeKind.Local).AddTicks(7064), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("09bfad34-85cf-49ff-a63e-a03e11b4032d") },
                    { new Guid("340656cb-5d5c-4d61-a152-537d022e05c0"), "Similique eveniet assumenda nostrum quaerat consectetur.", new DateTime(2023, 10, 26, 12, 54, 50, 425, DateTimeKind.Local).AddTicks(689), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("6a2e13be-4a7e-4475-ade9-837eb81690d3") },
                    { new Guid("3428d2c7-4056-40b2-92c8-0b8df5948905"), "Soluta odit saepe.", new DateTime(2023, 9, 1, 2, 42, 9, 228, DateTimeKind.Local).AddTicks(3287), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("5ba3b2ea-74c9-4581-8468-4831a3365be1") },
                    { new Guid("354b7063-c781-4a99-a076-7ab20eeda98a"), "Eveniet tempora dolores et sed aut minus eveniet facere.", new DateTime(2023, 6, 21, 8, 21, 39, 313, DateTimeKind.Local).AddTicks(4164), new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"), new Guid("aeccd29e-a493-4d9b-a3c6-21053fd3f9a8") },
                    { new Guid("37cea320-8f50-4045-b979-5be23719ace7"), "Iure voluptatum veniam.", new DateTime(2023, 10, 16, 14, 19, 20, 979, DateTimeKind.Local).AddTicks(3118), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("dc2fe4eb-9a75-40d7-925c-3730e81acbd8") },
                    { new Guid("3a4b046c-fb46-434a-8584-ef75d581abe7"), "Molestias qui soluta dolores et dignissimos.", new DateTime(2023, 7, 5, 1, 50, 35, 146, DateTimeKind.Local).AddTicks(5426), new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"), new Guid("5d6136ba-9604-47f8-882a-0913acc43e4b") },
                    { new Guid("3af2e840-68fd-46fc-9c89-a47ab0480086"), "Ut sequi et doloremque.", new DateTime(2024, 1, 6, 11, 16, 29, 832, DateTimeKind.Local).AddTicks(6421), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e") },
                    { new Guid("3da0c46c-d929-4291-a5aa-302b72c61055"), "Labore fugit rerum exercitationem et dolorum voluptates dolores.", new DateTime(2023, 5, 9, 16, 2, 13, 437, DateTimeKind.Local).AddTicks(3269), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("89d37238-1f2f-4d0b-a737-dc6f46d0993f") },
                    { new Guid("3f605963-d850-458c-86ec-3608d0ba4015"), "Et officiis voluptatem quisquam eaque ab rerum excepturi omnis optio.", new DateTime(2023, 12, 16, 13, 44, 49, 776, DateTimeKind.Local).AddTicks(9464), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("0c166491-4c73-4064-93da-08284afda695") },
                    { new Guid("40566bd4-a358-4fd0-ae94-b2614b078823"), "Quibusdam eveniet nesciunt.", new DateTime(2024, 1, 15, 7, 29, 20, 393, DateTimeKind.Local).AddTicks(3173), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115") },
                    { new Guid("409b7ecb-d9c7-4024-8479-5997bb5a6d89"), "Minima ut voluptatem quo.", new DateTime(2023, 9, 19, 16, 43, 3, 671, DateTimeKind.Local).AddTicks(2785), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("43881999-d5c9-4da9-9c5a-739548f8720c") },
                    { new Guid("4377d402-eb75-4b4c-9b5e-c09dc3d72053"), "Molestiae id expedita est quis aut et architecto sint.", new DateTime(2023, 11, 28, 23, 15, 55, 920, DateTimeKind.Local).AddTicks(1631), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("1d7d3c84-2713-4914-ae91-9981ec51a936") },
                    { new Guid("49129bda-c18c-4eaa-9cdf-d7364f356cdf"), "Voluptas consequatur qui dolor amet ab magni.", new DateTime(2023, 11, 11, 1, 4, 24, 392, DateTimeKind.Local).AddTicks(8099), new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"), new Guid("71dab545-e32d-40a7-ad88-cf613e24af80") },
                    { new Guid("4991a4b4-95f5-4375-9bbb-d0826461232a"), "Aspernatur voluptas ut consectetur adipisci quos neque ut.", new DateTime(2023, 11, 23, 0, 28, 50, 394, DateTimeKind.Local).AddTicks(8273), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("1d7d3c84-2713-4914-ae91-9981ec51a936") },
                    { new Guid("4a076d24-2c27-4cc0-a11e-f4d610e80623"), "Sit quia repellendus labore minima vitae omnis.", new DateTime(2023, 9, 11, 2, 39, 29, 796, DateTimeKind.Local).AddTicks(3494), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da") },
                    { new Guid("4a2bbb10-2c17-4e8c-b2bf-a9b203d47c5e"), "Odit numquam saepe sed praesentium explicabo doloribus id.", new DateTime(2024, 3, 19, 6, 58, 24, 300, DateTimeKind.Local).AddTicks(8566), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("9bfb10f7-5a46-41ff-a465-574158ced91f") },
                    { new Guid("4b8c74cc-c475-403f-94c3-8bde1594795c"), "Et quisquam et quae non tempora modi accusamus quis hic.", new DateTime(2024, 1, 20, 1, 18, 52, 632, DateTimeKind.Local).AddTicks(52), new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"), new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684") },
                    { new Guid("4de98a55-5fbd-43e2-92e3-5be551857023"), "Autem rerum consequatur nesciunt in.", new DateTime(2023, 12, 6, 2, 16, 40, 708, DateTimeKind.Local).AddTicks(1801), new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), new Guid("95514ec5-6eac-45c9-a340-75dea1c7695f") },
                    { new Guid("4f9abc67-04d0-4d3a-9dce-e6f231533a15"), "Quaerat velit excepturi temporibus aut qui repellat omnis.", new DateTime(2023, 4, 30, 0, 5, 19, 29, DateTimeKind.Local).AddTicks(339), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("b589a934-628a-45fb-813e-e75938a11641") },
                    { new Guid("501db96e-c70c-4e50-8d96-c3a971ae60f2"), "Placeat repellat odit.", new DateTime(2023, 7, 1, 21, 3, 22, 281, DateTimeKind.Local).AddTicks(5643), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("71e13137-4234-4351-8988-f6cc67a6bf1b") },
                    { new Guid("5154c9d6-b629-477c-8f99-9c5217d6b3c8"), "Aut fugiat qui qui modi non amet.", new DateTime(2023, 5, 21, 9, 3, 26, 122, DateTimeKind.Local).AddTicks(2394), new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), new Guid("ea990230-ebd9-4035-b5cc-7689c339ea2e") },
                    { new Guid("529b2705-60db-4099-9efe-69909e47bcc9"), "Totam sit officiis quaerat sunt eum.", new DateTime(2024, 1, 23, 22, 43, 5, 858, DateTimeKind.Local).AddTicks(2195), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("0c166491-4c73-4064-93da-08284afda695") },
                    { new Guid("540445a2-b63e-4dc1-ace7-5fc40088fbfd"), "Officia sed et illum et repellendus minima accusamus.", new DateTime(2023, 10, 19, 8, 30, 31, 730, DateTimeKind.Local).AddTicks(4559), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("26029586-c8d2-4f17-84c5-6796078b420c") },
                    { new Guid("55e897db-0c81-4d37-90f4-efd9dd0e783d"), "Iste ad tenetur animi.", new DateTime(2023, 10, 27, 17, 58, 31, 375, DateTimeKind.Local).AddTicks(1299), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("129c1071-9d4e-4cbd-9e1d-c05536a2c0e6") },
                    { new Guid("5639b249-7cbf-4747-8abc-55031714eb8f"), "Ea repellendus officia eos.", new DateTime(2024, 1, 17, 19, 1, 53, 520, DateTimeKind.Local).AddTicks(3994), new Guid("e086b229-59cd-4b2b-b073-a85c32fa80b8"), new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0") },
                    { new Guid("5708e251-c58c-4462-8da0-773d160d80a6"), "Dolor dolore id.", new DateTime(2023, 10, 20, 11, 22, 41, 222, DateTimeKind.Local).AddTicks(6796), new Guid("33a33b3e-14e6-4fca-8b8f-b3002c27b683"), new Guid("457a85ea-235e-46bd-9c7c-127755bfaae2") },
                    { new Guid("577178de-3bad-44cd-928a-9d8cabe73f2e"), "Sequi tenetur odio nostrum velit dolores necessitatibus.", new DateTime(2024, 3, 21, 21, 30, 30, 707, DateTimeKind.Local).AddTicks(416), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("6cc4cf48-e085-434f-a862-7362f18110dd") },
                    { new Guid("5c21ae70-0144-462b-b737-2fbd065fb466"), "Nobis illo praesentium deleniti et sunt.", new DateTime(2023, 8, 4, 14, 38, 50, 553, DateTimeKind.Local).AddTicks(1160), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("42504898-86e2-4510-a02a-8063eb338b8a") },
                    { new Guid("5dd9cacc-c9ee-4399-ba32-8ad130f44d7b"), "Ut praesentium repellat.", new DateTime(2023, 7, 16, 13, 12, 35, 38, DateTimeKind.Local).AddTicks(3609), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("a8a84041-4148-4bff-a2fa-6e8ed8ef73bd") },
                    { new Guid("5df353f0-77c6-4e5d-abd9-67cb5fe07b00"), "Ipsam corrupti doloremque odit illo rerum facere.", new DateTime(2023, 12, 29, 6, 26, 58, 544, DateTimeKind.Local).AddTicks(8092), new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"), new Guid("1f53d9fa-a550-4086-ba2e-911a1853be0e") },
                    { new Guid("5fb00e1a-edf2-4931-9828-2484a2dc752a"), "Incidunt velit voluptatibus quos repellat velit soluta dolores molestias nostrum.", new DateTime(2023, 9, 10, 19, 29, 23, 803, DateTimeKind.Local).AddTicks(2719), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7") },
                    { new Guid("60729a89-f9ae-4da1-8383-d1a0ea7dcfae"), "Possimus et rerum molestias exercitationem ut.", new DateTime(2023, 8, 19, 1, 39, 21, 437, DateTimeKind.Local).AddTicks(4780), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("ee952a2e-d590-47c4-b520-e4d5f12c1b46") },
                    { new Guid("6168e63c-d4e8-4216-b9d6-fa6f6509c7b1"), "Nam dolorem est.", new DateTime(2024, 2, 11, 5, 49, 17, 403, DateTimeKind.Local).AddTicks(6837), new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), new Guid("ac9b1803-f789-4bba-8ade-66cf62191ff3") },
                    { new Guid("64536b1e-a0dd-46b8-8b4c-20588b665fbb"), "Pariatur id deleniti accusantium est iste possimus inventore totam similique.", new DateTime(2023, 5, 31, 13, 26, 51, 936, DateTimeKind.Local).AddTicks(7385), new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), new Guid("b18a63af-e07f-4406-bc28-6ced50da67de") },
                    { new Guid("65522b8d-ff00-4129-8fb8-7671ff72bfb2"), "Et eum enim est veniam optio quia nam consequuntur suscipit.", new DateTime(2023, 11, 1, 22, 9, 22, 369, DateTimeKind.Local).AddTicks(3543), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("4d263298-1780-4eb2-b7d6-b69b6f3484e9") },
                    { new Guid("65d3390f-8700-42c9-b140-7497f440aba3"), "Consequuntur inventore cumque libero.", new DateTime(2024, 3, 17, 8, 52, 56, 367, DateTimeKind.Local).AddTicks(8958), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684") },
                    { new Guid("69cd35b6-01b6-4f06-9ce3-dbd34204ffb1"), "Voluptas rerum sed error eos nobis.", new DateTime(2024, 1, 1, 13, 0, 22, 52, DateTimeKind.Local).AddTicks(9228), new Guid("e086b229-59cd-4b2b-b073-a85c32fa80b8"), new Guid("374093a3-bfaa-4a73-b1c0-bb8eb0d75ba9") },
                    { new Guid("69e74622-efa1-4622-b7ef-815d4ce4f3bd"), "Architecto illum facilis animi sed sit.", new DateTime(2024, 3, 20, 13, 36, 56, 705, DateTimeKind.Local).AddTicks(499), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("fa24756e-9fd9-4a83-854f-6d87b77d2a92") },
                    { new Guid("6a2077d2-4a83-4ee6-a697-905c8fc32289"), "Distinctio autem commodi veniam sed aliquam quo earum qui molestiae.", new DateTime(2023, 8, 28, 14, 57, 15, 456, DateTimeKind.Local).AddTicks(6111), new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"), new Guid("5c9b1c64-1c30-4013-9183-5a9e970b6349") },
                    { new Guid("6b886ad9-7c44-4234-af24-8ec3b40b12ad"), "Labore fugit aut aut necessitatibus facilis nulla delectus cum.", new DateTime(2024, 3, 15, 8, 25, 18, 489, DateTimeKind.Local).AddTicks(3857), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0") },
                    { new Guid("6bb583fe-ddc6-4b0d-8202-28693e11f001"), "Ut omnis esse enim.", new DateTime(2023, 9, 6, 18, 2, 7, 782, DateTimeKind.Local).AddTicks(5280), new Guid("23bade39-5f05-45ac-80f8-608b424cc913"), new Guid("0ecd8487-f43a-46f8-a409-14934fe06ce0") },
                    { new Guid("6c01f29c-4a22-44e7-95f9-9d91591aac65"), "Unde ut nulla quia iste incidunt aspernatur illum enim ut.", new DateTime(2023, 9, 20, 14, 54, 24, 595, DateTimeKind.Local).AddTicks(7141), new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"), new Guid("a0bebdff-3dce-4b8b-b66e-e7375927ca2c") },
                    { new Guid("6e5dab1f-709b-4fb8-a20b-203fa13819ba"), "Ut delectus pariatur provident.", new DateTime(2023, 8, 21, 8, 48, 49, 441, DateTimeKind.Local).AddTicks(351), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("b9b4b1fd-0312-413f-b8ea-5bbf54fa844f") },
                    { new Guid("6e798181-3cbc-43d8-ad71-866dd51c7f81"), "Minus nihil et aut vitae voluptatibus omnis.", new DateTime(2024, 2, 1, 23, 26, 46, 949, DateTimeKind.Local).AddTicks(5161), new Guid("8e3d5e40-1032-4321-b7f5-9b6c92f7910d"), new Guid("5ba3b2ea-74c9-4581-8468-4831a3365be1") },
                    { new Guid("6feeb480-dc2f-4f6a-bbed-0784c6b42513"), "Quas quis fuga et placeat.", new DateTime(2023, 10, 24, 8, 47, 5, 947, DateTimeKind.Local).AddTicks(5712), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("790a3927-f12e-42fe-94e0-2d22da9e5bd5") },
                    { new Guid("70fd919f-9621-48ff-94ce-8d7213516cc8"), "Dolorem iure et maiores.", new DateTime(2023, 6, 4, 0, 36, 42, 25, DateTimeKind.Local).AddTicks(7101), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("5d6136ba-9604-47f8-882a-0913acc43e4b") },
                    { new Guid("760dd50a-cac9-473c-bb91-7c8297e3b2ea"), "Excepturi ut et qui ducimus.", new DateTime(2023, 7, 3, 15, 30, 14, 424, DateTimeKind.Local).AddTicks(6508), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("d9297d5c-74f9-4326-8753-06611ccb364b") },
                    { new Guid("7841bf01-564d-46c4-aea2-681caded8d6a"), "Tempora ducimus fugiat exercitationem consequatur ipsum quia ea reprehenderit nisi.", new DateTime(2024, 2, 13, 6, 31, 50, 243, DateTimeKind.Local).AddTicks(9729), new Guid("8e3d5e40-1032-4321-b7f5-9b6c92f7910d"), new Guid("78cb0444-844f-49f7-a5cc-dc17fe50117b") },
                    { new Guid("7a45dc6d-a618-4043-9bb1-1eea98c6b54a"), "Assumenda consequatur est suscipit vel commodi ut.", new DateTime(2023, 11, 19, 2, 10, 35, 178, DateTimeKind.Local).AddTicks(921), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("8675aa5b-df90-468d-b451-120d3d5a332d") },
                    { new Guid("7a843f12-a7c9-4118-8a54-647b106e1131"), "Cum voluptates iusto illo ipsum neque.", new DateTime(2024, 4, 2, 12, 32, 58, 467, DateTimeKind.Local).AddTicks(1595), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("0894e3c6-bf19-4294-a7a6-44fabb7e53e4") },
                    { new Guid("7b1f6155-940a-4f3d-b7e4-41d6426bfbf6"), "Tempora magni porro suscipit accusantium assumenda nisi.", new DateTime(2024, 3, 3, 3, 4, 48, 18, DateTimeKind.Local).AddTicks(7183), new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"), new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059") },
                    { new Guid("7c25b0a9-e405-46be-8f7c-2c9a0613b8f0"), "Voluptatem nulla aut dolorem officia optio.", new DateTime(2023, 7, 13, 19, 55, 51, 244, DateTimeKind.Local).AddTicks(619), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("fa24756e-9fd9-4a83-854f-6d87b77d2a92") },
                    { new Guid("7c477b77-f569-41c3-a7b0-30f91ae92263"), "Voluptas quia quod cumque.", new DateTime(2024, 1, 3, 23, 22, 51, 41, DateTimeKind.Local).AddTicks(1524), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("81a9284b-7e16-4a66-8182-2e8932483261") },
                    { new Guid("7c94bcba-ffcf-486a-bad6-95e9255d8989"), "Qui adipisci ducimus quia quis aliquid labore maxime nulla omnis.", new DateTime(2023, 12, 21, 22, 2, 58, 46, DateTimeKind.Local).AddTicks(2446), new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), new Guid("213b5a60-d8a9-48f2-9341-56b7ea5fd98d") },
                    { new Guid("808a3ee2-4eb3-497a-9104-d3bc470b6edf"), "Molestias molestiae quae id ad ut odio veritatis distinctio.", new DateTime(2023, 4, 23, 22, 34, 33, 442, DateTimeKind.Local).AddTicks(5666), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a") },
                    { new Guid("80bb2a07-59e5-4529-96c7-53a9a7d2d94a"), "Dignissimos quis dignissimos architecto quia sed repudiandae voluptatem.", new DateTime(2024, 4, 11, 21, 26, 46, 314, DateTimeKind.Local).AddTicks(2205), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("156cc60f-95d4-42bd-a7f0-8bc433dad5a9") },
                    { new Guid("829ad4f1-4676-473d-9fb0-e9538650bcf1"), "Eaque doloribus recusandae ut quos ut.", new DateTime(2024, 3, 2, 0, 27, 59, 627, DateTimeKind.Local).AddTicks(7575), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("71dab545-e32d-40a7-ad88-cf613e24af80") },
                    { new Guid("85d4da2e-a433-491b-9e89-f541f1470de1"), "Ut reiciendis ipsam quis sapiente dolorem sint blanditiis aspernatur est.", new DateTime(2023, 11, 28, 4, 31, 7, 1, DateTimeKind.Local).AddTicks(9154), new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"), new Guid("ac9b1803-f789-4bba-8ade-66cf62191ff3") },
                    { new Guid("88ec3c8e-21b0-4869-baa2-09a96a14cf84"), "Facilis deserunt consequatur eaque facere.", new DateTime(2024, 4, 7, 19, 58, 27, 844, DateTimeKind.Local).AddTicks(2412), new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"), new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856") },
                    { new Guid("8a1c7819-0dd6-4a27-af27-f466a5fd7a26"), "Odit veritatis quam voluptatum provident corrupti nesciunt facilis doloremque.", new DateTime(2024, 1, 23, 20, 32, 45, 649, DateTimeKind.Local).AddTicks(1269), new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"), new Guid("7da3faea-318b-4ad4-a66d-62be34dfd6bc") },
                    { new Guid("8a897a45-3dd1-401f-9ec1-05e12407e036"), "Non necessitatibus natus atque voluptatibus animi.", new DateTime(2023, 10, 30, 7, 57, 3, 832, DateTimeKind.Local).AddTicks(6916), new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), new Guid("9bdbbe5e-61d1-4100-a6c1-96ad062c179d") },
                    { new Guid("8dc0d2c1-914e-4585-bb5b-1572ffadc6f9"), "Officiis est modi.", new DateTime(2024, 2, 22, 8, 44, 38, 265, DateTimeKind.Local).AddTicks(5657), new Guid("e086b229-59cd-4b2b-b073-a85c32fa80b8"), new Guid("2ee20b64-f6a9-4c36-928e-2b17b18c1415") },
                    { new Guid("8e1b6be2-c6d1-4063-a02a-055cd8570af9"), "Tempora saepe in molestias officiis iure voluptas perspiciatis ex aut.", new DateTime(2023, 8, 30, 5, 23, 55, 322, DateTimeKind.Local).AddTicks(2732), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("4072b127-2891-4ac6-8b0a-baef95b325f4") },
                    { new Guid("8ec33c8f-bb07-4268-809a-95995fbffc6e"), "Nihil accusamus vitae recusandae voluptas hic temporibus voluptas est ut.", new DateTime(2023, 8, 2, 21, 57, 35, 795, DateTimeKind.Local).AddTicks(14), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a") },
                    { new Guid("8f0fe04c-e559-446d-9eb9-8a80bb64f6ef"), "Sint dolore veniam illum.", new DateTime(2024, 1, 21, 0, 20, 50, 811, DateTimeKind.Local).AddTicks(5154), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("fa24756e-9fd9-4a83-854f-6d87b77d2a92") },
                    { new Guid("93f739e2-0c3c-4840-aad1-0be4332ebb66"), "Vero praesentium ab rerum eius et ex cum praesentium quaerat.", new DateTime(2024, 4, 3, 10, 14, 3, 153, DateTimeKind.Local).AddTicks(5269), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("da3d6f5b-c8a4-4310-b684-86061fc826b3") },
                    { new Guid("94c76367-04b0-4099-a7af-6b5e76f0156f"), "Eum rerum iste.", new DateTime(2024, 2, 7, 5, 17, 15, 49, DateTimeKind.Local).AddTicks(1739), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("4630f1fa-8a65-4058-a8ad-824aa75c3769") },
                    { new Guid("953d66ff-67df-4eed-9ab3-b3f894b82abb"), "Illo soluta earum excepturi molestiae reiciendis recusandae eum.", new DateTime(2023, 12, 22, 1, 26, 34, 900, DateTimeKind.Local).AddTicks(495), new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"), new Guid("44c19fc2-112f-4dc3-ad0f-3e147fa7d18d") },
                    { new Guid("96d2814f-0033-4b11-a49a-6c177b715a89"), "Sit sit quia.", new DateTime(2024, 1, 16, 11, 45, 23, 812, DateTimeKind.Local).AddTicks(4446), new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"), new Guid("8352a3b5-4933-49f6-904e-be1daf133d75") },
                    { new Guid("96e3d9b8-abc7-481c-bad0-e496d1b83b88"), "Blanditiis et earum.", new DateTime(2023, 7, 14, 5, 45, 19, 857, DateTimeKind.Local).AddTicks(9576), new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"), new Guid("6c98aaee-4c17-43fd-9558-13228f4988c9") },
                    { new Guid("9886e2ba-c036-4ffc-8a49-08e5738b3051"), "Sint dignissimos aliquid est recusandae.", new DateTime(2023, 12, 2, 21, 41, 10, 667, DateTimeKind.Local).AddTicks(7354), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853") },
                    { new Guid("9a15d447-f139-403b-9fe4-0a93be4a56ce"), "Saepe laboriosam adipisci officia inventore nostrum velit.", new DateTime(2024, 3, 31, 1, 0, 25, 96, DateTimeKind.Local).AddTicks(5577), new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), new Guid("744b7b47-c075-4158-81ba-a8dd8b76c4ee") },
                    { new Guid("9bc0ada3-983b-4b37-a762-5bfb549b55d6"), "Blanditiis voluptas pariatur fuga dignissimos enim.", new DateTime(2023, 8, 29, 9, 55, 49, 511, DateTimeKind.Local).AddTicks(2700), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("3c9c7b28-e55e-40e6-9a33-c8a2da7f6b96") },
                    { new Guid("9fa93f74-7a30-451a-ad6d-075c8ce8a43e"), "Quo cupiditate pariatur sed minus dolore.", new DateTime(2023, 7, 6, 23, 53, 13, 732, DateTimeKind.Local).AddTicks(9129), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("2b96c93c-88aa-4a63-b61c-9f13278cc8c9") },
                    { new Guid("a262e855-2a6d-479e-bd86-227334e9365b"), "Vel nisi alias excepturi eaque consequatur ipsam excepturi.", new DateTime(2023, 9, 26, 15, 28, 23, 512, DateTimeKind.Local).AddTicks(4175), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("525d056b-9c97-496b-9b1d-b42d6533c919") },
                    { new Guid("a3ec2549-495e-47e8-b630-8a8e40a38dcd"), "Libero vitae et voluptates.", new DateTime(2024, 3, 27, 5, 59, 12, 63, DateTimeKind.Local).AddTicks(6097), new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"), new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e") },
                    { new Guid("a405656d-ec73-4c06-8df2-4ed4a51ae8c5"), "Enim accusantium similique distinctio et laudantium possimus qui.", new DateTime(2023, 6, 13, 13, 22, 54, 317, DateTimeKind.Local).AddTicks(3481), new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"), new Guid("85d0b25c-94c6-41d9-a1f4-4f83ff2d93fa") },
                    { new Guid("a84843c1-b61a-43c4-8f3b-d175c28b8b3b"), "Voluptates enim incidunt blanditiis nihil iste dolorem rem.", new DateTime(2023, 12, 10, 7, 13, 30, 501, DateTimeKind.Local).AddTicks(4518), new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"), new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7") },
                    { new Guid("a9760aad-c2f1-4bb1-a18e-1b12b0612f28"), "Sit maiores eius quibusdam ut esse.", new DateTime(2024, 3, 3, 19, 19, 19, 325, DateTimeKind.Local).AddTicks(2465), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("457a85ea-235e-46bd-9c7c-127755bfaae2") },
                    { new Guid("aa55c46d-969a-41f8-b579-f445b30f954d"), "Vitae voluptate quia est possimus.", new DateTime(2023, 5, 28, 5, 38, 14, 239, DateTimeKind.Local).AddTicks(132), new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"), new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c") },
                    { new Guid("b05d34ef-3648-4410-b11d-208b474ed0b5"), "Aut unde vero dolores distinctio facilis a.", new DateTime(2024, 2, 9, 7, 31, 59, 660, DateTimeKind.Local).AddTicks(7350), new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), new Guid("7a0a4358-5130-49f3-badf-b4bbeed382cf") },
                    { new Guid("b2d8ee89-4a06-4c21-96dc-63c48d9e5c03"), "Qui ad eos accusamus totam et amet.", new DateTime(2023, 6, 21, 18, 36, 28, 674, DateTimeKind.Local).AddTicks(2172), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e") },
                    { new Guid("b52ccee7-76cd-4981-a0d5-7ddc1efd8b80"), "Cupiditate unde qui aliquam aspernatur.", new DateTime(2023, 5, 8, 23, 54, 31, 586, DateTimeKind.Local).AddTicks(3143), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da") },
                    { new Guid("b5b3ed84-1ca3-4cc5-be5b-cb3df61ef5e3"), "Et et praesentium quia ut voluptate ipsa quibusdam.", new DateTime(2024, 1, 9, 15, 52, 7, 988, DateTimeKind.Local).AddTicks(2367), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4") },
                    { new Guid("b66ffee7-085e-4106-a3f5-5b723383188c"), "Est sint minima saepe adipisci et ut.", new DateTime(2023, 7, 2, 0, 28, 53, 619, DateTimeKind.Local).AddTicks(3048), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("aeccd29e-a493-4d9b-a3c6-21053fd3f9a8") },
                    { new Guid("b6f318aa-06d2-443e-84d2-03353451a7cb"), "Earum id repudiandae in consequatur odio maxime.", new DateTime(2023, 9, 24, 21, 31, 27, 433, DateTimeKind.Local).AddTicks(3543), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("4fa018dd-091f-481b-b905-4856e7795e63") },
                    { new Guid("b82c4c30-a181-46b8-8c5e-1fb2d2f50989"), "Voluptatem ipsam eligendi perspiciatis.", new DateTime(2023, 9, 28, 8, 7, 39, 950, DateTimeKind.Local).AddTicks(9046), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("060e6b87-19b9-450c-b3f8-b8bce9433e47") },
                    { new Guid("bc0c22b5-1c1c-4825-b180-625bda7396f4"), "Corporis qui voluptas sequi illum voluptatem reprehenderit porro sunt aut.", new DateTime(2023, 10, 12, 1, 52, 32, 679, DateTimeKind.Local).AddTicks(3652), new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"), new Guid("80105bf0-db71-4b11-a006-87ee3449b929") },
                    { new Guid("c065371d-9b4b-4838-a5ac-6ff0b8bceb93"), "Reiciendis corporis ratione voluptatem placeat consequuntur aspernatur.", new DateTime(2024, 3, 28, 1, 43, 42, 749, DateTimeKind.Local).AddTicks(4234), new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), new Guid("525d056b-9c97-496b-9b1d-b42d6533c919") },
                    { new Guid("c271c89c-01ec-475a-a687-03ab76bf228b"), "Nemo fugit accusantium.", new DateTime(2023, 9, 30, 1, 36, 55, 806, DateTimeKind.Local).AddTicks(4014), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("3c319cfe-9452-4e16-826b-a4a9c012eebf") },
                    { new Guid("c5516e44-ecba-4cef-8d1c-484e6a6463a0"), "Ratione et sunt et id praesentium.", new DateTime(2023, 11, 23, 3, 31, 7, 636, DateTimeKind.Local).AddTicks(2163), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("950b48d1-e21b-46cb-b479-07ca0c9255d7") },
                    { new Guid("ce577728-14e6-487a-8695-8cbd902a61b6"), "Iure explicabo ut rerum enim rerum.", new DateTime(2024, 1, 7, 20, 9, 23, 231, DateTimeKind.Local).AddTicks(8063), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("798f293d-6f50-47f3-9a15-88a2945a4ee2") },
                    { new Guid("d11372e0-89e7-4ca5-9f9e-64d2efe602d2"), "Quia iure exercitationem rerum.", new DateTime(2023, 10, 2, 6, 21, 29, 356, DateTimeKind.Local).AddTicks(8411), new Guid("23bade39-5f05-45ac-80f8-608b424cc913"), new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853") },
                    { new Guid("d11be0a9-6ec1-46d7-b91f-a122bbeafd21"), "Quia voluptatem ea rerum cum.", new DateTime(2023, 12, 10, 5, 25, 15, 876, DateTimeKind.Local).AddTicks(6481), new Guid("23bade39-5f05-45ac-80f8-608b424cc913"), new Guid("5ab15f1c-3352-40e6-918d-51d69903dba4") },
                    { new Guid("d27f257b-1bc5-4a65-86b1-e9234a0febc8"), "Ipsa possimus doloribus autem aliquam debitis in ducimus.", new DateTime(2024, 4, 13, 13, 16, 19, 428, DateTimeKind.Local).AddTicks(2192), new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"), new Guid("426356a4-e7ce-49ac-8d74-5ae599a6e116") },
                    { new Guid("d362d0a4-f95d-4a77-aee4-87df902e5ab1"), "Quidem laudantium esse.", new DateTime(2023, 7, 11, 4, 22, 37, 185, DateTimeKind.Local).AddTicks(4426), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("7a0a4358-5130-49f3-badf-b4bbeed382cf") },
                    { new Guid("d379ad38-6638-4f73-8381-28db8246a801"), "Iste velit et rerum aperiam necessitatibus.", new DateTime(2024, 1, 4, 12, 23, 42, 221, DateTimeKind.Local).AddTicks(7340), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("6bdc0ab5-6380-49f4-8e58-6b8380c8304c") },
                    { new Guid("d4c96a10-2c44-493d-addf-ac58330ebf61"), "Architecto et dolor dolores.", new DateTime(2023, 5, 6, 13, 23, 18, 660, DateTimeKind.Local).AddTicks(2723), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("2b96c93c-88aa-4a63-b61c-9f13278cc8c9") },
                    { new Guid("d6bbee74-ecd7-4542-9471-efaa9c5ad2d9"), "Et ab vero sed quis aliquam.", new DateTime(2024, 3, 4, 9, 52, 33, 253, DateTimeKind.Local).AddTicks(7112), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("42504898-86e2-4510-a02a-8063eb338b8a") },
                    { new Guid("d7dd42d9-6cba-4bcd-a401-d7d3bfe853f1"), "Non omnis sequi sint ipsam quia.", new DateTime(2023, 8, 7, 14, 45, 31, 953, DateTimeKind.Local).AddTicks(359), new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"), new Guid("3c319cfe-9452-4e16-826b-a4a9c012eebf") },
                    { new Guid("d8a9bc56-ade0-4fa1-b45e-20c78a96c56d"), "Eius temporibus consequatur quaerat et quo hic enim.", new DateTime(2023, 11, 9, 21, 51, 1, 417, DateTimeKind.Local).AddTicks(2904), new Guid("31df4091-acc0-40ab-a45d-98fb86469174"), new Guid("71e13137-4234-4351-8988-f6cc67a6bf1b") },
                    { new Guid("de31d9da-896a-4755-8534-0bafdb9a1ed9"), "Fugiat unde praesentium facilis dolores dignissimos repudiandae sed et.", new DateTime(2023, 12, 22, 1, 13, 2, 589, DateTimeKind.Local).AddTicks(6970), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("6df27f42-990d-4e8b-b3a8-ce14647b21a1") },
                    { new Guid("dee7b785-2235-4bfc-822e-1f4a2557a83a"), "Quasi eos nam velit quam autem necessitatibus enim asperiores.", new DateTime(2023, 7, 9, 20, 59, 38, 80, DateTimeKind.Local).AddTicks(3028), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("9bfb10f7-5a46-41ff-a465-574158ced91f") },
                    { new Guid("df579516-4a2f-4601-9769-254ee87650a9"), "Voluptates eveniet rem ut mollitia.", new DateTime(2023, 11, 22, 12, 46, 38, 535, DateTimeKind.Local).AddTicks(1755), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("4fa018dd-091f-481b-b905-4856e7795e63") },
                    { new Guid("e04ba809-96ef-4e0e-b65c-165667c542de"), "Ut quae voluptate ut aut dolor libero magnam impedit qui.", new DateTime(2023, 12, 17, 11, 42, 31, 916, DateTimeKind.Local).AddTicks(235), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("12b4e896-154c-471d-99df-2ed343213784") },
                    { new Guid("e20a64ba-2025-40b4-8bc6-addec94be519"), "Est aut adipisci molestiae.", new DateTime(2023, 10, 30, 3, 31, 47, 100, DateTimeKind.Local).AddTicks(945), new Guid("3686c752-5d03-426e-bf53-129c280d52f1"), new Guid("f237bc17-bb36-4d96-9444-eefa69d519d2") },
                    { new Guid("e21fd501-a35b-4add-a10e-84a0baf7088f"), "Totam iure rem ullam modi quaerat.", new DateTime(2024, 3, 8, 3, 23, 34, 565, DateTimeKind.Local).AddTicks(8269), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("d9297d5c-74f9-4326-8753-06611ccb364b") },
                    { new Guid("e4a130f4-d610-44f3-8f7a-7c8dd2526e17"), "Odio aut labore tenetur unde similique voluptate amet.", new DateTime(2023, 5, 8, 3, 55, 26, 750, DateTimeKind.Local).AddTicks(2636), new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"), new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059") },
                    { new Guid("e5179f81-e8c2-40f3-9897-15a52f31b067"), "Et similique voluptates quidem error perferendis ut eaque deserunt.", new DateTime(2023, 9, 8, 13, 37, 8, 215, DateTimeKind.Local).AddTicks(7511), new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"), new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115") },
                    { new Guid("e576e74f-e273-401b-bca4-c04acf9b761d"), "Veritatis debitis iste porro et recusandae nostrum.", new DateTime(2023, 9, 9, 18, 42, 20, 118, DateTimeKind.Local).AddTicks(118), new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"), new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da") },
                    { new Guid("e8f1294c-5227-45d6-8291-895951ed9125"), "Vel voluptatum voluptatem.", new DateTime(2024, 2, 4, 23, 1, 50, 650, DateTimeKind.Local).AddTicks(7514), new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"), new Guid("b29a6eee-c316-46bf-b2c9-4e521554b08b") },
                    { new Guid("e928bf34-7ebf-4a46-9620-98f00b8b9b17"), "Inventore molestias dolores libero cumque alias.", new DateTime(2023, 5, 26, 14, 46, 45, 347, DateTimeKind.Local).AddTicks(8400), new Guid("3a798297-c07b-467c-b983-639062b9853b"), new Guid("c6cac74f-61ce-46f1-8519-2c920c3c7854") },
                    { new Guid("ed61e215-1491-4d22-9a17-ab557128d635"), "Maxime occaecati totam excepturi repudiandae et veniam et.", new DateTime(2023, 6, 29, 2, 52, 40, 761, DateTimeKind.Local).AddTicks(8341), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("457a85ea-235e-46bd-9c7c-127755bfaae2") },
                    { new Guid("f50ed719-5c0b-4e85-9b36-d915bb32afae"), "Quos aut qui nulla unde nesciunt distinctio natus quidem.", new DateTime(2024, 2, 18, 14, 4, 52, 325, DateTimeKind.Local).AddTicks(5354), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("95514ec5-6eac-45c9-a340-75dea1c7695f") },
                    { new Guid("f9a0c4b1-b1ce-4e64-89ee-41d51703ca89"), "Quibusdam consectetur nobis.", new DateTime(2023, 12, 29, 11, 24, 31, 372, DateTimeKind.Local).AddTicks(7037), new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"), new Guid("a1209db0-3aae-4123-ae46-7450420fd136") },
                    { new Guid("f9ee52d5-0eba-45fc-bf67-aaf8ce5d1e14"), "In nobis ad voluptate esse molestias cum.", new DateTime(2023, 11, 11, 2, 2, 51, 211, DateTimeKind.Local).AddTicks(8412), new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"), new Guid("3c9c7b28-e55e-40e6-9a33-c8a2da7f6b96") },
                    { new Guid("fab2b852-a9a7-47e2-850d-c46ceed6a84c"), "Quia culpa autem sed.", new DateTime(2023, 9, 7, 9, 21, 15, 482, DateTimeKind.Local).AddTicks(291), new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"), new Guid("374093a3-bfaa-4a73-b1c0-bb8eb0d75ba9") },
                    { new Guid("fb10b511-a9e1-44e1-b7b6-413e27a65843"), "Dolore perspiciatis architecto eum consectetur nesciunt voluptatem.", new DateTime(2024, 1, 11, 19, 14, 28, 300, DateTimeKind.Local).AddTicks(7524), new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"), new Guid("756247ae-bd2e-4300-a8b9-531f88248ac1") },
                    { new Guid("fb95e386-9763-48d2-a9a2-8e2ea108b6f7"), "Esse minus accusantium architecto velit dolore magni quia.", new DateTime(2023, 6, 25, 16, 28, 47, 898, DateTimeKind.Local).AddTicks(1725), new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"), new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856") },
                    { new Guid("ff346b71-a58d-4e13-8d07-826c1aa01feb"), "Est dolores sed doloremque ipsum.", new DateTime(2023, 10, 5, 19, 35, 3, 807, DateTimeKind.Local).AddTicks(5881), new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"), new Guid("4d263298-1780-4eb2-b7d6-b69b6f3484e9") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("032df801-14bb-4141-950c-829cbba38668"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("038c8a12-2148-4fdd-b3f6-a1115ab939e9"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("04afdbbc-9354-4807-a56f-5c470040c34e"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("073c3c75-976a-4962-91e7-382d880e0c01"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("135d45f2-5906-42f3-9718-bdac299340c7"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("14ea0121-dd47-4740-bd05-d99926361518"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("1ae9eff5-d91f-4ebd-89a8-2454157af236"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("1cce0f51-4036-4c4e-8b34-a51dfa054bf4"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("219e5585-90c3-4d69-9679-2576569663c0"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("271413b9-03ac-4128-b602-5063f5d5bb2d"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("32d1ae9a-2d5c-4c00-b091-7e7f1dc785af"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("33b871ba-1eec-445f-a219-9c8474a25ad0"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("34363072-fb88-4d6e-9b26-b48b4d5401de"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("462afcea-ddbc-4e82-a88b-76208809204b"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("48c1cb7b-585a-4cf5-927c-57f694149733"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("4ae2ec2a-0638-49c8-bafb-965c55726a2a"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("57fea372-da42-4cf7-b375-ed57548baf43"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("58c8ee74-7e7e-454c-a292-8a10bed23b8b"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("5c28bc97-6e26-4b2a-a9c4-0e8cef879db0"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("5c658c5e-ffa6-4836-899e-7bf4e3f8d04c"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("66d8313b-f515-4538-95a0-53d9036d23f1"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("6e3b5df4-22fa-441b-b42d-b320f20e146d"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("70e7779e-eb41-493c-9dde-bb7d75fcf53c"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("76209ca7-9f2a-4cbf-a90e-18d5632b74ba"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("801c704b-ab07-4c9b-9f17-a3b68d0f1f60"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("81446e2e-1fac-4100-bc92-1b21d1729809"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("8321cec2-b23f-42bc-be3e-b1bdcae86cd5"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("8a7dc554-8bec-40b0-aee6-c4a62c82b316"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("8c58a4e7-c107-4f4d-81c7-bad323b37083"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("8d65d850-2d75-417a-b739-b6728f5a5c5d"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("8d889b62-1ec8-4548-80ba-68b1e45c4f1c"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("92b347f1-499b-4dfd-ade3-27ab2998db30"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("92e43f70-2910-495b-a20a-47eaa79ce9c3"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("992699ad-fd40-49ce-8339-914cb1708c02"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("9ae21dae-c898-4457-a72a-9877f630bd91"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("a2569140-495a-43ac-9f60-5459d7a114e2"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("aa1c4468-fee6-46d8-8ddd-9f3a43a12074"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("ab26f02a-8b07-4cb8-8ef8-b6a304f761cc"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("aeb3f881-21b3-4f31-bf6a-d0d68b8d0da2"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("c47825b5-8685-4c12-901e-92723d63118f"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("c5019ec4-c3fd-43ad-9eb2-2de1c7a15a7f"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("cd27a9b1-ea48-4604-8f80-ad00cdaef003"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("d8821b00-1dd3-465d-bdd5-53733a5a56ac"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("d8ccab85-7c46-47bf-910b-207b164c6ff5"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("ded3b4b2-42e6-4693-9a9f-c64b584760fb"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("e6f5530a-ae89-48cf-9ea7-0a7bb413954c"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("eafc0ecf-3ebf-48c7-9776-f96604b88d0b"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("edfdd9fc-94e1-4d00-b9ad-870f5249c387"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("f14d46b7-9c31-4e4f-a60f-4a8d4cb6d569"));

            migrationBuilder.DeleteData(
                table: "Diagnoses",
                keyColumn: "ID",
                keyValue: new Guid("f4342d08-9234-4605-be69-d989183cc623"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("14bc4d79-d380-499f-bbaf-4c52b384ec88"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("18f0c16c-40f0-4595-8616-9415a8c05b7a"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("2a3f9202-94b3-4335-b821-d2dffbd22421"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3046cb46-ea0a-442a-91e5-c3a76d8e2390"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("31e2bfc5-c31c-4b7b-a25a-a8317f91e2c6"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("4de83fa4-818f-446d-9dd0-bb56f1e5a4fb"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("5dc1326a-0978-408c-8571-95a18ba04b8d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6122f9ae-e52f-4154-9ec6-38666b139177"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("692b75d4-bf15-4c09-80b0-46b787877e89"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6950b27c-2e9c-419b-be53-49d591446f8b"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("69dcc256-13f2-4b50-882a-613eae8190b3"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("7d672779-3b56-4ce0-adcd-9c5c06847c76"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("84e38bb4-d6da-4fe8-9655-f03637f099f9"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("993ca5ca-b6ac-4f41-bbb0-1b165678598e"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9c5071d5-7670-4efe-9899-64c8f09c61b0"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b93b0114-ed73-4ba9-ba6e-090444dd2f19"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ba982841-ddd1-4fde-b1db-d5e563fea40c"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e676bdb7-a88d-476c-82a5-cca3bc3a63b3"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ff0f76ce-2272-45ce-bc47-074779d2598f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ffa45e51-7417-4700-9dcf-017e9d00292e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0208a602-21bd-4533-95d0-45d8908eea16"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0465ca14-a869-4f69-9929-e39a7675170f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("07243997-27dc-44fb-91e8-78b79c12a365"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0eeecb7e-4eb0-4ff5-a37a-7a67e06fd026"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("27da5463-f04c-4cd7-b1d6-76e6d52471fb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2bf97bed-f1bc-4226-9f75-7d667c166a25"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2d6bd052-0b8f-4c96-ab7d-fd8cfff356fe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("30a30531-0e2e-4d61-acb5-183c3e2f7602"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3a756c63-5430-42f4-814f-1e37e12a3ad1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3fa1547f-a5cc-48d1-bab0-cbc3de0dbc2d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3ff556af-19d8-4f11-9609-af144dbd709e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4452b1c6-8b89-42aa-9d59-d64ddaaa8d9d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("478f0c75-2c9f-4a85-963f-86b6c0aeef58"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("49d699c4-e8ba-42f5-b634-c41b579937b0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5154c326-bdd9-4e2c-82cd-6e902c2bb58a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("52f53071-9ec3-40b6-a804-8414d817edf3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("59456922-edf5-4643-9854-124ae496a1d5"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5ddb8e45-7ec9-49b0-8865-a3d6175be718"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("627b9f5b-62ea-4e50-8646-0471c2cfbbfc"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("65b4175b-fc0b-451c-8ecb-a2f80750f2e0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6a376686-556a-43f9-8285-428abbfcdcad"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7912e932-c885-4dc4-a258-7505c40bb959"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("794b85ff-393e-4564-993b-cdcb9718d128"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8b9a5d8e-e058-4155-bebf-cdc65acf35d1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8c2d0541-c11e-4f99-9eed-a52b3b1815e0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8cd4c3c7-e2d3-4473-aa36-52d1aa8a3a2c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8e78d04f-8085-4584-9d1e-23ec4c1c8bfe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("91488e9c-c340-4a09-a5df-46d578966741"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("9548f4ad-7dc0-4f3b-b449-65a0838cb673"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("95eff680-028a-431f-8db5-bef2752d2a2c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a28a28a6-7783-4265-949f-b0437f00615d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a9a936a1-a87d-4aae-98c3-e39884784161"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("dca46baf-b1d4-4300-99ed-a77c6992bb67"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("dd0339d4-4fd5-4ff8-8778-51e3939084bc"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e145a512-f2b4-47cb-8dbb-bd036534b0e3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e6648517-0d32-4624-a7ec-6731d6b806b1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e66d8c0d-fbc4-4e16-b53f-68ac990d86bc"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ea4481aa-7f8b-4f4b-933e-ea3d8bff524b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f1b30695-15ce-4944-99cf-1b4b6f437667"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f411932a-7302-4042-a48e-a2aa76d87f81"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f6abc171-8892-4a6d-8c8e-b65d695ea322"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("fe37ab27-21ef-4995-94eb-dc17b46e8669"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("03422d88-888c-4a15-af65-68e90a2cd5bf"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("061a00f7-92a1-466e-85ae-45a00d909598"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("06629a1f-44c0-48aa-be5a-ac3026e020ee"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("07539dd5-98f8-4be0-bfeb-05cc79f62fb7"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("106869a8-341e-49c7-8d26-3a2e1a13ef0b"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("1281d807-10d7-419b-8a26-1d84af1e5107"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("12af909f-7a48-440a-9e1f-aadc2d86d0cc"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("158cae2b-b415-4343-bb6e-3e30e2f9e4ea"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("18c45d5d-8219-4cb2-a192-8ab8c8c67f11"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("1d158a2f-93bd-4366-b55d-beba7832fd72"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("21391265-55e6-4edc-957b-49851c9301dc"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("21e28521-2b67-4ed7-928d-0282c2e574a1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("2404804d-9fbe-4841-816c-c2cd3229803a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("292b8ac1-a805-40a9-ab8d-ddee1553e55d"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("2a46de9b-a67b-400d-aa2b-9ee6ef9309cf"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("30614bac-a386-437b-bb2c-147cb4a71f78"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("30b5c875-b7cd-4e77-a4df-cbd73932da85"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("33a82393-9319-42aa-8276-a51c664ec80a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3413c032-be66-4186-b42e-2dfdeab5dc76"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3574d4c9-2983-474b-9f6a-363e74cbe8e9"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3680c1b1-8fbd-4250-9e01-23594cc90a63"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("37d1fd78-ab39-4dc2-ab21-5bbf98ae67c1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3839a80b-a010-4238-a21b-da7b62df2e3f"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3885b979-bf50-490e-a196-062b81b6be21"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("38be90de-9c70-4152-b21c-07d9de385342"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3f1eb1aa-9d57-4b40-a287-5e6455095192"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("3f53c39f-cfea-484b-9578-3d977cdad194"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("4043d876-2605-49b0-86e2-6cb29a010ee6"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("417c9186-2d38-4cb2-a76f-ceb6b6cbb858"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("43156cc8-337f-4d3f-b063-808680306213"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("454ffe1e-8abb-4967-84cd-29941ee11506"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("45eb45b7-c9d5-477c-ac0a-a5f1a07d36f5"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("482d4578-1629-4b49-a11f-7f27a548f823"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("4bfa2ba1-2e64-46b3-9573-575a3f40d5ee"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("4d1e3156-3572-42dd-8f25-8f8b57e0966a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("5259830d-30ba-4d0d-9a54-8376193afc46"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("52b99ef7-4282-4a6c-b9c6-53e84bf1b562"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("53547d22-de3c-4d73-a334-cce9208d1d9d"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("5bbbbe97-1e2f-449c-979d-ed85ef9996e2"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("5bd5e210-1260-44bd-a9ba-56e315aaf8fe"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("647370bb-3cee-4245-8b75-bdb1e1d256cc"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6b58d645-3bd1-4fe4-95b6-da1bac2d05f4"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6baa04d5-ab46-4ce9-a54f-b00f3be5629d"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("7078c94a-3564-498a-8d0f-8ab58739ac92"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("70f3ef3b-0ee1-43fc-b15f-036ddd1789d3"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("720b22b7-14bb-41c5-b1fd-6f90c141afbb"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("728050e7-f85c-4a98-88ba-ded3a37f54d6"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("78b8bdbf-78fa-4362-a63c-7227386fc808"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("79b491f7-9e0c-4882-a688-43833629292b"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("87eefa48-ac2c-44db-93d8-b31ae15d6a18"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("88693298-91c6-4253-bbc3-31173033c18e"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8887384c-916a-4feb-b7af-aa9f6ca24857"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8a43480e-aa8c-4b4f-8b9e-04970e02f24b"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8a8da0aa-cb95-42aa-be80-fbc77819f438"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8c43d504-c4e7-4ec7-9e0f-3743829fc3d1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8d014fff-4b35-44c6-b184-88700c40040a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8f884fdc-c77c-46b7-bab0-c965a5340704"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("900d3a1b-84af-49ae-bb8a-1015cdcaee59"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9686d2b3-5a41-4e14-8e1e-232f4912f7d1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("973da73c-8a58-4e6c-8ac6-6675a91a60d0"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("975198dc-c6bc-4ab4-9b9e-57079a00f4d8"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9783ec2d-d892-4f13-a255-01d32b06d673"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("985e70e1-10a7-4fa8-8557-c05929d3858f"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9979d187-2ecb-4deb-8e50-75192abdc910"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9de1a826-f324-4a87-9dd7-50cb3fffbd79"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9f3c2721-faeb-4309-a9f5-ffa4a95661a8"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("a091f9d5-1202-4162-89b5-a464b53fe218"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("a69df4bc-9c5f-4814-8828-ea508bbb43eb"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("aae6a534-1e72-4c34-b16c-88475e8684af"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ad567cd4-0766-494c-a298-09fc56d8ef58"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("adc87044-8b88-4440-8e9d-023a5314d82c"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b5c9d295-7c7f-4d2d-a366-a356fe23603d"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b77f4bab-9c3c-4fb8-b39f-8ec6a7ac4350"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b80160d2-f99c-4766-a903-5ea10d4ac536"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b9f30dd9-2b60-4752-a95d-7cf6a925d2ad"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("b9f8539e-3d96-443d-8e6c-4cd945a9e846"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("bc9f4642-c249-440a-bd9b-5334849d0bf5"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("be524d58-1b95-4070-94a1-2163fffc680a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("c4e2c23d-618d-4c8d-b328-ada6462618d1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("c6ff4e3a-879e-4fa8-865a-926c8f3c1a19"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("c972ec18-5da7-44e2-b395-674e5762164e"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("cbd232ce-fdf2-46f6-be7c-da1f7672f666"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("cccee2a2-3c52-4b3f-9c0e-9ac4390d7275"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("cf838f66-ba5f-46ef-8eb1-d2c62665ea8e"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d1da957b-0344-409e-b754-44632ecf8771"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d3b3e4af-6c9e-4bb7-b7e8-3e55cc258587"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d9ecfd88-96c2-4a0d-af9d-331f5dbf78c7"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("df97429d-db6b-426e-98d5-52c743a9bde4"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e613df7f-1675-4b87-a8e8-c339af2fa561"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("eb62ad2a-ef9f-490e-a242-ca845dea58eb"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ec5dbbff-ab8b-4bf5-a243-95ab97e1591a"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("f072ec8f-f0c4-433d-aa56-602339d6d2d1"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("f0b3a3db-9cc7-4762-8fa5-876ecf6777d9"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("f1679c79-b854-4b1e-bdfa-a31e03692321"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("f293d589-2f97-4a42-a38c-cab28a472643"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("f3e2824b-8a63-449a-819a-9ba6f16aafcd"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("fc3e7466-7d19-4679-808e-0dec360eee5d"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("fd014d2b-d188-4ab0-94c0-8218317f66a5"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ff572f2b-965d-480d-9f1b-4d432a1f6a20"));

            migrationBuilder.DeleteData(
                table: "Prescription_Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("fff883e4-1443-4bfc-a119-7a5be750c46c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("00336c5f-13bc-47f5-8ab8-0b541759075d"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("02407ae9-9abb-4132-a5d0-52ab45ca4e8f"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("03c7a3f9-c1cf-40e6-9c27-3d7f292b4efc"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("03d0df5b-81ed-4546-ae84-b0a41a1432f7"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("040e7c24-e739-4a94-866a-bc2d3c124723"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("04525541-1b6f-4c11-84b5-a4197ebdd446"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("054740c4-0e57-4155-8b2d-9933af3295ca"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("069b7bb1-e1dc-4081-a158-0e057343b2c5"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("07169430-39db-4031-8149-455db23499a2"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("088ee268-7ab8-46fc-98f0-40729a0d21ee"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("089c7f6d-051b-41dc-8143-38b5cd5ee32e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("08e4a67f-37d6-4c50-86e4-7b0cdbd57abd"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("09ead1bd-4b68-4f67-8071-204cf5b27e04"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("0a53acba-838d-49fd-9aea-44c8d891d9fb"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("0b3b482b-cbce-4ae5-840f-7563c50bc80a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("0c5b5b0e-3c02-4cfc-a838-a02dce03dc8e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("1437b1b3-1b46-4843-900c-7aa7a21770db"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("157a5d9d-18a6-489e-b1e8-4f43721a580c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("1a205e18-f71d-4c5d-9c00-b1eafbddb266"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("1a97da5f-4454-49d3-bab2-edaca48fa121"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("1ba32a3b-74dd-4832-85e0-35331385d565"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("1f4c72e4-f06f-45a1-a3f1-ff3b0ee1b5ae"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("247abaf1-7c17-42b8-ac6d-7fffa01973a5"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("25d0896e-22fe-4d71-b259-0d9a4d8c8a7c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("27b2a906-d3b0-4637-a729-0ec97008da0f"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("27fd6a5f-6017-4d6d-b329-a90792c235ad"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("29940e01-5b2b-48c2-827a-4fe2fc0618e1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("2ef0bc7f-5c51-4042-848b-466b0d13bf01"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3055e47c-795c-487f-bfbe-77ed70739c85"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("30af5471-0988-491c-a01d-ececcdae18b5"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("333578df-a262-43fc-b80a-ab81077425f1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("340656cb-5d5c-4d61-a152-537d022e05c0"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3428d2c7-4056-40b2-92c8-0b8df5948905"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("354b7063-c781-4a99-a076-7ab20eeda98a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("37cea320-8f50-4045-b979-5be23719ace7"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3a4b046c-fb46-434a-8584-ef75d581abe7"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3af2e840-68fd-46fc-9c89-a47ab0480086"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3da0c46c-d929-4291-a5aa-302b72c61055"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("3f605963-d850-458c-86ec-3608d0ba4015"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("40566bd4-a358-4fd0-ae94-b2614b078823"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("409b7ecb-d9c7-4024-8479-5997bb5a6d89"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4377d402-eb75-4b4c-9b5e-c09dc3d72053"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("49129bda-c18c-4eaa-9cdf-d7364f356cdf"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4991a4b4-95f5-4375-9bbb-d0826461232a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4a076d24-2c27-4cc0-a11e-f4d610e80623"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4a2bbb10-2c17-4e8c-b2bf-a9b203d47c5e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4b8c74cc-c475-403f-94c3-8bde1594795c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4de98a55-5fbd-43e2-92e3-5be551857023"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("4f9abc67-04d0-4d3a-9dce-e6f231533a15"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("501db96e-c70c-4e50-8d96-c3a971ae60f2"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5154c9d6-b629-477c-8f99-9c5217d6b3c8"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("529b2705-60db-4099-9efe-69909e47bcc9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("540445a2-b63e-4dc1-ace7-5fc40088fbfd"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("55e897db-0c81-4d37-90f4-efd9dd0e783d"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5639b249-7cbf-4747-8abc-55031714eb8f"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5708e251-c58c-4462-8da0-773d160d80a6"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("577178de-3bad-44cd-928a-9d8cabe73f2e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5c21ae70-0144-462b-b737-2fbd065fb466"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5dd9cacc-c9ee-4399-ba32-8ad130f44d7b"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5df353f0-77c6-4e5d-abd9-67cb5fe07b00"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("5fb00e1a-edf2-4931-9828-2484a2dc752a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("60729a89-f9ae-4da1-8383-d1a0ea7dcfae"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6168e63c-d4e8-4216-b9d6-fa6f6509c7b1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("64536b1e-a0dd-46b8-8b4c-20588b665fbb"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("65522b8d-ff00-4129-8fb8-7671ff72bfb2"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("65d3390f-8700-42c9-b140-7497f440aba3"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("69cd35b6-01b6-4f06-9ce3-dbd34204ffb1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("69e74622-efa1-4622-b7ef-815d4ce4f3bd"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6a2077d2-4a83-4ee6-a697-905c8fc32289"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6b886ad9-7c44-4234-af24-8ec3b40b12ad"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6bb583fe-ddc6-4b0d-8202-28693e11f001"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6c01f29c-4a22-44e7-95f9-9d91591aac65"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6e5dab1f-709b-4fb8-a20b-203fa13819ba"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6e798181-3cbc-43d8-ad71-866dd51c7f81"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("6feeb480-dc2f-4f6a-bbed-0784c6b42513"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("70fd919f-9621-48ff-94ce-8d7213516cc8"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("760dd50a-cac9-473c-bb91-7c8297e3b2ea"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7841bf01-564d-46c4-aea2-681caded8d6a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7a45dc6d-a618-4043-9bb1-1eea98c6b54a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7a843f12-a7c9-4118-8a54-647b106e1131"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7b1f6155-940a-4f3d-b7e4-41d6426bfbf6"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7c25b0a9-e405-46be-8f7c-2c9a0613b8f0"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7c477b77-f569-41c3-a7b0-30f91ae92263"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("7c94bcba-ffcf-486a-bad6-95e9255d8989"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("808a3ee2-4eb3-497a-9104-d3bc470b6edf"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("80bb2a07-59e5-4529-96c7-53a9a7d2d94a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("829ad4f1-4676-473d-9fb0-e9538650bcf1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("85d4da2e-a433-491b-9e89-f541f1470de1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("88ec3c8e-21b0-4869-baa2-09a96a14cf84"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8a1c7819-0dd6-4a27-af27-f466a5fd7a26"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8a897a45-3dd1-401f-9ec1-05e12407e036"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8dc0d2c1-914e-4585-bb5b-1572ffadc6f9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8e1b6be2-c6d1-4063-a02a-055cd8570af9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8ec33c8f-bb07-4268-809a-95995fbffc6e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("8f0fe04c-e559-446d-9eb9-8a80bb64f6ef"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("93f739e2-0c3c-4840-aad1-0be4332ebb66"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("94c76367-04b0-4099-a7af-6b5e76f0156f"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("953d66ff-67df-4eed-9ab3-b3f894b82abb"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("96d2814f-0033-4b11-a49a-6c177b715a89"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("96e3d9b8-abc7-481c-bad0-e496d1b83b88"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("9886e2ba-c036-4ffc-8a49-08e5738b3051"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("9a15d447-f139-403b-9fe4-0a93be4a56ce"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("9bc0ada3-983b-4b37-a762-5bfb549b55d6"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("9fa93f74-7a30-451a-ad6d-075c8ce8a43e"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("a262e855-2a6d-479e-bd86-227334e9365b"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("a3ec2549-495e-47e8-b630-8a8e40a38dcd"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("a405656d-ec73-4c06-8df2-4ed4a51ae8c5"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("a84843c1-b61a-43c4-8f3b-d175c28b8b3b"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("a9760aad-c2f1-4bb1-a18e-1b12b0612f28"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("aa55c46d-969a-41f8-b579-f445b30f954d"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b05d34ef-3648-4410-b11d-208b474ed0b5"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b2d8ee89-4a06-4c21-96dc-63c48d9e5c03"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b52ccee7-76cd-4981-a0d5-7ddc1efd8b80"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b5b3ed84-1ca3-4cc5-be5b-cb3df61ef5e3"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b66ffee7-085e-4106-a3f5-5b723383188c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b6f318aa-06d2-443e-84d2-03353451a7cb"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("b82c4c30-a181-46b8-8c5e-1fb2d2f50989"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("bc0c22b5-1c1c-4825-b180-625bda7396f4"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("c065371d-9b4b-4838-a5ac-6ff0b8bceb93"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("c271c89c-01ec-475a-a687-03ab76bf228b"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("c5516e44-ecba-4cef-8d1c-484e6a6463a0"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("ce577728-14e6-487a-8695-8cbd902a61b6"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d11372e0-89e7-4ca5-9f9e-64d2efe602d2"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d11be0a9-6ec1-46d7-b91f-a122bbeafd21"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d27f257b-1bc5-4a65-86b1-e9234a0febc8"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d362d0a4-f95d-4a77-aee4-87df902e5ab1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d379ad38-6638-4f73-8381-28db8246a801"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d4c96a10-2c44-493d-addf-ac58330ebf61"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d6bbee74-ecd7-4542-9471-efaa9c5ad2d9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d7dd42d9-6cba-4bcd-a401-d7d3bfe853f1"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("d8a9bc56-ade0-4fa1-b45e-20c78a96c56d"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("de31d9da-896a-4755-8534-0bafdb9a1ed9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("dee7b785-2235-4bfc-822e-1f4a2557a83a"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("df579516-4a2f-4601-9769-254ee87650a9"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e04ba809-96ef-4e0e-b65c-165667c542de"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e20a64ba-2025-40b4-8bc6-addec94be519"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e21fd501-a35b-4add-a10e-84a0baf7088f"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e4a130f4-d610-44f3-8f7a-7c8dd2526e17"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e5179f81-e8c2-40f3-9897-15a52f31b067"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e576e74f-e273-401b-bca4-c04acf9b761d"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e8f1294c-5227-45d6-8291-895951ed9125"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("e928bf34-7ebf-4a46-9620-98f00b8b9b17"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("ed61e215-1491-4d22-9a17-ab557128d635"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("f50ed719-5c0b-4e85-9b36-d915bb32afae"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("f9a0c4b1-b1ce-4e64-89ee-41d51703ca89"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("f9ee52d5-0eba-45fc-bf67-aaf8ce5d1e14"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("fab2b852-a9a7-47e2-850d-c46ceed6a84c"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("fb10b511-a9e1-44e1-b7b6-413e27a65843"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("fb95e386-9763-48d2-a9a2-8e2ea108b6f7"));

            migrationBuilder.DeleteData(
                table: "Visitations",
                keyColumn: "ID",
                keyValue: new Guid("ff346b71-a58d-4e13-8d07-826c1aa01feb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("092b627b-1a39-4efe-9566-37f706ffcd29"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("0c5fce0b-bc25-496b-bb26-e7a410bb0e29"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("23bade39-5f05-45ac-80f8-608b424cc913"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("25c4dd62-2241-406d-85fc-7eb8d42453b9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("2ae1b866-04ae-4ef4-aee2-9cdedb2885b6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("31df4091-acc0-40ab-a45d-98fb86469174"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("33a33b3e-14e6-4fca-8b8f-b3002c27b683"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("3489640c-bb1b-44ab-83a1-79a049a825ab"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("3686c752-5d03-426e-bf53-129c280d52f1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("3a798297-c07b-467c-b983-639062b9853b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("41036ef3-320a-4b6a-a50a-d4f04a52601f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("47ca831f-32ba-481d-be06-0c5c9075d18f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("485e1e1c-3423-41d7-bfa0-6e12abdd3aaa"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("5652a3d2-12c5-4cfe-ac94-c1db6ae88bef"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("73271cb3-9a3a-4755-bcf4-63c770ab1274"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("80731c9c-7ce4-411d-bac0-8a50389474b3"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("8e3d5e40-1032-4321-b7f5-9b6c92f7910d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("9300dcd6-0371-4b71-b412-7240c6f1c5ba"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("9fff4a5a-8f3d-44e8-bb4c-db7f611c929d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("a2414301-62e4-4a01-99bf-47394f8d0b91"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("d96802e8-e0a0-4b8c-b7fe-44b8340b756a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("e086b229-59cd-4b2b-b073-a85c32fa80b8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("edaeb7f0-ddc2-46df-9bd6-cf071114e6c9"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("f3052283-18de-40b7-a6fc-9f5a85073ded"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "ID",
                keyValue: new Guid("fa7535e9-cced-4b41-b7ae-9cc09914a147"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("0658d7a5-3a63-4fd8-92be-78323d48333d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("066ccb51-2c1a-45c9-8c26-071594ddeb98"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("0881bac1-bd97-47fe-829e-7095f66d69a0"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("0d13452b-8b26-4560-b6ed-dd635136e782"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("14ac274d-07ae-4ab9-91f0-38ac3ab00d7d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("1ceb9127-2c3e-475a-b5cf-501b94dd7808"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("1fe87f28-915c-4a61-b3a8-2e110efe4def"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("24c88ec7-6fa0-45ad-93da-1808ccbf6d97"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("2745251c-46d2-4bf5-a84e-04768802d37b"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("280e3441-babb-4956-b625-d126930f6f2d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("28958a55-393d-4aa1-9eb4-82c91dbfdc56"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("2f31713c-4650-443e-83fc-26b6add67249"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("30a8ad38-d4c7-4ba2-8402-a00288e951a6"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("37224f72-08a6-4559-ab12-4a572529325f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("383d7fe3-21b4-48e0-b4d6-d7229dd1279d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("40335856-0f38-4a7f-9f5c-1435215356af"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("44299736-eb6a-4b66-ac86-6c5932aa334b"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("46ef0907-619c-4e9e-9d76-85a57ae262e9"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("5f569f58-320b-4570-9fbf-94d93bc1ecc2"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6dba3389-2057-439d-b5ea-81975c772a44"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("6dfa833d-fa98-4c38-9e09-a6f8483cb1a4"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("70fd3b60-2faa-459d-88d2-8bfeb89944ff"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("76decd0d-3630-4aad-9447-2d33d90c7332"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("7758402a-2259-438f-af10-2c5262d1b0f8"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("7b07f4ab-d666-4713-a4b4-53f8175da156"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("7ca51590-4c1e-4785-88a2-94b87f98b135"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("84030ce3-295a-4a5d-ac29-9bfb534e050f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("84fe8e37-472a-4723-9597-91a49edcda31"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("88eb3a1f-f6e4-40dd-8b68-e42eb885dfd8"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("8a49ab12-0b03-4555-aca3-fda84cc9b9e6"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9803a13c-cb55-442d-9bfa-e674ea87fe22"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9b2bd6d3-0da9-45e7-a2dc-f706f0391980"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9bdef98a-2baf-41bd-8563-9910d59d934d"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9e4d2b80-29f9-437b-b3b1-b676bccf615f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("9f6db193-a0d7-4bc4-bb04-48dd4a2ef3c6"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("af8ca68f-a655-4131-a595-cc0547f29d90"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("afe1843b-2134-4ea4-b4b7-d86e0b124f1c"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("c11ba176-fd9a-4d60-8f60-74f1e5bbb62a"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ca4c9f80-079c-481d-9c6d-26522267c98f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d25e56ba-97b2-479a-8f4f-b7e8e33e6b21"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d33664d4-f683-43a6-80b3-76212979e328"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("d675cbbb-eda1-4088-890c-0dec83e55736"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ddc28224-bb14-4eec-9337-5da6fafe0b74"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e1cbdd21-1c98-4444-82ed-799ad66639b3"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e2009130-7bbf-466f-a92a-fe93002fdb25"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e2a46cc9-0ae1-44b5-a9d4-2be26bf87e32"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e2e6abfa-fdd6-420f-b99a-1d328a964cbe"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e2f0386b-b9bd-4866-8910-bf797a2c415f"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e7163fa2-ec63-4f0c-907f-87abdfa94d9e"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e85ccb66-2736-4ef8-a340-388e5c2ad622"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("e9ef7615-81b6-493d-8fed-fa9e1f2fa954"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ec5604b0-1a8b-4480-9692-c6b726a35bdd"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ee918af8-48f6-4d2e-914d-515db1ffa9ab"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("ef55a6f8-7722-4af0-952c-5eb2138ed3da"));

            migrationBuilder.DeleteData(
                table: "Medicaments",
                keyColumn: "ID",
                keyValue: new Guid("fd8c7cc1-be8c-4aba-bde7-1eda0e8181b1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("051a2363-9054-4dc3-a108-f8c845bdeba7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("056e56a8-3da8-4472-b7f9-095c23d71833"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("060e6b87-19b9-450c-b3f8-b8bce9433e47"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("07a2c9f0-336c-4a87-bf1c-427ceffba480"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0894e3c6-bf19-4294-a7a6-44fabb7e53e4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("09bfad34-85cf-49ff-a63e-a03e11b4032d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0bfcf543-3355-4715-b2ad-17fba1d5a263"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0c166491-4c73-4064-93da-08284afda695"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0d928f2a-4c26-4382-96b5-2636b3b0698d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0dc2a631-4457-41f7-921d-a4444d635166"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("0ecd8487-f43a-46f8-a409-14934fe06ce0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("11b875d5-8031-4662-af6f-81a9459c0537"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("129c1071-9d4e-4cbd-9e1d-c05536a2c0e6"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("12b4e896-154c-471d-99df-2ed343213784"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("13623fcc-d7b4-4fb7-9c48-58b2015c9d82"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("156cc60f-95d4-42bd-a7f0-8bc433dad5a9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("157fca20-9e2d-4e80-b44f-7415f83471d2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("1ace7c3c-0686-46ed-a9ce-1e9282a42c1e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("1d7d3c84-2713-4914-ae91-9981ec51a936"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("1f53d9fa-a550-4086-ba2e-911a1853be0e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2012c563-324f-4db6-a478-dff4c8379690"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("213b5a60-d8a9-48f2-9341-56b7ea5fd98d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("213c336a-4f3a-4d1a-8161-11baf29cfa42"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("24e31d9e-ce06-4f29-b99e-3f80664a0fa4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("26029586-c8d2-4f17-84c5-6796078b420c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("28256e0b-cfe6-48ea-a034-8896358289ff"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2b96c93c-88aa-4a63-b61c-9f13278cc8c9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2bfc3e7c-f045-413f-95f9-f9375a338435"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2c27f180-fd4f-4bf0-b4e7-3c4f72abd8dd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("2ee20b64-f6a9-4c36-928e-2b17b18c1415"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("359f3c6a-d30b-4cfe-ade5-f0cd78f9dc52"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("374093a3-bfaa-4a73-b1c0-bb8eb0d75ba9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("37a0062c-6a08-4190-956b-a380b59ebbf7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3c319cfe-9452-4e16-826b-a4a9c012eebf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3c8d81ec-c16e-4473-ac68-c9100b222485"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3c9c7b28-e55e-40e6-9a33-c8a2da7f6b96"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3daad96f-7de7-4964-8065-056fe321eeb0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3e9143b0-5667-473a-b0de-b65984e02e5b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("3e97e0a4-cdf4-4a5b-9698-6420a9dd6770"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4072b127-2891-4ac6-8b0a-baef95b325f4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("42504898-86e2-4510-a02a-8063eb338b8a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("426356a4-e7ce-49ac-8d74-5ae599a6e116"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("43881999-d5c9-4da9-9c5a-739548f8720c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("43fd8a03-2999-4107-b5ea-e52aa8ad9684"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("44c19fc2-112f-4dc3-ad0f-3e147fa7d18d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("45732846-cb07-42d6-8bb9-72a9e28dcea0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("457a85ea-235e-46bd-9c7c-127755bfaae2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4630f1fa-8a65-4058-a8ad-824aa75c3769"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("47cff722-e4c4-4f48-9e18-6f88cd6b8f4b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4b763573-b537-4005-ab95-25c0a81a6d33"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4d263298-1780-4eb2-b7d6-b69b6f3484e9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4e098760-c8a0-4bee-9db2-16f68d02b059"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("4fa018dd-091f-481b-b905-4856e7795e63"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5080ec34-d105-477e-8be1-094862c9e390"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("511b2e18-efc3-44c7-9819-ab389144f943"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("525d056b-9c97-496b-9b1d-b42d6533c919"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("554194df-5afa-4232-b461-132182c64a1b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("55e0e6e5-eae4-454a-9457-7d1baedde998"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5ab15f1c-3352-40e6-918d-51d69903dba4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5ba3b2ea-74c9-4581-8468-4831a3365be1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5c9b1c64-1c30-4013-9183-5a9e970b6349"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5d6136ba-9604-47f8-882a-0913acc43e4b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5e3ea46e-d8d7-41d7-9556-6313db03b115"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("5f3e9730-5372-4711-a812-d467b1cb144b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("634f3997-7f5c-49dc-a4ef-e4072fcc8f56"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("64ef5204-68fa-4f85-81b3-89fdfb01a6c1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("678e63c7-061d-45da-b43c-f3ca58b9b735"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6a2e13be-4a7e-4475-ade9-837eb81690d3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6bdc0ab5-6380-49f4-8e58-6b8380c8304c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6c98aaee-4c17-43fd-9558-13228f4988c9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6cc4cf48-e085-434f-a862-7362f18110dd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("6df27f42-990d-4e8b-b3a8-ce14647b21a1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("71dab545-e32d-40a7-ad88-cf613e24af80"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("71e13137-4234-4351-8988-f6cc67a6bf1b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("726b16e7-efd2-439e-af51-c7db5c0767ef"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7330ed8d-d774-4a6c-a165-8c43c31bb8b4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("744b7b47-c075-4158-81ba-a8dd8b76c4ee"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("756247ae-bd2e-4300-a8b9-531f88248ac1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("762411cc-845f-4172-8c18-161a49f5d9c8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7821c1ab-2cbe-42b8-a861-4f3840382a16"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("78cb0444-844f-49f7-a5cc-dc17fe50117b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("790a3927-f12e-42fe-94e0-2d22da9e5bd5"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("798f293d-6f50-47f3-9a15-88a2945a4ee2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("79b8948c-0f6e-4350-8bae-99666feb169d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7a0a4358-5130-49f3-badf-b4bbeed382cf"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7c2ee55f-9f37-4175-a1fe-d4c2c41aa853"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7c994242-8c36-4776-84cd-ca241ca48dd2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7da3faea-318b-4ad4-a66d-62be34dfd6bc"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7e4dd588-b35e-4477-848f-75b082e57c25"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("7efa7a93-621c-438b-aa92-e547ea51a297"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("80105bf0-db71-4b11-a006-87ee3449b929"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("81a9284b-7e16-4a66-8182-2e8932483261"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("81c14a06-36c0-4b3e-8a34-ae99e5b61e97"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8352a3b5-4933-49f6-904e-be1daf133d75"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("854e328c-d95a-44af-8ede-110adde91323"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("85d0b25c-94c6-41d9-a1f4-4f83ff2d93fa"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8675aa5b-df90-468d-b451-120d3d5a332d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("89d37238-1f2f-4d0b-a737-dc6f46d0993f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("89f89cae-a29d-4f16-91ca-ffeb950136d8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8b5e0f4b-9e6f-436b-bc22-2b24960608f0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("8fd7ece0-d65b-4e1c-b92d-354fa80c633a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("90568c68-f32a-429d-a3f2-d57a64d510f0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("92ed03e2-7197-4767-b987-b50c1ad188b4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("950b48d1-e21b-46cb-b479-07ca0c9255d7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("95514ec5-6eac-45c9-a340-75dea1c7695f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("96a9702a-fb6d-45b4-a36c-377141fec3e2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("993c8327-b902-4c8f-a8fc-b65b22ea425d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("9bdbbe5e-61d1-4100-a6c1-96ad062c179d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("9bfb10f7-5a46-41ff-a465-574158ced91f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a0bebdff-3dce-4b8b-b66e-e7375927ca2c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a0cf1958-6b82-47cb-aca9-49f9dbe6da77"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a1209db0-3aae-4123-ae46-7450420fd136"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("a8a84041-4148-4bff-a2fa-6e8ed8ef73bd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ac9b1803-f789-4bba-8ade-66cf62191ff3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("aeccd29e-a493-4d9b-a3c6-21053fd3f9a8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("aed6c6eb-05b3-417f-9675-cc7035590569"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b18a63af-e07f-4406-bc28-6ced50da67de"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b29a6eee-c316-46bf-b2c9-4e521554b08b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b2d87fd0-6e53-421f-8d6f-1f4c5cbd786c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b39605a4-8057-46d3-975b-2c79d1e7ea06"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b52bd5e3-2c41-4040-b0a9-82b294ecbb5c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b52d3ce3-9aa7-4a23-9236-14f1179dd645"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b589a934-628a-45fb-813e-e75938a11641"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b730576a-5145-474a-9539-4254a2a938fb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b8db88d0-b2aa-4f6b-9ac8-5011f7afc548"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("b9b4b1fd-0312-413f-b8ea-5bbf54fa844f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("bf705702-7ddf-460e-af20-5b0e876a53b0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("c39a4212-ddb9-497d-bd59-03788900ad2b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("c67ccc8b-9959-4a0e-816a-85dcee495f4a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("c6cac74f-61ce-46f1-8519-2c920c3c7854"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ca0ae93b-5168-4b28-bdef-df3ae8ad24a1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("cda28c2f-338d-4dc0-9c5c-049f6929b4e6"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d2241a1e-6ada-4c13-9e4a-1756f98640da"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d2d70fb2-ca50-4d2b-bf27-57824ac87347"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d453349a-cf15-45a7-ac65-50c83b5b20ef"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d78ae6ce-ecfd-4bb6-a6da-431d4169e6e4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d9297d5c-74f9-4326-8753-06611ccb364b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("d9a98cef-b581-4017-9172-b8bd03707337"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("da3d6f5b-c8a4-4310-b684-86061fc826b3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("db633c4e-1db7-4da2-9b8f-8b9bb0fb2d3f"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("dc2fe4eb-9a75-40d7-925c-3730e81acbd8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("dca75398-c29e-48c8-88cc-87770163b4f8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("de2bfbf4-5c54-4f9f-98a4-0d99bed2725e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("de6bd080-74fa-4b79-946e-37c0cca85171"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e0263431-c820-4c52-b3f5-5a7e70f3eca7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e0be58e2-d7d1-46aa-a9e4-42dbcfc7053c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("e5888cb2-cc6a-428e-bc51-34d71518af07"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ea990230-ebd9-4035-b5cc-7689c339ea2e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ee88c0b5-841c-4e6e-82b7-b549b5765d45"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("ee952a2e-d590-47c4-b520-e4d5f12c1b46"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f083cb79-831c-4d55-acc4-ce122564dcd2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f1aa4a6b-05a6-4a5f-926e-3ede3ded1935"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f237bc17-bb36-4d96-9444-eefa69d519d2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f48032f1-313e-4492-b7e5-6fddb3085109"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f4a7d6fc-4dec-4b34-a4ed-62b7b2d1d856"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("f850772c-69f3-4df5-ac20-20de8872499a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("fa24756e-9fd9-4a83-854f-6d87b77d2a92"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "ID",
                keyValue: new Guid("fbf90cc0-3d57-4714-acb4-e4d94442f049"));
        }
    }
}

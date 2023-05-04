using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sales_Management_API.Migrations
{
    /// <inheritdoc />
    public partial class Initial_on_SMM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("08c63d8e-88ec-4ea2-b2f6-9ce1fb25a5df"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("11cbd6ff-7630-4d73-b7a0-2095e7a0c7f8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2a96ba46-0a4a-4db0-8dc5-353bd4085d77"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2b11cbd2-6551-4450-a3c9-96fa8d25dc9e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2b52e55b-b7fe-4cab-9492-1e9472868478"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3339d9b6-deb0-4d49-a75b-316d25757fab"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3dc41bee-189e-46b4-b1fd-a202a5e70633"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("44e881da-6816-4edb-b454-cc2cab92281d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4bd7a06c-6889-425a-8b17-c731e0aa4f46"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5086139d-4320-451a-b41b-d57d007b1ece"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5b40a833-ced1-4a76-af6c-cd7145d7032e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5c3db425-e518-45cb-9bc8-6d3db3bcdf1b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("64ca9622-6522-4de6-80da-30bdeba0fdae"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("65e975a5-d4a2-4c2b-9836-e3c8365e7e84"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7be294eb-e299-41ef-8da4-0be8fd040db1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("899e7917-4083-4944-9925-74d441ef76c5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("8e90a947-3b31-4a8c-9624-02b3032065b8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b00d24fc-3156-4fbd-8343-087df4293491"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b3ee5fe8-9e91-45a7-b012-5352aa89315e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b46e30c1-634d-414b-bb28-a50e00dc35fe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b5af5f8a-a3e0-447d-98ab-7547c10b7727"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bcf10a47-d1f9-4078-b0ea-cccb081162c7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c80c9ee1-86e9-455a-ba3a-e1af307e0e56"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("cad8a276-665a-42fa-9ec6-e5ca2c7e9d5a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("dcbb8492-2d91-4b70-9f26-ad445370482a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e2186b15-6e18-46b5-96f7-1bb1e87ee285"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e61eb903-1afa-4f56-b6e5-89930ffca51e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e655d9cd-917d-45f1-a185-f6deda22ebe4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("eac914af-7f71-4b23-8c57-d9f64246b585"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("eb83e2ba-09b4-418c-9e4c-f2200c6f8328"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("fd844061-c2b7-4eaa-9ae2-9f1adf3ba316"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0274b5ed-db1c-436e-80ed-f1f99a895cca"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0296fcf0-a37a-4fca-90b9-5eeb6c753fc4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("042d3886-f264-4d55-acab-b91d5f846d54"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0c4df2ba-0555-480f-a5e3-7f0fc575119f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("1625108a-6937-4b80-96be-a790e08fc4da"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("1ecae5fb-d2bf-4bc8-adfb-03154a03f6c6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("217ea179-d9a1-4f62-bfc6-becb0124daee"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("26b48feb-2f6f-4dc5-82dc-4e487aaeec92"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2f7fcd57-50cd-452a-beb0-d36c92d36e29"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2ffbe657-6cd2-455b-8ebd-56fa54371b8c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("358ec356-8c24-4de0-a040-f40185713ea0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3830ee40-497b-4e6c-b6ed-10255293212e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("39d3e759-5f9c-4c1c-8bb3-fac84f18c90c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("503df924-531c-42a2-b250-90ae3c5fcf9b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("53440321-8b7b-4d0d-8a0b-6c7305ef0fbf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("57e45f70-c65f-448c-89c3-50d3ec16f9a2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5f91fd92-2f47-4a59-b8d6-6f4a9f388b1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("60793dfb-2aa7-436c-83b8-236d05df8275"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("62efee04-029f-4f57-8449-897a9ce58b82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("662bb844-2803-4ffe-ad4d-59f2a0f2e913"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6be52a56-4c7d-447d-a656-82b34bbb39ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6f903cd3-5f61-4d32-881b-7a480b625352"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("723a39f2-459b-43b5-99e8-fd800a051a3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7667bfa1-9d94-43ee-bcd6-3863322a107e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7743928e-beec-4726-8c87-0bea36f52007"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7be2d4d6-fbed-421f-8729-c858de9cac7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7e5c95b1-8e7d-4128-a674-fcad82b91abb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("84cde055-8d1d-4ab0-bcc4-0d6fc91f38f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("952d546b-b734-47a5-95ae-b1e6bbcfcfbd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9b4388aa-a64d-4afd-a7d6-65a8b6338dc3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a0f36f68-f732-4f88-97bf-306746c9ac18"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a612ccb1-70ce-42ad-89d8-36ed204ff2b3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a7831ff4-f926-4357-a8b0-0848ef770ab2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a8bcbbe9-69c1-481a-97af-b38d8c55823b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a92d0917-eb06-46a6-808f-da2158554fb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("adc9426d-3431-424d-9d5e-8c4b1bbdbb86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("af91b910-4037-41df-b297-c988bf857c01"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b9a5b797-4e3c-4e5e-80a4-367f86151dd0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b9e99852-9043-448a-bcd5-17a2d5ff85cf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bf85ae8e-8c29-49e8-b562-9b412e673b09"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c3ae9cd1-ee0f-4a5c-a920-76eb82f9fc1e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c4df4dc4-70dd-459c-90a3-2d42a0e4ff67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c5bab8ae-8059-4e60-84ca-72cf5b0d547a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d3cff0b4-9f82-400e-b852-b7d28fe89bc8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d6d45cbf-6a48-426b-b38a-fcd6553c5e1f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d70b6bd0-b634-492d-88df-9e06cfbcf3ef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d963768d-74cc-4c23-9758-f7c973ecf8ad"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("daec52e1-0a40-4ec5-884a-117ebefd420c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("dbee5958-2fc3-41e6-97f8-28998dfe3266"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("dee2236b-29a5-4261-92d3-be5cf78c7526"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e50f8e70-c57c-434d-a7a2-97226f4ec467"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("eaf0f09e-dad3-45e7-8930-0ddab618e956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ec729070-2ad2-4acf-ba8d-aadc0bdf62bf"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ed01c539-c8cb-43bd-95a5-b17550c2ca37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ee620fd1-a634-4180-9558-ccfd1427a795"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ff16214b-9056-4f57-a368-7629095d77ed"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("03997ad5-9715-4fd2-adb9-cfc616383d0d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("085d908c-8655-4f62-9b90-8b6a4109e1c0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("2fd9ea37-b358-4c8f-9a06-51585934730e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("345f3cc4-9989-415c-90ad-18474298a5cb"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("42b8fff8-9de7-4905-bff2-1c5fe6220e6a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("46a7da08-7fc8-4ff1-8854-810d1f07a372"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("4d2fa749-bd6b-470a-bafe-39a74491f6af"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("55246ac8-6df2-4279-a423-4a8e8958ac08"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("641fe2b8-5dfc-4e98-b63b-4fd8a8af45ad"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("6d437a86-f9e3-4d5e-ac4a-98ee97ce6381"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("754ecd26-4123-4e7e-97a3-77a8e61c1ad2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("75ccfc43-16ed-46b6-bb6b-8d3faa15ce08"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("80c2a2c9-8307-4ccd-92f3-56bbee6af839"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("8fcbe916-8c59-48fe-889c-b7f5aab8a5c5"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("91c3fec7-a228-4f8a-813d-5dfa25a07434"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("99fa8941-6703-4418-9108-fcf05389a034"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("a4962aa1-3eb5-4d6c-8e6f-33d58aaf8541"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("c5fb9b2d-e619-420c-a8de-fc9585d96d73"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("c64ef65f-eaea-4b76-bfbc-1d283ced608d"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("db85a5d6-c664-408b-8a17-e941695d458e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("e6f26733-fa21-4ea8-b202-e670124ef81b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("e7e1dbbe-9466-4d36-afa4-e8b7132b46ef"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("e8d143bd-c11e-4980-9b7a-27983f84058e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("e9bf91ca-abb9-48d0-bf49-11075f6b0476"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("f4ae4c2f-ff28-47c9-90bf-025365ed821d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("0751c19c-dfd7-4570-8613-84733ec28449"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("09d27f7b-2556-44cf-8947-64e2b33d8c2d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("0f3763de-8774-4406-a832-7ce5fc8d73e4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("1b2e1169-4449-4668-8ae9-4e4e412c1322"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("2bed4197-33d0-4caa-9ce0-a3599bb9b3a7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("2e8cb047-c922-4a2e-a552-ef22f800ce28"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("35e983f7-b551-4833-8b45-e96f178d44e5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("38ee9d87-6f1d-4cbc-97b8-87024796c8cf"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("38fefa72-2135-43aa-a01f-865e8c2ad0fd"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("3e4e2b5a-219d-4c15-86ed-8ebd355c5019"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("565b0562-49d5-43b4-9649-a10489dfb1a7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("5681b108-289f-4147-a7ff-c6f0c372f255"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("5fc33523-d212-4fcb-8a3c-c8f5b6fed999"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("639990b1-38c1-4746-8b09-f97157984fd9"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("680c2d94-b0ec-4040-b558-32b56f0eb1d5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("6de84fd8-04ae-4b48-bf03-43342aa8058d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7859ac9a-66b1-4dac-8cb1-3e27e92b3e9a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7dacf76a-a1a3-4c31-a3d0-5e0395cbe538"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7dcd0e9f-6608-4450-b6fb-1e1ef32332d7"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7ddf2cf6-095c-4c5c-9739-9093b2699dbe"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7f66d2c6-29ce-42b5-bdf0-dd699863cdfb"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("9459ab24-9949-4aa3-b2e9-206345e812d0"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("a15a04b7-7189-4fbb-a5ba-fa112d5a925e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("a549ad99-74b4-4fe0-9971-c7f611bbe5ba"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("cb428e7f-2688-4a0b-beba-eefa98f74ad1"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("d7d12601-6297-44a8-b8b6-72b0dfaf2da3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("e2c18bf5-b741-4085-b577-d0e8471b653d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("e367008c-d5a5-49ca-b54b-3e3e21d9e94c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("e58a1188-18d4-4e7c-81f2-ace04272ab16"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("ed2ee2d1-86b4-47e1-b504-be3558e20d79"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f4692d14-1c95-4cd6-b135-0442665833c5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("fba93935-21a7-489b-92c3-6e55fb411b19"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0204c9c5-110d-4575-a7b5-26900814e248"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("05e516c5-d7b6-4cdc-928b-d66881482b0c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("09db64f2-42da-4dfc-8e26-8fb9c93c03fa"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0b096a5a-166a-4c69-b7a3-1d116d52c02c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0b47859c-9506-48d1-9d9c-f02f4f43d686"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1cf311c6-7a11-4815-8059-9bdf4ff37579"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("206602e7-b6f6-43e5-8bb8-d18e0685f319"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("2bf6b142-027b-48d3-a1c7-43b1d541a721"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("308853c2-3060-42a0-bb2c-b528d11361c9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("3fd687a6-18bd-4805-bdfc-2218d2d01108"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("46cfcedf-8689-4eda-ab8c-b6e530f91227"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("490f9f51-76c1-4fae-bd3b-92b82c71351f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("7cf9ec82-52e5-44aa-bdae-83bdd2e70791"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("828ed59f-7550-43d4-968f-a6bda1e0f829"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("8af23ad1-078d-47a6-b24b-9ca35c724e29"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("9a5cef5f-c345-4bbc-98ef-fdf7fee6f0d7"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("afa1d854-a3f6-468e-8374-ab99f9c3aca4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e60e17e0-7eb3-49b0-a2aa-ce9191f073fe"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f8fd1c91-bcbd-48bd-8df7-3ce118c7164a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("153fb67f-0cf9-4bbb-a880-49ec2551e16f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2a810134-4381-4a1c-80a0-ed0db9343679"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3d885358-6c71-46ff-8f77-2783c06a91f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3f75ed22-2c21-49b6-872e-f56aca923794"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("43864080-b9a9-4dc8-9e26-d1442c450779"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("4dc89d24-4057-48ff-be05-3d45d31718ac"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5c365456-f233-4f94-8157-661200aea27c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6d65f6a1-a72f-4594-9d86-3f3a009c97fb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7246c8ac-8a2e-4192-acb5-edf34139f28e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7d059e04-124e-4ebd-b57b-128d2f4d242e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("83b51db4-ee8a-439d-8da3-3480a281c4c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("90aa5c2e-c45c-49a7-8826-2770a8e80e16"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9ca9299c-a910-464f-a8d0-766d7c0ded86"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a1fa29e1-5764-4e9f-a662-91008f1de8c2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ab64c6b7-c7b6-4d19-b2c0-007d3d338449"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("abd7447f-6860-490e-94d7-ae92bc779ef0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("aee9f00e-5b74-4144-aab9-880e590c4e7b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ce60e88d-6126-44f1-bc10-18735d2e9f0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ee288e2a-833b-4ca6-8e53-139a87942e83"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("11bf6f33-b5a8-40bf-8702-fc7530382512"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("1fcd6652-ff1a-4bab-8482-c0669102b61f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("3704073d-3d2c-4360-945c-a81c4028f592"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("49ea3eff-c22a-41e4-9276-5d95a82de59d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("54ab24a5-109a-47f5-9803-b08289d9871e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("5e7d2f14-8a27-421b-87d6-68f8cea52752"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7c62f168-4277-473e-94ec-db522622594d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("a3c73526-c96e-4e5d-b8bd-6cc392eba74d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("abcc2e41-d8b5-47a8-9b89-d4265fbbb9c3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("b8851927-1480-414b-93d1-c7580130b692"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("b9638634-db3b-48ee-915a-399de5059305"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("bfec6453-922f-4f13-9033-96387c951a7e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("c86dbd47-d43d-4e11-8f83-934042b8a404"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("cb0cf49d-5cda-41d2-aaeb-3f78caeffcce"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("cd8ae90f-a87c-4553-bc03-7f903d957b5c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("d22bf60e-ace9-4a0f-a798-0d0be984d5d8"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("edd14fc6-2103-4c14-b89a-75a4959cccea"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f86e8f1b-3082-474c-88ce-7dd0ea2ed064"));

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "ID", "Customers_email", "Customers_title" },
                values: new object[,]
                {
                    { new Guid("00d01742-8351-47ad-8ab5-8e9649676d57"), "MaeQuitzon96@gmail.com", "Mae Quitzon" },
                    { new Guid("01b7f83c-356b-434a-96da-73f47cbb6640"), "JerryUllrich.Block@gmail.com", "Jerry Ullrich" },
                    { new Guid("03165422-c72a-43d1-96ef-264175fa3ea2"), "PaulaHaley_Kuhlman@yahoo.com", "Paula Haley" },
                    { new Guid("07e5efac-cb1e-4b6e-9a6e-bb88bb2352a0"), "CarrieThompson16@yahoo.com", "Carrie Thompson" },
                    { new Guid("0b2f96e8-2081-4cdd-ac4f-90e10f0cd9db"), "EssieRussel99@gmail.com", "Essie Russel" },
                    { new Guid("1021c112-fdc4-40b2-a81c-9acc0efe70cf"), "DominicLeffler_Hintz@gmail.com", "Dominic Leffler" },
                    { new Guid("17558074-c828-429a-bb98-ece3b305d767"), "VanYundt.Pagac@hotmail.com", "Van Yundt" },
                    { new Guid("1b205faa-9500-406e-baf6-871f73b8f6af"), "YolandaWilderman.Wolf@gmail.com", "Yolanda Wilderman" },
                    { new Guid("218be20c-b7b0-4b18-b687-c6efbfe86764"), "LyndaZemlak.Reinger@yahoo.com", "Lynda Zemlak" },
                    { new Guid("26b631fd-c51f-4511-a70a-dbd7653cf265"), "MarjorieKoelpin_Gottlieb20@gmail.com", "Marjorie Koelpin" },
                    { new Guid("351a6f7d-4c90-4240-9126-a62e86154faf"), "FredCarroll.Brekke@yahoo.com", "Fred Carroll" },
                    { new Guid("37469122-6090-45bb-8654-00f17564b09a"), "RonHills.Schinner@yahoo.com", "Ron Hills" },
                    { new Guid("42609502-f0bf-47a4-ba6e-57be0b15b15c"), "MalcolmBrakus_Metz68@yahoo.com", "Malcolm Brakus" },
                    { new Guid("43a0f2e9-a01f-44a0-af76-9505621dbfd0"), "WendellBreitenberg69@yahoo.com", "Wendell Breitenberg" },
                    { new Guid("4497b661-019e-4b12-bffe-35aca5310964"), "RomanQuigley54@gmail.com", "Roman Quigley" },
                    { new Guid("47444fd5-e960-4f96-a1f3-fe3feb1211de"), "JavierCronin.Corkery@hotmail.com", "Javier Cronin" },
                    { new Guid("491d4a4f-e44f-473e-ae46-6908abcd06cc"), "SarahOkuneva81@yahoo.com", "Sarah Okuneva" },
                    { new Guid("496f0bc5-8f88-4c93-941e-aa9d76f2cf87"), "JordanDenesik.Torp98@hotmail.com", "Jordan Denesik" },
                    { new Guid("4defc4c5-fbe6-4b88-b765-8173911dcaa5"), "RyanDeckow.Kunde93@hotmail.com", "Ryan Deckow" },
                    { new Guid("4f29b645-641f-49df-aab5-cabab45bca8b"), "BobbieMacGyver.Towne29@hotmail.com", "Bobbie MacGyver" },
                    { new Guid("50130165-cdec-484f-ba81-ae14159bd229"), "ElviraSchaden_Jacobi@yahoo.com", "Elvira Schaden" },
                    { new Guid("51ac2ef7-63a6-47fd-bd11-e0b59be603bd"), "AnitaHand58@gmail.com", "Anita Hand" },
                    { new Guid("5d7936d0-1d6f-483d-9ecf-8f7d5d197d54"), "KellyKemmer_Koelpin20@gmail.com", "Kelly Kemmer" },
                    { new Guid("64df48d9-cb38-42bb-945e-a392a1eea8a2"), "DomingoStark.Ullrich@gmail.com", "Domingo Stark" },
                    { new Guid("66f4cac8-03ce-40aa-acf8-36ec1c23f07e"), "NaomiNader_Becker10@gmail.com", "Naomi Nader" },
                    { new Guid("6b7c6ca7-c8b6-465d-be98-b34e860e1e70"), "MichelleYost.Hane39@yahoo.com", "Michelle Yost" },
                    { new Guid("75d4fdf2-25f3-4d11-8b43-ba7d5aff6ff9"), "CeliaFlatley.Lesch@gmail.com", "Celia Flatley" },
                    { new Guid("87935438-385e-44e2-8aa6-968addf83bf8"), "CeliaRice_Collier@hotmail.com", "Celia Rice" },
                    { new Guid("87eba4aa-2fb3-4fb4-9df2-3c1180995756"), "BeverlyAbbott.Corkery@yahoo.com", "Beverly Abbott" },
                    { new Guid("968e87d1-7328-482b-91f1-8a594b1b220d"), "ShaneKoepp_Bergstrom54@gmail.com", "Shane Koepp" },
                    { new Guid("a25fd341-90dc-4bda-94f2-d5aaa1698a29"), "JesusHeidenreich25@gmail.com", "Jesus Heidenreich" },
                    { new Guid("a92c4f5f-42c2-4de7-9fac-2b3c5da6c74b"), "SpencerQuigley.Okuneva@yahoo.com", "Spencer Quigley" },
                    { new Guid("b3603f61-fde8-4ce6-ad58-320d032b8fbc"), "JoshuaAnkunding_Steuber6@yahoo.com", "Joshua Ankunding" },
                    { new Guid("bd10acfc-0cd0-4797-ae89-65b4683baebb"), "FredrickQuigley98@gmail.com", "Fredrick Quigley" },
                    { new Guid("bed6da71-b625-4a9e-867f-f6343fd4b64b"), "TylerChamplin_Prohaska@hotmail.com", "Tyler Champlin" },
                    { new Guid("bf457565-a1ef-445d-9a6a-7d807ca26032"), "ArleneDare14@hotmail.com", "Arlene Dare" },
                    { new Guid("bf6aa289-bc71-4845-a4e9-382b8b4560bc"), "KatieJacobi18@gmail.com", "Katie Jacobi" },
                    { new Guid("c4bcf52c-c9a5-4f86-bc35-9f7a0d06cce9"), "ClaireHessel71@gmail.com", "Claire Hessel" },
                    { new Guid("c604b0ad-c864-4384-90d3-88b7e21f1ab4"), "HenriettaMonahan_Kohler@hotmail.com", "Henrietta Monahan" },
                    { new Guid("c9dc9e45-bd46-48e9-be0a-2c8069085ec3"), "IsaacCole.Wunsch94@yahoo.com", "Isaac Cole" },
                    { new Guid("cd37307e-1b7c-42f6-ac22-97f909950c68"), "PabloWiza.Kuvalis21@gmail.com", "Pablo Wiza" },
                    { new Guid("d568bfb7-b390-4239-a10a-08166f33cb2f"), "TinaBailey_Collins@yahoo.com", "Tina Bailey" },
                    { new Guid("d645df59-a06b-42c4-871a-46a7c5cdc149"), "TiffanyWolf_Nolan@hotmail.com", "Tiffany Wolf" },
                    { new Guid("db0c50c2-f678-4701-bc49-84b9212ee388"), "BerthaHomenick_Towne@yahoo.com", "Bertha Homenick" },
                    { new Guid("db27de94-69d3-4643-b7b8-6898ce55c368"), "MartyDach87@yahoo.com", "Marty Dach" },
                    { new Guid("dd1a93c2-ae08-4505-985b-21dc287285b9"), "CorneliusMcLaughlin87@hotmail.com", "Cornelius McLaughlin" },
                    { new Guid("e3589655-e59a-4be2-b0fb-0aaae5b15c15"), "NoahVandervort.Kessler39@hotmail.com", "Noah Vandervort" },
                    { new Guid("ea485e3e-fa11-4cca-9de9-c8ce34aeb60d"), "RossRohan17@yahoo.com", "Ross Rohan" },
                    { new Guid("f2d799b3-2f6e-4dc2-8cad-70f57ae257f1"), "RochelleAbernathy.Cormier94@yahoo.com", "Rochelle Abernathy" },
                    { new Guid("fa167022-bf3c-4de1-ac21-9fc39cbfb6e4"), "RoderickLangosh_Leuschke@gmail.com", "Roderick Langosh" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "Products_count", "Products_title" },
                values: new object[,]
                {
                    { new Guid("069b08b2-e2ee-48a6-9a29-c8f5175920f1"), 1633929147, "Pizza" },
                    { new Guid("082b3002-d0b1-4457-9283-557ae9aaad39"), 280381853, "Chips" },
                    { new Guid("09e3a883-5164-46fb-99df-62edbfded4e5"), -2002745498, "Car" },
                    { new Guid("0a1ed57b-36ff-4811-a06b-7498e556f48a"), -1207088053, "Chair" },
                    { new Guid("0e9d959c-d8a9-4f5a-8422-058379169332"), -1908269884, "Chicken" },
                    { new Guid("0f1a8df7-9cdf-4d18-8a31-d577e1f37092"), -1304240749, "Mouse" },
                    { new Guid("0f90083f-8e89-4c50-bedc-32dd0d502ef3"), 1269710412, "Tuna" },
                    { new Guid("15b490df-5151-4606-8726-4fcd5856fe95"), -298960636, "Bacon" },
                    { new Guid("20f49066-7313-4df7-9243-8c51dd43fb78"), 238911479, "Table" },
                    { new Guid("23410fd0-0507-4d46-8dba-31b4a67ed5b6"), 1983805216, "Tuna" },
                    { new Guid("25890d1a-e294-407e-b9f8-0f7f60175bb3"), 687268844, "Sausages" },
                    { new Guid("2bf8843e-91b7-466b-9c8f-4c58938cfd2b"), -128022188, "Tuna" },
                    { new Guid("32def40c-7efa-4dea-b461-2b97cedc61f8"), 481484116, "Table" },
                    { new Guid("355268e9-2e10-4962-8b19-527433dde974"), 2119387760, "Chair" },
                    { new Guid("36ee85d9-7fac-45c7-b1da-f0554d1baae4"), -1129472336, "Hat" },
                    { new Guid("3957b5ae-502d-4800-a59d-f3a2533f9c4f"), -688958141, "Ball" },
                    { new Guid("3a814dee-218a-4111-ac8e-1b598fd86e78"), -850393464, "Chicken" },
                    { new Guid("404f0a2c-1f73-4616-bf9c-0130c0e17cb1"), -1964731876, "Chair" },
                    { new Guid("43500789-1762-4aa0-8814-8c488d08c246"), 1781512953, "Chips" },
                    { new Guid("45dce803-dd24-4685-92e8-a583c72dbf6f"), -1704187814, "Chicken" },
                    { new Guid("5489549c-20df-4678-90a5-f63f0470de67"), 126809936, "Fish" },
                    { new Guid("582443c4-29a7-4312-b9e2-45636161b21a"), -1396559232, "Hat" },
                    { new Guid("582d1eef-5607-415d-90cc-0f56e4ace143"), -1242383638, "Ball" },
                    { new Guid("5a643e83-fd7e-473f-8c08-e5194ef5bf64"), 1125412998, "Chair" },
                    { new Guid("5cd730f2-5644-4d2f-a9c2-fae1f02d9b5b"), -1395773151, "Pizza" },
                    { new Guid("5fa0e79b-d281-42af-b119-54f4af2b39fc"), 760145034, "Pizza" },
                    { new Guid("62c28bda-9fad-4b14-9e83-551e514721fa"), 999899204, "Computer" },
                    { new Guid("62f0aa9b-0a50-44d9-96a5-91299e9711eb"), -1659405439, "Salad" },
                    { new Guid("66070e34-254a-433f-9140-008ba57b7e17"), -613607897, "Pants" },
                    { new Guid("6681cdb3-4ea5-4c3b-8074-645d0170ccf6"), 1631460800, "Cheese" },
                    { new Guid("6f0ede23-2ea4-4a20-9ee0-390516c1bcf8"), 161973047, "Keyboard" },
                    { new Guid("7098bb9c-24f3-4853-b98c-df9605b13159"), -1622206785, "Pizza" },
                    { new Guid("762d7727-6e74-4fac-af58-238fce12e7c8"), 1573782003, "Bike" },
                    { new Guid("76b5762a-d9d8-46fa-b577-7122be105538"), 300905242, "Gloves" },
                    { new Guid("77c80fcc-6a6e-4309-a08e-d279d9e9db7f"), 329236569, "Ball" },
                    { new Guid("80736a53-31c0-4a74-a10a-671c115f21e8"), -1362200678, "Soap" },
                    { new Guid("85084da4-0fa7-4a27-8e91-278d4c6fa695"), 706291114, "Keyboard" },
                    { new Guid("88ee08e4-882f-434e-ae9e-218b0c524555"), 1901581071, "Shoes" },
                    { new Guid("8fdfe323-3b58-4aad-9d40-8d75dce4b337"), 818479549, "Cheese" },
                    { new Guid("9a26c330-a991-416d-9d9d-6a9f2ebdf29c"), -299438967, "Pants" },
                    { new Guid("9f5a4214-ad94-4c9e-856c-e576d59f0e95"), 263080548, "Sausages" },
                    { new Guid("a2b32fdc-7c4c-444e-8e64-c3c1ac6c9fc0"), 909366214, "Mouse" },
                    { new Guid("a6c0caa7-19a2-4b3f-81e8-f86ee550ea7f"), -1529256966, "Chicken" },
                    { new Guid("aaff7576-58f4-435f-a879-b3424f8bbfef"), -496349590, "Gloves" },
                    { new Guid("af7faabc-0392-4c94-b92c-77e48acb26fa"), 1761144751, "Ball" },
                    { new Guid("b1f6ea8d-7b53-4aa4-a1c6-389e0851ee43"), -823995443, "Table" },
                    { new Guid("b4bea53e-6568-4307-ac57-8b5e25349445"), 1467206709, "Soap" },
                    { new Guid("b92fa980-1a4c-42f5-bdc4-d4b5d506fa91"), -369356230, "Gloves" },
                    { new Guid("b98083c5-83ed-4d4c-9133-9c3ee4a7f344"), 375451154, "Bike" },
                    { new Guid("bc11728c-2087-44bc-920b-48bf983a07ab"), -434481421, "Shoes" },
                    { new Guid("bdd70a88-f6ee-4010-8430-9da264264010"), -66809624, "Gloves" },
                    { new Guid("be883979-e93a-479d-86f3-c7491d8269be"), 1669219602, "Mouse" },
                    { new Guid("bed4c761-a4f9-4338-9663-28f71a471496"), 2081061119, "Pants" },
                    { new Guid("bf7465c0-b88d-46c8-a1e0-bc531ec920bb"), -1319913239, "Gloves" },
                    { new Guid("c09afc71-098a-4db1-a2d3-14f745c98106"), -1496745863, "Chips" },
                    { new Guid("c2a3dfd1-17a6-4e8c-a2d0-83da33b8efa2"), -1027471418, "Chicken" },
                    { new Guid("c49f8b6d-1e8b-4846-a13e-678190526143"), 794400859, "Tuna" },
                    { new Guid("ca7db7b1-ae7e-4554-8dfd-d70d89d51aa8"), -1333316584, "Towels" },
                    { new Guid("cc5aa489-ebd2-4dcf-b0da-ee7285b38065"), 1501621993, "Salad" },
                    { new Guid("cd069cdf-ba4d-4a6e-9124-274d8ee74161"), -132002792, "Shirt" },
                    { new Guid("d0c30186-3c37-431d-98fb-2db628b3704f"), 429515567, "Fish" },
                    { new Guid("d1303b9a-c552-4a6e-9e19-894b69a827ea"), -429256004, "Pizza" },
                    { new Guid("d4ade33c-5dfb-449b-9535-e110c2ada9cd"), -620942255, "Bacon" },
                    { new Guid("d884d368-9d16-45a8-a693-29f4ab0715a7"), -2074005789, "Table" },
                    { new Guid("dd0ed904-2462-4514-ad11-76f358c849a9"), -88273259, "Fish" },
                    { new Guid("e1f6c0f1-27f8-4f06-98ed-ea4e5d5821be"), 488154528, "Bike" },
                    { new Guid("e378012b-7bc4-4d6e-9f66-281e94fe4ab2"), 1210390689, "Towels" },
                    { new Guid("e6c855e9-f88c-4dc4-a111-6c4a8c9c9148"), 1048376882, "Salad" },
                    { new Guid("e78ec919-e087-4168-bdf3-97d6ba3c79a1"), -1432403039, "Hat" },
                    { new Guid("ec695b62-d5a7-42e8-90c8-78d7b0428e70"), 861728192, "Chair" },
                    { new Guid("f2344c4a-760e-43c2-b225-75aa32e5830d"), -1231317469, "Bike" },
                    { new Guid("f60c557a-3b55-403d-8b84-b81fdbf7a03c"), 240499218, "Chicken" },
                    { new Guid("fe435863-b32e-4c60-b370-b56063330b88"), 1864258026, "Bacon" },
                    { new Guid("ff265591-290e-438a-9b1e-abc5f8ab3e2c"), -689646517, "Gloves" },
                    { new Guid("ffa68154-b58d-48e5-80dc-b3de7d9897e0"), 1804840688, "Computer" }
                });

            migrationBuilder.InsertData(
                table: "Stores",
                columns: new[] { "ID", "Stores_title" },
                values: new object[,]
                {
                    { new Guid("012de121-524e-4ab1-8d62-fc9803044cd4"), "Garden & Tools" },
                    { new Guid("028c6975-ff99-46c8-80a0-f180c1c0545a"), "Toys & Jewelery" },
                    { new Guid("089b3000-367c-48b9-8272-a6d1885bfa40"), "Shoes & Health" },
                    { new Guid("151a54d1-6760-4c44-8b8f-843f23302def"), "Automotive" },
                    { new Guid("18739b83-5062-4ff4-90bd-5060f84fcdb4"), "Jewelery, Sports & Kids" },
                    { new Guid("23655364-43e3-4ba3-97d4-12280e2606e5"), "Games" },
                    { new Guid("25226161-216f-4fd1-a0e9-a4699f745e22"), "Grocery" },
                    { new Guid("27ed5819-2d9a-46b2-93d9-e40fe3de294a"), "Clothing" },
                    { new Guid("2b24f9b9-33a0-42ab-8fad-76fe43918f14"), "Kids, Movies & Movies" },
                    { new Guid("2cd3d699-8ff0-43d3-b83c-4388178c7bc6"), "Sports, Computers & Sports" },
                    { new Guid("37912c86-113b-4b44-904f-c5b5a9bfe230"), "Shoes & Clothing" },
                    { new Guid("3893111f-c539-4734-aa5f-c2d833ad7397"), "Computers, Books & Clothing" },
                    { new Guid("3a3e5c24-b175-4a85-a574-907c35643598"), "Beauty, Automotive & Shoes" },
                    { new Guid("41f5b06d-42c3-4b59-8d25-67cda7709aab"), "Health, Computers & Jewelery" },
                    { new Guid("4fe4cebe-63db-45a6-a576-71d61a5752a4"), "Electronics & Computers" },
                    { new Guid("58d028ca-d211-4c25-9f1c-3066f67567bc"), "Kids" },
                    { new Guid("5ae058ac-fb3b-44bd-91a0-626213487e8f"), "Books" },
                    { new Guid("5cf037f2-4ddc-4f90-8641-1028412a9a8d"), "Jewelery" },
                    { new Guid("6a3cd904-d3eb-494e-a66f-e840386c4fb3"), "Outdoors" },
                    { new Guid("6b1ee671-d9fe-428a-a859-b97b72a77d5e"), "Clothing, Sports & Home" },
                    { new Guid("7034fb26-4397-43d5-a85c-9008c71ee8ad"), "Tools & Baby" },
                    { new Guid("790ab7ca-0dbd-4a12-8e1f-010656bb1d61"), "Baby & Garden" },
                    { new Guid("798478ea-4156-4750-bfc9-66241e1e5def"), "Tools, Shoes & Kids" },
                    { new Guid("79e5f624-fbb0-4a6e-90a3-26f043e7382d"), "Games & Industrial" },
                    { new Guid("7ab67ce7-9b58-4d70-903f-a1aed929f84a"), "Clothing, Sports & Jewelery" },
                    { new Guid("7c6ff238-7ee6-4579-94e4-48158d987b2e"), "Industrial & Electronics" },
                    { new Guid("8013dc28-3307-416f-9211-4b80a2c33209"), "Shoes, Computers & Home" },
                    { new Guid("81a41671-1e8f-4b52-b127-c13388571555"), "Health, Books & Toys" },
                    { new Guid("8661cf69-91a3-496d-94ee-5fe9772d7e1e"), "Garden & Toys" },
                    { new Guid("8c58932a-2235-4630-80e1-b870e65cef47"), "Grocery" },
                    { new Guid("8f4c4a95-f250-4ecc-a93e-0b1ac381d2c3"), "Industrial & Clothing" },
                    { new Guid("91d0b04d-9847-49fe-8d3d-160bd745ccfa"), "Health & Garden" },
                    { new Guid("975499f9-761e-48a9-8a2c-e0a70826da1d"), "Industrial & Music" },
                    { new Guid("ac13f26b-18d5-4b29-855e-7aa47ed5d009"), "Industrial & Games" },
                    { new Guid("b1a580be-2a78-484e-b405-d8eb9a950516"), "Kids & Outdoors" },
                    { new Guid("b8c11870-39ec-417a-bebb-d9e10a9d6301"), "Sports, Outdoors & Outdoors" },
                    { new Guid("d2c03793-8ff6-4f32-9f67-1ad842ee830c"), "Jewelery, Games & Sports" },
                    { new Guid("d6719218-3ed5-4fde-98d3-6d883dabe95e"), "Games, Sports & Movies" },
                    { new Guid("d6f11af9-f245-4965-8261-d3dbf0945044"), "Garden" },
                    { new Guid("e1281bcb-4204-4952-8c88-f9a696d9bc22"), "Electronics, Games & Games" },
                    { new Guid("e64498c4-4b51-42d5-af10-1e530b4f16d5"), "Movies" },
                    { new Guid("eb6c36d6-2888-4ca9-bd0a-099fc24a33f1"), "Jewelery, Movies & Books" },
                    { new Guid("ebe90182-4e38-40d7-a507-07385c0e3a04"), "Garden, Sports & Sports" },
                    { new Guid("ef1d83e7-87eb-4656-83a8-720ccda29fe5"), "Baby & Kids" },
                    { new Guid("f02cd1b4-a3f8-4355-9340-5e87b93e7dd6"), "Music, Electronics & Industrial" },
                    { new Guid("f35f7bc6-b82a-488d-8ac1-667ff627f5b3"), "Kids" },
                    { new Guid("f50d6dca-481c-4e40-a525-f5f50fc26ca5"), "Clothing & Garden" },
                    { new Guid("f861e07e-ab27-4824-88e8-f95af49d8f72"), "Books" },
                    { new Guid("f93d7ac1-a63c-4cbb-af71-fbfaefaea9e3"), "Garden" },
                    { new Guid("ffe95ed0-93a2-4805-a0ff-56ceff2d46b0"), "Beauty & Baby" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "ID", "Customers_ID", "Date", "Products_ID", "Stores_ID" },
                values: new object[,]
                {
                    { new Guid("0400462a-8fb2-4b47-a875-57ca3b5f46f8"), new Guid("a92c4f5f-42c2-4de7-9fac-2b3c5da6c74b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5a643e83-fd7e-473f-8c08-e5194ef5bf64"), new Guid("f50d6dca-481c-4e40-a525-f5f50fc26ca5") },
                    { new Guid("07586486-5eb7-454a-855c-a69d6d50b240"), new Guid("51ac2ef7-63a6-47fd-bd11-e0b59be603bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("aaff7576-58f4-435f-a879-b3424f8bbfef"), new Guid("3a3e5c24-b175-4a85-a574-907c35643598") },
                    { new Guid("1576f5b8-20ed-4f64-a9f6-13c4bb0015df"), new Guid("87935438-385e-44e2-8aa6-968addf83bf8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("09e3a883-5164-46fb-99df-62edbfded4e5"), new Guid("790ab7ca-0dbd-4a12-8e1f-010656bb1d61") },
                    { new Guid("1769234a-0ec5-427c-99ad-6b696f006d9a"), new Guid("218be20c-b7b0-4b18-b687-c6efbfe86764"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("62f0aa9b-0a50-44d9-96a5-91299e9711eb"), new Guid("ac13f26b-18d5-4b29-855e-7aa47ed5d009") },
                    { new Guid("3354c717-8018-4a4a-8e11-7e65dfc8fe41"), new Guid("bed6da71-b625-4a9e-867f-f6343fd4b64b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4bea53e-6568-4307-ac57-8b5e25349445"), new Guid("25226161-216f-4fd1-a0e9-a4699f745e22") },
                    { new Guid("3381b481-e042-4a24-833a-3fe4a46d39db"), new Guid("07e5efac-cb1e-4b6e-9a6e-bb88bb2352a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd069cdf-ba4d-4a6e-9124-274d8ee74161"), new Guid("089b3000-367c-48b9-8272-a6d1885bfa40") },
                    { new Guid("481c1309-90a9-4578-bf0d-92b1c202170f"), new Guid("17558074-c828-429a-bb98-ece3b305d767"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5489549c-20df-4678-90a5-f63f0470de67"), new Guid("089b3000-367c-48b9-8272-a6d1885bfa40") },
                    { new Guid("51fb0d55-d496-46cd-967d-b6b51580779e"), new Guid("64df48d9-cb38-42bb-945e-a392a1eea8a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cc5aa489-ebd2-4dcf-b0da-ee7285b38065"), new Guid("3a3e5c24-b175-4a85-a574-907c35643598") },
                    { new Guid("54c85686-34b8-4c06-9c95-c4d37416d2fd"), new Guid("968e87d1-7328-482b-91f1-8a594b1b220d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f60c557a-3b55-403d-8b84-b81fdbf7a03c"), new Guid("18739b83-5062-4ff4-90bd-5060f84fcdb4") },
                    { new Guid("5b4d370f-e1db-4420-ab26-f4f79bf440af"), new Guid("4defc4c5-fbe6-4b88-b765-8173911dcaa5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23410fd0-0507-4d46-8dba-31b4a67ed5b6"), new Guid("3a3e5c24-b175-4a85-a574-907c35643598") },
                    { new Guid("74dfb2ce-6322-4b72-8ed8-dec2aab362cb"), new Guid("bf6aa289-bc71-4845-a4e9-382b8b4560bc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e6c855e9-f88c-4dc4-a111-6c4a8c9c9148"), new Guid("f93d7ac1-a63c-4cbb-af71-fbfaefaea9e3") },
                    { new Guid("7a15ac06-f96c-46ab-aba6-d294ba7a4921"), new Guid("66f4cac8-03ce-40aa-acf8-36ec1c23f07e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88ee08e4-882f-434e-ae9e-218b0c524555"), new Guid("f861e07e-ab27-4824-88e8-f95af49d8f72") },
                    { new Guid("801aa5c7-fff4-4f25-a5d0-0f94d94d8611"), new Guid("db0c50c2-f678-4701-bc49-84b9212ee388"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ff265591-290e-438a-9b1e-abc5f8ab3e2c"), new Guid("798478ea-4156-4750-bfc9-66241e1e5def") },
                    { new Guid("8356e413-f338-4a73-83ad-e664cf8b68a1"), new Guid("cd37307e-1b7c-42f6-ac22-97f909950c68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0a1ed57b-36ff-4811-a06b-7498e556f48a"), new Guid("151a54d1-6760-4c44-8b8f-843f23302def") },
                    { new Guid("90f712a6-899e-443e-8833-9331bbbc4ab2"), new Guid("218be20c-b7b0-4b18-b687-c6efbfe86764"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8fdfe323-3b58-4aad-9d40-8d75dce4b337"), new Guid("e64498c4-4b51-42d5-af10-1e530b4f16d5") },
                    { new Guid("a0f0677d-6e4b-49c3-9542-31d107733ecc"), new Guid("1b205faa-9500-406e-baf6-871f73b8f6af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("09e3a883-5164-46fb-99df-62edbfded4e5"), new Guid("798478ea-4156-4750-bfc9-66241e1e5def") },
                    { new Guid("a9621d07-0558-46d0-a311-75cf70fee93b"), new Guid("03165422-c72a-43d1-96ef-264175fa3ea2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4ade33c-5dfb-449b-9535-e110c2ada9cd"), new Guid("58d028ca-d211-4c25-9f1c-3066f67567bc") },
                    { new Guid("b52dd710-5a37-48a0-ad6d-a318dbe4ea64"), new Guid("00d01742-8351-47ad-8ab5-8e9649676d57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d884d368-9d16-45a8-a693-29f4ab0715a7"), new Guid("7ab67ce7-9b58-4d70-903f-a1aed929f84a") },
                    { new Guid("b8108204-cfa6-40e5-a490-3f03bdfd0245"), new Guid("64df48d9-cb38-42bb-945e-a392a1eea8a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2bf8843e-91b7-466b-9c8f-4c58938cfd2b"), new Guid("6b1ee671-d9fe-428a-a859-b97b72a77d5e") },
                    { new Guid("bc018dae-56f4-4b86-99b7-d15770789953"), new Guid("5d7936d0-1d6f-483d-9ecf-8f7d5d197d54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36ee85d9-7fac-45c7-b1da-f0554d1baae4"), new Guid("790ab7ca-0dbd-4a12-8e1f-010656bb1d61") },
                    { new Guid("be08c7d4-f43b-4465-9ec0-02e42553fbec"), new Guid("03165422-c72a-43d1-96ef-264175fa3ea2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3957b5ae-502d-4800-a59d-f3a2533f9c4f"), new Guid("27ed5819-2d9a-46b2-93d9-e40fe3de294a") },
                    { new Guid("c3b5f450-5d87-4325-8d15-ec6a3a17c529"), new Guid("496f0bc5-8f88-4c93-941e-aa9d76f2cf87"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6f0ede23-2ea4-4a20-9ee0-390516c1bcf8"), new Guid("5cf037f2-4ddc-4f90-8641-1028412a9a8d") },
                    { new Guid("cfea1287-fe4f-449c-96d6-6ed5ceaaf3ef"), new Guid("4f29b645-641f-49df-aab5-cabab45bca8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c09afc71-098a-4db1-a2d3-14f745c98106"), new Guid("e1281bcb-4204-4952-8c88-f9a696d9bc22") },
                    { new Guid("f03324e0-4132-4bf3-aace-b568bb55a3c3"), new Guid("47444fd5-e960-4f96-a1f3-fe3feb1211de"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("082b3002-d0b1-4457-9283-557ae9aaad39"), new Guid("3a3e5c24-b175-4a85-a574-907c35643598") },
                    { new Guid("fad60cb4-c6b0-42dd-8833-2a5c8c02535d"), new Guid("bd10acfc-0cd0-4797-ae89-65b4683baebb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bdd70a88-f6ee-4010-8430-9da264264010"), new Guid("975499f9-761e-48a9-8a2c-e0a70826da1d") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("01b7f83c-356b-434a-96da-73f47cbb6640"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("0b2f96e8-2081-4cdd-ac4f-90e10f0cd9db"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1021c112-fdc4-40b2-a81c-9acc0efe70cf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("26b631fd-c51f-4511-a70a-dbd7653cf265"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("351a6f7d-4c90-4240-9126-a62e86154faf"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("37469122-6090-45bb-8654-00f17564b09a"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("42609502-f0bf-47a4-ba6e-57be0b15b15c"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("43a0f2e9-a01f-44a0-af76-9505621dbfd0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4497b661-019e-4b12-bffe-35aca5310964"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("491d4a4f-e44f-473e-ae46-6908abcd06cc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("50130165-cdec-484f-ba81-ae14159bd229"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("6b7c6ca7-c8b6-465d-be98-b34e860e1e70"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("75d4fdf2-25f3-4d11-8b43-ba7d5aff6ff9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("87eba4aa-2fb3-4fb4-9df2-3c1180995756"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("a25fd341-90dc-4bda-94f2-d5aaa1698a29"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("b3603f61-fde8-4ce6-ad58-320d032b8fbc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bf457565-a1ef-445d-9a6a-7d807ca26032"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c4bcf52c-c9a5-4f86-bc35-9f7a0d06cce9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c604b0ad-c864-4384-90d3-88b7e21f1ab4"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("c9dc9e45-bd46-48e9-be0a-2c8069085ec3"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d568bfb7-b390-4239-a10a-08166f33cb2f"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("d645df59-a06b-42c4-871a-46a7c5cdc149"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("db27de94-69d3-4643-b7b8-6898ce55c368"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("dd1a93c2-ae08-4505-985b-21dc287285b9"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("e3589655-e59a-4be2-b0fb-0aaae5b15c15"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("ea485e3e-fa11-4cca-9de9-c8ce34aeb60d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("f2d799b3-2f6e-4dc2-8cad-70f57ae257f1"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("fa167022-bf3c-4de1-ac21-9fc39cbfb6e4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("069b08b2-e2ee-48a6-9a29-c8f5175920f1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0e9d959c-d8a9-4f5a-8422-058379169332"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0f1a8df7-9cdf-4d18-8a31-d577e1f37092"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0f90083f-8e89-4c50-bedc-32dd0d502ef3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("15b490df-5151-4606-8726-4fcd5856fe95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("20f49066-7313-4df7-9243-8c51dd43fb78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("25890d1a-e294-407e-b9f8-0f7f60175bb3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("32def40c-7efa-4dea-b461-2b97cedc61f8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("355268e9-2e10-4962-8b19-527433dde974"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3a814dee-218a-4111-ac8e-1b598fd86e78"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("404f0a2c-1f73-4616-bf9c-0130c0e17cb1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("43500789-1762-4aa0-8814-8c488d08c246"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("45dce803-dd24-4685-92e8-a583c72dbf6f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("582443c4-29a7-4312-b9e2-45636161b21a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("582d1eef-5607-415d-90cc-0f56e4ace143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5cd730f2-5644-4d2f-a9c2-fae1f02d9b5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5fa0e79b-d281-42af-b119-54f4af2b39fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("62c28bda-9fad-4b14-9e83-551e514721fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("66070e34-254a-433f-9140-008ba57b7e17"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6681cdb3-4ea5-4c3b-8074-645d0170ccf6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("7098bb9c-24f3-4853-b98c-df9605b13159"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("762d7727-6e74-4fac-af58-238fce12e7c8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("76b5762a-d9d8-46fa-b577-7122be105538"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("77c80fcc-6a6e-4309-a08e-d279d9e9db7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("80736a53-31c0-4a74-a10a-671c115f21e8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("85084da4-0fa7-4a27-8e91-278d4c6fa695"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9a26c330-a991-416d-9d9d-6a9f2ebdf29c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("9f5a4214-ad94-4c9e-856c-e576d59f0e95"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a2b32fdc-7c4c-444e-8e64-c3c1ac6c9fc0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("a6c0caa7-19a2-4b3f-81e8-f86ee550ea7f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("af7faabc-0392-4c94-b92c-77e48acb26fa"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b1f6ea8d-7b53-4aa4-a1c6-389e0851ee43"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b92fa980-1a4c-42f5-bdc4-d4b5d506fa91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b98083c5-83ed-4d4c-9133-9c3ee4a7f344"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bc11728c-2087-44bc-920b-48bf983a07ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("be883979-e93a-479d-86f3-c7491d8269be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bed4c761-a4f9-4338-9663-28f71a471496"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bf7465c0-b88d-46c8-a1e0-bc531ec920bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c2a3dfd1-17a6-4e8c-a2d0-83da33b8efa2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c49f8b6d-1e8b-4846-a13e-678190526143"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ca7db7b1-ae7e-4554-8dfd-d70d89d51aa8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d0c30186-3c37-431d-98fb-2db628b3704f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d1303b9a-c552-4a6e-9e19-894b69a827ea"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("dd0ed904-2462-4514-ad11-76f358c849a9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e1f6c0f1-27f8-4f06-98ed-ea4e5d5821be"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e378012b-7bc4-4d6e-9f66-281e94fe4ab2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e78ec919-e087-4168-bdf3-97d6ba3c79a1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ec695b62-d5a7-42e8-90c8-78d7b0428e70"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("f2344c4a-760e-43c2-b225-75aa32e5830d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("fe435863-b32e-4c60-b370-b56063330b88"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ffa68154-b58d-48e5-80dc-b3de7d9897e0"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("0400462a-8fb2-4b47-a875-57ca3b5f46f8"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("07586486-5eb7-454a-855c-a69d6d50b240"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("1576f5b8-20ed-4f64-a9f6-13c4bb0015df"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("1769234a-0ec5-427c-99ad-6b696f006d9a"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("3354c717-8018-4a4a-8e11-7e65dfc8fe41"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("3381b481-e042-4a24-833a-3fe4a46d39db"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("481c1309-90a9-4578-bf0d-92b1c202170f"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("51fb0d55-d496-46cd-967d-b6b51580779e"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("54c85686-34b8-4c06-9c95-c4d37416d2fd"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("5b4d370f-e1db-4420-ab26-f4f79bf440af"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("74dfb2ce-6322-4b72-8ed8-dec2aab362cb"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("7a15ac06-f96c-46ab-aba6-d294ba7a4921"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("801aa5c7-fff4-4f25-a5d0-0f94d94d8611"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("8356e413-f338-4a73-83ad-e664cf8b68a1"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("90f712a6-899e-443e-8833-9331bbbc4ab2"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("a0f0677d-6e4b-49c3-9542-31d107733ecc"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("a9621d07-0558-46d0-a311-75cf70fee93b"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("b52dd710-5a37-48a0-ad6d-a318dbe4ea64"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("b8108204-cfa6-40e5-a490-3f03bdfd0245"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("bc018dae-56f4-4b86-99b7-d15770789953"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("be08c7d4-f43b-4465-9ec0-02e42553fbec"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("c3b5f450-5d87-4325-8d15-ec6a3a17c529"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("cfea1287-fe4f-449c-96d6-6ed5ceaaf3ef"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("f03324e0-4132-4bf3-aace-b568bb55a3c3"));

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "ID",
                keyValue: new Guid("fad60cb4-c6b0-42dd-8833-2a5c8c02535d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("012de121-524e-4ab1-8d62-fc9803044cd4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("028c6975-ff99-46c8-80a0-f180c1c0545a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("23655364-43e3-4ba3-97d4-12280e2606e5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("2b24f9b9-33a0-42ab-8fad-76fe43918f14"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("2cd3d699-8ff0-43d3-b83c-4388178c7bc6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("37912c86-113b-4b44-904f-c5b5a9bfe230"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("3893111f-c539-4734-aa5f-c2d833ad7397"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("41f5b06d-42c3-4b59-8d25-67cda7709aab"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("4fe4cebe-63db-45a6-a576-71d61a5752a4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("5ae058ac-fb3b-44bd-91a0-626213487e8f"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("6a3cd904-d3eb-494e-a66f-e840386c4fb3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7034fb26-4397-43d5-a85c-9008c71ee8ad"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("79e5f624-fbb0-4a6e-90a3-26f043e7382d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7c6ff238-7ee6-4579-94e4-48158d987b2e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("8013dc28-3307-416f-9211-4b80a2c33209"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("81a41671-1e8f-4b52-b127-c13388571555"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("8661cf69-91a3-496d-94ee-5fe9772d7e1e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("8c58932a-2235-4630-80e1-b870e65cef47"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("8f4c4a95-f250-4ecc-a93e-0b1ac381d2c3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("91d0b04d-9847-49fe-8d3d-160bd745ccfa"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("b1a580be-2a78-484e-b405-d8eb9a950516"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("b8c11870-39ec-417a-bebb-d9e10a9d6301"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("d2c03793-8ff6-4f32-9f67-1ad842ee830c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("d6719218-3ed5-4fde-98d3-6d883dabe95e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("d6f11af9-f245-4965-8261-d3dbf0945044"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("eb6c36d6-2888-4ca9-bd0a-099fc24a33f1"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("ebe90182-4e38-40d7-a507-07385c0e3a04"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("ef1d83e7-87eb-4656-83a8-720ccda29fe5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f02cd1b4-a3f8-4355-9340-5e87b93e7dd6"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f35f7bc6-b82a-488d-8ac1-667ff627f5b3"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("ffe95ed0-93a2-4805-a0ff-56ceff2d46b0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("00d01742-8351-47ad-8ab5-8e9649676d57"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("03165422-c72a-43d1-96ef-264175fa3ea2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("07e5efac-cb1e-4b6e-9a6e-bb88bb2352a0"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("17558074-c828-429a-bb98-ece3b305d767"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("1b205faa-9500-406e-baf6-871f73b8f6af"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("218be20c-b7b0-4b18-b687-c6efbfe86764"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("47444fd5-e960-4f96-a1f3-fe3feb1211de"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("496f0bc5-8f88-4c93-941e-aa9d76f2cf87"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4defc4c5-fbe6-4b88-b765-8173911dcaa5"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("4f29b645-641f-49df-aab5-cabab45bca8b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("51ac2ef7-63a6-47fd-bd11-e0b59be603bd"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("5d7936d0-1d6f-483d-9ecf-8f7d5d197d54"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("64df48d9-cb38-42bb-945e-a392a1eea8a2"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("66f4cac8-03ce-40aa-acf8-36ec1c23f07e"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("87935438-385e-44e2-8aa6-968addf83bf8"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("968e87d1-7328-482b-91f1-8a594b1b220d"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("a92c4f5f-42c2-4de7-9fac-2b3c5da6c74b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bd10acfc-0cd0-4797-ae89-65b4683baebb"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bed6da71-b625-4a9e-867f-f6343fd4b64b"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("bf6aa289-bc71-4845-a4e9-382b8b4560bc"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("cd37307e-1b7c-42f6-ac22-97f909950c68"));

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "ID",
                keyValue: new Guid("db0c50c2-f678-4701-bc49-84b9212ee388"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("082b3002-d0b1-4457-9283-557ae9aaad39"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("09e3a883-5164-46fb-99df-62edbfded4e5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("0a1ed57b-36ff-4811-a06b-7498e556f48a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("23410fd0-0507-4d46-8dba-31b4a67ed5b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("2bf8843e-91b7-466b-9c8f-4c58938cfd2b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("36ee85d9-7fac-45c7-b1da-f0554d1baae4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("3957b5ae-502d-4800-a59d-f3a2533f9c4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5489549c-20df-4678-90a5-f63f0470de67"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("5a643e83-fd7e-473f-8c08-e5194ef5bf64"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("62f0aa9b-0a50-44d9-96a5-91299e9711eb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("6f0ede23-2ea4-4a20-9ee0-390516c1bcf8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("88ee08e4-882f-434e-ae9e-218b0c524555"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("8fdfe323-3b58-4aad-9d40-8d75dce4b337"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("aaff7576-58f4-435f-a879-b3424f8bbfef"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("b4bea53e-6568-4307-ac57-8b5e25349445"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("bdd70a88-f6ee-4010-8430-9da264264010"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("c09afc71-098a-4db1-a2d3-14f745c98106"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("cc5aa489-ebd2-4dcf-b0da-ee7285b38065"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("cd069cdf-ba4d-4a6e-9124-274d8ee74161"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d4ade33c-5dfb-449b-9535-e110c2ada9cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("d884d368-9d16-45a8-a693-29f4ab0715a7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("e6c855e9-f88c-4dc4-a111-6c4a8c9c9148"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("f60c557a-3b55-403d-8b84-b81fdbf7a03c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ID",
                keyValue: new Guid("ff265591-290e-438a-9b1e-abc5f8ab3e2c"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("089b3000-367c-48b9-8272-a6d1885bfa40"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("151a54d1-6760-4c44-8b8f-843f23302def"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("18739b83-5062-4ff4-90bd-5060f84fcdb4"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("25226161-216f-4fd1-a0e9-a4699f745e22"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("27ed5819-2d9a-46b2-93d9-e40fe3de294a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("3a3e5c24-b175-4a85-a574-907c35643598"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("58d028ca-d211-4c25-9f1c-3066f67567bc"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("5cf037f2-4ddc-4f90-8641-1028412a9a8d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("6b1ee671-d9fe-428a-a859-b97b72a77d5e"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("790ab7ca-0dbd-4a12-8e1f-010656bb1d61"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("798478ea-4156-4750-bfc9-66241e1e5def"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("7ab67ce7-9b58-4d70-903f-a1aed929f84a"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("975499f9-761e-48a9-8a2c-e0a70826da1d"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("ac13f26b-18d5-4b29-855e-7aa47ed5d009"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("e1281bcb-4204-4952-8c88-f9a696d9bc22"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("e64498c4-4b51-42d5-af10-1e530b4f16d5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f50d6dca-481c-4e40-a525-f5f50fc26ca5"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f861e07e-ab27-4824-88e8-f95af49d8f72"));

            migrationBuilder.DeleteData(
                table: "Stores",
                keyColumn: "ID",
                keyValue: new Guid("f93d7ac1-a63c-4cbb-af71-fbfaefaea9e3"));

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
        }
    }
}

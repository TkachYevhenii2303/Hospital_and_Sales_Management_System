using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class Changes_in_Default_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Visitations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b689b58a-f86f-499f-9ef2-d12d655f0200"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("b3f1ec4b-211c-474c-b7bf-72f3c3545f9c"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Medicaments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("8d8d8521-d6d8-45e8-a790-b5c0237ad5f1"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("5a9c7cde-422d-4338-8a34-fd037783de66"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Diagnoses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValueSql: "NEWID()",
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValue: new Guid("d98973bf-9314-4c42-82b0-ad33f82d70de"));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Visitations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b689b58a-f86f-499f-9ef2-d12d655f0200"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Patients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("b3f1ec4b-211c-474c-b7bf-72f3c3545f9c"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Medicaments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("8d8d8521-d6d8-45e8-a790-b5c0237ad5f1"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Doctors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("5a9c7cde-422d-4338-8a34-fd037783de66"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");

            migrationBuilder.AlterColumn<Guid>(
                name: "ID",
                table: "Diagnoses",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("d98973bf-9314-4c42-82b0-ad33f82d70de"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldDefaultValueSql: "NEWID()");
        }
    }
}

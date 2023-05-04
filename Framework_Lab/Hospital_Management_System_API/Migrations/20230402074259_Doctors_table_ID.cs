using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class Doctors_table_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorsId",
                table: "Visitations",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Specialty",
                table: "Doctors",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations");

            migrationBuilder.AlterColumn<Guid>(
                name: "DoctorsId",
                table: "Visitations",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "Specialty",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "ID");
        }
    }
}

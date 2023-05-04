using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class Doctors_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorsId",
                table: "Visitations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NewID()"),
                    Doctors_name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    Updated_at = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitations_DoctorsId",
                table: "Visitations",
                column: "DoctorsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropIndex(
                name: "IX_Visitations_DoctorsId",
                table: "Visitations");

            migrationBuilder.DropColumn(
                name: "DoctorsId",
                table: "Visitations");
        }
    }
}

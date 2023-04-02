using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class Changes_in_Structure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Patients_PatientsId",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Patients_PatientsId",
                table: "Visitations");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "Visitations",
                newName: "Patients_ID");

            migrationBuilder.RenameColumn(
                name: "DoctorsId",
                table: "Visitations",
                newName: "Doctors_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Visitations_PatientsId",
                table: "Visitations",
                newName: "IX_Visitations_Patients_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Visitations_DoctorsId",
                table: "Visitations",
                newName: "IX_Visitations_Doctors_ID");

            migrationBuilder.RenameColumn(
                name: "PatientsId",
                table: "Diagnoses",
                newName: "Patiens_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_PatientsId",
                table: "Diagnoses",
                newName: "IX_Diagnoses_Patiens_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Patients_Patiens_ID",
                table: "Diagnoses",
                column: "Patiens_ID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_Doctors_ID",
                table: "Visitations",
                column: "Doctors_ID",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Patients_Patients_ID",
                table: "Visitations",
                column: "Patients_ID",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diagnoses_Patients_Patiens_ID",
                table: "Diagnoses");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Doctors_Doctors_ID",
                table: "Visitations");

            migrationBuilder.DropForeignKey(
                name: "FK_Visitations_Patients_Patients_ID",
                table: "Visitations");

            migrationBuilder.RenameColumn(
                name: "Patients_ID",
                table: "Visitations",
                newName: "PatientsId");

            migrationBuilder.RenameColumn(
                name: "Doctors_ID",
                table: "Visitations",
                newName: "DoctorsId");

            migrationBuilder.RenameIndex(
                name: "IX_Visitations_Patients_ID",
                table: "Visitations",
                newName: "IX_Visitations_PatientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Visitations_Doctors_ID",
                table: "Visitations",
                newName: "IX_Visitations_DoctorsId");

            migrationBuilder.RenameColumn(
                name: "Patiens_ID",
                table: "Diagnoses",
                newName: "PatientsId");

            migrationBuilder.RenameIndex(
                name: "IX_Diagnoses_Patiens_ID",
                table: "Diagnoses",
                newName: "IX_Diagnoses_PatientsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diagnoses_Patients_PatientsId",
                table: "Diagnoses",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Doctors_DoctorsId",
                table: "Visitations",
                column: "DoctorsId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visitations_Patients_PatientsId",
                table: "Visitations",
                column: "PatientsId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

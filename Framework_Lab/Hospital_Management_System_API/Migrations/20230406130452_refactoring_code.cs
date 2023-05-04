using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labs_EF.Migrations
{
    /// <inheritdoc />
    public partial class refactoring_code : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Medicaments_Medicaments_ID",
                table: "Prescriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescriptions_Patients_Patients_ID",
                table: "Prescriptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions");

            migrationBuilder.RenameTable(
                name: "Prescriptions",
                newName: "Prescription_Medicaments");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_Patients_ID",
                table: "Prescription_Medicaments",
                newName: "IX_Prescription_Medicaments_Patients_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Prescriptions_Medicaments_ID",
                table: "Prescription_Medicaments",
                newName: "IX_Prescription_Medicaments_Medicaments_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Visitations",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Patients_first_name",
                table: "Patients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Patients_last_name",
                table: "Patients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Medicaments_title",
                table: "Medicaments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Doctors_name",
                table: "Doctors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescription_Medicaments",
                table: "Prescription_Medicaments",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_Medicaments_ID",
                table: "Prescription_Medicaments",
                column: "Medicaments_ID",
                principalTable: "Medicaments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescription_Medicaments_Patients_Patients_ID",
                table: "Prescription_Medicaments",
                column: "Patients_ID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Medicaments_Medicaments_ID",
                table: "Prescription_Medicaments");

            migrationBuilder.DropForeignKey(
                name: "FK_Prescription_Medicaments_Patients_Patients_ID",
                table: "Prescription_Medicaments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prescription_Medicaments",
                table: "Prescription_Medicaments");

            migrationBuilder.RenameTable(
                name: "Prescription_Medicaments",
                newName: "Prescriptions");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_Medicaments_Patients_ID",
                table: "Prescriptions",
                newName: "IX_Prescriptions_Patients_ID");

            migrationBuilder.RenameIndex(
                name: "IX_Prescription_Medicaments_Medicaments_ID",
                table: "Prescriptions",
                newName: "IX_Prescriptions_Medicaments_ID");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "Visitations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Patients_first_name",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Patients_last_name",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Medicaments_title",
                table: "Medicaments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Doctors_name",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prescriptions",
                table: "Prescriptions",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Medicaments_Medicaments_ID",
                table: "Prescriptions",
                column: "Medicaments_ID",
                principalTable: "Medicaments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Prescriptions_Patients_Patients_ID",
                table: "Prescriptions",
                column: "Patients_ID",
                principalTable: "Patients",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

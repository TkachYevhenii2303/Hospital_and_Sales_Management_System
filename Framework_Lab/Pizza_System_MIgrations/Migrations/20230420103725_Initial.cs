using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pizza_System_MIgrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sauce_table",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Sauce_title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Is_vegan = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauce_table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Topping_table",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Toppings_table = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Calories = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping_table", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pizza_table",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Pizza_title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SauceID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizza_table", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pizza_table_Sauce_table_SauceID",
                        column: x => x.SauceID,
                        principalTable: "Sauce_table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PizzaToppings",
                columns: table => new
                {
                    PizzasID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ToppingsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaToppings", x => new { x.PizzasID, x.ToppingsID });
                    table.ForeignKey(
                        name: "FK_PizzaToppings_Pizza_table_PizzasID",
                        column: x => x.PizzasID,
                        principalTable: "Pizza_table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PizzaToppings_Topping_table_ToppingsID",
                        column: x => x.ToppingsID,
                        principalTable: "Topping_table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_table_SauceID",
                table: "Pizza_table",
                column: "SauceID");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaToppings_ToppingsID",
                table: "PizzaToppings",
                column: "ToppingsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PizzaToppings");

            migrationBuilder.DropTable(
                name: "Pizza_table");

            migrationBuilder.DropTable(
                name: "Topping_table");

            migrationBuilder.DropTable(
                name: "Sauce_table");
        }
    }
}

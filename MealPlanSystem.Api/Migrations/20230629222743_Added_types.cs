using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPlanSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class Added_types : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Plan",
                type: "NVARCHAR(200)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "NVARCHAR(200)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "PlanEntryType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    DisplayName = table.Column<string>(type: "NVARCHAR(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEntryType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanEntryType");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Plan",
                type: "NVARCHAR(200)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(200)");
        }
    }
}

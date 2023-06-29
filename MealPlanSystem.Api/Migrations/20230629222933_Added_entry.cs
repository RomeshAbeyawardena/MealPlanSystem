using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPlanSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class Added_entry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanEntry",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanEntryTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnitTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(200)", nullable: false),
                    Notes = table.Column<string>(type: "NVARCHAR(2000)", nullable: true),
                    Amount = table.Column<decimal>(type: "DECIMAL(38,5)", nullable: true),
                    Cost = table.Column<decimal>(type: "DECIMAL(38,5)", nullable: true),
                    StartDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    EndDate = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Created = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanEntry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanEntry_PlanEntryType_PlanEntryTypeId",
                        column: x => x.PlanEntryTypeId,
                        principalTable: "PlanEntryType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanEntry_PlanEntryTypeId",
                table: "PlanEntry",
                column: "PlanEntryTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanEntry");
        }
    }
}

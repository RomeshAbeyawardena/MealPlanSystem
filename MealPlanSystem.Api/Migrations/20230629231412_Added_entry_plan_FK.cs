using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MealPlanSystem.Api.Migrations
{
    /// <inheritdoc />
    public partial class Added_entry_plan_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "PlanId",
                table: "PlanEntry",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PlanEntry_PlanId",
                table: "PlanEntry",
                column: "PlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanEntry_Plan_PlanId",
                table: "PlanEntry",
                column: "PlanId",
                principalTable: "Plan",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanEntry_Plan_PlanId",
                table: "PlanEntry");

            migrationBuilder.DropIndex(
                name: "IX_PlanEntry_PlanId",
                table: "PlanEntry");

            migrationBuilder.DropColumn(
                name: "PlanId",
                table: "PlanEntry");
        }
    }
}

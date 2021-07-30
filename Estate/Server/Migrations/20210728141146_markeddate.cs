using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class markeddate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tenants_ApartmentId",
                table: "Tenants");

            migrationBuilder.AddColumn<DateTime>(
                name: "MarkedAsPaid",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_ApartmentId",
                table: "Tenants",
                column: "ApartmentId",
                unique: true,
                filter: "[ApartmentId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Tenants_ApartmentId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "MarkedAsPaid",
                table: "Invoices");

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_ApartmentId",
                table: "Tenants",
                column: "ApartmentId");
        }
    }
}

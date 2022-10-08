using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class changedinvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "Invoices",
                newName: "TenantId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_ApartmentId",
                table: "Invoices",
                newName: "IX_Invoices_TenantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Tenants_TenantId",
                table: "Invoices",
                column: "TenantId",
                principalTable: "Tenants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Tenants_TenantId",
                table: "Invoices");

            migrationBuilder.RenameColumn(
                name: "TenantId",
                table: "Invoices",
                newName: "ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_TenantId",
                table: "Invoices",
                newName: "IX_Invoices_ApartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

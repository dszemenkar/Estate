using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class tenantchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EInvoice",
                table: "Tenants",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_AppUserId",
                table: "Tenants",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_AppUserId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "EInvoice",
                table: "Tenants");
        }
    }
}

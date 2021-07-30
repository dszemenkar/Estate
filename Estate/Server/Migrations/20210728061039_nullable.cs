using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class nullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Apartments_ApartmentId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Tenants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "Tenants",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Apartments_ApartmentId",
                table: "Tenants",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_Apartments_ApartmentId",
                table: "Tenants");

            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "Tenants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_Apartments_ApartmentId",
                table: "Tenants",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_AppUsers_AppUserId",
                table: "Tenants",
                column: "AppUserId",
                principalTable: "AppUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

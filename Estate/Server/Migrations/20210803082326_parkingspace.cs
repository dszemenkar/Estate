using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class parkingspace : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParkingId",
                table: "Tenants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BusinessMonth",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BusinessMonth",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "BusinessProperty",
                table: "Apartments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "ParkingSpaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(9,2)", nullable: false),
                    Archieved = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParkingSpaces", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tenants_ParkingId",
                table: "Tenants",
                column: "ParkingId",
                unique: true,
                filter: "[ParkingId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Tenants_ParkingSpaces_ParkingId",
                table: "Tenants",
                column: "ParkingId",
                principalTable: "ParkingSpaces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tenants_ParkingSpaces_ParkingId",
                table: "Tenants");

            migrationBuilder.DropTable(
                name: "ParkingSpaces");

            migrationBuilder.DropIndex(
                name: "IX_Tenants_ParkingId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "ParkingId",
                table: "Tenants");

            migrationBuilder.DropColumn(
                name: "BusinessMonth",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "BusinessMonth",
                table: "Apartments");

            migrationBuilder.DropColumn(
                name: "BusinessProperty",
                table: "Apartments");
        }
    }
}

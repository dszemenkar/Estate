using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUserRolesId",
                table: "AppUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppUsers_AppUserRolesId",
                table: "AppUsers",
                column: "AppUserRolesId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesId",
                table: "AppUsers",
                column: "AppUserRolesId",
                principalTable: "AppUserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsers_AppUserRoles_AppUserRolesId",
                table: "AppUsers");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AppUsers_AppUserRolesId",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "AppUserRolesId",
                table: "AppUsers");
        }
    }
}

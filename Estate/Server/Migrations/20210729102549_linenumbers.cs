using Microsoft.EntityFrameworkCore.Migrations;

namespace Estate.Server.Migrations
{
    public partial class linenumbers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceNo",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LineNo",
                table: "InvoiceLines",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InvoiceNo",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "LineNo",
                table: "InvoiceLines");
        }
    }
}

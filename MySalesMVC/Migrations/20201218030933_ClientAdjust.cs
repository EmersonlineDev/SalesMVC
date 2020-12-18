using Microsoft.EntityFrameworkCore.Migrations;

namespace MySalesMVC.Migrations
{
    public partial class ClientAdjust : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MyProperty",
                table: "Client");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MyProperty",
                table: "Client",
                nullable: false,
                defaultValue: 0);
        }
    }
}

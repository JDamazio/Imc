using Microsoft.EntityFrameworkCore.Migrations;

namespace IMC.Migrations
{
    public partial class DbAjustes3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ImcCalc",
                table: "Imcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImcCalc",
                table: "Imcs");
        }
    }
}

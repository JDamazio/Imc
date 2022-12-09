using Microsoft.EntityFrameworkCore.Migrations;

namespace IMC.Migrations
{
    public partial class DbAjustes6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "classificacao",
                table: "Imcs",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "classificacao",
                table: "Imcs");
        }
    }
}

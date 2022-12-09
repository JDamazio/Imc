using Microsoft.EntityFrameworkCore.Migrations;

namespace IMC.Migrations
{
    public partial class DbAjustes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "Imcs",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Altura",
                table: "Imcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Peso",
                table: "Imcs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Imcs",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imcs_UsuarioId",
                table: "Imcs",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imcs_Usuarios_UsuarioId",
                table: "Imcs",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imcs_Usuarios_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropIndex(
                name: "IX_Imcs_UsuarioId",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "Altura",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "Peso",
                table: "Imcs");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Imcs");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Imcs",
                newName: "id");
        }
    }
}

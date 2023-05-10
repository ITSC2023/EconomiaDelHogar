using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EDH.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "Categorias");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "Presupuestos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Icono",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GrupoId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Grupo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupo", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presupuestos_GrupoId",
                table: "Presupuestos",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_GrupoId",
                table: "AspNetUsers",
                column: "GrupoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Grupo_GrupoId",
                table: "AspNetUsers",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Presupuestos_Grupo_GrupoId",
                table: "Presupuestos",
                column: "GrupoId",
                principalTable: "Grupo",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Grupo_GrupoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Presupuestos_Grupo_GrupoId",
                table: "Presupuestos");

            migrationBuilder.DropTable(
                name: "Grupo");

            migrationBuilder.DropIndex(
                name: "IX_Presupuestos_GrupoId",
                table: "Presupuestos");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_GrupoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "Presupuestos");

            migrationBuilder.DropColumn(
                name: "Icono",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "GrupoId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

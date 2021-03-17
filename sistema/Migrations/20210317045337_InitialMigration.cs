using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace sistema.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "noticias",
                columns: table => new
                {
                    NoticiaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noticias", x => x.NoticiaID);
                });

            migrationBuilder.CreateTable(
                name: "comentarios",
                columns: table => new
                {
                    ComentarioID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ComentarioTexto = table.Column<string>(type: "text", nullable: true),
                    NoticiaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comentarios", x => x.ComentarioID);
                    table.ForeignKey(
                        name: "FK_comentarios_noticias_NoticiaID",
                        column: x => x.NoticiaID,
                        principalTable: "noticias",
                        principalColumn: "NoticiaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_comentarios_NoticiaID",
                table: "comentarios",
                column: "NoticiaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "comentarios");

            migrationBuilder.DropTable(
                name: "noticias");
        }
    }
}

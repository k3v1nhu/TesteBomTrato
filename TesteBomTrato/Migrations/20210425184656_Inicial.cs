using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteBomTrato.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroProcesso = table.Column<int>(nullable: false),
                    ValorCausa = table.Column<string>(nullable: true),
                    Escritorio = table.Column<string>(nullable: true),
                    NomeReclamante = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Processos",
                columns: new[] { "Id", "Ativo", "Escritorio", "NomeReclamante", "NumeroProcesso", "ValorCausa" },
                values: new object[] { 1, true, "Guttenber", "Kevin", 1, "1500,00" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace TesteBomTrato.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Processos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeroProcesso = table.Column<int>(nullable: false),
                    ValorCausa = table.Column<string>(nullable: true),
                    Escritorio = table.Column<string>(nullable: true),
                    NomeReclamante = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Processos",
                columns: new[] { "Id", "Escritorio", "NomeReclamante", "NumeroProcesso", "ValorCausa" },
                values: new object[] { 1, "LalaLand", "Kevin", 1, "1500" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Processos");
        }
    }
}

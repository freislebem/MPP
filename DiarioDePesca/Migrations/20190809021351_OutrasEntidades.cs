using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiarioDePesca.Migrations
{
    public partial class OutrasEntidades : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Especie",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Anzol",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anzol", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CondicaoDia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CondicaoDia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorAgua",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorAgua", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Isca",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Isca", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DtaRegistro = table.Column<DateTime>(nullable: false),
                    DtaPescaria = table.Column<DateTime>(nullable: false),
                    Uf = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Praia = table.Column<string>(nullable: true),
                    Local = table.Column<string>(nullable: true),
                    Temperatura = table.Column<double>(nullable: false),
                    Pressao = table.Column<double>(nullable: false),
                    HorMareCheia = table.Column<DateTime>(nullable: false),
                    MareCheia = table.Column<double>(nullable: false),
                    HorMareVazia = table.Column<DateTime>(nullable: false),
                    MareVazia = table.Column<double>(nullable: false),
                    CondicaoDia = table.Column<string>(nullable: true),
                    Lua = table.Column<string>(nullable: true),
                    CorAgua = table.Column<string>(nullable: true),
                    Anzol = table.Column<string>(nullable: true),
                    Obs = table.Column<string>(nullable: true),
                    CondicaoDiasId = table.Column<int>(nullable: true),
                    CorAguasId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diario_CondicaoDia_CondicaoDiasId",
                        column: x => x.CondicaoDiasId,
                        principalTable: "CondicaoDia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Diario_CorAgua_CorAguasId",
                        column: x => x.CorAguasId,
                        principalTable: "CorAgua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDiario = table.Column<int>(nullable: false),
                    IdEspecie = table.Column<int>(nullable: false),
                    Qtde = table.Column<int>(nullable: false),
                    TamanhoMaiorPeixe = table.Column<double>(nullable: false),
                    PesoMaiorPeixe = table.Column<double>(nullable: false),
                    Pernada = table.Column<double>(nullable: false),
                    DiarioId = table.Column<int>(nullable: true),
                    EspecieId = table.Column<int>(nullable: true),
                    IscaId = table.Column<int>(nullable: true),
                    AnzolId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Item_Anzol_AnzolId",
                        column: x => x.AnzolId,
                        principalTable: "Anzol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Diario_DiarioId",
                        column: x => x.DiarioId,
                        principalTable: "Diario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Especie_EspecieId",
                        column: x => x.EspecieId,
                        principalTable: "Especie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Isca_IscaId",
                        column: x => x.IscaId,
                        principalTable: "Isca",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CondicaoDiasId",
                table: "Diario",
                column: "CondicaoDiasId");

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CorAguasId",
                table: "Diario",
                column: "CorAguasId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_AnzolId",
                table: "Item",
                column: "AnzolId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_DiarioId",
                table: "Item",
                column: "DiarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_EspecieId",
                table: "Item",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IscaId",
                table: "Item",
                column: "IscaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Anzol");

            migrationBuilder.DropTable(
                name: "Diario");

            migrationBuilder.DropTable(
                name: "Isca");

            migrationBuilder.DropTable(
                name: "CondicaoDia");

            migrationBuilder.DropTable(
                name: "CorAgua");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Especie",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}

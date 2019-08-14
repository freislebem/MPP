using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiarioDePesca.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diario_CondicaoDia_CondicaoDiasId",
                table: "Diario");

            migrationBuilder.DropForeignKey(
                name: "FK_Diario_CorAgua_CorAguasId",
                table: "Diario");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Anzol_AnzolId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Especie_EspecieId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Isca_IscaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_AnzolId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_EspecieId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_IscaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Diario_CondicaoDiasId",
                table: "Diario");

            migrationBuilder.DropIndex(
                name: "IX_Diario_CorAguasId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "IdDiario",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "IdEspecie",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Anzol",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "CondicaoDia",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "CondicaoDiasId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "CorAgua",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "CorAguasId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "Lua",
                table: "Diario");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Item",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Isca",
                newName: "IscaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Especie",
                newName: "EspecieId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CorAgua",
                newName: "CorAguaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "CondicaoDia",
                newName: "CondicaoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Anzol",
                newName: "AnzolId");

            migrationBuilder.AlterColumn<int>(
                name: "IscaId",
                table: "Item",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EspecieId",
                table: "Item",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnzolId",
                table: "Item",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DtaPescaria",
                table: "Item",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CondicaoId",
                table: "Diario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CorAguaId",
                table: "Diario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Diario",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CorAgua",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CondicaoDia",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    email = table.Column<string>(nullable: false),
                    login = table.Column<string>(nullable: false),
                    celular = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_AnzolId",
                table: "Item",
                column: "AnzolId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_EspecieId",
                table: "Item",
                column: "EspecieId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Item_IscaId",
                table: "Item",
                column: "IscaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CondicaoId",
                table: "Diario",
                column: "CondicaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CorAguaId",
                table: "Diario",
                column: "CorAguaId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Diario_UsuarioId",
                table: "Diario",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diario_CondicaoDia_CondicaoId",
                table: "Diario",
                column: "CondicaoId",
                principalTable: "CondicaoDia",
                principalColumn: "CondicaoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diario_CorAgua_CorAguaId",
                table: "Diario",
                column: "CorAguaId",
                principalTable: "CorAgua",
                principalColumn: "CorAguaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Diario_Usuario_UsuarioId",
                table: "Diario",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Anzol_AnzolId",
                table: "Item",
                column: "AnzolId",
                principalTable: "Anzol",
                principalColumn: "AnzolId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Especie_EspecieId",
                table: "Item",
                column: "EspecieId",
                principalTable: "Especie",
                principalColumn: "EspecieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Isca_IscaId",
                table: "Item",
                column: "IscaId",
                principalTable: "Isca",
                principalColumn: "IscaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Diario_CondicaoDia_CondicaoId",
                table: "Diario");

            migrationBuilder.DropForeignKey(
                name: "FK_Diario_CorAgua_CorAguaId",
                table: "Diario");

            migrationBuilder.DropForeignKey(
                name: "FK_Diario_Usuario_UsuarioId",
                table: "Diario");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Anzol_AnzolId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Especie_EspecieId",
                table: "Item");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Isca_IscaId",
                table: "Item");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Item_AnzolId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_EspecieId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_IscaId",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Diario_CondicaoId",
                table: "Diario");

            migrationBuilder.DropIndex(
                name: "IX_Diario_CorAguaId",
                table: "Diario");

            migrationBuilder.DropIndex(
                name: "IX_Diario_UsuarioId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "DtaPescaria",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "CondicaoId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "CorAguaId",
                table: "Diario");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Diario");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Item",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "IscaId",
                table: "Isca",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EspecieId",
                table: "Especie",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CorAguaId",
                table: "CorAgua",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CondicaoId",
                table: "CondicaoDia",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AnzolId",
                table: "Anzol",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "IscaId",
                table: "Item",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "EspecieId",
                table: "Item",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AnzolId",
                table: "Item",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "IdDiario",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdEspecie",
                table: "Item",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Anzol",
                table: "Diario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CondicaoDia",
                table: "Diario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CondicaoDiasId",
                table: "Diario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorAgua",
                table: "Diario",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CorAguasId",
                table: "Diario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lua",
                table: "Diario",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CorAgua",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "CondicaoDia",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.CreateIndex(
                name: "IX_Item_AnzolId",
                table: "Item",
                column: "AnzolId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_EspecieId",
                table: "Item",
                column: "EspecieId");

            migrationBuilder.CreateIndex(
                name: "IX_Item_IscaId",
                table: "Item",
                column: "IscaId");

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CondicaoDiasId",
                table: "Diario",
                column: "CondicaoDiasId");

            migrationBuilder.CreateIndex(
                name: "IX_Diario_CorAguasId",
                table: "Diario",
                column: "CorAguasId");

            migrationBuilder.AddForeignKey(
                name: "FK_Diario_CondicaoDia_CondicaoDiasId",
                table: "Diario",
                column: "CondicaoDiasId",
                principalTable: "CondicaoDia",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diario_CorAgua_CorAguasId",
                table: "Diario",
                column: "CorAguasId",
                principalTable: "CorAgua",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Anzol_AnzolId",
                table: "Item",
                column: "AnzolId",
                principalTable: "Anzol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Especie_EspecieId",
                table: "Item",
                column: "EspecieId",
                principalTable: "Especie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Isca_IscaId",
                table: "Item",
                column: "IscaId",
                principalTable: "Isca",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

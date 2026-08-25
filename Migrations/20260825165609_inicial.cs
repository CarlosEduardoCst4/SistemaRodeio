using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaRodeio.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sigla = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TiposAnimais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposAnimais", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Competidores",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cidadeid = table.Column<int>(type: "int", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    vitorias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competidores", x => x.id);
                    table.ForeignKey(
                        name: "FK_Competidores_Cidades_cidadeid",
                        column: x => x.cidadeid,
                        principalTable: "Cidades",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Animais",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tipoAnimalid = table.Column<int>(type: "int", nullable: false),
                    idade = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<float>(type: "real", nullable: false),
                    valor = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animais", x => x.id);
                    table.ForeignKey(
                        name: "FK_Animais_TiposAnimais_tipoAnimalid",
                        column: x => x.tipoAnimalid,
                        principalTable: "TiposAnimais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    competidorid = table.Column<int>(type: "int", nullable: false),
                    animalid = table.Column<int>(type: "int", nullable: false),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    notAnimal = table.Column<float>(type: "real", nullable: false),
                    notCompetidor = table.Column<float>(type: "real", nullable: false),
                    penalidade = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.id);
                    table.ForeignKey(
                        name: "FK_Rounds_Animais_animalid",
                        column: x => x.animalid,
                        principalTable: "Animais",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rounds_Competidores_competidorid",
                        column: x => x.competidorid,
                        principalTable: "Competidores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animais_tipoAnimalid",
                table: "Animais",
                column: "tipoAnimalid");

            migrationBuilder.CreateIndex(
                name: "IX_Competidores_cidadeid",
                table: "Competidores",
                column: "cidadeid");

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_animalid",
                table: "Rounds",
                column: "animalid");

            migrationBuilder.CreateIndex(
                name: "IX_Rounds_competidorid",
                table: "Rounds",
                column: "competidorid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropTable(
                name: "Animais");

            migrationBuilder.DropTable(
                name: "Competidores");

            migrationBuilder.DropTable(
                name: "TiposAnimais");

            migrationBuilder.DropTable(
                name: "Cidades");
        }
    }
}

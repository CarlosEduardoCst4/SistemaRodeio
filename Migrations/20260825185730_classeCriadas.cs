using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaRodeio.Migrations
{
    /// <inheritdoc />
    public partial class classeCriadas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animais_TiposAnimais_tipoAnimalid",
                table: "Animais");

            migrationBuilder.DropForeignKey(
                name: "FK_Competidores_Cidades_cidadeid",
                table: "Competidores");

            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Animais_animalid",
                table: "Rounds");

            migrationBuilder.DropForeignKey(
                name: "FK_Rounds_Competidores_competidorid",
                table: "Rounds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TiposAnimais",
                table: "TiposAnimais");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rounds",
                table: "Rounds");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competidores",
                table: "Competidores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animais",
                table: "Animais");

            migrationBuilder.RenameTable(
                name: "TiposAnimais",
                newName: "TipoAnimal");

            migrationBuilder.RenameTable(
                name: "Rounds",
                newName: "Round");

            migrationBuilder.RenameTable(
                name: "Competidores",
                newName: "Competidor");

            migrationBuilder.RenameTable(
                name: "Cidades",
                newName: "Cidade");

            migrationBuilder.RenameTable(
                name: "Animais",
                newName: "Animal");

            migrationBuilder.RenameIndex(
                name: "IX_Rounds_competidorid",
                table: "Round",
                newName: "IX_Round_competidorid");

            migrationBuilder.RenameIndex(
                name: "IX_Rounds_animalid",
                table: "Round",
                newName: "IX_Round_animalid");

            migrationBuilder.RenameIndex(
                name: "IX_Competidores_cidadeid",
                table: "Competidor",
                newName: "IX_Competidor_cidadeid");

            migrationBuilder.RenameIndex(
                name: "IX_Animais_tipoAnimalid",
                table: "Animal",
                newName: "IX_Animal_tipoAnimalid");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "TipoAnimal",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Competidor",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Cidade",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1)");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Cidade",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Animal",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TipoAnimal",
                table: "TipoAnimal",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Round",
                table: "Round",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competidor",
                table: "Competidor",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cidade",
                table: "Cidade",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animal",
                table: "Animal",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animal_TipoAnimal_tipoAnimalid",
                table: "Animal",
                column: "tipoAnimalid",
                principalTable: "TipoAnimal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Competidor_Cidade_cidadeid",
                table: "Competidor",
                column: "cidadeid",
                principalTable: "Cidade",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Round_Animal_animalid",
                table: "Round",
                column: "animalid",
                principalTable: "Animal",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Round_Competidor_competidorid",
                table: "Round",
                column: "competidorid",
                principalTable: "Competidor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Animal_TipoAnimal_tipoAnimalid",
                table: "Animal");

            migrationBuilder.DropForeignKey(
                name: "FK_Competidor_Cidade_cidadeid",
                table: "Competidor");

            migrationBuilder.DropForeignKey(
                name: "FK_Round_Animal_animalid",
                table: "Round");

            migrationBuilder.DropForeignKey(
                name: "FK_Round_Competidor_competidorid",
                table: "Round");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TipoAnimal",
                table: "TipoAnimal");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Round",
                table: "Round");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Competidor",
                table: "Competidor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cidade",
                table: "Cidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Animal",
                table: "Animal");

            migrationBuilder.RenameTable(
                name: "TipoAnimal",
                newName: "TiposAnimais");

            migrationBuilder.RenameTable(
                name: "Round",
                newName: "Rounds");

            migrationBuilder.RenameTable(
                name: "Competidor",
                newName: "Competidores");

            migrationBuilder.RenameTable(
                name: "Cidade",
                newName: "Cidades");

            migrationBuilder.RenameTable(
                name: "Animal",
                newName: "Animais");

            migrationBuilder.RenameIndex(
                name: "IX_Round_competidorid",
                table: "Rounds",
                newName: "IX_Rounds_competidorid");

            migrationBuilder.RenameIndex(
                name: "IX_Round_animalid",
                table: "Rounds",
                newName: "IX_Rounds_animalid");

            migrationBuilder.RenameIndex(
                name: "IX_Competidor_cidadeid",
                table: "Competidores",
                newName: "IX_Competidores_cidadeid");

            migrationBuilder.RenameIndex(
                name: "IX_Animal_tipoAnimalid",
                table: "Animais",
                newName: "IX_Animais_tipoAnimalid");

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "TiposAnimais",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Competidores",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "sigla",
                table: "Cidades",
                type: "nvarchar(1)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(2)",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<string>(
                name: "descricao",
                table: "Cidades",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<string>(
                name: "nome",
                table: "Animais",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TiposAnimais",
                table: "TiposAnimais",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rounds",
                table: "Rounds",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Competidores",
                table: "Competidores",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cidades",
                table: "Cidades",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Animais",
                table: "Animais",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Animais_TiposAnimais_tipoAnimalid",
                table: "Animais",
                column: "tipoAnimalid",
                principalTable: "TiposAnimais",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Competidores_Cidades_cidadeid",
                table: "Competidores",
                column: "cidadeid",
                principalTable: "Cidades",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Animais_animalid",
                table: "Rounds",
                column: "animalid",
                principalTable: "Animais",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rounds_Competidores_competidorid",
                table: "Rounds",
                column: "competidorid",
                principalTable: "Competidores",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

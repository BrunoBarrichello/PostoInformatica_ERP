using FirebirdSql.EntityFrameworkCore.Firebird.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PostoInformatica_ERP.Migrations
{
    public partial class criacaoLogin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BAIRRO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BAIRRO_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAIXA_POSTAL",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CAIXA_POSTAL_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CELULAR",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIDADE",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIDADE_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CIDADE_IBGE",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COLIGADA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COMPLEMENTO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COMPLEMENTO_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "COND_PAGAMENTO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CONTATO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EMAIL",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ENDERECO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ENDERECO_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESTADO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ESTADO_COBRANCA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FANTASIA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FONE",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FONE_RAMAL",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INSCRICAOMUNICIPAL",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "INTERNET",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LOGIN",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NOME",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NUMERO",
                table: "CLIENTES",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NUMERO_COBRANCA",
                table: "CLIENTES",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PAIS",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RG_INSCRICAO",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SENHA",
                table: "CLIENTES",
                type: "BLOB SUB_TYPE TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "USUARIO",
                columns: table => new
                {
                    USUARIO = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Fb:ValueGenerationStrategy", FbValueGenerationStrategy.IdentityColumn),
                    NOME = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    SENHA = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    CPF = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    USUARIO_EMAIL = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true),
                    SENHA_EMAIL = table.Column<string>(type: "BLOB SUB_TYPE TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIO", x => x.USUARIO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIO");

            migrationBuilder.DropColumn(
                name: "BAIRRO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "BAIRRO_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CAIXA_POSTAL",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CAIXA_POSTAL_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CELULAR",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CIDADE",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CIDADE_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CIDADE_IBGE",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "COLIGADA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "COMPLEMENTO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "COMPLEMENTO_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "COND_PAGAMENTO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "CONTATO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "EMAIL",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "ENDERECO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "ENDERECO_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "ESTADO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "ESTADO_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "FANTASIA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "FONE",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "FONE_RAMAL",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "INSCRICAOMUNICIPAL",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "INTERNET",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "LOGIN",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "NOME",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "NUMERO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "NUMERO_COBRANCA",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "PAIS",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "RG_INSCRICAO",
                table: "CLIENTES");

            migrationBuilder.DropColumn(
                name: "SENHA",
                table: "CLIENTES");
        }
    }
}

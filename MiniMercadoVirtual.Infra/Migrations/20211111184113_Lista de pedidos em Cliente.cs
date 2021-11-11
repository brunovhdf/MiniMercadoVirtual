using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMercadoVirtual.Infra.Migrations
{
    public partial class ListadepedidosemCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Endereco_EnderecoId",
                table: "Pedido");

            migrationBuilder.DropIndex(
                name: "IX_Pedido_EnderecoId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedido",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido");

            migrationBuilder.AlterColumn<int>(
                name: "EnderecoId",
                table: "Pedido",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "Pedido",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Pedido_EnderecoId",
                table: "Pedido",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Cliente_ClienteId",
                table: "Pedido",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedido_Endereco_EnderecoId",
                table: "Pedido",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

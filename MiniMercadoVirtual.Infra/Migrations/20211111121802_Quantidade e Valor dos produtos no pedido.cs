using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMercadoVirtual.Infra.Migrations
{
    public partial class QuantidadeeValordosprodutosnopedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Pedido",
                newName: "ValorPedido");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "ProdutoPedido",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorProduto",
                table: "ProdutoPedido",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "ProdutoPedido");

            migrationBuilder.DropColumn(
                name: "ValorProduto",
                table: "ProdutoPedido");

            migrationBuilder.RenameColumn(
                name: "ValorPedido",
                table: "Pedido",
                newName: "ValorTotal");
        }
    }
}

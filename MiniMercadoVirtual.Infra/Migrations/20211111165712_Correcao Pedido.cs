using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MiniMercadoVirtual.Infra.Migrations
{
    public partial class CorrecaoPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtAlteracao",
                table: "ProdutoPedido");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "ProdutoPedido");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ProdutoPedido");

            migrationBuilder.RenameColumn(
                name: "ValorProduto",
                table: "ProdutoPedido",
                newName: "ValorTotal");

            migrationBuilder.RenameColumn(
                name: "ValorPedido",
                table: "Pedido",
                newName: "ValorTotal");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtAlteracao",
                table: "Pedido",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "Pedido",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DtAlteracao",
                table: "Pedido");

            migrationBuilder.DropColumn(
                name: "DtInclusao",
                table: "Pedido");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "ProdutoPedido",
                newName: "ValorProduto");

            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "Pedido",
                newName: "ValorPedido");

            migrationBuilder.AddColumn<DateTime>(
                name: "DtAlteracao",
                table: "ProdutoPedido",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtInclusao",
                table: "ProdutoPedido",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ProdutoPedido",
                nullable: false,
                defaultValue: 0);
        }
    }
}

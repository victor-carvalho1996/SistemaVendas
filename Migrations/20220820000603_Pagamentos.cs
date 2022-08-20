using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VendasSolutto.Migrations
{
    public partial class Pagamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    data_pagamento = table.Column<DateTime>(type: "date", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "date", nullable: false),
                    valor_pago = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    descricao_pagamento = table.Column<string>(type: "varchar(50)", nullable: true),
                    vendasid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.id);
                    table.ForeignKey(
                        name: "FK_Pagamentos_Vendas_vendasid",
                        column: x => x.vendasid,
                        principalTable: "Vendas",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagamentos_vendasid",
                table: "Pagamentos",
                column: "vendasid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagamentos");
        }
    }
}

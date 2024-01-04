﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PF_GerenciaEscolar.Migrations
{
    /// <inheritdoc />
    public partial class Avaliacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Valor",
                table: "Avaliacoes",
                type: "decimal(18,2)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Avaliacoes");
        }
    }
}

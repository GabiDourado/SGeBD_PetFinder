﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoSemestre3___Encontrar.Migrations
{
    /// <inheritdoc />
    public partial class AjusteData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ObservacaoData",
                table: "Observacoes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ObservacaoData",
                table: "Observacoes",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}

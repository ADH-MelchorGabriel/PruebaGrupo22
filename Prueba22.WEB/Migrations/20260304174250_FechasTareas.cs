using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba22.WEB.Migrations
{
    /// <inheritdoc />
    public partial class FechasTareas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "FechaElaboracion",
                table: "Tareas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaTerminacion",
                table: "Tareas",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaElaboracion",
                table: "Tareas");

            migrationBuilder.DropColumn(
                name: "FechaTerminacion",
                table: "Tareas");
        }
    }
}

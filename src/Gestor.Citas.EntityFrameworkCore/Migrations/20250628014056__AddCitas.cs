using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Citas.Migrations
{
    /// <inheritdoc />
    public partial class _AddCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "Estado",
                table: "AppCitas",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraFin",
                table: "AppCitas",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HoraInicio",
                table: "AppCitas",
                type: "interval",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<byte>(
                name: "Modalidad",
                table: "AppCitas",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "NotasInternas",
                table: "AppCitas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ObservacionesCliente",
                table: "AppCitas",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ubicacion",
                table: "AppCitas",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppCitas_FechaCita",
                table: "AppCitas",
                column: "FechaCita",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AppCitas_FechaCita",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "HoraFin",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "HoraInicio",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "Modalidad",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "NotasInternas",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "ObservacionesCliente",
                table: "AppCitas");

            migrationBuilder.DropColumn(
                name: "Ubicacion",
                table: "AppCitas");
        }
    }
}

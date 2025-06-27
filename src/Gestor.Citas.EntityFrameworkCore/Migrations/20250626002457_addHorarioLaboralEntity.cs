using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gestor.Citas.Migrations
{
    /// <inheritdoc />
    public partial class addHorarioLaboralEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppHorariosLaborales",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ProfesionalId = table.Column<Guid>(type: "uuid", nullable: false),
                    DayOfWeekSemana = table.Column<byte>(type: "smallint", nullable: false),
                    HoraInicio = table.Column<TimeSpan>(type: "interval", nullable: false),
                    HoraFin = table.Column<TimeSpan>(type: "interval", nullable: false),
                    EstaActivo = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppHorariosLaborales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppHorariosLaborales_AppProfesionales_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "AppProfesionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppHorariosLaborales_ProfesionalId_DayOfWeekSemana",
                table: "AppHorariosLaborales",
                columns: new[] { "ProfesionalId", "DayOfWeekSemana" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppHorariosLaborales");
        }
    }
}

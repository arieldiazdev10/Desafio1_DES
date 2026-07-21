using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio1_DES.Migrations
{
    /// <inheritdoc />
    public partial class MigracioninicialCreaciondelmodeloEmpleado : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmpleadoID",
                table: "Departamentos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpleado = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaContratacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_EmpleadoID",
                table: "Departamentos",
                column: "EmpleadoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoID",
                table: "Departamentos",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoID",
                table: "Departamentos");

            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_EmpleadoID",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "EmpleadoID",
                table: "Departamentos");
        }
    }
}

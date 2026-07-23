using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio1_DES.Migrations
{
    /// <inheritdoc />
    public partial class MigraciondecorreccionLlaveforaneadelmodeloempleados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoId",
                table: "Departamentos");

            migrationBuilder.DropIndex(
                name: "IX_Departamentos_EmpleadoId",
                table: "Departamentos");

            migrationBuilder.DropColumn(
                name: "EmpleadoId",
                table: "Departamentos");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Empleados",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_DepartamentoId",
                table: "Empleados",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoId",
                table: "Empleados",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Departamentos_DepartamentoId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_DepartamentoId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Empleados");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Empleados",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmpleadoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departamentos_EmpleadoId",
                table: "Departamentos",
                column: "EmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoId",
                table: "Departamentos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

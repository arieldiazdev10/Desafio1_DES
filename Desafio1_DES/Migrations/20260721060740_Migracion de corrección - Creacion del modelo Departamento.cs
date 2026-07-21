using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio1_DES.Migrations
{
    /// <inheritdoc />
    public partial class MigraciondecorrecciónCreaciondelmodeloDepartamento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoID",
                table: "Departamentos");

            migrationBuilder.RenameColumn(
                name: "EmpleadoID",
                table: "Departamentos",
                newName: "EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_EmpleadoID",
                table: "Departamentos",
                newName: "IX_Departamentos_EmpleadoId");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepartamento",
                table: "Departamentos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "EmpleadoId",
                table: "Departamentos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Departamentos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoId",
                table: "Departamentos",
                column: "EmpleadoId",
                principalTable: "Empleados",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoId",
                table: "Departamentos");

            migrationBuilder.RenameColumn(
                name: "EmpleadoId",
                table: "Departamentos",
                newName: "EmpleadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Departamentos_EmpleadoId",
                table: "Departamentos",
                newName: "IX_Departamentos_EmpleadoID");

            migrationBuilder.AlterColumn<string>(
                name: "NombreDepartamento",
                table: "Departamentos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "EmpleadoID",
                table: "Departamentos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Departamentos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Departamentos_Empleados_EmpleadoID",
                table: "Departamentos",
                column: "EmpleadoID",
                principalTable: "Empleados",
                principalColumn: "ID");
        }
    }
}

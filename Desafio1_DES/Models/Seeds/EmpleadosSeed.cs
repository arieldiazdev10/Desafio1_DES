using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1_DES.Models.Seeds
{
    public class EmpleadosSeed : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.HasData(
                new Empleado
                {
                    ID = 1,
                    NombreEmpleado = "John Doe",
                    FechaNacimiento = DateTime.Parse("1985-05-20"),
                    FechaContratacion = DateTime.Parse("2010-08-15"),
                    Salario = 50000,
                    Descripcion = null,
                    DepartamentoId = 1
                },
                new Empleado
                {
                    ID = 2,
                    NombreEmpleado = "Jane Smith",
                    FechaNacimiento = DateTime.Parse("1990-03-10"),
                    FechaContratacion = DateTime.Parse("2015-01-25"),
                    Salario = 70000,
                    Descripcion = null,
                    DepartamentoId = 2
                },
                new Empleado
                {
                    ID = 3,
                    NombreEmpleado = "Mark Johnson",
                    FechaNacimiento = DateTime.Parse("1982-11-22"),
                    FechaContratacion = DateTime.Parse("2012-06-18"),
                    Salario = 55000,
                    Descripcion = null,
                    DepartamentoId = 3
                },
                new Empleado
                {
                    ID = 4,
                    NombreEmpleado = "Emily Davis",
                    FechaNacimiento = DateTime.Parse("1978-07-30"),
                    FechaContratacion = DateTime.Parse("2005-10-12"),
                    Salario = 75000,
                    Descripcion = null,
                    DepartamentoId = 1
                },
                new Empleado
                {
                    ID = 5,
                    NombreEmpleado = "Michael Brown",
                    FechaNacimiento = DateTime.Parse("1995-12-05"),
                    FechaContratacion = DateTime.Parse("2020-04-15"),
                    Salario = 60000,
                    Descripcion = null,
                    DepartamentoId = 2
                }
                );
        }
    }
}

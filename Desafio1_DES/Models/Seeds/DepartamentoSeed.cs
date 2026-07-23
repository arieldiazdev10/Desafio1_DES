using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1_DES.Models.Seeds
{
    public class DepartamentoSeed : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.HasData(
                new Departamento { 
                    ID = 1,
                    NombreDepartamento = "Recursos Humanos",
                    Descripcion = "Departemento de recursos humanos, contratación y despido"
                },
                new Departamento { 
                    ID = 2,
                    NombreDepartamento = "Tecnología",
                    Descripcion = null
                },
                new Departamento {
                    ID = 3,
                    NombreDepartamento = "Ventas",
                    Descripcion = null 
                }
                );
        }
    }
}

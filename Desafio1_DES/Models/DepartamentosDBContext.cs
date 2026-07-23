using Desafio1_DES.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Desafio1_DES.Models
{
    public class DepartamentosDBContext: DbContext
    {
        public DepartamentosDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Departamento>Departamentos { get; set; }
        public DbSet<Empleado>Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DepartamentoSeed());
            modelBuilder.ApplyConfiguration(new EmpleadosSeed());
        }
    }
}

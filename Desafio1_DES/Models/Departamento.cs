using System.ComponentModel.DataAnnotations;
namespace Desafio1_DES.Models
{
    public class Departamento
    {
        public int ID { get; set; }//Código único de departamento
        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string NombreDepartamento { get; set; }//Nombre del departamento (Obligatorio)
        public string? Descripcion { get; set; }//Descripción (Opcional)

        //Propiedad de navegación inversa (un departamento tiene muchos empleados)
        public ICollection<Empleado> Empleados { get; set; } = new List<Empleado>();
    }
}

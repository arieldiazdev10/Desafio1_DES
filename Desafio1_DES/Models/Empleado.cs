using System.ComponentModel.DataAnnotations;

namespace Desafio1_DES.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength =2)]
        [Required]
        public string NombreEmpleado { get; set; }

        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public DateTime FechaContratacion { get; set; }

        [Required]
        public decimal Salario { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        //Propiedad de navegacion
        public ICollection<Departamento> Departamentos { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Desafio1_DES.Models
{
    public class Empleado
    {
        public int ID { get; set; }
        [StringLength(100, MinimumLength = 2)]
        [Required]
        public string NombreEmpleado { get; set; }
        [Required]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public DateTime FechaContratacion { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "El salario debe ser mayor a cero")]
        [Precision(18, 2)]
        public decimal Salario { get; set; }
        public string? Descripcion { get; set; }

        //Propiedad para la llave foránea
        public int DepartamentoId { get; set; }

        //Propiedad de navegación
        [ValidateNever]
        public Departamento Departamento { get; set; } = null!;
    }
}
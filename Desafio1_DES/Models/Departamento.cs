using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1_DES.Models
{
    public class Departamento
    {
        public int ID { get; set; }//Código único de departamento

        [StringLength(100, MinimumLength = 3)]
        [Required]
        public string NombreDepartamento { get; set; }//Nombre del departamento (Obligatorio)

        public string? Descripcion { get; set; }//Descripción (Opcional)

        //Llave foranea
        [Required]
        [ForeignKey("Empleado")]
        public int? EmpleadoId { get; set; }

        //Propiedad de navegación
        public Empleado Empleado { get; set; }
    }
}

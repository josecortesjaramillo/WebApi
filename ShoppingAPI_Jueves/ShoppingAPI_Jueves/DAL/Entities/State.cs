using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI_Jueves.DAL.Entities
{
    public class State : AuditBase
    {
        [Display(Name = "Estado/Departamento")] //´para identificar el nombre mas facil
        [MaxLength(50, ErrorMessage = " el campo {0} debe de tener maximo {1} caracteres")] // longitud maxima 
        [Required(ErrorMessage = "el campo {0} es obligatorio")]// Campo obligatorio
        public string Name { get; set; }

        //asi se relacionan dos tablas 
        [Display(Name = "pais")]
        public Country? Country { get; set; }

        //F.K
        [Display(Name = "id pais")]
        public Guid CountryId { get; set; }


    }
}

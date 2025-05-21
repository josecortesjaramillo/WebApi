using System.ComponentModel.DataAnnotations;

namespace ShoppingAPI_Jueves.DAL.Entities
{
    public class AuditBase
    {
        [Key ] // PK
        [Required] //significa que el campo es obligatorio
        public Guid Id { get; set; } // pk de todas las tablas 
        public DateTime? CreatedDate { get; set; } // para guardar todo registro con su fecha
        public DateTime? ModifiefDate { get; set; } // para guardar modificacion de registro con su fecha


    }
}

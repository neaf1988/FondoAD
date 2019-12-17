using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.DAL
{
    public class Prestamo
    {
        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Seleccione la persona que realizó el prestamo")]
        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Ingrese el valor del prestamo")]
        [Range(minimum: 0, maximum: 1000000000, ErrorMessage = "El valor ingresado no puede ser negativo")]
        public double Valor { get; set; }

        [Required(ErrorMessage = "Ingrese el monto del interes pactado")]
        [Range(minimum: 0, maximum: 1000000000, ErrorMessage = "El valor ingresado no puede ser negativo")]
        public double Interes { get; set; }

        [Required(ErrorMessage = "Seleccione la fecha de la consignación")]
        [DataType(DataType.Date, ErrorMessage = "Debe ser una fecha válida")]
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }

        public bool Finalizado { get; set; }

        public virtual Persona Persona { get; set; }
        public virtual IEnumerable<Consignacion> Consignaciones { get; set; }
    }
}

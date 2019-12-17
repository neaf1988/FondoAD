using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.Web.Model
{
    public class ConsignacionMVC
    {
        public int Id { get; set; }

        [Display(Name = "Persona")]
        [Required(ErrorMessage = "Seleccione la persona de la consignación")]
        [Validators.PrestamoActivo("TipoConsignacion",ErrorMessage = "El usuario no tiene un prestamo activo, seleccione de nuevo")]
        public int PersonaId { get; set; }
        public Byte TipoConsignacion { get; set; }

        [Display(Name = "Valor")]
        [Validators.ValorConsignacionValidationFieldsAttribute("TipoConsignacion", "Interes", mensaje: "Debe ingresar el capital o el interes de la consignacion", ErrorMessage = "Debe ingresar el monto ahorrado")]
        [Validators.ValorConsignado("TipoConsignacion","PersonaId","Interes", ErrorMessage = "El valor de la consignación es superior al saldo del prestamo")]
        public double? Valor { get; set; }

        [Display(Name = "Interés")]
        public double? Interes { get; set; }

        [Display(Name = "Fecha")]
        [Required(ErrorMessage = "Seleccione la fecha de la consignación")]
        public DateTime Fecha { get; set; }

        public int? PrestamoId { get; set; }


        public DateTime FechaRegistro { get; set; }
        public virtual PersonaMVC Persona { get; set; }
        public virtual PrestamoMVC Prestamo { get; set; }
    }
}

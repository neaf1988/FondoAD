using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.Web.Model
{
    public class PrestamoMVC
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Seleccione a una persona")]
        [Display(Name = "Persona")]
        public int PersonaId { get; set; }
        [Required(ErrorMessage = "Ingrese el valor del prestamo")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Ingrese el valor del interés pactado")]
        [Display(Name = "Interés")]
        public double Interes { get; set; }
        [Required(ErrorMessage = "Seleccione la fecha del prestamo")]
        public DateTime Fecha { get; set; }
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }

        [Display(Name ="Vigente")]
        public bool Finalizado { get; set; }

        public virtual  PersonaMVC Persona { get; set; }
    }
}

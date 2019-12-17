using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.Web.Model
{
    public class ParametrosMVC
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del parámetro")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Ingrese el valor del parámetro 1")]
        [Display(Name = "Valor 1")]
        public string Valor1 { get; set; }
        [Display(Name = "Valor 2")]
        public string Valor2 { get; set; }
    }
}

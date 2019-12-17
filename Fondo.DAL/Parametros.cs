using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fondo.DAL
{
    public class Parametros
    {
        [Key]
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string Valor1 { get; set; }
        public string Valor2 { get; set; }
    }
}

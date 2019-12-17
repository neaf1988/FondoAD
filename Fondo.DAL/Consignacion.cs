using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.DAL
{
    public class Consignacion
    {
        [Key]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public Byte TipoConsignacion { get; set; }
         public Double? Valor { get; set; }
        public Double? Interes { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? PrestamoId { get; set; }
        public virtual Persona Persona { get; set; }
        public virtual Prestamo Prestamo { get; set; }
    }
}

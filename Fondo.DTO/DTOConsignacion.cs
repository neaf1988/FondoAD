using System;
using System.Collections.Generic;
using System.Text;

namespace Fondo.DTO
{
    public class ConsignacionDTO
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public Byte TipoConsignacion { get; set; }
        public double? Valor { get; set; }
        public double? Interes { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? PrestamoId { get; set; }
        public virtual PersonaDTO Persona { get; set; }
        public virtual PrestamoDTO Prestamo { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Fondo.DTO
{
    public class PrestamoDTO
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public double Valor { get; set; }
        public double Interes { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Finalizado { get; set; }

        public virtual PersonaDTO Persona { get; set; }
        public virtual IEnumerable<ConsignacionDTO> Consignaciones { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Fondo.DTO
{
    public class PersonaDTO
    {
        public int Id { get; set; }
        public string Cedula { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Activo { get; set; }
        public string Banco { get; set; }
        public string NumeroCuenta { get; set; }
        public double MontoAhorro { get; set; }
        public bool Afiliado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public byte? Quincena { get; set; }
        public List<PrestamoDTO> Prestamos { get; set; }
        public List<ConsignacionDTO> Consignaciones { get; set; }

    }
}

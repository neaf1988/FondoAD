using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.DAL
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Ingrese el número de cédula de la persona")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Ingrese los nombres de la persona")]
        public string Nombres { get; set; }
        [Required(ErrorMessage = "Ingrese los apellidos de la persona")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Ingrese el teléfono de la persona")]
        public string Telefono { get; set; }
        
        public string Direccion { get; set; }
        [Required(ErrorMessage = "Ingrese el correo elctrónico de la persona")]
        public string CorreoElectronico { get; set; }
        
        public bool Activo { get; set; }
        
        public string Banco { get; set; }
        
        public string NumeroCuenta { get; set; }
        
        public double MontoAhorro { get; set; }
        [Required(ErrorMessage = "Seleccione si la persona es afiliada al fondo")]
        public bool Afiliado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        
        public byte? Quincena { get; set; }

        public virtual List<Prestamo> Prestamos { get; set; }
        public virtual List<Consignacion> Consignaciones { get; set; }

    }
}

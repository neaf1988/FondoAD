using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Fondo.Web.Model
{
    public class PersonaMVC
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el número de cédula de la persona")]
        [Display(Name ="Cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "Ingrese los nombres de la persona")]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Ingrese los apellidos de la persona")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; }

        [Display(Name ="Teléfono")]
        [Required(ErrorMessage = "Ingrese el teléfono de la persona")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        public string Direccion { get; set; }

        [EmailAddress(ErrorMessage ="Debe ingresar un formato de correo válido")]
        [Display(Name = "Correo electrónico")]
        [Required(ErrorMessage = "Ingrese el correo elctrónico de la persona")]
        public string CorreoElectronico { get; set; }
        public bool Activo { get; set; }
        [Validators.AfiliadoValidation("Afiliado", ErrorMessage = "Si es afiliado debe ingresar el nombre del banco")]
        public string Banco { get; set; }

        [Display(Name = "Número de cuenta")]
        [Validators.AfiliadoValidation("Afiliado", ErrorMessage = "Si es afiliado debe ingresar un número de cuenta")]
        public string NumeroCuenta { get; set; }

        [Display(Name = "Monto de ahorro")]
        [Validators.MontoAhorroValidation("Afiliado",mensaje:"Si no es afiliado el monto debe ser cero",ErrorMessage ="Si es afiliado debe ingresar el monto a ahorrar mayor a cero")]
        [Required(ErrorMessage ="Ingrese el monto a ahorrar")]
        public double MontoAhorro { get; set; }

        [Required(ErrorMessage = "Seleccione si la persona es afiliada al fondo")]
        public bool Afiliado { get; set; }

        [Display(Name = "Fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

       [Validators.AfiliadoValidation("Afiliado",ErrorMessage ="Si es afiliado debe seleccionar una quincena")]
        public byte? Quincena { get; set; }
        public virtual List<PrestamoMVC> Prestamos { get; set; }
        public virtual List<ConsignacionMVC> Consignaciones { get; set; }

    }
}

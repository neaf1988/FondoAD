using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Fondo.Web.Model.Validators
{

    public class AfiliadoValidationAttribute : ValidationAttribute
    {
        private readonly string _afiliado;

        public AfiliadoValidationAttribute(string afiliado)
        {
            _afiliado = afiliado;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool isByte = false;
            byte? valueAsByte = null;
            string valueAsString = null;
            if (value is Byte)
            {
                valueAsByte = (byte)value;
                isByte = true;
            }
            else
            {
                valueAsString = (string)value;
            }
            PropertyInfo propertyAfiliado = validationContext.ObjectType.GetProperty(_afiliado);
            if (propertyAfiliado == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _afiliado));

            bool isAfiliado = (bool)propertyAfiliado.GetValue(validationContext.ObjectInstance, null);

            if (isByte && valueAsByte.HasValue && !isAfiliado)
            {
                return new ValidationResult("No es afiliado no debe seleccionar una quincena");
            }
            if (!isByte && string.IsNullOrEmpty(valueAsString) && isAfiliado)
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }


            return null;
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Fondo.Web.Model.Validators
{

    public class MontoAhorroValidationAttribute : ValidationAttribute
    {
        private readonly string _afiliado;
        private readonly string _mensaje;

        public MontoAhorroValidationAttribute(string afiliado, string mensaje)
        {
            _afiliado = afiliado;
            _mensaje = mensaje;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            double _value = (double)value;
            PropertyInfo propertyAfiliado = validationContext.ObjectType.GetProperty(_afiliado);
            if (propertyAfiliado == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _afiliado));

            bool fieldValue = (bool)propertyAfiliado.GetValue(validationContext.ObjectInstance, null);

            if(fieldValue &&  _value == 0)
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }
            else if (!fieldValue && _value>0)
            {
                return new ValidationResult(_mensaje);
            }
           
            return null;
        }


    }
}

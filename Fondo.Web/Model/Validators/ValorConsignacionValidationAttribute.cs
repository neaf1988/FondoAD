using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Fondo.Web.Model.Validators
{

    public class ValorConsignacionValidationFieldsAttributeAttribute : ValidationAttribute
    {
        private readonly string _fieldTipoConsignacion;
        private readonly string _fieldInteres;
        private readonly string _mensaje;

        public ValorConsignacionValidationFieldsAttributeAttribute(string fieldTipoConsignacion, string fieldInteres, string mensaje)
        {
            _fieldTipoConsignacion = fieldTipoConsignacion;
            _fieldInteres = fieldInteres;
            _mensaje = mensaje;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            float? _value = null;
            if(value != null)
            {
                _value = float.Parse(value.ToString());
            }
            PropertyInfo propertyFieldTipoconsignacion = validationContext.ObjectType.GetProperty(_fieldTipoConsignacion);
            PropertyInfo propertyFieldInteres = validationContext.ObjectType.GetProperty(_fieldInteres);

            if (propertyFieldTipoconsignacion == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _fieldTipoConsignacion));
            else if (propertyFieldInteres == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _fieldInteres));

            byte fieldTipoConsignacionValue = (byte)propertyFieldTipoconsignacion.GetValue(validationContext.ObjectInstance, null);

            float? fieldInteresValue = null;
            if (null != propertyFieldInteres.GetValue(validationContext.ObjectInstance, null))
            {
                fieldInteresValue = float.Parse(propertyFieldInteres.GetValue(validationContext.ObjectInstance, null).ToString());
            }
            

            if (fieldTipoConsignacionValue == 2 && (!_value.HasValue || (_value.HasValue && _value.Value == 0)))
            {
                return new ValidationResult(this.FormatErrorMessage(validationContext.DisplayName));
            }
            else if (fieldTipoConsignacionValue == 1 && (!_value.HasValue || (_value.HasValue && _value.Value == 0)) && (!fieldInteresValue.HasValue || (fieldInteresValue.HasValue && fieldInteresValue.Value == 0)))
            {
                return new ValidationResult(_mensaje);
            }
           
            return null;
        }


    }
}

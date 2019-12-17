using Fondo.DAL;
using Fondo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Fondo.Web.Model.Validators
{
    internal class ValorConsignadoAttribute : ValidationAttribute
    {
        private readonly string _fieldTipoConsignacion;
        private readonly string _fieldPersonaId;
        private readonly string _fieldInteres;

        public ValorConsignadoAttribute(string fieldTipoConsignacion, string fieldPersonaId, string fieldInteres)
        {
            _fieldTipoConsignacion = fieldTipoConsignacion;
            _fieldPersonaId = fieldPersonaId;
            _fieldInteres = fieldInteres;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contextOptionsService = (DbContextOptions<FondoContext>)validationContext.GetService(typeof(DbContextOptions<FondoContext>));
            double? valorConsignado = null;
            if (value != null)
            {
                valorConsignado = Convert.ToDouble(value.ToString());
            }
            else
            {
                PropertyInfo propertyFieldIntereses = validationContext.ObjectType.GetProperty(_fieldInteres);
                double? fieldInteresValue = (double?)propertyFieldIntereses.GetValue(validationContext.ObjectInstance, null);
                if (fieldInteresValue.HasValue)
                {
                    return null;
                }
                else
                {
                    return new ValidationResult("El valor consignado no es valido");
                }
            }
            PropertyInfo propertyFieldTipoconsignacion = validationContext.ObjectType.GetProperty(_fieldTipoConsignacion);
            PropertyInfo propertyFieldPersonaId = validationContext.ObjectType.GetProperty(_fieldPersonaId);
            if (propertyFieldTipoconsignacion == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _fieldTipoConsignacion));
            if (propertyFieldPersonaId == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _fieldPersonaId));
            byte fieldTipoConsignacionValue = (byte)propertyFieldTipoconsignacion.GetValue(validationContext.ObjectInstance, null);
            int fieldPersonaIdValue = (int)propertyFieldPersonaId.GetValue(validationContext.ObjectInstance, null);
            IConsignacionRepository consignacionRepository = new ConsignacionRepository(contextOptionsService);
            IPrestamoRepository prestamoRepository = new PrestamoRepository(contextOptionsService);
            var prestamoActivo = prestamoRepository.GetPrestamoActivoPersona(fieldPersonaIdValue);
            if (fieldTipoConsignacionValue == 1 && !consignacionRepository.MontoValido(valorConsignado, prestamoActivo))
            {
                return new ValidationResult(ErrorMessage);
            }

            return null;
        }
    }
}
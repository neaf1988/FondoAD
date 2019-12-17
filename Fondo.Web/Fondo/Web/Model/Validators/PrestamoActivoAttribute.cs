using Fondo.DAL;
using Fondo.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Fondo.Web.Model.Validators
{
    internal class PrestamoActivoAttribute : ValidationAttribute
    {
        private readonly string _fieldTipoConsignacion;

        public PrestamoActivoAttribute(string fieldTipoConsignacion)
        {
            _fieldTipoConsignacion = fieldTipoConsignacion;
        }


        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var contextOptionsService = (DbContextOptions<FondoContext>)validationContext.GetService(typeof(DbContextOptions<FondoContext>));
            int? personaId = null;
            if (value != null)
            {
                personaId = Convert.ToInt32(value.ToString());
            }
            PropertyInfo propertyFieldTipoconsignacion = validationContext.ObjectType.GetProperty(_fieldTipoConsignacion);
            if (propertyFieldTipoconsignacion == null)
                return new ValidationResult(string.Format("Property '{0}' is undefined.", _fieldTipoConsignacion));
            byte fieldTipoConsignacionValue = (byte)propertyFieldTipoconsignacion.GetValue(validationContext.ObjectInstance, null);
            IPrestamoRepository prestamoRepository = new PrestamoRepository(contextOptionsService);
            var prestamoActivo = prestamoRepository.GetPrestamoActivoPersona(personaId.Value);
            if (fieldTipoConsignacionValue == 1 && null == prestamoActivo)
            {
                return new ValidationResult(ErrorMessage);
            }

            return null;
        }
    }
}
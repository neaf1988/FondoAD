using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fondo.DAL;
using Fondo.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Fondo.Web.Pages.Shared
{
    public class AlertsPartialModel : PageModel
    {
        DbContextOptions<FondoContext> _dbContext;
        IPersonaRepository _personaRepository;
        IPrestamoRepository _prestamoRepository;
        IConsignacionRepository _consignacionRepository;
        public int NumberAlertsTotal{get; set;}
        public int NumberAlertsPrestamo { get; set; } = 0;
        public int NumberAlertsAhorro { get; set; } = 0;

        public AlertsPartialModel() : base()
        {

        }

        public AlertsPartialModel(DbContextOptions<FondoContext> dbContext) : base()
        {
            int countAlerts = 0;
            var hoy = DateTime.Today;
            _dbContext = dbContext;
            _personaRepository = new PersonaRepository(_dbContext);
            _prestamoRepository = new PrestamoRepository(_dbContext);
            _consignacionRepository = new ConsignacionRepository(_dbContext);
            var afiliadosActivos = _personaRepository.Get(x => x.Activo && x.Afiliado, new string[] { "Consignaciones", "Prestamos" });
            
            foreach (var afiliado in afiliadosActivos)
            {
                var ultimaConsignacion = afiliado.Consignaciones.Where(x=>x.TipoConsignacion == 2).LastOrDefault();
                var diffDias = 0;
                if (ultimaConsignacion != null)
                {
                    diffDias = ((TimeSpan)(hoy - ultimaConsignacion.Fecha)).Days;
                }
                if (ultimaConsignacion == null && (hoy.Month > 1 || (afiliado.Quincena.Value == 1 && hoy.Day > 5) || (afiliado.Quincena.Value == 2 && hoy.Day > 15)))
                {
                    countAlerts++;
                }
                else if (diffDias > 30)
                {
                    countAlerts++;
                }
                else if (afiliado.Quincena.HasValue && (afiliado.Quincena.Value == 1 && diffDias > 5) || (afiliado.Quincena.Value == 2 && diffDias > 15))
                {
                    countAlerts++;
                }
            }
            NumberAlertsAhorro = countAlerts;
            countAlerts = 0;
            var prestamosActivos = _prestamoRepository.Get(x => !x.Finalizado, new string[] { "Persona" });
            foreach (var prestamo in prestamosActivos)
            {
                var diffDias = 0;
                var fechaLimite = new DateTime(hoy.Year, hoy.Month, prestamo.Fecha.Day);
                var consignacion = _consignacionRepository.Get(x=>x.PersonaId == prestamo.PersonaId && x.TipoConsignacion == 1 && x.Interes.HasValue && x.Interes>0).LastOrDefault();
                if(consignacion != null)
                {
                    diffDias = ((TimeSpan)(fechaLimite - consignacion.Fecha)).Days;
                    if(diffDias > 30)
                    {
                        countAlerts++;
                    }

                }
                else
                {
                    diffDias = ((TimeSpan)(fechaLimite - prestamo.Fecha)).Days;
                    if (diffDias > 30)
                    {
                        countAlerts++;
                    }
                }
            }
            NumberAlertsPrestamo = countAlerts;
            NumberAlertsTotal = NumberAlertsPrestamo + NumberAlertsAhorro;
        }


        public void OnGet()
        {
            Console.Write("Onget");
        }
    }
}
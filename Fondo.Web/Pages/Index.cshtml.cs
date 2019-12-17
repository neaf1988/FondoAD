using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fondo.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fondo.Web.Pages
{
    public class IndexModel : PageModel
    {
        private IConsignacionRepository _consignacionRepository;
        private IPrestamoRepository _prestamoRepository;
        private IParametrosRepository _parametrosRepository;
        public double? ahorrado;
        public double? prestado;
        public double? interes;
        public double? disponible;
        public IndexModel(IConsignacionRepository consinacionRepository, IPrestamoRepository prestamoRepository,IParametrosRepository parametrosRepository)
        {
            _consignacionRepository = consinacionRepository;
            _prestamoRepository = prestamoRepository;
            _parametrosRepository = parametrosRepository;
        }

        public void OnGet()
        {
            var anhoParametrizado = Convert.ToInt32( _parametrosRepository.Get(x => x.Nombre.Equals("año")).FirstOrDefault().Valor1);
            ahorrado = _consignacionRepository.Get(x => x.Fecha.Year == anhoParametrizado && x.TipoConsignacion == 2).Sum(x => x.Valor);
            interes = _consignacionRepository.Get(x => x.Fecha.Year == anhoParametrizado && x.TipoConsignacion == 1).Sum(x => x.Interes);
            prestado = _prestamoRepository.Get(x => x.Fecha.Year == anhoParametrizado && !x.Finalizado).Sum(x => x.Valor);
            disponible = ahorrado + interes - prestado;
        }
    }
}

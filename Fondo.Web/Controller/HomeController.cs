using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Fondo.Web
{
    public class HomeController : Controller
    {
        [HttpPost]
        /// <returns></returns>
        public IActionResult Search(string id)
        {
            return RedirectToAction("Search","Personas",new { id });
        }
    }
}
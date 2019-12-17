using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fondo.Web.Pages
{
    public class SearchModel : PageModel
    {
        public SearchModel()
        {
            Console.WriteLine("Constructor");
        }
        public void OnPost()
        {
            var data = Request.Form["searchBox"];
            RedirectToAction("Search", "Personas", new { id = data });
        }
    }

}

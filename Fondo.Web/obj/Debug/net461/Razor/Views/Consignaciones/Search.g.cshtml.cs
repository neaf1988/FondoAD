#pragma checksum "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4ab86ff87014ca97b3f13ea0ed3b5f5b03c7ab3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Views.Consignaciones.Views_Consignaciones_Search), @"mvc.1.0.view", @"/Views/Consignaciones/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consignaciones/Search.cshtml", typeof(Fondo.Web.Views.Consignaciones.Views_Consignaciones_Search))]
namespace Fondo.Web.Views.Consignaciones
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\_ViewImports.cshtml"
using Fondo.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4ab86ff87014ca97b3f13ea0ed3b5f5b03c7ab3", @"/Views/Consignaciones/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f25c81c608dc4c67669954815bfa11dc1f3859", @"/Views/_ViewImports.cshtml")]
    public class Views_Consignaciones_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Fondo.Web.Model.ConsignacionMVC>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Consignaciones";

#line default
#line hidden
            BeginContext(130, 90, true);
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(221, 43, false);
#line 14 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Persona));

#line default
#line hidden
            EndContext();
            BeginContext(264, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(320, 52, false);
#line 17 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoConsignacion));

#line default
#line hidden
            EndContext();
            BeginContext(372, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(428, 41, false);
#line 20 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(469, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(525, 43, false);
#line 23 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Interes));

#line default
#line hidden
            EndContext();
            BeginContext(568, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(624, 41, false);
#line 26 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(665, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(721, 49, false);
#line 29 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(770, 88, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(907, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(968, 70, false);
#line 40 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
               Write(String.Format("{0} {1}", item.Persona.Nombres, item.Persona.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(1038, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 43 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
                     if (item.TipoConsignacion == 1)
                    {

#line default
#line hidden
            BeginContext(1162, 45, true);
            WriteLiteral("                        <div>Prestamo</div>\r\n");
            EndContext();
#line 46 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(1279, 43, true);
            WriteLiteral("                        <div>Ahorro</div>\r\n");
            EndContext();
#line 50 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
                    }

#line default
#line hidden
            BeginContext(1345, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1413, 40, false);
#line 54 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1453, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1521, 42, false);
#line 57 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
               Write(Html.DisplayFor(modelItem => item.Interes));

#line default
#line hidden
            EndContext();
            BeginContext(1563, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1631, 33, false);
#line 60 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
               Write(item.Fecha.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1732, 41, false);
#line 63 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
               Write(item.FechaRegistro.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1773, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 66 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(1828, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Fondo.Web.Model.ConsignacionMVC>> Html { get; private set; }
    }
}
#pragma warning restore 1591

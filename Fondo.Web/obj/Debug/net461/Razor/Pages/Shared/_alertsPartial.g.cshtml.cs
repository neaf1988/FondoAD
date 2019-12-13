#pragma checksum "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e6b3fd7fbaa53c663187197b93988bd4088b77d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Pages.Shared.Pages_Shared__alertsPartial), @"mvc.1.0.razor-page", @"/Pages/Shared/_alertsPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Shared/_alertsPartial.cshtml", typeof(Fondo.Web.Pages.Shared.Pages_Shared__alertsPartial), null)]
namespace Fondo.Web.Pages.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\_ViewImports.cshtml"
using Fondo.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e6b3fd7fbaa53c663187197b93988bd4088b77d", @"/Pages/Shared/_alertsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c5c7c9aebf82722073bcaec974b05f43d8c565", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__alertsPartial : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(157, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 8 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
  
    var semaforoAhorro = "badge badge-";
    var semaforoPrestamo = "badge badge-";
    var s = new AlertsPartialModel(ContextOptions);

    if (s.NumberAlertsAhorro >= 1 && s.NumberAlertsAhorro <= 4)
    {
        semaforoAhorro += "primary";
    }
    else if (s.NumberAlertsAhorro >= 5 && s.NumberAlertsAhorro <= 8)
    {
        semaforoAhorro += "warning";
    }
    else
    {
        semaforoAhorro += "danger";
    }
    if (s.NumberAlertsPrestamo >= 1 && s.NumberAlertsPrestamo <= 4)
    {
        semaforoPrestamo += "primary";
    }
    else if (s.NumberAlertsPrestamo >= 5 && s.NumberAlertsPrestamo <= 8)
    {
        semaforoPrestamo += "warning";
    }
    else
    {
        semaforoPrestamo += "danger";
    }

#line default
#line hidden
#line 38 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
 if (s.NumberAlertsTotal > 0)
{

#line default
#line hidden
            BeginContext(1051, 328, true);
            WriteLiteral(@"    <!-- Navbar -->
    <ul class=""navbar-nav ml-auto ml-md-0"">
        <li class=""nav-item dropdown no-arrow mx-1"">
            <a class=""nav-link dropdown-toggle"" href=""#"" id=""alertsDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                <span class=""badge badge-danger"">");
            EndContext();
            BeginContext(1380, 19, false);
#line 44 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                                            Write(s.NumberAlertsTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1399, 155, true);
            WriteLiteral(" </span><i class=\"fas fa-bell fa-fw\"></i>\r\n            </a>\r\n            <div class=\"dropdown-menu dropdown-menu-right\" aria-labelledby=\"alertsDropdown\">\r\n");
            EndContext();
#line 47 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                 if (s.NumberAlertsAhorro > 0)
                {

#line default
#line hidden
            BeginContext(1621, 77, true);
            WriteLiteral("                    <a class=\"dropdown-item\" href=\"#\">Pendientes ahorro <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1698, "\"", 1721, 1);
#line 49 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
WriteAttributeValue("", 1706, semaforoAhorro, 1706, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1722, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1724, 20, false);
#line 49 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                                                                                                 Write(s.NumberAlertsAhorro);

#line default
#line hidden
            EndContext();
            BeginContext(1744, 13, true);
            WriteLiteral("</span></a>\r\n");
            EndContext();
#line 50 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(1776, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 51 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                 if (s.NumberAlertsPrestamo > 0)
                {

#line default
#line hidden
            BeginContext(1845, 79, true);
            WriteLiteral("                    <a class=\"dropdown-item\" href=\"#\">Pendientes prestamo <span");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1924, "\"", 1949, 1);
#line 53 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
WriteAttributeValue("", 1932, semaforoPrestamo, 1932, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1950, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1952, 22, false);
#line 53 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                                                                                                     Write(s.NumberAlertsPrestamo);

#line default
#line hidden
            EndContext();
            BeginContext(1974, 13, true);
            WriteLiteral("</span></a>\r\n");
            EndContext();
#line 54 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
                }

#line default
#line hidden
            BeginContext(2006, 48, true);
            WriteLiteral("\r\n            </div>\r\n        </li>\r\n    </ul>\r\n");
            EndContext();
#line 59 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Pages\Shared\_alertsPartial.cshtml"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.EntityFrameworkCore.DbContextOptions<Fondo.DAL.FondoContext> ContextOptions { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlertsPartialModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AlertsPartialModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AlertsPartialModel>)PageContext?.ViewData;
        public AlertsPartialModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

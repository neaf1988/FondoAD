#pragma checksum "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e2f380c5cf598566791db0061600c034a9267b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(Fondo.Web.Pages.Pages_Index), null)]
namespace Fondo.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\_ViewImports.cshtml"
using Fondo.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e2f380c5cf598566791db0061600c034a9267b", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5c5c7c9aebf82722073bcaec974b05f43d8c565", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";
    

#line default
#line hidden
            BeginContext(77, 485, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-xl-3 col-sm-6 mb-3"">
        <div class=""card text-white bg-primary o-hidden h-100"">
            <div class=""card-body"">
                <div class=""card-body-icon"">
                    <i class=""fas fa-fw fa-piggy-bank""></i>
                </div>
                <div class=""mr-5"">Ahorrado</div>
            </div>
            <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                <span class=""float-left"">$ ");
            EndContext();
            BeginContext(563, 14, false);
#line 18 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml"
                                      Write(Model.ahorrado);

#line default
#line hidden
            EndContext();
            BeginContext(577, 650, true);
            WriteLiteral(@"</span>
                <span class=""float-right"">
                    <i class=""fas fa-angle-right""></i>
                </span>
            </a>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 mb-3"">
        <div class=""card text-white bg-warning o-hidden h-100"">
            <div class=""card-body"">
                <div class=""card-body-icon"">
                    <i class=""fas fa-fw fa-comment-dollar""></i>
                </div>
                <div class=""mr-5"">Disponible</div>
            </div>
            <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                <span class=""float-left"">$ ");
            EndContext();
            BeginContext(1228, 16, false);
#line 34 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml"
                                      Write(Model.disponible);

#line default
#line hidden
            EndContext();
            BeginContext(1244, 640, true);
            WriteLiteral(@"</span>
                <span class=""float-right"">
                    <i class=""fas fa-angle-right""></i>
                </span>
            </a>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 mb-3"">
        <div class=""card text-white bg-success o-hidden h-100"">
            <div class=""card-body"">
                <div class=""card-body-icon"">
                    <i class=""fas fa-fw fa-coins""></i>
                </div>
                <div class=""mr-5"">Intereses</div>
            </div>
            <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                <span class=""float-left"">$ ");
            EndContext();
            BeginContext(1885, 13, false);
#line 50 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml"
                                      Write(Model.interes);

#line default
#line hidden
            EndContext();
            BeginContext(1898, 644, true);
            WriteLiteral(@"</span>
                <span class=""float-right"">
                    <i class=""fas fa-angle-right""></i>
                </span>
            </a>
        </div>
    </div>
    <div class=""col-xl-3 col-sm-6 mb-3"">
        <div class=""card text-white bg-danger o-hidden h-100"">
            <div class=""card-body"">
                <div class=""card-body-icon"">
                    <i class=""fas fa-fw fa-dollar-sign""></i>
                </div>
                <div class=""mr-5"">Prestado</div>
            </div>
            <a class=""card-footer text-white clearfix small z-1"" href=""#"">
                <span class=""float-left"">$ ");
            EndContext();
            BeginContext(2543, 14, false);
#line 66 "C:\Users\fabio.quintero\Source\Repos\FondoAD\Fondo.Web\Pages\Index.cshtml"
                                      Write(Model.prestado);

#line default
#line hidden
            EndContext();
            BeginContext(2557, 192, true);
            WriteLiteral("</span>\r\n                <span class=\"float-right\">\r\n                    <i class=\"fas fa-angle-right\"></i>\r\n                </span>\r\n            </a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

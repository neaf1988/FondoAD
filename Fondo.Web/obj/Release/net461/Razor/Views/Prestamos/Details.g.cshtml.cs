#pragma checksum "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48059e3d253e0f9abf3e5ec473c543fd68619681"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Views.Prestamos.Views_Prestamos_Details), @"mvc.1.0.view", @"/Views/Prestamos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prestamos/Details.cshtml", typeof(Fondo.Web.Views.Prestamos.Views_Prestamos_Details))]
namespace Fondo.Web.Views.Prestamos
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48059e3d253e0f9abf3e5ec473c543fd68619681", @"/Views/Prestamos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f25c81c608dc4c67669954815bfa11dc1f3859", @"/Views/_ViewImports.cshtml")]
    public class Views_Prestamos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fondo.Web.Model.PrestamoMVC>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
  
    ViewData["Title"] = "Prestamos-Detalles";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(117, 113, true);
            WriteLiteral("\r\n<div class=\"card mb-3\">\r\n    <div class=\"card-header\">\r\n        <i class=\"fas fa-table\"></i>\r\n        Detalles ");
            EndContext();
            BeginContext(231, 47, false);
#line 11 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
            Write(Html.DisplayFor(model => model.Persona.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(278, 6, true);
            WriteLiteral("&nbsp;");
            EndContext();
            BeginContext(285, 49, false);
#line 11 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                                                                  Write(Html.DisplayFor(model => model.Persona.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(334, 258, true);
            WriteLiteral(@"
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>  ");
            EndContext();
            BeginContext(593, 41, false);
#line 18 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(634, 37, true);
            WriteLiteral("</th>\r\n                        <th>  ");
            EndContext();
            BeginContext(672, 43, false);
#line 19 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Interes));

#line default
#line hidden
            EndContext();
            BeginContext(715, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(752, 41, false);
#line 20 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(793, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(830, 49, false);
#line 21 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                        Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(879, 143, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n                    <tr>\r\n                        <td>  ");
            EndContext();
            BeginContext(1023, 37, false);
#line 27 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1096, 39, false);
#line 28 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Interes));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1171, 34, false);
#line 29 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                       Write(Model.Fecha.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1205, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1241, 42, false);
#line 30 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                       Write(Model.FechaRegistro.ToString("yyyy-MM-dd"));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 168, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <div class=\"card-footer small text-muted\">\r\n        ");
            EndContext();
            BeginContext(1451, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03368eebb65640f9920c625f85dbfc75", async() => {
                BeginContext(1536, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Prestamos\Details.cshtml"
                                                                      WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1546, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1556, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40750a1369b74f928db654d3bbcdc5d7", async() => {
                BeginContext(1606, 8, true);
                WriteLiteral("Regresar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1618, 24, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fondo.Web.Model.PrestamoMVC> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de5f2e9f93beb705721b39c3d4f7a73d2a99a01a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Views.Consignaciones.Views_Consignaciones_Delete), @"mvc.1.0.view", @"/Views/Consignaciones/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Consignaciones/Delete.cshtml", typeof(Fondo.Web.Views.Consignaciones.Views_Consignaciones_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de5f2e9f93beb705721b39c3d4f7a73d2a99a01a", @"/Views/Consignaciones/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f25c81c608dc4c67669954815bfa11dc1f3859", @"/Views/_ViewImports.cshtml")]
    public class Views_Consignaciones_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fondo.Web.Model.ConsignacionMVC>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Consignación-Eliminar";

#line default
#line hidden
            BeginContext(124, 359, true);
            WriteLiteral(@"
<h3 class=""text-danger"">Va eliminar esta consignación, desea continuar?</h3>
<div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>
                            ");
            EndContext();
            BeginContext(484, 52, false);
#line 16 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.TipoConsignacion));

#line default
#line hidden
            EndContext();
            BeginContext(536, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(628, 41, false);
#line 19 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(669, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(761, 41, false);
#line 22 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Fecha));

#line default
#line hidden
            EndContext();
            BeginContext(802, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(894, 49, false);
#line 25 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(943, 91, true);
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
            EndContext();
            BeginContext(1035, 43, false);
#line 28 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Persona));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 197, true);
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n                    <tr>\r\n                        <td>\r\n                            \r\n");
            EndContext();
#line 36 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                             if(Model.TipoConsignacion == 1)
                            {

#line default
#line hidden
            BeginContext(1368, 57, true);
            WriteLiteral("                                <div>Consignación</div>\r\n");
            EndContext();
#line 39 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1521, 51, true);
            WriteLiteral("                                <div>Ahorro</div>\r\n");
            EndContext();
#line 43 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                            }

#line default
#line hidden
            BeginContext(1603, 91, true);
            WriteLiteral("                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1695, 37, false);
#line 47 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1732, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1826, 31, false);
#line 51 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Model.Fecha.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1857, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1951, 45, false);
#line 55 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.FechaRegistro));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 93, true);
            WriteLiteral("\r\n                        </td>\r\n\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2090, 70, false);
#line 59 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
                       Write(String.Format("{0} {1}",Model.Persona.Nombres,Model.Persona.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(2160, 154, true);
            WriteLiteral("\r\n                            \r\n                        </td>\r\n                    </tr>\r\n                </tbody>\r\n\r\n            </table>\r\n\r\n            ");
            EndContext();
            BeginContext(2314, 236, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55fa1bd77548449fb25e225547bedd14", async() => {
                BeginContext(2340, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(2358, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3fbc5509701648e9ae93750b7474ae01", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 68 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Consignaciones\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2394, 101, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n                ");
                EndContext();
                BeginContext(2495, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56cce6f617f7455a9d6d2f0815727ea1", async() => {
                    BeginContext(2517, 8, true);
                    WriteLiteral("Regresar");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2529, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2550, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fondo.Web.Model.ConsignacionMVC> Html { get; private set; }
    }
}
#pragma warning restore 1591

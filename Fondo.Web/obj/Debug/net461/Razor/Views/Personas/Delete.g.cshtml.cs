#pragma checksum "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "586e3d11c3f1d78f528c4944a1e696fa98509162"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Fondo.Web.Views.Personas.Views_Personas_Delete), @"mvc.1.0.view", @"/Views/Personas/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Personas/Delete.cshtml", typeof(Fondo.Web.Views.Personas.Views_Personas_Delete))]
namespace Fondo.Web.Views.Personas
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"586e3d11c3f1d78f528c4944a1e696fa98509162", @"/Views/Personas/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f25c81c608dc4c67669954815bfa11dc1f3859", @"/Views/_ViewImports.cshtml")]
    public class Views_Personas_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Fondo.Web.Model.PersonaMVC>
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
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Personas-Eliminar";

#line default
#line hidden
            BeginContext(115, 344, true);
            WriteLiteral(@"
<h3 class=""text-danger"">Va eliminar esta persona, desea continuar?</h3>
<div>
  

    <hr />
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>  ");
            EndContext();
            BeginContext(460, 42, false);
#line 18 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                         Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(502, 37, true);
            WriteLiteral("</th>\r\n                        <th>  ");
            EndContext();
            BeginContext(540, 43, false);
#line 19 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                         Write(Html.DisplayNameFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(583, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(620, 45, false);
#line 20 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(665, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(702, 44, false);
#line 21 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(746, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(783, 45, false);
#line 22 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(828, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(865, 53, false);
#line 23 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.CorreoElectronico));

#line default
#line hidden
            EndContext();
            BeginContext(918, 36, true);
            WriteLiteral("</th>\r\n                        <th> ");
            EndContext();
            BeginContext(955, 51, false);
#line 24 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                        Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1006, 143, true);
            WriteLiteral("</th>\r\n                    </tr>\r\n                </thead>\r\n\r\n                <tbody>\r\n                    <tr>\r\n                        <td>  ");
            EndContext();
            BeginContext(1150, 38, false);
#line 30 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                         Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
            EndContext();
            BeginContext(1188, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1224, 39, false);
#line 31 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
            EndContext();
            BeginContext(1263, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1299, 41, false);
#line 32 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
            EndContext();
            BeginContext(1340, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1376, 40, false);
#line 33 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Telefono));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1452, 41, false);
#line 34 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
            EndContext();
            BeginContext(1493, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1529, 49, false);
#line 35 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.CorreoElectronico));

#line default
#line hidden
            EndContext();
            BeginContext(1578, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1614, 47, false);
#line 36 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.FechaNacimiento));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 120, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n\r\n                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n\r\n    ");
            EndContext();
            BeginContext(1781, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3d0e781d0ca14134a2aed2eb91053a90", async() => {
                BeginContext(1807, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1817, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c4cbec67d4124e11a97c1ed7f0e215a4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 46 "C:\Users\fabio.quintero\Source\Repos\Fondo\Fondo.Web\Views\Personas\Delete.cshtml"
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
                BeginContext(1853, 85, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1938, 34, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce6260d2d7b045e1810c8520411ec34a", async() => {
                    BeginContext(1960, 8, true);
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
                BeginContext(1972, 6, true);
                WriteLiteral("\r\n    ");
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
            BeginContext(1985, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Fondo.Web.Model.PersonaMVC> Html { get; private set; }
    }
}
#pragma warning restore 1591

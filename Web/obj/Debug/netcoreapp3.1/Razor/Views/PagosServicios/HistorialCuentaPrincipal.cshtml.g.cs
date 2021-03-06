#pragma checksum "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b1aa32d9eeb8da79e48670be436747483a4964"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PagosServicios_HistorialCuentaPrincipal), @"mvc.1.0.view", @"/Views/PagosServicios/HistorialCuentaPrincipal.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\fastpay\FastPayProyect\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\fastpay\FastPayProyect\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b1aa32d9eeb8da79e48670be436747483a4964", @"/Views/PagosServicios/HistorialCuentaPrincipal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_PagosServicios_HistorialCuentaPrincipal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Web.ViewModel.TransationDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/pagoServicioIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
  
    ViewData["Title"] = "Historial Pago";
    ViewData["Modulo"] = "Pagos de Servicios";
    ViewData["IdRol"] = "1";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <div class=""card-header border-0"">
        <h2 class=""card-title"">Historial de Pagos Generales</h2>
    </div>

    <div class=""card-body"">
        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Servicio</th>
                        <th>Tipo de Servicio</th>
                        <th>Monto</th>
                        <th>No. Servicio</th>
                        <th>Fecha</th>
                        <th>Usuario Correo</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th>");
#nullable restore
#line 32 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                           Write(item.ServicioName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 33 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                           Write(item.ServicioTipo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>$");
#nullable restore
#line 34 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                            Write(item.Monto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 35 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                           Write(item.ReferenciaPago);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 36 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                           Write(item.FechaCreacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th>");
#nullable restore
#line 37 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                           Write(item.Correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                        </tr>\r\n");
#nullable restore
#line 40 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n\r\n            </table>\r\n        </div>\r\n\r\n    </div>\r\n\r\n    <div class=\"card-footer py-4\">\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1425, "\"", 1469, 1);
#nullable restore
#line 51 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
WriteAttributeValue("", 1432, Url.Action("Index","PagosServicios"), 1432, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger float-right\">Atras</a>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b1aa32d9eeb8da79e48670be436747483a49647550", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    <script>\r\n        let GetServicosById = \'");
#nullable restore
#line 65 "D:\fastpay\FastPayProyect\Web\Views\PagosServicios\HistorialCuentaPrincipal.cshtml"
                          Write(Url.Action("GetServicoById", "PagosServicios"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n    </script>\r\n\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Web.ViewModel.TransationDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157268927853dace37c4a23ed6a8ad565b5bcb7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PagosServicios_CreatePago), @"mvc.1.0.view", @"/Views/PagosServicios/CreatePago.cshtml")]
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
#line 1 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157268927853dace37c4a23ed6a8ad565b5bcb7c", @"/Views/PagosServicios/CreatePago.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_PagosServicios_CreatePago : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.ViewModel.ServicosDto>
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
#line 3 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
  
    ViewData["Title"] = "Pagar" + Model.Nombre;
    ViewData["Modulo"] = "Pagos de Servicios";
    ViewData["IdRol"] = "1";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header border-0\">\r\n        <h2 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
                          Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n\r\n    <div class=\"card-body\">\r\n");
#nullable restore
#line 16 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
         using (Html.BeginForm("SavePago", "PagosServicios", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"form-group\">\r\n                <label for=\"exampleInputEmail1\">Monto</label>\r\n                <input type=\"email\" class=\"form-control\" id=\"exampleInputEmail1\" aria-describedby=\"emailHelp\" placeholder=\"Monto\">\r\n");
            WriteLiteral("            </div>\r\n");
            WriteLiteral("            <button type=\"submit\" class=\"btn btn-success float-right\"><i class=\"far fa-money-bill-alt\"></i> Pagar</button>\r\n");
#nullable restore
#line 29 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"card-footer py-4\">\r\n\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1246, "\"", 1290, 1);
#nullable restore
#line 35 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
WriteAttributeValue("", 1253, Url.Action("Index","PagosServicios"), 1253, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger float-right\">Atras</a>\r\n");
            WriteLiteral("    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "157268927853dace37c4a23ed6a8ad565b5bcb7c6012", async() => {
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
#line 52 "C:\Users\gi.rivas\Documents\FastPayApp\FastPayProyect\Web\Views\PagosServicios\CreatePago.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.ViewModel.ServicosDto> Html { get; private set; }
    }
}
#pragma warning restore 1591

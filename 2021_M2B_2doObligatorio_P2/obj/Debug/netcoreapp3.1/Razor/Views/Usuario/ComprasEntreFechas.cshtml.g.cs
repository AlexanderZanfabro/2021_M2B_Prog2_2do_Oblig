#pragma checksum "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3f4533b3ccefda65bf28b3bfb31da100d36603"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ComprasEntreFechas), @"mvc.1.0.view", @"/Views/Usuario/ComprasEntreFechas.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc3f4533b3ccefda65bf28b3bfb31da100d36603", @"/Views/Usuario/ComprasEntreFechas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ComprasEntreFechas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comprasEntreFechas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Registro de compras entre fechas seleccionadas</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc3f4533b3ccefda65bf28b3bfb31da100d366034178", async() => {
                WriteLiteral(@"
    <label>Ingrese primer fecha</label>
    <input type=""datetime-local"" name=""f1"" id=""f1"" > <!--required para que no quede el campo vac??o ?-->
    <br>
    <label>Ingrese segunda fecha</label>
    <input type=""datetime-local"" name=""f2"" id=""f2"" >
    <br>

    <br>

    <input type=""submit"" value=""Buscar"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<p id=\"pMensaje\">");
#nullable restore
#line 17 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
            Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
  
    ViewData["Title"] = "ComprasEntreFechas";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 27 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Listado</h1>\r\n");
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Id   ");
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Actividad Comprada  ");
            WriteLiteral(@"
                </th>
                <th>
                    Cantidad de Entradas
                </th>
                <th>
                    Id de Usuario que Compra
                </th>
                <th>
                    Fecha y Hora
                </th>
                <th>
                    Estado
                </th>
                <th>
                    Precio de las Entradas
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 58 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 62 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ActividadComprada.NombreActividad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CantidadEntradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.IdUsuarioQueCompra));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaYhora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
                   Write(item.PrecioFinalEntrada);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 93 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ComprasEntreFechas.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!--------------------------------------------------- Util si se ingresan campos de texto ------------------------------->\r\n\r\n\r\n");
            WriteLiteral(@"        <script>
            document.querySelector(""#comprasEntreFechas"").addEventListener(""submit"", verificaCampo);

            function verificaCampo(evento) {
                evento.preventDefault();

                let fecha1 = document.querySelector(""#f1"").value;
                let fecha2 = document.querySelector(""#f2"").value;

                if (fecha1 != """" && fecha2 != """") {
                    this.submit();
                } else {
                    document.querySelector(""#pMensaje"").innerHTML = ""Error. Debe ingresar un rangos de fechas "";
                }

            }


        </script>
");
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n<!---------------------------------------------------------------------------------------------------------------------->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90e8fc860c021a08ccbcc537904d9bbe69e78b25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_MisCompras), @"mvc.1.0.view", @"/Views/Usuario/MisCompras.cshtml")]
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
#line 1 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90e8fc860c021a08ccbcc537904d9bbe69e78b25", @"/Views/Usuario/MisCompras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_MisCompras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Compra>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
  
    ViewData["Title"] = "ListaDeCompras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"text-align: center\">No hay ninguna compra registrada a su nombre</h3>\r\n");
#nullable restore
#line 10 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Nombre de la actividad</th>
                <th>Fecha y hora de la compra</th>
                <th>Cantidad de entradas</th>
                <th>Precio final</th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 24 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ActividadComprada.NombreActividad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FechaYhora));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CantidadEntradas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
                   Write(Html.DisplayFor(modelItem => item.PrecioFinalEntrada));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 36 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\MisCompras.cshtml"
}

#line default
#line hidden
#nullable disable
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
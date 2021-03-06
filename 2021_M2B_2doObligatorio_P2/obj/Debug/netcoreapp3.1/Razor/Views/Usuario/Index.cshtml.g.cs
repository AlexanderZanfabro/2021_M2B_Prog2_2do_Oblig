#pragma checksum "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c859357ce5511fc0a680b78312d921d608b4d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c859357ce5511fc0a680b78312d921d608b4d0", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Actividad>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1>Bienvenidos al portal del usuario</h1>

<h3>Lista de Actividades</h3>
<table>
    <thead>
        <tr>
            <th>Nombre Actividad</th>
            <th>Categoria</th>
            <th>Fecha y hora del Evento</th>
            <th>Precio de las entradas</th>
            <th>Cantidad de likes</th>
            <th></th><!--Se necesita, pero no es necesario poner nada-->
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 19 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
         foreach (var item in ViewBag.ListadoAct)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
           Write(item.NombreActividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
           Write(item.Categoria.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
           Write(item.FechaYhoraActividad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
           Write(item.CalcularPrecioFinal().ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
           Write(item.ContadorLikes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n");
#nullable restore
#line 28 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
                 if (Context.Session.GetString("usuarioLogUsername") != null && Context.Session.GetString("usuarioLogRol") == "Registrado")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <td>\r\n            ");
#nullable restore
#line 31 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
       Write(Html.ActionLink("Comprar entrada", "ComprarEntradas", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            /\r\n            ");
#nullable restore
#line 33 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
       Write(Html.ActionLink("Me gusta", "LikearActividad", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>");
#nullable restore
#line 34 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Usuario\source\repos\nuevo_nuevo\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<p>-----------------------------------------------------------------------------------------</p>\r\n<!--<td>");
            WriteLiteral("</td>-->\r\n<!--<td>");
            WriteLiteral("</td>-->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Actividad>> Html { get; private set; }
    }
}
#pragma warning restore 1591

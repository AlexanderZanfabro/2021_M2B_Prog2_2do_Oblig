#pragma checksum "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7583914b9afc0d51cf9c421b5949b265084e183e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7583914b9afc0d51cf9c421b5949b265084e183e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Portal de Actividades Culturales y Recreativas</h1>\r\n    <p>Para adquirir entradas debe registrarse como usuario</p>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml"
     if (Context.Session.GetString("usuarioLogUsername") != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Bienvenido/a ");
#nullable restore
#line 12 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml"
                   Write(Context.Session.GetString("usuarioLogNombre"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><!-- del ejemplo integrador-->\r\n");
#nullable restore
#line 13 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n</div>\r\n\r\n<div>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 470, "\"", 477, 0);
            EndWriteAttribute();
            WriteLiteral("></a> <!-- foto de portada-->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

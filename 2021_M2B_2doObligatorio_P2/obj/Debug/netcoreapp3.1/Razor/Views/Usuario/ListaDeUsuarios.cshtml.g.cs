#pragma checksum "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3b24b7e52762c484ae0ebc1e9afc10e5893d136"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ListaDeUsuarios), @"mvc.1.0.view", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3b24b7e52762c484ae0ebc1e9afc10e5893d136", @"/Views/Usuario/ListaDeUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ListaDeUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
  
    ViewData["Title"] = "ListaDeUsuarios";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListaDeUsuarios</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e3b24b7e52762c484ae0ebc1e9afc10e5893d1363967", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n");
            WriteLiteral("            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayNameFor(model => model.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 46 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 58 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 61 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rol));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
           Write(Html.DisplayFor(modelItem => item.Activo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 81 "C:\Users\Federico\Source\Repos\AlexanderZanfabro\2021_M2B_Prog2_2do_Oblig\2021_M2B_2doObligatorio_P2\Views\Usuario\ListaDeUsuarios.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591

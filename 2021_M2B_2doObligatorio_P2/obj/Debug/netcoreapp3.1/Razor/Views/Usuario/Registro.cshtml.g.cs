#pragma checksum "C:\Users\Usuario\source\repos\2021_M2B_2doObligatorio_P2\2021_M2B_2doObligatorio_P2\Views\Usuario\Registro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0a9c484f1256422c1400ce92c3e30dfe6cad8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Registro), @"mvc.1.0.view", @"/Views/Usuario/Registro.cshtml")]
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
#line 1 "C:\Users\Usuario\source\repos\2021_M2B_2doObligatorio_P2\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\2021_M2B_2doObligatorio_P2\2021_M2B_2doObligatorio_P2\Views\_ViewImports.cshtml"
using _2021_M2B_2doObligatorio_P2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0a9c484f1256422c1400ce92c3e30dfe6cad8b", @"/Views/Usuario/Registro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ac07ca3bd816823ddc9b28a34164a6759197a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Registro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registroUsuario"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Registro de nuevo usuario</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c0a9c484f1256422c1400ce92c3e30dfe6cad8b4050", async() => {
                WriteLiteral(@"
    <label>Nombre</label>
    <input type=""text"" name=""nombre"" id=""nombre"">
    <br>

    <label>Apellido</label>
    <input type=""text"" name=""apellido"" id=""apellido"">
    <br>
    <label>Email</label>
    <input type=""text"" name=""email"" id=""email"">
    <br>
    <label>Fecha de Nacimiento</label>
    <input type=""text"" name=""fechaNacimiento"" id=""fechaNacimiento"">
    <br>
    <label>Nombre de Usuario</label>
    <input type=""text"" name=""nombreUsuario"" id=""nombreUsuario"">
    <br>
    <label>Contraseña</label>
    <input type=""text"" name=""contrasenia"" id=""contrasenia"">
    <br>

    <input type=""submit"" value=""Registrarse"">
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
#line 27 "C:\Users\Usuario\source\repos\2021_M2B_2doObligatorio_P2\2021_M2B_2doObligatorio_P2\Views\Usuario\Registro.cshtml"
            Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
            WriteLiteral(@"    <script>
        document.querySelector(""#registroUsuario"").addEventListener(""submit"", controlForm);

        function controlForm(evento) {
            evento.preventDefault();
            let nombre = document.querySelector(""#nombre"").value;
            let apellido = document.querySelector(""#apellido"").value;
            let contrasenia = document.querySelector(""#contrasenia"").value;
            let email = document.querySelector(""#email"").value;
            let fechaNacimiento = document.querySelector(""#fechaNacimiento"").value;
            let nombreUsuario = document.querySelector(""#nombreUsuario"").value;



            if (nombre != """" && apellido != """" && email != """" && fechaNacimiento != """" && nombreUsuario != """" && contrasenia != """") {
                if (nombre.length >= 2 && apellido.length >= 2 && contrasenia.length >= 6) {

                    this.submit();
                } else {
                    document.querySelector(""#pMensaje"").innerHTML = ""Error. Es requerido un ");
            WriteLiteral("largo mínimo en el ingreso de datos \";\r\n                }\r\n\r\n\r\n            } else {\r\n                document.querySelector(\"#pMensaje\").innerHTML = \"Error. Falta ingresar de datos \";\r\n            }\r\n\r\n        }\r\n\r\n\r\n\r\n    </script>\r\n");
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

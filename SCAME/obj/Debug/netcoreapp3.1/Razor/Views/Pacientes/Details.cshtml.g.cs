#pragma checksum "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c58553ccae1e7c898bb582d3496201e7cf6df7b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_Details), @"mvc.1.0.view", @"/Views/Pacientes/Details.cshtml")]
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
#line 1 "/home/perez/Escritorio/SCAME/SCAME/Views/_ViewImports.cshtml"
using SCAME;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/perez/Escritorio/SCAME/SCAME/Views/_ViewImports.cshtml"
using SCAME.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c58553ccae1e7c898bb582d3496201e7cf6df7b0", @"/Views/Pacientes/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53eeb5e3a3e55f94db18e45c453e930461fe6949", @"/Views/_ViewImports.cshtml")]
    public class Views_Pacientes_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCAME.Models.Paciente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-get-started scrollto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br/>\n<br/>\n<section id=\"hero\" class=\"d-flex align-items-center\">\n    <div class=\"container\">\n      <h1>Detalle Paciente</h1>\n      <h2>\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 14 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 17 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Cedula));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 20 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 23 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimerNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 23 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
                                                     Write(Html.DisplayFor(model => model.SegundoNombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 26 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 29 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.PrimerApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.SegundoApellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 32 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 35 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 38 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PruebaCovid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            <a class=\"icon-sli-docs\"");
            BeginWriteAttribute("href", " href=\"", 1318, "\"", 1358, 1);
#nullable restore
#line 41 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
WriteAttributeValue("", 1325, "/PdfPac/" + Model.PruebaCovid, 1325, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Prueba</a>\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 44 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CasoConfirmado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 47 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.CasoConfirmado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 50 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discapacidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 53 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Discapacidad.NombreDiscapacidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 56 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumeroCarnet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 59 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.NumeroCarnet));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 62 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 65 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Porcentaje));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 68 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Canton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 71 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Canton.NombreCanton));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 74 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 77 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
       Write(Html.DisplayFor(model => model.Sexo.NombreSexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c58553ccae1e7c898bb582d3496201e7cf6df7b011568", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "/home/perez/Escritorio/SCAME/SCAME/Views/Pacientes/Details.cshtml"
                           WriteLiteral(Model.IdPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c58553ccae1e7c898bb582d3496201e7cf6df7b013755", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n</h2>\n </div>\n  </section>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCAME.Models.Paciente> Html { get; private set; }
    }
}
#pragma warning restore 1591
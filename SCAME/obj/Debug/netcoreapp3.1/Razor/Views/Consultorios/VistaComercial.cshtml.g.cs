#pragma checksum "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c52ef49573751d19ea28a958e6ca1141b6b992"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultorios_VistaComercial), @"mvc.1.0.view", @"/Views/Consultorios/VistaComercial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c52ef49573751d19ea28a958e6ca1141b6b992", @"/Views/Consultorios/VistaComercial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53eeb5e3a3e55f94db18e45c453e930461fe6949", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultorios_VistaComercial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SCAME.Models.Consultorio>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:30px; height:30px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Citas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h6>\n    Imagen\n</h6>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39c52ef49573751d19ea28a958e6ca1141b6b9924167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 5 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
WriteLiteral("/Image/" + Model.First().ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 5 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<h6>\n    ");
#nullable restore
#line 7 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayNameFor(model => model.NombreConsultorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<h6>\n    ");
#nullable restore
#line 10 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayFor(model => model.First().NombreConsultorio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<h6>\n    Contacto\n</h6>\n<h6>\n    ");
#nullable restore
#line 16 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayFor(model => model.First().User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<h6>\n    Correo\n</h6>\n<h6>\n    ");
#nullable restore
#line 22 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayFor(model => model.First().User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<h6>\n    ");
#nullable restore
#line 25 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayNameFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<h6>\n    ");
#nullable restore
#line 28 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
Write(Html.DisplayFor(model => model.First().Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h6>\n<table>\n    <thead>\n        <tr>\n            <th>Nombre del especialista</th>\n            <th>Especialidad</th>\n            <th>Precio</th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 39 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 42 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
   Write(Html.DisplayFor(modelItem => item.Medicos.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
                                                        Write(Html.DisplayFor(model => item.Medicos.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 43 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
   Write(Html.DisplayFor(modelItem => item.Medicos.Detalle.Especialidad.NombreEspecialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 44 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
   Write(Html.DisplayFor(modelItem => item.Medicos.Detalle.PrecioEspecialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\n    <td>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c52ef49573751d19ea28a958e6ca1141b6b9929406", async() => {
                WriteLiteral("Agendar Cita");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idC", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
                                                         WriteLiteral(item.IdConsultorio);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idC"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idC", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idC"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
                                                                                             WriteLiteral(item.Medicos.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idM"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idM", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idM"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
                                                                                                                              WriteLiteral(item.Medicos.Detalle.EspecialidadId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idE", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idE"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </td>\n</tr>");
#nullable restore
#line 48 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/VistaComercial.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SCAME.Models.Consultorio>> Html { get; private set; }
    }
}
#pragma warning restore 1591
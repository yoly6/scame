#pragma checksum "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f579a320c07aae3a70a8712fa938aa4dd7a88e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Consultorios_Delete), @"mvc.1.0.view", @"/Views/Consultorios/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f579a320c07aae3a70a8712fa938aa4dd7a88e7", @"/Views/Consultorios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53eeb5e3a3e55f94db18e45c453e930461fe6949", @"/Views/_ViewImports.cshtml")]
    public class Views_Consultorios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCAME.Models.Consultorio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
  
    ViewData["Title"] = "Eliminar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""col-md-12"">
        <h1 class=""h1 text-strong text-center padding"">Eliminar <small>Consultorio</small></h1>
        <h3>¿Éstas seguro de eliminar? no se podrá recuperar la Información</h3>
        <hr />
        <div>
            <div class=""form-row"">
                <div class=""col-md-1 mb-2"">
                    <p class=""form-group"">Imagen</p>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f579a320c07aae3a70a8712fa938aa4dd7a88e76073", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                   WriteLiteral("/image/" + Model.ImageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">");
#nullable restore
#line 18 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                     Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <label class=\"form-group\">");
#nullable restore
#line 19 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">");
#nullable restore
#line 22 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                     Write(Html.DisplayNameFor(model => model.Ruc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <label class=\"form-group\"> ");
#nullable restore
#line 23 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.Ruc));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">Nombre del Consultorio</p>\n                    <label class=\"form-group\"> ");
#nullable restore
#line 27 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.NombreConsultorio));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-md-1 mb-2""></div>
                <div class=""col-md-3 mb-2"">
                    <p class=""form-group"">Cédula del Representante Legal</p>
                    <label class=""form-group"">");
#nullable restore
#line 34 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.CedulaRepresentanteLegal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">Nombre del Representate Legal</p>\n                    <label class=\"form-group\">\n                        ");
#nullable restore
#line 39 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                   Write(Html.DisplayFor(model => model.NombreRepresentateLegal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        ");
#nullable restore
#line 40 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                   Write(Html.DisplayFor(model => model.ApellidoRepresentanteLegal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </label>\n                </div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">");
#nullable restore
#line 44 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                     Write(Html.DisplayNameFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <label class=\"form-group\"> ");
#nullable restore
#line 45 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.User.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n\n            </div>\n            <div class=\"form-row\">\n                <div class=\"col-md-1 mb-2\"></div>\n                <div class=\"col-md-3 mb-2\">\n                    <p class=\"form-group\">");
#nullable restore
#line 52 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                     Write(Html.DisplayNameFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <label class=\"form-group\">");
#nullable restore
#line 53 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.User.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n                <div class=\"col-md-6 mb-2\">\n                    <p class=\"form-group\"> Dirección</p>\n                    <label class=\"form-group\">");
#nullable restore
#line 57 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
                </div>
            </div>
            <div class=""form-row"">
                <div class=""col-md-1 mb-2""></div>
                <div class=""col-md-5 mb-2"">
                    <p class=""form-group"">Patente Municipal</p>
                    <label class=""form-group"">");
#nullable restore
#line 64 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.NumPatenteMunicipal));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n                </div>\n                <div class=\"col-md-5 mb-2\">\n                    <p class=\"form-group\">Permiso de Funcionamiento otorgado por el MSP</p>\n                    <label class=\"form-group\">");
#nullable restore
#line 68 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.PermisoFuncionamientoMsp));

#line default
#line hidden
#nullable disable
            WriteLiteral(")</label>\n                </div>\n            </div>\n            <div class=\"form-row \">\n                <div class=\"form-group col-md-1 mb-3\"></div>\n                <div class=\"form-group col-md-2 mb-3\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f579a320c07aae3a70a8712fa938aa4dd7a88e714782", async() => {
                WriteLiteral("\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f579a320c07aae3a70a8712fa938aa4dd7a88e715061", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 75 "/home/perez/Escritorio/SCAME/SCAME/Views/Consultorios/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdConsultorio);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                        <input type=\"submit\" value=\"Eliminar\" class=\"btn btn-danger\" />\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n                <div class=\"form-group col-md-6 mb-3\"> </div>\n                <div class=\"form-group col-md-2 mb-3\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f579a320c07aae3a70a8712fa938aa4dd7a88e718170", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n            <br />\n            <br />\n\n        </div>\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCAME.Models.Consultorio> Html { get; private set; }
    }
}
#pragma warning restore 1591

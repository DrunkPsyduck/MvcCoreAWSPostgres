#pragma checksum "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Home\CifradoHashEficiente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "015ee69d03c3f975d9d868b9b364bd19c53405d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CifradoHashEficiente), @"mvc.1.0.view", @"/Views/Home/CifradoHashEficiente.cshtml")]
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
#line 1 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\_ViewImports.cshtml"
using MvcCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\_ViewImports.cshtml"
using MvcCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\_ViewImports.cshtml"
using MvcCore.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"015ee69d03c3f975d9d868b9b364bd19c53405d5", @"/Views/Home/CifradoHashEficiente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f72e8bb6f8b9df4de5f89ef7a833231391d2f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CifradoHashEficiente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Cifrado Hash Eficiente</h1>\r\n\r\n");
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Home\CifradoHashEficiente.cshtml"
Write(Html.Raw(ViewData["MENSAJE"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "015ee69d03c3f975d9d868b9b364bd19c53405d54380", async() => {
                WriteLiteral(@"
    <label>Iteraciones: </label>
    <input type=""text"" name=""iteraciones""
           class=""form-control""/><br/>
    <label>Salt: </label>
    <input type=""text"" name=""salt"" class=""form-control""/><br/>
    <label>Contenido: </label>
    <input type=""text"" name=""contenido"" class=""form-control""/><br/>
    <label>Resultado: </label>
    <input name=""resultado"" class=""form-control""");
                BeginWriteAttribute("value", " value=\"", 480, "\"", 510, 1);
#nullable restore
#line 14 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Home\CifradoHashEficiente.cshtml"
WriteAttributeValue("", 488, ViewData["RESULTADO"], 488, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/><br/>\r\n    <button type=\"submit\" class=\"btn btn-danger\" name=\"accion\"\r\n             value=\"cifrar\">Cifrar</button>\r\n    <button type=\"submit\" name=\"accion\" value=\"comparar\"\r\n            class=\"btn btn-info\">Comparar</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>");
#nullable restore
#line 20 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\Home\CifradoHashEficiente.cshtml"
Write(ViewData["RESULTADO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
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

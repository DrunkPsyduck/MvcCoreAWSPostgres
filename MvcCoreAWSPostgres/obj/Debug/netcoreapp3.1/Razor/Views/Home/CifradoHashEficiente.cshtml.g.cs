#pragma checksum "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Home\CifradoHashEficiente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a871bc5eb84f798aba39eefc12f7b29782f99c5"
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
#line 1 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\_ViewImports.cshtml"
using MvcCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\_ViewImports.cshtml"
using MvcCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\_ViewImports.cshtml"
using MvcCore.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a871bc5eb84f798aba39eefc12f7b29782f99c5", @"/Views/Home/CifradoHashEficiente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab535407c6438a76d6e0f6ecd085d873fc62c0b", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("<h1>Cifrado Hash Eficiente</h1>\n\n");
#nullable restore
#line 3 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Home\CifradoHashEficiente.cshtml"
Write(Html.Raw(ViewData["MENSAJE"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a871bc5eb84f798aba39eefc12f7b29782f99c54198", async() => {
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
                BeginWriteAttribute("value", " value=\"", 467, "\"", 497, 1);
#nullable restore
#line 14 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Home\CifradoHashEficiente.cshtml"
WriteAttributeValue("", 475, ViewData["RESULTADO"], 475, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/><br/>\n    <button type=\"submit\" class=\"btn btn-danger\" name=\"accion\"\n             value=\"cifrar\">Cifrar</button>\n    <button type=\"submit\" name=\"accion\" value=\"comparar\"\n            class=\"btn btn-info\">Comparar</button>\n");
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
            WriteLiteral("\n<p>");
#nullable restore
#line 20 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Home\CifradoHashEficiente.cshtml"
Write(ViewData["RESULTADO"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
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

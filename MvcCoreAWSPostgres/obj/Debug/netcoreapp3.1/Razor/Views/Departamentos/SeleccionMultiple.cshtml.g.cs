#pragma checksum "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fe58f4db8b29dbd5cb6a38ecd4a0f81e1f9bfe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_SeleccionMultiple), @"mvc.1.0.view", @"/Views/Departamentos/SeleccionMultiple.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fe58f4db8b29dbd5cb6a38ecd4a0f81e1f9bfe4", @"/Views/Departamentos/SeleccionMultiple.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab535407c6438a76d6e0f6ecd085d873fc62c0b", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_SeleccionMultiple : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Empleado>>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
  
    ViewData["Title"] = "SeleccionMultiple";
    List<Departamento> departamentos =
        ViewData["DEPARTAMENTOS"] as List<Departamento>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("styles", async() => {
                WriteLiteral(" \n    <style>\n        ul#menu li{\n            display: inline;\n        }\n    </style>\n");
            }
            );
            WriteLiteral("\n<h1>Seleccion Múltiple empleados</h1>\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fe58f4db8b29dbd5cb6a38ecd4a0f81e1f9bfe44600", async() => {
                WriteLiteral("\n    <ul id=\"menu\" class=\"list-group\">\n");
#nullable restore
#line 21 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
         foreach (Departamento dept in departamentos)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <li class=\"list-group-item\">\n                <input type=\"checkbox\" name=\"iddepartamentos\"\n                       class=\"form-check\"");
                BeginWriteAttribute("value", " value=\"", 588, "\"", 608, 1);
#nullable restore
#line 25 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
WriteAttributeValue("", 596, dept.Numero, 596, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                ");
#nullable restore
#line 26 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
           Write(dept.Nombre);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n            </li>\n");
#nullable restore
#line 28 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </ul>\n    <br/>\n    <button type=\"submit\" class=\"btn-success\">Mostrar empleados</button>\n");
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
            WriteLiteral("\n\n");
#nullable restore
#line 34 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-danger\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 40 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
               Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 43 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
               Write(Html.DisplayNameFor(model => model.Oficio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 46 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
               Write(Html.DisplayNameFor(model => model.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 49 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
               Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 55 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td>\n                        ");
#nullable restore
#line 59 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 62 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Oficio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 65 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Salario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        ");
#nullable restore
#line 68 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Departamento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                </tr>\n");
#nullable restore
#line 71 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
#nullable restore
#line 74 "C:\Users\mario\Documents\mvccore-master\MvcCore\Views\Departamentos\SeleccionMultiple.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c04d32b3317e36f7edfb04fcedba58d1ea203439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmpleadosSession_AlmacenarEmpleados), @"mvc.1.0.view", @"/Views/EmpleadosSession/AlmacenarEmpleados.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c04d32b3317e36f7edfb04fcedba58d1ea203439", @"/Views/EmpleadosSession/AlmacenarEmpleados.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3f72e8bb6f8b9df4de5f89ef7a833231391d2f3", @"/Views/_ViewImports.cshtml")]
    public class Views_EmpleadosSession_AlmacenarEmpleados : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MvcCore.Models.Empleado>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MostrarEmpleados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "EmpleadosSession", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AlmacenarEmpleados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/groot.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50px; height:50px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
  
    ViewData["Title"] = "Almacenar Empleados";
    List<int> sessionemp = 
        Context.Session.GetObject<List<int>>("EMPLEADOS");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Almacenar Empleados Session</h1>\r\n<h2 style=\"color:rebeccapurple\">\r\n    ");
#nullable restore
#line 11 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
Write(ViewData["MENSAJE"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04d32b3317e36f7edfb04fcedba58d1ea2034396277", async() => {
                WriteLiteral("Mostrar Session");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
           Write(Html.DisplayNameFor(model => model.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
           Write(Html.DisplayNameFor(model => model.Oficio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 30 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
           Write(Html.DisplayFor(modelItem => item.Oficio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 39 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                 if (sessionemp == null)
                {
                    //PINTAMOS ALMACENAR

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04d32b3317e36f7edfb04fcedba58d1ea2034399903", async() => {
                WriteLiteral("\r\n                        Almacenar\r\n                    ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idempleado", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                                 WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idempleado"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idempleado", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idempleado"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                }
                else if (!sessionemp.Contains(item.IdEmpleado))
                {
                    //PINTAMOS ALMACENAR

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c04d32b3317e36f7edfb04fcedba58d1ea20343912796", async() => {
                WriteLiteral("\r\n                        Almacenar\r\n                    ");
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
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idempleado", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                                 WriteLiteral(item.IdEmpleado);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idempleado"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idempleado", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idempleado"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                }
                else
                {
                    //EXISTE EN LA SESSION

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c04d32b3317e36f7edfb04fcedba58d1ea20343915649", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 65 "C:\Users\AlumnoMCSD\Documents\0-master\MvcCoreAWSPostgres\MvcCoreAWSPostgres\Views\EmpleadosSession\AlmacenarEmpleados.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MvcCore.Models.Empleado>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb0fec7a796849e98fbc1c3a441129fef57b12e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(airlineBOOM.Pages.Office.Views_Office_createFlightSetting), @"mvc.1.0.view", @"/Views/Office/createFlightSetting.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Office/createFlightSetting.cshtml", typeof(airlineBOOM.Pages.Office.Views_Office_createFlightSetting))]
namespace airlineBOOM.Pages.Office
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\_ViewImports.cshtml"
using airlineBOOM;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb0fec7a796849e98fbc1c3a441129fef57b12e8", @"/Views/Office/createFlightSetting.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e3702683434e526607cfb324a8272a6bf20ca0", @"/Views/_ViewImports.cshtml")]
    public class Views_Office_createFlightSetting : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<airlineBOOM.Models.FlightSetting>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block mt-3 btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "createFlight", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Create flight setting"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "office", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "createFlightSetting", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 31, true);
            WriteLiteral("<!-- Dependency injection -->\r\n");
            EndContext();
            BeginContext(72, 24, true);
            WriteLiteral("\r\n<!-- Page itself -->\r\n");
            EndContext();
#line 5 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
  
    ViewData["Title"] = "Create Flight Setting";

#line default
#line hidden
            BeginContext(153, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(155, 1571, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bfc58ed656de4858a05f1982fb78458f", async() => {
                BeginContext(232, 227, true);
                WriteLiteral("\r\n    <h1> Create Flight Setting </h1>\r\n\r\n    <!-- #region Meteorology, visibility & setoff values of the flight setting -->\r\n    <!-- Meteorology -->\r\n    <h2 class=\"mt-2\"> Meteorology </h2>\r\n\r\n    <!-- Meteorology score -->\r\n");
                EndContext();
#line 17 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
     for (int i = 0; i <= 10; i++)
    {

#line default
#line hidden
                BeginContext(502, 140, true);
                WriteLiteral("        <div class=\"form-check form-check-inline\">\r\n            <input class=\"form-check-input\" type=\"radio\" name=\"flightSettingMeteorology\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 642, "", 651, 1);
#line 20 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
WriteAttributeValue("", 649, i, 649, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(651, 65, true);
                WriteLiteral(">\r\n            <label class=\"form-check-label\">\r\n                ");
                EndContext();
                BeginContext(717, 1, false);
#line 22 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(718, 40, true);
                WriteLiteral("\r\n            </label>\r\n        </div>\r\n");
                EndContext();
#line 25 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
    }

#line default
#line hidden
                BeginContext(765, 100, true);
                WriteLiteral("\r\n    <!-- Visibility -->\r\n    <h2 class=\"mt-2\"> Visibility </h2>\r\n\r\n    <!-- Visibility score -->\r\n");
                EndContext();
#line 31 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
     for (int i = 0; i <= 10; i++)
    {

#line default
#line hidden
                BeginContext(908, 139, true);
                WriteLiteral("        <div class=\"form-check form-check-inline\">\r\n            <input class=\"form-check-input\" type=\"radio\" name=\"flightSettingVisibility\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1047, "", 1056, 1);
#line 34 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
WriteAttributeValue("", 1054, i, 1054, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1056, 65, true);
                WriteLiteral(">\r\n            <label class=\"form-check-label\">\r\n                ");
                EndContext();
                BeginContext(1122, 1, false);
#line 36 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1123, 40, true);
                WriteLiteral("\r\n            </label>\r\n        </div>\r\n");
                EndContext();
#line 39 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
    }

#line default
#line hidden
                BeginContext(1170, 88, true);
                WriteLiteral("\r\n    <!-- Setoff -->\r\n    <h2 class=\"mt-2\"> Setoff </h2>\r\n\r\n    <!-- Setoff score -->\r\n");
                EndContext();
#line 45 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
     for (int i = 0; i <= 10; i++)
    {

#line default
#line hidden
                BeginContext(1301, 135, true);
                WriteLiteral("        <div class=\"form-check form-check-inline\">\r\n            <input class=\"form-check-input\" type=\"radio\" name=\"flightSettingSetoff\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 1436, "", 1445, 1);
#line 48 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
WriteAttributeValue("", 1443, i, 1443, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1445, 65, true);
                WriteLiteral(">\r\n            <label class=\"form-check-label\">\r\n                ");
                EndContext();
                BeginContext(1511, 1, false);
#line 50 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
           Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1512, 40, true);
                WriteLiteral("\r\n            </label>\r\n        </div>\r\n");
                EndContext();
#line 53 "C:\Users\El Alvaro\Desktop\airlineBOOM\airlineBOOM\Views\Office\createFlightSetting.cshtml"
    }

#line default
#line hidden
                BeginContext(1559, 31, true);
                WriteLiteral("    <!-- #endregion -->\r\n\r\n    ");
                EndContext();
                BeginContext(1590, 127, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0b51c6178c0446d58ac6adf7619455b6", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1717, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<airlineBOOM.Models.FlightSetting> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\SARA DOKUMENTI\Desktop\KraenProekt\WebProjectEndApp\WebProjectEndWebApp\Views\EventsWebContent\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03cd6ff2d0e12e6a334c7672ef67be00cd4bb4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EventsWebContent_Add), @"mvc.1.0.view", @"/Views/EventsWebContent/Add.cshtml")]
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
#line 1 "D:\SARA DOKUMENTI\Desktop\KraenProekt\WebProjectEndApp\WebProjectEndWebApp\Views\_ViewImports.cshtml"
using WebProjectEndWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SARA DOKUMENTI\Desktop\KraenProekt\WebProjectEndApp\WebProjectEndWebApp\Views\_ViewImports.cshtml"
using WebProjectEndWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03cd6ff2d0e12e6a334c7672ef67be00cd4bb4a9", @"/Views/EventsWebContent/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dced6dd230a1228d00ffaf6148e4f98117f6d2d0", @"/Views/_ViewImports.cshtml")]
    public class Views_EventsWebContent_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row g-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\SARA DOKUMENTI\Desktop\KraenProekt\WebProjectEndApp\WebProjectEndWebApp\Views\EventsWebContent\Add.cshtml"
  
    Layout = "_ActionLayout";
    ViewData["Header"] = "Event";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 class=\"text-center\">Add ");
#nullable restore
#line 6 "D:\SARA DOKUMENTI\Desktop\KraenProekt\WebProjectEndApp\WebProjectEndWebApp\Views\EventsWebContent\Add.cshtml"
                        Write(ViewData["Header"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<br />\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd6ff2d0e12e6a334c7672ef67be00cd4bb4a94415", async() => {
                WriteLiteral(@"
    <div class=""col-md-6"">
        <label for=""inputEmail4"" class=""form-label"">Email</label>
        <input type=""email"" class=""form-control"" id=""inputEmail4"">
    </div>
    <div class=""col-md-6"">
        <label for=""inputPassword4"" class=""form-label"">Password</label>
        <input type=""password"" class=""form-control"" id=""inputPassword4"">
    </div>
    <div class=""col-12"">
        <label for=""inputAddress"" class=""form-label"">Address</label>
        <input type=""text"" class=""form-control"" id=""inputAddress"" placeholder=""1234 Main St"">
    </div>
    <div class=""col-12"">
        <label for=""inputAddress2"" class=""form-label"">Address 2</label>
        <input type=""text"" class=""form-control"" id=""inputAddress2"" placeholder=""Apartment, studio, or floor"">
    </div>
    <div class=""col-md-6"">
        <label for=""inputCity"" class=""form-label"">City</label>
        <input type=""text"" class=""form-control"" id=""inputCity"">
    </div>
    <div class=""col-md-4"">
        <label for=""inputState"" class=");
                WriteLiteral("\"form-label\">State</label>\r\n        <select id=\"inputState\" class=\"form-select\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd6ff2d0e12e6a334c7672ef67be00cd4bb4a95901", async() => {
                    WriteLiteral("Choose...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03cd6ff2d0e12e6a334c7672ef67be00cd4bb4a97253", async() => {
                    WriteLiteral("...");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </select>
    </div>
    <div class=""col-md-2"">
        <label for=""inputZip"" class=""form-label"">Zip</label>
        <input type=""text"" class=""form-control"" id=""inputZip"">
    </div>
    <div class=""col-12"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
            <label class=""form-check-label"" for=""gridCheck"">
                Check me out
            </label>
        </div>
    </div>
    <div class=""col-12"">
        <button type=""submit"" class=""btn btn-primary"">Sign in</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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

#pragma checksum "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "074355c0a3605cd2fd304d273916cd0bfa0255af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Menu_Default))]
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
#line 1 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\_ViewImports.cshtml"
using WebKonopelko;

#line default
#line hidden
#line 2 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\_ViewImports.cshtml"
using WebKonopelko.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"074355c0a3605cd2fd304d273916cd0bfa0255af", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6fc231a5fa06e84d84e0795d515a4661499cbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(32, 32, true);
            WriteLiteral("\r\n    <div class=\"navbar-nav\">\r\n");
            EndContext();
#line 5 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#line 7 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
             if (item.IsPage)
            {

#line default
#line hidden
            BeginContext(159, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(175, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf40666715764f05b45a42462645319c", async() => {
                BeginContext(301, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(324, 9, false);
#line 12 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
               Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(333, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 185, "nav-item", 185, 8, true);
            AddHtmlAttributeValue(" ", 193, "nav-link", 194, 9, true);
#line 9 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 202, item.Active, 203, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 10 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
                 WriteLiteral(item.Area);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 11 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
                 WriteLiteral(item.Page);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(405, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(421, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a998a1a9baa245a5a074f486ea37a633", async() => {
                BeginContext(563, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(586, 9, false);
#line 20 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
               Write(item.Text);

#line default
#line hidden
                EndContext();
                BeginContext(595, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 431, "nav-item", 431, 8, true);
            AddHtmlAttributeValue(" ", 439, "nav-link", 440, 9, true);
#line 17 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 448, item.Active, 449, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 18 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
                       WriteLiteral(item.Controller);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 19 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
                   WriteLiteral(item.Action);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(617, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
            }

#line default
#line hidden
#line 22 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Shared\Components\Menu\Default.cshtml"
             
        }

#line default
#line hidden
            BeginContext(645, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591

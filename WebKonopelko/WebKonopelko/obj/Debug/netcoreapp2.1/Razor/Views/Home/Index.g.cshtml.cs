#pragma checksum "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "452479f134d62cbde703028327e18772c6e6a6d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"452479f134d62cbde703028327e18772c6e6a6d1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6fc231a5fa06e84d84e0795d515a4661499cbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Главная страница";

#line default
#line hidden
            BeginContext(50, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(55, 16, false);
#line 5 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
Write(ViewData["Text"]);

#line default
#line hidden
            EndContext();
            BeginContext(71, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
            BeginContext(166, 17, true);
            WriteLiteral("\r\n<ol type=\"A\">\r\n");
            EndContext();
#line 12 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
     for (int i = 1; i < 5; i++)
    {

#line default
#line hidden
            BeginContext(224, 20, true);
            WriteLiteral("        <li>элемент ");
            EndContext();
            BeginContext(245, 1, false);
#line 14 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(246, 14, true);
            WriteLiteral(" списка</li>\r\n");
            EndContext();
#line 15 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(267, 9, true);
            WriteLiteral("</ol>\r\n\r\n");
            EndContext();
            BeginContext(276, 2200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ce01f5e1dd24d29b7c6767cd51c84e5", async() => {
                BeginContext(282, 26, true);
                WriteLiteral("\r\n    <h1>Форма</h1>\r\n    ");
                EndContext();
                BeginContext(308, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f1a757860f544499a425c8b422b42fd", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 20 "E:\GitHub\WebKonopelko\WebKonopelko\WebKonopelko\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewData["Lst"] as SelectList;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(368, 2101, true);
                WriteLiteral(@"
    <div class=""form-group"">
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
            <label class=""form-check-label"" for=""gridCheck"">
                Чек-бокс 1
            </label>
        </div>
        <div class=""form-check"">
            <input class=""form-check-input"" type=""checkbox"" id=""gridCheck"">
            <label class=""form-check-label"" for=""gridCheck"">
                Чек-бокс 2
            </label>
        </div>
    </div>


    <fieldset class=""form-group"">
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio1"" value=""option1"">
            <label class=""form-check-label"" for=""inlineRadio1"">Радио 1</label>
        </div>
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio2"" value=""option2"">
            <label class=");
                WriteLiteral(@"""form-check-label"" for=""inlineRadio2"">Радио 2</label>
        </div>
        <div class=""form-check form-check-inline"">
            <input class=""form-check-input"" type=""radio"" name=""inlineRadioOptions"" id=""inlineRadio3"" value=""option3"">
            <label class=""form-check-label"" for=""inlineRadio3"">Радио 3</label>
        </div>
    </fieldset>

    <div class=""form-group row"">
        <label for=""inputEmail3"" class=""col-sm-2 col-form-label"">Логин</label>
        <div class=""col-sm-6"">
            <input type=""email"" class=""form-control"" id=""inputEmail3"" placeholder=""Введите логин"">
        </div>
    </div>
    <div class=""form-group row"">
        <label for=""inputPassword3"" class=""col-sm-2 col-form-label"">Пароль</label>
        <div class=""col-sm-6"">
            <input type=""password"" class=""form-control"" id=""inputPassword3"" placeholder=""Введите пароль"">
        </div>
    </div>
    <fieldset class=""form-group"">
        <div>
            <button type=""submit"" class=""btn btn-primary"">");
                WriteLiteral("Отправить</button>\r\n        </div>\r\n    </fieldset>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2476, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

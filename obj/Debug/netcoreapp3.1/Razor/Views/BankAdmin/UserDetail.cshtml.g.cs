#pragma checksum "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6654f4f5efe7ea352a38bfa829c103e084f3482b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BankAdmin_UserDetail), @"mvc.1.0.view", @"/Views/BankAdmin/UserDetail.cshtml")]
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
#line 1 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\_ViewImports.cshtml"
using Tata_Power_App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6654f4f5efe7ea352a38bfa829c103e084f3482b", @"/Views/BankAdmin/UserDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9e731ed5185126f44a251a627985c2f5c7bb32", @"/_ViewImports.cshtml")]
    public class Views_BankAdmin_UserDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "bankadmin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div style=\"padding:10px\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6654f4f5efe7ea352a38bfa829c103e084f3482b4012", async() => {
                WriteLiteral("Go Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"card-deck\">\r\n            <div class=\"card m-3\">\r\n                <div class=\"card-header\">\r\n                    <h3>");
#nullable restore
#line 7 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n                </div>\r\n                <div class=\"card-footer text-center\">\r\n                    <h4>");
#nullable restore
#line 11 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>");
#nullable restore
#line 12 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>");
#nullable restore
#line 13 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userAccountNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>");
#nullable restore
#line 14 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userAccountBalance);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                    <h4>");
#nullable restore
#line 15 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\BankAdmin\UserDetail.cshtml"
                   Write(Model.userAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
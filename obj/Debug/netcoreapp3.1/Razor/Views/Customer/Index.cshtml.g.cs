#pragma checksum "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28cf0202141e333ef04ea64e9c62f56d2af297a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28cf0202141e333ef04ea64e9c62f56d2af297a3", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9e731ed5185126f44a251a627985c2f5c7bb32", @"/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tata_Power_App.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul>\r\n    <li>");
#nullable restore
#line 3 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\Customer\Index.cshtml"
   Write(Model.customerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 4 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\Customer\Index.cshtml"
   Write(Model.customerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>");
#nullable restore
#line 5 "C:\Users\kumar.narendra\Downloads\Net core training\PracticeCodes\Tata-Power-App\Tata-Power-App\Views\Customer\Index.cshtml"
   Write(Model.customerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tata_Power_App.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
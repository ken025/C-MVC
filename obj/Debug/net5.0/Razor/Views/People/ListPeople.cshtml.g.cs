#pragma checksum "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4a77df6f2683a4901213c4b52ac15e80f2e4e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_ListPeople), @"mvc.1.0.view", @"/Views/People/ListPeople.cshtml")]
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
#line 1 "/Users/kennethmanuel/demomvc/Views/_ViewImports.cshtml"
using demomvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kennethmanuel/demomvc/Views/_ViewImports.cshtml"
using demomvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4a77df6f2683a4901213c4b52ac15e80f2e4e5", @"/Views/People/ListPeople.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0df3b0bf5efd96590b578a15c2b3de11e8957cc", @"/Views/_ViewImports.cshtml")]
    public class Views_People_ListPeople : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<demomvc.Models.PersonModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
  
    ViewData["Title"] = "ListPeople";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>List People:</h2>\n\n<p>\n    ");
#nullable restore
#line 10 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n\n<table class=\"table\">\n    <tr>\n        <th>\n            ");
#nullable restore
#line 16 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th>\n            ");
#nullable restore
#line 20 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th>\n            ");
#nullable restore
#line 24 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th>\n            ");
#nullable restore
#line 28 "/Users/kennethmanuel/demomvc/Views/People/ListPeople.cshtml"
       Write(Html.DisplayNameFor(model => model.IsAlive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </th>\n\n        <th></th>\n    </tr>\n\n   \n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<demomvc.Models.PersonModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
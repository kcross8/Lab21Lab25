#pragma checksum "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f5b0d80c6e67d0cccb2658b3eab1a489a9b78a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Receipt), @"mvc.1.0.view", @"/Views/Home/Receipt.cshtml")]
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
#line 1 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\_ViewImports.cshtml"
using Lab21Lab25;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\_ViewImports.cshtml"
using Lab21Lab25.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5b0d80c6e67d0cccb2658b3eab1a489a9b78a8", @"/Views/Home/Receipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a62b2f03353b72be4af8783d2cb6d0534bb3f1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Receipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml"
  
    ViewData["Title"] = "Receipt";
    double totalprice = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Receipt</h1>\r\n<table>\r\n    <tr>\r\n        <th>Title</th>\r\n        <th>Price</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml"
     foreach (var film in Model)
    {
        totalprice += 6.99;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml"
           Write(film.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                $6.99\r\n            </td>            \r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n    <h2>Total: $");
#nullable restore
#line 24 "C:\Users\kyle\source\repos\Lab21Lab25\Lab21Lab25\Views\Home\Receipt.cshtml"
           Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <a href=\"ClearMovies\">Clear cart of all movies.</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591

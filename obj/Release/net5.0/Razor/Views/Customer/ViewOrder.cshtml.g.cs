#pragma checksum "D:\Assignment1\Views\Customer\ViewOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab0abafcf944613f58b9e16faf069e2f101d584b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ViewOrder), @"mvc.1.0.view", @"/Views/Customer/ViewOrder.cshtml")]
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
#line 1 "D:\Assignment1\Views\_ViewImports.cshtml"
using Assignment1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Assignment1\Views\_ViewImports.cshtml"
using Assignment1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab0abafcf944613f58b9e16faf069e2f101d584b", @"/Views/Customer/ViewOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85f0efab5ddbb0a5c18cf004c4d9e07516f4dd0e", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ViewOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
  
    ViewData["Title"] = "ViewOrder";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1 class=\"text-center\">Orders of \"");
#nullable restore
#line 5 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
                              Write(ViewBag.usname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""</h1>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Member Id</th>
            <th>Order Date</th>
            <th>Require Date</th>
            <th>Shipped Date</th>
            <th>Freight</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
         foreach (Order item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
               Write(item.MemberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
               Write(item.OrderDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
               Write(item.RequireDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
               Write(item.ShippedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
               Write(item.Freight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "D:\Assignment1\Views\Customer\ViewOrder.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2488c58029da75eb547e4d776c52dcac71b404a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Show), @"mvc.1.0.view", @"/Views/Vendors/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Show.cshtml", typeof(AspNetCore.Views_Vendors_Show))]
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
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
using VendorTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2488c58029da75eb547e4d776c52dcac71b404a5", @"/Views/Vendors/Show.cshtml")]
    public class Views_Vendors_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(60, 61, true);
            WriteLiteral("\r\n<h3>Here are all the Orders this Vendor has.</h3>\r\n\r\n<ol>\r\n");
            EndContext();
#line 9 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
 foreach (Order order in @Model["orders"])
{

#line default
#line hidden
            BeginContext(168, 8, true);
            WriteLiteral("  <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 176, "\'", 228, 4);
            WriteAttributeValue("", 183, "/vendors/", 183, 9, true);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 192, Model["vendor"].Id, 192, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 211, "/orders/", 211, 8, true);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 219, order.Id, 219, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(229, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(231, 11, false);
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
                                                         Write(order.Title);

#line default
#line hidden
            EndContext();
            BeginContext(242, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 12 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
}

#line default
#line hidden
            BeginContext(256, 14, true);
            WriteLiteral("</ol>\r\n\r\n<p><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 270, "\'", 316, 3);
            WriteAttributeValue("", 277, "/vendors/", 277, 9, true);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Show.cshtml"
WriteAttributeValue("", 286, Model["vendor"].Id, 286, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 305, "/orders/new", 305, 11, true);
            EndWriteAttribute();
            BeginContext(317, 125, true);
            WriteLiteral(">Add a new Order</a></p>\r\n<p><a href=\'/vendors\'>Return to the Vendor List</a></p>\r\n<p><a href=\'/\'>Return to Home Page</a></p>");
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

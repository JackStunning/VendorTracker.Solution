#pragma checksum "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed8f3ea1b5ae1f324150182874c3f265b5f4783b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vendors_Index), @"mvc.1.0.view", @"/Views/Vendors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vendors/Index.cshtml", typeof(AspNetCore.Views_Vendors_Index))]
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
#line 1 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
using VendorTracker.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8f3ea1b5ae1f324150182874c3f265b5f4783b", @"/Views/Vendors/Index.cshtml")]
    public class Views_Vendors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(60, 22, true);
            WriteLiteral("\r\n<h2>Vendors</h2>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(110, 44, true);
            WriteLiteral("  <h4>No Vendors have been added yet!</h4>\r\n");
            EndContext();
#line 11 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
} 

#line default
#line hidden
            BeginContext(158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
 foreach (Vendor vendor in Model)
{

#line default
#line hidden
            BeginContext(198, 8, true);
            WriteLiteral("  <h4><a");
            EndContext();
            BeginWriteAttribute("href", " href=\'", 206, "\'", 232, 2);
            WriteAttributeValue("", 213, "/vendors/", 213, 9, true);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
WriteAttributeValue("", 222, vendor.Id, 222, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(233, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(235, 11, false);
#line 15 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
                               Write(vendor.Name);

#line default
#line hidden
            EndContext();
            BeginContext(246, 11, true);
            WriteLiteral("</a></h4>\r\n");
            EndContext();
#line 16 "C:\Users\Stunning\Desktop\epicodusProjects\c#\VendorTracker.Solution\VendorTracker\Views\Vendors\Index.cshtml"
}

#line default
#line hidden
            BeginContext(260, 48, true);
            WriteLiteral("\r\n<p><a href=\"/vendors/new\">Add a Vendor</a></p>");
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

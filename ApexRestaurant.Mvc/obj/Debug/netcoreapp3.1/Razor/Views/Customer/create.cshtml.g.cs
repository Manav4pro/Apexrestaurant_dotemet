#pragma checksum "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "548cce6470044bf712a722ef460e1cd10d94408e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_create), @"mvc.1.0.view", @"/Views/Customer/create.cshtml")]
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
#line 1 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/_ViewImports.cshtml"
using ApexRestaurant.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/_ViewImports.cshtml"
using ApexRestaurant.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"548cce6470044bf712a722ef460e1cd10d94408e", @"/Views/Customer/create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2369768eb70623acf1b455032a9a618096237c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApexRestaurant.Mvc.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
  
    ViewBag.Title = "Create New Customer - MVC"; Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Create New Student</h2>\n");
#nullable restore
#line 6 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\n    <hr />\n    ");
#nullable restore
#line 11 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 13 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
   Write(Html.LabelFor(model => model.FirstName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 15 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
       Write(Html.EditorFor(model => model.FirstName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            ");
#nullable restore
#line 16 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName, "", new { @class =
            "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"form-group\">\n        ");
#nullable restore
#line 21 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
   Write(Html.LabelFor(model => model.LastName, htmlAttributes: new { @class =
        "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        <div class=\"col-md-10\">\n            ");
#nullable restore
#line 24 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
       Write(Html.EditorFor(model => model.LastName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            \"text-danger\" })\n            ");
#nullable restore
#line 26 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    </div>\n    <div class=\"form-group\">\n        <div class=\"col-md-offset-2 col-md-10\">\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n        </div>\n    </div>\n</div>\n");
#nullable restore
#line 34 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\n    ");
#nullable restore
#line 36 "/Users/ayushkc/Desktop/ApexResturant/ApexRestaurant.Mvc/Views/Customer/create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApexRestaurant.Mvc.Models.CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

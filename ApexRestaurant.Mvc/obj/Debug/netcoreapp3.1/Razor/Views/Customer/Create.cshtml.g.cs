#pragma checksum "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe0154f216d0adaaa5c5667f8fa8c539dd94a459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Create), @"mvc.1.0.view", @"/Views/Customer/Create.cshtml")]
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
#line 1 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\_ViewImports.cshtml"
using ApexRestaurant.Mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe0154f216d0adaaa5c5667f8fa8c539dd94a459", @"/Views/Customer/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd2369768eb70623acf1b455032a9a618096237c", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApexRestaurant.Mvc.Models.CustomerViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
  
    ViewBag.Title = "Create New Customer";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create New Customer</h2>\r\n");
#nullable restore
#line 9 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <hr />\r\n        ");
#nullable restore
#line 15 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        \r\n        ");
#nullable restore
#line 17 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
   Write(Html.EditorForModel());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <div class=\"col-md-offset-2 col-md-10\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 25 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
#nullable restore
#line 27 "E:\C#\apxapi\apxapi\ApexRestaurant.Mvc\Views\Customer\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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

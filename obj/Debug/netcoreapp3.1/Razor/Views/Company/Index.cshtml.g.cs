#pragma checksum "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22b46fa8af3de752e2f720de7dd74a2f54d03d61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Company_Index), @"mvc.1.0.view", @"/Views/Company/Index.cshtml")]
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
#line 1 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\_ViewImports.cshtml"
using WebApplication.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22b46fa8af3de752e2f720de7dd74a2f54d03d61", @"/Views/Company/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b9b07c050a0c51332b819e62acfb82d2ccb8e9b", @"/Views/_ViewImports.cshtml")]
    public class Views_Company_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CompanyModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Company Management</h1>\r\n\r\n<h2>Add new company</h2>\r\n\r\n<p>...</p>\r\n\r\n\r\n");
#nullable restore
#line 11 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("       <div class=\"form-group\">\r\n           ");
#nullable restore
#line 14 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.Name, "Company name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           ");
#nullable restore
#line 15 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n       </div>\r\n       <div class=\"form-group\">\r\n           ");
#nullable restore
#line 18 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.Description, "Company description"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           ");
#nullable restore
#line 19 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.TextBoxFor(x => x.Description, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </div>\r\n       <div class=\"form-group\">\r\n           ");
#nullable restore
#line 22 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.CheckBoxFor(x => x.IsVisible, new { @class = "form-check-input"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           ");
#nullable restore
#line 23 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
      Write(Html.LabelFor(x => x.IsVisible, "Visible", new { @gclass = "form-check-label"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n       </div>\r\n       <div class=\"form-group\">\r\n           <button type=\"submit\" class=\"btn btn-primary\">Add Company</button>\r\n       </div>\r\n");
#nullable restore
#line 28 "C:\Users\user\source\repos\WebApplication.Web\WebApplication.Web\Views\Company\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CompanyModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

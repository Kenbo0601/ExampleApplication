#pragma checksum "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6329c9cc4532a482601e34066676fb05b85f96dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
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
#line 1 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\_ViewImports.cshtml"
using ExampleApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\_ViewImports.cshtml"
using ExampleApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6329c9cc4532a482601e34066676fb05b85f96dc", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf362b39d50672d98166d874d3203215df4cb68", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExampleApplication.Models.SchoolViewModels.EnrollmentDateGroup>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml"
  
    ViewData["Title"] = "Student Body Statistics";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Student Body Statistics</h2>\n\n<table>\n    <tr>\n        <th>\n            Enrollment Date\n        </th>\n        <th>\n            Students\n        </th>\n    </tr>\n\n");
#nullable restore
#line 19 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 23 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnrollmentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 26 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml"
           Write(item.StudentCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 29 "C:\Users\Kenichi Sakamoto\source\repos\ExampleApplication\ExampleApplication\Views\Home\About.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExampleApplication.Models.SchoolViewModels.EnrollmentDateGroup>> Html { get; private set; }
    }
}
#pragma warning restore 1591

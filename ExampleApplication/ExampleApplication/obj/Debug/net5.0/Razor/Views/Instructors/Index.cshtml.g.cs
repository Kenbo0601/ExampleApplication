#pragma checksum "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25261dd7818abc51c91c851fcaf3b15ff29c04ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Index), @"mvc.1.0.view", @"/Views/Instructors/Index.cshtml")]
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
#line 1 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\_ViewImports.cshtml"
using ExampleApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\_ViewImports.cshtml"
using ExampleApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25261dd7818abc51c91c851fcaf3b15ff29c04ec", @"/Views/Instructors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adf362b39d50672d98166d874d3203215df4cb68", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExampleApplication.Models.SchoolViewModels.InstructorIndexData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Instructors</h2>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25261dd7818abc51c91c851fcaf3b15ff29c04ec5117", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
 foreach (var item in Model.Instructors) {
    string selectedRow = "";
    if (item.ID == (int?)ViewData["InstructorID"])
    {
        selectedRow = "table-success";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("class", " class=\"", 634, "\"", 654, 1);
#nullable restore
#line 30 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 642, selectedRow, 642, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n            <td>\n                ");
#nullable restore
#line 32 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 35 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstMidName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n");
#nullable restore
#line 41 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                 if (item.OfficeAssignment != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(item.OfficeAssignment.Location);

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                                   
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n");
#nullable restore
#line 47 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                 foreach (var course in item.CourseAssignments)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(course.Course.CourseID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                       Write(course.Course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n");
#nullable restore
#line 50 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25261dd7818abc51c91c851fcaf3b15ff29c04ec10596", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25261dd7818abc51c91c851fcaf3b15ff29c04ec12812", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                       WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25261dd7818abc51c91c851fcaf3b15ff29c04ec15025", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                          WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25261dd7818abc51c91c851fcaf3b15ff29c04ec17244", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
                                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 59 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n");
#nullable restore
#line 63 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
 if (Model.Courses != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Courses Taught by Selected Instructor</h3>\n    <table class=\"table\">\n        <tr>\n            <th></th>\n            <th>Number</th>\n            <th>Title</th>\n            <th>Department</th>\n        </tr>\n\n");
#nullable restore
#line 74 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Courses)
        {
            string selectedRow = "";
            if (item.CourseID == (int?)ViewData["CourseID"])
            {
                selectedRow = "success";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 2184, "\"", 2204, 1);
#nullable restore
#line 81 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
WriteAttributeValue("", 2192, selectedRow, 2192, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <td>\n                    ");
#nullable restore
#line 83 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(Html.ActionLink("Select", "Index", new { courseID = item.CourseID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 86 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(item.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 89 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 92 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(item.Department.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 95 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </table>\n");
#nullable restore
#line 98 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 100 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
 if (Model.Enrollments != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>\n        Students Enrolled in Selected Course\n    </h3>\n    <table class=\"table\">\n        <tr>\n            <th>Name</th>\n            <th>Grade</th>\n        </tr>\n");
#nullable restore
#line 110 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
         foreach (var item in Model.Enrollments)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>\n                    ");
#nullable restore
#line 114 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(item.Student.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 117 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 120 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n");
#nullable restore
#line 122 "C:\Users\Kenichi Sakamoto\Desktop\ExampleApplication-master\ExampleApplication\ExampleApplication\Views\Instructors\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExampleApplication.Models.SchoolViewModels.InstructorIndexData> Html { get; private set; }
    }
}
#pragma warning restore 1591

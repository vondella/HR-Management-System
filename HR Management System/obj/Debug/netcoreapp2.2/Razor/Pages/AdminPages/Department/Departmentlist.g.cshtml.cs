#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c27a49b948fcd63061172400bedb3fda661d405f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Department_Departmentlist), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Department/Departmentlist.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Department/Departmentlist.cshtml", typeof(AspNetCore.Pages_AdminPages_Department_Departmentlist), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c27a49b948fcd63061172400bedb3fda661d405f", @"/Pages/AdminPages/Department/Departmentlist.cshtml")]
    public class Pages_AdminPages_Department_Departmentlist : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "EditDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "DeleteDepartment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'You are about to delete This Department. All Designation Under This Department Will Be Deleted. Are you sure?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
  
    ViewData["Title"] = "Departmentlist";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(227, 421, true);
            WriteLiteral(@"

<div class=""container-fluid"">

    <div class=""row"">
        <div class=""col-sm-12"" data-offset=""0"">
            <div class=""panel panel-default"">
                <!-- Default panel contents -->
                <div class=""panel-heading"">
                    <div class=""panel-title"">
                        <h3 class=""text-gray-800"">Department List</h3>
                    </div>
                </div>
");
            EndContext();
#line 21 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                 if (Model.Departments != null)
                {
                    foreach (var departmentItem in Model.Departments)
                    {

#line default
#line hidden
            BeginContext(810, 148, true);
            WriteLiteral("                        <div class=\"panel-heading\">\r\n                            <div class=\"panel-title\">\r\n                                <strong>");
            EndContext();
            BeginContext(959, 19, false);
#line 27 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                   Write(departmentItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(978, 107, true);
            WriteLiteral("</strong>\r\n\r\n                                <div class=\"pull-right\">\r\n                                    ");
            EndContext();
            BeginContext(1085, 148, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27a49b948fcd63061172400bedb3fda661d405f6482", async() => {
                BeginContext(1187, 42, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i> Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                                                           WriteLiteral(departmentItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1233, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(1271, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c27a49b948fcd63061172400bedb3fda661d405f9043", async() => {
                BeginContext(1513, 36, true);
                WriteLiteral("<i class=\"fa fa-trash-o\"></i> Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                                                             WriteLiteral(departmentItem.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1553, 110, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
            BeginContext(1669, 390, true);
            WriteLiteral(@"                        <table class=""table table-bordered table-hover"">
                            <thead>
                                <tr>
                                    <th class=""col-sm-1"">SL</th>
                                    <th>Designations</th>
                                </tr>
                            </thead>
                            <tbody>

");
            EndContext();
#line 47 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                 if (departmentItem.Designation != null)
                                {
                                    if (departmentItem.Designation.Count > 0)
                                    {
                                        for (var i = 0; i < departmentItem.Designation.Count; i++)
                                        {

#line default
#line hidden
            BeginContext(2429, 102, true);
            WriteLiteral("                                            <tr>\r\n                                                <td>");
            EndContext();
            BeginContext(2533, 5, false);
#line 54 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                                Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2539, 59, true);
            WriteLiteral("</td>\r\n                                                <td>");
            EndContext();
            BeginContext(2599, 34, false);
#line 55 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                               Write(departmentItem.Designation[i].Name);

#line default
#line hidden
            EndContext();
            BeginContext(2633, 60, true);
            WriteLiteral("</td>\r\n\r\n                                            </tr>\r\n");
            EndContext();
#line 58 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                                        }
                                    }
                                }

#line default
#line hidden
            BeginContext(2810, 72, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n");
            EndContext();
#line 63 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Department\Departmentlist.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(2924, 60, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.DepartmentlistModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.DepartmentlistModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.DepartmentlistModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.DepartmentlistModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

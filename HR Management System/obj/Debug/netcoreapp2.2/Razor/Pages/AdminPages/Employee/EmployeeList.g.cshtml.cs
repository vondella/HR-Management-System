#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Employee\EmployeeList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f97add25781f6314ec2ff049f96949d3964037b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Employee_EmployeeList), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Employee/EmployeeList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Employee/EmployeeList.cshtml", typeof(AspNetCore.Pages_AdminPages_Employee_EmployeeList), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f97add25781f6314ec2ff049f96949d3964037b1", @"/Pages/AdminPages/Employee/EmployeeList.cshtml")]
    public class Pages_AdminPages_Employee_EmployeeList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Employee\EmployeeList.cshtml"
  
    ViewData["Title"] = "EmployeeList";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(169, 43, true);
            WriteLiteral("\r\n<center><h1>Employee List</h1></center>\r\n");
            EndContext();
            BeginContext(212, 6005, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f97add25781f6314ec2ff049f96949d3964037b13192", async() => {
                BeginContext(218, 5992, true);
                WriteLiteral(@"
    <div class=""container-fluid"">


        <br><!--            show when print start-->
        <div class=""row"">
            <div class=""col-sm-12 wrap-fpanel"" data-spy=""scroll"" data-offset=""0"">
                <div class=""panel panel-default"">
                    <!-- Default panel contents -->

                    <br>
                    <!-- Table -->
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""row""><div class=""col-sm-6""><div class=""dataTables_length"" id=""dataTables-example_length""><label><select name=""dataTables-example_length"" aria-controls=""dataTables-example"" class=""form-control input-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> <b>Records per page</b></label></div></div><div class=""col-sm-6""><div id=""dataTables-example_filter"" class=""dataTables_filter""><label>Search:<input type=""search"" style=""ma");
                WriteLiteral(@"rgin:0px 10px;"" class=""form-control input-sm"" aria-controls=""dataTables-example""></label></div></div></div><table class=""table table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr role=""row"">
                                    <th class=""col-sm-1 sorting_asc"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""EMP ID: activate to sort column ascending"" style=""width: 73px;"">EMP ID</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Employee: activate to sort column ascending"" style=""width: 149px;"">Employee</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Department: activate to sort column ascending"" style=""width: 295px;"">Department<");
                WriteLiteral(@"/th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Designations: activate to sort column ascending"" style=""width: 295px;"">Designations</th>
                                    <th class=""show_print sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Email: activate to sort column ascending"" style=""width: 33px;"">Email</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Mobile: activate to sort column ascending"" style=""width: 105px;"">Mobile</th>
                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Status: activate to sort column ascending"" style=""width: 111px;"">Status</th>
                                    <th class=""col-sm-1 hidden-print sorting"" tabindex=""0"" aria-controls=""dataTables-example"" ");
                WriteLiteral(@"rowspan=""1"" colspan=""1"" aria-label=""View: activate to sort column ascending"" style=""width: 73px;"">View</th>
                                    <th class=""col-sm-2 hidden-print sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Action: activate to sort column ascending"" style=""width: 164px;"">Action</th>
                                </tr>
                            </thead>
                            <tbody>




                                <tr class=""odd"">
                                    <td class=""sorting_1"">112</td>
                                    <td class="" "">Ovijit Roy</td>
                                    <td class="" "">Marketing</td>
                                    <td class="" "">Manager</td>
                                    <td class=""show_print "">dsasds@gtds.com</td>
                                    <td class="" "">12</td>
                                    <td class="" ""><span class=""label label-success"">Active</span>");
                WriteLiteral(@"</td>
                                    <td class=""hidden-print ""><a href=""http://localhost/HRMS-FRESH/admin/employee/view_employee/3"" class=""btn btn-info btn-xs"" data-toggle=""tooltip"" data-placement=""top"" title="""" data-original-title=""View"">View</a></td>
                                    <td class=""hidden-print "">
                                        <a href=""http://localhost/HRMS-FRESH/admin/employee/add_employee/3"" class=""btn btn-primary btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Edit"">Edit</a>
                                        <a href=""http://localhost/HRMS-FRESH/admin/employee/delete_employee/3/2/2"" class=""btn btn-danger btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" onclick=""return confirm('You are about to delete a record. This cannot be undone. Are you sure?');"" data-original-title=""Delete""> Delete</a>
                                    </td>
                                </tr>
                            </tbody>
             ");
                WriteLiteral(@"           </table><div class=""row""><div class=""col-sm-6""><div class=""dataTables_info"" id=""dataTables-example_info"" role=""alert"" aria-live=""polite"" aria-relevant=""all"">Showing 1 to 2 of 2 entries</div></div><div class=""col-sm-6""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate""><ul class=""pagination""><li class=""paginate_button previous disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_previous""><a href=""#"">Previous</a></li><li class=""paginate_button active"" aria-controls=""dataTables-example"" tabindex=""0""><a href=""#"">1</a></li><li class=""paginate_button next disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_next""><a href=""#"">Next</a></li></ul></div></div></div>
                    </div>
                </div>
            </div>
        </div>
    </div>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6217, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.EmployeeListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeeListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeeListModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.EmployeeListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

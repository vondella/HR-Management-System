#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\Selected_Applicant_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da5646fd49c7a95295ca302c1dd25c961052246f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Recruitment_Selected_Applicant_List), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Recruitment/Selected_Applicant_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Recruitment/Selected_Applicant_List.cshtml", typeof(AspNetCore.Pages_AdminPages_Recruitment_Selected_Applicant_List), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da5646fd49c7a95295ca302c1dd25c961052246f", @"/Pages/AdminPages/Recruitment/Selected_Applicant_List.cshtml")]
    public class Pages_AdminPages_Recruitment_Selected_Applicant_List : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\Selected_Applicant_List.cshtml"
  
    ViewData["Title"] = "Selected_Applicant_List";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(191, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(195, 7058, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da5646fd49c7a95295ca302c1dd25c961052246f3271", async() => {
                BeginContext(201, 7045, true);
                WriteLiteral(@"
        <div class=""container-fluid"">

            <div class=""row"">
                <div class=""col-sm-12"">
                    <div class=""wrap-fpanel"">
                        <div class=""panel panel-default"" data-collapsed=""0"">
                            <div class=""panel-heading"">
                                <div class=""panel-title"">
                                    <strong>Add Selected Parson</strong>
                                </div>
                            </div>
                            <div class=""panel-body"">

                                <form id=""form"" action=""http://localhost/HRMS-FRESH/admin/settings/save_leave_category/"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">

                                    <div class=""form-group"">
                                        
                                        <div class=""col-sm-5"">
                                            <input type=""text"" name=""category"" value=""");
                WriteLiteral(@""" class=""form-control"" placeholder=""Enter Applicatin ID"">
                                        </div>

                                        <div class=""col-sm-2"">
                                            <input type=""date"" name=""category"" value="""" class=""form-control"" placeholder=""Interview Date"">
                                        </div><div>
                                            <div class=""col-sm-2"">
                                                <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Save</button>
                                            </div>
                                        </div>

                                        <div class=""row"">
                                            <div class=""col-sm-12 wrap-fpanel"" data-offset=""0"">
                                                <div class=""panel panel-default"">

                                                    <div class=""panel-heading"">
                                               ");
                WriteLiteral(@"         <div class=""panel-title"">
                                                            <span>
                                                                <strong>Recruitment Selected List</strong>
                                                            </span>
                                                        </div>

                                                        <!-- Table -->
                                                    </div>
                                                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                                                        <div class=""row""><div class=""col-sm-6""><div class=""dataTables_length"" id=""dataTables-example_length""><label><select name=""dataTables-example_length"" aria-controls=""dataTables-example"" class=""form-control input-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> <");
                WriteLiteral(@"b>Records per page</b></label></div></div><div class=""col-sm-6""><div id=""dataTables-example_filter"" class=""dataTables_filter""><label>Search:<input type=""search"" style=""margin:0px 10px;"" class=""form-control input-sm"" aria-controls=""dataTables-example""></label></div></div></div><table class=""table table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                                                            <thead>
                                                                <tr role=""row"">
                                                                    <th class=""col-sm-1 sorting_asc"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""ID: activate to sort column ascending"" style=""width: 73px;"">ID</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Full Name: a");
                WriteLiteral(@"ctivate to sort column ascending"" style=""width: 116px;"">Full Name</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Department: activate to sort column ascending"" style=""width: 125px;"">Department</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Designation: activate to sort column ascending"" style=""width: 125px;"">Designation</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Date of Application: activate to sort column ascending"" style=""width: 132px;"">Date of Application</th>

                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=");
                WriteLiteral(@"""1"" aria-label=""Date of Interview: activate to sort column ascending"" style=""width: 132px;"">Date of Interview</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Status: activate to sort column ascending"" style=""width: 107px;"">Status</th>
                                                                    <th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""View Details: activate to sort column ascending"" style=""width: 162px;"">View Details</th>
                                                                </tr>
                                                            </thead>
                                                            <tbody></tbody>
                                                        </table><div class=""row""><div class=""col-sm-6""><div class=""dataTables_info"" id=""dataTables-example_info"" role=""alert"" aria");
                WriteLiteral(@"-live=""polite"" aria-relevant=""all"">Showing 1 to 1 of 1 entries</div></div><div class=""col-sm-6""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate""><ul class=""pagination""><li class=""paginate_button previous disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_previous""><a href=""#"">Previous</a></li><li class=""paginate_button active"" aria-controls=""dataTables-example"" tabindex=""0""><a href=""#"">1</a></li><li class=""paginate_button next disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_next""><a href=""#"">Next</a></li></ul></div></div></div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.Selected_Applicant_ListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.Selected_Applicant_ListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.Selected_Applicant_ListModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.Selected_Applicant_ListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

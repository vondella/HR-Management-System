#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Payroll\EmployeeSalaryList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2dfcf8c58ff4ba62ade0c5b9858ffce92d21660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Payroll_EmployeeSalaryList), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Payroll/EmployeeSalaryList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Payroll/EmployeeSalaryList.cshtml", typeof(AspNetCore.Pages_AdminPages_Payroll_EmployeeSalaryList), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2dfcf8c58ff4ba62ade0c5b9858ffce92d21660", @"/Pages/AdminPages/Payroll/EmployeeSalaryList.cshtml")]
    public class Pages_AdminPages_Payroll_EmployeeSalaryList : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Payroll\EmployeeSalaryList.cshtml"
  
    ViewData["Title"] = "EmployeeSalaryList";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(181, 50, true);
            WriteLiteral("<center><h1>Employee Salary List</h1></center>\r\n\r\n");
            EndContext();
            BeginContext(231, 11406, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2dfcf8c58ff4ba62ade0c5b9858ffce92d216603246", async() => {
                BeginContext(237, 11393, true);
                WriteLiteral(@"

    <div class=""container-fluid"">
        <script language=""javascript"" type=""text/javascript"">
            function getXMLHTTP() { //fuction to return the xml http object
                var xmlhttp = false;
                try {
                    xmlhttp = new XMLHttpRequest();
                }
                catch (e) {
                    try {
                        xmlhttp = new ActiveXObject(""Microsoft.XMLHTTP"");
                    }
                    catch (e) {
                        try {
                            xmlhttp = new ActiveXObject(""Msxml2.XMLHTTP"");
                        }
                        catch (e1) {
                            xmlhttp = false;
                        }
                    }
                }

                return xmlhttp;
            }

            function check_duplicate_emp_id(val) {
                var base_url = 'http://localhost/HRMS-FRESH/';
                var strURL = base_url + ""admin/global_controller/check");
                WriteLiteral(@"_duplicate_emp_id/"" + val;
                var req = getXMLHTTP();
                if (req) {
                    req.onreadystatechange = function () {
                        if (req.readyState == 4) {
                            // only if ""OK""
                            if (req.status == 200) {
                                var result = req.responseText;
                                if (result) {
                                    $(""#id_error_msg"").append(result);
                                    document.getElementById('btn_emp').disabled = true;
                                } else {
                                    document.getElementById('btn_emp').disabled = false;
                                }

                            } else {
                                alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                            }
                        }
                    }
                    req.open(""POST"", strURL, true);
");
                WriteLiteral(@"                    req.send(null);
                }

            }
            ;
            function get_employee_by_designations_id(designation_id) {
                var base_url = 'http://localhost/HRMS-FRESH/';
                var strURL = base_url + ""admin/global_controller/get_employee_by_designations_id/"" + designation_id;
                var req = getXMLHTTP();
                if (req) {
                    req.onreadystatechange = function () {
                        if (req.readyState == 4) {
                            // only if ""OK""
                            if (req.status == 200) {
                                var result = req.responseText;

                                $(""#employee"").html(""<option value='' >Select Employee...</option>"");
                                $(""#employee"").append(result);

                            } else {
                                alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                          ");
                WriteLiteral(@"  }
                        }
                    }
                    req.open(""POST"", strURL, true);
                    req.send(null);
                }

            }
            ;
            function check_current_password(val) {
                var base_url = 'http://localhost/HRMS-FRESH/';
                var strURL = base_url + ""admin/global_controller/check_current_password/"" + val;
                var req = getXMLHTTP();
                if (req) {
                    req.onreadystatechange = function () {
                        if (req.readyState == 4) {
                            // only if ""OK""
                            if (req.status == 200) {
                                var result = req.responseText;
                                if (result) {
                                    $(""#id_error_msg"").css(""display"", ""block"");
                                    document.getElementById('sbtn').disabled = true;
                                } else {
              ");
                WriteLiteral(@"                      $(""#id_error_msg"").css(""display"", ""none"");
                                    document.getElementById('sbtn').disabled = false;
                                }

                            } else {
                                alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                            }
                        }
                    }
                    req.open(""POST"", strURL, true);
                    req.send(null);
                }

            }
            function check_employee_password(val) {

                var base_url = 'http://localhost/HRMS-FRESH/';
                var strURL = base_url + ""employee/dashboard/check_employee_password/"" + val;

                var req = getXMLHTTP();
                if (req) {
                    req.onreadystatechange = function () {
                        if (req.readyState == 4) {
                            // only if ""OK""
                            if (req.status ==");
                WriteLiteral(@" 200) {
                                var result = req.responseText;
                                if (result) {
                                    $(""#id_error_msg"").css(""display"", ""block"");
                                    document.getElementById('sbtn').disabled = true;
                                } else {
                                    $(""#id_error_msg"").css(""display"", ""none"");
                                    document.getElementById('sbtn').disabled = false;
                                }

                            } else {
                                alert(""There was a problem while using XMLHTTP:\n"" + req.statusText);
                            }
                        }
                    }
                    req.open(""POST"", strURL, true);
                    req.send(null);
                }

            }
            ;


        </script>
        <div class=""row"">
            <div class=""col-sm-12 wrap-fpanel"" data-offset=""0"">
             ");
                WriteLiteral(@"   <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">
                            <span>
                                <strong>List of Employees and Their Salaries</strong>
                            </span>
                        </div>
                    </div>
                    <!-- Table -->

                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""row""><div class=""col-sm-6""><div class=""dataTables_length"" id=""dataTables-example_length""><label><select name=""dataTables-example_length"" aria-controls=""dataTables-example"" class=""form-control input-sm""><option value=""10"">10</option><option value=""25"">25</option><option value=""50"">50</option><option value=""100"">100</option></select> <b>Records per page</b></label></div></div><div class=""col-sm-6""><div id=""dataTables-example_filter"" class=""dataTables_filter""><label>Search:<input ");
                WriteLiteral(@"type=""search"" style=""margin:0px 10px;"" class=""form-control input-sm"" aria-controls=""dataTables-example""></label></div></div></div><table class=""table table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr role=""row""><th class=""col-sm-1 sorting_asc"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-sort=""ascending"" aria-label=""ID: activate to sort column ascending"" style=""width: 73px;"">ID</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Full Name: activate to sort column ascending"" style=""width: 128px;"">Full Name</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Gross Salary: activate to sort column ascending"" style=""width: 161px;"">Gross Salary</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""");
                WriteLiteral(@"1"" aria-label=""Deductions: activate to sort column ascending"" style=""width: 140px;"">Deductions</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Net Salary: activate to sort column ascending"" style=""width: 132px;"">Net Salary</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Emp Type: activate to sort column ascending"" style=""width: 137px;"">Emp Type</th><th class=""col-sm-1 sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Details: activate to sort column ascending"" style=""width: 73px;"">Details</th><th class=""sorting"" tabindex=""0"" aria-controls=""dataTables-example"" rowspan=""1"" colspan=""1"" aria-label=""Action: activate to sort column ascending"" style=""width: 108px;"">Action</th></tr>
                            </thead>
                            <tbody>


                                <tr class=""odd"">
                                    <td class=""");
                WriteLiteral(@"sorting_1"">12345</td>
                                    <td class="" "">Al Amin</td>
                                    <td class="" "">23700</td>
                                    <td class="" "">3700</td>
                                    <td class="" "">20000</td>
                                    <td class="" "">Permanent</td>
                                    <td class="" ""><a href=""http://localhost/HRMS-FRESH/admin/payroll/view_salary_details/2"" class=""btn btn-info btn-xs"" data-toggle=""tooltip"" data-placement=""top"" title="""" data-original-title=""View""><span class=""fa fa-list-alt""></span></a></td>
                                    <td class="" "">
                                        <a href=""http://localhost/HRMS-FRESH/admin/payroll/manage_salary_details/2/1"" class=""btn btn-primary btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Edit""><i class=""fa fa-pencil-square-o""></i> Edit</a>
                                    </td>
                                </tr>");
                WriteLiteral(@"
                            </tbody>
                        </table><div class=""row""><div class=""col-sm-6""><div class=""dataTables_info"" id=""dataTables-example_info"" role=""alert"" aria-live=""polite"" aria-relevant=""all"">Showing 1 to 1 of 1 entries</div></div><div class=""col-sm-6""><div class=""dataTables_paginate paging_simple_numbers"" id=""dataTables-example_paginate""><ul class=""pagination""><li class=""paginate_button previous disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_previous""><a href=""#"">Previous</a></li><li class=""paginate_button active"" aria-controls=""dataTables-example"" tabindex=""0""><a href=""#"">1</a></li><li class=""paginate_button next disabled"" aria-controls=""dataTables-example"" tabindex=""0"" id=""dataTables-example_next""><a href=""#"">Next</a></li></ul></div></div></div>
                    </div>
                </div>
            </div>
        </div>

        <script>
            $(function () {
                $('#date').datepicker({
                    aut");
                WriteLiteral("oclose: true,\r\n                    format: \"yyyy-mm-dd\",\r\n                });\r\n            });\r\n        </script>\r\n    </div>\r\n\r\n");
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
            BeginContext(11637, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.EmployeeSalaryListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeeSalaryListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.EmployeeSalaryListModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.EmployeeSalaryListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

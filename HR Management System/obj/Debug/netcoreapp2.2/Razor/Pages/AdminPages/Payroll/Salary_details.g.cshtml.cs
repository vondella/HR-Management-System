#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Payroll\Salary_details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea34d6fe8494598617305d3edf8559fb9e5a0731"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Payroll_Salary_details), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Payroll/Salary_details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Payroll/Salary_details.cshtml", typeof(AspNetCore.Pages_AdminPages_Payroll_Salary_details), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea34d6fe8494598617305d3edf8559fb9e5a0731", @"/Pages/AdminPages/Payroll/Salary_details.cshtml")]
    public class Pages_AdminPages_Payroll_Salary_details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\AdminPages\Payroll\Salary_details.cshtml"
  
    ViewData["Title"] = "Salary_details";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(192, 15060, true);
            WriteLiteral(@"

<center><h1>Salary_details</h1></center>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-sm-12"" data-spy=""scroll"" data-offset=""0"">
            <div class=""panel panel-default"">
                <!-- main content -->
                <div class=""panel-heading"">
                    <div class=""row"">
                        <div class=""col-lg-12 panel-title"">
                            <div class=""pull-right"" style=""text-align:right"">
                                <span><a href=""#"" class=""btn btn-primary btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Edit""><i class=""fa fa-pencil-square-o""></i> Edit</a></span>
                                <span><a href=""#"" class=""btn btn-primary btn-xs"" title="""" data-toggle=""tooltip"" data-placement=""top"" data-original-title=""Edit""><i class=""fa fa-pencil-square-o""></i> Print</a></span>

                            </div>
                        </div>
                    </div>
                ");
            WriteLiteral(@"</div>
                <br>
                <div id=""printableArea"">
                    <!--            show when print start-->
                    <br>
                    <div class=""col-lg-12 well"">
                        <div class=""row"">
                            <div class=""col-lg-2 col-sm-2"">
                                <div class=""fileinput-new thumbnail"" style=""width: 144px; height: 158px; margin-top: 14px; margin-left: 16px; background-color: #EBEBEB;"">
                                    <img src=""http://localhost/HRMS-FRESH/img/uploads/Screenshot_(4).png"" style=""width: 142px; height: 148px; border-radius: 3px;"">

                                </div>
                            </div>
                            <div class=""col-lg-1 col-sm-1"">
                                &nbsp;
                            </div>
                            <div class=""col-lg-8 col-sm-8 "">
                                <div>
                                    <div style=""margin-le");
            WriteLiteral(@"ft: 20px;"">
                                        <h3>Al Amin</h3>
                                        <hr>
                                        <table class=""table-hover"">
                                            <tbody>
                                                <tr>
                                                    <td><strong>Employee ID</strong></td>
                                                    <td>&nbsp;&nbsp;&nbsp;</td>
                                                    <td>12345</td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Department</strong></td>
                                                    <td>&nbsp;&nbsp;&nbsp;</td>
                                                    <td>sells</td>
                                                </tr>
                                                <tr>
                                  ");
            WriteLiteral(@"                  <td><strong>Designation</strong></td>
                                                    <td>&nbsp;&nbsp;&nbsp;</td>
                                                    <td>manager</td>
                                                </tr>
                                                <tr>
                                                    <td><strong>Joining Date</strong></td>
                                                    <td>&nbsp;&nbsp;&nbsp;</td>
                                                    <td>28 May 2019</td>
                                                </tr>
                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                    <div class=""show_print"" style=""width: 100%; border-bottom: 2px solid black;"">

                  ");
            WriteLiteral(@"  </div>

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div class=""wrap-fpanel"">
                                <div class=""panel panel-default"">
                                    <form id=""form_validation"" role=""form"" enctype=""multipart/form-data"" action=""http://localhost/HRMS-FRESH/admin/payroll/save_salary_details/1"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">

                                        <!-- ********************************* Salary Details Panel ***********************-->

                                        <div class=""col-sm-12"">
                                            <div class=""panel panel-default"">
                                                <div class=""panel-heading"">
                                                    <div class=""panel-title"">
                                                        <strong>Salary Details</strong>
                  ");
            WriteLiteral(@"                                  </div>
                                                </div>
                                                <div class=""panel-body "">

                                                    <div class=""row"">
                                                        <div class=""col-sm-12 form-groups-bordered"">
                                                            <div class=""form-group"" id=""border-none"">
                                                                <div class="""">
                                                                    <label for=""field-1"" class=""col-sm-3 control-label""><strong>Employment Type :</strong></label>
                                                                    <p class=""form-control-static"">Permanent</p>
                                                                </div>
                                                            </div>
                                                            <div class=""for");
            WriteLiteral(@"m-group"" id=""border-none"">
                                                                <label for=""field-1"" class=""col-sm-12 control-label"">Basic Salary <span class=""required"" aria-required=""true"">*</span></label>
                                                                <div class=""col-sm-12"">
                                                                    <input type=""text"" name=""basic_salary"" value=""20000"" disabled="""" class=""salary form-control"">
                                                                </div>
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </form>

                                    <!-- ***************** Salary Details  Ends *****");
            WriteLiteral(@"****************-->

                                    <form>
                                        <!-- ******************-- Allowance Panel Start **************************-->
                                        <div class=""col-sm-12"" style=""margin-left:25px"">
                                            <div class=""panel panel-default"">

                                                <div class=""panel-title"">
                                                    <strong>Allowances</strong>
                                                </div>

                                                <div class=""panel-body"">
                                                    <div class="""">
                                                        <label class=""control-label"">House Rent Allowance </label>
                                                        <input type=""text"" name=""house_rent_allowance"" value=""1500"" disabled="""" class=""salary form-control"">
                                     ");
            WriteLiteral(@"               </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Medical Allowance </label>
                                                        <input type=""text"" name=""medical_allowance"" value=""500"" disabled="""" class=""salary form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Special Allowance </label>
                                                        <input type=""text"" name=""special_allowance"" value=""500"" disabled="""" class=""salary form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Fuel Allowance </label>
                                 ");
            WriteLiteral(@"                       <input type=""text"" name=""fuel_allowance"" value=""100"" disabled="""" class=""salary form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Phone Bill Allowance </label>
                                                        <input type=""text"" name=""phone_bill_allowance"" value=""1000"" disabled="""" class=""salary form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Other Allowance </label>
                                                        <input type=""text"" name=""other_allowance"" value=""100"" disabled="""" class=""salary form-control"">
                                                    </div>
                                                </div");
            WriteLiteral(@">
                                            </div>
                                        </div><!-- ********************Allowance End ******************-->

                                    </form>

                                    <form>
                                        <!--            ************** Deduction Panel Column ************** -->

                                        <div class=""col-sm-12"" style=""margin-left:55px"">
                                            <div class=""panel panel-default"">
                                                <div class=""panel-heading"">
                                                    <div class=""panel-title"">
                                                        <strong>Deductions</strong>
                                                    </div>
                                                </div>
                                                <div class=""panel-body"">
                                                    ");
            WriteLiteral(@"<div class="""">
                                                        <label class=""control-label"">Provident Fund </label>
                                                        <input type=""text"" name=""provident_fund"" value=""3500"" disabled="""" class=""deduction form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Tax Deduction </label>
                                                        <input type=""text"" name=""tax_deduction"" value=""100"" disabled="""" class=""deduction form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Other Deduction </label>
                                                        <input type=""text"" name=""other_deduction"" value=""100"" disa");
            WriteLiteral(@"bled="""" class=""deduction form-control"">
                                                    </div>
                                                </div>
                                            </div>

                                        </div>

                                        <!-- ****************** Deduction End  *******************-->
                                        <!-- ************** Total Salary Details Start  **************-->
                                        <div class=""col-sm-12"" style=""margin-left:55px; margin-top:15px"">
                                            <div class=""panel panel-default"">
                                                <div class=""panel-heading"">
                                                    <div class=""panel-title"">
                                                        <strong>Total Salary Details</strong>
                                                    </div>
                                                </div>
");
            WriteLiteral(@"                                                <div class=""panel-body"">
                                                    <div class="""">
                                                        <label class=""control-label"">Gross Salary </label>
                                                        <input type=""text"" name=""provident_fund"" disabled="""" value=""23700"" id=""total"" class=""form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Total Deduction </label>
                                                        <input type=""text"" name=""tax_deduction"" disabled="""" value=""3700"" id=""deduc"" class=""form-control"">
                                                    </div>
                                                    <div class="""">
                                                        <label class=""control-label"">Net Salary");
            WriteLiteral(@" </label>
                                                        <input type=""text"" name=""tax_deduction"" disabled="""" value=""20000"" id=""net_salary"" class=""form-control"">
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                        <!-- ****************** Total Salary Details End  *******************-->
                                    </form>
                                   


                                </div>
                            </div>
                        </div>
                        
");
            EndContext();
            BeginContext(15675, 68, true);
            WriteLiteral("\r\n                    </div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AdminPages.Payroll.Salary_detailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Payroll.Salary_detailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Payroll.Salary_detailsModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AdminPages.Payroll.Salary_detailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e92550314226bba49ee914d2491d70b3a33518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Attendence_ManageAttendence), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Attendence/ManageAttendence.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Attendence/ManageAttendence.cshtml", typeof(AspNetCore.Pages_AdminPages_Attendence_ManageAttendence), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e92550314226bba49ee914d2491d70b3a33518", @"/Pages/AdminPages/Attendence/ManageAttendence.cshtml")]
    public class Pages_AdminPages_Attendence_ManageAttendence : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Attendence\ManageAttendence.cshtml"
  
    ViewData["Title"] = "ManageAttendence";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(177, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(179, 12751, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65e92550314226bba49ee914d2491d70b3a335183187", async() => {
                BeginContext(185, 12738, true);
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


        </script><div class=""row"">
            <div class=""col-sm-12"">

                <div class=""row"">
              ");
                WriteLiteral(@"      <div class=""col-sm-12"" data-offset=""0"">
                        <div class=""wrap-fpanel"">
                            <div class=""panel panel-default"" data-collapsed=""0"">
                                <div class=""panel-heading"">
                                    <div class=""panel-title"">
                                        <strong>Set Attendance</strong>
                                    </div>
                                </div>
                                <div class=""panel-body"">
                                    <form id=""form"" action=""http://localhost/HRMS-FRESH/admin/attendance/manage_attendance"" method=""post"" enctype=""multipart/form-data"" class=""form-horizontal"" novalidate=""novalidate"">
                                        <div class=""panel_controls"">
                                            <div class=""form-group margin"">
                                                <label class=""col-sm-3 control-label"">Select Day <span class=""required"" aria-required=""true""");
                WriteLiteral(@">*</span></label>

                                                <div class=""col-sm-5"">
                                                    <div class=""input-group"">
                                                        <input type=""date"" name=""date"" id=""date"" placeholder=""Enter Day"" class=""form-control"" value=""2019-07-02"" data-format=""dd-mm-yyyy"">
                                                        <div class=""input-group-addon"">
                                                            <a href=""#""><i class=""entypo-calendar""></i></a>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <label for=""field-1"" class=""col-sm-3 control-label"">Department <span class=""required"" aria-required=""true"">*</span><");
                WriteLiteral(@"/label>

                                                <div class=""col-sm-5"">
                                                    <select name=""department_id"" id=""department"" class=""form-control"">
                                                        <option value="""">Select Department</option>
                                                        

                                                    </select>
                                                </div>
                                            </div>
                                            <div class=""form-group"">
                                                <div class=""col-sm-offset-3 col-sm-5"">
                                                    <button type=""submit"" id=""sbtn"" name=""sbtn"" value=""1"" class=""btn btn-primary"">Go</button>
                                                </div>
                                            </div>
                                        </div>
                                ");
                WriteLiteral(@"    </form>
                                </div>
                            </div>
                            <table class=""table table-bordered"">
                                    <thead>
                                        <tr>
                                            <th>Employee Name</th>
                                            <th>Designation</th>
                                            <th> Attend</th>
                                            <th> Absent</th>
                                            <th> Leave Category</th>
                                        </tr>
                                    </thead>
                                    <tbody>

                                        <tr>
                                            <td>
                                                <input type=""hidden"" name=""date"" value=""2019-07-02"">

                                                <input type=""hidden"" name=""employee_id[]"" value=""2""> Al Amin
");
                WriteLiteral(@"                                            </td>
                                            <td>manager</td>
                                            <td><input name=""attendance[]"" id=""2"" value=""2"" type=""checkbox"" class=""child_present""> </td>
                                            <td><input name=""attendance[]"" id=""2"" value=""2"" type=""checkbox"" class=""child_present""> </td>

                                            <td style=""width: 35%"">
                                                <input id=""2"" type=""checkbox"" value=""2"" class=""child_absent"">
                                                <div id=""l_category"" class=""col-sm-9"">
                                                    <select name=""leave_category_id[]"" class=""form-control"">
                                                        <option value="""">Select Leave Category</option>
                                                        <option value=""1"">
                                                            eid
         ");
                WriteLiteral(@"                                               </option>;
                                                    </select>
                                                </div>
                                            </td>
                                        </tr>

                                    </tbody>
                                </table>
                            </form>
                        </div>
                        <div class=""form-group"">
                            <div class=""col-sm-offset-11"">
                                <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Update</button>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <script type=""text/javascript"">
            $(document).ready(function () {
                $(':checkbox').on('change', function () {
                    var th = $(this), id = th.prop('id');

          ");
                WriteLiteral(@"          if (th.is(':checked')) {
                        $(':checkbox[id=""' + id + '""]').not($(this)).prop('checked', false);
                    }
                });
            });
        </script>
        <script>
            $(function () {
                $('#date').datepicker({
                    autoclose: true,
                    format: ""yyyy-mm-dd"",
                });
            });

        </script>
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
            BeginContext(12930, 4, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.ManageAttendenceModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageAttendenceModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageAttendenceModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.ManageAttendenceModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

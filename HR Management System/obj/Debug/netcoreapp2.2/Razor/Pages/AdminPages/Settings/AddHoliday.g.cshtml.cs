#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Settings\AddHoliday.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9dfcd997dd4c31a481d2e551af2c8fde785d6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Settings_AddHoliday), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Settings/AddHoliday.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Settings/AddHoliday.cshtml", typeof(AspNetCore.Pages_AdminPages_Settings_AddHoliday), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9dfcd997dd4c31a481d2e551af2c8fde785d6e8", @"/Pages/AdminPages/Settings/AddHoliday.cshtml")]
    public class Pages_AdminPages_Settings_AddHoliday : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Settings\AddHoliday.cshtml"
  
    ViewData["Title"] = "AddHoliday";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(185, 237, true);
            WriteLiteral("\r\n<center><h1>Add Holiday</h1></center>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12\">\r\n        <div class=\"wrap-fpanel\">\r\n            <div class=\"panel panel-default\" data-collapsed=\"0\">\r\n                <div class=\"panel-heading\">\r\n");
            EndContext();
            BeginContext(563, 2898, true);
            WriteLiteral(@"                </div>
                <div class=""panel-body"">
                    <form id=""form"" action=""http://localhost/HRMS-FRESH/admin/settings/save_holiday/"" method=""post"" class=""form-horizontal form-groups-bordered"" novalidate=""novalidate"">
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">Event Name<span class=""required"" aria-required=""true""> *</span></label>

                            <div class=""col-sm-5"">
                                <input type=""text"" name=""event_name"" class=""form-control"" value="""" id=""field-1"" placeholder=""Enter Your Event Name"">
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">Description<span class=""required"" aria-required=""true""> *</span></label>

                            <div class=""col-sm-5"">
                                <texta");
            WriteLiteral(@"rea style=""height: 100px"" name=""description"" class=""form-control"" id=""field-1"" placeholder=""Enter Your Description""></textarea>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">Start Date<span class=""required"" aria-required=""true"">*</span></label>
                            <div class=""input-group col-sm-5"">
                                <input type=""date"" class=""form-control datepicker"" name=""start_date"" value="""">

                                <div class=""input-group-addon"">
                                    <a href=""#""><i class=""entypo-calendar""></i></a>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group"">
                            <label for=""field-1"" class=""col-sm-3 control-label"">End Date<span class=""required"" aria-required=""true"">*</span");
            WriteLiteral(@"></label>
                            <div class=""input-group col-sm-5"">
                                <input type=""date"" class=""form-control datepicker"" name=""end_date"" value="""">

                                <div class=""input-group-addon"">
                                    <a href=""#""><i class=""entypo-calendar""></i></a>
                                </div>
                            </div>
                        </div>
                        <div class=""form-group margin"">
                            <div class=""col-sm-offset-3 col-sm-5"">
                                <button type=""submit"" id=""sbtn"" class=""btn btn-primary"">Save</button>
                            </div>
                        </div>
                    </form>
                </div>

            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.AdminPages.Settings.AddHolidayModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Settings.AddHolidayModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.AdminPages.Settings.AddHolidayModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.AdminPages.Settings.AddHolidayModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba511a9493b057e02aebfd188dd69de20080e9a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_CareerPages_ViewRecruitmentNotice), @"mvc.1.0.razor-page", @"/Pages/CareerPages/ViewRecruitmentNotice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/CareerPages/ViewRecruitmentNotice.cshtml", typeof(AspNetCore.Pages_CareerPages_ViewRecruitmentNotice), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba511a9493b057e02aebfd188dd69de20080e9a6", @"/Pages/CareerPages/ViewRecruitmentNotice.cshtml")]
    public class Pages_CareerPages_ViewRecruitmentNotice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
  
    ViewData["Title"] = "ViewRecruitmentNotice";
    Layout = "~/Views/Shared/_CareerLayout.cshtml";

#line default
#line hidden
            BeginContext(245, 389, true);
            WriteLiteral(@"



<div class=""container-fluid"">
    <div class=""wrap-fpanel"">
        <div class=""row"">
            <div class=""col-sm-12"" data-offset=""0"">
                <div class=""panel panel-default"">



                    <div class=""card shadow mb-4"">
                        <div class=""card-header py-3"">
                            <h6 class=""m-0 font-weight-bold text-primary"">");
            EndContext();
            BeginContext(635, 29, false);
#line 22 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                                                                     Write(Model.RecruitmentNotice.Title);

#line default
#line hidden
            EndContext();
            BeginContext(664, 116, true);
            WriteLiteral("</h6>\r\n                        </div>\r\n                        <div class=\"card-body\">\r\n                            ");
            EndContext();
            BeginContext(781, 35, false);
#line 25 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                       Write(Model.RecruitmentNotice.Description);

#line default
#line hidden
            EndContext();
            BeginContext(816, 184, true);
            WriteLiteral("\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"ml-4 text-gray-600\">\r\n                            <span>Department: </span> <span>");
            EndContext();
            BeginContext(1001, 34, false);
#line 29 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                                                       Write(Model.RecruitmentNotice.Department);

#line default
#line hidden
            EndContext();
            BeginContext(1035, 206, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"ml-4 text-gray-600 card-subtitle\">\r\n                            <span>Designation: </span> <span>");
            EndContext();
            BeginContext(1242, 35, false);
#line 33 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                                                        Write(Model.RecruitmentNotice.Designation);

#line default
#line hidden
            EndContext();
            BeginContext(1277, 195, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <br />\r\n                        <div class=\"ml-4 text-gray-600\">\r\n                            <span>No. of Vacancy: </span> <span>");
            EndContext();
            BeginContext(1473, 39, false);
#line 37 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitmentNotice.NumberOfVacancy);

#line default
#line hidden
            EndContext();
            BeginContext(1512, 161, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div class=\"card-body text-danger\">\r\n                            <span>Last Date: </span> <span>");
            EndContext();
            BeginContext(1674, 52, false);
#line 40 "E:\Visual studio\HR-Management-System\HR Management System\Pages\CareerPages\ViewRecruitmentNotice.cshtml"
                                                      Write(Model.RecruitmentNotice.LastDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1726, 212, true);
            WriteLiteral("</span>\r\n                        </div>\r\n                        <div>\r\n\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.CareerPages.ViewRecruitmentNoticeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.CareerPages.ViewRecruitmentNoticeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.CareerPages.ViewRecruitmentNoticeModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.CareerPages.ViewRecruitmentNoticeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

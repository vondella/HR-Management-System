#pragma checksum "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "767ad0cab59ce0937eb90eb0b8406a4651b89b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_AdminPages_Recruitment_ManageRecruitmentNotice), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml", typeof(AspNetCore.Pages_AdminPages_Recruitment_ManageRecruitmentNotice), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"767ad0cab59ce0937eb90eb0b8406a4651b89b8b", @"/Pages/AdminPages/Recruitment/ManageRecruitmentNotice.cshtml")]
    public class Pages_AdminPages_Recruitment_ManageRecruitmentNotice : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
  
    ViewData["Title"] = "ManageRecruitmentNotice";
    Layout = "~/Views/Shared/_AdminDashboardLayout.cshtml";

#line default
#line hidden
            BeginContext(284, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(624, 843, true);
            WriteLiteral(@"


<center><h1>Manage Recruitment Notice</h1></center>

<div class=""container-fluid"">
    <div class=""wrap-fpanel"">
        <div class=""row"">
            <div class=""col-sm-12"" data-offset=""0"">
                <div class=""panel panel-default"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">
                            <strong>List of All Recruitment Notice</strong>
                        </div>
                    </div>

                 
                            <div class=""card shadow mb-4"">

                                <div class=""row"">
                                    <div class=""col-sm-6 col-md-6"">
                                        <div id=""dataTable_filter"" class=""dataTables_filter ml-4 mt-4"">
                                            ");
            EndContext();
            BeginContext(1467, 416, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767ad0cab59ce0937eb90eb0b8406a4651b89b8b5111", async() => {
                BeginContext(1486, 390, true);
                WriteLiteral(@"
                                                <label>Search:<input type=""search"" class=""form-control form-control-sm"" placeholder=""Search by Title"" aria-controls=""dataTable"" name=""src_string""></label>
                                                <span><button class=""btn btn-primary form-control-sm"" type=""submit"">Search</button></span>
                                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1883, 1216, true);
            WriteLiteral(@"
                                            
                                        </div>
                                    </div>
                                </div>


                                <div class=""card-body"">
                                    <div class=""table-responsive"">
                                        <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                                            <thead>
                                                <tr>
                                                    <th>SL</th>
                                                    <th>Title</th>
                                                    <th>Created Date</th>
                                                    <th>Designation</th>
                                                    <th>No. of Vacancy</th>
                                                    <th>Last Date</th>
                                                    <th");
            WriteLiteral(">Status</th>\r\n                                                    <th>Action</th>\r\n                                                </tr>\r\n                                            </thead>\r\n");
            EndContext();
#line 79 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                             if (Model.RecruitementNotices != null)
                                            {
                                                if (Model.RecruitementNotices.Count > 0)
                                                {
                                                    

#line default
#line hidden
#line 83 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                     if (Model.RecruitementNotices.Count > 10)
                                                    {

#line default
#line hidden
            BeginContext(3523, 849, true);
            WriteLiteral(@"                                                        <tfoot>
                                                            <tr>
                                                                <th>SL</th>
                                                                <th>Created Date</th>
                                                                <th>Designation</th>
                                                                <th>No. of Vacancy</th>
                                                                <th>Last Date</th>
                                                                <th>Status</th>
                                                                <th>Action</th>
                                                            </tr>
                                                        </tfoot>
");
            EndContext();
#line 96 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(4429, 63, true);
            WriteLiteral("                                                    <tbody>\r\n\r\n");
            EndContext();
#line 100 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                         for (int i = 0; i < Model.RecruitementNotices.Count; i++)
                                                        {

#line default
#line hidden
            BeginContext(4667, 126, true);
            WriteLiteral("                                                        <tr>\r\n                                                            <td>");
            EndContext();
            BeginContext(4795, 5, false);
#line 103 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(4801, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4873, 34, false);
#line 104 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitementNotices[i].Title);

#line default
#line hidden
            EndContext();
            BeginContext(4907, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(4979, 60, false);
#line 105 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitementNotices[i].CreatedDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5039, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5111, 40, false);
#line 106 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitementNotices[i].Designation);

#line default
#line hidden
            EndContext();
            BeginContext(5151, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5223, 44, false);
#line 107 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitementNotices[i].NumberOfVacancy);

#line default
#line hidden
            EndContext();
            BeginContext(5267, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5339, 57, false);
#line 108 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.RecruitementNotices[i].LastDate.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(5396, 71, true);
            WriteLiteral("</td>\r\n                                                            <td>");
            EndContext();
            BeginContext(5468, 59, false);
#line 109 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                           Write(Model.IsPublished(Model.RecruitementNotices[i].IsPublished));

#line default
#line hidden
            EndContext();
            BeginContext(5527, 244, true);
            WriteLiteral("</td>\r\n                                                            <td>\r\n                                                                <div class=\"row\">\r\n                                                                    <div class=\"col-12\">");
            EndContext();
            BeginContext(5771, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "767ad0cab59ce0937eb90eb0b8406a4651b89b8b14880", async() => {
                BeginContext(5848, 60, true);
                WriteLiteral("<span class=\"oi Delete-HyperLink\" data-glyph=\"trash\"></span>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                                                                                       WriteLiteral(Model.RecruitementNotices[i].Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(5912, 210, true);
            WriteLiteral("</div>\r\n                                                                </div>\r\n                                                            </td>\r\n                                                        </tr>\r\n");
            EndContext();
#line 116 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                        }

#line default
#line hidden
            BeginContext(6181, 64, true);
            WriteLiteral("\r\n                                                    </tbody>\r\n");
            EndContext();
#line 119 "E:\Github\HR-Management-System\HR Management System\Pages\AdminPages\Recruitment\ManageRecruitmentNotice.cshtml"
                                                }
                                            }

#line default
#line hidden
            BeginContext(6343, 195, true);
            WriteLiteral("                                        </table>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                       \r\n");
            EndContext();
            BeginContext(7026, 110, true);
            WriteLiteral("\r\n                    \r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HR_Management_System.Pages.ManageRecruitmentNoticeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageRecruitmentNoticeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<HR_Management_System.Pages.ManageRecruitmentNoticeModel>)PageContext?.ViewData;
        public HR_Management_System.Pages.ManageRecruitmentNoticeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

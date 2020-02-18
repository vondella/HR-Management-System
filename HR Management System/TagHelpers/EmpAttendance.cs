using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.TagHelpers
{
    public class EmpAttendance: TagHelper
    {
        public long Id { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {

            var gg = $"<a onclick=\"SetAttendance({Id}, 'present', this)\" href='#'>Present</a><a class=\"ml-2\" onclick=\"SetAttendance({Id}, 'absent', this)\" href='#'>Absent</a><a class=\"ml-2\" onclick=\"SetAttendance({Id}, 'holiday', this)\" href='#'>Holiday</a>";

            output.TagName = "div";
            output.Attributes.SetAttribute("class", "d-flex flex-row");
            output.Content.SetHtmlContent(gg);
            return Task.CompletedTask;
        }
    }
}

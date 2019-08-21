using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.TagHelpers
{



    public class EmployeeIsActiveTagHelper : TagHelper
    {
        public bool IsActive { get; set; }

        public long Id { get; set; }

        public override Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            var cls = "";

            if (IsActive == true)
            {
                cls = "employee-active";
            }
            else cls = "employee-deactive";

            var gg = $"<span class='fas fa-bolt {cls}'></span>";

            output.TagName = "a";
            output.Attributes.SetAttribute("onclick", $"ActivateDeactivateEmployee({Id}, this)");
            output.Content.SetHtmlContent(gg);
            return Task.CompletedTask;
        }
    }
}

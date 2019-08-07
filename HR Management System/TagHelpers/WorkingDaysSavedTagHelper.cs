using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.TagHelpers
{

    public class WorkingDaysSavedTagHelper: TagHelper
    {
        public bool Saved { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Attributes.Add("class", "alert alert-success");

            if (Saved == false)
            {
                output.Attributes.Add("style", "display:none;");
            }
            
            output.Attributes.Add("role", "alert");
            output.Attributes.Add("id", "WorkingdaysSavedId");
            output.Attributes.Add("onload", $"WorkingDaysSavedDiv({Saved})");
            output.Content.SetContent("Working days saved!");
        }
    }
}

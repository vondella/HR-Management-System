using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.TagHelpers
{
    //[HtmlTargetElement("rich-description")]
    public class RichDescriptionTagHelper: TagHelper
    {
        public string Description { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.Content.SetHtmlContent(Description);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class AddNoticeModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public bool Published { get; set; }


        public IActionResult OnPost( string title, string long_description, bool published)
        {
            var gfg = Published;
            return Page();
        }
    }
}
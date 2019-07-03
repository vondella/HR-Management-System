using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HR_Management_System.Pages
{
    public class DashboardModel : PageModel
    {
        [BindProperty]
        public UserModel User { get; set; }

        public void OnGet(UserModel user = null)
        {
            if(user != null)
            {
                User = user;
            }
        }
    }
}
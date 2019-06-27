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
        public MyDependency _dependency;
        public DashboardModel(MyDependency dependency)
        {
            _dependency = dependency;
        }


        [BindProperty]
        public string SimpleMessage { get; set; }


        public void OnGet()
        {
             SimpleMessage = _dependency.GetMessage();
        }
    }
}
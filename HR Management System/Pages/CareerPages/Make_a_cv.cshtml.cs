using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HR_Management_System.Data;
using HR_Management_System.Models;


namespace HR_Management_System.Pages
{
    public class Make_a_cvModel : PageModel
    {
        private readonly HRMS_DB_Context _db;
        private readonly AccountManageModel _accountManage;

        public Make_a_cvModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }


        public void OnGet()
        {

        }




        public async Task<IActionResult> OnPostAsync(string first_name, string last_name, )
        {

        }
    }
}
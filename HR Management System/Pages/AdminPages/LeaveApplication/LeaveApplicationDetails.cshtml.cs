using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using HR_Management_System.Data;
using HR_Management_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_System.Pages.AdminPages.LeaveApplication
{
    public class LeaveApplicationDetailsModel : PageModel
    {
        private readonly HRMS_DB_Context _db;

        private readonly AccountManageModel _accountManage;

        public LeaveApplicationDetailsModel(HRMS_DB_Context db, AccountManageModel accountManage)
        {
            _db = db;
            _accountManage = accountManage;
        }

      public Models.LeaveApplication LeaveApplication { get; set; }

        public async Task<IActionResult> OnGetAsync(long id)
        {
            if (_accountManage.IsLoggedIn != true || _accountManage.User.UserType != UserType.Admin)
            {
                return RedirectToPage("/LoginPage");
            }
            ViewData["User_Name"] = _accountManage.User.Name;
            ViewData.Add("ProfileImg", _accountManage.User.ProfileImageSrc);



            LeaveApplication = await _db.LeaveApplications.Include(a => a.LeaveCategory).Include(a => a.User).AsNoTracking().SingleAsync(a=>a.Id == id);

            if(LeaveApplication == null)
            {
                return NotFound();
            }


            return Page();
        }







        public string ShortDateString(DateTime? gg)
        {
            if (gg != null)
            {
                var fd = (DateTime)gg;
                return String.Format("{0: MMM d, yyyy}", fd);

            }
            return "";
        }




        public string ImgSrc(byte[] img_data)
        {
            try
            {
                var base64 = Convert.ToBase64String(img_data);
                var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                return imgSrc;
            }
            catch
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    var current_directory = Directory.GetCurrentDirectory();
                    FileStream fileStream = new FileStream($"{current_directory}/wwwroot/img/user.png", FileMode.Open);
                    fileStream.CopyTo(memoryStream);
                    var imgData = memoryStream.ToArray();
                    var base64 = Convert.ToBase64String(imgData);
                    var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                    fileStream.Close();
                    return imgSrc;
                }

            }
        }






        public async Task<IActionResult> OnPostAsync(long id, string status)
        {
            LeaveApplication = await _db.LeaveApplications.Include(a=>a.User).ThenInclude(o=>o.Attendances).SingleAsync(a=>a.Id == id);

            switch (status)
            {
                case "Pending":
                    LeaveApplication.Status = LeaveApplicationStatus.Pending;
                    break;

                case "Approved":
                    LeaveApplication.Status = LeaveApplicationStatus.Approved;
                    break;

                case "Rejected":
                    LeaveApplication.Status = LeaveApplicationStatus.Rejected;
                    break;

                case "Default":
                    LeaveApplication.Status = LeaveApplicationStatus.Pending;
                    break;
            }

            if(LeaveApplication.Status == LeaveApplicationStatus.Approved)
            {
                for(int i = 0; i < LeaveApplication.Days; i++)
                {
                    var new_date = LeaveApplication.StartDate.AddDays(i);
                    LeaveApplication.User.Attendances.Add(new Attendance
                    {
                        Status = AttendanceStatus.InLeave,
                        Date = new_date,
                        Day = new_date.Day,
                        Month = new_date.Month,
                        Year = new_date.Year
                    });
                }
                
            }

            await _db.SaveChangesAsync();
            return RedirectToPage("./LeaveApplicationList");
        }
    }
}
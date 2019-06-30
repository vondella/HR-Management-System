using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_System.Controllers
{
    public class AdminController : Controller
    {

        //when clicked on Admin Logo
        //bujhsoooo ?
        public IActionResult Dashboard()
        {
            return RedirectToPage("/AdminDashboard");
        }


        public IActionResult adminDashboard()
        {
            return RedirectToPage("/AdminDashboard");
        }

        public IActionResult SetWorkingDays()
        {
            return RedirectToPage("/Set_Working_Days");
        }
        public IActionResult Add_Employee()
        {
            return RedirectToPage("/Add_Employee");
        }

        public IActionResult logout()
        {
            return RedirectToPage("/LoginPage");
        }


        public IActionResult LeaveCategory()
        {
            return RedirectToPage("/LeaveCategory");
        }
        public IActionResult HolidayList()
        {
            return RedirectToPage("/HolidayList");
        }
        public IActionResult AddDepartment()
        {
            return RedirectToPage("/AddDepartment");
        }
        public IActionResult Departmentlist()
        {
            return RedirectToPage("/Departmentlist");
        }
        public IActionResult AddEmployee()
        {
            return RedirectToPage("/AddEmployee");
        }

        public IActionResult EmployeeList()
        {
            return RedirectToPage("/EmployeeList");
        }

        public IActionResult ManageAttendence()
        {
            return RedirectToPage("/ManageAttendence");
        }

        public IActionResult AttandenceReport()
        {
            return RedirectToPage("/AttandenceReport");
        }

        public IActionResult LeaveApplicationList()
        {
            return RedirectToPage("/LeaveApplicationList");
        }

        public IActionResult ManageSalaryDetails()
        {
            return RedirectToPage("/ManageSalaryDetails");
        }
        public IActionResult EmployeeSalaryList()
        {
            return RedirectToPage("/EmployeeSalaryList");
        }
        public IActionResult MakePayment()
        {
            return RedirectToPage("/MakePayment");
        }

        public IActionResult GeneratePayslip()
        {
            return RedirectToPage("/GeneratePayslip");
        }

        public IActionResult AddNotice()
        {
            return RedirectToPage("/AddNotice");
        }
        

        public IActionResult ManageNotice()
        {
            return RedirectToPage("/ManageNotice");
        }

        public IActionResult ManageRecruitmentNotice()
        {
            return RedirectToPage("/ManageRecruitmentNotice");
        }

        public IActionResult AddRecruitmentNotice()
        {
            return RedirectToPage("/AddRecruitementNotice");
        }

        public IActionResult Recruitment_Applicant_List()
        {
            return RedirectToPage("/Recruitment_Applicant_List");
        }

        public IActionResult Selected_Applicant_List()
        {
            return RedirectToPage("/Selected_Applicant_List");
        }

        public IActionResult Profile()
        {
            return RedirectToPage("/Profile");
        }
    }
}
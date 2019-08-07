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
            return RedirectToPage("/AdminPages/AdminDashboard");
        }


        public IActionResult adminDashboard()
        {
            return RedirectToPage("/AdminPages/AdminDashboard");
        }

        public IActionResult SetWorkingDays()
        {
            return RedirectToPage("/AdminPages/Settings/SetWorkingDays");
        }

        public IActionResult logout()
        {
            return RedirectToPage("/LoginPage");
        }


        public IActionResult LeaveCategory()
        {
            return RedirectToPage("/AdminPages/Settings/LeaveCategory");
        }
        public IActionResult HolidayList()
        {
            return RedirectToPage("/AdminPages/Settings/HolidayList");
        }
        public IActionResult AddDepartment()
        {
            return RedirectToPage("/AdminPages/Department/AddDepartment");
        }
        public IActionResult Departmentlist()
        {
            return RedirectToPage("/AdminPages/Department/Departmentlist");
        }
        public IActionResult AddEmployee()
        {
            return RedirectToPage("/AdminPages/Employee/AddEmployee");
        }

        public IActionResult EmployeeList()
        {
            return RedirectToPage("/AdminPages/Employee/EmployeeList");
        }

        public IActionResult ManageAttendence()
        {
            return RedirectToPage("/AdminPages/Attendence/ManageAttendence");
        }

        public IActionResult AttandenceReport()
        {
            return RedirectToPage("/AdminPages/Attendence/AttandenceReport");
        }

        public IActionResult LeaveApplicationList()
        {
            return RedirectToPage("/AdminPages/LeaveApplication/LeaveApplicationList");
        }

        public IActionResult ManageSalaryDetails()
        {
            return RedirectToPage("/AdminPages/Payroll/ManageSalaryDetails");
        }
        public IActionResult EmployeeSalaryList()
        {
            return RedirectToPage("/AdminPages/Payroll/EmployeeSalaryList");
        }

        public IActionResult GeneratePayslip()
        {
            return RedirectToPage("/AdminPages/Payroll/GeneratePayslip");
        }

        public IActionResult AddNotice()
        {
            return RedirectToPage("/AdminPages/Notice/AddNotice");
        }
        

        public IActionResult ManageNotice()
        {
            return RedirectToPage("/AdminPages/Notice/ManageNotice");
        }

        public IActionResult ManageRecruitmentNotice()
        {
            return RedirectToPage("/AdminPages/Recruitment/ManageRecruitmentNotice");
        }

        public IActionResult AddRecruitmentNotice()
        {
            return RedirectToPage("/AdminPages/Recruitment/AddRecruitementNotice");
        }

        public IActionResult Recruitment_Applicant_List()
        {
            return RedirectToPage("/AdminPages/Recruitment/Recruitment_Applicant_List");
        }

        public IActionResult Selected_Applicant_List()
        {
            return RedirectToPage("/AdminPages/Recruitment/Selected_Applicant_List");
        }

        public IActionResult Profile()
        {
            return RedirectToPage("/AdminPages/Profile");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class EmployeeAttendanceViewModel
    {
        public string Name { get; set; }
        public List<Attendance> Attendances { get; set; }
    }
}

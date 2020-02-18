using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class Attendance
    {
        public long Id { get; set; }
        public AttendanceStatus Status { get; set; } = AttendanceStatus.Absent;
        public DateTime Date { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int Day { get; set; }
    }



    public enum AttendanceStatus
    {
        Present,
        Absent,
        InLeave,
        Holiday,
        NotJoined
    }
}

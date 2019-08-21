using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class LeaveApplication
    {
        public long Id { get; set; }

        [Required]
        public LeaveCategory LeaveCategory { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public DateTime AppliedDate { get; set; } = DateTime.Now;

        [Required]
        public int Days { get; set; }

        public string Reason { get; set; }

        public LeaveApplicationStatus Status { get; set; } = LeaveApplicationStatus.Pending;

        [InverseProperty("LeaveApplications")]
        public UserModel User { get; set; }
    }





    public enum LeaveApplicationStatus
    {
        Approved,
        Rejected,
        Pending
    }

}

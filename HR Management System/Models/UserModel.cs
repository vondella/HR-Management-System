using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class UserModel
    {
        public long Id { get; set;}


        public byte[] ProfileImage { get; set; }

        [NotMapped]
        public string ProfileImageSrc { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Department { get; set; }
        public string Designation { get; set; }

        [Required]
        public UserType UserType { get; set; }


        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }

        public Resume Resume { get; set; }

        public DateTime? DateOfApplication { get; set; }

        public DateTime? InterviewDate { get; set; }
        
        public bool SelectedForInterview { get; set; } = false;

        public DateTime? JoiningDate { get; set; }

        public bool Status { get; set; }

        public Salary Salary { get; set; }
        
        public List<LeaveApplication> LeaveApplications { get; set; }

        public List<Attendance> Attendances { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class RecruitementNoticeModel
    {
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public DateTime LastDate { get; set; }

        [Required]
        public bool IsPublished { get; set; }

        [Required]
        public int NumberOfVacancy { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public string Designation { get; set; }

        public List<UserModel> Applicants { get; set; }
    }
}

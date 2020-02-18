using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class LeaveCategory
    {
        public long Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public int Days { get; set; }
    }
}

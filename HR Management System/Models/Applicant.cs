using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class Applicant
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }

        public DateTime? DateOfApplication { get; set; }

        public DateTime? DateOfInterview { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class DepartmentModel
    {
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public List<DesignationModel> Designation { get; set; }
    }


    public class DesignationModel
    {
        
        public long Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}

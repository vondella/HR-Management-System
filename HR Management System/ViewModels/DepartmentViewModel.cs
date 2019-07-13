using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.ViewModels
{
    public class DepartmentViewModel
    {
        public string Name { get; set; }
        public int SerialNo { get; set; }

        public List<string> Designations { get; set; }
    }
}

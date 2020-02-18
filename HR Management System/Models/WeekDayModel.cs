using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class WeekDayModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsWorkingDay { get; set; }

        [NotMapped]
        public bool IsHoliday { get { return !IsWorkingDay; } set { IsWorkingDay = !value; } }
    }
}

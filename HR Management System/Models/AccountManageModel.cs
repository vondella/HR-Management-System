using HR_Management_System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace HR_Management_System.Models
{
    public class AccountManageModel
    {
 
        public UserModel User { get; set; }

        public bool IsLoggedIn { get; set; } = false;
    }
}

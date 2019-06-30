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
        public static AccountManageModel Current;


        public UserModel User { get; set; }


        public AccountManageModel(UserModel user)
        {
            Current = this;
            User = user;
        }
    }
}

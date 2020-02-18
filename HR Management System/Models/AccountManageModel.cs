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




        public string ImgSrc(byte[] img_data)
        {
            try
            {
                var base64 = Convert.ToBase64String(img_data);
                var imgSrc = String.Format("data:image/jpg;base64,{0}", base64);
                return imgSrc;
            }
            catch
            {
                return "~/img/user.png";
            }

        }
    }
}

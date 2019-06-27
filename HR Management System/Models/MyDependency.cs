using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Management_System.Models
{
    public class MyDependency
    {
        public string msg = "shakir";
        public int count = 0;

        public string GetMessage()
        {
            count = count + 1;
            return msg + count.ToString();
        }
    }
}

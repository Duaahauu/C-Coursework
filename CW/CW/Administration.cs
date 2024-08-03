using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class Administration : User
    {
        public double Salary { get; set; }
        public bool IsFullTime { get; set; }
        public int WorkingHours { get; set; }

        public Administration()
        {
            Role = "admin";
        }
    }

}

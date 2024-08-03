using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class TeachingStaff : User
    {
        public double Salary { get; set; }
        public List<string> Subjects { get; set; }

        public TeachingStaff()
        {
            Role = "teacher";
            Subjects = new List<string>();
        }
    }
}

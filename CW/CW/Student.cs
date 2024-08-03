using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW
{
    public class Student : User
    {
        public List<string> CurrentSubjects { get; set; }
        public List<string> PreviousSubjects { get; set; }

        public Student()
        {
            Role = "student";
            CurrentSubjects = new List<string>();
            PreviousSubjects = new List<string>();
        }
    }
}

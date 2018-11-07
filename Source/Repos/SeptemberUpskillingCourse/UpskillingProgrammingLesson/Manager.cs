using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Manager : Employee   // : Employee is called Inheritance //Manager class is called a Subsclass to an Employee superclass
    {
        public string managerialRole;

        public void ExtraRole()
        {
            Console.WriteLine("Managing people is my additional Role");
        }        
    }
}

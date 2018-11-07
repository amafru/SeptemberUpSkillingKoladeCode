using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Account  //Superclass
    {
        public virtual int Balance()
        {
            Console.WriteLine("This super class balance method returns 10");
            return 10;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Amount : Account  //Subclass
    {
        public override int Balance()
        {
            Console.WriteLine("This sub class balance method returns 5");
            return 5;
        }
    }
}

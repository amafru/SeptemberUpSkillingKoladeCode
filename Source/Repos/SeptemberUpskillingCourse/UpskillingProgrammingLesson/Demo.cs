using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    static class Demo
    {
        //All the variables and methods have to be static in this class
        //But if it was a normal class, variables and methods can either be static or not

        public static string firstName = "Car";
        public static string lastName = "Key";

        public static void FullName()
        {
            Console.WriteLine("His fullname is " + firstName + " " + lastName);
        }
    }
}

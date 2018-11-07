using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3ProgrammingAssignment2
{
    class AreaOfATriangle
    {
        static void Main(string[] args)
        {
            double Area;

            Console.WriteLine("Calculate the Area of a Triangle:");
            Console.WriteLine("________________________");
            Console.WriteLine("Please enter measurement for the Triangle's base:");
            double Base = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter measurement for the Triangle's height");
            double Height = Convert.ToDouble(Console.ReadLine());

            Area = ((Base * Height) / 2);
            Console.WriteLine("Area of Triangle is: " + Area);
        
        }
    }
}

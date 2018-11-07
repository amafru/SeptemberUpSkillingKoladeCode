using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoladeWeek3ProgrammingAssignment
{
    class AverageOfThreeNumbers
    {
        static void Main(string[] args)
        {
            double Average;

            Console.WriteLine("CALCULATE AVERAGE OF 3 NUMBERS:");
            Console.WriteLine("_______________________________");
            Console.WriteLine("Please Enter your First Number: ");
            double FirstNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter your Second Number: ");
            double SecondNumber = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter your Third Number: ");
            double ThirdNumber = Convert.ToDouble(Console.ReadLine());

            Average = ((FirstNumber + SecondNumber + ThirdNumber) / 3);

            Console.WriteLine("Average of your 3 numbers is: " + Average);

        }
    }
}

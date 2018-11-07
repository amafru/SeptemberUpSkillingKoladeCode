using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ProgrammingAssignment
{
    class CountryOfOrigin
    {
        static void Main()
        {
            Console.WriteLine("Please enter your country of origin");
            string Input = Console.ReadLine();

            //string uk;
            string UK;
            string Nigeria;
            //string nigeria;
            string Cameroon;
            //string cameroon;

            if(Input == "UK")
            {
                Console.WriteLine("You are from Europe");
            }
            else if(Input == "Nigeria")
            {
                Console.WriteLine("You are from Africa");
            }
            else if(Input == "Cameroon")
            {
                Console.WriteLine("You are from Africa");
            }
            else
            {
                Console.WriteLine("You are from the rest of the world");
            }
            Console.Read();
        }
    }
}

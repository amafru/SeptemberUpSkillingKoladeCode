using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4ProgrammingAssignment
{
    class ChooseABrowser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From the list below, please select a browser to run your Automated Tests");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("Enter '1' For Internet Explorer");
            Console.WriteLine("Enter '2' For Firefox");
            Console.WriteLine("Enter '3' For Google chrome");
            Console.WriteLine("Enter '4' For Safari");


            Console.WriteLine("Please type in your choice:");

            string Choice = Console.ReadLine();
            switch (Choice)
            {
                case "1":
                    Console.WriteLine("Test automation scripts will use Internet Explorer to run regression tests");
                    break;
                case "2":
                    Console.WriteLine("Test automation scripts will use Firefox to run regression tests");
                    break;
                case "3":
                    Console.WriteLine("Test automation scripts will use Google chrome to run regression tests");
                    break;
                case "4":
                    Console.WriteLine("Test automation scripts will use Safari to run regression tests");
                    break;
                default:
                    Console.WriteLine("This browser does not exits");
                    break;
                
            }
        }
    }
}

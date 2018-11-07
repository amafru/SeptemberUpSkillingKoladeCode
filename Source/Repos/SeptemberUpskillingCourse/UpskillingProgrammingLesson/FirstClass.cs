using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class FirstClass
    {
        SecondClass secondClassObj = new SecondClass(); //This is an object
        ThirdClass thirdClassObj;

        //This is a method that has the same name as the class
        //It can be used to set default value(s)
        //It gets executed first when the method is called or referenced
        public FirstClass(ThirdClass _thirdClass)
        {
            Console.WriteLine("This is a Constructor");
            thirdClassObj = _thirdClass;
        }

        public FirstClass(string name)
        {
            Console.WriteLine(name + " This is a Constructor");
        }

        double firstNumber = 20.5;
        int secondNumber = 10;
        public static string name = "Mouse";

        // firstNumber and secondNumber are class level variables. or global variables
        //while variable 'result' within AdditionOfTwoNumbers method is a method-level variable
        //A method can also be called a function

        public void FirstMethodFirstClass()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            secondClassObj.SecondMethodSecondClass();
            thirdClassObj.ThirdMethodThirdClass();
        }

        public static void Model()
        {
            Console.WriteLine("The car is new");
        }

        public void AdditionOfTwoNumbers()
        {
            double sum = firstNumber + secondNumber;
            Console.WriteLine("Addition of two numbers = " + sum);
        }

        public double MultiplicationOfTwoNumbers()
        {
            double result = firstNumber * secondNumber;
            Console.WriteLine("Multiplication of two numbers = " + result);
            return result;
        }

        //Note: numberOne, numberTwo and numberThree in the Addition method below 
        //are called Parameters
        public void Addition(double numberOne, double numberTwo, double numberThree)
        {
            double total = numberOne + numberTwo + numberThree;
            Console.WriteLine("Addition of three numbers = " + total);
        }
    }
}

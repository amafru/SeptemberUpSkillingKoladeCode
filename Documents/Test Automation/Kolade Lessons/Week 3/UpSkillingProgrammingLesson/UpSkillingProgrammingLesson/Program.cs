using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Datatypes or Types (Integer, String, Boolean, Var) 
            //String manipulation
            //Class
            //Object (instance or static)
            //Constructor
            //Access modifier (private, public, internal)
            //Method (parameter, argument, return, void)
            //Object Oriented Programming (Encapsulation, Polymorphism, Inheritance, Abstraction)
            //Try-catch statement
            //Conditional statements (if, switch-case)
            //Control statements (for, for-each, while, do-while)
            //Collections (List, Array, Dictionary)
            //Concatenation

            ////Task 1
            //Console.WriteLine("Enter your name ");
            //string name = Console.ReadLine(); //reads data from the console
            //Console.WriteLine("Hello world!"); //writes data to the console
            //Console.WriteLine(name);

            ////Task 2
            //// Identify different data types with examples
            //string firstName = "Ade";  //string - datatype, firstName - variable, 
            //                           //Ade - a value assigned to a variable firstname
            //string value = "5000";  //this is an example of hardcoding 
            //int age = 30;
            //bool isEnabled = true;
            //double money = 23.22;
            //long longNumber = 12345678912;
            //double VAT = 0.2;

            //Value / Values can be from different sources e.g. directly assigned to a 
            // variable - hardcoding, coming from console or user interface,
            // coming from a datasource - like database, XML, Json, CSV, Excel etc


            //Task 3
            //Write a program to add two numbers
            //Remember that any values inputted to the console will be a string even 
            // it is 33 (which to human it's an integer), true (which to human it's a boolean)
            // 22.33 (which to human it's a double). To a computer, it's a string. It needs conversion
            Console.WriteLine("What's the first number? ");
            int firstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("What's the second number? ");
            int secondNumber = Convert.ToInt16(Console.ReadLine());
            int total = firstNumber + secondNumber;
            Console.WriteLine("Addition of two numbers = " + total);
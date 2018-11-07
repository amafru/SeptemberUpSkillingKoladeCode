using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UpskillingProgrammingLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod();

            //Datatypes or Types (Integer, String, Boolean, Var) (Covered)
            //String manipulation (Covered)
            //Class (Covered)
            //Object (instance (Covered) or static (Covered))
            //Constructor (Covered)
            //Access modifier (private, public, internal) (Covered)
            //Method (parameter (Covered), argument (Covered), return (Covered), void (Covered))
            //Object Oriented Programming (Encapsulation (Covered), Polymorphism (Covered), Inheritance (Covered), Abstraction (Covered))
            //Try-catch statement (Covered)
            //Conditional statements (if, switch-case) (Covered)
            //Control statements (for, for-each, while, do-while) (Covered)
            //Collections (List, Array, ArrayList, Dictionary) (Covered)
            //Concatenation (Covered)
            //Read and write data from Notepad to the console (covered)

            //Task 1
            //Console.WriteLine("Enter your name ");
            //string name = Console.ReadLine(); //reads data from the console
            //Console.WriteLine("Hello world!"); //writes data to the console
            //Console.WriteLine(name);

            ////Task 2
            // Identify different data types with examples
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
            //Console.WriteLine("What's the first number? ");
            //int firstNumber = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine("What's the second number? ");
            //int secondNumber = Convert.ToInt16(Console.ReadLine());
            //int total = firstNumber + secondNumber;
            //Console.WriteLine("Addition of two numbers = " + total);


            //Task 4
            //Find the average of three numbers
            //Console.WriteLine("What's the first number? ");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What's the second number? ");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What's the third number? ");
            //double thirdNumber = Convert.ToDouble(Console.ReadLine());
            //double average = (firstNumber + secondNumber + thirdNumber) / 3;
            //Console.WriteLine("Average of three numbers = " + average);

            //Task 5
            //Camel case : myNameIsKay
            //Find the area of a triangle
            ////formular   area of triangle = 0.5 * base * height
            //Console.WriteLine("What is the base?");
            //double baseOfTriangle = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("What is the height?");
            //double heightOfTriangle = Convert.ToDouble(Console.ReadLine());
            //double areaOfTriangle = 0.5 * baseOfTriangle * heightOfTriangle;
            //Console.WriteLine("Area of a triangle = " + areaOfTriangle);

            //Task 6
            //Try-catch 
            // to get below piece of code, type 'try' and twice the 'tab' key on your keyboard
            //try
            //{
            //    Console.WriteLine("What's the first number? ");
            //    double firstNumber = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("What's the second number? ");
            //    double secondNumber = Convert.ToDouble(Console.ReadLine());
            //    double total = firstNumber + secondNumber;
            //    Console.WriteLine("Addition of two numbers = " + total);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    //Console.WriteLine("Input value is not in a correct format");
            //}

            //Task 7
            //Write a computer program to print 1 to 9 to the console
            //Put all the code in this Main method
            //Console.WriteLine("1");
            //Console.WriteLine("2");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");

            //Task 8
            //Write a computer program to print 1 to 9 to the console
            //Put your code in this Program class
            //Split your code accross 3 methods and call those methods from the Main method
            //FirstMethod();
            //SecondMethod();
            //ThirdMethod();

            //Task 9
            //Remember the concept of access modifier
            //Access modifier can be Private or Public and it works for variables, methods and classes
            //Variables and Methods to be visible from another class have to be made Public
            //They are Private by default
            //Write a computer program to print 1 to 9 to the console
            //Put your code in three different methods which belong to three different classes
            //Make sure that the method from each class get referenced from the Main method
            //Object is an instance of a class while a class is a blue print for an object
            //FirstClass firstClassObj = new FirstClass();
            //SecondClass secondClassObj = new SecondClass();
            //ThirdClass thirdClassObj = new ThirdClass();
            //firstClassObj.FirstMethodFirstClass(); //print 1 to 3
            //secondClassObj.SecondMethodSecondClass(); //print 4 to 6
            //thirdClassObj.ThirdMethodThirdClass(); //print 7 to 9

            //Operators
            // plus => +
            // minus => -
            // multiplication => *
            // division => /
            // modulo => %
            // assignment sign => =
            // equality sign => ==
            // or-statement => ||
            // and-statement => &&
            // greater than => >
            // less than => <
            // greater than or equal to => >=
            // less than or equal to => <=

            //Task 10
            //If - statement(conditional statement)
            //Write a computer program to ask a user to input a number.
            //Display 'Yes' to the console if the number is greater than 10
            //Display 'No' to the console if the number is less than 10
            //Display 'Equal' to the console if the number is equal to 10
            //Console.WriteLine("Enter a number");
            //int number = Convert.ToInt16(Console.ReadLine());
            ////Type if and Press Tab key twice to get the code snipet for an if-statement
            //if (number > 10)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else if (number < 10)
            //{
            //    Console.WriteLine("No");
            //}
            //else if (number == 10)
            //{
            //    Console.WriteLine("Equal");
            //}

            //Task 11
            //Solution to the assignment
            // Browsers input computer program using case-statement
            //Console.WriteLine("Please enter a browser name");
            //string browserName = Console.ReadLine().ToLower();
            //switch (browserName)
            //{
            //    case "chrome":
            //        Console.WriteLine("Chrome browser will be used to run test");
            //        break;
            //    case "firefox":
            //        Console.WriteLine("Firefox browser will be used to run test");
            //        break;
            //    case "safari":
            //        Console.WriteLine("Safari browser will be used to run test");
            //        break;
            //    case "ie":
            //        Console.WriteLine("Safari browser will be used to run test");
            //        break;
            //    default:
            //        Console.WriteLine("Opera as a default browser will be used to run the test");
            //        break;
            //}

            //Task 12
            //A user to input country of their origin
            //Console.WriteLine("What is your country of origin?");
            //string countryOfOrigin = Console.ReadLine().ToLower();
            //if (countryOfOrigin == "uk")
            //{
            //    Console.WriteLine("You are from Europe");               
            //}
            //else if (countryOfOrigin == "cameroon")
            //{
            //    Console.WriteLine("You are from Africa");
            //}
            //else
            //{
            //    Console.WriteLine("You are from rest of the world");
            //}

            //Control statements (for, for-each, while, do-while)
            //Collections (List, Array, ArrayList, Dictionary)
            //Code snipet

            //Task 13
            //for-statement
            //Write a computer program to generate numbers between 1 and 20
            //Write those numbers to the console
            //for (int i = 1; i <= 20; i++)  // i++ is an incremental
            //{
            //    Console.WriteLine(i);
            //}


            //Task 14            
            //for-statement
            //Write a computer program to generate numbers between 1 and 20
            //Write to the console all the odd numbers
            //e.g 1,3,5,7,9,11,13,15,17,19 = odd numbers  
            //Odd number is a number that is divisible by 2 with remainder 1 
            // Modulo => %    
            // Plus => +
            // Minus => -
            // Division => /
            // 4/2 = 2
            // 4%2 = 0     
            // 5%2 = 1
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task 14 option
            //for-statement
            //Write a computer program to generate numbers between 1 and 20
            //Write to the console all the odd numbers
            //e.g 1,3,5,7,9,11,13,15,17,19 = odd numbers  
            //for (int i = 1; i <= 20; i+=2)  // i++ is an incremental
            //{
            //    Console.WriteLine(i);
            //}

            //Task 15                    
            //for-statement
            //Write a computer program to generate numbers between 1 and 20
            //Write to the console all the even numbers
            //e.g. 2,4,6,8,10,12,14,16,18,20 = even numbers
            //Even number is a number that is divisible by 2 with remainder 0
            //Modulo => %
            //for (int i = 1; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task 16 : Solution to the assignment
            //Write a computer program to generate numbers between 1 and 45
            //Write your 'firstname' to the console if a number is a multiple of 3,
            //Write your 'lastname' to the console if a number is a multiple of 5,
            //Write your both your 'firstname lastname' to the console if a number is a multiple of 3 and 5,
            //Likely result
            //3 Lola
            //5 Joe
            //15 Lola Joe
            //for (int number = 1; number <= 45; number++)
            //{
            //    if (number % 3 == 0 && number % 5 == 0)
            //    {
            //        Console.WriteLine(number + " = Lola Joe");
            //    }
            //    else if (number % 3 == 0)
            //    {
            //        Console.WriteLine(number + " = Lola");
            //    }
            //    else if (number % 5 == 0)
            //    {
            //        Console.WriteLine(number + " = Joe");
            //    }                
            //}

            //Below code is not a good to represent group of data. Please avoid it
            //string firstStudent = "Ama";
            //string secondStudent = "Bisi";
            //string thirdStudent = "Ola";
            //string fourthStudent = "Jide";
            //string fifthStudent = "Kelly";
            //Console.WriteLine(firstStudent);
            //Console.WriteLine(secondStudent);
            //Console.WriteLine(thirdStudent);
            //Console.WriteLine(fourthStudent);
            //Console.WriteLine(fifthStudent);

            //Task 17
            //Write a computer program to group together list of students name and write their
            //name to the console
            //Array is a group of data with related datatype and of fixed length
            //string[] students = new string[5] { "Ama", "Bisi", "Ola", "Jide", "Kelly" };
            ////Console.WriteLine(students); you cannot see the data in an array like this
            ////use foreach-statement to iterate through the collection
            //foreach (var item in students)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 18
            //Write a computer program to group together list of students and write 
            //to the console only students with name Bisi or Jide
            //Array is a group of data with related datatype
            //string[] students = new string[5] { "Ama", "Bisi", "Ola", "Jide", "Kelly" };
            ////Console.WriteLine(students); you cannot see the data in an array like this
            ////use foreach-statement to iterate through the collection
            //foreach (var item in students)
            //{
            //    if (item == "Bisi" || item == "Jide")
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Task 19
            //Write a computer program to group together list of students age and write their
            //individual age to the console
            //int[] studentsAge = new int[] { 34, 33, 40, 47, 50 };
            //int[] studentsAge = new int[5];
            //studentsAge[0] = 34;
            //studentsAge[1] = 33;
            //studentsAge[2] = 40;
            //studentsAge[3] = 47;
            //studentsAge[4] = 50;
            //foreach (var item in studentsAge)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 20
            //List is a group of data with similar datatype but not of a fixed length
            //Write a computer program to group together list of students name 
            //Remove a few names after you have added it 
            //And add more names to the list before printing them to the console
            //List<string> studentNames = new List<string>() { "Zina", "Ursula", "William", "Taofik", "Test", "Browser" };
            //studentNames.Remove("Test");
            //studentNames.Remove("Browser");
            //studentNames.Add("Nurudeen");
            //studentNames.Add("Eric");
            //studentNames.Add("Sultan");
            ////implement foreach-statement to see the data in the list
            //foreach (var item in studentNames)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 21
            //List of integers            
            //Write a computer program to group together list of students age             
            //Print to the console students age between 20 and 30
            //List<int> studentsAge = new List<int>() { 23,33,34,29,35,21};
            ////implement foreach-statement to see the data in the list
            //foreach (var item in studentsAge)
            //{
            //    if (item >= 20 && item <= 30)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            //Task 22
            //Arraylist can be used to hold group of data with different datatypes
            //Write a computer program to capture a student attributes
            //And write to the console those attributes
            //By attribute, I mean firstname, age, bank account balance, blackOrWhite
            //ArrayList studentAttributes = new ArrayList() { "Lola", 30, 3456.45, true }; //we've captured data of different datatypes
            ////implement foreach to see the data in the list
            //foreach (var item in studentAttributes)
            //{
            //    Console.WriteLine(item);
            //}

            //Task 23
            //Dictionary allows programmer to hold keys and values of a group of data
            //It evolves depends on programmers need i.e. you can add or remove data from a dictionary
            //Write a computer program to hold both student id and student firstname
            //Print to the console only student names
            //Dictionary<int, string> studentsRecord = new Dictionary<int, string>();
            //studentsRecord.Add(1, "Ama");
            //studentsRecord.Add(2, "Bisi");
            //studentsRecord.Add(3, "Olanipekun");
            //studentsRecord.Add(4, "Eric");
            //studentsRecord.Add(5, "Jide");
            //studentsRecord.Add(6, "Mouse");
            //studentsRecord.Remove(6);
            ////implement foreach to print students first name
            //foreach (var item in studentsRecord)
            //{
            //    Console.WriteLine(item.Value);
            //}

            //Task 24
            //While-statement
            //Write a Computer program to ask a user to input a number 
            //and print to the console 'Hello world' if the number is less than 5
            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());
            //while (number <= 5)
            //{
            //    Console.WriteLine("Hello world");
            //    break;
            //}

            //Task 25
            //Do-while
            //Write a Computer program to ask a user to input a number 
            //and print to the console 'Hello world' if the number is less than 5
            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());
            //do
            //{
            //    Console.WriteLine("Hello world");
            //    break;
            //} while (number <= 5);

            //Task 26
            //Above question (Task 25) can also be solved using if-statement as below:
            //Console.WriteLine("Enter a positive number");
            //int number = Convert.ToInt16(Console.ReadLine());
            //if (number <= 5)
            //{
            //    Console.WriteLine("Hello world");
            //}

            //Task 27
            //Method
            //return and void keywords 
            //Create or use an existing class (apart from Program class) to write the following method types:
            //A method that does not return anything (i.e. a void method)
            //A method that does return a value, use that value for further calculation (like to multiply itself)
            //FirstClass firstClassObj = new FirstClass();
            //firstClassObj.AdditionOfTwoNumbers();
            //firstClassObj.MultiplicationOfTwoNumbers();
            ////Keyword 'var' can be used to keep the result that non-void method is returning
            //var returnedValue = firstClassObj.MultiplicationOfTwoNumbers();
            //Console.WriteLine("Multiply the returned value by itself = "+ returnedValue * returnedValue);

            //Libraries (default, in-built and external)   //

            //Task 28
            //Parameter and Argument
            //Write a computer program to take three values from a user and write to the console addition of those values
            //Note: create a method in another class and pass above values you are getting from an end user to the
            //method as parameters
            //Console.WriteLine("Enter first number: ");
            //double firstNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter second number: ");
            //double secondNumber = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter third number: ");
            //double thirdNumber = Convert.ToDouble(Console.ReadLine());
            //FirstClass firstClassObj = new FirstClass();
            //firstClassObj.Addition(firstNumber, secondNumber, thirdNumber);
            ////Note: firstNumber, secondNumber and thirdNumber are called Arguments

            //Task 29
            //Constructor
            //This is a method that has the same name as the class
            //It can be used to set default value(s)
            //It gets executed first when the method is called or referenced
            //Write a computer program to create a constructor in 'FirstClass' class
            //FirstClass firstClassObj = new FirstClass("Lola");
            //FirstClass firstClassObjTwo = new FirstClass();


            //Task 30
            //Read more about Static and Instance class
            //Static (Class(es), Method(s), Variable(s) etc)
            //An instance of a Static class cannot be created. The class has to be 
            //called directly to have access to its variable(s) and method(s)
            //Write a computer program to create a static class with atleast
            //one variable and a method in it. Then call that static class
            //from the program class         
            //Demo.FullName();          
            //FirstClass.Model();

            //Task 31
            //Object Oriented Programming (Encapsulation (covered), Polymorphism, Inheritance (covered), Abstraction (covered))
            //Encapsulation 
            //Abstraction
            //Encapsulation is defined 'as the process of enclosing one or more items within a physical or logical package'. Encapsulation, in object oriented programming methodology, prevents access to implementation details.
            //https://www.tutorialspoint.com/csharp/csharp_encapsulation.htm
            //Abstraction is one of the principle of object oriented programming. It is used to display only necessary and essential features of an object to ouside the world.Means displaying what is necessary and encapsulate the unnecessary things to outside the world.Hiding can be achieved by using "private" access modifiers.
            //https://www.onlinebuff.com/article_oops-principle-abstraction-in-c-with-an-example-and-explanation_5.html

            //Inheritance: this is related to two classes where one class inherits the members (like variables or methods) from another class
            //Write a computer program to capture both Employee and Manager attributes such that
            //Manager class inherits from an Employee class. Create an instance (i.e. Object) of Manager class
            //and display to the console the results
            //Manager managerBisi = new Manager();
            //managerBisi.firstName = "Adebisi";
            //managerBisi.lastName = "Adesina";
            //managerBisi.age = 36;
            //managerBisi.salary = 78564.45;
            //managerBisi.managerialRole = "CEO";
            //managerBisi.EmployeeDetails();
            //managerBisi.ExtraRole();

            //Console.WriteLine();

            //Employee employeeAma = new Employee();
            //employeeAma.firstName = "Ama";
            //employeeAma.lastName = "Ngwashi Fru";
            //employeeAma.age = 33;
            //employeeAma.salary = 62345.34;
            //employeeAma.EmployeeDetails();

            //Task 32
            //Polymorphism
            //Concept of method overloading and method overidden 
            //https://www.c-sharpcorner.com/UploadFile/0c1bb2/method-oveloading-and-overriding-C-Sharp/
            //Method Overloading: more than one methods with the same name but 
            //different signatures (i.e. they have different numbers of parameters in them)
            //Write a computer program to have 3 methods with the same name and display
            //their differences to the console. Use employee class to do the work
            //Employee employeeObj = new Employee();
            //employeeObj.Model();
            //employeeObj.Model(41);
            //employeeObj.Model("Iphone 6");

            //Task 33
            //Method overriden (under Polymorphism)
            //Creating the method in a derived class with same name, same parameters and same return type as in base class is called as method overriding.
            //https://www.c-sharpcorner.com/UploadFile/0c1bb2/method-oveloading-and-overriding-C-Sharp/
            //Write a Computer program to implement two classes (Amount and Account). 
            //Let Account class inherits from Amount class and allow them to have the same methods
            //for overriden purpose (use keyword virtual and override to different them)
            //Amount amountObj = new Amount();
            //amountObj.Balance();
            //Account accountObj = new Account();
            //accountObj.Balance();

            //Task 34
            //Create a notepad file (called Test) and load it with contents
            //Write a computer program to read the contents from Test notepad
            //and write the contents to the console
            //using (var reader = new StreamReader(@"Test.txt"))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

        }

        static void NewMethod()
        {
            Console.WriteLine("I live in London");
        }

        static void FirstMethod()
        {
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
        }

        static void SecondMethod()
        {
            Console.WriteLine("4");
            Console.WriteLine("5");
            Console.WriteLine("6");
        }

        static void ThirdMethod()
        {
            Console.WriteLine("7");
            Console.WriteLine("8");
            Console.WriteLine("9");
        }
    }
}


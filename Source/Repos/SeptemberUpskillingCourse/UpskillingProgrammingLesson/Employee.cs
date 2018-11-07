using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpskillingProgrammingLesson
{
    class Employee   //This is a superclass to a Manager class
    {
        public string firstName;
        public string lastName;
        public int age;
        public double salary;
        string uniqueFeature;

        public void EmployeeDetails()
        {
            Console.WriteLine("His name is " + firstName + " " + lastName);
            Console.WriteLine("He's of age " + age);
            Console.WriteLine("He's on salary " + salary);
        }

        public void Model() //This method has zero parameters
        {
            Console.WriteLine("This is Nokia 3310");
        }

        public void Model(string modelName) //This method has one parameter with datatype string
        {
            Console.WriteLine("This is " + modelName);
        }

        public void Model(int modelNumber) //This method has one parameter with datatype integer
        {
            Console.WriteLine("This is Samsung s9+ with model number "+ modelNumber);
        }
        //It means that the above method (Model) has been overloaded
    }
}

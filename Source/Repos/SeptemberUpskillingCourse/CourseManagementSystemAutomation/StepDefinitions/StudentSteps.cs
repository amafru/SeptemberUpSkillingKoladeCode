using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementSystemAutomation.Hooks;
using CourseManagementSystemAutomation.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow.Assist;
using CourseManagementSystemAutomation.Model;

namespace CourseManagementSystemAutomation.StepsDefinition
{
    [Binding]  //specflow annotation
    public class StudentSteps
    {
        Context context;
        Student student;
        DatabaseHelper databaseHelper;

        //Use Constructor dependency injection approach to get an instance of a class (Object)
        public StudentSteps(Context _context, Student _student, DatabaseHelper _dbHelper)   //This is a constructor
        {
            context = _context;
            student = _student;
            databaseHelper = _dbHelper;
        }

        [BeforeScenario] //any code here would be executed before test run
        public void BeforeTestRunActivity()
        {
            
        }

        [AfterScenario]  //any code here would be executed after test run
        public void CloseApplicationUnderTest()
        {
            context.ShutDown();
        }

        [Given(@"that Course Management System is loaded")]
        public void GivenThatCourseManagementSystemIsLoaded()
        {
            context.SetUp();
        }

        [When(@"a user clicks on Students link")]
        public void WhenAUserClicksOnStudentsLink()
        {
            databaseHelper.ClearTable("Person");
            student.ClickOnStudentLink();
        }

        [When(@"a user clicks on Create New link")]
        public void WhenAUserClicksOnCreateNewLink()
        {
            student.ClickOnCreateNewLink();
        }

        [When(@"a user fill-in Family Name field with (.*)")]
        public void WhenAUserFill_InFamilyNameFieldWithTom(string familyName)
        {
            student.FillInFamilyNameField(familyName);
        }

        [When(@"a user fill-in First Name field with (.*)")]
        public void WhenAUserFill_InFirstNameFieldWithBrett(string firstName)
        {
            student.FillInFirstNameField(firstName);
        }

        [When(@"a user fill-in Enrollment Date field with (.*)")]
        public void WhenAUserFill_InEnrollmentDateFieldWith(string enrollmentDate)
        {
            student.FillInEnrollmentDateField(enrollmentDate);
        }

        [When(@"a user clicks on Student Create Button")]
        public void WhenAUserClicksOnCreateButton()
        {
            student.ClickOnStudentCreateButton();
        }

        [Then(@"a new student record (.*) should be created")]
        public void ThenANewStudentRecordShouldBeCreated(string expectedResult)
        {
            string actualResult = student.StudentRecordsTable();
            Assert.IsTrue(expectedResult.Equals(actualResult), "Expected result " + expectedResult +" is different from the actual result "+ actualResult);
        }

        [When(@"a user fill-in a form with the following data:")]
        public void WhenAUserFill_InAFormWithTheFollowingData(Table table)
        {
            var tableData = table.CreateInstance<StudentModel>();
            student.FillInFamilyNameField(tableData.FamilyName);
            student.FillInFirstNameField(tableData.FirstName);
            student.FillInEnrollmentDateField(tableData.EnrollmentDate);
        }

        [When(@"a user fill-in a form for (.*), (.*), (.*) fields")]
        public void WhenAUserFill_InAFormForBrettTomFields(string familyName, string firstName, string enrollmentDate)
        {
            student.FillInFamilyNameField(familyName);
            student.FillInFirstNameField(firstName);
            student.FillInEnrollmentDateField(enrollmentDate);
        }      

        [Then(@"an expected result is equal to (.*)")]
        public void ThenAnExpectedResultIsEqualToANewStudentRecordShouldBeCreated(string expectedResult)
        {
            //var can used (for example to replace string datatype in the code below) 
            //when you are not sure of what the actual datatype is OR trying not to be explicit 
            string actualResult = string.Empty;
            string actualResult1 = "";
            string actualResult2 = "";            

            if (expectedResult.Equals("Brett"))
            {
                actualResult = student.StudentRecordsTable();                
            }
            else if (expectedResult.Equals("Last name is required"))
            {
                actualResult = student.FamilyNameErrorMessage();                
            }
            else if (expectedResult.Equals("First name is required"))
            {
                actualResult = student.FirstNameErrorMessage();                 
            }
            else if (expectedResult.Equals("Enrollment date is required"))
            {
                actualResult = student.EnrollmentDateErrorMessage();                
            }
            else if (expectedResult.Equals("First name is required,Enrollment date is required"))
            {
                actualResult1 = student.FirstNameErrorMessage();
                actualResult2 = student.EnrollmentDateErrorMessage();
                actualResult = actualResult1 + "," + actualResult2;                
            }
            else if(expectedResult.Equals("Last name is required,First name is required"))
            {
                actualResult1 = student.FamilyNameErrorMessage();
                actualResult2 = student.FirstNameErrorMessage();
                actualResult = actualResult1 + "," + actualResult2;                
            }
            else if (expectedResult.Equals("Last name is required,Enrollment date is required"))
            {
                actualResult1 = student.FamilyNameErrorMessage();
                actualResult2 = student.EnrollmentDateErrorMessage();
                actualResult = actualResult1 + "," + actualResult2;                
            }
            Assert.IsTrue(expectedResult.Equals(actualResult), "Expected result " + expectedResult + " is different from the actual result " + actualResult);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagementSystemAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using System.Threading;

namespace CourseManagementSystemAutomation.Pages
{
    public class Student
    {
        //Reference Context class so as to make Selenium WebDriver availble in it
        Context context;

        public Student(Context _context)
        {
            context = _context;
        }
              
        By studentLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[1]/a");
        By createNewLink = By.XPath("/html/body/div[2]/p/a");
        By familyName = By.Id("LastName");
        By firstName = By.Id("FirstName");
        By enrollmentDate = By.Id("EnrollmentDate");
        By createStudentBtn = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");
        By studentRecordsTable = By.XPath("/html/body/div[2]/table");
        By tableRow = By.TagName("tr");
        By tableData = By.TagName("td");
        By errorMsgFamilyName = By.XPath("/html/body/div[2]/form/div/div[2]/div/span");
        By errorMsgFirstName = By.XPath("/html/body/div[2]/form/div/div[3]/div/span");
        By errorMsgEnrollmentDate = By.XPath("/html/body/div[2]/form/div/div[4]/div/span");

        public void ClickOnStudentLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(studentLink).Click();            
        }

        public void ClickOnCreateNewLink()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(createNewLink).Click();
        }

        public void FillInFamilyNameField(string familyNameData)
        {
            //You'll need two actions for every sendKeys (i.e. write to a field) activity
            //Clear the field 
            //Then write a value to the field
            //context.driver.FindElement(familyName).Clear();
            //context.driver.FindElement(familyName).SendKeys(familyNameData);
            //Better way to write above code is as below
            Thread.Sleep(2000);
            IWebElement familyNameField = context.driver.FindElement(familyName);
            familyNameField.Clear();
            familyNameField.SendKeys(familyNameData);
        }

        public void FillInFirstNameField(string firstNameData)
        {
            Thread.Sleep(2000);
            IWebElement firstNameField = context.driver.FindElement(firstName);
            firstNameField.Clear();
            firstNameField.SendKeys(firstNameData);
        }

        public void FillInEnrollmentDateField(string enrollmentDateData)
        {
            Thread.Sleep(2000);
            IWebElement enrollmentDateField = context.driver.FindElement(enrollmentDate);
            enrollmentDateField.Clear();
            enrollmentDateField.SendKeys(enrollmentDateData);
        }

        public void ClickOnStudentCreateButton()
        {
            Thread.Sleep(2000);
            context.driver.FindElement(createStudentBtn).Click();
            Thread.Sleep(2000);
        }

        public string StudentRecordsTable()
        {
            IWebElement tableElement = context.driver.FindElement(studentRecordsTable);
            var rows = tableElement.FindElements(tableRow).Skip(1); //skip the header
            string actualData = "";

            foreach (IWebElement row in rows)
            {
                var rowData = row.FindElements(tableData);
                foreach (var data in rowData)
                {
                    actualData = data.Text;
                    break;
                }
                break;
            }
            return actualData;
        }

        public string FamilyNameErrorMessage()
        {            
            return context.driver.FindElement(errorMsgFamilyName).Text;            
        }

        public string FirstNameErrorMessage()
        {
            return context.driver.FindElement(errorMsgFirstName).Text;
        }

        public string EnrollmentDateErrorMessage()
        {
            string enrollmentDateErrorMsg = context.driver.FindElement(errorMsgEnrollmentDate).Text;
            return enrollmentDateErrorMsg;
        }
    }
}

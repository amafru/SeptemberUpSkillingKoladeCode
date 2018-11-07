using CourseManagementSystemAutomation.Hooks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CourseManagementSystemAutomation.Pages
{
    public class Course
    {
        Context context;

        public Course(Context _context)
        {
            context = _context;
        }

        By courseLink = By.XPath("/html/body/div[1]/div/div[2]/ul[1]/li[2]/a");
        By createNewCourseLink = By.XPath("/html/body/div[2]/p/a");
        By courseNumberField = By.Id("CourseId");
        By titleField = By.Id("CourseName");
        By creditField = By.Id("TotalCredits");
        By departmentField = By.Id("DepartmentId");
        By createCourseButton = By.XPath("/html/body/div[2]/form/div/div[5]/div/input");
        By courseRecordsTable = By.XPath("/html/body/div[2]/table");
        By courseTableRow = By.TagName("tr");
        By courseTableData = By.TagName("td");

        public void CourseLink()
        {
            context.driver.FindElement(courseLink,30).Click();
            //Thread.Sleep(1000);
        }

        public void CreateNewCourseLink()
        {
            context.driver.FindElement(createNewCourseLink,20).Click();
            //Thread.Sleep(1000);
        }

        public void CourseNumberField(string courseNumber)
        {
            IWebElement course = context.driver.FindElement(courseNumberField);
            course.Clear();
            course.SendKeys(courseNumber);
            Thread.Sleep(1000);
        }

        public void TitleField(string titleData)
        {
            IWebElement title = context.driver.FindElement(titleField);
            title.Clear();
            title.SendKeys(titleData);
            Thread.Sleep(1000);
        }

        public void CreditsField(string creditData)
        {
            IWebElement credit = context.driver.FindElement(creditField);
            credit.Clear();
            credit.SendKeys(creditData);
            Thread.Sleep(1000);
        }

        public void DepartmentMenu(string departmentText)
        {
            IWebElement departmentMenu = context.driver.FindElement(departmentField);
            SelectElement element = new SelectElement(departmentMenu);
            element.SelectByText(departmentText);
            Thread.Sleep(1000);
        }

        public void CreateCourseButton()
        {
            context.driver.FindElement(createCourseButton,15).Click();
            //Thread.Sleep(1000);
        }

        public string CourseResultPageTable()
        {
            int counter = 0; //implement counter so as to manage result data to return
            IWebElement tableElement = context.driver.FindElement(courseRecordsTable);
            var rows = tableElement.FindElements(courseTableRow).Skip(1); //skip the header
            string actualData = "";

            foreach (IWebElement row in rows)
            {
                var rowData = row.FindElements(courseTableData);
                foreach (var data in rowData)
                {
                    counter++;  //we would like to get the second data in the record
                    if (counter == 2)
                    {
                        actualData = data.Text;
                        break;
                    }                   
                }
                break;
            }
            return actualData;
        }        
    }
}

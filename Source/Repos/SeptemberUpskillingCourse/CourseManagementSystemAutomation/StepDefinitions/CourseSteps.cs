using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using CourseManagementSystemAutomation.Pages;
using CourseManagementSystemAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseManagementSystemAutomation.StepDefinitions
{
    [Binding]
    public class CourseSteps
    {
        Course course;
        DatabaseHelper databaseHelper;
        
        public CourseSteps(Course _course, DatabaseHelper _databaseHelper)
        {
            course = _course;
            databaseHelper = _databaseHelper;
        }

        [When(@"a user clicks on Course link from the menu")]
        public void WhenAUserClicksOnCourseLinkFromTheMenu()
        {
            databaseHelper.ClearTable("Course");
            course.CourseLink();
        }

        [When(@"a user clicks on Create New Course link")]
        public void WhenAUserClicksOnCreateNewCourseLink()
        {
            course.CreateNewCourseLink();
        }

        [When(@"a user inputs (.*) to a Course Number field")]
        public void WhenAUserInputsToACourseNumberField(string courseNumber)
        {
            course.CourseNumberField(courseNumber);
        }

        [When(@"a user fill-in Title field with (.*)")]
        public void WhenAUserFill_InTitleFieldWithTestAutomation(string courseName)
        {
            course.TitleField(courseName);
        }

        [When(@"a user fill-in (.*) in Credit field")]
        public void WhenAUserFill_InInCreditField(string credit)
        {
            course.CreditsField(credit);
        }

        [When(@"a user selects (.*) from Department drop down menu")]
        public void WhenAUserSelectsGeographyFromDepartmentDropDownMenu(string subject)
        {
            course.DepartmentMenu(subject);
        }

        [When(@"a user clicks on create new course button")]
        public void WhenAUserClicksOnCreateNewCourseButton()
        {
            course.CreateCourseButton();
        }

        [Then(@"a new course record (.*) should be created")]
        public void ThenANewCourseRecordTestAutomationShouldBeCreated(string expectedResult)
        {
            string actualResult = course.CourseResultPageTable();
            Assert.IsTrue(expectedResult.Equals(actualResult), "Expected result " + expectedResult + " is different from the actual result " + actualResult);
        }

    }
}

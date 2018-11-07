using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using TaskManagementApiAutomation.Hooks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskManagementApiAutomation.Model;
using Newtonsoft.Json;
using System.IO;

namespace TaskManagementApiAutomation.StepDefinitions
{
    [Binding]
    public class ProjectSteps
    {
        Context context;
        DatabaseHelper databaseHelper;
        public ProjectSteps(Context _context, DatabaseHelper _databaseHelper)
        {
            context = _context;
            databaseHelper = _databaseHelper;
        }

        [When(@"API service is up and running with GET endpoint (.*)")]
        public void GivenThatTaskManagementSystemAPIServiceIsUpAndRunning(string resource)
        {
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateMultipleRecordsToProjectTable();
            context.GetRequest(resource);
        }        

        [Then(@"the status code for GET call is equal to (.*)")]
        public void ThenTheStatusCodeForGETCallIsEqualToOK(string expectedResult)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedResult));            
        }

        [Then(@"the response description for GET call is equal to (.*)")]
        public void ThenTheResponseDescriptionForGETCallIsEqualToOK(string expectedResult)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResult));
        }

        [Then(@"the following records should be retrieved")]
        public void ThenTheFollowingRecordsShouldBeRetrieved(Table table)
        {
            var expectedResult = table.CreateSet<ProjectModel>();
            string actualAPIContent = context.actualContent;  //it comes in form of Json data structure
            var actualResult = JsonConvert.DeserializeObject<List<ProjectModel>>(actualAPIContent);
            Assert.IsTrue(CompareTwoList(expectedResult, actualResult));            
        }

        public bool CompareTwoList(object firstList, object secondList)
        {
            var objectOne = JsonConvert.SerializeObject(firstList);
            var objectTwo = JsonConvert.SerializeObject(secondList);
            return objectOne == objectTwo;
        }

        [Then(@"the status code for POST call is equal to (.*)")]
        public void ThenTheStatusCodeForPOSTCallIsEqualToCreated(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for POST call is equal to (.*)")]
        public void ThenTheResponseDescriptionForPOSTCallIsEqualToCreated(string expectedResponseDescription)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));
        }   

        [Then(@"the status code for PUT call is equal to (.*)")]
        public void ThenTheStatusCodeForPUTCallIsEqualToNoContent(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for PUT call is equal to (.*)")]
        public void ThenTheResponseDescriptionForPUTCallIsEqualToNoContent(string expectedResponseDescription)
        {
            //string actualResponseDescription = context.actualResponseDescription;
            //Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));

            Assert.IsTrue(context.actualResponseDescription.Equals(expectedResponseDescription));
        }      

        [Then(@"the status code for DELETE call is equal to (.*)")]
        public void ThenTheStatusCodeForDELETECallIsEqualToOK(string expectedStatusCode)
        {
            string actualStatusCode = context.actualStatusCode;
            Assert.IsTrue(actualStatusCode.Equals(expectedStatusCode));
        }

        [Then(@"the response description for DELETE call is equal to (.*)")]
        public void ThenTheResponseDescriptionForDELETECallIsEqualToOK(string expectedResponseDescription)
        {
            string actualResponseDescription = context.actualResponseDescription;
            Assert.IsTrue(actualResponseDescription.Equals(expectedResponseDescription));
        }

        //[When(@"API service is up and running with POST endpoint (.*)")]
        //public void WhenAPIServiceIsUpAndRunningWithPOSTEndpointProjects(string resource)
        //{
        //    databaseHelper.ClearTable("Projects");
        //    context.PostRequest(resource, File.ReadAllText(@"PostToProject.json").Replace(@"\", ""));
        //}

        [When(@"API service is up and running with POST endpoint (.*)")]
        public void WhenAPIServiceIsUpAndRunningWithPOSTEndpointProjects(string resource)
        {
            Dictionary<string, string> dataToPost = new Dictionary<string, string>();
            dataToPost.Add("Name", "Load Testing");
            databaseHelper.ClearTable("Projects");
            context.PostRequest(resource, dataToPost);
        }

        [When(@"API service is up and running with PUT endpoint (.*)")]
        public void WhenAPIServiceIsUpAndRunningWithPUTEndpointProjects(string resource)
        {            
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateOneRecordToProjectTable();
            int id = databaseHelper.SelectARecordFromProjectTable();
            // retrieve newly created record ID and append it to the resource
            Dictionary<string, string> dataToPut = new Dictionary<string, string>();
            dataToPut.Add("Id", id.ToString());
            dataToPut.Add("Name", "Performance Testing");
            string resourceWithId = resource + "/" + id;
            context.PutRequest(resourceWithId, dataToPut);
        }

        [When(@"API service is up and running with DELETE endpoint (.*)")]
        public void WhenAPIServiceIsUpAndRunningWithDELETEEndpointProjects(string resource)
        {
            databaseHelper.ClearTable("Projects");
            databaseHelper.PopulateOneRecordToProjectTable();
            int id = databaseHelper.SelectARecordFromProjectTable();
            // retrieve newly created record ID and append it to the resource            
            string resourceWithId = resource + "/" + id;
            context.DeleteRequest(resourceWithId);
        }


    }
}

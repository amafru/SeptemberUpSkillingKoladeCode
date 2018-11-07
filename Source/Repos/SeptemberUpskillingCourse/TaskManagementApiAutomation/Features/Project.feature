Feature: Project	

Scenario: API_Project_01_Verify that existing project records can be retrieved from the database
	When API service is up and running with GET endpoint /Projects
	Then the status code for GET call is equal to OK
	And the response description for GET call is equal to OK
	And the following records should be retrieved 
	| Name            |
	| Test Automation |
	| Manual Testing  |
	| Unit Testing    |
	| API Testing     |

Scenario: API_Project_02_Verify that a new project record can be created to the database	
	When API service is up and running with POST endpoint /Projects
	Then the status code for POST call is equal to Created
	And the response description for POST call is equal to Created

Scenario: API_Project_03_Verify that an existing project record can be modified
	When API service is up and running with PUT endpoint /Projects
	Then the status code for PUT call is equal to NoContent
	And the response description for PUT call is equal to No Content

Scenario: API_Project_04_Verify that an existing project record can be deleted	
	When API service is up and running with DELETE endpoint /Projects
	Then the status code for DELETE call is equal to OK
	And the response description for DELETE call is equal to OK
Feature: Course
	
Scenario: Course_01_Verify that a user can create a new Course record
	Given that Course Management System is loaded
	When a user clicks on Course link from the menu
	And a user clicks on Create New Course link
	And a user inputs 3 to a Course Number field
	And a user fill-in Title field with Test Automation
	And a user fill-in 4 in Credit field
	And a user selects Geography from Department drop down menu
	And a user clicks on create new course button
	Then a new course record Test Automation should be created	
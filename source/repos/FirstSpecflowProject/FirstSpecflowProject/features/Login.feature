Feature: Login
	We will login Student management system 

@mytag
Scenario: login to Student management system as a admin
	Given I have entererd user name as 'admin'
	And I have entererd password as 'admin'
	When I click on login button
	Then I should be login successfully

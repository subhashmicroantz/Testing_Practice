Feature: Student Management System 


@mytag
Scenario: Admin Login to Student Management System Unsuccessfully
	Given I have entered username as "abc"
	And I have entered password as "abc"
	When I press submit button
	Then Im unable to login successfully


@mytag
Scenario: Admin Login to Student Management System Successfully
    Given I have entered username as "admin"
	And I have entered password as "admin"
	When I press submit button
	Then I Can able to login successfully

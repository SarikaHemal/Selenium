Feature: TMFeature
	As turn up protal i would like to time and material page


@tm @automate
Scenario: Turn Up portal admin should be able to create a time and material record
	Given I have login into time and material page
	And I have navigate to the time and material page
	Then I should create time and material page successfully

@tm @automate
Scenario: Turn Up portal admin should delete a time and material record
	Given I have login into time and material page
	And I have navigate to the time and material page
	Then I should be able to delete a time and material record.

@tm @automate
Scenario: Admin should be able to edit a time and material record
	Given I have login into time and material page
	And I have navigate to the time and material page
	Then I should be able to edit a time and material record.

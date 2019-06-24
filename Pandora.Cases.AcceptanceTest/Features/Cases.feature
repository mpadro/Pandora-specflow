Feature: Cases
	In order to verify the cases endpoint
	I want to create, update and modify cases

Scenario: Get existing case
	Given I have a case for user 'tester'
	When I get the case
	Then The case information is retrieved

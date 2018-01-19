Feature: CreateBlog
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: AuthenticatedUser create Blog
	Given I m an Authenticated User
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

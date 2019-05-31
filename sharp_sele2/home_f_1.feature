Feature: home_f_1
	Test home page menu

@mytag
Scenario Outline: Click home menus
	Given I am on home page
	And I click on menu <menu>
	Then I should see menu conains <text>

	Examples: 
	| menu            | text                                  |
	| Aged Care Homes | Find your nearest Bupa Aged Care home |
	| Dental          | Find a Bupa owned dental clinic       |

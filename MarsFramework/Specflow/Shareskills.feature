Feature: Shareskills
	Adding skills in the listing for sharing

@Shareskills
Scenario: Sharing Skills
	Given I have logged in and i try to add skill 
	When I try to add and share skill in the listing
	Then Skill dhould gets added in the listings for sharing
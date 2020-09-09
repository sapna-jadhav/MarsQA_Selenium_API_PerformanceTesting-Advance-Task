Feature: SearchSkills
	When i try to search Skills, the skills which i am searching for get displayed in the list.

@SearchSkills
Scenario: Searching for the particular skill
	Given I have logged in and I Enter Keyword in the search
	When I try to search for the desired skills applying filter
	Then The desired skills get listed on the page
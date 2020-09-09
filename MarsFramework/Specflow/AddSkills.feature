Feature: AddEditDeleteSkills
	I have loged in with given credentials and try to add/Edit/Delete Skill Details

@AddEditDeleteSkills
Scenario: Adding new Skill Details
	Given I  logged in with valid credentials and navigate to profile page
	When I try to add Skill Details
	Then A Skill Details gets added Successfully


	Scenario: Edit Seller Skill Details
	
	When I try to Edit Skill Details
	Then  Skill Details gets Updated Successfully

	Scenario: Deleting Skill Details
	
	When I try to delete Skill Details
	Then Skill Details gets deleted successfully
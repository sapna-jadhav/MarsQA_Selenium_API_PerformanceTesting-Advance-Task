Feature: AddEditDeleteCertificate
	I have loged in with given credentials and try to add/Edit/Delete Certificate Details

@AddEditDeleteCertificate
Scenario: Adding new Certificate Details
	Given I  logged in with valid credentials 
	When I try to add Certificate Details
	Then A Certificate Details gets added Successfully

	Scenario: Edit Seller Certificate Details
	When I try to Edit Certificate Details
	Then  Certificate Details gets Updated Successfully

	Scenario: Deleting Certificate Details
	When I try to delete Certificate Details
	Then Certificate Details gets deleted successfully
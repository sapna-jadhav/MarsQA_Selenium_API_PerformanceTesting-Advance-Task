Feature: ManageListings
	Editing and Deleting Listings

@mytag
Scenario: Edit Skills on the Manage Listing page
	Given I logged in with valid Credentials
	When I try to Edit Skill on the manage Listing Page
	Then The Skill get Updated Successfully

	Scenario:Delete Skills on the Manage Listing page
	When I try to Delete Skill on the manage Listing Page
	Then The Skill get Deleted Successfully
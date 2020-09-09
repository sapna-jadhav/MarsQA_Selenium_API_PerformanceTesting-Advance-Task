Feature: Profile
	Adding and updating location,Earn target,availability,Hours

@Profile
Scenario: Adding and editing Profile
	Given I logge in and i am on the profile page
	When I try to Updated Profile
	Then The Profile details get Updated
Feature: Login
@mytag
Scenario: Launch
	Given I Called Application URL
	Then Application Should be Launched
@mytag
Scenario: Login
	Given I have Application Opened
	When I Enter User Credentials
	Then I Could able to Login To the Application
@mytag
Scenario: Logut
	Given I Called Logut
	Then Application Should be LoggedOut
@mytag
Scenario: Close
	Given I have Close Application
	Then  Application should be Closed



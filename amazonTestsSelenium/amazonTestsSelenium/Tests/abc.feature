Feature:  abc
	Checking logging capabilities

@fast
Scenario: Logging scenarios

Given existing user name
When Go to login page and fill the login form using existing user
Then The user is logged in

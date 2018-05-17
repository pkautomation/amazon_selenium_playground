Feature:  logging in
	Checking logging capabilities

Scenario: Logging scenario

Given existing user name
When Go to login page and fill the login form using existing user
Then The user is logged in

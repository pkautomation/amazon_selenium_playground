Feature: MainPageTests

Scenario: Searching for something

Given Main page is opened
When I enter the phrase "abcdefghijklmnopqrstuvwxyz"
Then I can see "ABCDEFGHIJKLMNOPQRSTUVWXYZ" Notebook on the list

Scenario: Checking if basket is empty
Given Main page is opened
When I click basket button
Then I get an empty basket message

Scenario: Check redirection to Amazon Music Unlimited Offer
Given Main page is opened
When I click link to Amazon Music Unlimited from the dropdown
Then I will be at the offer page
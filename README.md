# amazon_selenium_playground
E2E tests in Selenium with c# and Specflow.

# Important notes
Selenium tests require geckodriver or chromedriver to be in valid directory.
My piece of code require to fill up the user name and password for testing purposes.
I STRONGLY ADVICE TO CREATE FAKE TEST ACCOUNT IF YOU WANT TO RUN SOME TESTS, NEVER USE YOUR PERSONAL AMAZON ACCOUNT!

Please remember to pass during instatiation of a webdriver for example :
driver = new FirefoxDriver("./");

# Obstructions
I got surprised by breaking changes in the Selenium. They made many of the Selenium tutorials outdated:
- Page Objects are created using anonymous functions 
- wait methods have different notation
- IWebDriver interface is no longer used

For more information read the changelog, especially for v3.11.0
https://github.com/SeleniumHQ/selenium/blob/master/dotnet/CHANGELOG

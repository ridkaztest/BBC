Feature: Chorley

Navigate to BBC site and search for Chorley

@tag1
Scenario: Verify user can search for Chorley on BBC site
	Given I navigate to BBC news Url "https://www.bbc.co.uk/news"
	And I click on search BBC icon 
	And I enter "Chorley" in the search icon
	When I click on search button
	Then I should see the search results
	And I should see a list of articles containing "Chorley" in the first five of the results displayed
	
	
	
Scenario: Verify user can read articles on Israel-Gaza war
	Given I navigate to BBC news Url "https://www.bbc.co.uk/news"
	And I click on "Israel-Gaza War" icon under news section
	When I scroll down to the Analysis section
	And I click on "Has Israel's invasion of Gaza begun"
	Then I should be able to see the article 






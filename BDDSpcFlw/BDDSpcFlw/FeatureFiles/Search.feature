Feature: Search
	
@mytag
Scenario: Search with Testing
	Given Launch Firefox
	And Navigate to Code Project
	When Click on Search Our Articles
	When Enter Testing
	And Click on Seach Button
	Then Results should be visible and browser should close
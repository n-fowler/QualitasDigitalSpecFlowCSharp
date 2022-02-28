Feature: Home

The Home page of the Qualitas website

@QualitasHomeLoad
Scenario: [Home - Load]
	Given [The Home Page is being visited]
	When [The Home Page is visited]
	Then [The Home Logo is present]

@QualitasHomeNavigation
Scenario: [Home - Navigation]
	Given [The Home Page is being visited]
	When [The Home Page is visited]
	Then [The Home Navigation is present]

@QualitasHomeSearch
Scenario: [Home - Search]
	Given [The Home Page is being visited]
	When [The Home Page is visited]
	Then [The Home Search is present]

@QualitasHomeContent
Scenario: [Home - Content]
	Given [The Home Page is being visited]
	When [The Home Page is visited]
	Then [The Home Content is present]

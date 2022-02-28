Feature: AboutUs

The About Us page of the Qualitas website

@QualitasAboutUsLoad
Scenario: [About Us - Load]
	Given [The About Us Page is being visited]
	When [The About Us Page is visited]
	Then [The About Us Logo is present]

@QualitasAboutUsContent
Scenario: [About Us - Content]
	Given [The About Us Page is being visited]
	When [The About Us Page is visited]
	Then [The About Us Content is present]

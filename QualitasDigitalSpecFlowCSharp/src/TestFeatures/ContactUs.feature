Feature: ContactUs

The Contact Us page of the Qualitas website

@QualitasContactUsLoad
Scenario: [Contact Us - Load]
	Given [The Contact Us Page is being visited]
	When [The Contact Us Page is visited]
	Then [The Contact Us Logo is present]

@QualitasContactUsContent
Scenario: [Contact Us - Content]
	Given [The Contact Us Page is being visited]
	When [The Contact Us Page is visited]
	Then [The Contact Us Content is present]

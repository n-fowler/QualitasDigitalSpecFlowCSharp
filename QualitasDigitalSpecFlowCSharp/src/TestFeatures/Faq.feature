Feature: Faq

The Faq page of the Qualitas website

@QualitasFaqLoad
Scenario: [Faq - Load]
	Given [The Faq Page is being visited]
	When [The Faq Page is visited]
	Then [The Faq Logo is present]

@QualitasFaqContent
Scenario: [Faq - Content]
	Given [The Faq Page is being visited]
	When [The Faq Page is visited]
	Then [The Faq Content is present]

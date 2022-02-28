Feature: NewsAndNotes

The News and Notes page of the Qualitas website

@QualitasNewsandNotesLoad
Scenario: [News and Notes - Load]
	Given [The News and Notes Page is being visited]
	When [The News and Notes Page is visited]
	Then [The News and Notes Logo is present]

@QualitasNewsandNotesContent
Scenario: [News and Notes - Content]
	Given [The News and Notes Page is being visited]
	When [The News and Notes Page is visited]
	Then [The News and Notes Content is present]

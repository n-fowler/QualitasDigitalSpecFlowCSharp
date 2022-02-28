Feature: PricingAndServices

The Pricing and Services page of the Qualitas website

@QualitasPricingAndServicesLoad
Scenario: [Pricing and Services - Load]
	Given [The Pricing and Services Page is being visited]
	When [The Pricing and Services Page is visited]
	Then [The Pricing and Services Logo is present]

@QualitasPricingAndServicesContent
Scenario: [Pricing and Services - Content]
	Given [The Pricing and Services Page is being visited]
	When [The Pricing and Services Page is visited]
	Then [The Pricing and Services Content is present]

Feature: Testimonials

The Testimonials page of the Qualitas website

@QualitasTestimonialsLoad
Scenario: [Testimonials - Load]
	Given [The Testimonials Page is being visited]
	When [The Testimonials Page is visited]
	Then [The Testimonials Logo is present]

@QualitasTestimonialsContent
Scenario: [Testimonials - Content]
	Given [The Testimonials Page is being visited]
	When [The Testimonials Page is visited]
	Then [The Testimonials Content is present]

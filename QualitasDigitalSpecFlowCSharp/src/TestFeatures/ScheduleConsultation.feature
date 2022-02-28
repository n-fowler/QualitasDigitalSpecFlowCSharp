Feature: ScheduleConsultation

The Schedule Consultation page of the Qualitas website

@QualitasScheduleConsultationLoad
Scenario: [Schedule Consultation - Load]
	Given [The Schedule Consultation Page is being visited]
	When [The Schedule Consultation Page is visited]
	Then [The Schedule Consultation Logo is present]

@QualitasScheduleConsultationContent
Scenario: [Pricing and Services - Content]
	Given [The Schedule Consultation Page is being visited]
	When [The Schedule Consultation Page is visited]
	Then [The Schedule Consultation Content is present]

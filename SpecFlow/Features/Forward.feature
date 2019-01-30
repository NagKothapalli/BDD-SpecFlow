Feature: Forward
@Regression
Scenario: ForwardAnEmail Without Attachment
	Given I Navigated to Inbox
	When I Forward An Mail WithoutAttachment
	Then I Could see the sent mesage
@Regression
Scenario: ForwardAnEmail With Attachment
	Given I Navigated to Inbox
	When I Forward An Mail WithAttachment
	Then I Could see the sent mesage
Feature: Forward
@Regression @Smoke
Scenario: ForwardAnEmail Without Attachment
	Given I Navigated to Inbox
	And I Saw The Inbox
	When I Forward An Mail WithoutAttachment
	And I Saw it is correct
	Then I Could see the sent mesage
	And I Saw that it Sent
@Regression @Smoke
Scenario: ForwardAnEmail With Attachment
	Given I Navigated to Inbox
	When I Forward An Mail WithAttachment
	Then I Could see the sent mesage
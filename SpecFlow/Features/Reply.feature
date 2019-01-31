Feature: Reply
@Regression
Scenario: ReplyToAnEmail Without Attachment
	Given I Navigated to Inbox
	When I Reply To An Mail Without Attachment
	Then I Could see the sent mesage
@Regression
Scenario: ReplyToAnEmail With Attachment
	Given I Navigated to Inbox
	When I Reply To An Email With Attachment
	Then I Could see the sent mesage
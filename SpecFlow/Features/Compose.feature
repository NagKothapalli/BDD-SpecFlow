Feature: Compose
@Smoke
Scenario: ComposeAndSendAnEmail Without Attachment
	Given I Navigated to Inbox
	When I Compose And Send Mail Without Attachment
	Then I Could see the sent mesage
@Smoke
Scenario: ComposeAndSendAnEmail With Attachment
	Given I Navigated to Inbox
	When I Compose And Send Mail With Attachment
	Then I Could see the sent mesage
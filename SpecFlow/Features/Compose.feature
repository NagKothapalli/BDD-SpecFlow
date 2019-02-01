Feature: Compose
I Want to Check Scenarios with parameters and examples
@Smoke @Regression
Scenario: ComposeAndSendAnEmail Without Attachment
	Given I Navigated to Inbox
	When I Compose And Send Mail Without Attachment
	Then I Could see the sent mesage
@Smoke @Regression
Scenario: ComposeAndSendAnEmail With Attachment
	Given I Navigated to Inbox
	When I Compose And Send Mail With Attachment
	Then I Could see the sent mesage
@Parameter
Scenario:ParameterizedLogin
I Want to Test Scenario With Parameterization
Given I Launched Application 'https://gmail.com'
When I Enter UserName 'nag022'
And I Enter PassWord'mar1234'
Then I Should Login
@Example
Scenario Outline: DataDrivenLogin
I Want to check scenario with Examples for Data Driven
Given I Called The '<URL>'
When I Enter The UserName '<User>'
And I Enter The PassWord '<PassWord>'
Examples: 
| URL                  | User   | PassWord |
| https://google.co.in | nag022 | mar1234  |
| https://google.com   | nag025 | mar5678  |

#@Example
#Scenario Outline: DataDrivenLogin2
#Given I Called The "<URL>"
#When I Enter The UserName "<User>"
#And I Enter The PassWord "<PassWord>"
#Examples: 
#| URL                  | User   | PassWord |
#| https://google.co.in | nag022 | mar1234  |
#| https://google.com   | nag025 | mar5678  |
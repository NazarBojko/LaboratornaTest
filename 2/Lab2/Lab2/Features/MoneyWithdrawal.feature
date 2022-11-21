@setup_feature
Feature: MoneyWithdrawal

Scenario: Withdrawal of certain amount of money
	Given open the XYZ Bank page
	When click on the Customer Login button
	And select the Customer Name 
	And click on the Login button
	And click on the Withdrawl button
	And enter an amount to be Withdrawn 
	And click on the Withdraw button
	Then the result should be a successful withdrawal

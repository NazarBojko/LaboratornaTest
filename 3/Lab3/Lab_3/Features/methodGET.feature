@setup_feature
Feature: methodGET

Scenario: Testing the GET method 
	When make GetBookingIds request to the server
	Then the result of GetBookingIds request should be success

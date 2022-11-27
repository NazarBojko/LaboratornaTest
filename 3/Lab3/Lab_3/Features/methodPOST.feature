Feature: methodPOST

A short summary of the feature

@tag1
Scenario: Testing the POST method 
	When make CreateBooking request to the server
	Then the result of CreateBooking request should be success
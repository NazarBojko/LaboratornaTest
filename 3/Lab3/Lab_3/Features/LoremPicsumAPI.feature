Feature: LoremPicsumAPI

A short summary of the feature

@tag1
Scenario: Lorem Picsum API testing
	Given open Lorem Picsum website
	When make randomImageGet request to the server 
	When make listImagesGet request to the server 
	Then the results should be success

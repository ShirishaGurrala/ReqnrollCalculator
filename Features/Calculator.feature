@regression @calculator
Feature: Calculator

Simple calculator for adding two numbers


Scenario: Add two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are added
	Then the result should be 120

Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 10
	When the two numbers are subtracted
	Then the result should be 60

Scenario: Multiply two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are multiplied
	Then the result should be 3500

Scenario: Division two numbers
	Given the first number is 70
	And the second number is 10
	When the two numbers are divided
	Then the result should be 7

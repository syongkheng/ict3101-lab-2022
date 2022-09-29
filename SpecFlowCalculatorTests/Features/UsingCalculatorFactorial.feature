Feature: UsingCalculatorFactorial
	Simple calculator for calculating factorial

@Factorial
Scenario: Calculate Factorial
	Given I have a bad calculator
	When I have entered 5 into the calculator and press factorial
	Then the factorial result should be 120
	
@Factorial
Scenario: Calculate Zero Factorial
	Given I have a bad calculator
	When I have entered 0 into the calculator and press factorial
	Then the factorial result should be 1
	
@Factorial
Scenario: Calculate Negative Factorial
	Given I have a bad calculator
	When I have entered -1 into the calculator and press factorial
	Then the result should be negative_infinity
	
@Factorial
Scenario: Calculate Decimal Factorial
	Given I have a bad calculator
	When I have entered 1.2 into the calculator and press factorial
	Then the result should be positive_infinity
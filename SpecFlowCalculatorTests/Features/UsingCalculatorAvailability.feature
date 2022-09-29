Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability
	As someone who struggles with math
	I want to be able to use my calculator to do this
	
	
@Availability
Scenario: Calculating MTBF
	Given I is a calculator
	When I have entered 10 and 20 into the calculator and press Mtbf
	Then the availability result should be 30
	
@Availability
Scenario: Calculating MTBF double
	Given I is a calculator
	When I have entered 10.2 and 20.5 into the calculator and press Mtbf
	Then the availability result should be 30.7

@Availability
Scenario: Calculating MTBF negative time1
	Given I is a calculator
	When I have entered -10 and 30 into the calculator and press Mtbf
	Then the availability result should be positive_infinity
	
@Availability
Scenario: Calculating MTBF negative time2
	Given I is a calculator
	When I have entered 10.0 and -30.0 into the calculator and press Mtbf
	Then the availability result should be positive_infinity
	
@Availability
Scenario: Calculating Availability
	Given I is a calculator
	When I have entered 10 and 30 into the calculator and press Availability
	Then the availability result should be 0.75
	
@Availability
Scenario: Calculating Availability double
	Given I is a calculator
	When I have entered 10.0 and 30.0 into the calculator and press Availability
	Then the availability result should be 0.75
	
@Availability
Scenario: Calculating Availability negative time1
	Given I is a calculator
	When I have entered -10.0 and 30.0 into the calculator and press Availability
	Then the availability result should be positive_infinity

@Availability
Scenario: Calculating Availability negative time2
	Given I is a calculator
	When I have entered 10.0 and -30.0 into the calculator and press Availability
	Then the availability result should be positive_infinity
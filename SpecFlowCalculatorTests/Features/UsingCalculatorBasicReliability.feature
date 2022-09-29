Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this
	
# Current Failure Intensity = Initial Failure Intensity * ( 1 - (Average number of failure / Failure in Infinite time))
	
#Average number of failure at time t = Failure in Infinite Time ( 1 - e^(-Initial failure intensity/ Failure in InfiniteTime)(time))

@Reliability
Scenario: Calculate Average number of failure at time
	Given I are a calculator
	When FInf is 100 and FIntensity is 10 and Time is 10
	Then the reliability result should be 63	

@Reliability
Scenario: Calculate Average number of failure at time weird1
	Given I are a calculator
	When FInf is -100 and FIntensity is 10 and Time is 10
	Then the reliability result should be positive_infinity	
	
@Reliability
Scenario: Calculate Average number of failure at time weird2
	Given I are a calculator
	When FInf is 100 and FIntensity is -10 and Time is 10
	Then the reliability result should be positive_infinity	
	
@Reliability
Scenario: Calculate Average number of failure at time weird3
	Given I are a calculator
	When FInf is 100 and FIntensity is 10 and Time is -10
	Then the reliability result should be positive_infinity	

@Reliability
Scenario: Calculate Current Failure Intensity
	Given I are a calculator
	When FIntensity is 33 and FAvg is 150 and FInf is 450
	Then the reliability result should be 22
	
@Reliability
Scenario: Calculate Current Failure Intensity Weird1
	Given I are a calculator
	When FIntensity is -33 and FAvg is 150 and FInf is 450
	Then the reliability result should be positive_infinity
	
@Reliability
Scenario: Calculate Current Failure Intensity Weird2
	Given I are a calculator
	When FIntensity is 33 and FAvg is -150 and FInf is 450
	Then the reliability result should be positive_infinity

@Reliability
Scenario: Calculate Current Failure Intensity Weird3
	Given I are a calculator
	When FIntensity is 33 and FAvg is 150 and FInf is -450
	Then the reliability result should be positive_infinity
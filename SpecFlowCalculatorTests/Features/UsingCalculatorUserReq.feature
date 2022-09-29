#Client Requirement:
#ICT3101 Lab_2.3 04/09/2022
#Client requirements:
#`A group of system quality engineers wish to customize the command line calculator program
#to perform quality metric calculations. The engineers need to calculate the defect density of a
#system. Furthermore, they require a custom calculation for the new total number of Shipped
#Source Instructions (SSI) in the second release of a system. The engineers also wish to be able
#to use the Musa Logarithmic model to calculate failure intensity and the number of expected
#failures, performing each of these using a single calculator command.`
#
## Epic Description
#Allow System Quality Engineers to customize the CLI Calculator program to calculate matrix prove that it is worth it for my boss to keep my job.
#
## User Story Examples
#As a System Quality Engineer,
#I want to be able to customise the CLI Calculator program,
#so that I can calculate various information about a system such as its defect density, SSI, and failure intensity/expected failure
#with Musa Logarithmic model.
#
#As a System Quality Engineer,
#I want to be able to determine the total number of Shipped Source Instructions,
#So that I can determine other information such as the defect density of the system.
#
###As a System Quality Engineer,
###I want to be able to calculate the defect density of a system,
###So that I can assess the change of defect density over the each system release iteration.
#
###As a System Quality Engineer,
###I want to be able to determine the defect density improvement,
###So that I can prove I am doing good in my job.
#
#As a System Quality Engineer,
#I want to be able to incorporate the Musa Logarithmic Model,
#So That I can calculate the failure intensity.
#
#As a System Quality Engineer,
#I want to be able to incorporate the Musa Logarithmic Model,
#So That I can calculate the expected failure.


Feature: UsingCalculatorUserReq
	Allow System Quality Engineer to perform stuff
	So he does not get fired

@CustomRequirement
Scenario: Calculate Defect Density
	Given I am custom calculator
	When kloc is 50 and defects is 200
	Then the custom result should be 4.0
	
@CustomRequirement
Scenario: Calculate Defect Density no bugs
	Given I am custom calculator
	When kloc is 50 and defects is 0
	Then the custom result should be 0.0
	
@CustomRequirement
Scenario: Calculate Defect Density no KLOC LOL
	Given I am custom calculator
	When kloc is 0 and defects is 1
	Then the custom result should be positive_infinity
	
@CustomRequirement
Scenario: Calculate Defect Density Change Positive
	Given I am custom calculator
	When old dd is 2 and new dd is 1.8 
	Then the custom result should be 0.1
	
@CustomRequirement
Scenario: Calculate Defect Density Change Negative
	Given I am custom calculator
	When old dd is 2 and new dd is 3
	Then the custom result should be -0.5
	
@CustomRequirement
Scenario: Calculate Defect Density Improvement No Improvement
	Given I am custom calculator
	When old dd is 2 and new dd is 2 
	Then the custom result should be 0.0
	
	
#Issues faced, need a strong foundation to determine the cases to be tested
#Such as what should be the defect density when defects is 0 and kloc is 0?
#change Is the dd 0 or infinity, since 0/0 is infinity but 0 system so no bug?
#
#
# Reuse THEN statement from other feature files.
#Test Test latest commit

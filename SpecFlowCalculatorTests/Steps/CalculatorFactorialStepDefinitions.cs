using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public class UsingCalculatorFactorialStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

    private Calculator _calc;
    private double _res;

    public UsingCalculatorFactorialStepDefinitions(Calculator calc)
    {
        this._calc = calc;
    }

    [Given("I have a bad calculator")]
    public void GivenIHaveABadCalculator()
    {

    }

    [When("I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(double p0)
    {
        _res = _calc.Factorial(p0, 0);
    }
    
    [Then("the factorial result should be (.*)")]
    public void ThenTheResultShouldBe(Decimal p0)
    {
        Assert.That(_res, Is.EqualTo(p0));
    }
    
    [Then("the result should be positive_infinity")]
    public void ThenTheResultShouldBePositive_Infinity()
    {
        Assert.That(_res, Is.EqualTo(Double.PositiveInfinity));
    }
    
    [Then("the result should be negative_infinity")]
    public void ThenTheResultShouldBeNegative_Infinity()
    {
        Assert.That(_res, Is.EqualTo(Double.NegativeInfinity));
    }
}
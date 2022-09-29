using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public class UsingCalculatorDivisionStepDefinitions
    {

        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorDivisionStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [Given(@"I am a calculator")]
        public void GivenIHaveACalculator()
        {
            
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            _result = _calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }


        [Then(@"the division result should be positive_infinity")]
        public void ThenTheDivisionResultShouldBePositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }

    }
}
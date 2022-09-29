using ICT3101_Caculator;
using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorAvailabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorAvailabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [Given(@"I is a calculator")]
        public void GivenIIsACalculator()
        {
            
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press Mtbf")]
        public void WhenIHaveEnteredAndIntoTheCalculatorMtbf(double p0, double p1)
        {
            _result = _calculator.AvailAdd(p0, p1);
        }
        
        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAvail(double p0, double p1)
        {
            double tempRes = _calculator.AvailAdd(p0, p1);
            _result = _calculator.DivideAvail(p1, tempRes);
        }

        [Then(@"the availability result should be (.*)")]
        public void ThenTheAvailabilityResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the availability result should be positive_infinity")]
        public void ThenTheAvailabilityResultShouldBePositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}
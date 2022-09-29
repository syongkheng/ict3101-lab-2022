using ICT3101_Caculator;
using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorBasicReliabilityStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorBasicReliabilityStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [Given(@"I are a calculator")]
        public void GivenIIsACalculator()
        {
            
        }
        [When(@"FIntensity is (.*) and FAvg is (.*) and FInf is (.*)")]
        public void WhenFIntensityIsAndFAvgIsAndFInfIs(double p0, double p1, double p2)
        {
            _result = _calculator.BasicReliabilityCfi(p0, p1, p2);
        }

        [When(@"FInf is (.*) and FIntensity is (.*) and Time is (.*)")]
        public void WhenFInfIsAndFIntensityIsAndTimeIs(double p0, double p1, double p2)
        {
            _result = _calculator.BasicReliabilityFailureAtTime(p0, p1, p2);
        }
        [Then(@"the reliability result should be (.*)")]
        public void ThenTheReliabilityResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the reliability result should be positive_infinity")]
        public void ThenTheReliabilityResultShouldBePositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
    }
}
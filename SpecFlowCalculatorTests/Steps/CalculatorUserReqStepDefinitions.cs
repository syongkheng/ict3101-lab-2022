using ICT3101_Caculator;
using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorUserReqStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorUserReqStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [Given(@"I am custom calculator")]
        public void GivenIAmCustomCalculator()
        {
            
        }
        [When(@"kloc is (.*) and defects is (.*)")]
        public void WhenKlocIsAndDefectsIs(double p0, double p1)
        {
            _result = _calculator.Divide(p1, p0);
        }
        
        [When(@"old dd is (.*) and new dd is (.*)")]
        public void WhenOldDdIsAndNewDdIs(double p0, double p1)
        {
            _result = _calculator.DefectDensityChange(p0, p1);
        }

        [Then(@"the custom result should be (.*)")]
        public void ThenTheCustomResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the custom result should be positive_infinity")]
        public void ThenTheCustomResultShouldBePositive_Infinity()
        {
            Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
        }
        
        [Then(@"the custom result should be negative_infinity")]
        public void ThenTheCustomResultShouldBeNegative_Infinity()
        {
            Assert.That(_result, Is.EqualTo(Double.NegativeInfinity));
        }
    }
}
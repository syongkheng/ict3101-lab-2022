using ICT3101_Caculator;
using NUnit.Framework;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private Calculator _calculator;
        private double _result;
        
        public UsingCalculatorStepDefinitions(Calculator calc)
        {
            this._calculator = calc;
        }
        
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            
        }
        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculator.Add(p0, p1);
        }
        
        [When(@"I have entered binary (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredBinaryAndIntoTheCalculator(String p0, String p1)
        {
            _result = _calculator.BinaryAdd(p0, p1);
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
using Lab01;
using Moq;

namespace ICT3101_Caculator.UnitTests;

public class AdditionalCalculatorTests
{
    private Calculator _calculator;
    private Mock<IFileReader> _mockFileReader;
    
    [SetUp]
    public void Setup()
    {
        _mockFileReader = new Mock<IFileReader>();
        _mockFileReader.Setup(fr =>
            fr.Read("MagicNumbers.txt")).Returns(new string[5]{"1","2","3","4","5"});
        _calculator = new Calculator();
    }
    
    [Test]
    [TestCase(0)]
    [TestCase(1)]
    [TestCase(2)]
    [TestCase(3)]
    [TestCase(4)]
    public void MockFileReader_WhenUsingThisMagicalFunction_ResultEqualSix(double p0)
    {
        Assert.That(() => _calculator.GenMagicNum(p0, _mockFileReader.Object),Is.EqualTo(p0 * 2 + 2));
    }
}
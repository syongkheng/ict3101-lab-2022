namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToDifference()
        {
            //Act
            double res = _calculator.Subtract(20, 10);
            //Asssert
            Assert.That(res, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToMultiplication()
        {
            double res = _calculator.Multiply(10, 10);
            Assert.That(res, Is.EqualTo(100));
        }

        [Test]
        public void Divide_WhenDividingTwoNumbers_ResultEqualToDivision()
        {
            double res = _calculator.Divide(10, 2);
            Assert.That(res, Is.EqualTo(5));
        }

        [Test]
        [TestCase(10,0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double num1, double num2)
        {
            Assert.That(() => _calculator.Divide(num1, num2), Is.EqualTo(Double.PositiveInfinity));
            
        }

        [Test]
        public void Factorial_WhenGivenANumberToFactorial_ResultEqualToTheMultiplicationFromItselfToOne()
        {
            //handle decimal input for factorial
            Assert.That(() => _calculator.Factorial(3,0), Is.EqualTo(6));
            Assert.That(() => _calculator.Factorial(-1, 0), Is.EqualTo(Double.NegativeInfinity));
            Assert.That(() => _calculator.Factorial(0, 0), Is.EqualTo(1));
        }

        //Unknown Function A

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        //Circle and Triangle test cases
        [Test]
        public void Triangle_WhenCalculatingAreaTriangle_ResultEqualHalfBaseHeight()
        {
            Assert.That(() => _calculator.Triangle(5,10), Is.EqualTo(25));
            Assert.That(() => _calculator.Triangle(5,20), Is.EqualTo(50));
        }
        
        [Test]
        [TestCase(0,5)]
        [TestCase(-1,5)]
        [TestCase(5,0)]
        [TestCase(5,-1)]
        public void Triangle_WhenCalculatingWeirdAreaTriangle_ResultThrowArgExcpt(double b, double h)
        {
            Assert.That(() => _calculator.Triangle(b,h), Throws.ArgumentException);
        }

        [Test]
        public void Circle_WhenCalculatingAreaCircle_ResultEqualPiRadiusRadius()
        {
            Assert.That(() => _calculator.Circle(10), Is.EqualTo(Math.PI * 10 * 10));
            Assert.That(() => _calculator.Circle(17), Is.EqualTo(Math.PI * 17 * 17));
            Assert.That(() => _calculator.Circle(20), Is.EqualTo(Math.PI * 20 * 20));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-7)]
        public void Circle_WhenCalculatingWeirdAreaCircle_ResultThrowArgExcpt(double r)
        {
            Assert.That(() => _calculator.Circle(r), Throws.ArgumentException);
        }

    }
}
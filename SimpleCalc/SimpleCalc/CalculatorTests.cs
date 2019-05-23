using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SimpleCalc
{
	[TestFixture]
	public class CalculatorTests
	{
        [Test]
        [TestCase(3.0, 10.0, 13.0)]
        [TestCase(-100.0, 1000.0, 900.0)]
        [TestCase(-0.14, 10.0, 9.86)]
        public void Add_AddingTwoNumbers_returnSum(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second };

            double _result = calc.Add();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        public void Add_CalculatorIsEmpty_return0()
        {
            var calc = new Calculator ();

            double result = calc.Add();

            Assert.That(result, Is.EqualTo(0.0));
        }
        
        [Test]
        [TestCase(30.0, 10.0, 20.0)]
        [TestCase(1345.0, 1.0, 1344.0)]
        [TestCase(0.369, 0.1, 0.269)]
        public void Subtract_SubstractTwonumbers_ReturnDifference(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second };

            double _result = calc.Subtract();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        [TestCase(3.0, 10.0, -7.0)]
        [TestCase(100.0, 1000.0, -900.0)]
        [TestCase(-0.14, 10.0, -10.14)]
        public void Subtract_SeondnumberIsBiggerThanFirst_ReturnNegativeDifference(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second};

            var _result = calc.Subtract();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        public void Subtract_CalculatorIsEmpty_return0()
        {
            var calc = new Calculator();

            double result = calc.Subtract();

            Assert.That(result, Is.EqualTo(0.0));
        }

        [Test]
        [TestCase(30.0, 10.0, 300.0)]
        [TestCase(1345.0, 1.0, 1345.0)]
        [TestCase(-0.369, 0.1, -0.0369)]
        public void Multiply_TwoNumbers_ReturnProduct(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second };

            double _result = calc.Multiply();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        public void Multiply_CalculatorIsEmpty_return0()
        {
            var calc = new Calculator();

            double result = calc.Multiply();

            Assert.That(result, Is.EqualTo(0.0));
        }

        [Test]
        [TestCase(0, 10.0, 0)]
        [TestCase(100.0, 0, 0.0)]
        [TestCase(-0.047, 0.0, 0.0)]
        public void Multiply_MyltiplyOnZero_return0(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second};

            double _result = calc.Multiply();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        [TestCase(30.0, 10.0, 3.0)]
        [TestCase(1345.0, 1.0, 1345.0)]
        [TestCase(-0.369, 0.1, -3.69)]
        [TestCase(0.0, 12.8, 0.0)]
        public void Divide_TwoNumbers_ReturnDivision(double first, double second, double result)
        {
            var calc = new Calculator { Number1 = first, Number2 = second };

            double _result = calc.Divide();

            Assert.That(_result, Is.EqualTo(result));
        }

        [Test]
        public void Divide_CalculatorIsEmpty_throwDivideByZeroException()
        {
            var calc = new Calculator();

            Assert.That( () => calc.Divide(), Throws.InstanceOf(typeof(DivideByZeroException)));
        }

        [Test]
        [TestCase(30.0, 0.0)]
        [TestCase(1345.0, 0.0)]
        [TestCase(-0.369, 0.0)]
        [TestCase(0.0, 0.0)]
        public void Divide_numberDivideBy0_throwDivideByZeroException(double first, double second)
        {
            var calc = new Calculator { Number1 = first, Number2 = second };     

            Assert.That( () => calc.Divide(), Throws.InstanceOf(typeof(DivideByZeroException)));
        }

    }
}

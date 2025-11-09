namespace Task2;

using Task2;
using NUnit.Framework;
using System;


[TestFixture]
public class CalculatorTests
{
    [TestCase(5, 3, "+", 8)]
    [TestCase(5, 3, "-", 2)]
    [TestCase(5, 3, "*", 15)]
    [TestCase(15, 3, "/", 5)]
    [TestCase(0, 5, "+", 5)]
    [TestCase(0, 5, "/", 0)]
    [TestCase(10, -2, "/", -5)]
    [TestCase(-5, 3, "+", -2)]
    [TestCase(5.5, 2.5, "+", 8)]
    [TestCase(1000000000, 2000000000, "+", 3000000000)]
    public void CalculatorTest(double a, double b, string operation, double expected)
    {
        var calculator = new Calculator(a, b, operation);
        Assert.That(calculator.GetResult(), Is.EqualTo(expected).Within(0.001));
    }


    [Test]
    public void DivisionByZeroTest()
    {
        var calculator = new Calculator(15, 0, "/");
        Assert.Throws<ArgumentException>(() => calculator.GetResult());
    }

    [Test]
    public void UnknownOperationTest()
    {
        var calculator = new Calculator(5, 3, "%");
        Assert.Throws<ArgumentException>(() => calculator.GetResult());
    }
}
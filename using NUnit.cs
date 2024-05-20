using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    [Test]
    public void TestAdd()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Add(5, 3);

        Assert.AreEqual(8, result);
    }

    [Test]
    public void TestSubtract()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Subtract(10, 4);

        Assert.AreEqual(6, result);
    }

    [Test]
    public void TestMultiply()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Multiply(7, 3);

        Assert.AreEqual(21, result);
    }

    [Test]
    public void TestDivide()
    {
        Calculator calculator = new Calculator();

        int result = calculator.Divide(15, 3);

        Assert.AreEqual(5, result);
    }

    [Test]
    public void TestDivide_ByZero()
    {
        Calculator calculator = new Calculator();

        Assert.Throws<ArgumentException>(() => calculator.Divide(10, 0));
    }
}

using System;
using Xunit;

namespace Calculator.Tests;
using MathCalculator;


public class UnitTest1
{
    [Fact]
    public void Sum_TwoPositiveNumbers_ReturnsCorrectResult()
    {
        Calculator calc = new Calculator();
        Assert.Equal(5, calc.Sum(2, 3));
    }

    [Fact]
    public void Sum_NegativeAndPositiveNumber_ReturnsCorrectResult()
    {
        Calculator calc = new Calculator();
        Assert.Equal(1, calc.Sum(-2, 3));
    }

    [Fact]
    public void Sum_TwoNegativeNumbers_ReturnsCorrectResult()
    {
        Calculator calc = new Calculator();
        Assert.Equal(-5, calc.Sum(-2, -3));
    }

    [Fact]
    public void Sum_WithZero_ReturnsSameNumber()
    {
        Calculator calc = new Calculator();
        Assert.Equal(7, calc.Sum(7, 0));
    }

    [Fact]
    public void Sum_Decimals_ReturnsCorrectResult()
    {
        Calculator calc = new Calculator();
        Assert.Equal(5.7, calc.Sum(2.2, 3.5), 1);
    }

    [Fact]
    public void Sum_LargeNumbers_ReturnsCorrectResult()
    {
        Calculator calc = new Calculator();
        Assert.Equal(1000000, calc.Sum(500000, 500000));
    }

    [Fact]
    public void Sum_DecimalEdgeCase_RoundsCorrectly()
    {
        Calculator calc = new Calculator();
        Assert.Equal(0.3, calc.Sum(0.1, 0.2), 1);
    }

    [Fact]
    public void Minus_NegativeResult_ReturnsCorrectValue()
    {
        Calculator calc = new Calculator();
        Assert.Equal(-1, calc.Minus(2, 3));
    }

    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        Calculator calc = new Calculator();
        Assert.Throws<DivideByZeroException>(() => calc.Divide(4, 0));
    }


    [Fact]
    public void Multiply_NegativeNumbers_ReturnsPositive()
    {
        Calculator calc = new Calculator();
        Assert.Equal(9, calc.Multiply(-3, -3));
    }

    [Fact]
    public void Sum_MaxDoubleValues_ThrowsOverflow()
    {
        Calculator calc = new Calculator();
        double max = double.MaxValue;

        double result = calc.Sum(max, max);
        Assert.True(double.IsInfinity(result)); // overflows to infinity
    }

    [Fact]
    public void Sum_SmallDecimals_PreciseEnough()
    {
        Calculator calc = new Calculator();
        double result = calc.Sum(0.0000001, 0.0000002);
        Assert.Equal(0.0000003, result, 7);
    }

    [Fact]
    public void Sum_InputNegativeAndDecimal_ReturnsCorrect()
    {
        Calculator calc = new Calculator();
        double result = calc.Sum(-1.5, 2.5);
        Assert.Equal(1.0, result);
    }
    
}
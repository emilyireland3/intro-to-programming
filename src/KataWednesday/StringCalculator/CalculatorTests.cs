

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("3", 3)]
    [InlineData("4", 4)]
    [InlineData("78", 78)]
    public void CanAddSingleInteger(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4", 7)]
    [InlineData("0,9", 9)]
    [InlineData("78,22", 100)]
    public void CanAddTwoIntegers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4,5", 12)]
    [InlineData("0,9,1,2,3", 15)]
    [InlineData("78,22,15,30,55", 200)]
    public void CanAddSeveralIntegers(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4,5\n6", 18)]
    [InlineData("0\n1,2,3", 6)]
    [InlineData("2\n3,2,3", 10)]
    [InlineData("78,22,15,30\n55", 200)]
    public void CanAddSeveralIntegersWNewLineAndComma(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

}

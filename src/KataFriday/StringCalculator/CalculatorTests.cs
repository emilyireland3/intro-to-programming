

namespace StringCalculator;
public class CalculatorTests
{
    Calculator calculator;

    public CalculatorTests()
    {
        // Tests treat each method as independent so need to
        // create a new instance of Calculator for each test
        // ... for each [Fact} or [Theory --> inline], a new instance
        // of this class is created and the constructor will be called again 
        calculator = new Calculator();
    }

    [Fact]
    public void EmptyStringReturnsZero()
    {

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Theory]
    [InlineData("3", 3)]
    [InlineData("4", 4)]
    [InlineData("78", 78)]
    public void CanAddSingleInteger(string value, int expected)
    {
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4", 7)]
    [InlineData("0,9", 9)]
    [InlineData("78,22", 100)]
    public void CanAddTwoIntegers(string value, int expected)
    {
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4,5", 12)]
    [InlineData("0,9,1,2,3", 15)]
    [InlineData("78,22,15,30,55", 200)]
    public void CanAddSeveralIntegers(string value, int expected)
    {
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
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,4,5\n6", 18)]
    [InlineData("0\n1,2,3", 6)]
    [InlineData("//#\n1#2#3", 6)]
    [InlineData("//;\n1;2,3\n24", 30)]
    public void CanAddSeveralIntegersWAnyDelimeter(string value, int expected)
    {
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("3,-1,5\n6", "Negatives not allowed")]
    [InlineData("//#\n1#-2#3", "Negatives not allowed")]
    [InlineData("//;\n-1;2;-3", "Negatives not allowed")]
    public void ThrowsExceptionForNegativeNumbers(string value, string expectedMessage)
    {
        var exception = Assert.Throws<ArgumentException>(() => calculator.Add(value));
        Assert.Equal(expectedMessage, exception.Message);
    }
}

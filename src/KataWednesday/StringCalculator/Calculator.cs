
using System.Diagnostics.Eventing.Reader;
using System.IO;

public class Calculator
{
    public int Add(string numbers)
    {
        if (numbers == "")
        {
            return 0;
        }

        numbers = numbers.Replace("\n", ","); // replace newline with string

        var nums = numbers.Split(","); // splits into array of substrings
        int sum = 0;

        foreach (var num in nums)
        {
            sum += int.Parse(num); // convert each substring to an integer and add it to the sum
        }

        return sum;
    }
}

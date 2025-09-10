
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

// int --> System.Int32
// string --> System.String

// cant use var outside of a method, it's only for local variables

// data type ex: string[] to declare array, can just use "var" -> interpreted by 
// the compiler as being used as an array
// .Select(int.Parse) --> like 'map'


// alternative implementation:
//return numbers
//    .Split(',', '\n') --> ["1", "2", "3"]
//    .Select(int.Parse) --> // [1, 2, 3] , so maps strings to ints 
//    .Sum();

// generics provide "parametric polymorphism"
// var numbers = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9}
// var onlyTheEvens = numbers.Where(n => n % 2 == 0);
// numbers[0] = 8; // lazy evaluation, "homoiconicity"
// Assert.Equal(4, onlyTheEvents.Count());


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

        if (numbers.Contains("//"))
        {
            var delimiter = numbers[2].ToString(); // extracts custom delimiter
            numbers = numbers.Substring(4); // removes the first 5 chars from string
            numbers = numbers.Replace(delimiter, ","); // // Replace the custom delimiter with a comma
        }

        numbers = numbers.Replace("\n", ","); // replace newline with comma

        var nums = numbers.Split(","); // splits into array of substrings
        int sum = 0;

        foreach (var num in nums)
        {

            int parsedNum = int.Parse(num); // converts the substring to an integer
            if (parsedNum < 0)
            {
                throw new ArgumentException("Negatives not allowed");
            }
            else
            {
                sum += parsedNum;
            }
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

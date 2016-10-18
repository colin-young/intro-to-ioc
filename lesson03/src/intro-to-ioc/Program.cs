using System;
using System.Collections.Generic;

namespace IntroToIoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzer();
            var inputs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            var results = fizzBuzz.FormatEntries(inputs);

            Console.WriteLine(results);

            var jsonFizzBuzzer = new JsonFizzBuzzer();
            var json = jsonFizzBuzzer.FormatEntries(inputs);
            Console.WriteLine($"Input: {inputs}, JSON: {json}");
        }
    }
}

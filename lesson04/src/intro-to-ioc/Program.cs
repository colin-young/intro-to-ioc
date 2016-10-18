using System;
using System.Collections.Generic;
using IntroToIoc.FizzBuzzCaseConverters;
using IntroToIoc.FizzBuzzStyleConverters;
using IntroToIoc.FizzBuzzers;
using IntroToIoc.FizzBuzzTesters;

namespace IntroToIoc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var inputs = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

            // configure our conversions
            IFizzBuzzCaseConverter consoleCaseConverter = new TitleCaseConverter();
            IFizzBuzzCaseConverter jsonCaseConverter = new LowerCaseConverter();
            IFizzBuzzStyleConverter concatenator = new ConcatenateConverter(consoleCaseConverter);
            IFizzBuzzStyleConverter arrayConverter = new ArrayConverter(jsonCaseConverter);
            IFizzBuzzTester consoleTester = new FizzBuzzTester(concatenator);
            IFizzBuzzTester jsonTester = new FizzBuzzTester(arrayConverter);

            var fizzBuzz = new ConsoleFizzBuzzer(consoleTester);

            // execute configured converter
            var results = fizzBuzz.FormatEntries(inputs);
            Console.WriteLine(results);

            var jsonFizzBuzzer = new JsonFizzBuzzer(jsonTester);
            var json = jsonFizzBuzzer.FormatEntries(inputs);
            Console.WriteLine($"Input: {inputs}, JSON: {json}");
        }
    }
}

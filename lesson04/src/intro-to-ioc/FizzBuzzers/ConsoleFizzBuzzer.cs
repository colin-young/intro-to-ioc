using System.Collections.Generic;
using IntroToIoc.FizzBuzzTesters;

namespace IntroToIoc.FizzBuzzers
{
    public class ConsoleFizzBuzzer : IFizzBuzzer
    {
        readonly IFizzBuzzTester _tester;

        public ConsoleFizzBuzzer(IFizzBuzzTester tester)
        {
            _tester = tester;
        }

        public string FormatEntries(List<int> entries)
        {
            var results = new List<string>();

            foreach (var input in entries)
            {
                results.Add($"Input: {input}, Output: {_tester.Convert(input)}");
            }

            return string.Join($"\n", results);
        }
    }
}

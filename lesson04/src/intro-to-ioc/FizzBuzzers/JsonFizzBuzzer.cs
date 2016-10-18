using System.Collections.Generic;
using IntroToIoc.FizzBuzzTesters;
using System.Linq;

namespace IntroToIoc
{
    public class JsonFizzBuzzer : IFizzBuzzer
    {
        readonly IFizzBuzzTester _tester;

        public JsonFizzBuzzer (IFizzBuzzTester tester)
        {
            _tester = tester;
        }
        public string FormatEntries(List<int> entries)
        {
            var result = "";

            // { [ {input: 1, output: "1"}, {input: 3, output: "buzz"}, { input: 15, output: ["fizz", "buzz"] } ] }
            var formattedEntries = new List<string>();

            foreach (var entry in entries)
            {
                var formattedEntry = _tester.Convert(entry);
                formattedEntries.Add($"{{input: {entry}, output: {formattedEntry}}}");
            }

            result = $"{{ [ {string.Join(",", formattedEntries)} ] }}";

            return result;
        }
    }
}
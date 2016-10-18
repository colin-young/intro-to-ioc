using System.Collections.Generic;
using System.Linq;
using System.Linq;

namespace IntroToIoc
{
    public class JsonFizzBuzzer : IFizzBuzzer
    {
        public string FormatEntries(List<int> entries)
        {
            var converter = new FizzBuzzConverter();
            var result = "";

            // { [ {input: 1, output: "1"}, {input: 3, output: "Buzz"}, { input: 15, output: "FizzBuzz" } ] }
            var formattedEntries = new List<string>();

            foreach (var entry in entries)
            {
                var formattedEntry = converter.Convert(entry);
                formattedEntries.Add($"{{input: {entry}, output: \"{formattedEntry}\"}}");
            }

            result = $"{{ [ {string.Join(",", formattedEntries)} ] }}";

            return result;
        }
    }
}
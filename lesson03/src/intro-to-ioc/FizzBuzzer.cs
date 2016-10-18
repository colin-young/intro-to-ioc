using System.Collections.Generic;

namespace IntroToIoc
{
    public class FizzBuzzer : IFizzBuzzer
    {
        public string FormatEntries(List<int> entries)
        {
            var converter = new FizzBuzzConverter();
            var results = new List<string>();

            foreach (var input in entries)
            {
                results.Add($"Input: {input}, Output: {converter.Convert(input)}");
            }

            return string.Join($"\n", results);
        }
    }
}

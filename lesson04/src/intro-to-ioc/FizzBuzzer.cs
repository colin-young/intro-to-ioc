using System.Collections.Generic;
using IntroToIoc.FizzBuzzers;

namespace IntroToIoc
{
    public class FizzBuzzer : IFizzBuzzer
    {
        readonly IFizzBuzzConverterStyle _styleConverter;

        public FizzBuzzer(IFizzBuzzConverterStyle styleConverter)
        {
            _styleConverter = styleConverter;
        }

        public string FormatEntries(List<int> entries)
        {
            var converter = new ConsoleFizzBuzzer(_styleConverter);
            var results = new List<string>();

            foreach (var input in entries)
            {
                results.Add($"Input: {input}, Output: {converter.Convert(input)}");
            }

            return string.Join($"\n", results);
        }
    }
}

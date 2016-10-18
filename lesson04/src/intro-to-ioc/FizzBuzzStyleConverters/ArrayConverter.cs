using IntroToIoc.FizzBuzzCaseConverters;

namespace IntroToIoc.FizzBuzzStyleConverters
{
    public class ArrayConverter : IFizzBuzzStyleConverter
    {
        readonly IFizzBuzzCaseConverter _caseConverter;

        public ArrayConverter (IFizzBuzzCaseConverter caseConverter)
        {
            _caseConverter = caseConverter;
        }

        public string Buzz => _caseConverter.Buzz;
        public string Fizz => _caseConverter.Fizz;

        public string FizzBuzz => $"[\"{_caseConverter.Fizz}\", \"{_caseConverter.Buzz}\"]";
    }
}

using IntroToIoc.FizzBuzzCaseConverters;

namespace IntroToIoc.FizzBuzzStyleConverters
{
    public class ConcatenateConverter : IFizzBuzzStyleConverter
    {
        readonly IFizzBuzzCaseConverter _caseConverter;
        
        public ConcatenateConverter (IFizzBuzzCaseConverter caseConverter)
        {
            _caseConverter = caseConverter;
        }
        
        public string Buzz => _caseConverter.Buzz;

        public string Fizz => _caseConverter.Fizz;

        public string FizzBuzz => $"{_caseConverter.Fizz}{_caseConverter.Buzz}";
    }
}

using IntroToIoc.FizzBuzzConverterCase;

namespace IntroToIoc.FizzBuzzConverterStyles
{
    public class ConcatenateFizzBuzzConverter : IFizzBuzzConverterStyle
    {
        readonly IFizzBuzzConverterCase _caseConverter;
        
        public ConcatenateFizzBuzzConverter (IFizzBuzzConverterCase caseConverter)
        {
            _caseConverter = caseConverter;
        }
        public string Buzz => _caseConverter.Buzz;

        public string Fizz => _caseConverter.Fizz;

        public string FizzBuzz => $"{_caseConverter.Fizz}{_caseConverter.Buzz}";
    }
}
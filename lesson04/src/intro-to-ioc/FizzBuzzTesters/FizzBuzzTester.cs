namespace IntroToIoc.FizzBuzzTesters
{
    public class FizzBuzzTester : IFizzBuzzTester
    {
        readonly IFizzBuzzStyleConverter _converterStyle;

        public FizzBuzzTester(IFizzBuzzStyleConverter converterStyle)
        {
            _converterStyle = converterStyle;
        }

        public string Convert(int input)
        {
            var result = input.ToString();

            if (input % 3 == 0)
            {
                result = _converterStyle.Fizz;
            }

            if (input % 5 == 0)
            {
                result = _converterStyle.Buzz;
            }

            if (input % 3 == 0 && input % 5 == 0)
            {
                result = _converterStyle.FizzBuzz;
            }

            return result;
        }
    }
}

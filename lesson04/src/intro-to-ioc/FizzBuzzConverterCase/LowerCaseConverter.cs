namespace IntroToIoc.FizzBuzzConverterCase
{
    public class LowerCaseConverter : IFizzBuzzConverterCase
    {
        public string Buzz => "fizz";

        public string Fizz => "buzz";
    }
}

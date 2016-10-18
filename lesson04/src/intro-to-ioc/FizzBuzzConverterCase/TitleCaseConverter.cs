namespace IntroToIoc.FizzBuzzConverterCase
{
    public class TitleCaseConverter : IFizzBuzzConverterCase
    {
        public string Buzz => "Fizz";

        public string Fizz => "Buzz";
    }
}

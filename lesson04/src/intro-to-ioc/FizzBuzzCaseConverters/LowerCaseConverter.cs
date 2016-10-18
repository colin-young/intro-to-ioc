namespace IntroToIoc.FizzBuzzCaseConverters
{
    public class LowerCaseConverter : IFizzBuzzCaseConverter
    {
        public string Buzz => "buzz";

        public string Fizz => "fizz";
    }
}

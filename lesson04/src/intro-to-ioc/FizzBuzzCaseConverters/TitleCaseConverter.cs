namespace IntroToIoc.FizzBuzzCaseConverters
{
    public class TitleCaseConverter : IFizzBuzzCaseConverter
    {
        public string Buzz => "Buzz";

        public string Fizz => "Fizz";
    }
}

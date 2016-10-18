namespace IntroToIoc
{
    public class FizzBuzzConverter
    {
        public string Convert(int input)
        {
            var result = input.ToString();

            if (input % 3 == 0)
            {
                result = "Fizz";
            }

            if (input % 5 == 0)
            {
                result = "Buzz";
            }

            if (input % 3 == 0 && input % 5 == 0)
            {
                result = "FizzBuzz";
            }

            return result;
        }
    }
}

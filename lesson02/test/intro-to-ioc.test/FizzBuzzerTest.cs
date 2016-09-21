using FluentAssertions;
using Xunit;

namespace intro_to_ioc
{
    public class FizzBuzzerTest
    {
        [Theory,
         InlineData(1, "1"),
         InlineData(13, "13"),
         InlineData(53, "53"),
         InlineData(3, "Fizz"),
         InlineData(9, "Fizz"),
         InlineData(5, "Buzz"),
         InlineData(25, "Buzz"),
         InlineData(15, "FizzBuzz"),
         InlineData(30, "FizzBuzz")
         ]
        public void NumberResultTest(int input, string expected)
        {
            // arrange
            var fizzBuzzer = new FizzBuzzer();

            // act
            var result = fizzBuzzer.FormatEntry(input);

            // assert
            result.Should().Be(expected);
        }
    }
}

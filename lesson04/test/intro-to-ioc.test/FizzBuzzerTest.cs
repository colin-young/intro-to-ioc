using System;
using System.Collections.Generic;
using FluentAssertions;
using IntroToIoc;
using IntroToIoc.FizzBuzzers;
using IntroToIoc.FizzBuzzCaseConverters;
using IntroToIoc.FizzBuzzStyleConverters;
using IntroToIoc.FizzBuzzTesters;
using Xunit;
using FakeItEasy;

namespace intro_to_ioc
{
    public class FizzBuzzerTest
    {
        [Theory,
         InlineData(typeof(ConsoleFizzBuzzer), new[] { 1, 3, 5, 15 }, "Input: 1, Output: 1"),
         InlineData(typeof(ConsoleFizzBuzzer), new[] { 1, 3, 5, 15 }, "Input: 3, Output: Fizz"),
         InlineData(typeof(ConsoleFizzBuzzer), new[] { 1, 3, 5, 15 }, "Input: 5, Output: Buzz"),
         InlineData(typeof(ConsoleFizzBuzzer), new[] { 1, 3, 5, 15 }, "Input: 15, Output: FizzBuzz"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 3, 5, 15 }, "{input: 1, output: 1}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 3, 5, 15 }, "{input: 3, output: Fizz}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 3, 5, 15 }, "{input: 5, output: Buzz}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 3, 5, 15 }, "{input: 15, output: FizzBuzz}")
        ]
        public void TesterTest(Type fizzBuzzerType, int[] inputArray, string output)
        {
            // arrange
            var tester = A.Fake<IFizzBuzzTester>();
            A.CallTo(() => tester.Convert(1)).Returns("1");
            A.CallTo(() => tester.Convert(3)).Returns("Fizz");
            A.CallTo(() => tester.Convert(5)).Returns("Buzz");
            A.CallTo(() => tester.Convert(15)).Returns("FizzBuzz");

            var fizzBuzzer = Activator.CreateInstance(fizzBuzzerType, tester) as IFizzBuzzer;
            var inputs = new List<int>(inputArray);

            // act
            var result = fizzBuzzer.FormatEntries(inputs);

            // assert
            result.Should().Contain(output);
        }

        [Theory,
         InlineData(typeof(ConcatenateConverter), "Fizz", "Buzz", "Fizz", "Buzz", "FizzBuzz"),
         InlineData(typeof(ConcatenateConverter), "fizz", "buzz", "fizz", "buzz", "fizzbuzz"),
         InlineData(typeof(ArrayConverter), "fizz", "buzz", "fizz", "buzz", "[\"fizz\", \"buzz\"]")
        ]
        public void StyleConverterTestVoid(Type converterType, string fizzCase, string buzzCase, string fizzExpect, string buzzExpect, string fizzBuzzExpect)
        {
            // arrange
            var caseConverter = A.Fake<IFizzBuzzCaseConverter>();
            A.CallTo(() => caseConverter.Fizz).Returns(fizzCase);
            A.CallTo(() => caseConverter.Buzz).Returns(buzzCase);

            var converter = Activator.CreateInstance(converterType, caseConverter) as IFizzBuzzStyleConverter;

            // act
            var fizzResult = converter.Fizz;
            var buzzResult = converter.Buzz;
            var fizzBuzzResult = converter.FizzBuzz;

            // assert
            fizzResult.Should().Be(fizzExpect);
            buzzResult.Should().Be(buzzExpect);
            fizzBuzzResult.Should().Be(fizzBuzzExpect);
        }

        [Theory,
        InlineData(typeof(LowerCaseConverter), "fizz", "buzz"),
        InlineData(typeof(TitleCaseConverter), "Fizz", "Buzz")]
        public void CaseConverterTest(Type converterType, string fizzValue, string buzzValue)
        {
            // arrange
            var converter = Activator.CreateInstance(converterType) as IFizzBuzzCaseConverter;

            // act
            var fizzResult = converter.Fizz;
            var buzzResult = converter.Buzz;

            // assert
            fizzResult.Should().Be(fizzValue);
            buzzResult.Should().Be(buzzValue);
        }
    }
}

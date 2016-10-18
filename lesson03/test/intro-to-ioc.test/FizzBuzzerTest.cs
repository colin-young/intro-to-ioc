using System;
using System.Collections.Generic;
using FluentAssertions;
using IntroToIoc;
using Xunit;

namespace intro_to_ioc
{
    public class FizzBuzzerTest
    {
        [Theory,
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 1, Output: 1"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 53, Output: 53"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 13, Output: 13"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 9, Output: Fizz"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 15, Output: FizzBuzz"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 25, Output: Buzz"),
         InlineData(typeof(FizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "Input: 30, Output: FizzBuzz"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 1, output: \"1\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 53, output: \"53\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 13, output: \"13\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 9, output: \"Fizz\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 15, output: \"FizzBuzz\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 25, output: \"Buzz\"}"),
         InlineData(typeof(JsonFizzBuzzer), new[] { 1, 13, 53, 3, 9, 5, 25, 15, 30 }, "{input: 30, output: \"FizzBuzz\"}")         
        ]
        public void NumberResultTest(Type fizzBuzzerObject, int[] inputArray, string output)
        {
            // arrange
            var fizzBuzzer = Activator.CreateInstance(fizzBuzzerObject) as IFizzBuzzer;
            var inputs = new List<int>(inputArray);

            // act
            var result = fizzBuzzer.FormatEntries(inputs);

            // assert
            result.Should().Contain(output);
        }
    }
}

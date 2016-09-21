using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzer();

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"Input: {i}, Output: {fizzBuzz.FormatEntry(i)}");
            }
        }
    }
}

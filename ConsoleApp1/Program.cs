using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Calculator calc = new Calculator();
            int result = calc.add(1, 7);
            Console.WriteLine("Result is:" + result);

            PatternMatcher patternMatcher = new PatternMatcher();
            Console.WriteLine("Basic: True is " + patternMatcher.basic(true));
            Console.WriteLine("Basic: False is " + patternMatcher.basic(false));
            Console.WriteLine("Basic: False with fallback is " + patternMatcher.basicWithCatchAll(false));

        }
    }

    internal class PatternMatcher
    {
        public string basic(bool a) => (a) switch
        {
            (true) => "correct",
            (false) => "incorrect"
        };

        public string basicWithCatchAll(bool a) => (a) switch
        {
            (true) => "correct",
            (_) => "incorrect"
        };
    }
    
    internal class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}

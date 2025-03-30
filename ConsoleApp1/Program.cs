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

            Lists lists = new Lists();
        }
    }

    internal class Lists
    {
        public Lists()
        {
            int[] numbers = [1, 2, 3, 4];
            int[] moreNumbers = [5, 6, 7, 8];
            int[] combined = [.. numbers, .. moreNumbers];

            Console.WriteLine(this.toString(numbers));
            Console.WriteLine(this.toString(combined));
        }

        public string toString(int[] list)
        {
            string result = "[";
            for (int i = 0; i < list.Length - 1; i++)
            {
                if (result.Length > 1)
                {
                    result += ", ";
                }
                result += list[i].ToString();
                if (i == list.Length - 2)
                {
                    result += "]";
                }
            }
            return result;
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

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
        }
    }

    internal class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
}

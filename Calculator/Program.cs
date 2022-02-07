using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter First Number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result;
            result = num1 + num2;
            Console.WriteLine($"The Sum of the {num1} and {num2} is {result}");
            result = num1 - num2;
            Console.WriteLine($"The Subtraction of the {num1} and {num2} is {result}");
            result = num1 * num2;
            Console.WriteLine($"The Multipication of the {num1} and {num2} is {result}");
            result = num1 / num2;
            Console.WriteLine($"The Division of the {num1} and {num2} is {result}");

        }
    }
}

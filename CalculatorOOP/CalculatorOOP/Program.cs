using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 10;
            int secondNumber = 20;

            int result;

            // addition
            result = firstNumber + secondNumber;
            Console.WriteLine($"Adding numbers : {result}");

            // subtraction
            result = firstNumber - secondNumber;
            Console.WriteLine($"Subtracting numbers : {result}");

            // multiplication
            result = firstNumber * secondNumber;
            Console.WriteLine($"Multiplying numbers : {result}");

            // division
            result = firstNumber / secondNumber;
            Console.WriteLine($"Dividing numbers : {result}");

            Console.ReadKey();
        }
    }
}

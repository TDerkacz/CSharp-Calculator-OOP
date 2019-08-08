using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal? result = null;

            Console.WriteLine("==== This is simple Calculator with four operations ====");
            Console.WriteLine();

            Console.WriteLine("Enter first number");
            var firstNumberFromConsole = Console.ReadLine();

            Console.WriteLine("Enter second number");
            var secondNumberFromConsole = Console.ReadLine();

            result = Calculator.AddNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Adding numbers");

            result = Calculator.SubtractNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Subtracting numbers");

            result = Calculator.MultiplyNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Multiplying numbers");

            result = Calculator.DivideNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Dividing numbers");

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static void PrintResult(decimal? result, string ResultInfo)
        {
            if ((result == null) && (result == -1))
            {
                Console.WriteLine("Incorrect result");
            }
            else
            {
                Console.WriteLine($"{ResultInfo} : {result}");
            }
        }
    }
}

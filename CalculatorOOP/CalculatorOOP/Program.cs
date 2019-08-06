using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNumber, secondNumber, result;

            Console.WriteLine("==== This is simple Calculator with four operations ====");
            Console.WriteLine();

            Console.WriteLine("Enter first number");
            var firstNumberFromConsole = Console.ReadLine();

            Console.WriteLine("Enter second number");
            var secondNumberFromConsole = Console.ReadLine();

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {
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
                if (secondNumber != 0)
                {
                    result = firstNumber / secondNumber;
                    Console.WriteLine($"Dividing numbers : {result}");
                }
                else
                {
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            else
            {
                Console.WriteLine("Incorrect data, both must be numbers");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

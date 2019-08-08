using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==== This is simple Calculator with four operations ====");
            Console.WriteLine();

            Console.WriteLine("Enter first number");
            var firstNumberFromConsole = Console.ReadLine();

            Console.WriteLine("Enter second number");
            var secondNumberFromConsole = Console.ReadLine();

            AddNumbers(firstNumberFromConsole, secondNumberFromConsole);
            SubtractNumbers(firstNumberFromConsole, secondNumberFromConsole);
            MultiplyNumbers(firstNumberFromConsole, secondNumberFromConsole);
            DivideNumbers(firstNumberFromConsole, secondNumberFromConsole);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }

        static decimal? AddNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
        {
            decimal firstNumber, secondNumber;
            decimal? result = null;

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {
                result = firstNumber + secondNumber;
                Console.WriteLine($"Adding numbers : {result}");
            }
            else
            {
                Console.WriteLine("Incorrect data, both must be numbers");
            }
            return result;
        }

        static decimal? SubtractNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
        {
            decimal firstNumber, secondNumber;
            decimal? result = null;

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {             
                result = firstNumber - secondNumber;
                Console.WriteLine($"Subtracting numbers : {result}");
            }
            else
            {
                Console.WriteLine("Incorrect data, both must be numbers");
            }
            return result;
        }

        static decimal? MultiplyNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
        {
            decimal firstNumber, secondNumber;
            decimal? result = null;

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {
                result = firstNumber * secondNumber;
                Console.WriteLine($"Multiplying numbers : {result}");
            }
            else
            {
                Console.WriteLine("Incorrect data, both must be numbers");
            }
            return result;
        }

        static decimal? DivideNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
        {
            decimal firstNumber, secondNumber;
            decimal? result = null;

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {        
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
            return result;
        }
    }
}

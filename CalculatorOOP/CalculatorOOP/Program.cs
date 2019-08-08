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

            result = AddNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Adding numbers");

            result = SubtractNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Subtracting numbers");

            result = MultiplyNumbers(firstNumberFromConsole, secondNumberFromConsole);
            PrintResult(result, "Multiplying numbers");

            result = DivideNumbers(firstNumberFromConsole, secondNumberFromConsole);
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

        static decimal? AddNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
        {
            decimal firstNumber, secondNumber;
            decimal? result = null;

            if ((Decimal.TryParse(firstNumberFromConsole, out firstNumber)) && (Decimal.TryParse(secondNumberFromConsole, out secondNumber)))
            {
                result = firstNumber + secondNumber;
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

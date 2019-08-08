using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP
{
    public class Calculator
    {
        public static decimal? AddNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
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

        public static decimal? SubtractNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
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

        public static decimal? MultiplyNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
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

        public static decimal? DivideNumbers(string firstNumberFromConsole, string secondNumberFromConsole)
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

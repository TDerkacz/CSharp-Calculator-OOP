using CalculatorOOP.Classes;
using System;

namespace CalculatorOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            ObiFinancialCalc obiFinancialCalc = new ObiFinancialCalc();
            TescoFinancialCalc tescoFinancialCalc = new TescoFinancialCalc();

            decimal annualResults = obiFinancialCalc.CalculateAnnualFinances(20000);
            decimal monthlyResults = obiFinancialCalc.CalculateMonthlyFinances(1500);
            decimal weeklyResults = obiFinancialCalc.CalculateWeeklyFinances(50);

            Console.WriteLine($"OBI annual results = {annualResults}");
            Console.WriteLine($"OBI monthly results = {monthlyResults}");
            Console.WriteLine($"OBI weekly results = {weeklyResults}");

            Console.WriteLine();

            annualResults = tescoFinancialCalc.CalculateAnnualFinances(20000);
            monthlyResults = tescoFinancialCalc.CalculateMonthlyFinances(1500);
            weeklyResults = tescoFinancialCalc.CalculateWeeklyFinances(50);

            Console.WriteLine($"TESCO annual results = {annualResults}");
            Console.WriteLine($"TESCO monthly results = {monthlyResults}");
            Console.WriteLine($"TESCO weekly results = {weeklyResults}");

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

//decimal? result = null;

//Console.WriteLine("==== This is simple Calculator with four operations ====");
//            Console.WriteLine();

//            Console.WriteLine("Enter first number");
//            var firstNumberFromConsole = Console.ReadLine();

//Console.WriteLine("Enter second number");
//            var secondNumberFromConsole = Console.ReadLine();

//result = Calculator.AddNumbers(firstNumberFromConsole, secondNumberFromConsole);
//            PrintResult(result, "Adding numbers");

//result = Calculator.SubtractNumbers(firstNumberFromConsole, secondNumberFromConsole);
//            PrintResult(result, "Subtracting numbers");

//result = Calculator.MultiplyNumbers(firstNumberFromConsole, secondNumberFromConsole);
//            PrintResult(result, "Multiplying numbers");

//result = Calculator.DivideNumbers(firstNumberFromConsole, secondNumberFromConsole);
//            PrintResult(result, "Dividing numbers");

//Console.WriteLine();
//            Console.WriteLine("Press any key to exit");
//            Console.ReadKey();
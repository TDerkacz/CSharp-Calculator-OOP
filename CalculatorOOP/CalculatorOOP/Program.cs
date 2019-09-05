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


            Console.WriteLine();
            Console.WriteLine(">> one calculation method invoked with two classes using IFinancialCalculator as a type ");
            Console.WriteLine();

            CalculateFinances(obiFinancialCalc, 20000, 1500, 50);
            Console.WriteLine();
            CalculateFinances(tescoFinancialCalc, 20000, 1500, 50);

            Console.ReadKey();
        }

        static void CalculateFinances(IFinancialCalculator FinancialCalc, decimal annualInput, decimal monthlyInput, decimal weeklyInput)
        {
            decimal annualResults = FinancialCalc.CalculateAnnualFinances(annualInput);
            decimal monthlyResults = FinancialCalc.CalculateMonthlyFinances(monthlyInput);
            decimal weeklyResults = FinancialCalc.CalculateWeeklyFinances(weeklyInput);

            Console.WriteLine($"OBI annual results = {annualResults}");
            Console.WriteLine($"OBI monthly results = {monthlyResults}");
            Console.WriteLine($"OBI weekly results = {weeklyResults}");
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

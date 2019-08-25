using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.Classes
{
    public class ObiFinancialCalc : IFinancialCalculator
    {
        private const decimal FINANCE_FACTOR = 0.5m;
        private const decimal BONUS_FACTOR = 0.4m;

        public decimal CalculateAnnualFinances(decimal input)
        {
            return input * 12 * FINANCE_FACTOR * BONUS_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * FINANCE_FACTOR * BONUS_FACTOR;
        }

        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * FINANCE_FACTOR * BONUS_FACTOR;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.Classes
{
    public class GeneralCompanyFinancialCalculator : IFinancialCalculator
    {
        private const decimal GENERAL_COMPANY_FINANCE_FACTOR = 0.3m;

        public decimal CalculateAnnuallyFinances(decimal input)
        {
            return input * 12 * GENERAL_COMPANY_FINANCE_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * GENERAL_COMPANY_FINANCE_FACTOR;
        }

        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * GENERAL_COMPANY_FINANCE_FACTOR;
        }
    }
}

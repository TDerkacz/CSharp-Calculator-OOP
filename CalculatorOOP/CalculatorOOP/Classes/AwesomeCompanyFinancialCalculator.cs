using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.Classes
{
    public class AwesomeCompanyFinancialCalculator : IFinancialCalculator
    {
        private const decimal AWESOME_COMPANY_FINANCE_FACTOR = 0.5m;

        public decimal CalculateAnnuallyFinances(decimal input)
        {
            return input * 12 * AWESOME_COMPANY_FINANCE_FACTOR;
        }

        public decimal CalculateMonthlyFinances(decimal input)
        {
            return input * AWESOME_COMPANY_FINANCE_FACTOR;
        }

        public decimal CalculateWeeklyFinances(decimal input)
        {
            return input * 0.25m * AWESOME_COMPANY_FINANCE_FACTOR;
        }
    }
}

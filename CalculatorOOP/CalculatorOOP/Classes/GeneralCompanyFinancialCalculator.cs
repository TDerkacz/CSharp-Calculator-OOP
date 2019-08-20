using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP.Classes
{
    public class GeneralCompanyFinancialCalculator : IFinancialCalculator
    {
        private const decimal GENERAL_COMPANY_FINANCE_FACTOR = 0.3m;

        public void CalculateAnnuallyFinances(decimal input)
        {
            throw new NotImplementedException();
        }

        public void CalculateMonthlyFinances(decimal input)
        {
            throw new NotImplementedException();
        }

        public void CalculateWeeklyFinances(decimal input)
        {
            throw new NotImplementedException();
        }
    }
}

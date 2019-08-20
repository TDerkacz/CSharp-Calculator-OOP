using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorOOP
{/// <summary>
/// Interface 
/// no field declarations
/// no methods implementations 
/// only methods declarations
/// 
/// Interface can be used as a parameter in method
/// so method will know from witch class to use
/// 
/// Interface members are always public by default - no modifier required
/// 
/// Abstract Class might contain
/// - private or protected variables
/// </summary>
/// 
    public interface IFinancialCalculator
    {
        decimal CalculateAnnuallyFinances(decimal input);
        decimal CalculateMonthlyFinances(decimal input);
        decimal CalculateWeeklyFinances(decimal input);
    }
}

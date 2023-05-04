using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetFormsApp.Models;

namespace BudgetFormsApp.Utils
{
    public static class SharedUtils
    {
        public static double CalculateTotals(List<Expense> expenses)
        {
            double total = 0;
            foreach (Expense expense in expenses)
            {
                total += expense.Amount;
            }
            return total;
        }

        public static bool DetermineAffordability(double income, double expenses)
        {
            if (expenses <= 2 * (income / 3))
                return true;
            else
                return false;
        }
    }
}

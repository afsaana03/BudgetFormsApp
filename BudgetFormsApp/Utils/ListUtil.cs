using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetFormsApp.Models;

namespace BudgetFormsApp.Utils
{
    public static class ListUtil
    {
        public static List<Expense> expenses = new List<Expense>();

        public static List<GeneralExpense> generalExpenses = new List<GeneralExpense>();
        public static List<RentalExpense> rentalExpenses = new List<RentalExpense>();
    }
}

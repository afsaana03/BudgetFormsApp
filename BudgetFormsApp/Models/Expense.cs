using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetFormsApp.Models
{
    public abstract class Expense
    {
        public int ExpenseId { get; set; }
        public double Amount { get; set; }
        public string? Payee { get; set; }

        protected Expense(int expenseId, double amount, string? payee)
        {
            ExpenseId = expenseId;
            Amount = amount;
            Payee = payee;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetFormsApp.Models
{
    public class GeneralExpense : Expense
    {
        public DateTime Date { get; set; }
        public string? Description { get; set; }

        public GeneralExpense(DateTime date, string? description,
            int expenseId, double amount, string payee) :
            base(expenseId, amount, payee)
        {
            Date = date;
            Description = description;
        }
    }
}

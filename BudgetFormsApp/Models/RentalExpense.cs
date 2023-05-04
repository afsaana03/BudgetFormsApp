using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BudgetFormsApp.Models
{
    public class RentalExpense : Expense
    {
        public int LeasePeriod { get; set; }
        public string? Address { get; set; }

        public RentalExpense(int leasePeriod, string address, int expenseId, double amount,
            string payee) : base(expenseId, amount, payee)
        {
            LeasePeriod = leasePeriod;
            Address = address;

        }
    }
}

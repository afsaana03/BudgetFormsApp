using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetFormsApp.Models;
using BudgetFormsApp.Utils;

namespace BudgetFormsApp.Tests
{
    [TestClass()]
    public class SharedUtilsTests
    {
        // Getting started: https://www.c-sharpcorner.com/article/a-basic-introduction-of-unit-test-for-beginners/
        // Best practices: https://stackify.com/unit-testing-basics-best-practices/
        // Running unit tests in VS: https://learn.microsoft.com/en-us/visualstudio/test/run-unit-tests-with-test-explorer?view=vs-2022
        // Code coverage: https://learn.microsoft.com/en-us/visualstudio/test/using-code-coverage-to-determine-how-much-code-is-being-tested?view=vs-2022&tabs=csharp
        [TestMethod()]
        public void CalculateCorrectTotalsTest()
        {
            List<Expense> list = new List<Expense>();
            list.Add(new GeneralExpense(DateTime.Now, "Test", 1, 500, "Test payee"));
            list.Add(new GeneralExpense(DateTime.Now, "Test 2", 1, 1000, "Test payee 2"));
            double result = SharedUtils.CalculateTotals(list);
            Assert.AreEqual(1500, result);
        }

        [TestMethod()]
        public void CalculateIncorrectTotalsTest()
        {
            List<Expense> list = new List<Expense>();
            list.Add(new GeneralExpense(DateTime.Now, "Test", 1, 500, "Test payee"));
            double result = SharedUtils.CalculateTotals(list);
            Assert.AreNotEqual(1500, result);
        }

        [TestMethod()]
        public void DetermineAffordabilityTestWithAffordable()
        {
            bool result = SharedUtils.DetermineAffordability(10000, 5000);
            Assert.AreEqual(true, result);
        }

        [TestMethod()]
        public void DetermineAffordabilityTestWithUnaffordable()
        {
            bool result = SharedUtils.DetermineAffordability(10000, 8000);
            Assert.AreEqual(false, result);
        }
    }
}
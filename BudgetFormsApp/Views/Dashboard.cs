using BudgetFormsApp.Models;
using BudgetFormsApp.Utils;

namespace BudgetFormsApp
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            GeneralExpense ge = new GeneralExpense(DateTime.Now, "Light Bill", 1, 2000, "Ethekwini");
            ListUtil.generalExpenses.Add(ge);

            RentalExpense re = new RentalExpense(24, "12 Radar Drive", 2, 10000, "Mr Landlord");
            ListUtil.rentalExpenses.Add(re);

            dtgGeneralExpenses.DataSource = ListUtil.generalExpenses;
            dtgRentalExpenses.DataSource = ListUtil.rentalExpenses;

            ListUtil.expenses.Add(ge);
            ListUtil.expenses.Add(re);

            dtgExpenses.DataSource = ListUtil.expenses;
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total is R " + 
                SharedUtils.CalculateTotals(ListUtil.expenses));
        }

        private void btnAffordability_Click(object sender, EventArgs e)
        {
            double income = Convert.ToDouble(txbIncome.Text);
            MessageBox.Show("Affordability fine? " + SharedUtils.DetermineAffordability(income, SharedUtils.CalculateTotals(ListUtil.expenses)));
        }
    }
}
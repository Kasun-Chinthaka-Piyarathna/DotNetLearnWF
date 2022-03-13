using DVDStore;
using FinancialManagementStore.DataObjects;
using FinancialManagementStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManagementStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

      /*  private void AuthenticateUser(object sender, EventArgs e)
        {
            String username = this.txtUserName.Text;
            String password = this.txtPassword.Text;

            //validations
            if (username == null || username == String.Empty) { 
                    MessageBox.Show("Username required", "Hey", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            UserProfileModel userProfileModel = new UserProfileModel();
            Boolean result = userProfileModel.LoginUser(username, password);
            if (result == true) {
                RegisterView registerView = new RegisterView();
                registerView.UserName = username;
                registerView.labelUserEnteredName.Text = username;
                registerView.Show();
                this.Hide();
            }
        }*/

        FinancialMgtDataSet financialMgtDataSet = new FinancialMgtDataSet();
    
        private void ShowTheData(object sender, EventArgs e)
        {
            TransactionView transactionView = new TransactionView();
            if (this.financialMgtDataSet.TransactionDataTable==null ||
                this.financialMgtDataSet.TransactionDataTable.Rows.Count == 0) {
                MessageBox.Show("No Transaction to display, Please add incomes and expenses first!", "Hey", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }
            FinancialMgtDataSet.TransactionDataTableRow row = (FinancialMgtDataSet.TransactionDataTableRow)
                this.financialMgtDataSet.
                TransactionDataTable.Rows[this.financialMgtDataSet.TransactionDataTable.Rows.Count - 1];
            TransactionInformation newData = new TransactionInformation();
            newData.Transaction = row.Transaction;
            newData.Date = row.Date;
            transactionView.TransactionDataToDisplay = newData;
            transactionView.transactionDataGridView.DataSource = this.financialMgtDataSet.TransactionDataTable;
            transactionView.Show();
        }

        private void ShowAddExpenseForm(object sender, EventArgs e)
        {
            ExpenseEntry expenseEntry = new ExpenseEntry();
            expenseEntry.ShowDialog();
            TransactionInformation transactionInfo = expenseEntry.TransactionData;
            expenseEntry.Dispose();
            //storage
            FinancialMgtDataSet.TransactionDataTableRow row = this.financialMgtDataSet.TransactionDataTable.NewTransactionDataTableRow();
            if (row != null && transactionInfo != null)
            {
                row.Transaction = transactionInfo.Transaction;
                row.Date = transactionInfo.Date;
                row.IsIncome = transactionInfo.IsIncome ? "YES" : "NO";
                row.Type = transactionInfo.Type;
                this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row);
            }

        }

        private void ShowAddIncomeForm(object sender, EventArgs e)
        {
            IncomeEntry incomeEntry = new IncomeEntry();
            incomeEntry.ShowDialog();
            TransactionInformation transactionInfo = incomeEntry.TransactionData;
            incomeEntry.Dispose();
            //storage
            FinancialMgtDataSet.TransactionDataTableRow row = this.financialMgtDataSet.TransactionDataTable.NewTransactionDataTableRow();
            if (row != null && transactionInfo!=null)
            {
                row.Transaction = transactionInfo.Transaction;
                row.Date = transactionInfo.Date;
                row.IsIncome = transactionInfo.IsIncome ? "YES" : "NO";
                row.Type = transactionInfo.Type;
                this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row);
            }
        }
    }
}

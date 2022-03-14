using FinancialMgtTool;
using FinancialManagementStore.DataObjects;
using System;
using System.Windows.Forms;

namespace FinancialManagementStore
{
    public partial class MainForm : Form
    {
        FinancialMgtDataSet financialMgtDataSet;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            financialMgtDataSet = TransactionInformationModel.GetInstance().financialMgtDataSet;

        }

        private void ShowTheData(object sender, EventArgs e)
        {
            TransactionView transactionView = new TransactionView();
            if (this.financialMgtDataSet.TransactionDataTable==null ||
                this.financialMgtDataSet.TransactionDataTable.Rows.Count == 0) {
                MessageBox.Show("No Transaction to display, Please add incomes and expenses first!", "Hey", MessageBoxButtons.OK,
                   MessageBoxIcon.Warning);
                return;
            }
            transactionView.transactionDataGridView.DataSource = this.financialMgtDataSet.
                TransactionDataTable;
            transactionView.financialMgtDataSet = this.financialMgtDataSet; 
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
                row.Amount = transactionInfo.Amount;
                row.Date = transactionInfo.Date;
                row.Type = transactionInfo.Type;
                row.Description = transactionInfo.Description;
                row.Occurence = transactionInfo.Occurence;
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
                row.Amount = transactionInfo.Amount;
                row.Date = transactionInfo.Date;
                row.Type = transactionInfo.Type;
                row.Description = transactionInfo.Description;
                row.Occurence = transactionInfo.Occurence;
                this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row);
            }
        }
    }
}

using FinancialManagementStore.DataObjects;
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
    public partial class ExpenseEntry : Form
    {
        public TransactionInformation TransactionData { get; set; }
        public ExpenseEntry()
        {
            InitializeComponent();
        }

    
        private void ExpenseEntry_Load(object sender, EventArgs e)
        {

        }

        private void AddTransaction(object sender, EventArgs e)
        {
            if (this.TransactionData == null)
            {
                this.TransactionData = new TransactionInformation();
            }
            String amount = this.textAmount.Text;
            String transactionDate = this.dateTimePicker.Value.ToLongDateString();
            int index = this.typeSelectionComboBox.SelectedIndex;
            if (amount == null || amount == String.Empty)
            {
                MessageBox.Show("Transaction Amount is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (transactionDate == null || transactionDate == String.Empty)
            {
                MessageBox.Show("Transaction Date is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (index==-1)
            {
                MessageBox.Show("Transaction Type is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.TransactionData.Transaction = amount;
            this.TransactionData.Date = transactionDate;
            this.TransactionData.Type = this.typeSelectionComboBox.SelectedItem.ToString();
            this.TransactionData.IsIncome = false;
            this.Hide();
        }
    }
}

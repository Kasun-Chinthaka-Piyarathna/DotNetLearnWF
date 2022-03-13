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

namespace DVDStore
{
    public partial class IncomeEntry : Form
    { 
        public TransactionInformation TransactionData { get; set; }
        public IncomeEntry()
        {
            InitializeComponent();
        }
      
        private void AddTransaction(object sender, EventArgs e)
        {
            if (this.TransactionData == null)
            {
                this.TransactionData = new TransactionInformation();
            }

            String amount = this.textAmount.Text;
            String transactionDate = this.dateTimePicker.Value.ToLongDateString();
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
            this.TransactionData.Transaction = amount;
            this.TransactionData.Date = transactionDate;
            this.TransactionData.IsIncome = true;
            this.TransactionData.Type = null;
            this.Hide();
        }
    }
}

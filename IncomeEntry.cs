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
            String description = this.textDescription.Text;
            DateTime transactionDate = this.dateTimePicker.Value.Date;
            if (amount == null || amount == String.Empty)
            {
                MessageBox.Show("Transaction Amount is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (description == null || description == String.Empty)
            {
                MessageBox.Show("Transaction Description is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (transactionDate == null)
            {
                MessageBox.Show("Transaction Date is required", "Hey", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            this.TransactionData.Amount = Convert.ToDouble(amount);
            this.TransactionData.Description = description;
            this.TransactionData.Date = transactionDate;
            this.TransactionData.Type = "Income";
            this.TransactionData.Occurence = "One-Off";
            this.Hide();
        }

        private void IncomeEntry_Load(object sender, EventArgs e)
        {

        }
    }
}

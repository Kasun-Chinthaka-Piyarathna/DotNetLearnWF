using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialMgtTool
{
    public partial class UpdateEntry : Form
    {

        public FinancialMgtDataSet financialMgtDataSet { get; set; }
        public int index { get; set; }
        public UpdateEntry()
        {
            InitializeComponent();
        }

        private void UpdateTransactionNow(object sender, EventArgs e)
        {
            String amount = this.textAmount.Text;
            String description = this.textDescription.Text;
          
            FinancialMgtDataSet.TransactionDataTableRow[] rows =
                (FinancialMgtDataSet.TransactionDataTableRow[])
                this.financialMgtDataSet.TransactionDataTable.Select("Id = " + index);

            this.financialMgtDataSet.AcceptChanges();
            this.financialMgtDataSet.TransactionDataTable.AcceptChanges();
            Boolean isUpdated = false;
            if (rows.Length > 0)
            {
                foreach (FinancialMgtDataSet.TransactionDataTableRow row in rows)
                {
                    if (amount != null &&  amount != String.Empty)
                    {
                        row.Amount = Convert.ToDouble(amount);
                        row.AcceptChanges();
                        isUpdated = true;
                    }
                    if (description != null && description != String.Empty)
                    {
                        row.Description = description;
                        row.AcceptChanges();
                        isUpdated = true;
                    }
                    

                }
            }
            if (isUpdated)
            {
                MessageBox.Show("Record has been successfully updated!");
            }
            this.Hide();
        }
    }
}

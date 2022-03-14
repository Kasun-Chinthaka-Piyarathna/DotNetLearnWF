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
    public partial class TransactionView : Form
    {

        public TransactionInformation TransactionDataToDisplay { get; set; }
        public FinancialMgtDataSet financialMgtDataSet { get; set; }

        int id = 0;


        public TransactionView()
        {
            InitializeComponent();
        }
        private void TransactionView_Load(object sender, EventArgs e)
        {
        }
 

        private void DeleteRecord(object sender, EventArgs e)
        {
            if (id != 0)
            {

        
                FinancialMgtDataSet.TransactionDataTableRow[] rows =
    (FinancialMgtDataSet.TransactionDataTableRow[])
    this.financialMgtDataSet.TransactionDataTable.Select("Id = " + id);

                this.financialMgtDataSet.AcceptChanges();
                this.financialMgtDataSet.TransactionDataTable.AcceptChanges();

                if (rows.Length > 0)
                {
                    foreach (FinancialMgtDataSet.TransactionDataTableRow row in rows)
                    {
                        row.Delete();

                    }
                    MessageBox.Show("Record Deleted Successfully!");
                }

                id = 0;

            }
            else
            {
                MessageBox.Show("Please Select Record to Delete. You can click on Row Header and select the row!");

             
            }
        }

        private void RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(transactionDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void UpdateRecord(object sender, EventArgs e)
        {
            if (id != 0)
            {
                FinancialMgtDataSet.TransactionDataTableRow[] rows = 
                    (FinancialMgtDataSet.TransactionDataTableRow[])
                    this.financialMgtDataSet.TransactionDataTable.Select("id = " + id);

                this.financialMgtDataSet.AcceptChanges();
                this.financialMgtDataSet.TransactionDataTable.AcceptChanges();

                if (rows.Length > 0)
                {
                    foreach (FinancialMgtDataSet.TransactionDataTableRow row in rows)
                    {
                        row.Amount = 1000;
                        row.AcceptChanges();
       
                    }
                }
                MessageBox.Show("Record has been successfully updated!");
                id = 0;
            }
            else {
                MessageBox.Show("Please Select Record to Update. You can click on Row Header and select the row!");
            }
        }

        private void ShowWeeklyReport(object sender, EventArgs e)
        {
            WeeklyView weeklyView = new WeeklyView();
            weeklyView.ShowDialog();
        }
    }
}

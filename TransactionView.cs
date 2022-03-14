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

        public FinancialMgtDataSet financialMgtDataSet { get; set; }

        int id = 0;


        public TransactionView()
        {
            InitializeComponent();
        }
        private void TransactionView_Load(object sender, EventArgs e)
        {
            FinancialMgtDataSet.TransactionDataTableRow[] rows =
(FinancialMgtDataSet.TransactionDataTableRow[])
    this.financialMgtDataSet.TransactionDataTable.Select();
            MessageBox.Show(rows.Length.ToString());

            if (rows.Length > 0)
            {
                Double totalIncomes = 0;
                Double totalExpenses = 0;
                Double balance = 0;
                int financialPredictionPerADate = 0;
                int numberOfDates =(int)(rows[rows.Length - 1].Date - rows[0].Date).TotalDays;
                numberOfDates = numberOfDates == 0 ? 1 : numberOfDates;
                foreach (FinancialMgtDataSet.TransactionDataTableRow row in rows)
                {
                    if (row.Type.Equals("Income"))
                    {
                        totalIncomes += row.Amount;
                    }
                    else
                    {
                        totalExpenses += row.Amount;
                    }

                }
                balance = totalIncomes - totalExpenses;
                financialPredictionPerADate = (int)balance / numberOfDates;
                this.labelTransactionViewTotalIncome.Text = "Your total incomes are "+ totalIncomes;
                this.labelTransactionViewTotalExpenses.Text = "Your total expeses are "+totalExpenses;
                this.labelTransactionViewTotalBalance.Text = "Your balance is "+balance;
                this.labelTransactionViewFuturePrediction.Text="Financial Prediction per a future date is "+
                    financialPredictionPerADate;

            }
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
            DateTime nowDate = DateTime.Now.Date;
            DateTime lastWeekStartDate = DateTime.Now.AddDays(-7).Date;
            FinancialMgtDataSet.TransactionDataTableRow[] rows =
            (FinancialMgtDataSet.TransactionDataTableRow[])
            this.financialMgtDataSet.TransactionDataTable.Select("Date > #" + lastWeekStartDate+"#"+
            "AND Date <= #"+nowDate+"#");
            List<TransactionInformation> weeklyData = new List<TransactionInformation>();

            if (rows.Length > 0)
            {
                Double totalIncome=0;
                Double totalExpenses=0;
                Double balance = 0;
                foreach (FinancialMgtDataSet.TransactionDataTableRow row in rows)
                {
                    weeklyData.Add(new TransactionInformation()
                    {
                        Id = row.Id,
                        Description = row.Description,
                        Amount = row.Amount,
                        Date = row.Date,
                        Type = row.Type,
                        Occurence = row.Occurence
                    });

                    if (row.Type.Equals("Income"))
                    {
                        totalIncome += row.Amount;
                    }
                    else {
                        totalExpenses += row.Amount;
                    }

                }
                balance = totalIncome - totalExpenses;
                WeeklyView weeklyView = new WeeklyView();
                weeklyView.labelFrom.Text = lastWeekStartDate.ToShortDateString();
                weeklyView.labelTo.Text = nowDate.ToShortDateString();
                weeklyView.labelWeekIncome.Text = Convert.ToString(totalIncome);
                weeklyView.labelWeekExpenses.Text =Convert.ToString(totalExpenses);
                weeklyView.labelWeekBalance.Text = Convert.ToString(balance);
                weeklyView.weeklyDataGridView.DataSource = weeklyData;
                weeklyView.ShowDialog();
            }
            else {
                MessageBox.Show("No data found to display a week report!");
            }

            
        }
    }
}

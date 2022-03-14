using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDStore
{
    public class TransactionInformationModel
    {
        private static TransactionInformationModel instance = null;

        public FinancialMgtDataSet financialMgtDataSet = new FinancialMgtDataSet();
        private TransactionInformationModel()
        {
            SetInitialRecords();
        }

        public static TransactionInformationModel GetInstance() {
            if (instance == null)
                instance = new TransactionInformationModel();

            return instance;
        }

        public void SetInitialRecords() // only for demostration
        {

            FinancialMgtDataSet.TransactionDataTableRow row1 = this.financialMgtDataSet.
                TransactionDataTable.NewTransactionDataTableRow();
            row1.Amount = 1000.50;
            row1.Date = Convert.ToDateTime("2/10/2022").Date;
            row1.Type = "Income";
            row1.Occurence = "One-Off";
            row1.Description = "Arduino Kit";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row1);

            FinancialMgtDataSet.TransactionDataTableRow row2 = this.financialMgtDataSet.
                TransactionDataTable.NewTransactionDataTableRow();
            row2.Amount = 10000;
            row2.Date = Convert.ToDateTime("3/10/2022").Date;
            row2.Type = "Expense";
            row2.Occurence = "One-Off";
            row2.Description = "Pay a loan";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row2);

            FinancialMgtDataSet.TransactionDataTableRow row3 = this.financialMgtDataSet.
               TransactionDataTable.NewTransactionDataTableRow();
            row3.Amount = 120000;
            row3.Date = Convert.ToDateTime("3/10/2022").Date;
            row3.Type = "Income";
            row3.Occurence = "Salary";
            row3.Description = "Arduino Kit";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row3);

            FinancialMgtDataSet.TransactionDataTableRow row4 = this.financialMgtDataSet.
               TransactionDataTable.NewTransactionDataTableRow();
            row4.Amount = 1500;
            row4.Date = Convert.ToDateTime("3/11/2022").Date;
            row4.Type = "Expense";
            row4.Occurence = "Recurring";
            row4.Description = "Internet Bill";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row4);

            FinancialMgtDataSet.TransactionDataTableRow row5 = this.financialMgtDataSet.
               TransactionDataTable.NewTransactionDataTableRow();
            row5.Amount = 4500;
            row5.Date = Convert.ToDateTime("3/12/2022").Date;
            row5.Type = "Income";
            row5.Occurence = "One-Off";
            row5.Description = "Money back from friend";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row5);

            FinancialMgtDataSet.TransactionDataTableRow row6 = this.financialMgtDataSet.
               TransactionDataTable.NewTransactionDataTableRow();
            row6.Amount = 1000.50;
            row6.Date = Convert.ToDateTime("3/13/2022").Date;
            row6.Type = "Income";
            row6.Occurence = "One-Off";
            row6.Description = "Money back from friend";
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row6);
        }
    }
}




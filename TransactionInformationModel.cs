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

            FinancialMgtDataSet.TransactionDataTableRow row = this.financialMgtDataSet.
                TransactionDataTable.NewTransactionDataTableRow();
            row.Amount = 1000.50;
            row.Date = Convert.ToDateTime("3/10/2022").Date;
            row.Type = "Income";
            row.Occurence = null;
            this.financialMgtDataSet.TransactionDataTable.AddTransactionDataTableRow(row);
        }
    }
}




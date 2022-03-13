using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementStore.DataObjects
{
    public class TransactionInformation
    {
        public String Id { get; set; }
        public String Transaction { get; set; }
        public String Date { get; set; }
        public Boolean IsIncome { get; set; }
        public String Type { get; set; }
    }
}

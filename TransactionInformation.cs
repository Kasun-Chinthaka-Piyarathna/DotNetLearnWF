using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementStore.DataObjects
{
    public class TransactionInformation
    {
        public int Id { get; set; }
        public String Description { get; set; }
        public Double Amount { get; set; }
        public DateTime Date { get; set; }
        public String Type { get; set; }
        public String Occurence { get; set; }
    }
}

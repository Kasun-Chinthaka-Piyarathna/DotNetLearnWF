using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementStore.Models

{
    public class UserProfileModel
    {
        private List<String> UserNames = null;
        public UserProfileModel(){
            this.UserNames = new List<string>();
            this.UserNames.Add("Kasun");
            this.UserNames.Add("Mune");
    }
        public Boolean LoginUser(String username, String password)
        {
            if (this.UserNames.Contains(username))
            {
                return true;
            }
            return false;
        }
    }
}

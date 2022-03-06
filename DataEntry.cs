using DVDStore.DataObjects;
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
    public partial class DataEntry : Form
    {
        public UserInformation UserData { get; set; }
        public DataEntry()
        {
            InitializeComponent();
        }

        private void StoreTheInfor(object sender, EventArgs e)
        {
            if (this.UserData == null)
            {
                this.UserData = new UserInformation();
            }
            this.UserData.FirstName = this.textFirstName.Text;
            this.UserData.LastName = this.textLastName.Text;
            this.Hide();
        }
    }
}

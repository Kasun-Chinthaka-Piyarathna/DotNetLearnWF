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
    public partial class RegisterView : Form
    {
        public String UserName { get; set; }

        public UserInformation UserDataToDisplay { get; set; }
        public RegisterView()
        {
            InitializeComponent();
        }

        private void RegisterView_Load(object sender, EventArgs e)
        {
            this.lblUserEnteredName.Text = this.UserDataToDisplay.FirstName;
        }

        private void GenerateRows(object sender, EventArgs e)
        {
            int numberOfItems = Convert.ToInt32(this.textRows.Text);
            int horizontal = 142;
            int vertical = 48;
            for (int x = 0; x < numberOfItems; x++) {
                TextBox b = new TextBox();
                vertical += 25;
                b.Location = new System.Drawing.Point(horizontal, vertical);
                b.Name = "txtUserName"+x;
                b.Size = new System.Drawing.Size(100, 20);
                this.Controls.Add(b);
                b.Visible = true;
            }
           // this.Controls.Clear(); clear the all ui components of the window
        }
    }
}

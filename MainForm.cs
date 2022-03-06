using DVDStore.DataObjects;
using DVDStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVDStore.DVDStoreData;

namespace DVDStore
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AuthenticateUser(object sender, EventArgs e)
        {
            String username = this.txtUserName.Text;
            String password = this.txtPassword.Text;

            //validations
            if (username == null || username == String.Empty) { 
                    MessageBox.Show("Username required", "Hey", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
            UserProfileModel userProfileModel = new UserProfileModel();
            Boolean result = userProfileModel.LoginUser(username, password);
            if (result == true) {
                RegisterView registerView = new RegisterView();
                registerView.UserName = username;
               // registerView.lblUserEnteredName.Text = username;
                registerView.Show();
                //this.Hide();
            }
        }

        UserInformation userEnteredInfo;
        DVDStoreData dbData = new DVDStoreData();
        private void OpenDataEntryForm(object sender, EventArgs e)
        {
            DataEntry dataEntry = new DataEntry();
            dataEntry.ShowDialog();
            userEnteredInfo = dataEntry.UserData;
            dataEntry.Dispose();
            //storage
            UserDataRow row = this.dbData.UserData.NewUserDataRow();
            row.FirstName = userEnteredInfo.FirstName;
            row.LastName = userEnteredInfo.LastName;
            this.dbData.UserData.AddUserDataRow(row);
        }

        private void ShowTheData(object sender, EventArgs e)
        {
            RegisterView register = new RegisterView();
            DVDStoreData.UserDataRow row = (UserDataRow)this.dbData.UserData.Rows[this.dbData.UserData.Rows.Count - 1];
            UserInformation newData = new UserInformation();
            newData.FirstName = row.FirstName;
            newData.LastName = row.LastName;
            register.UserDataToDisplay = newData;

            register.dataGridView.DataSource = this.dbData.UserData;



            register.Show();
        }
    }
}

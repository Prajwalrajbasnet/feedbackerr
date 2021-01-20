using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feedback_System
{
    public partial class Login : Form
    {
        private Hashtable customers = new Hashtable(){
            {"user", "user"},
            { "customer", "customerPwd" }
         };

        private Hashtable admins = new Hashtable(){
            { "admin", "admin" },
            { "root", "root" }
        };
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginAdmin_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                if (admins.ContainsKey(usernameField.Text))
                {
                    if ((string)admins[usernameField.Text] == passwordField.Text)
                    {
                        var adminPanel = new Admin();
                        adminPanel.Show();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("Wrong credentials");
                    }
                }
                else {
                    MessageBox.Show("There is no such user in the system");
                }
            }
            else {
                MessageBox.Show("Please provide proper input for credentials");
            }
        }

        private void customerLogin_Click(object sender, EventArgs e)
        {
            if (validateFields()) {
                if(customers.ContainsKey(usernameField.Text)) {
                    if ((string)customers[usernameField.Text] == passwordField.Text)
                    {
                        var ratingPortal = new RatingPortal();
                        ratingPortal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong credentials");
                    }
                }
                else
                {
                    MessageBox.Show("There is no such user in the system");
                }
            }
            else
            {
                MessageBox.Show("Please provide proper input for credentials");
            }

        }

        private Boolean validateFields() {
            if (usernameField.Text != "" && usernameField.Text != null && passwordField.Text != "" && passwordField.Text != null) { 
                return true;
            }
            return false;
        }

        public void exitApp() {
            this.Close();
        }
    }
}

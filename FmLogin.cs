using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FmLogin : Form
    {
        string originalUsername = "admin";
        string originalPassword = "12345";
        public FmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text;
                string pwd = txtPassword.Text;

                if(username.Equals(originalUsername) && pwd.Equals(originalPassword))
                {
                    MessageBox.Show("login successful!");

                    // take user to the home page
                    FmHomePage homePage = new FmHomePage();
                    this.Hide();
                    homePage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid login credentials!");
                }


                lblLoginTime.Text = "You logged in at " + DateTime.Now.ToString("D");
                //MessageBox.Show("Button clicked!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! " + ex.Message);
            }
        }
    }
}

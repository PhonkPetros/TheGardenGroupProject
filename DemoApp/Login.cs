using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using Model;

namespace DemoApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            var authenticationLogic = new AuthenticationLogic();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                ShowMessage("Email and Password field is required.");
                return;
            }

            if (!IsValidEmail(email))
            {
                ShowMessage("Please enter a valid email address.");
                return;
            }

            Employee authenticatedEmployee = authenticationLogic.AuthenticateUser(email, authenticationLogic.GetHashPassword(password));

            if (authenticatedEmployee != null)
            {
                lblMessage.Visible = false;
                GotoNextView(authenticatedEmployee);
            }
            else
            {
                ShowMessage("Credential does not match with the record!");
            }
        }

        private void ShowMessage(String message)
        {
            lblMessage.Visible = true;
            lblMessage.Text = message;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void GotoNextView(Employee employee) //use it
        {
            this.Hide();
            Form home;
            home = new UserInterface(employee);
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

    }
}

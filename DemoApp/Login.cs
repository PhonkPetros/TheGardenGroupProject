using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Logic;
using Model;

namespace DemoApp
{
    public partial class Login : Form
    {
        private string resetCode;
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

        private void forgetPasswordBtn_Click(object sender, EventArgs e)
        {
            loginPanel.Hide();
            forgotPasswordPnl.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            forgetPasswordBtn.Hide();
        }

        private void SendCodeToEmail_Click(object sender, EventArgs e)
        {
            string emailInput = emailInputTxt.Text;

            var authenticationLogic = new AuthenticationLogic();

            Employee employeeEmail = authenticationLogic.AuthenticateEmail(emailInput);

            if (employeeEmail != null)
            {
                resetCode = GeneratePasswordResetCode();
                authenticationLogic.SendPasswordResetEmail(emailInput, resetCode);
                labelEmailCode.Text = "The code has been sent to the email";
            }
            else
            {
                labelEmailCode.Text = "Email does not exists"; //I could also say "The code has been sent to the email" for best security practice
            }
        }

        private void VerifyCode_Click(object sender, EventArgs e)
        {
            string codeInput = codeInputTxt.Text;

            if (codeInput == resetCode)
            {
            }
            else 
            {
                validInvalidCode.Text = "Invalid code";
            }
        }


        public string GeneratePasswordResetCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            char[] codeCharacters = new char[8]; 

            for (int i = 0; i < codeCharacters.Length; i++)
            {
                codeCharacters[i] = chars[random.Next(chars.Length)];
            }

            string code = new String(codeCharacters);
            return code;
        }

    }
}

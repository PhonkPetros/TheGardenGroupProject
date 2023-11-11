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
using DAL;

namespace DemoApp
{
    public partial class Login : Form
    {
        private string resetCode;

        private bool updateSuccess = false;

        private string userEmail;

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

        private void GotoNextView(Employee employee) 
        {
            this.Hide();
            Form home;
            home = new UserInterface(employee);
            home.Closed += (s, args) => this.Close();
            home.Show();
        }

        private void forgetPasswordBtn_Click(object sender, EventArgs e)
        {
            forgotPasswordPnl.Show();
            loginPanel.Hide();
            updatePasswordPnl.Hide();

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            updatePasswordPnl.Hide();
            forgotPasswordPnl.Hide();
        }

        private void SendCodeToEmail_Click(object sender, EventArgs e)
        {
            string emailInput = emailInputTxt.Text;

            if (emailInput != "")
            {
                var authenticationLogic = new AuthenticationLogic();

                Employee employeeEmail = authenticationLogic.AuthenticateEmail(emailInput);

                userEmail = employeeEmail.Email;

                if (employeeEmail != null)
                {
                    resetCode = GeneratePasswordResetCode();
                    authenticationLogic.SendPasswordResetEmail(emailInput, resetCode);
                    labelEmailCode.Text = "The code has been sent to the email";
                }
                else
                {
                    labelEmailCode.Text = "Email does not exists";
                }
            } else
            {
                labelEmailCode.Text = "Please enter email address";
            }
        }

        private void VerifyCode_Click(object sender, EventArgs e)
        {
            string codeInput = codeInputTxt.Text;

            if (codeInput == resetCode)
            {
                updatePasswordPnl.Show();
                loginPanel.Hide();
                forgotPasswordPnl.Hide();
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

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            loginPanel.Show();
            updatePasswordPnl.Hide();
            forgotPasswordPnl.Hide();
        }

        private void UpdatePasswordBtn_Click(object sender, EventArgs e)
        {
            if (passwordTextBoxInput.Text == confirmPasswordTextBoxInput.Text)
            {
                var authenticationLogic = new AuthenticationLogic();

                string newPassword = passwordTextBoxInput.Text;

                string hashedNewPassword = authenticationLogic.GetHashPassword(newPassword);

                updateSuccess = authenticationLogic.UpdatePassword(userEmail, hashedNewPassword);

                if (updateSuccess)
                {
                    loginPanel.Show();
                    updatePasswordPnl.Hide();
                    forgotPasswordPnl.Hide();
                }
                else
                {
                    passwordError.Text = "There was a problem updating your password. Please try again.";
                }
            }
            else
            {
                passwordError.Text = "Passwords do not match.";
            }
        }

    }
}

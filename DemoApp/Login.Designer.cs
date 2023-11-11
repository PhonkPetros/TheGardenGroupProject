namespace DemoApp
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.forgetPasswordBtn = new System.Windows.Forms.Button();
            this.forgotPasswordPnl = new System.Windows.Forms.Panel();
            this.validInvalidCode = new System.Windows.Forms.Label();
            this.labelEmailCode = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.VerifyCode = new System.Windows.Forms.Button();
            this.SendCodeToEmail = new System.Windows.Forms.Button();
            this.codeInputTxt = new System.Windows.Forms.TextBox();
            this.emailInputTxt = new System.Windows.Forms.TextBox();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.updatePasswordPnl = new System.Windows.Forms.Panel();
            this.passwordError = new System.Windows.Forms.Label();
            this.BackToLogin = new System.Windows.Forms.Button();
            this.UpdatePasswordBtn = new System.Windows.Forms.Button();
            this.confirmPassword = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.confirmPasswordTextBoxInput = new System.Windows.Forms.TextBox();
            this.passwordTextBoxInput = new System.Windows.Forms.TextBox();
            this.forgotPasswordPnl.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.updatePasswordPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(83)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(110, 229);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(185, 33);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "SIGN IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 180);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(185, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(110, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(107, 163);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(107, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(107, 98);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(111, 13);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "This is a test message";
            this.lblMessage.Visible = false;
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.Location = new System.Drawing.Point(128, 58);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(152, 39);
            this.lblLoginText.TabIndex = 17;
            this.lblLoginText.Text = "SIGN IN";
            // 
            // forgetPasswordBtn
            // 
            this.forgetPasswordBtn.Location = new System.Drawing.Point(181, 284);
            this.forgetPasswordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgetPasswordBtn.Name = "forgetPasswordBtn";
            this.forgetPasswordBtn.Size = new System.Drawing.Size(115, 24);
            this.forgetPasswordBtn.TabIndex = 19;
            this.forgetPasswordBtn.Text = "Forgoten password?";
            this.forgetPasswordBtn.UseVisualStyleBackColor = true;
            this.forgetPasswordBtn.Click += new System.EventHandler(this.forgetPasswordBtn_Click);
            // 
            // forgotPasswordPnl
            // 
            this.forgotPasswordPnl.Controls.Add(this.validInvalidCode);
            this.forgotPasswordPnl.Controls.Add(this.labelEmailCode);
            this.forgotPasswordPnl.Controls.Add(this.BackButton);
            this.forgotPasswordPnl.Controls.Add(this.VerifyCode);
            this.forgotPasswordPnl.Controls.Add(this.SendCodeToEmail);
            this.forgotPasswordPnl.Controls.Add(this.codeInputTxt);
            this.forgotPasswordPnl.Controls.Add(this.emailInputTxt);
            this.forgotPasswordPnl.Location = new System.Drawing.Point(0, 0);
            this.forgotPasswordPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.forgotPasswordPnl.Name = "forgotPasswordPnl";
            this.forgotPasswordPnl.Size = new System.Drawing.Size(432, 378);
            this.forgotPasswordPnl.TabIndex = 20;
            // 
            // validInvalidCode
            // 
            this.validInvalidCode.AutoSize = true;
            this.validInvalidCode.Location = new System.Drawing.Point(180, 201);
            this.validInvalidCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.validInvalidCode.Name = "validInvalidCode";
            this.validInvalidCode.Size = new System.Drawing.Size(0, 13);
            this.validInvalidCode.TabIndex = 26;
            // 
            // labelEmailCode
            // 
            this.labelEmailCode.AutoSize = true;
            this.labelEmailCode.Location = new System.Drawing.Point(180, 128);
            this.labelEmailCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailCode.Name = "labelEmailCode";
            this.labelEmailCode.Size = new System.Drawing.Size(0, 13);
            this.labelEmailCode.TabIndex = 25;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(9, 342);
            this.BackButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(80, 19);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // VerifyCode
            // 
            this.VerifyCode.Location = new System.Drawing.Point(182, 179);
            this.VerifyCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.VerifyCode.Name = "VerifyCode";
            this.VerifyCode.Size = new System.Drawing.Size(142, 19);
            this.VerifyCode.TabIndex = 23;
            this.VerifyCode.Text = "Verify code";
            this.VerifyCode.UseVisualStyleBackColor = true;
            this.VerifyCode.Click += new System.EventHandler(this.VerifyCode_Click);
            // 
            // SendCodeToEmail
            // 
            this.SendCodeToEmail.Location = new System.Drawing.Point(176, 100);
            this.SendCodeToEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SendCodeToEmail.Name = "SendCodeToEmail";
            this.SendCodeToEmail.Size = new System.Drawing.Size(148, 19);
            this.SendCodeToEmail.TabIndex = 22;
            this.SendCodeToEmail.Text = "Send code";
            this.SendCodeToEmail.UseVisualStyleBackColor = true;
            this.SendCodeToEmail.Click += new System.EventHandler(this.SendCodeToEmail_Click);
            // 
            // codeInputTxt
            // 
            this.codeInputTxt.Location = new System.Drawing.Point(182, 156);
            this.codeInputTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeInputTxt.Name = "codeInputTxt";
            this.codeInputTxt.Size = new System.Drawing.Size(144, 20);
            this.codeInputTxt.TabIndex = 21;
            // 
            // emailInputTxt
            // 
            this.emailInputTxt.Location = new System.Drawing.Point(60, 77);
            this.emailInputTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailInputTxt.Name = "emailInputTxt";
            this.emailInputTxt.Size = new System.Drawing.Size(265, 20);
            this.emailInputTxt.TabIndex = 20;
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.txtEmail);
            this.loginPanel.Controls.Add(this.forgetPasswordBtn);
            this.loginPanel.Controls.Add(this.lblEmail);
            this.loginPanel.Controls.Add(this.lblLoginText);
            this.loginPanel.Controls.Add(this.lblPassword);
            this.loginPanel.Controls.Add(this.lblMessage);
            this.loginPanel.Controls.Add(this.txtPassword);
            this.loginPanel.Controls.Add(this.btn_login);
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(432, 378);
            this.loginPanel.TabIndex = 21;
            // 
            // updatePasswordPnl
            // 
            this.updatePasswordPnl.Controls.Add(this.passwordError);
            this.updatePasswordPnl.Controls.Add(this.BackToLogin);
            this.updatePasswordPnl.Controls.Add(this.UpdatePasswordBtn);
            this.updatePasswordPnl.Controls.Add(this.confirmPassword);
            this.updatePasswordPnl.Controls.Add(this.password);
            this.updatePasswordPnl.Controls.Add(this.confirmPasswordTextBoxInput);
            this.updatePasswordPnl.Controls.Add(this.passwordTextBoxInput);
            this.updatePasswordPnl.Location = new System.Drawing.Point(0, 0);
            this.updatePasswordPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updatePasswordPnl.Name = "updatePasswordPnl";
            this.updatePasswordPnl.Size = new System.Drawing.Size(432, 378);
            this.updatePasswordPnl.TabIndex = 20;
            // 
            // passwordError
            // 
            this.passwordError.AutoSize = true;
            this.passwordError.Location = new System.Drawing.Point(124, 184);
            this.passwordError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(0, 13);
            this.passwordError.TabIndex = 6;
            // 
            // BackToLogin
            // 
            this.BackToLogin.Location = new System.Drawing.Point(122, 229);
            this.BackToLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackToLogin.Name = "BackToLogin";
            this.BackToLogin.Size = new System.Drawing.Size(56, 19);
            this.BackToLogin.TabIndex = 5;
            this.BackToLogin.Text = "Back";
            this.BackToLogin.UseVisualStyleBackColor = true;
            this.BackToLogin.Click += new System.EventHandler(this.BackToLogin_Click);
            // 
            // UpdatePasswordBtn
            // 
            this.UpdatePasswordBtn.Location = new System.Drawing.Point(122, 203);
            this.UpdatePasswordBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdatePasswordBtn.Name = "UpdatePasswordBtn";
            this.UpdatePasswordBtn.Size = new System.Drawing.Size(174, 19);
            this.UpdatePasswordBtn.TabIndex = 4;
            this.UpdatePasswordBtn.Text = "Update password";
            this.UpdatePasswordBtn.UseVisualStyleBackColor = true;
            this.UpdatePasswordBtn.Click += new System.EventHandler(this.UpdatePasswordBtn_Click);
            // 
            // confirmPassword
            // 
            this.confirmPassword.AutoSize = true;
            this.confirmPassword.Location = new System.Drawing.Point(32, 168);
            this.confirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(90, 13);
            this.confirmPassword.TabIndex = 3;
            this.confirmPassword.Text = "Confirm password";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(67, 131);
            this.password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // confirmPasswordTextBoxInput
            // 
            this.confirmPasswordTextBoxInput.Location = new System.Drawing.Point(122, 163);
            this.confirmPasswordTextBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.confirmPasswordTextBoxInput.Name = "confirmPasswordTextBoxInput";
            this.confirmPasswordTextBoxInput.Size = new System.Drawing.Size(175, 20);
            this.confirmPasswordTextBoxInput.TabIndex = 1;
            // 
            // passwordTextBoxInput
            // 
            this.passwordTextBoxInput.Location = new System.Drawing.Point(122, 128);
            this.passwordTextBoxInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBoxInput.Name = "passwordTextBoxInput";
            this.passwordTextBoxInput.Size = new System.Drawing.Size(175, 20);
            this.passwordTextBoxInput.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 378);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.forgotPasswordPnl);
            this.Controls.Add(this.updatePasswordPnl);
            this.Name = "Login";
            this.Text = "Login";
            this.forgotPasswordPnl.ResumeLayout(false);
            this.forgotPasswordPnl.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.updatePasswordPnl.ResumeLayout(false);
            this.updatePasswordPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblLoginText;
        private System.Windows.Forms.Button forgetPasswordBtn;
        private System.Windows.Forms.Panel forgotPasswordPnl;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox codeInputTxt;
        private System.Windows.Forms.TextBox emailInputTxt;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button VerifyCode;
        private System.Windows.Forms.Button SendCodeToEmail;
        private System.Windows.Forms.Label labelEmailCode;
        private System.Windows.Forms.Label validInvalidCode;
        private System.Windows.Forms.Panel updatePasswordPnl;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Button BackToLogin;
        private System.Windows.Forms.Button UpdatePasswordBtn;
        private System.Windows.Forms.Label confirmPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox confirmPasswordTextBoxInput;
        private System.Windows.Forms.TextBox passwordTextBoxInput;
    }
}
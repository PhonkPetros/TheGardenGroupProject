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
            this.chbxRemember = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblLoginText = new System.Windows.Forms.Label();
            this.forgetPasswordBtn = new System.Windows.Forms.Button();
            this.forgotPasswordPnl = new System.Windows.Forms.Panel();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.emailInputTxt = new System.Windows.Forms.TextBox();
            this.codeInputTxt = new System.Windows.Forms.TextBox();
            this.SendCodeToEmail = new System.Windows.Forms.Button();
            this.VerifyCode = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.labelEmailCode = new System.Windows.Forms.Label();
            this.validInvalidCode = new System.Windows.Forms.Label();
            this.forgotPasswordPnl.SuspendLayout();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbxRemember
            // 
            this.chbxRemember.AutoSize = true;
            this.chbxRemember.Location = new System.Drawing.Point(147, 255);
            this.chbxRemember.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbxRemember.Name = "chbxRemember";
            this.chbxRemember.Size = new System.Drawing.Size(119, 20);
            this.chbxRemember.TabIndex = 15;
            this.chbxRemember.Text = "Remember me";
            this.chbxRemember.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(136)))), ((int)(((byte)(83)))));
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(147, 302);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(247, 41);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "SIGN IN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(147, 221);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(245, 22);
            this.txtPassword.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 168);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(143, 201);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 16);
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(143, 148);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(143, 120);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(141, 16);
            this.lblMessage.TabIndex = 16;
            this.lblMessage.Text = "This is a test message";
            this.lblMessage.Visible = false;
            // 
            // lblLoginText
            // 
            this.lblLoginText.AutoSize = true;
            this.lblLoginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginText.Location = new System.Drawing.Point(170, 72);
            this.lblLoginText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoginText.Name = "lblLoginText";
            this.lblLoginText.Size = new System.Drawing.Size(183, 48);
            this.lblLoginText.TabIndex = 17;
            this.lblLoginText.Text = "SIGN IN";
            // 
            // forgetPasswordBtn
            // 
            this.forgetPasswordBtn.Location = new System.Drawing.Point(241, 350);
            this.forgetPasswordBtn.Name = "forgetPasswordBtn";
            this.forgetPasswordBtn.Size = new System.Drawing.Size(153, 29);
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
            this.forgotPasswordPnl.Name = "forgotPasswordPnl";
            this.forgotPasswordPnl.Size = new System.Drawing.Size(576, 465);
            this.forgotPasswordPnl.TabIndex = 20;
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
            this.loginPanel.Controls.Add(this.chbxRemember);
            this.loginPanel.Controls.Add(this.btn_login);
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(576, 465);
            this.loginPanel.TabIndex = 21;
            // 
            // emailInputTxt
            // 
            this.emailInputTxt.Location = new System.Drawing.Point(80, 95);
            this.emailInputTxt.Name = "emailInputTxt";
            this.emailInputTxt.Size = new System.Drawing.Size(352, 22);
            this.emailInputTxt.TabIndex = 20;
            // 
            // codeInputTxt
            // 
            this.codeInputTxt.Location = new System.Drawing.Point(242, 192);
            this.codeInputTxt.Name = "codeInputTxt";
            this.codeInputTxt.Size = new System.Drawing.Size(190, 22);
            this.codeInputTxt.TabIndex = 21;
            // 
            // SendCodeToEmail
            // 
            this.SendCodeToEmail.Location = new System.Drawing.Point(234, 123);
            this.SendCodeToEmail.Name = "SendCodeToEmail";
            this.SendCodeToEmail.Size = new System.Drawing.Size(198, 23);
            this.SendCodeToEmail.TabIndex = 22;
            this.SendCodeToEmail.Text = "Send code";
            this.SendCodeToEmail.UseVisualStyleBackColor = true;
            this.SendCodeToEmail.Click += new System.EventHandler(this.SendCodeToEmail_Click);
            // 
            // VerifyCode
            // 
            this.VerifyCode.Location = new System.Drawing.Point(242, 220);
            this.VerifyCode.Name = "VerifyCode";
            this.VerifyCode.Size = new System.Drawing.Size(190, 23);
            this.VerifyCode.TabIndex = 23;
            this.VerifyCode.Text = "Verify code";
            this.VerifyCode.UseVisualStyleBackColor = true;
            this.VerifyCode.Click += new System.EventHandler(this.VerifyCode_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(12, 421);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(106, 23);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // labelEmailCode
            // 
            this.labelEmailCode.AutoSize = true;
            this.labelEmailCode.Location = new System.Drawing.Point(240, 158);
            this.labelEmailCode.Name = "labelEmailCode";
            this.labelEmailCode.Size = new System.Drawing.Size(0, 16);
            this.labelEmailCode.TabIndex = 25;
            // 
            // validInvalidCode
            // 
            this.validInvalidCode.AutoSize = true;
            this.validInvalidCode.Location = new System.Drawing.Point(240, 247);
            this.validInvalidCode.Name = "validInvalidCode";
            this.validInvalidCode.Size = new System.Drawing.Size(0, 16);
            this.validInvalidCode.TabIndex = 26;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 465);
            this.Controls.Add(this.forgotPasswordPnl);
            this.Controls.Add(this.loginPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.forgotPasswordPnl.ResumeLayout(false);
            this.forgotPasswordPnl.PerformLayout();
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chbxRemember;
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
    }
}
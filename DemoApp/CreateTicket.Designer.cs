namespace DemoApp
{
    partial class CreateTicket
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
            this.lblDateOfReport = new System.Windows.Forms.Label();
            this.lblSubjectofIncedent = new System.Windows.Forms.Label();
            this.lblTypeOfIncident = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitTicket = new System.Windows.Forms.Button();
            this.txtSubjectOfIncident = new System.Windows.Forms.TextBox();
            this.comboBoxTypeOfIncident = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.richTxtDescription = new System.Windows.Forms.RichTextBox();
            this.dateTimePickerDeadline = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateReeported = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblDateOfReport
            // 
            this.lblDateOfReport.AutoSize = true;
            this.lblDateOfReport.Location = new System.Drawing.Point(38, 77);
            this.lblDateOfReport.Name = "lblDateOfReport";
            this.lblDateOfReport.Size = new System.Drawing.Size(99, 13);
            this.lblDateOfReport.TabIndex = 0;
            this.lblDateOfReport.Text = "Date/time reported:";
            // 
            // lblSubjectofIncedent
            // 
            this.lblSubjectofIncedent.AutoSize = true;
            this.lblSubjectofIncedent.Location = new System.Drawing.Point(38, 111);
            this.lblSubjectofIncedent.Name = "lblSubjectofIncedent";
            this.lblSubjectofIncedent.Size = new System.Drawing.Size(99, 13);
            this.lblSubjectofIncedent.TabIndex = 1;
            this.lblSubjectofIncedent.Text = "Subject of Incident:";
            // 
            // lblTypeOfIncident
            // 
            this.lblTypeOfIncident.AutoSize = true;
            this.lblTypeOfIncident.Location = new System.Drawing.Point(38, 146);
            this.lblTypeOfIncident.Name = "lblTypeOfIncident";
            this.lblTypeOfIncident.Size = new System.Drawing.Size(87, 13);
            this.lblTypeOfIncident.TabIndex = 2;
            this.lblTypeOfIncident.Text = "Type of Incident:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(38, 183);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(44, 13);
            this.lblPriority.TabIndex = 4;
            this.lblPriority.Text = "Priority: ";
            this.lblPriority.Click += new System.EventHandler(this.lblPriority_Click);
            // 
            // lblDeadline
            // 
            this.lblDeadline.AutoSize = true;
            this.lblDeadline.Location = new System.Drawing.Point(38, 220);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(99, 13);
            this.lblDeadline.TabIndex = 5;
            this.lblDeadline.Text = "Deadline/follow up:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(38, 256);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(66, 13);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description: ";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(191, 404);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitTicket
            // 
            this.btnSubmitTicket.Location = new System.Drawing.Point(363, 404);
            this.btnSubmitTicket.Name = "btnSubmitTicket";
            this.btnSubmitTicket.Size = new System.Drawing.Size(125, 23);
            this.btnSubmitTicket.TabIndex = 8;
            this.btnSubmitTicket.Text = "SUBMIT  TICKET";
            this.btnSubmitTicket.UseVisualStyleBackColor = true;
            this.btnSubmitTicket.Click += new System.EventHandler(this.btnSubmitTicket_Click);
            // 
            // txtSubjectOfIncident
            // 
            this.txtSubjectOfIncident.Location = new System.Drawing.Point(191, 108);
            this.txtSubjectOfIncident.Name = "txtSubjectOfIncident";
            this.txtSubjectOfIncident.Size = new System.Drawing.Size(297, 20);
            this.txtSubjectOfIncident.TabIndex = 9;
            // 
            // comboBoxTypeOfIncident
            // 
            this.comboBoxTypeOfIncident.FormattingEnabled = true;
            this.comboBoxTypeOfIncident.Items.AddRange(new object[] {
            "Software",
            "Hardware",
            "Service"});
            this.comboBoxTypeOfIncident.Location = new System.Drawing.Point(191, 143);
            this.comboBoxTypeOfIncident.Name = "comboBoxTypeOfIncident";
            this.comboBoxTypeOfIncident.Size = new System.Drawing.Size(297, 21);
            this.comboBoxTypeOfIncident.TabIndex = 10;
            this.comboBoxTypeOfIncident.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DisplayMember = "High";
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "High",
            "Normal",
            "Low"});
            this.comboBoxPriority.Location = new System.Drawing.Point(191, 184);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(297, 21);
            this.comboBoxPriority.TabIndex = 11;
            // 
            // richTxtDescription
            // 
            this.richTxtDescription.Location = new System.Drawing.Point(191, 256);
            this.richTxtDescription.Name = "richTxtDescription";
            this.richTxtDescription.Size = new System.Drawing.Size(297, 128);
            this.richTxtDescription.TabIndex = 12;
            this.richTxtDescription.Text = "";
            // 
            // dateTimePickerDeadline
            // 
            this.dateTimePickerDeadline.Location = new System.Drawing.Point(191, 220);
            this.dateTimePickerDeadline.Name = "dateTimePickerDeadline";
            this.dateTimePickerDeadline.Size = new System.Drawing.Size(297, 20);
            this.dateTimePickerDeadline.TabIndex = 13;
            // 
            // dateTimePickerDateReeported
            // 
            this.dateTimePickerDateReeported.Location = new System.Drawing.Point(191, 77);
            this.dateTimePickerDateReeported.Name = "dateTimePickerDateReeported";
            this.dateTimePickerDateReeported.Size = new System.Drawing.Size(297, 20);
            this.dateTimePickerDateReeported.TabIndex = 14;
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 460);
            this.Controls.Add(this.dateTimePickerDateReeported);
            this.Controls.Add(this.dateTimePickerDeadline);
            this.Controls.Add(this.richTxtDescription);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxTypeOfIncident);
            this.Controls.Add(this.txtSubjectOfIncident);
            this.Controls.Add(this.btnSubmitTicket);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblTypeOfIncident);
            this.Controls.Add(this.lblSubjectofIncedent);
            this.Controls.Add(this.lblDateOfReport);
            this.Name = "CreateTicket";
            this.Text = "CreateTicket";
            this.Load += new System.EventHandler(this.CreateTicket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDateOfReport;
        private System.Windows.Forms.Label lblSubjectofIncedent;
        private System.Windows.Forms.Label lblTypeOfIncident;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitTicket;
        private System.Windows.Forms.TextBox txtSubjectOfIncident;
        private System.Windows.Forms.ComboBox comboBoxTypeOfIncident;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.RichTextBox richTxtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeadline;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateReeported;
    }
}
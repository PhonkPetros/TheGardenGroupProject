namespace DemoApp
{
    partial class UserInterface
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
            this.employeePanel = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.incidentBtn = new System.Windows.Forms.Button();
            this.dashBoardBtn = new System.Windows.Forms.Button();
            this.dashboardPnl = new System.Windows.Forms.Panel();
            this.loadDataToList = new System.Windows.Forms.Button();
            this.ticketView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CreateTicketPanel = new System.Windows.Forms.Panel();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.deadlineComboBox = new System.Windows.Forms.ComboBox();
            this.deadlineLabel = new System.Windows.Forms.Label();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.priorityComboBox = new System.Windows.Forms.ComboBox();
            this.reportedByLabel = new System.Windows.Forms.Label();
            this.reportedByComboBox = new System.Windows.Forms.ComboBox();
            this.incidentTypeLabel = new System.Windows.Forms.Label();
            this.incidentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.dateReportedLabel = new System.Windows.Forms.Label();
            this.ticketDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.createTicketLabel = new System.Windows.Forms.Label();
            this.btnSubmit2 = new System.Windows.Forms.Button();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.txtDescription2 = new System.Windows.Forms.TextBox();
            this.lblDescription2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblDeadline2 = new System.Windows.Forms.Label();
            this.lblPriority2 = new System.Windows.Forms.Label();
            this.comboBoxPriority2 = new System.Windows.Forms.ComboBox();
            this.lblTypeOfIncident2 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfIncident2 = new System.Windows.Forms.ComboBox();
            this.lblSubjOfIncident = new System.Windows.Forms.Label();
            this.txtSubject2 = new System.Windows.Forms.TextBox();
            this.lblDateReported2 = new System.Windows.Forms.Label();
            this.dateTimePickerReported2 = new System.Windows.Forms.DateTimePicker();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlCreateTicketEmployee = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.employeePanel.SuspendLayout();
            this.dashboardPnl.SuspendLayout();
            this.CreateTicketPanel.SuspendLayout();
            this.pnlCreateTicketEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.userBtn);
            this.employeePanel.Controls.Add(this.incidentBtn);
            this.employeePanel.Controls.Add(this.dashBoardBtn);
            this.employeePanel.Controls.Add(this.dashboardPnl);
            this.employeePanel.Location = new System.Drawing.Point(2, 1);
            this.employeePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(622, 499);
            this.employeePanel.TabIndex = 0;
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(351, 15);
            this.userBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(104, 19);
            this.userBtn.TabIndex = 3;
            this.userBtn.Text = "User managment";
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // incidentBtn
            // 
            this.incidentBtn.Location = new System.Drawing.Point(233, 15);
            this.incidentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidentBtn.Name = "incidentBtn";
            this.incidentBtn.Size = new System.Drawing.Size(113, 19);
            this.incidentBtn.TabIndex = 2;
            this.incidentBtn.Text = "Incident managment";
            this.incidentBtn.UseVisualStyleBackColor = true;
            // 
            // dashBoardBtn
            // 
            this.dashBoardBtn.Location = new System.Drawing.Point(111, 15);
            this.dashBoardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashBoardBtn.Name = "dashBoardBtn";
            this.dashBoardBtn.Size = new System.Drawing.Size(118, 19);
            this.dashBoardBtn.TabIndex = 1;
            this.dashBoardBtn.Text = "Dashboard";
            this.dashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardPnl
            // 
            this.dashboardPnl.Controls.Add(this.loadDataToList);
            this.dashboardPnl.Controls.Add(this.ticketView);
            this.dashboardPnl.Location = new System.Drawing.Point(0, 0);
            this.dashboardPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardPnl.Name = "dashboardPnl";
            this.dashboardPnl.Size = new System.Drawing.Size(622, 496);
            this.dashboardPnl.TabIndex = 4;
            // 
            // loadDataToList
            // 
            this.loadDataToList.Location = new System.Drawing.Point(165, 426);
            this.loadDataToList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loadDataToList.Name = "loadDataToList";
            this.loadDataToList.Size = new System.Drawing.Size(56, 19);
            this.loadDataToList.TabIndex = 0;
            this.loadDataToList.Text = "load date";
            this.loadDataToList.UseVisualStyleBackColor = true;
            this.loadDataToList.Click += new System.EventHandler(this.loadDataToList_Click);
            // 
            // ticketView
            // 
            this.ticketView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ticketView.GridLines = true;
            this.ticketView.HideSelection = false;
            this.ticketView.Location = new System.Drawing.Point(111, 38);
            this.ticketView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketView.Name = "ticketView";
            this.ticketView.Size = new System.Drawing.Size(474, 383);
            this.ticketView.TabIndex = 0;
            this.ticketView.UseCompatibleStateImageBehavior = false;
            this.ticketView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Subject";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "User";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Date";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Status";
            this.columnHeader5.Width = 100;
            // 
            // CreateTicketPanel
            // 
            this.CreateTicketPanel.Controls.Add(this.pnlCreateTicketEmployee);
            this.CreateTicketPanel.Controls.Add(this.submitButton);
            this.CreateTicketPanel.Controls.Add(this.cancelButton);
            this.CreateTicketPanel.Controls.Add(this.descriptionTextBox);
            this.CreateTicketPanel.Controls.Add(this.descriptionLabel);
            this.CreateTicketPanel.Controls.Add(this.deadlineComboBox);
            this.CreateTicketPanel.Controls.Add(this.deadlineLabel);
            this.CreateTicketPanel.Controls.Add(this.priorityLabel);
            this.CreateTicketPanel.Controls.Add(this.priorityComboBox);
            this.CreateTicketPanel.Controls.Add(this.reportedByLabel);
            this.CreateTicketPanel.Controls.Add(this.reportedByComboBox);
            this.CreateTicketPanel.Controls.Add(this.incidentTypeLabel);
            this.CreateTicketPanel.Controls.Add(this.incidentTypeComboBox);
            this.CreateTicketPanel.Controls.Add(this.subjectLabel);
            this.CreateTicketPanel.Controls.Add(this.subjectTextBox);
            this.CreateTicketPanel.Controls.Add(this.dateReportedLabel);
            this.CreateTicketPanel.Controls.Add(this.ticketDateTimePicker);
            this.CreateTicketPanel.Controls.Add(this.createTicketLabel);
            this.CreateTicketPanel.Location = new System.Drawing.Point(0, 0);
            this.CreateTicketPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateTicketPanel.Name = "CreateTicketPanel";
            this.CreateTicketPanel.Size = new System.Drawing.Size(620, 499);
            this.CreateTicketPanel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(396, 453);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(91, 33);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit Ticket";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(250, 453);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(96, 33);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(250, 292);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(237, 133);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(113, 292);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deadlineComboBox
            // 
            this.deadlineComboBox.FormattingEnabled = true;
            this.deadlineComboBox.Location = new System.Drawing.Point(250, 252);
            this.deadlineComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deadlineComboBox.Name = "deadlineComboBox";
            this.deadlineComboBox.Size = new System.Drawing.Size(237, 21);
            this.deadlineComboBox.TabIndex = 12;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLabel.Location = new System.Drawing.Point(113, 255);
            this.deadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(127, 17);
            this.deadlineLabel.TabIndex = 11;
            this.deadlineLabel.Text = "Deadline/follow up:";
            this.deadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(113, 223);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(56, 17);
            this.priorityLabel.TabIndex = 10;
            this.priorityLabel.Text = "Priority:";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(250, 219);
            this.priorityComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(237, 21);
            this.priorityComboBox.TabIndex = 9;
            // 
            // reportedByLabel
            // 
            this.reportedByLabel.AutoSize = true;
            this.reportedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportedByLabel.Location = new System.Drawing.Point(113, 190);
            this.reportedByLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reportedByLabel.Name = "reportedByLabel";
            this.reportedByLabel.Size = new System.Drawing.Size(122, 17);
            this.reportedByLabel.TabIndex = 8;
            this.reportedByLabel.Text = "Reported by user:";
            this.reportedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportedByLabel.Click += new System.EventHandler(this.reportedByLabel_Click);
            // 
            // reportedByComboBox
            // 
            this.reportedByComboBox.FormattingEnabled = true;
            this.reportedByComboBox.Location = new System.Drawing.Point(250, 187);
            this.reportedByComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportedByComboBox.Name = "reportedByComboBox";
            this.reportedByComboBox.Size = new System.Drawing.Size(237, 21);
            this.reportedByComboBox.TabIndex = 7;
            // 
            // incidentTypeLabel
            // 
            this.incidentTypeLabel.AutoSize = true;
            this.incidentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentTypeLabel.Location = new System.Drawing.Point(113, 158);
            this.incidentTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.incidentTypeLabel.Name = "incidentTypeLabel";
            this.incidentTypeLabel.Size = new System.Drawing.Size(113, 17);
            this.incidentTypeLabel.TabIndex = 6;
            this.incidentTypeLabel.Text = "Type of incident:";
            this.incidentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incidentTypeComboBox
            // 
            this.incidentTypeComboBox.FormattingEnabled = true;
            this.incidentTypeComboBox.Location = new System.Drawing.Point(250, 154);
            this.incidentTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidentTypeComboBox.Name = "incidentTypeComboBox";
            this.incidentTypeComboBox.Size = new System.Drawing.Size(237, 21);
            this.incidentTypeComboBox.TabIndex = 5;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(105, 125);
            this.subjectLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(152, 17);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject of the incident:";
            this.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(250, 122);
            this.subjectTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(237, 20);
            this.subjectTextBox.TabIndex = 3;
            // 
            // dateReportedLabel
            // 
            this.dateReportedLabel.AutoSize = true;
            this.dateReportedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReportedLabel.Location = new System.Drawing.Point(105, 92);
            this.dateReportedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateReportedLabel.Name = "dateReportedLabel";
            this.dateReportedLabel.Size = new System.Drawing.Size(130, 17);
            this.dateReportedLabel.TabIndex = 2;
            this.dateReportedLabel.Text = "Date/time reported:";
            this.dateReportedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateReportedLabel.Click += new System.EventHandler(this.dateReportedLabel_Click);
            // 
            // ticketDateTimePicker
            // 
            this.ticketDateTimePicker.Location = new System.Drawing.Point(250, 89);
            this.ticketDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketDateTimePicker.Name = "ticketDateTimePicker";
            this.ticketDateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.ticketDateTimePicker.TabIndex = 1;
            // 
            // createTicketLabel
            // 
            this.createTicketLabel.AutoSize = true;
            this.createTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTicketLabel.Location = new System.Drawing.Point(111, 46);
            this.createTicketLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createTicketLabel.Name = "createTicketLabel";
            this.createTicketLabel.Size = new System.Drawing.Size(352, 31);
            this.createTicketLabel.TabIndex = 0;
            this.createTicketLabel.Text = "Create new incident ticket";
            // 
            // btnSubmit2
            // 
            this.btnSubmit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit2.Location = new System.Drawing.Point(396, 453);
            this.btnSubmit2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit2.Name = "btnSubmit2";
            this.btnSubmit2.Size = new System.Drawing.Size(91, 33);
            this.btnSubmit2.TabIndex = 16;
            this.btnSubmit2.Text = "Submit Ticket";
            this.btnSubmit2.UseVisualStyleBackColor = true;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel2.Location = new System.Drawing.Point(250, 453);
            this.btnCancel2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(96, 33);
            this.btnCancel2.TabIndex = 15;
            this.btnCancel2.Text = "Cancel";
            this.btnCancel2.UseVisualStyleBackColor = true;
            // 
            // txtDescription2
            // 
            this.txtDescription2.Location = new System.Drawing.Point(250, 292);
            this.txtDescription2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription2.Multiline = true;
            this.txtDescription2.Name = "txtDescription2";
            this.txtDescription2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription2.Size = new System.Drawing.Size(237, 133);
            this.txtDescription2.TabIndex = 14;
            // 
            // lblDescription2
            // 
            this.lblDescription2.AutoSize = true;
            this.lblDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription2.Location = new System.Drawing.Point(113, 292);
            this.lblDescription2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription2.Name = "lblDescription2";
            this.lblDescription2.Size = new System.Drawing.Size(83, 17);
            this.lblDescription2.TabIndex = 13;
            this.lblDescription2.Text = "Description:";
            this.lblDescription2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 252);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // lblDeadline2
            // 
            this.lblDeadline2.AutoSize = true;
            this.lblDeadline2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline2.Location = new System.Drawing.Point(113, 255);
            this.lblDeadline2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeadline2.Name = "lblDeadline2";
            this.lblDeadline2.Size = new System.Drawing.Size(127, 17);
            this.lblDeadline2.TabIndex = 11;
            this.lblDeadline2.Text = "Deadline/follow up:";
            this.lblDeadline2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPriority2
            // 
            this.lblPriority2.AutoSize = true;
            this.lblPriority2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority2.Location = new System.Drawing.Point(113, 223);
            this.lblPriority2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPriority2.Name = "lblPriority2";
            this.lblPriority2.Size = new System.Drawing.Size(56, 17);
            this.lblPriority2.TabIndex = 10;
            this.lblPriority2.Text = "Priority:";
            this.lblPriority2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxPriority2
            // 
            this.comboBoxPriority2.FormattingEnabled = true;
            this.comboBoxPriority2.Location = new System.Drawing.Point(250, 219);
            this.comboBoxPriority2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPriority2.Name = "comboBoxPriority2";
            this.comboBoxPriority2.Size = new System.Drawing.Size(237, 21);
            this.comboBoxPriority2.TabIndex = 9;
            // 
            // lblTypeOfIncident2
            // 
            this.lblTypeOfIncident2.AutoSize = true;
            this.lblTypeOfIncident2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfIncident2.Location = new System.Drawing.Point(113, 158);
            this.lblTypeOfIncident2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTypeOfIncident2.Name = "lblTypeOfIncident2";
            this.lblTypeOfIncident2.Size = new System.Drawing.Size(113, 17);
            this.lblTypeOfIncident2.TabIndex = 6;
            this.lblTypeOfIncident2.Text = "Type of incident:";
            this.lblTypeOfIncident2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxTypeOfIncident2
            // 
            this.comboBoxTypeOfIncident2.FormattingEnabled = true;
            this.comboBoxTypeOfIncident2.Location = new System.Drawing.Point(250, 154);
            this.comboBoxTypeOfIncident2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTypeOfIncident2.Name = "comboBoxTypeOfIncident2";
            this.comboBoxTypeOfIncident2.Size = new System.Drawing.Size(237, 21);
            this.comboBoxTypeOfIncident2.TabIndex = 5;
            // 
            // lblSubjOfIncident
            // 
            this.lblSubjOfIncident.AutoSize = true;
            this.lblSubjOfIncident.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjOfIncident.Location = new System.Drawing.Point(105, 125);
            this.lblSubjOfIncident.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubjOfIncident.Name = "lblSubjOfIncident";
            this.lblSubjOfIncident.Size = new System.Drawing.Size(152, 17);
            this.lblSubjOfIncident.TabIndex = 4;
            this.lblSubjOfIncident.Text = "Subject of the incident:";
            this.lblSubjOfIncident.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSubject2
            // 
            this.txtSubject2.Location = new System.Drawing.Point(250, 122);
            this.txtSubject2.Margin = new System.Windows.Forms.Padding(2);
            this.txtSubject2.Name = "txtSubject2";
            this.txtSubject2.Size = new System.Drawing.Size(237, 20);
            this.txtSubject2.TabIndex = 3;
            // 
            // lblDateReported2
            // 
            this.lblDateReported2.AutoSize = true;
            this.lblDateReported2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReported2.Location = new System.Drawing.Point(105, 92);
            this.lblDateReported2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateReported2.Name = "lblDateReported2";
            this.lblDateReported2.Size = new System.Drawing.Size(130, 17);
            this.lblDateReported2.TabIndex = 2;
            this.lblDateReported2.Text = "Date/time reported:";
            this.lblDateReported2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePickerReported2
            // 
            this.dateTimePickerReported2.Location = new System.Drawing.Point(250, 89);
            this.dateTimePickerReported2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerReported2.Name = "dateTimePickerReported2";
            this.dateTimePickerReported2.Size = new System.Drawing.Size(237, 20);
            this.dateTimePickerReported2.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(111, 46);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(352, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Create new incident ticket";
            // 
            // pnlCreateTicketEmployee
            // 
            this.pnlCreateTicketEmployee.Controls.Add(this.btnSubmit2);
            this.pnlCreateTicketEmployee.Controls.Add(this.btnCancel2);
            this.pnlCreateTicketEmployee.Controls.Add(this.txtDescription2);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblDescription2);
            this.pnlCreateTicketEmployee.Controls.Add(this.comboBox1);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblDeadline2);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblPriority2);
            this.pnlCreateTicketEmployee.Controls.Add(this.comboBoxPriority2);
            this.pnlCreateTicketEmployee.Controls.Add(this.label8);
            this.pnlCreateTicketEmployee.Controls.Add(this.comboBox4);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblTypeOfIncident2);
            this.pnlCreateTicketEmployee.Controls.Add(this.comboBoxTypeOfIncident2);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblSubjOfIncident);
            this.pnlCreateTicketEmployee.Controls.Add(this.txtSubject2);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblDateReported2);
            this.pnlCreateTicketEmployee.Controls.Add(this.dateTimePickerReported2);
            this.pnlCreateTicketEmployee.Controls.Add(this.lblHeader);
            this.pnlCreateTicketEmployee.Location = new System.Drawing.Point(2, 0);
            this.pnlCreateTicketEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.pnlCreateTicketEmployee.Name = "pnlCreateTicketEmployee";
            this.pnlCreateTicketEmployee.Size = new System.Drawing.Size(620, 499);
            this.pnlCreateTicketEmployee.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 190);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Reported by user:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(250, 187);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(237, 21);
            this.comboBox4.TabIndex = 7;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 498);
            this.Controls.Add(this.CreateTicketPanel);
            this.Controls.Add(this.employeePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInterface";
            this.Text = "User Interface";
            this.employeePanel.ResumeLayout(false);
            this.dashboardPnl.ResumeLayout(false);
            this.CreateTicketPanel.ResumeLayout(false);
            this.CreateTicketPanel.PerformLayout();
            this.pnlCreateTicketEmployee.ResumeLayout(false);
            this.pnlCreateTicketEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel employeePanel;
        private System.Windows.Forms.ListView ticketView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button incidentBtn;
        private System.Windows.Forms.Button dashBoardBtn;
        private System.Windows.Forms.Panel dashboardPnl;
        private System.Windows.Forms.Button loadDataToList;
        private System.Windows.Forms.Panel CreateTicketPanel;
        private System.Windows.Forms.DateTimePicker ticketDateTimePicker;
        private System.Windows.Forms.Label createTicketLabel;
        private System.Windows.Forms.Label incidentTypeLabel;
        private System.Windows.Forms.ComboBox incidentTypeComboBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label dateReportedLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.ComboBox deadlineComboBox;
        private System.Windows.Forms.Label deadlineLabel;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.ComboBox priorityComboBox;
        private System.Windows.Forms.Label reportedByLabel;
        private System.Windows.Forms.ComboBox reportedByComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel pnlCreateTicketEmployee;
        private System.Windows.Forms.Button btnSubmit2;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.TextBox txtDescription2;
        private System.Windows.Forms.Label lblDescription2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblDeadline2;
        private System.Windows.Forms.Label lblPriority2;
        private System.Windows.Forms.ComboBox comboBoxPriority2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label lblTypeOfIncident2;
        private System.Windows.Forms.ComboBox comboBoxTypeOfIncident2;
        private System.Windows.Forms.Label lblSubjOfIncident;
        private System.Windows.Forms.TextBox txtSubject2;
        private System.Windows.Forms.Label lblDateReported2;
        private System.Windows.Forms.DateTimePicker dateTimePickerReported2;
        private System.Windows.Forms.Label lblHeader;
    }
}
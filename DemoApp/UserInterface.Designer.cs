﻿namespace DemoApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.employeePanel = new System.Windows.Forms.Panel();
            this.userBtn = new System.Windows.Forms.Button();
            this.incidentBtn = new System.Windows.Forms.Button();
            this.dashBoardBtn = new System.Windows.Forms.Button();
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.editTicketPanel = new System.Windows.Forms.Panel();
            this.incidentTypeEditComboBox = new System.Windows.Forms.ComboBox();
            this.incidentTypeEditLabel = new System.Windows.Forms.Label();
            this.descriptionEditTextbox = new System.Windows.Forms.TextBox();
            this.descriptionEditLabel = new System.Windows.Forms.Label();
            this.deadlineEditDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.deadlineEditLabel = new System.Windows.Forms.Label();
            this.statusEditComboBox = new System.Windows.Forms.ComboBox();
            this.priorityEditComboBox = new System.Windows.Forms.ComboBox();
            this.priorityEditLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.submitEditButton = new System.Windows.Forms.Button();
            this.editTicketListView = new System.Windows.Forms.ListView();
            this.loadDataToList = new System.Windows.Forms.Button();
            this.ticketView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createTicketPanel = new System.Windows.Forms.Panel();
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
            this.btnIncidentManagment = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.ticketCount = new System.Windows.Forms.Label();
            this.incidentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ticketViewPanel = new System.Windows.Forms.Panel();
            this.incidentManagamentUIbtn = new System.Windows.Forms.Button();
            this.dashBoardTickeUI = new System.Windows.Forms.Button();
            this.lblUpdateTicket = new System.Windows.Forms.Label();
            this.employeePanel.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            this.editTicketPanel.SuspendLayout();
            this.createTicketPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).BeginInit();
            this.ticketViewPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.userBtn);
            this.employeePanel.Controls.Add(this.incidentBtn);
            this.employeePanel.Controls.Add(this.dashBoardBtn);
            this.employeePanel.Location = new System.Drawing.Point(2, 1);
            this.employeePanel.Name = "employeePanel";
            this.employeePanel.Size = new System.Drawing.Size(830, 614);
            this.employeePanel.TabIndex = 0;
            // 
            // userBtn
            // 
            this.userBtn.Location = new System.Drawing.Point(468, 18);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(138, 23);
            this.userBtn.TabIndex = 3;
            this.userBtn.Text = "User managment";
            this.userBtn.UseVisualStyleBackColor = true;
            // 
            // incidentBtn
            // 
            this.incidentBtn.Location = new System.Drawing.Point(311, 18);
            this.incidentBtn.Name = "incidentBtn";
            this.incidentBtn.Size = new System.Drawing.Size(151, 23);
            this.incidentBtn.TabIndex = 2;
            this.incidentBtn.Text = "Incident managment";
            this.incidentBtn.UseVisualStyleBackColor = true;
            // 
            // dashBoardBtn
            // 
            this.dashBoardBtn.Location = new System.Drawing.Point(148, 18);
            this.dashBoardBtn.Name = "dashBoardBtn";
            this.dashBoardBtn.Size = new System.Drawing.Size(157, 23);
            this.dashBoardBtn.TabIndex = 1;
            this.dashBoardBtn.Text = "Dashboard";
            this.dashBoardBtn.UseVisualStyleBackColor = true;
            // 
            // dashBoardPanel
            // 
            this.dashBoardPanel.Controls.Add(this.editTicketPanel);
            this.dashBoardPanel.Controls.Add(this.btnIncidentManagment);
            this.dashBoardPanel.Controls.Add(this.btnDashBoard);
            this.dashBoardPanel.Controls.Add(this.ticketCount);
            this.dashBoardPanel.Controls.Add(this.incidentChart);
            this.dashBoardPanel.Controls.Add(this.piChart);
            this.dashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(830, 612);
            this.dashBoardPanel.TabIndex = 2;
            // 
            // editTicketPanel
            // 
            this.editTicketPanel.Controls.Add(this.lblUpdateTicket);
            this.editTicketPanel.Controls.Add(this.incidentTypeEditComboBox);
            this.editTicketPanel.Controls.Add(this.incidentTypeEditLabel);
            this.editTicketPanel.Controls.Add(this.descriptionEditTextbox);
            this.editTicketPanel.Controls.Add(this.descriptionEditLabel);
            this.editTicketPanel.Controls.Add(this.deadlineEditDateTimePicker);
            this.editTicketPanel.Controls.Add(this.deadlineEditLabel);
            this.editTicketPanel.Controls.Add(this.statusEditComboBox);
            this.editTicketPanel.Controls.Add(this.priorityEditComboBox);
            this.editTicketPanel.Controls.Add(this.priorityEditLabel);
            this.editTicketPanel.Controls.Add(this.statusLabel);
            this.editTicketPanel.Controls.Add(this.submitEditButton);
            this.editTicketPanel.Controls.Add(this.editTicketListView);
            this.editTicketPanel.Location = new System.Drawing.Point(0, 0);
            this.editTicketPanel.Name = "editTicketPanel";
            this.editTicketPanel.Size = new System.Drawing.Size(827, 614);
            this.editTicketPanel.TabIndex = 17;
            // 
            // incidentTypeEditComboBox
            // 
            this.incidentTypeEditComboBox.FormattingEnabled = true;
            this.incidentTypeEditComboBox.Location = new System.Drawing.Point(402, 257);
            this.incidentTypeEditComboBox.Name = "incidentTypeEditComboBox";
            this.incidentTypeEditComboBox.Size = new System.Drawing.Size(121, 24);
            this.incidentTypeEditComboBox.TabIndex = 12;
            // 
            // incidentTypeEditLabel
            // 
            this.incidentTypeEditLabel.AutoSize = true;
            this.incidentTypeEditLabel.Location = new System.Drawing.Point(399, 233);
            this.incidentTypeEditLabel.Name = "incidentTypeEditLabel";
            this.incidentTypeEditLabel.Size = new System.Drawing.Size(82, 16);
            this.incidentTypeEditLabel.TabIndex = 11;
            this.incidentTypeEditLabel.Text = "Incident type";
            // 
            // descriptionEditTextbox
            // 
            this.descriptionEditTextbox.Location = new System.Drawing.Point(148, 337);
            this.descriptionEditTextbox.Multiline = true;
            this.descriptionEditTextbox.Name = "descriptionEditTextbox";
            this.descriptionEditTextbox.Size = new System.Drawing.Size(631, 153);
            this.descriptionEditTextbox.TabIndex = 10;
            // 
            // descriptionEditLabel
            // 
            this.descriptionEditLabel.AutoSize = true;
            this.descriptionEditLabel.Location = new System.Drawing.Point(148, 316);
            this.descriptionEditLabel.Name = "descriptionEditLabel";
            this.descriptionEditLabel.Size = new System.Drawing.Size(75, 16);
            this.descriptionEditLabel.TabIndex = 9;
            this.descriptionEditLabel.Text = "Description";
            // 
            // deadlineEditDateTimePicker
            // 
            this.deadlineEditDateTimePicker.Location = new System.Drawing.Point(540, 257);
            this.deadlineEditDateTimePicker.Name = "deadlineEditDateTimePicker";
            this.deadlineEditDateTimePicker.Size = new System.Drawing.Size(239, 22);
            this.deadlineEditDateTimePicker.TabIndex = 8;
            // 
            // deadlineEditLabel
            // 
            this.deadlineEditLabel.AutoSize = true;
            this.deadlineEditLabel.Location = new System.Drawing.Point(537, 233);
            this.deadlineEditLabel.Name = "deadlineEditLabel";
            this.deadlineEditLabel.Size = new System.Drawing.Size(62, 16);
            this.deadlineEditLabel.TabIndex = 7;
            this.deadlineEditLabel.Text = "Deadline";
            // 
            // statusEditComboBox
            // 
            this.statusEditComboBox.FormattingEnabled = true;
            this.statusEditComboBox.Location = new System.Drawing.Point(148, 257);
            this.statusEditComboBox.Name = "statusEditComboBox";
            this.statusEditComboBox.Size = new System.Drawing.Size(121, 24);
            this.statusEditComboBox.TabIndex = 6;
            // 
            // priorityEditComboBox
            // 
            this.priorityEditComboBox.FormattingEnabled = true;
            this.priorityEditComboBox.Location = new System.Drawing.Point(275, 257);
            this.priorityEditComboBox.Name = "priorityEditComboBox";
            this.priorityEditComboBox.Size = new System.Drawing.Size(121, 24);
            this.priorityEditComboBox.TabIndex = 5;
            // 
            // priorityEditLabel
            // 
            this.priorityEditLabel.AutoSize = true;
            this.priorityEditLabel.Location = new System.Drawing.Point(272, 233);
            this.priorityEditLabel.Name = "priorityEditLabel";
            this.priorityEditLabel.Size = new System.Drawing.Size(48, 16);
            this.priorityEditLabel.TabIndex = 4;
            this.priorityEditLabel.Text = "Priority";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(145, 233);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(44, 16);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Status";
            // 
            // submitEditButton
            // 
            this.submitEditButton.Location = new System.Drawing.Point(704, 524);
            this.submitEditButton.Name = "submitEditButton";
            this.submitEditButton.Size = new System.Drawing.Size(75, 23);
            this.submitEditButton.TabIndex = 1;
            this.submitEditButton.Text = "Submit";
            this.submitEditButton.UseVisualStyleBackColor = true;
            // 
            // editTicketListView
            // 
            this.editTicketListView.HideSelection = false;
            this.editTicketListView.Location = new System.Drawing.Point(148, 98);
            this.editTicketListView.Name = "editTicketListView";
            this.editTicketListView.Size = new System.Drawing.Size(631, 97);
            this.editTicketListView.TabIndex = 0;
            this.editTicketListView.UseCompatibleStateImageBehavior = false;
            // 
            // loadDataToList
            // 
            this.loadDataToList.Location = new System.Drawing.Point(220, 524);
            this.loadDataToList.Name = "loadDataToList";
            this.loadDataToList.Size = new System.Drawing.Size(75, 23);
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
            this.ticketView.Location = new System.Drawing.Point(148, 47);
            this.ticketView.Name = "ticketView";
            this.ticketView.Size = new System.Drawing.Size(631, 471);
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
            // createTicketPanel
            // 
            this.createTicketPanel.Controls.Add(this.submitButton);
            this.createTicketPanel.Controls.Add(this.cancelButton);
            this.createTicketPanel.Controls.Add(this.descriptionTextBox);
            this.createTicketPanel.Controls.Add(this.descriptionLabel);
            this.createTicketPanel.Controls.Add(this.deadlineComboBox);
            this.createTicketPanel.Controls.Add(this.deadlineLabel);
            this.createTicketPanel.Controls.Add(this.priorityLabel);
            this.createTicketPanel.Controls.Add(this.priorityComboBox);
            this.createTicketPanel.Controls.Add(this.reportedByLabel);
            this.createTicketPanel.Controls.Add(this.reportedByComboBox);
            this.createTicketPanel.Controls.Add(this.incidentTypeLabel);
            this.createTicketPanel.Controls.Add(this.incidentTypeComboBox);
            this.createTicketPanel.Controls.Add(this.subjectLabel);
            this.createTicketPanel.Controls.Add(this.subjectTextBox);
            this.createTicketPanel.Controls.Add(this.dateReportedLabel);
            this.createTicketPanel.Controls.Add(this.ticketDateTimePicker);
            this.createTicketPanel.Controls.Add(this.createTicketLabel);
            this.createTicketPanel.Location = new System.Drawing.Point(0, 0);
            this.createTicketPanel.Name = "createTicketPanel";
            this.createTicketPanel.Size = new System.Drawing.Size(827, 614);
            this.createTicketPanel.TabIndex = 1;
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(528, 557);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 41);
            this.submitButton.TabIndex = 16;
            this.submitButton.Text = "Submit Ticket";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(334, 557);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(128, 41);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(334, 360);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionTextBox.Size = new System.Drawing.Size(315, 163);
            this.descriptionTextBox.TabIndex = 14;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(151, 360);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(100, 20);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description:";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deadlineComboBox
            // 
            this.deadlineComboBox.FormattingEnabled = true;
            this.deadlineComboBox.Location = new System.Drawing.Point(334, 310);
            this.deadlineComboBox.Name = "deadlineComboBox";
            this.deadlineComboBox.Size = new System.Drawing.Size(315, 24);
            this.deadlineComboBox.TabIndex = 12;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deadlineLabel.Location = new System.Drawing.Point(151, 314);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(151, 20);
            this.deadlineLabel.TabIndex = 11;
            this.deadlineLabel.Text = "Deadline/follow up:";
            this.deadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priorityLabel.Location = new System.Drawing.Point(151, 274);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(67, 20);
            this.priorityLabel.TabIndex = 10;
            this.priorityLabel.Text = "Priority:";
            this.priorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // priorityComboBox
            // 
            this.priorityComboBox.FormattingEnabled = true;
            this.priorityComboBox.Location = new System.Drawing.Point(334, 270);
            this.priorityComboBox.Name = "priorityComboBox";
            this.priorityComboBox.Size = new System.Drawing.Size(315, 24);
            this.priorityComboBox.TabIndex = 9;
            // 
            // reportedByLabel
            // 
            this.reportedByLabel.AutoSize = true;
            this.reportedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportedByLabel.Location = new System.Drawing.Point(151, 234);
            this.reportedByLabel.Name = "reportedByLabel";
            this.reportedByLabel.Size = new System.Drawing.Size(142, 20);
            this.reportedByLabel.TabIndex = 8;
            this.reportedByLabel.Text = "Reported by user:";
            this.reportedByLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportedByLabel.Click += new System.EventHandler(this.reportedByLabel_Click);
            // 
            // reportedByComboBox
            // 
            this.reportedByComboBox.FormattingEnabled = true;
            this.reportedByComboBox.Location = new System.Drawing.Point(334, 230);
            this.reportedByComboBox.Name = "reportedByComboBox";
            this.reportedByComboBox.Size = new System.Drawing.Size(315, 24);
            this.reportedByComboBox.TabIndex = 7;
            // 
            // incidentTypeLabel
            // 
            this.incidentTypeLabel.AutoSize = true;
            this.incidentTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incidentTypeLabel.Location = new System.Drawing.Point(151, 194);
            this.incidentTypeLabel.Name = "incidentTypeLabel";
            this.incidentTypeLabel.Size = new System.Drawing.Size(132, 20);
            this.incidentTypeLabel.TabIndex = 6;
            this.incidentTypeLabel.Text = "Type of incident:";
            this.incidentTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // incidentTypeComboBox
            // 
            this.incidentTypeComboBox.FormattingEnabled = true;
            this.incidentTypeComboBox.Location = new System.Drawing.Point(334, 190);
            this.incidentTypeComboBox.Name = "incidentTypeComboBox";
            this.incidentTypeComboBox.Size = new System.Drawing.Size(315, 24);
            this.incidentTypeComboBox.TabIndex = 5;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(151, 152);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(180, 20);
            this.subjectLabel.TabIndex = 4;
            this.subjectLabel.Text = "Subject of the incident:";
            this.subjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(334, 150);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(315, 22);
            this.subjectTextBox.TabIndex = 3;
            // 
            // dateReportedLabel
            // 
            this.dateReportedLabel.AutoSize = true;
            this.dateReportedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReportedLabel.Location = new System.Drawing.Point(151, 112);
            this.dateReportedLabel.Name = "dateReportedLabel";
            this.dateReportedLabel.Size = new System.Drawing.Size(154, 20);
            this.dateReportedLabel.TabIndex = 2;
            this.dateReportedLabel.Text = "Date/time reported:";
            this.dateReportedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dateReportedLabel.Click += new System.EventHandler(this.dateReportedLabel_Click);
            // 
            // ticketDateTimePicker
            // 
            this.ticketDateTimePicker.Location = new System.Drawing.Point(334, 110);
            this.ticketDateTimePicker.Name = "ticketDateTimePicker";
            this.ticketDateTimePicker.Size = new System.Drawing.Size(315, 22);
            this.ticketDateTimePicker.TabIndex = 1;
            // 
            // createTicketLabel
            // 
            this.createTicketLabel.AutoSize = true;
            this.createTicketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTicketLabel.Location = new System.Drawing.Point(148, 57);
            this.createTicketLabel.Name = "createTicketLabel";
            this.createTicketLabel.Size = new System.Drawing.Size(417, 38);
            this.createTicketLabel.TabIndex = 0;
            this.createTicketLabel.Text = "Create new incident ticket";
            // 
            // btnIncidentManagment
            // 
            this.btnIncidentManagment.Location = new System.Drawing.Point(365, 57);
            this.btnIncidentManagment.Name = "btnIncidentManagment";
            this.btnIncidentManagment.Size = new System.Drawing.Size(243, 23);
            this.btnIncidentManagment.TabIndex = 4;
            this.btnIncidentManagment.Text = "Incident manamgnet";
            this.btnIncidentManagment.UseVisualStyleBackColor = true;
            this.btnIncidentManagment.Click += new System.EventHandler(this.btnIncidentManagment_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(155, 57);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(190, 23);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "Dash board";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // ticketCount
            // 
            this.ticketCount.AutoSize = true;
            this.ticketCount.Location = new System.Drawing.Point(172, 277);
            this.ticketCount.Name = "ticketCount";
            this.ticketCount.Size = new System.Drawing.Size(0, 16);
            this.ticketCount.TabIndex = 2;
            // 
            // incidentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.incidentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.incidentChart.Legends.Add(legend1);
            this.incidentChart.Location = new System.Drawing.Point(435, 138);
            this.incidentChart.Name = "incidentChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "incidents past deadline";
            this.incidentChart.Series.Add(series1);
            this.incidentChart.Size = new System.Drawing.Size(381, 300);
            this.incidentChart.TabIndex = 1;
            this.incidentChart.Text = "chart2";
            // 
            // piChart
            // 
            chartArea2.Name = "ChartArea1";
            this.piChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.piChart.Legends.Add(legend2);
            this.piChart.Location = new System.Drawing.Point(57, 138);
            this.piChart.Name = "piChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.piChart.Series.Add(series2);
            this.piChart.Size = new System.Drawing.Size(352, 300);
            this.piChart.TabIndex = 0;
            this.piChart.Text = "chart1";
            // 
            // ticketViewPanel
            // 
            this.ticketViewPanel.Controls.Add(this.incidentManagamentUIbtn);
            this.ticketViewPanel.Controls.Add(this.dashBoardTickeUI);
            this.ticketViewPanel.Controls.Add(this.loadDataToList);
            this.ticketViewPanel.Controls.Add(this.ticketView);
            this.ticketViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ticketViewPanel.Name = "ticketViewPanel";
            this.ticketViewPanel.Size = new System.Drawing.Size(830, 611);
            this.ticketViewPanel.TabIndex = 4;
            // 
            // incidentManagamentUIbtn
            // 
            this.incidentManagamentUIbtn.Location = new System.Drawing.Point(334, 18);
            this.incidentManagamentUIbtn.Name = "incidentManagamentUIbtn";
            this.incidentManagamentUIbtn.Size = new System.Drawing.Size(153, 23);
            this.incidentManagamentUIbtn.TabIndex = 2;
            this.incidentManagamentUIbtn.Text = "Incident managment";
            this.incidentManagamentUIbtn.UseVisualStyleBackColor = true;
            this.incidentManagamentUIbtn.Click += new System.EventHandler(this.incidentManagamentUIbtn_Click);
            // 
            // dashBoardTickeUI
            // 
            this.dashBoardTickeUI.Location = new System.Drawing.Point(148, 18);
            this.dashBoardTickeUI.Name = "dashBoardTickeUI";
            this.dashBoardTickeUI.Size = new System.Drawing.Size(180, 23);
            this.dashBoardTickeUI.TabIndex = 1;
            this.dashBoardTickeUI.Text = "Dash board";
            this.dashBoardTickeUI.UseVisualStyleBackColor = true;
            this.dashBoardTickeUI.Click += new System.EventHandler(this.dashBoardTickeUI_Click);
            // 
            // lblUpdateTicket
            // 
            this.lblUpdateTicket.AutoSize = true;
            this.lblUpdateTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateTicket.Location = new System.Drawing.Point(148, 38);
            this.lblUpdateTicket.Name = "lblUpdateTicket";
            this.lblUpdateTicket.Size = new System.Drawing.Size(215, 39);
            this.lblUpdateTicket.TabIndex = 13;
            this.lblUpdateTicket.Text = "Update ticket";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 613);
            this.Controls.Add(this.dashBoardPanel);
            this.Controls.Add(this.ticketViewPanel);
            this.Controls.Add(this.createTicketPanel);
            this.Controls.Add(this.employeePanel);
            this.Name = "UserInterface";
            this.Text = "User Interface";
            this.employeePanel.ResumeLayout(false);
            this.dashBoardPanel.ResumeLayout(false);
            this.dashBoardPanel.PerformLayout();
            this.editTicketPanel.ResumeLayout(false);
            this.editTicketPanel.PerformLayout();
            this.createTicketPanel.ResumeLayout(false);
            this.createTicketPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).EndInit();
            this.ticketViewPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Panel ticketViewPanel;
        private System.Windows.Forms.Button loadDataToList;
        private System.Windows.Forms.Panel createTicketPanel;
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
        private System.Windows.Forms.Panel editTicketPanel;
        private System.Windows.Forms.Button submitEditButton;
        private System.Windows.Forms.ListView editTicketListView;
        private System.Windows.Forms.Label priorityEditLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox priorityEditComboBox;
        private System.Windows.Forms.ComboBox statusEditComboBox;
        private System.Windows.Forms.TextBox descriptionEditTextbox;
        private System.Windows.Forms.Label descriptionEditLabel;
        private System.Windows.Forms.DateTimePicker deadlineEditDateTimePicker;
        private System.Windows.Forms.Label deadlineEditLabel;
        private System.Windows.Forms.ComboBox incidentTypeEditComboBox;
        private System.Windows.Forms.Label incidentTypeEditLabel;
        private System.Windows.Forms.Panel dashBoardPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart incidentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart piChart;
        private System.Windows.Forms.Button dashBoardTickeUI;
        private System.Windows.Forms.Label ticketCount;
        private System.Windows.Forms.Button incidentManagamentUIbtn;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnIncidentManagment;
        private System.Windows.Forms.Label lblUpdateTicket;
    }
}
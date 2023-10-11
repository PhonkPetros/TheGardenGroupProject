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
            this.ticketViewPanel = new System.Windows.Forms.Panel();
            this.incidentManagamentUIbtn = new System.Windows.Forms.Button();
            this.dashBoardTickeUI = new System.Windows.Forms.Button();
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
            this.dashBoardPanel = new System.Windows.Forms.Panel();
            this.btnIncidentManagment = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.ticketCount = new System.Windows.Forms.Label();
            this.incidentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.piChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.employeePanel.SuspendLayout();
            this.ticketViewPanel.SuspendLayout();
            this.createTicketPanel.SuspendLayout();
            this.dashBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).BeginInit();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.userBtn);
            this.employeePanel.Controls.Add(this.incidentBtn);
            this.employeePanel.Controls.Add(this.dashBoardBtn);
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
            // ticketViewPanel
            // 
            this.ticketViewPanel.Controls.Add(this.incidentManagamentUIbtn);
            this.ticketViewPanel.Controls.Add(this.dashBoardTickeUI);
            this.ticketViewPanel.Controls.Add(this.loadDataToList);
            this.ticketViewPanel.Controls.Add(this.ticketView);
            this.ticketViewPanel.Location = new System.Drawing.Point(0, 0);
            this.ticketViewPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ticketViewPanel.Name = "ticketViewPanel";
            this.ticketViewPanel.Size = new System.Drawing.Size(622, 496);
            this.ticketViewPanel.TabIndex = 4;
            // 
            // incidentManagamentUIbtn
            // 
            this.incidentManagamentUIbtn.Location = new System.Drawing.Point(250, 15);
            this.incidentManagamentUIbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidentManagamentUIbtn.Name = "incidentManagamentUIbtn";
            this.incidentManagamentUIbtn.Size = new System.Drawing.Size(115, 19);
            this.incidentManagamentUIbtn.TabIndex = 2;
            this.incidentManagamentUIbtn.Text = "Incident managment";
            this.incidentManagamentUIbtn.UseVisualStyleBackColor = true;
            this.incidentManagamentUIbtn.Click += new System.EventHandler(this.incidentManagamentUIbtn_Click);
            // 
            // dashBoardTickeUI
            // 
            this.dashBoardTickeUI.Location = new System.Drawing.Point(111, 15);
            this.dashBoardTickeUI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashBoardTickeUI.Name = "dashBoardTickeUI";
            this.dashBoardTickeUI.Size = new System.Drawing.Size(135, 19);
            this.dashBoardTickeUI.TabIndex = 1;
            this.dashBoardTickeUI.Text = "Dash board";
            this.dashBoardTickeUI.UseVisualStyleBackColor = true;
            this.dashBoardTickeUI.Click += new System.EventHandler(this.dashBoardTickeUI_Click);
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
            this.createTicketPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createTicketPanel.Name = "createTicketPanel";
            this.createTicketPanel.Size = new System.Drawing.Size(620, 499);
            this.createTicketPanel.TabIndex = 1;
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
            this.subjectLabel.Location = new System.Drawing.Point(113, 124);
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
            this.dateReportedLabel.Location = new System.Drawing.Point(113, 91);
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
            // dashBoardPanel
            // 
            this.dashBoardPanel.Controls.Add(this.btnIncidentManagment);
            this.dashBoardPanel.Controls.Add(this.btnDashBoard);
            this.dashBoardPanel.Controls.Add(this.ticketCount);
            this.dashBoardPanel.Controls.Add(this.incidentChart);
            this.dashBoardPanel.Controls.Add(this.piChart);
            this.dashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.dashBoardPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashBoardPanel.Name = "dashBoardPanel";
            this.dashBoardPanel.Size = new System.Drawing.Size(622, 497);
            this.dashBoardPanel.TabIndex = 2;
            // 
            // btnIncidentManagment
            // 
            this.btnIncidentManagment.Location = new System.Drawing.Point(274, 46);
            this.btnIncidentManagment.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIncidentManagment.Name = "btnIncidentManagment";
            this.btnIncidentManagment.Size = new System.Drawing.Size(182, 19);
            this.btnIncidentManagment.TabIndex = 4;
            this.btnIncidentManagment.Text = "Incident manamgnet";
            this.btnIncidentManagment.UseVisualStyleBackColor = true;
            this.btnIncidentManagment.Click += new System.EventHandler(this.btnIncidentManagment_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.Location = new System.Drawing.Point(116, 46);
            this.btnDashBoard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(142, 19);
            this.btnDashBoard.TabIndex = 3;
            this.btnDashBoard.Text = "Dash board";
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // ticketCount
            // 
            this.ticketCount.AutoSize = true;
            this.ticketCount.Location = new System.Drawing.Point(129, 225);
            this.ticketCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ticketCount.Name = "ticketCount";
            this.ticketCount.Size = new System.Drawing.Size(0, 13);
            this.ticketCount.TabIndex = 2;
            // 
            // incidentChart
            // 
            chartArea1.Name = "ChartArea1";
            this.incidentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.incidentChart.Legends.Add(legend1);
            this.incidentChart.Location = new System.Drawing.Point(326, 112);
            this.incidentChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.incidentChart.Name = "incidentChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "incidents past deadline";
            this.incidentChart.Series.Add(series1);
            this.incidentChart.Size = new System.Drawing.Size(286, 244);
            this.incidentChart.TabIndex = 1;
            this.incidentChart.Text = "chart2";
            // 
            // piChart
            // 
            chartArea2.Name = "ChartArea1";
            this.piChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.piChart.Legends.Add(legend2);
            this.piChart.Location = new System.Drawing.Point(43, 112);
            this.piChart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.piChart.Name = "piChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.piChart.Series.Add(series2);
            this.piChart.Size = new System.Drawing.Size(264, 244);
            this.piChart.TabIndex = 0;
            this.piChart.Text = "chart1";
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 498);
            this.Controls.Add(this.createTicketPanel);
            this.Controls.Add(this.dashBoardPanel);
            this.Controls.Add(this.ticketViewPanel);
            this.Controls.Add(this.employeePanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UserInterface";
            this.Text = "User Interface";
            this.employeePanel.ResumeLayout(false);
            this.ticketViewPanel.ResumeLayout(false);
            this.createTicketPanel.ResumeLayout(false);
            this.createTicketPanel.PerformLayout();
            this.dashBoardPanel.ResumeLayout(false);
            this.dashBoardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.incidentChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.piChart)).EndInit();
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
        private System.Windows.Forms.Panel dashBoardPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart incidentChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart piChart;
        private System.Windows.Forms.Button dashBoardTickeUI;
        private System.Windows.Forms.Label ticketCount;
        private System.Windows.Forms.Button incidentManagamentUIbtn;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnIncidentManagment;
    }
}
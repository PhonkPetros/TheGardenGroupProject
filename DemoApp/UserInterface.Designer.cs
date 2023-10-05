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
            this.ticketView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dashboardPnl = new System.Windows.Forms.Panel();
            this.loadDataToList = new System.Windows.Forms.Button();
            this.employeePanel.SuspendLayout();
            this.dashboardPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeePanel
            // 
            this.employeePanel.Controls.Add(this.userBtn);
            this.employeePanel.Controls.Add(this.incidentBtn);
            this.employeePanel.Controls.Add(this.dashBoardBtn);
            this.employeePanel.Controls.Add(this.dashboardPnl);
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
            // dashboardPnl
            // 
            this.dashboardPnl.Controls.Add(this.loadDataToList);
            this.dashboardPnl.Controls.Add(this.ticketView);
            this.dashboardPnl.Location = new System.Drawing.Point(0, 0);
            this.dashboardPnl.Name = "dashboardPnl";
            this.dashboardPnl.Size = new System.Drawing.Size(830, 611);
            this.dashboardPnl.TabIndex = 4;
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
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 613);
            this.Controls.Add(this.employeePanel);
            this.Name = "UserInterface";
            this.Text = "User Interface";
            this.employeePanel.ResumeLayout(false);
            this.dashboardPnl.ResumeLayout(false);
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
    }
}
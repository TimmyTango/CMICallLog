namespace CMICallLog
{
    partial class TicketDetailForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ticketNumBox = new System.Windows.Forms.TextBox();
            this.createdDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.contactTypeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.createdByBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeNumberBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.issueTypeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createdTimeBox = new System.Windows.Forms.TextBox();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.filesBtn = new System.Windows.Forms.Button();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.toggleBtn = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.Button();
            this.midPanel = new System.Windows.Forms.Panel();
            this.completedByBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateCompletedPicker = new System.Windows.Forms.DateTimePicker();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.midPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // ticketNumBox
            // 
            this.ticketNumBox.Location = new System.Drawing.Point(108, 6);
            this.ticketNumBox.Name = "ticketNumBox";
            this.ticketNumBox.Size = new System.Drawing.Size(160, 20);
            this.ticketNumBox.TabIndex = 2;
            // 
            // createdDatePicker
            // 
            this.createdDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createdDatePicker.Location = new System.Drawing.Point(108, 32);
            this.createdDatePicker.Name = "createdDatePicker";
            this.createdDatePicker.Size = new System.Drawing.Size(160, 20);
            this.createdDatePicker.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Time";
            // 
            // contactTypeBox
            // 
            this.contactTypeBox.FormattingEnabled = true;
            this.contactTypeBox.Items.AddRange(new object[] {
            "live",
            "vmail",
            "email"});
            this.contactTypeBox.Location = new System.Drawing.Point(108, 84);
            this.contactTypeBox.Name = "contactTypeBox";
            this.contactTypeBox.Size = new System.Drawing.Size(160, 21);
            this.contactTypeBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Contact Type";
            // 
            // createdByBox
            // 
            this.createdByBox.Location = new System.Drawing.Point(108, 111);
            this.createdByBox.Name = "createdByBox";
            this.createdByBox.Size = new System.Drawing.Size(160, 20);
            this.createdByBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contact Name";
            // 
            // storeNumberBox
            // 
            this.storeNumberBox.Location = new System.Drawing.Point(108, 137);
            this.storeNumberBox.Name = "storeNumberBox";
            this.storeNumberBox.Size = new System.Drawing.Size(160, 20);
            this.storeNumberBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Store Number";
            // 
            // issueTypeBox
            // 
            this.issueTypeBox.Location = new System.Drawing.Point(108, 163);
            this.issueTypeBox.Name = "issueTypeBox";
            this.issueTypeBox.Size = new System.Drawing.Size(160, 20);
            this.issueTypeBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Issue Type";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 260);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descriptionBox.Size = new System.Drawing.Size(354, 153);
            this.descriptionBox.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Description";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(219, 6);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 16;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(300, 6);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // createdTimeBox
            // 
            this.createdTimeBox.Location = new System.Drawing.Point(108, 58);
            this.createdTimeBox.Name = "createdTimeBox";
            this.createdTimeBox.Size = new System.Drawing.Size(160, 20);
            this.createdTimeBox.TabIndex = 4;
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "open",
            "r/v",
            "f/u",
            "closed"});
            this.statusBox.Location = new System.Drawing.Point(108, 189);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(160, 21);
            this.statusBox.TabIndex = 18;
            this.statusBox.Text = "open";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Status";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.filesBtn);
            this.topPanel.Controls.Add(this.priorityBox);
            this.topPanel.Controls.Add(this.label13);
            this.topPanel.Controls.Add(this.toggleBtn);
            this.topPanel.Controls.Add(this.copyBtn);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.label2);
            this.topPanel.Controls.Add(this.ticketNumBox);
            this.topPanel.Controls.Add(this.createdDatePicker);
            this.topPanel.Controls.Add(this.label3);
            this.topPanel.Controls.Add(this.contactTypeBox);
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Controls.Add(this.createdByBox);
            this.topPanel.Controls.Add(this.label5);
            this.topPanel.Controls.Add(this.storeNumberBox);
            this.topPanel.Controls.Add(this.label6);
            this.topPanel.Controls.Add(this.issueTypeBox);
            this.topPanel.Controls.Add(this.label7);
            this.topPanel.Controls.Add(this.descriptionBox);
            this.topPanel.Controls.Add(this.label8);
            this.topPanel.Controls.Add(this.createdTimeBox);
            this.topPanel.Controls.Add(this.statusBox);
            this.topPanel.Controls.Add(this.label9);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(378, 444);
            this.topPanel.TabIndex = 20;
            // 
            // filesBtn
            // 
            this.filesBtn.Location = new System.Drawing.Point(291, 154);
            this.filesBtn.Name = "filesBtn";
            this.filesBtn.Size = new System.Drawing.Size(75, 23);
            this.filesBtn.TabIndex = 23;
            this.filesBtn.Text = "Files";
            this.filesBtn.UseVisualStyleBackColor = true;
            this.filesBtn.Click += new System.EventHandler(this.filesBtn_Click);
            // 
            // priorityBox
            // 
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Items.AddRange(new object[] {
            "Normal",
            "High",
            "Low"});
            this.priorityBox.Location = new System.Drawing.Point(108, 216);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(160, 21);
            this.priorityBox.TabIndex = 22;
            this.priorityBox.Text = "Normal";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = "Priority";
            // 
            // toggleBtn
            // 
            this.toggleBtn.Location = new System.Drawing.Point(291, 209);
            this.toggleBtn.Name = "toggleBtn";
            this.toggleBtn.Size = new System.Drawing.Size(75, 23);
            this.toggleBtn.TabIndex = 18;
            this.toggleBtn.Text = "Toggle";
            this.toggleBtn.UseVisualStyleBackColor = true;
            this.toggleBtn.Click += new System.EventHandler(this.toggleBtn_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(291, 183);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(75, 23);
            this.copyBtn.TabIndex = 20;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.nextBtn);
            this.bottomPanel.Controls.Add(this.cancelBtn);
            this.bottomPanel.Controls.Add(this.createBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 696);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(378, 41);
            this.bottomPanel.TabIndex = 20;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(3, 6);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // midPanel
            // 
            this.midPanel.Controls.Add(this.completedByBox);
            this.midPanel.Controls.Add(this.label12);
            this.midPanel.Controls.Add(this.label11);
            this.midPanel.Controls.Add(this.label10);
            this.midPanel.Controls.Add(this.dateCompletedPicker);
            this.midPanel.Controls.Add(this.solutionBox);
            this.midPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midPanel.Location = new System.Drawing.Point(0, 444);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(378, 252);
            this.midPanel.TabIndex = 21;
            // 
            // completedByBox
            // 
            this.completedByBox.Location = new System.Drawing.Point(108, 32);
            this.completedByBox.Name = "completedByBox";
            this.completedByBox.Size = new System.Drawing.Size(160, 20);
            this.completedByBox.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Completed By";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Date Completed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Solution";
            // 
            // dateCompletedPicker
            // 
            this.dateCompletedPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompletedPicker.Location = new System.Drawing.Point(108, 6);
            this.dateCompletedPicker.Name = "dateCompletedPicker";
            this.dateCompletedPicker.Size = new System.Drawing.Size(160, 20);
            this.dateCompletedPicker.TabIndex = 21;
            // 
            // solutionBox
            // 
            this.solutionBox.Location = new System.Drawing.Point(12, 76);
            this.solutionBox.Multiline = true;
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.solutionBox.Size = new System.Drawing.Size(354, 153);
            this.solutionBox.TabIndex = 20;
            // 
            // TicketDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 737);
            this.Controls.Add(this.midPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketDetailForm";
            this.ShowInTaskbar = false;
            this.Text = "Ticket Details";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.midPanel.ResumeLayout(false);
            this.midPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ticketNumBox;
        private System.Windows.Forms.DateTimePicker createdDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox contactTypeBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox createdByBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox storeNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox issueTypeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox createdTimeBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.TextBox completedByBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateCompletedPicker;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Button toggleBtn;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button filesBtn;
    }
}
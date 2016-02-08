namespace CMICallLog
{
    partial class CompleteTicketForm
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
            this.ticketNumBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storeNumBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.completedByBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateCompletedBox = new System.Windows.Forms.DateTimePicker();
            this.solutionBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ticket Number";
            // 
            // ticketNumBox
            // 
            this.ticketNumBox.Location = new System.Drawing.Point(95, 6);
            this.ticketNumBox.Name = "ticketNumBox";
            this.ticketNumBox.ReadOnly = true;
            this.ticketNumBox.Size = new System.Drawing.Size(104, 20);
            this.ticketNumBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Store Number";
            // 
            // storeNumBox
            // 
            this.storeNumBox.Location = new System.Drawing.Point(288, 6);
            this.storeNumBox.Name = "storeNumBox";
            this.storeNumBox.ReadOnly = true;
            this.storeNumBox.Size = new System.Drawing.Size(104, 20);
            this.storeNumBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 53);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(384, 99);
            this.descriptionBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Completed";
            // 
            // completedByBox
            // 
            this.completedByBox.Location = new System.Drawing.Point(95, 158);
            this.completedByBox.Name = "completedByBox";
            this.completedByBox.Size = new System.Drawing.Size(104, 20);
            this.completedByBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Completed By";
            // 
            // dateCompletedBox
            // 
            this.dateCompletedBox.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCompletedBox.Location = new System.Drawing.Point(288, 158);
            this.dateCompletedBox.Name = "dateCompletedBox";
            this.dateCompletedBox.Size = new System.Drawing.Size(104, 20);
            this.dateCompletedBox.TabIndex = 9;
            // 
            // solutionBox
            // 
            this.solutionBox.Location = new System.Drawing.Point(15, 207);
            this.solutionBox.Multiline = true;
            this.solutionBox.Name = "solutionBox";
            this.solutionBox.Size = new System.Drawing.Size(384, 99);
            this.solutionBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Solution";
            // 
            // completeButton
            // 
            this.completeButton.Location = new System.Drawing.Point(240, 313);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(75, 23);
            this.completeButton.TabIndex = 12;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(321, 313);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CompleteTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.solutionBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateCompletedBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.completedByBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.storeNumBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketNumBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompleteTicketForm";
            this.ShowInTaskbar = false;
            this.Text = "CompleteTicketForm";
            this.Load += new System.EventHandler(this.CompleteTicketForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketNumBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox storeNumBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox completedByBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateCompletedBox;
        private System.Windows.Forms.TextBox solutionBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
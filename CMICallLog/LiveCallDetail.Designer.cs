namespace CMICallLog
{
    partial class LiveCallDetail
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
            this.callerText = new System.Windows.Forms.TextBox();
            this.contactBox = new System.Windows.Forms.ComboBox();
            this.startDateBox = new System.Windows.Forms.DateTimePicker();
            this.endDateBox = new System.Windows.Forms.DateTimePicker();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.manualBox = new System.Windows.Forms.CheckBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.problemText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.resolutionText = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.openBtn = new System.Windows.Forms.Button();
            this.nowBtn = new System.Windows.Forms.Button();
            this.storeList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store";
            // 
            // callerText
            // 
            this.callerText.Location = new System.Drawing.Point(67, 38);
            this.callerText.Name = "callerText";
            this.callerText.Size = new System.Drawing.Size(121, 20);
            this.callerText.TabIndex = 2;
            // 
            // contactBox
            // 
            this.contactBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactBox.FormattingEnabled = true;
            this.contactBox.Location = new System.Drawing.Point(67, 64);
            this.contactBox.Name = "contactBox";
            this.contactBox.Size = new System.Drawing.Size(121, 21);
            this.contactBox.TabIndex = 3;
            // 
            // startDateBox
            // 
            this.startDateBox.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.startDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDateBox.Location = new System.Drawing.Point(250, 12);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Size = new System.Drawing.Size(141, 20);
            this.startDateBox.TabIndex = 4;
            // 
            // endDateBox
            // 
            this.endDateBox.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.endDateBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateBox.Location = new System.Drawing.Point(250, 38);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Size = new System.Drawing.Size(141, 20);
            this.endDateBox.TabIndex = 5;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(250, 64);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(141, 21);
            this.typeBox.TabIndex = 6;
            // 
            // manualBox
            // 
            this.manualBox.AutoSize = true;
            this.manualBox.Location = new System.Drawing.Point(218, 95);
            this.manualBox.Name = "manualBox";
            this.manualBox.Size = new System.Drawing.Size(73, 17);
            this.manualBox.TabIndex = 7;
            this.manualBox.Text = "In Manual";
            this.manualBox.UseVisualStyleBackColor = true;
            // 
            // priorityBox
            // 
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(67, 91);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(121, 21);
            this.priorityBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Start";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Priority";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Caller";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Type";
            // 
            // problemText
            // 
            this.problemText.Location = new System.Drawing.Point(12, 144);
            this.problemText.Multiline = true;
            this.problemText.Name = "problemText";
            this.problemText.Size = new System.Drawing.Size(460, 145);
            this.problemText.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Problem Description:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Resolution";
            // 
            // resolutionText
            // 
            this.resolutionText.Location = new System.Drawing.Point(12, 318);
            this.resolutionText.Multiline = true;
            this.resolutionText.Name = "resolutionText";
            this.resolutionText.Size = new System.Drawing.Size(460, 76);
            this.resolutionText.TabIndex = 18;
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(397, 417);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.Text = "Create";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 417);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 23;
            this.openBtn.Text = "Keep Open";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // nowBtn
            // 
            this.nowBtn.Location = new System.Drawing.Point(397, 36);
            this.nowBtn.Name = "nowBtn";
            this.nowBtn.Size = new System.Drawing.Size(75, 23);
            this.nowBtn.TabIndex = 24;
            this.nowBtn.Text = "Now";
            this.nowBtn.UseVisualStyleBackColor = true;
            this.nowBtn.Click += new System.EventHandler(this.nowBtn_Click);
            // 
            // storeList
            // 
            this.storeList.FormattingEnabled = true;
            this.storeList.Location = new System.Drawing.Point(67, 12);
            this.storeList.Name = "storeList";
            this.storeList.Size = new System.Drawing.Size(121, 21);
            this.storeList.TabIndex = 25;
            // 
            // LiveCallDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 452);
            this.Controls.Add(this.storeList);
            this.Controls.Add(this.nowBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.resolutionText);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.problemText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.priorityBox);
            this.Controls.Add(this.manualBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.endDateBox);
            this.Controls.Add(this.startDateBox);
            this.Controls.Add(this.contactBox);
            this.Controls.Add(this.callerText);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LiveCallDetail";
            this.Text = "Live Call";
            this.Load += new System.EventHandler(this.LiveCallDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox callerText;
        private System.Windows.Forms.DateTimePicker startDateBox;
        private System.Windows.Forms.CheckBox manualBox;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox problemText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox resolutionText;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.DateTimePicker endDateBox;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button nowBtn;
        private System.Windows.Forms.ComboBox storeList;
        private System.Windows.Forms.ComboBox contactBox;
    }
}
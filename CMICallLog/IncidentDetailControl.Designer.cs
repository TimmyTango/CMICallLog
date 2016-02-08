namespace CMICallLog
{
    partial class IncidentDetailControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.storeNumberBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.incidentBox = new System.Windows.Forms.TextBox();
            this.createDateTime = new System.Windows.Forms.DateTimePicker();
            this.contactNameBox = new System.Windows.Forms.TextBox();
            this.contactTypeBox = new System.Windows.Forms.ComboBox();
            this.priorityBox = new System.Windows.Forms.ComboBox();
            this.problemTypeBox = new System.Windows.Forms.ComboBox();
            this.manualCheckbox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.problemBox = new System.Windows.Forms.TextBox();
            this.constantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // storeNumberBox
            // 
            this.storeNumberBox.FormattingEnabled = true;
            this.storeNumberBox.Location = new System.Drawing.Point(84, 32);
            this.storeNumberBox.Name = "storeNumberBox";
            this.storeNumberBox.Size = new System.Drawing.Size(141, 21);
            this.storeNumberBox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Priority";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Problem Type";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contact Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date/Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Contact Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Store";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Incident";
            // 
            // incidentBox
            // 
            this.incidentBox.Location = new System.Drawing.Point(84, 6);
            this.incidentBox.Name = "incidentBox";
            this.incidentBox.ReadOnly = true;
            this.incidentBox.Size = new System.Drawing.Size(141, 20);
            this.incidentBox.TabIndex = 10;
            // 
            // createDateTime
            // 
            this.createDateTime.CustomFormat = "yyyy-MM-dd hh:mm tt";
            this.createDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.createDateTime.Location = new System.Drawing.Point(84, 59);
            this.createDateTime.Name = "createDateTime";
            this.createDateTime.Size = new System.Drawing.Size(141, 20);
            this.createDateTime.TabIndex = 20;
            // 
            // contactNameBox
            // 
            this.contactNameBox.Location = new System.Drawing.Point(84, 85);
            this.contactNameBox.Name = "contactNameBox";
            this.contactNameBox.Size = new System.Drawing.Size(141, 20);
            this.contactNameBox.TabIndex = 21;
            // 
            // contactTypeBox
            // 
            this.contactTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactTypeBox.FormattingEnabled = true;
            this.contactTypeBox.Location = new System.Drawing.Point(84, 111);
            this.contactTypeBox.Name = "contactTypeBox";
            this.contactTypeBox.Size = new System.Drawing.Size(141, 21);
            this.contactTypeBox.TabIndex = 22;
            // 
            // priorityBox
            // 
            this.priorityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priorityBox.FormattingEnabled = true;
            this.priorityBox.Location = new System.Drawing.Point(84, 192);
            this.priorityBox.Name = "priorityBox";
            this.priorityBox.Size = new System.Drawing.Size(141, 21);
            this.priorityBox.TabIndex = 23;
            // 
            // problemTypeBox
            // 
            this.problemTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.problemTypeBox.FormattingEnabled = true;
            this.problemTypeBox.Location = new System.Drawing.Point(84, 165);
            this.problemTypeBox.Name = "problemTypeBox";
            this.problemTypeBox.Size = new System.Drawing.Size(141, 21);
            this.problemTypeBox.TabIndex = 24;
            // 
            // manualCheckbox
            // 
            this.manualCheckbox.AutoSize = true;
            this.manualCheckbox.Location = new System.Drawing.Point(84, 219);
            this.manualCheckbox.Name = "manualCheckbox";
            this.manualCheckbox.Size = new System.Drawing.Size(73, 17);
            this.manualCheckbox.TabIndex = 25;
            this.manualCheckbox.Text = "In Manual";
            this.manualCheckbox.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Status";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusBox);
            this.panel1.Controls.Add(this.incidentBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.manualCheckbox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.problemTypeBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.priorityBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.contactTypeBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.contactNameBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.createDateTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.storeNumberBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 251);
            this.panel1.TabIndex = 28;
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Location = new System.Drawing.Point(84, 138);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(141, 21);
            this.statusBox.TabIndex = 28;
            // 
            // problemBox
            // 
            this.problemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.problemBox.Location = new System.Drawing.Point(244, 0);
            this.problemBox.Multiline = true;
            this.problemBox.Name = "problemBox";
            this.problemBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.problemBox.Size = new System.Drawing.Size(258, 251);
            this.problemBox.TabIndex = 29;
            // 
            // constantsBindingSource
            // 
            this.constantsBindingSource.DataSource = typeof(CMICallLog.Constants);
            // 
            // IncidentDetailControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.problemBox);
            this.Controls.Add(this.panel1);
            this.Name = "IncidentDetailControl";
            this.Size = new System.Drawing.Size(502, 251);
            this.Load += new System.EventHandler(this.IncidentDetailControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.constantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox storeNumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incidentBox;
        private System.Windows.Forms.DateTimePicker createDateTime;
        private System.Windows.Forms.TextBox contactNameBox;
        private System.Windows.Forms.ComboBox contactTypeBox;
        private System.Windows.Forms.ComboBox priorityBox;
        private System.Windows.Forms.ComboBox problemTypeBox;
        private System.Windows.Forms.CheckBox manualCheckbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox problemBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.BindingSource constantsBindingSource;
    }
}

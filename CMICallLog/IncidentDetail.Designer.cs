namespace CMICallLog
{
    partial class IncidentDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncidentDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.updateButton = new System.Windows.Forms.Button();
            this.details = new CMICallLog.IncidentDetailControl();
            this.updatesList = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updDeleteBtn = new System.Windows.Forms.Button();
            this.updEditBtn = new System.Windows.Forms.Button();
            this.updCreateBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.details);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 291);
            this.panel1.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(6, 257);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // details
            // 
            this.details.Dock = System.Windows.Forms.DockStyle.Top;
            this.details.Location = new System.Drawing.Point(0, 0);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(622, 251);
            this.details.TabIndex = 2;
            // 
            // updatesList
            // 
            this.updatesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updatesList.Location = new System.Drawing.Point(3, 46);
            this.updatesList.Name = "updatesList";
            this.updatesList.Size = new System.Drawing.Size(616, 292);
            this.updatesList.TabIndex = 2;
            this.updatesList.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.updatesList_ControlAdded);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatesList);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 341);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Updates";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.updDeleteBtn);
            this.panel2.Controls.Add(this.updEditBtn);
            this.panel2.Controls.Add(this.updCreateBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(616, 30);
            this.panel2.TabIndex = 4;
            // 
            // updDeleteBtn
            // 
            this.updDeleteBtn.Location = new System.Drawing.Point(165, 3);
            this.updDeleteBtn.Name = "updDeleteBtn";
            this.updDeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.updDeleteBtn.TabIndex = 5;
            this.updDeleteBtn.Text = "Delete";
            this.updDeleteBtn.UseVisualStyleBackColor = true;
            this.updDeleteBtn.Click += new System.EventHandler(this.updDeleteBtn_Click);
            // 
            // updEditBtn
            // 
            this.updEditBtn.Location = new System.Drawing.Point(84, 3);
            this.updEditBtn.Name = "updEditBtn";
            this.updEditBtn.Size = new System.Drawing.Size(75, 23);
            this.updEditBtn.TabIndex = 4;
            this.updEditBtn.Text = "Edit";
            this.updEditBtn.UseVisualStyleBackColor = true;
            this.updEditBtn.Click += new System.EventHandler(this.updEditBtn_Click);
            // 
            // updCreateBtn
            // 
            this.updCreateBtn.Location = new System.Drawing.Point(3, 3);
            this.updCreateBtn.Name = "updCreateBtn";
            this.updCreateBtn.Size = new System.Drawing.Size(75, 23);
            this.updCreateBtn.TabIndex = 3;
            this.updCreateBtn.Text = "Create\r\n";
            this.updCreateBtn.UseVisualStyleBackColor = true;
            this.updCreateBtn.Click += new System.EventHandler(this.updCreateBtn_Click);
            // 
            // IncidentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 632);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IncidentDetail";
            this.Text = "IncidentDetail";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private IncidentDetailControl details;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TreeView updatesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button updDeleteBtn;
        private System.Windows.Forms.Button updEditBtn;
        private System.Windows.Forms.Button updCreateBtn;
    }
}
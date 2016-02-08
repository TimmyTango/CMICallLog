namespace CMICallLog
{
    partial class EmailSettings
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
            this.hostTextBox = new System.Windows.Forms.TextBox();
            this.fromEmailTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.l54Box = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.storeBox = new System.Windows.Forms.CheckBox();
            this.superBox = new System.Windows.Forms.CheckBox();
            this.opsBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Host";
            // 
            // hostTextBox
            // 
            this.hostTextBox.Location = new System.Drawing.Point(76, 12);
            this.hostTextBox.Name = "hostTextBox";
            this.hostTextBox.Size = new System.Drawing.Size(190, 20);
            this.hostTextBox.TabIndex = 1;
            // 
            // fromEmailTextBox
            // 
            this.fromEmailTextBox.Location = new System.Drawing.Point(76, 38);
            this.fromEmailTextBox.Name = "fromEmailTextBox";
            this.fromEmailTextBox.Size = new System.Drawing.Size(190, 20);
            this.fromEmailTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "From";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(76, 64);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(190, 20);
            this.usernameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(76, 90);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(190, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password";
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(191, 190);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 8;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // l54Box
            // 
            this.l54Box.AutoSize = true;
            this.l54Box.Location = new System.Drawing.Point(65, 142);
            this.l54Box.Name = "l54Box";
            this.l54Box.Size = new System.Drawing.Size(54, 17);
            this.l54Box.TabIndex = 9;
            this.l54Box.Text = "List54";
            this.l54Box.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Send emails to:";
            // 
            // storeBox
            // 
            this.storeBox.AutoSize = true;
            this.storeBox.Location = new System.Drawing.Point(153, 142);
            this.storeBox.Name = "storeBox";
            this.storeBox.Size = new System.Drawing.Size(51, 17);
            this.storeBox.TabIndex = 11;
            this.storeBox.Text = "Store";
            this.storeBox.UseVisualStyleBackColor = true;
            // 
            // superBox
            // 
            this.superBox.AutoSize = true;
            this.superBox.Location = new System.Drawing.Point(65, 165);
            this.superBox.Name = "superBox";
            this.superBox.Size = new System.Drawing.Size(54, 17);
            this.superBox.TabIndex = 12;
            this.superBox.Text = "Super";
            this.superBox.UseVisualStyleBackColor = true;
            // 
            // opsBox
            // 
            this.opsBox.AutoSize = true;
            this.opsBox.Location = new System.Drawing.Point(153, 165);
            this.opsBox.Name = "opsBox";
            this.opsBox.Size = new System.Drawing.Size(66, 17);
            this.opsBox.TabIndex = 13;
            this.opsBox.Text = "Ops Mgr";
            this.opsBox.UseVisualStyleBackColor = true;
            // 
            // EmailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 218);
            this.Controls.Add(this.opsBox);
            this.Controls.Add(this.superBox);
            this.Controls.Add(this.storeBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l54Box);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fromEmailTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hostTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailSettings";
            this.Text = "Email Settings";
            this.Load += new System.EventHandler(this.EmailSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hostTextBox;
        private System.Windows.Forms.TextBox fromEmailTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.CheckBox l54Box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox storeBox;
        private System.Windows.Forms.CheckBox superBox;
        private System.Windows.Forms.CheckBox opsBox;
    }
}
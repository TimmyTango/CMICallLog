namespace CMICallLog
{
    partial class SetStoreManagers
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
            this.opsBox = new System.Windows.Forms.ListBox();
            this.supersBox = new System.Windows.Forms.ListBox();
            this.storesBox = new System.Windows.Forms.ListBox();
            this.storesToSuper = new System.Windows.Forms.Button();
            this.setSupervisorBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opsBox
            // 
            this.opsBox.FormattingEnabled = true;
            this.opsBox.Location = new System.Drawing.Point(12, 12);
            this.opsBox.Name = "opsBox";
            this.opsBox.Size = new System.Drawing.Size(186, 238);
            this.opsBox.TabIndex = 0;
            this.opsBox.SelectedValueChanged += new System.EventHandler(this.supersBox_SelectedValueChanged);
            // 
            // supersBox
            // 
            this.supersBox.FormattingEnabled = true;
            this.supersBox.Location = new System.Drawing.Point(204, 12);
            this.supersBox.Name = "supersBox";
            this.supersBox.Size = new System.Drawing.Size(186, 238);
            this.supersBox.TabIndex = 1;
            this.supersBox.SelectedValueChanged += new System.EventHandler(this.storesBox_SelectedValueChanged);
            // 
            // storesBox
            // 
            this.storesBox.FormattingEnabled = true;
            this.storesBox.Location = new System.Drawing.Point(396, 12);
            this.storesBox.Name = "storesBox";
            this.storesBox.Size = new System.Drawing.Size(186, 238);
            this.storesBox.TabIndex = 2;
            // 
            // storesToSuper
            // 
            this.storesToSuper.Location = new System.Drawing.Point(353, 256);
            this.storesToSuper.Name = "storesToSuper";
            this.storesToSuper.Size = new System.Drawing.Size(75, 23);
            this.storesToSuper.TabIndex = 3;
            this.storesToSuper.Text = "Set Stores";
            this.storesToSuper.UseVisualStyleBackColor = true;
            // 
            // setSupervisorBtn
            // 
            this.setSupervisorBtn.Location = new System.Drawing.Point(156, 256);
            this.setSupervisorBtn.Name = "setSupervisorBtn";
            this.setSupervisorBtn.Size = new System.Drawing.Size(75, 23);
            this.setSupervisorBtn.TabIndex = 4;
            this.setSupervisorBtn.Text = "Set Supers";
            this.setSupervisorBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(507, 298);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 5;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // SetStoreManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 333);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.setSupervisorBtn);
            this.Controls.Add(this.storesToSuper);
            this.Controls.Add(this.storesBox);
            this.Controls.Add(this.supersBox);
            this.Controls.Add(this.opsBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetStoreManagers";
            this.Text = "SetStoreManagers";
            this.Load += new System.EventHandler(this.SetStoreManagers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox opsBox;
        private System.Windows.Forms.ListBox supersBox;
        private System.Windows.Forms.ListBox storesBox;
        private System.Windows.Forms.Button storesToSuper;
        private System.Windows.Forms.Button setSupervisorBtn;
        private System.Windows.Forms.Button updateBtn;
    }
}
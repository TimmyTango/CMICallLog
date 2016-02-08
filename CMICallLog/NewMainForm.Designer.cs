namespace CMICallLog
{
    partial class NewMainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDBLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storeSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.storeListBox = new System.Windows.Forms.ToolStripComboBox();
            this.tsFiltersBtn = new System.Windows.Forms.ToolStripButton();
            this.tsCreateBtn = new System.Windows.Forms.ToolStripButton();
            this.tsQuickBtn = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closedIncidentsTab = new System.Windows.Forms.TabPage();
            this.closedIncidentsGrid = new System.Windows.Forms.DataGridView();
            this.openIncidentsTab = new System.Windows.Forms.TabPage();
            this.openIncidentsGrid = new System.Windows.Forms.DataGridView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.exportDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.closedIncidentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closedIncidentsGrid)).BeginInit();
            this.openIncidentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsGrid)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(759, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setDBLocationToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.emailTestToolStripMenuItem,
            this.storeSettingsToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // setDBLocationToolStripMenuItem
            // 
            this.setDBLocationToolStripMenuItem.Name = "setDBLocationToolStripMenuItem";
            this.setDBLocationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.setDBLocationToolStripMenuItem.Text = "Set DB Location";
            this.setDBLocationToolStripMenuItem.Click += new System.EventHandler(this.setDBLocationToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // emailTestToolStripMenuItem
            // 
            this.emailTestToolStripMenuItem.Name = "emailTestToolStripMenuItem";
            this.emailTestToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.emailTestToolStripMenuItem.Text = "Email Settings";
            this.emailTestToolStripMenuItem.Click += new System.EventHandler(this.emailTestToolStripMenuItem_Click);
            // 
            // storeSettingsToolStripMenuItem
            // 
            this.storeSettingsToolStripMenuItem.Name = "storeSettingsToolStripMenuItem";
            this.storeSettingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.storeSettingsToolStripMenuItem.Text = "Store Settings";
            this.storeSettingsToolStripMenuItem.Click += new System.EventHandler(this.storeSettingsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.storeListBox,
            this.tsFiltersBtn,
            this.tsCreateBtn,
            this.tsQuickBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(759, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "Store:";
            // 
            // storeListBox
            // 
            this.storeListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.storeListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.storeListBox.Name = "storeListBox";
            this.storeListBox.Size = new System.Drawing.Size(121, 25);
            this.storeListBox.SelectedIndexChanged += new System.EventHandler(this.storeListBox_SelectedIndexChanged);
            // 
            // tsFiltersBtn
            // 
            this.tsFiltersBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsFiltersBtn.Image")));
            this.tsFiltersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsFiltersBtn.Name = "tsFiltersBtn";
            this.tsFiltersBtn.Size = new System.Drawing.Size(58, 22);
            this.tsFiltersBtn.Text = "Filters";
            this.tsFiltersBtn.Click += new System.EventHandler(this.tsFiltersBtn_Click);
            // 
            // tsCreateBtn
            // 
            this.tsCreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsCreateBtn.Image")));
            this.tsCreateBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCreateBtn.Name = "tsCreateBtn";
            this.tsCreateBtn.Size = new System.Drawing.Size(107, 22);
            this.tsCreateBtn.Text = "Create Incident";
            this.tsCreateBtn.Click += new System.EventHandler(this.createIncidentToolStripMenuItem_Click);
            // 
            // tsQuickBtn
            // 
            this.tsQuickBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsQuickBtn.Image")));
            this.tsQuickBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuickBtn.Name = "tsQuickBtn";
            this.tsQuickBtn.Size = new System.Drawing.Size(71, 22);
            this.tsQuickBtn.Text = "Live Call";
            this.tsQuickBtn.Click += new System.EventHandler(this.tsQuickBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createIncidentToolStripMenuItem,
            this.completeIncidentToolStripMenuItem,
            this.editSelectedIncidentToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.deleteSelectedIncidentToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(173, 114);
            // 
            // createIncidentToolStripMenuItem
            // 
            this.createIncidentToolStripMenuItem.Name = "createIncidentToolStripMenuItem";
            this.createIncidentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createIncidentToolStripMenuItem.Text = "Create Incident";
            this.createIncidentToolStripMenuItem.Click += new System.EventHandler(this.createIncidentToolStripMenuItem_Click);
            // 
            // completeIncidentToolStripMenuItem
            // 
            this.completeIncidentToolStripMenuItem.Name = "completeIncidentToolStripMenuItem";
            this.completeIncidentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.completeIncidentToolStripMenuItem.Text = "Complete Incident";
            this.completeIncidentToolStripMenuItem.Click += new System.EventHandler(this.completeIncidentToolStripMenuItem_Click);
            // 
            // editSelectedIncidentToolStripMenuItem
            // 
            this.editSelectedIncidentToolStripMenuItem.Name = "editSelectedIncidentToolStripMenuItem";
            this.editSelectedIncidentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.editSelectedIncidentToolStripMenuItem.Text = "Edit Incident";
            this.editSelectedIncidentToolStripMenuItem.Click += new System.EventHandler(this.editSelectedIncidentToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.copyToolStripMenuItem.Text = "Copy Incident";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // deleteSelectedIncidentToolStripMenuItem
            // 
            this.deleteSelectedIncidentToolStripMenuItem.Name = "deleteSelectedIncidentToolStripMenuItem";
            this.deleteSelectedIncidentToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deleteSelectedIncidentToolStripMenuItem.Text = "Delete Incident";
            this.deleteSelectedIncidentToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectedIncidentToolStripMenuItem_Click);
            // 
            // closedIncidentsTab
            // 
            this.closedIncidentsTab.Controls.Add(this.closedIncidentsGrid);
            this.closedIncidentsTab.Location = new System.Drawing.Point(4, 22);
            this.closedIncidentsTab.Name = "closedIncidentsTab";
            this.closedIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.closedIncidentsTab.Size = new System.Drawing.Size(751, 512);
            this.closedIncidentsTab.TabIndex = 1;
            this.closedIncidentsTab.Text = "Closed Incidents";
            this.closedIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // closedIncidentsGrid
            // 
            this.closedIncidentsGrid.AllowUserToAddRows = false;
            this.closedIncidentsGrid.AllowUserToDeleteRows = false;
            this.closedIncidentsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.closedIncidentsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.closedIncidentsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.closedIncidentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.closedIncidentsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.closedIncidentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closedIncidentsGrid.Location = new System.Drawing.Point(3, 3);
            this.closedIncidentsGrid.MultiSelect = false;
            this.closedIncidentsGrid.Name = "closedIncidentsGrid";
            this.closedIncidentsGrid.ReadOnly = true;
            this.closedIncidentsGrid.RowHeadersVisible = false;
            this.closedIncidentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closedIncidentsGrid.Size = new System.Drawing.Size(745, 506);
            this.closedIncidentsGrid.TabIndex = 2;
            this.closedIncidentsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.closedIncidentsGrid_CellDoubleClick);
            this.closedIncidentsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.closedIncidentsGrid_CellMouseDown);
            // 
            // openIncidentsTab
            // 
            this.openIncidentsTab.Controls.Add(this.openIncidentsGrid);
            this.openIncidentsTab.Location = new System.Drawing.Point(4, 22);
            this.openIncidentsTab.Name = "openIncidentsTab";
            this.openIncidentsTab.Padding = new System.Windows.Forms.Padding(3);
            this.openIncidentsTab.Size = new System.Drawing.Size(751, 512);
            this.openIncidentsTab.TabIndex = 0;
            this.openIncidentsTab.Text = "Open Incidents";
            this.openIncidentsTab.UseVisualStyleBackColor = true;
            // 
            // openIncidentsGrid
            // 
            this.openIncidentsGrid.AllowUserToAddRows = false;
            this.openIncidentsGrid.AllowUserToDeleteRows = false;
            this.openIncidentsGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            this.openIncidentsGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.openIncidentsGrid.BackgroundColor = System.Drawing.SystemColors.Control;
            this.openIncidentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.openIncidentsGrid.ContextMenuStrip = this.contextMenuStrip1;
            this.openIncidentsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsGrid.Location = new System.Drawing.Point(3, 3);
            this.openIncidentsGrid.MultiSelect = false;
            this.openIncidentsGrid.Name = "openIncidentsGrid";
            this.openIncidentsGrid.ReadOnly = true;
            this.openIncidentsGrid.RowHeadersVisible = false;
            this.openIncidentsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.openIncidentsGrid.Size = new System.Drawing.Size(745, 506);
            this.openIncidentsGrid.TabIndex = 0;
            this.openIncidentsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.openIncidentsGrid_CellDoubleClick);
            this.openIncidentsGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.openIncidentsGrid_CellMouseDown);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.openIncidentsTab);
            this.mainTabControl.Controls.Add(this.closedIncidentsTab);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 49);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(759, 538);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTabControl_Selected);
            // 
            // exportDialog
            // 
            this.exportDialog.DefaultExt = "xlsx";
            this.exportDialog.FileName = "Call Log Export";
            this.exportDialog.Filter = "Excel Sheet|*.xlsx|All files|*.*";
            this.exportDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportDialog_FileOk);
            // 
            // NewMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 587);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewMainForm";
            this.Text = "CMI Call Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewMainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.closedIncidentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closedIncidentsGrid)).EndInit();
            this.openIncidentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openIncidentsGrid)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox storeListBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton tsCreateBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedIncidentToolStripMenuItem;
        private System.Windows.Forms.TabPage closedIncidentsTab;
        private System.Windows.Forms.DataGridView closedIncidentsGrid;
        private System.Windows.Forms.TabPage openIncidentsTab;
        private System.Windows.Forms.DataGridView openIncidentsGrid;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.ToolStripButton tsQuickBtn;
        private System.Windows.Forms.ToolStripMenuItem completeIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDBLocationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog exportDialog;
        private System.Windows.Forms.ToolStripMenuItem emailTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storeSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsFiltersBtn;
    }
}
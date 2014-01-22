namespace UniLauncher
{
    partial class frmMain
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
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddEntry = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnAddCategory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnSettings = new System.Windows.Forms.ToolStripButton();
            this.tabControlCategorys = new System.Windows.Forms.TabControl();
            this.tabPageDefault = new System.Windows.Forms.TabPage();
            this.mainToolStrip.SuspendLayout();
            this.tabControlCategorys.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.AllowItemReorder = true;
            this.mainToolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainToolStrip.AutoSize = false;
            this.mainToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddEntry,
            this.toolStripBtnAddCategory,
            this.toolStripSeparator1,
            this.toolStripBtnEdit,
            this.toolStripSeparator2,
            this.toolStripBtnSettings});
            this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainToolStrip.Size = new System.Drawing.Size(435, 48);
            this.mainToolStrip.TabIndex = 0;
            this.mainToolStrip.Text = "Tool Strip";
            // 
            // toolStripBtnAddEntry
            // 
            this.toolStripBtnAddEntry.AutoSize = false;
            this.toolStripBtnAddEntry.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAddEntry.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnAddEntry.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddEntry.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripBtnAddEntry.Name = "toolStripBtnAddEntry";
            this.toolStripBtnAddEntry.Size = new System.Drawing.Size(42, 42);
            this.toolStripBtnAddEntry.Text = "Add Entry";
            this.toolStripBtnAddEntry.Click += new System.EventHandler(this.toolStripBtnAddEntry_Click);
            // 
            // toolStripBtnAddCategory
            // 
            this.toolStripBtnAddCategory.AutoSize = false;
            this.toolStripBtnAddCategory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnAddCategory.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddCategory.Name = "toolStripBtnAddCategory";
            this.toolStripBtnAddCategory.Size = new System.Drawing.Size(42, 42);
            this.toolStripBtnAddCategory.Text = "Add Category";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripBtnEdit
            // 
            this.toolStripBtnEdit.AutoSize = false;
            this.toolStripBtnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnEdit.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripBtnEdit.Name = "toolStripBtnEdit";
            this.toolStripBtnEdit.Size = new System.Drawing.Size(42, 42);
            this.toolStripBtnEdit.Text = "Edit";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripBtnSettings
            // 
            this.toolStripBtnSettings.AutoSize = false;
            this.toolStripBtnSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSettings.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripBtnSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSettings.Name = "toolStripBtnSettings";
            this.toolStripBtnSettings.Size = new System.Drawing.Size(42, 42);
            this.toolStripBtnSettings.Text = "Settings";
            // 
            // tabControlCategorys
            // 
            this.tabControlCategorys.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlCategorys.Controls.Add(this.tabPageDefault);
            this.tabControlCategorys.Location = new System.Drawing.Point(13, 51);
            this.tabControlCategorys.Name = "tabControlCategorys";
            this.tabControlCategorys.SelectedIndex = 0;
            this.tabControlCategorys.Size = new System.Drawing.Size(409, 448);
            this.tabControlCategorys.TabIndex = 1;
            // 
            // tabPageDefault
            // 
            this.tabPageDefault.Location = new System.Drawing.Point(4, 22);
            this.tabPageDefault.Name = "tabPageDefault";
            this.tabPageDefault.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDefault.Size = new System.Drawing.Size(401, 422);
            this.tabPageDefault.TabIndex = 0;
            this.tabPageDefault.Text = "Default";
            this.tabPageDefault.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 511);
            this.Controls.Add(this.tabControlCategorys);
            this.Controls.Add(this.mainToolStrip);
            this.MinimumSize = new System.Drawing.Size(350, 450);
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Text = "UniLauncher";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.tabControlCategorys.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddEntry;
        private System.Windows.Forms.ToolStripButton toolStripBtnEdit;
        private System.Windows.Forms.ToolStripButton toolStripBtnSettings;
        private System.Windows.Forms.TabControl tabControlCategorys;
        private System.Windows.Forms.TabPage tabPageDefault;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddCategory;
    }
}


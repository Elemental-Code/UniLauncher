namespace UniLauncher
{
    partial class frmAdd
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtBoxLocation = new System.Windows.Forms.TextBox();
            this.btnLocate = new System.Windows.Forms.Button();
            this.opnFileDialogLocate = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.Location = new System.Drawing.Point(12, 33);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(262, 20);
            this.txtBoxName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblName.Location = new System.Drawing.Point(9, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(196, 226);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Done!";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.lblLocation.Location = new System.Drawing.Point(9, 69);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(62, 16);
            this.lblLocation.TabIndex = 3;
            this.lblLocation.Text = "Location:";
            // 
            // txtBoxLocation
            // 
            this.txtBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLocation.Location = new System.Drawing.Point(12, 88);
            this.txtBoxLocation.Name = "txtBoxLocation";
            this.txtBoxLocation.Size = new System.Drawing.Size(232, 20);
            this.txtBoxLocation.TabIndex = 4;
            // 
            // btnLocate
            // 
            this.btnLocate.Location = new System.Drawing.Point(250, 87);
            this.btnLocate.Name = "btnLocate";
            this.btnLocate.Size = new System.Drawing.Size(24, 22);
            this.btnLocate.TabIndex = 5;
            this.btnLocate.Text = "...";
            this.btnLocate.UseVisualStyleBackColor = true;
            this.btnLocate.Click += new System.EventHandler(this.btnLocate_Click);
            // 
            // opnFileDialogLocate
            // 
            this.opnFileDialogLocate.FileName = "openFileDialog1";
            // 
            // frmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLocate);
            this.Controls.Add(this.txtBoxLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxName);
            this.Name = "frmAdd";
            this.Text = "UniLauncher - Add";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdd_FormClosing);
            this.Load += new System.EventHandler(this.frmAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtBoxLocation;
        private System.Windows.Forms.Button btnLocate;
        private System.Windows.Forms.OpenFileDialog opnFileDialogLocate;
    }
}
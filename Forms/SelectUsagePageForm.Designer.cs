namespace HID_Report_Descriptor_Editor.Forms
{
    partial class SelectUsagePageForm
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.ListUsagePages = new System.Windows.Forms.ListView();
            this.ColumnName = new System.Windows.Forms.ColumnHeader();
            this.ColumnHEX = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(208, 288);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(73, 26);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(287, 288);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(73, 26);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ListUsagePages
            // 
            this.ListUsagePages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListUsagePages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnName,
            this.ColumnHEX});
            this.ListUsagePages.FullRowSelect = true;
            this.ListUsagePages.HideSelection = false;
            this.ListUsagePages.Location = new System.Drawing.Point(12, 12);
            this.ListUsagePages.MultiSelect = false;
            this.ListUsagePages.Name = "ListUsagePages";
            this.ListUsagePages.Size = new System.Drawing.Size(348, 270);
            this.ListUsagePages.TabIndex = 1;
            this.ListUsagePages.UseCompatibleStateImageBehavior = false;
            this.ListUsagePages.View = System.Windows.Forms.View.Details;
            this.ListUsagePages.DoubleClick += new System.EventHandler(this.ListView1_DoubleClick);
            // 
            // ColumnName
            // 
            this.ColumnName.DisplayIndex = 1;
            this.ColumnName.Text = "Название";
            this.ColumnName.Width = 220;
            // 
            // ColumnHEX
            // 
            this.ColumnHEX.DisplayIndex = 0;
            this.ColumnHEX.Text = "HEX";
            // 
            // SelectUsagePageForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(372, 322);
            this.Controls.Add(this.ListUsagePages);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectUsagePageForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select Type";
            this.Resize += new System.EventHandler(this.SelectUsagePageForm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ListView ListUsagePages;
        private System.Windows.Forms.ColumnHeader ColumnHEX;
        private System.Windows.Forms.ColumnHeader ColumnName;
    }
}
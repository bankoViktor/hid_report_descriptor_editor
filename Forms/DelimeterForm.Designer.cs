namespace HID_Report_Descriptor_Editor.Forms
{
    partial class DelimeterForm
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
            this.RbDelimeterOpen = new System.Windows.Forms.RadioButton();
            this.RbDelimeterClose = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(121, 102);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(84, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(211, 102);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // RbDelimeterOpen
            // 
            this.RbDelimeterOpen.AutoSize = true;
            this.RbDelimeterOpen.Checked = true;
            this.RbDelimeterOpen.Location = new System.Drawing.Point(51, 29);
            this.RbDelimeterOpen.Name = "RbDelimeterOpen";
            this.RbDelimeterOpen.Size = new System.Drawing.Size(54, 19);
            this.RbDelimeterOpen.TabIndex = 1;
            this.RbDelimeterOpen.TabStop = true;
            this.RbDelimeterOpen.Tag = "1";
            this.RbDelimeterOpen.Text = "Open";
            this.RbDelimeterOpen.UseVisualStyleBackColor = true;
            // 
            // RbDelimeterClose
            // 
            this.RbDelimeterClose.AutoSize = true;
            this.RbDelimeterClose.Location = new System.Drawing.Point(51, 54);
            this.RbDelimeterClose.Name = "RbDelimeterClose";
            this.RbDelimeterClose.Size = new System.Drawing.Size(54, 19);
            this.RbDelimeterClose.TabIndex = 1;
            this.RbDelimeterClose.Tag = "0";
            this.RbDelimeterClose.Text = "Close";
            this.RbDelimeterClose.UseVisualStyleBackColor = true;
            // 
            // DelimeterForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(307, 137);
            this.Controls.Add(this.RbDelimeterClose);
            this.Controls.Add(this.RbDelimeterOpen);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DelimeterForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Delimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RbDelimeterOpen;
        private System.Windows.Forms.RadioButton RbDelimeterClose;
    }
}
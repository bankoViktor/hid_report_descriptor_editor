namespace HID_Report_Descriptor_Editor.Forms
{
    partial class CollectionForm
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
            this.ColTypePhysical = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColTypeVendorDefined = new System.Windows.Forms.RadioButton();
            this.ColTypeUsageModifier = new System.Windows.Forms.RadioButton();
            this.ColTypeUsageSwitch = new System.Windows.Forms.RadioButton();
            this.ColTypeNamedArray = new System.Windows.Forms.RadioButton();
            this.ColTypeReport = new System.Windows.Forms.RadioButton();
            this.ColTypeLogical = new System.Windows.Forms.RadioButton();
            this.ColTypeApplication = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(126, 151);
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
            this.BtnCancel.Location = new System.Drawing.Point(216, 151);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ColTypePhysical
            // 
            this.ColTypePhysical.AutoSize = true;
            this.ColTypePhysical.Checked = true;
            this.ColTypePhysical.Location = new System.Drawing.Point(17, 22);
            this.ColTypePhysical.Name = "ColTypePhysical";
            this.ColTypePhysical.Size = new System.Drawing.Size(68, 19);
            this.ColTypePhysical.TabIndex = 1;
            this.ColTypePhysical.TabStop = true;
            this.ColTypePhysical.Text = "Physical";
            this.ColTypePhysical.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ColTypeVendorDefined);
            this.groupBox1.Controls.Add(this.ColTypeUsageModifier);
            this.groupBox1.Controls.Add(this.ColTypeUsageSwitch);
            this.groupBox1.Controls.Add(this.ColTypeNamedArray);
            this.groupBox1.Controls.Add(this.ColTypeReport);
            this.groupBox1.Controls.Add(this.ColTypeLogical);
            this.groupBox1.Controls.Add(this.ColTypeApplication);
            this.groupBox1.Controls.Add(this.ColTypePhysical);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 133);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Collection Type";
            // 
            // ColTypeVendorDefined
            // 
            this.ColTypeVendorDefined.AutoSize = true;
            this.ColTypeVendorDefined.Location = new System.Drawing.Point(154, 97);
            this.ColTypeVendorDefined.Name = "ColTypeVendorDefined";
            this.ColTypeVendorDefined.Size = new System.Drawing.Size(106, 19);
            this.ColTypeVendorDefined.TabIndex = 1;
            this.ColTypeVendorDefined.Text = "Vendor Defined";
            this.ColTypeVendorDefined.UseVisualStyleBackColor = true;
            // 
            // ColTypeUsageModifier
            // 
            this.ColTypeUsageModifier.AutoSize = true;
            this.ColTypeUsageModifier.Location = new System.Drawing.Point(154, 72);
            this.ColTypeUsageModifier.Name = "ColTypeUsageModifier";
            this.ColTypeUsageModifier.Size = new System.Drawing.Size(105, 19);
            this.ColTypeUsageModifier.TabIndex = 1;
            this.ColTypeUsageModifier.Text = "Usage Modifier";
            this.ColTypeUsageModifier.UseVisualStyleBackColor = true;
            // 
            // ColTypeUsageSwitch
            // 
            this.ColTypeUsageSwitch.AutoSize = true;
            this.ColTypeUsageSwitch.Location = new System.Drawing.Point(154, 47);
            this.ColTypeUsageSwitch.Name = "ColTypeUsageSwitch";
            this.ColTypeUsageSwitch.Size = new System.Drawing.Size(95, 19);
            this.ColTypeUsageSwitch.TabIndex = 1;
            this.ColTypeUsageSwitch.Text = "Usage Switch";
            this.ColTypeUsageSwitch.UseVisualStyleBackColor = true;
            // 
            // ColTypeNamedArray
            // 
            this.ColTypeNamedArray.AutoSize = true;
            this.ColTypeNamedArray.Location = new System.Drawing.Point(154, 22);
            this.ColTypeNamedArray.Name = "ColTypeNamedArray";
            this.ColTypeNamedArray.Size = new System.Drawing.Size(95, 19);
            this.ColTypeNamedArray.TabIndex = 1;
            this.ColTypeNamedArray.Text = "Named Array";
            this.ColTypeNamedArray.UseVisualStyleBackColor = true;
            // 
            // ColTypeReport
            // 
            this.ColTypeReport.AutoSize = true;
            this.ColTypeReport.Location = new System.Drawing.Point(17, 97);
            this.ColTypeReport.Name = "ColTypeReport";
            this.ColTypeReport.Size = new System.Drawing.Size(60, 19);
            this.ColTypeReport.TabIndex = 1;
            this.ColTypeReport.Text = "Report";
            this.ColTypeReport.UseVisualStyleBackColor = true;
            // 
            // ColTypeLogical
            // 
            this.ColTypeLogical.AutoSize = true;
            this.ColTypeLogical.Location = new System.Drawing.Point(17, 72);
            this.ColTypeLogical.Name = "ColTypeLogical";
            this.ColTypeLogical.Size = new System.Drawing.Size(63, 19);
            this.ColTypeLogical.TabIndex = 1;
            this.ColTypeLogical.Text = "Logical";
            this.ColTypeLogical.UseVisualStyleBackColor = true;
            // 
            // ColTypeApplication
            // 
            this.ColTypeApplication.AutoSize = true;
            this.ColTypeApplication.Location = new System.Drawing.Point(17, 47);
            this.ColTypeApplication.Name = "ColTypeApplication";
            this.ColTypeApplication.Size = new System.Drawing.Size(86, 19);
            this.ColTypeApplication.TabIndex = 1;
            this.ColTypeApplication.Text = "Application";
            this.ColTypeApplication.UseVisualStyleBackColor = true;
            // 
            // CollectionForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(312, 186);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CollectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Collection";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton ColTypePhysical;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ColTypeApplication;
        private System.Windows.Forms.RadioButton ColTypeReport;
        private System.Windows.Forms.RadioButton ColTypeLogical;
        private System.Windows.Forms.RadioButton ColTypeVendorDefined;
        private System.Windows.Forms.RadioButton ColTypeUsageModifier;
        private System.Windows.Forms.RadioButton ColTypeUsageSwitch;
        private System.Windows.Forms.RadioButton ColTypeNamedArray;
    }
}
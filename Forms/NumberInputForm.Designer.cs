namespace HID_Report_Descriptor_Editor.Forms
{
    partial class NumberInputForm
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
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.RbDEC = new System.Windows.Forms.RadioButton();
            this.RbHEX = new System.Windows.Forms.RadioButton();
            this.TbValue = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LabelRange = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(161, 95);
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
            this.BtnCancel.Location = new System.Drawing.Point(251, 95);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // RbDEC
            // 
            this.RbDEC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbDEC.AutoSize = true;
            this.RbDEC.Checked = true;
            this.RbDEC.Location = new System.Drawing.Point(288, 24);
            this.RbDEC.Name = "RbDEC";
            this.RbDEC.Size = new System.Drawing.Size(47, 19);
            this.RbDEC.TabIndex = 1;
            this.RbDEC.TabStop = true;
            this.RbDEC.Text = "DEC";
            this.RbDEC.UseVisualStyleBackColor = true;
            this.RbDEC.CheckedChanged += new System.EventHandler(this.RbDEC_CheckedChanged);
            // 
            // RbHEX
            // 
            this.RbHEX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RbHEX.AutoSize = true;
            this.RbHEX.Location = new System.Drawing.Point(288, 49);
            this.RbHEX.Name = "RbHEX";
            this.RbHEX.Size = new System.Drawing.Size(47, 19);
            this.RbHEX.TabIndex = 1;
            this.RbHEX.Text = "HEX";
            this.RbHEX.UseVisualStyleBackColor = true;
            this.RbHEX.CheckedChanged += new System.EventHandler(this.RbHEX_CheckedChanged);
            // 
            // TbValue
            // 
            this.TbValue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TbValue.Location = new System.Drawing.Point(12, 23);
            this.TbValue.MaxLength = 100;
            this.TbValue.Name = "TbValue";
            this.TbValue.Size = new System.Drawing.Size(233, 23);
            this.TbValue.TabIndex = 2;
            this.TbValue.WordWrap = false;
            this.TbValue.Validating += new System.ComponentModel.CancelEventHandler(this.TbValue_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LabelRange
            // 
            this.LabelRange.AutoSize = true;
            this.LabelRange.Location = new System.Drawing.Point(12, 53);
            this.LabelRange.Name = "LabelRange";
            this.LabelRange.Size = new System.Drawing.Size(43, 15);
            this.LabelRange.TabIndex = 3;
            this.LabelRange.Text = "Range:";
            // 
            // NumberInputForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(347, 130);
            this.Controls.Add(this.LabelRange);
            this.Controls.Add(this.TbValue);
            this.Controls.Add(this.RbHEX);
            this.Controls.Add(this.RbDEC);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NumberInputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Number";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton RbDEC;
        private System.Windows.Forms.RadioButton RbHEX;
        private System.Windows.Forms.TextBox TbValue;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label LabelRange;
    }
}
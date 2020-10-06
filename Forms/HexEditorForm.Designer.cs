
namespace HID_Report_Descriptor_Editor.Forms
{
    partial class HexEditorForm
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
            this.TbDump = new System.Windows.Forms.TextBox();
            this.TbLongTag = new System.Windows.Forms.TextBox();
            this.LabelLongTag = new System.Windows.Forms.Label();
            this.LabelDump = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(288, 335);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(80, 23);
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(374, 335);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(80, 23);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // TbDump
            // 
            this.TbDump.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDump.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbDump.Location = new System.Drawing.Point(12, 68);
            this.TbDump.Multiline = true;
            this.TbDump.Name = "TbDump";
            this.TbDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TbDump.Size = new System.Drawing.Size(424, 261);
            this.TbDump.TabIndex = 1;
            this.TbDump.Validating += new System.ComponentModel.CancelEventHandler(this.TbDump_Validating);
            // 
            // TbLongTag
            // 
            this.TbLongTag.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbLongTag.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbLongTag.Location = new System.Drawing.Point(106, 12);
            this.TbLongTag.MaxLength = 100;
            this.TbLongTag.Name = "TbLongTag";
            this.TbLongTag.Size = new System.Drawing.Size(330, 22);
            this.TbLongTag.TabIndex = 0;
            this.TbLongTag.WordWrap = false;
            this.TbLongTag.Validating += new System.ComponentModel.CancelEventHandler(this.TbLongTag_Validating);
            // 
            // LabelLongTag
            // 
            this.LabelLongTag.AutoSize = true;
            this.LabelLongTag.Location = new System.Drawing.Point(12, 15);
            this.LabelLongTag.Name = "LabelLongTag";
            this.LabelLongTag.Size = new System.Drawing.Size(88, 15);
            this.LabelLongTag.TabIndex = 5;
            this.LabelLongTag.Text = "Long Tag (hex):";
            // 
            // LabelDump
            // 
            this.LabelDump.AutoSize = true;
            this.LabelDump.Location = new System.Drawing.Point(12, 50);
            this.LabelDump.Name = "LabelDump";
            this.LabelDump.Size = new System.Drawing.Size(120, 15);
            this.LabelDump.TabIndex = 6;
            this.LabelDump.Text = "Memory dump (hex):";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // HexEditorForm
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(466, 370);
            this.Controls.Add(this.LabelDump);
            this.Controls.Add(this.LabelLongTag);
            this.Controls.Add(this.TbLongTag);
            this.Controls.Add(this.TbDump);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.Name = "HexEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Long Item Data";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TbDump;
        private System.Windows.Forms.TextBox TbLongTag;
        private System.Windows.Forms.Label LabelLongTag;
        private System.Windows.Forms.Label LabelDump;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
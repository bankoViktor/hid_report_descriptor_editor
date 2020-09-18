namespace HID_Report_Descriptor_Editor.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.BtnOK = new System.Windows.Forms.Button();
            this.LabelCR = new System.Windows.Forms.Label();
            this.LabelProductVersion = new System.Windows.Forms.Label();
            this.LabelProductName = new System.Windows.Forms.Label();
            this.BtnVisitWebSite = new System.Windows.Forms.Button();
            this.LinkEmail = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            resources.ApplyResources(this.BtnOK, "BtnOK");
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.UseVisualStyleBackColor = true;
            // 
            // LabelCR
            // 
            resources.ApplyResources(this.LabelCR, "LabelCR");
            this.LabelCR.BackColor = System.Drawing.Color.Transparent;
            this.LabelCR.Name = "LabelCR";
            // 
            // LabelProductVersion
            // 
            resources.ApplyResources(this.LabelProductVersion, "LabelProductVersion");
            this.LabelProductVersion.Name = "LabelProductVersion";
            // 
            // LabelProductName
            // 
            resources.ApplyResources(this.LabelProductName, "LabelProductName");
            this.LabelProductName.Name = "LabelProductName";
            // 
            // BtnVisitWebSite
            // 
            resources.ApplyResources(this.BtnVisitWebSite, "BtnVisitWebSite");
            this.BtnVisitWebSite.Name = "BtnVisitWebSite";
            this.BtnVisitWebSite.UseVisualStyleBackColor = true;
            this.BtnVisitWebSite.Click += new System.EventHandler(this.BtnVisitWebSite_Click);
            // 
            // LinkEmail
            // 
            resources.ApplyResources(this.LinkEmail, "LinkEmail");
            this.LinkEmail.Name = "LinkEmail";
            this.LinkEmail.TabStop = true;
            this.LinkEmail.Click += new System.EventHandler(this.LinkEmail_Click);
            // 
            // AboutForm
            // 
            this.AcceptButton = this.BtnOK;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LinkEmail);
            this.Controls.Add(this.BtnVisitWebSite);
            this.Controls.Add(this.LabelProductName);
            this.Controls.Add(this.LabelProductVersion);
            this.Controls.Add(this.LabelCR);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Label LabelCR;
        private System.Windows.Forms.Label LabelProductName;
        private System.Windows.Forms.Label LabelProductVersion;
        private System.Windows.Forms.Button BtnVisitWebSite;
        private System.Windows.Forms.LinkLabel LinkEmail;
    }
}
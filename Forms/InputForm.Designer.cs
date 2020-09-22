namespace HID_Report_Descriptor_Editor.Forms
{
    partial class InputForm
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
            this.rb0_Data = new System.Windows.Forms.RadioButton();
            this.gb0 = new System.Windows.Forms.GroupBox();
            this.rb0_Constant = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rb1_Variable = new System.Windows.Forms.RadioButton();
            this.rb1_Array = new System.Windows.Forms.RadioButton();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.rb2_Relative = new System.Windows.Forms.RadioButton();
            this.rb2_Absolute = new System.Windows.Forms.RadioButton();
            this.gb3 = new System.Windows.Forms.GroupBox();
            this.rb3_Wrap = new System.Windows.Forms.RadioButton();
            this.rb3_NoWrap = new System.Windows.Forms.RadioButton();
            this.gb4 = new System.Windows.Forms.GroupBox();
            this.rb4_NoLinear = new System.Windows.Forms.RadioButton();
            this.rb4_Linear = new System.Windows.Forms.RadioButton();
            this.gb5 = new System.Windows.Forms.GroupBox();
            this.rb5_NoPreferred = new System.Windows.Forms.RadioButton();
            this.rb5_PreferredState = new System.Windows.Forms.RadioButton();
            this.gb6 = new System.Windows.Forms.GroupBox();
            this.rb6_NullState = new System.Windows.Forms.RadioButton();
            this.rb6_NotNullPosition = new System.Windows.Forms.RadioButton();
            this.gb7 = new System.Windows.Forms.GroupBox();
            this.rb7_Valatile = new System.Windows.Forms.RadioButton();
            this.rb7_NotValatile = new System.Windows.Forms.RadioButton();
            this.gb8 = new System.Windows.Forms.GroupBox();
            this.rb8_Buffered = new System.Windows.Forms.RadioButton();
            this.rb8_BitField = new System.Windows.Forms.RadioButton();
            this.gb0.SuspendLayout();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.gb3.SuspendLayout();
            this.gb4.SuspendLayout();
            this.gb5.SuspendLayout();
            this.gb6.SuspendLayout();
            this.gb7.SuspendLayout();
            this.gb8.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(423, 300);
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
            this.BtnCancel.Location = new System.Drawing.Point(423, 329);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(84, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // rb0_Data
            // 
            this.rb0_Data.AutoSize = true;
            this.rb0_Data.Checked = true;
            this.rb0_Data.Location = new System.Drawing.Point(18, 24);
            this.rb0_Data.Name = "rb0_Data";
            this.rb0_Data.Size = new System.Drawing.Size(49, 19);
            this.rb0_Data.TabIndex = 1;
            this.rb0_Data.TabStop = true;
            this.rb0_Data.Tag = "0:0";
            this.rb0_Data.Text = "Data";
            this.rb0_Data.UseVisualStyleBackColor = true;
            // 
            // gb0
            // 
            this.gb0.Controls.Add(this.rb0_Constant);
            this.gb0.Controls.Add(this.rb0_Data);
            this.gb0.Location = new System.Drawing.Point(12, 12);
            this.gb0.Name = "gb0";
            this.gb0.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb0.Size = new System.Drawing.Size(160, 80);
            this.gb0.TabIndex = 2;
            this.gb0.TabStop = false;
            this.gb0.Text = "Bit 0";
            // 
            // rb0_Constant
            // 
            this.rb0_Constant.AutoSize = true;
            this.rb0_Constant.Location = new System.Drawing.Point(18, 49);
            this.rb0_Constant.Name = "rb0_Constant";
            this.rb0_Constant.Size = new System.Drawing.Size(73, 19);
            this.rb0_Constant.TabIndex = 2;
            this.rb0_Constant.TabStop = true;
            this.rb0_Constant.Tag = "0:1";
            this.rb0_Constant.Text = "Constant";
            this.rb0_Constant.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rb1_Variable);
            this.gb1.Controls.Add(this.rb1_Array);
            this.gb1.Location = new System.Drawing.Point(12, 98);
            this.gb1.Name = "gb1";
            this.gb1.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb1.Size = new System.Drawing.Size(160, 80);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "Bit 1";
            // 
            // rb1_Variable
            // 
            this.rb1_Variable.AutoSize = true;
            this.rb1_Variable.Location = new System.Drawing.Point(18, 49);
            this.rb1_Variable.Name = "rb1_Variable";
            this.rb1_Variable.Size = new System.Drawing.Size(66, 19);
            this.rb1_Variable.TabIndex = 2;
            this.rb1_Variable.TabStop = true;
            this.rb1_Variable.Tag = "1:1";
            this.rb1_Variable.Text = "Variable";
            this.rb1_Variable.UseVisualStyleBackColor = true;
            // 
            // rb1_Array
            // 
            this.rb1_Array.AutoSize = true;
            this.rb1_Array.Checked = true;
            this.rb1_Array.Location = new System.Drawing.Point(18, 24);
            this.rb1_Array.Name = "rb1_Array";
            this.rb1_Array.Size = new System.Drawing.Size(53, 19);
            this.rb1_Array.TabIndex = 1;
            this.rb1_Array.TabStop = true;
            this.rb1_Array.Tag = "1:0";
            this.rb1_Array.Text = "Array";
            this.rb1_Array.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.rb2_Relative);
            this.gb2.Controls.Add(this.rb2_Absolute);
            this.gb2.Location = new System.Drawing.Point(12, 184);
            this.gb2.Name = "gb2";
            this.gb2.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb2.Size = new System.Drawing.Size(160, 80);
            this.gb2.TabIndex = 4;
            this.gb2.TabStop = false;
            this.gb2.Text = "Bit 2";
            // 
            // rb2_Relative
            // 
            this.rb2_Relative.AutoSize = true;
            this.rb2_Relative.Location = new System.Drawing.Point(18, 49);
            this.rb2_Relative.Name = "rb2_Relative";
            this.rb2_Relative.Size = new System.Drawing.Size(66, 19);
            this.rb2_Relative.TabIndex = 2;
            this.rb2_Relative.TabStop = true;
            this.rb2_Relative.Tag = "2:1";
            this.rb2_Relative.Text = "Relative";
            this.rb2_Relative.UseVisualStyleBackColor = true;
            // 
            // rb2_Absolute
            // 
            this.rb2_Absolute.AutoSize = true;
            this.rb2_Absolute.Checked = true;
            this.rb2_Absolute.Location = new System.Drawing.Point(18, 24);
            this.rb2_Absolute.Name = "rb2_Absolute";
            this.rb2_Absolute.Size = new System.Drawing.Size(72, 19);
            this.rb2_Absolute.TabIndex = 1;
            this.rb2_Absolute.TabStop = true;
            this.rb2_Absolute.Tag = "2:0";
            this.rb2_Absolute.Text = "Absolute";
            this.rb2_Absolute.UseVisualStyleBackColor = true;
            // 
            // gb3
            // 
            this.gb3.Controls.Add(this.rb3_Wrap);
            this.gb3.Controls.Add(this.rb3_NoWrap);
            this.gb3.Location = new System.Drawing.Point(12, 270);
            this.gb3.Name = "gb3";
            this.gb3.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb3.Size = new System.Drawing.Size(160, 80);
            this.gb3.TabIndex = 5;
            this.gb3.TabStop = false;
            this.gb3.Text = "Bit 3";
            // 
            // rb3_Wrap
            // 
            this.rb3_Wrap.AutoSize = true;
            this.rb3_Wrap.Location = new System.Drawing.Point(18, 49);
            this.rb3_Wrap.Name = "rb3_Wrap";
            this.rb3_Wrap.Size = new System.Drawing.Size(53, 19);
            this.rb3_Wrap.TabIndex = 2;
            this.rb3_Wrap.TabStop = true;
            this.rb3_Wrap.Tag = "3:1";
            this.rb3_Wrap.Text = "Wrap";
            this.rb3_Wrap.UseVisualStyleBackColor = true;
            // 
            // rb3_NoWrap
            // 
            this.rb3_NoWrap.AutoSize = true;
            this.rb3_NoWrap.Checked = true;
            this.rb3_NoWrap.Location = new System.Drawing.Point(18, 24);
            this.rb3_NoWrap.Name = "rb3_NoWrap";
            this.rb3_NoWrap.Size = new System.Drawing.Size(72, 19);
            this.rb3_NoWrap.TabIndex = 1;
            this.rb3_NoWrap.TabStop = true;
            this.rb3_NoWrap.Tag = "3:0";
            this.rb3_NoWrap.Text = "No Wrap";
            this.rb3_NoWrap.UseVisualStyleBackColor = true;
            // 
            // gb4
            // 
            this.gb4.Controls.Add(this.rb4_NoLinear);
            this.gb4.Controls.Add(this.rb4_Linear);
            this.gb4.Location = new System.Drawing.Point(178, 12);
            this.gb4.Name = "gb4";
            this.gb4.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb4.Size = new System.Drawing.Size(160, 80);
            this.gb4.TabIndex = 6;
            this.gb4.TabStop = false;
            this.gb4.Text = "Bit 4";
            // 
            // rb4_NoLinear
            // 
            this.rb4_NoLinear.AutoSize = true;
            this.rb4_NoLinear.Location = new System.Drawing.Point(18, 49);
            this.rb4_NoLinear.Name = "rb4_NoLinear";
            this.rb4_NoLinear.Size = new System.Drawing.Size(76, 19);
            this.rb4_NoLinear.TabIndex = 2;
            this.rb4_NoLinear.TabStop = true;
            this.rb4_NoLinear.Tag = "4:1";
            this.rb4_NoLinear.Text = "No Linear";
            this.rb4_NoLinear.UseVisualStyleBackColor = true;
            // 
            // rb4_Linear
            // 
            this.rb4_Linear.AutoSize = true;
            this.rb4_Linear.Checked = true;
            this.rb4_Linear.Location = new System.Drawing.Point(18, 24);
            this.rb4_Linear.Name = "rb4_Linear";
            this.rb4_Linear.Size = new System.Drawing.Size(57, 19);
            this.rb4_Linear.TabIndex = 1;
            this.rb4_Linear.TabStop = true;
            this.rb4_Linear.Tag = "4:0";
            this.rb4_Linear.Text = "Linear";
            this.rb4_Linear.UseVisualStyleBackColor = true;
            // 
            // gb5
            // 
            this.gb5.Controls.Add(this.rb5_NoPreferred);
            this.gb5.Controls.Add(this.rb5_PreferredState);
            this.gb5.Location = new System.Drawing.Point(178, 98);
            this.gb5.Name = "gb5";
            this.gb5.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb5.Size = new System.Drawing.Size(160, 80);
            this.gb5.TabIndex = 7;
            this.gb5.TabStop = false;
            this.gb5.Text = "Bit 5";
            // 
            // rb5_NoPreferred
            // 
            this.rb5_NoPreferred.AutoSize = true;
            this.rb5_NoPreferred.Location = new System.Drawing.Point(18, 49);
            this.rb5_NoPreferred.Name = "rb5_NoPreferred";
            this.rb5_NoPreferred.Size = new System.Drawing.Size(92, 19);
            this.rb5_NoPreferred.TabIndex = 2;
            this.rb5_NoPreferred.TabStop = true;
            this.rb5_NoPreferred.Tag = "5:1";
            this.rb5_NoPreferred.Text = "No Preferred";
            this.rb5_NoPreferred.UseVisualStyleBackColor = true;
            // 
            // rb5_PreferredState
            // 
            this.rb5_PreferredState.AutoSize = true;
            this.rb5_PreferredState.Checked = true;
            this.rb5_PreferredState.Location = new System.Drawing.Point(18, 24);
            this.rb5_PreferredState.Name = "rb5_PreferredState";
            this.rb5_PreferredState.Size = new System.Drawing.Size(102, 19);
            this.rb5_PreferredState.TabIndex = 1;
            this.rb5_PreferredState.TabStop = true;
            this.rb5_PreferredState.Tag = "5:0";
            this.rb5_PreferredState.Text = "Preferred State";
            this.rb5_PreferredState.UseVisualStyleBackColor = true;
            // 
            // gb6
            // 
            this.gb6.Controls.Add(this.rb6_NullState);
            this.gb6.Controls.Add(this.rb6_NotNullPosition);
            this.gb6.Location = new System.Drawing.Point(178, 184);
            this.gb6.Name = "gb6";
            this.gb6.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb6.Size = new System.Drawing.Size(160, 80);
            this.gb6.TabIndex = 8;
            this.gb6.TabStop = false;
            this.gb6.Text = "Bit 6";
            // 
            // rb6_NullState
            // 
            this.rb6_NullState.AutoSize = true;
            this.rb6_NullState.Location = new System.Drawing.Point(18, 49);
            this.rb6_NullState.Name = "rb6_NullState";
            this.rb6_NullState.Size = new System.Drawing.Size(76, 19);
            this.rb6_NullState.TabIndex = 2;
            this.rb6_NullState.TabStop = true;
            this.rb6_NullState.Tag = "6:1";
            this.rb6_NullState.Text = "Null State";
            this.rb6_NullState.UseVisualStyleBackColor = true;
            // 
            // rb6_NotNullPosition
            // 
            this.rb6_NotNullPosition.AutoSize = true;
            this.rb6_NotNullPosition.Checked = true;
            this.rb6_NotNullPosition.Location = new System.Drawing.Point(18, 24);
            this.rb6_NotNullPosition.Name = "rb6_NotNullPosition";
            this.rb6_NotNullPosition.Size = new System.Drawing.Size(116, 19);
            this.rb6_NotNullPosition.TabIndex = 1;
            this.rb6_NotNullPosition.TabStop = true;
            this.rb6_NotNullPosition.Tag = "6:0";
            this.rb6_NotNullPosition.Text = "Not Null Position";
            this.rb6_NotNullPosition.UseVisualStyleBackColor = true;
            // 
            // gb7
            // 
            this.gb7.Controls.Add(this.rb7_Valatile);
            this.gb7.Controls.Add(this.rb7_NotValatile);
            this.gb7.Location = new System.Drawing.Point(178, 270);
            this.gb7.Name = "gb7";
            this.gb7.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb7.Size = new System.Drawing.Size(160, 80);
            this.gb7.TabIndex = 9;
            this.gb7.TabStop = false;
            this.gb7.Text = "Bit 7";
            // 
            // rb7_Valatile
            // 
            this.rb7_Valatile.AutoSize = true;
            this.rb7_Valatile.Location = new System.Drawing.Point(18, 49);
            this.rb7_Valatile.Name = "rb7_Valatile";
            this.rb7_Valatile.Size = new System.Drawing.Size(62, 19);
            this.rb7_Valatile.TabIndex = 2;
            this.rb7_Valatile.Tag = "7:1";
            this.rb7_Valatile.Text = "Valatile";
            this.rb7_Valatile.UseVisualStyleBackColor = true;
            // 
            // rb7_NotValatile
            // 
            this.rb7_NotValatile.AutoSize = true;
            this.rb7_NotValatile.Checked = true;
            this.rb7_NotValatile.Location = new System.Drawing.Point(18, 24);
            this.rb7_NotValatile.Name = "rb7_NotValatile";
            this.rb7_NotValatile.Size = new System.Drawing.Size(85, 19);
            this.rb7_NotValatile.TabIndex = 1;
            this.rb7_NotValatile.TabStop = true;
            this.rb7_NotValatile.Tag = "7:0";
            this.rb7_NotValatile.Text = "Not Valatile";
            this.rb7_NotValatile.UseVisualStyleBackColor = true;
            // 
            // gb8
            // 
            this.gb8.Controls.Add(this.rb8_Buffered);
            this.gb8.Controls.Add(this.rb8_BitField);
            this.gb8.Location = new System.Drawing.Point(344, 12);
            this.gb8.Name = "gb8";
            this.gb8.Padding = new System.Windows.Forms.Padding(15, 5, 5, 5);
            this.gb8.Size = new System.Drawing.Size(160, 80);
            this.gb8.TabIndex = 10;
            this.gb8.TabStop = false;
            this.gb8.Text = "Bit 8";
            // 
            // rb8_Buffered
            // 
            this.rb8_Buffered.AutoSize = true;
            this.rb8_Buffered.Location = new System.Drawing.Point(18, 49);
            this.rb8_Buffered.Name = "rb8_Buffered";
            this.rb8_Buffered.Size = new System.Drawing.Size(70, 19);
            this.rb8_Buffered.TabIndex = 2;
            this.rb8_Buffered.Tag = "8:1";
            this.rb8_Buffered.Text = "Buffered";
            this.rb8_Buffered.UseVisualStyleBackColor = true;
            // 
            // rb8_BitField
            // 
            this.rb8_BitField.AutoSize = true;
            this.rb8_BitField.Checked = true;
            this.rb8_BitField.Location = new System.Drawing.Point(18, 24);
            this.rb8_BitField.Name = "rb8_BitField";
            this.rb8_BitField.Size = new System.Drawing.Size(67, 19);
            this.rb8_BitField.TabIndex = 1;
            this.rb8_BitField.TabStop = true;
            this.rb8_BitField.Tag = "8:0";
            this.rb8_BitField.Text = "Bit Field";
            this.rb8_BitField.UseVisualStyleBackColor = true;
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 364);
            this.Controls.Add(this.gb8);
            this.Controls.Add(this.gb7);
            this.Controls.Add(this.gb6);
            this.Controls.Add(this.gb5);
            this.Controls.Add(this.gb4);
            this.Controls.Add(this.gb3);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.gb0);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Input Form";
            this.gb0.ResumeLayout(false);
            this.gb0.PerformLayout();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.gb3.ResumeLayout(false);
            this.gb3.PerformLayout();
            this.gb4.ResumeLayout(false);
            this.gb4.PerformLayout();
            this.gb5.ResumeLayout(false);
            this.gb5.PerformLayout();
            this.gb6.ResumeLayout(false);
            this.gb6.PerformLayout();
            this.gb7.ResumeLayout(false);
            this.gb7.PerformLayout();
            this.gb8.ResumeLayout(false);
            this.gb8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.RadioButton rb0_Data;
        private System.Windows.Forms.GroupBox gb0;
        private System.Windows.Forms.RadioButton rb0_Constant;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton rb1_Variable;
        private System.Windows.Forms.RadioButton rb1_Array;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.RadioButton rb2_Relative;
        private System.Windows.Forms.RadioButton rb2_Absolute;
        private System.Windows.Forms.GroupBox gb3;
        private System.Windows.Forms.RadioButton rb3_Wrap;
        private System.Windows.Forms.RadioButton rb3_NoWrap;
        private System.Windows.Forms.GroupBox gb4;
        private System.Windows.Forms.RadioButton rb4_NoLinear;
        private System.Windows.Forms.RadioButton rb4_Linear;
        private System.Windows.Forms.GroupBox gb5;
        private System.Windows.Forms.RadioButton rb5_NoPreferred;
        private System.Windows.Forms.RadioButton rb5_PreferredState;
        private System.Windows.Forms.GroupBox gb6;
        private System.Windows.Forms.RadioButton rb6_NullState;
        private System.Windows.Forms.RadioButton rb6_NotNullPosition;
        private System.Windows.Forms.GroupBox gb7;
        private System.Windows.Forms.RadioButton rb7_Valatile;
        private System.Windows.Forms.RadioButton rb7_NotValatile;
        private System.Windows.Forms.GroupBox gb8;
        private System.Windows.Forms.RadioButton rb8_Buffered;
        private System.Windows.Forms.RadioButton rb8_BitField;
    }
}
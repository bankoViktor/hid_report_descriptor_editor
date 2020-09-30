
namespace HID_Report_Descriptor_Editor.Controls
{
    partial class HexEditor
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexEditor));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TextHeaderPanel = new System.Windows.Forms.Label();
            this.ContentPanel = new System.Windows.Forms.RichTextBox();
            this.AddressPanel = new System.Windows.Forms.RichTextBox();
            this.OffsetPanel = new System.Windows.Forms.Label();
            this.TextPanel = new System.Windows.Forms.RichTextBox();
            this.VerticalScrollBar = new System.Windows.Forms.VScrollBar();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayout.ColumnCount = 4;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Controls.Add(this.TextHeaderPanel, 2, 0);
            this.tableLayout.Controls.Add(this.ContentPanel, 1, 1);
            this.tableLayout.Controls.Add(this.AddressPanel, 0, 1);
            this.tableLayout.Controls.Add(this.OffsetPanel, 1, 0);
            this.tableLayout.Controls.Add(this.TextPanel, 2, 1);
            this.tableLayout.Controls.Add(this.VerticalScrollBar, 3, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(0, 0);
            this.tableLayout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 2;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Size = new System.Drawing.Size(784, 483);
            this.tableLayout.TabIndex = 8;
            // 
            // TextHeaderPanel
            // 
            this.TextHeaderPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TextHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextHeaderPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextHeaderPanel.ForeColor = System.Drawing.Color.Red;
            this.TextHeaderPanel.Location = new System.Drawing.Point(584, 0);
            this.TextHeaderPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.TextHeaderPanel.Name = "TextHeaderPanel";
            this.TextHeaderPanel.Size = new System.Drawing.Size(180, 35);
            this.TextHeaderPanel.TabIndex = 9;
            this.TextHeaderPanel.Text = "ASNI";
            this.TextHeaderPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.TextHeaderPanel.UseMnemonic = false;
            // 
            // ContentPanel
            // 
            this.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContentPanel.DetectUrls = false;
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContentPanel.ForeColor = System.Drawing.Color.Green;
            this.ContentPanel.Location = new System.Drawing.Point(80, 45);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ContentPanel.Size = new System.Drawing.Size(494, 438);
            this.ContentPanel.TabIndex = 3;
            this.ContentPanel.Text = resources.GetString("ContentPanel.Text");
            this.ContentPanel.WordWrap = false;
            // 
            // AddressPanel
            // 
            this.AddressPanel.BackColor = System.Drawing.SystemColors.Window;
            this.AddressPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddressPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddressPanel.DetectUrls = false;
            this.AddressPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddressPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressPanel.ForeColor = System.Drawing.Color.Red;
            this.AddressPanel.Location = new System.Drawing.Point(0, 45);
            this.AddressPanel.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.AddressPanel.Name = "AddressPanel";
            this.AddressPanel.ReadOnly = true;
            this.AddressPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddressPanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.AddressPanel.Size = new System.Drawing.Size(70, 438);
            this.AddressPanel.TabIndex = 7;
            this.AddressPanel.TabStop = false;
            this.AddressPanel.Text = "0000\n0010\n0020\n0030\n0040\n0050\n0060\n0070\n0080\n0090";
            this.AddressPanel.WordWrap = false;
            // 
            // OffsetPanel
            // 
            this.OffsetPanel.BackColor = System.Drawing.SystemColors.Window;
            this.OffsetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OffsetPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OffsetPanel.ForeColor = System.Drawing.Color.Red;
            this.OffsetPanel.Location = new System.Drawing.Point(80, 0);
            this.OffsetPanel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.OffsetPanel.Name = "OffsetPanel";
            this.OffsetPanel.Size = new System.Drawing.Size(494, 35);
            this.OffsetPanel.TabIndex = 8;
            this.OffsetPanel.Text = "00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F";
            this.OffsetPanel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.OffsetPanel.UseMnemonic = false;
            // 
            // TextPanel
            // 
            this.TextPanel.BackColor = System.Drawing.SystemColors.Window;
            this.TextPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPanel.DetectUrls = false;
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextPanel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextPanel.ForeColor = System.Drawing.Color.Green;
            this.TextPanel.Location = new System.Drawing.Point(584, 45);
            this.TextPanel.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.TextPanel.Size = new System.Drawing.Size(180, 438);
            this.TextPanel.TabIndex = 11;
            this.TextPanel.Text = "is program canno\n................\n..............A.";
            this.TextPanel.WordWrap = false;
            // 
            // VerticalScrollBar
            // 
            this.VerticalScrollBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VerticalScrollBar.Location = new System.Drawing.Point(764, 0);
            this.VerticalScrollBar.Name = "VerticalScrollBar";
            this.tableLayout.SetRowSpan(this.VerticalScrollBar, 2);
            this.VerticalScrollBar.Size = new System.Drawing.Size(20, 483);
            this.VerticalScrollBar.TabIndex = 12;
            // 
            // HexEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayout);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HexEditor";
            this.Size = new System.Drawing.Size(784, 483);
            this.tableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private System.Windows.Forms.RichTextBox ContentPanel;
        private System.Windows.Forms.RichTextBox AddressPanel;
        private System.Windows.Forms.Label OffsetPanel;
        private System.Windows.Forms.RichTextBox TextPanel;
        private System.Windows.Forms.Label TextHeaderPanel;
        private System.Windows.Forms.VScrollBar VerticalScrollBar;
    }
}

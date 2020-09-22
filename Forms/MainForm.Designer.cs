namespace HID_Report_Descriptor_Editor.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ListItems = new System.Windows.Forms.ListView();
            this.ColumnItem = new System.Windows.Forms.ColumnHeader();
            this.ColumnHex = new System.Windows.Forms.ColumnHeader();
            this.СolumnComment = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmdEditMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdEditMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileExport = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SmEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SmView = new System.Windows.Forms.ToolStripMenuItem();
            this.SmViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.SmViewReportScheme = new System.Windows.Forms.ToolStripMenuItem();
            this.SmTools = new System.Windows.Forms.ToolStripMenuItem();
            this.SmToolsRegisterFileExt = new System.Windows.Forms.ToolStripMenuItem();
            this.SmToolsUnregisterFileExt = new System.Windows.Forms.ToolStripMenuItem();
            this.SmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.SmHelpHIDSpec = new System.Windows.Forms.ToolStripMenuItem();
            this.SmHelpHIDUsages = new System.Windows.Forms.ToolStripMenuItem();
            this.SmHelpSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SmHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBarSpring = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarElementCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBarByteCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.ListItemPalet = new System.Windows.Forms.ListView();
            this.ColumnItemName = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuStrip1.SuspendLayout();
            this.MainMenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListItems
            // 
            this.ListItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnItem,
            this.ColumnHex,
            this.СolumnComment});
            this.ListItems.ContextMenuStrip = this.ContextMenuStrip1;
            this.ListItems.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListItems.FullRowSelect = true;
            this.ListItems.HideSelection = false;
            this.ListItems.Location = new System.Drawing.Point(192, 27);
            this.ListItems.Name = "ListItems";
            this.ListItems.Size = new System.Drawing.Size(969, 630);
            this.ListItems.TabIndex = 1;
            this.ListItems.UseCompatibleStateImageBehavior = false;
            this.ListItems.View = System.Windows.Forms.View.Details;
            this.ListItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            this.ListItems.DoubleClick += new System.EventHandler(this.ListItems_DoubleClick);
            // 
            // ColumnItem
            // 
            this.ColumnItem.Text = "Элемент";
            this.ColumnItem.Width = 520;
            // 
            // ColumnHex
            // 
            this.ColumnHex.Text = "HEX";
            this.ColumnHex.Width = 210;
            // 
            // СolumnComment
            // 
            this.СolumnComment.Text = "Comment";
            this.СolumnComment.Width = 220;
            // 
            // ContextMenuStrip1
            // 
            this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdEditMoveUp,
            this.CmdEditMoveDown,
            this.CmdEditDelete});
            this.ContextMenuStrip1.Name = "ContextMenuStrip";
            this.ContextMenuStrip1.Size = new System.Drawing.Size(119, 70);
            // 
            // CmdEditMoveUp
            // 
            this.CmdEditMoveUp.Name = "CmdEditMoveUp";
            this.CmdEditMoveUp.Size = new System.Drawing.Size(118, 22);
            this.CmdEditMoveUp.Text = "Вверх";
            // 
            // CmdEditMoveDown
            // 
            this.CmdEditMoveDown.Name = "CmdEditMoveDown";
            this.CmdEditMoveDown.Size = new System.Drawing.Size(118, 22);
            this.CmdEditMoveDown.Text = "Вниз";
            // 
            // CmdEditDelete
            // 
            this.CmdEditDelete.Name = "CmdEditDelete";
            this.CmdEditDelete.Size = new System.Drawing.Size(118, 22);
            this.CmdEditDelete.Text = "Удалить";
            this.CmdEditDelete.Click += new System.EventHandler(this.Command_EditDelete);
            // 
            // MainMenuStrip1
            // 
            this.MainMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmFile,
            this.SmEdit,
            this.SmView,
            this.SmTools,
            this.SmHelp});
            this.MainMenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MainMenuStrip1.Name = "MainMenuStrip1";
            this.MainMenuStrip1.Size = new System.Drawing.Size(1173, 24);
            this.MainMenuStrip1.TabIndex = 2;
            this.MainMenuStrip1.Text = "MainMenuStrip";
            // 
            // SmFile
            // 
            this.SmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmFileOpen,
            this.SmFileSave,
            this.SmFileSaveAs,
            this.SmFileExport});
            this.SmFile.Name = "SmFile";
            this.SmFile.Size = new System.Drawing.Size(37, 20);
            this.SmFile.Text = "File";
            // 
            // SmFileOpen
            // 
            this.SmFileOpen.Name = "SmFileOpen";
            this.SmFileOpen.ShortcutKeyDisplayString = "";
            this.SmFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.SmFileOpen.Size = new System.Drawing.Size(148, 22);
            this.SmFileOpen.Text = "Open";
            this.SmFileOpen.Click += new System.EventHandler(this.Command_FileOpen);
            // 
            // SmFileSave
            // 
            this.SmFileSave.Name = "SmFileSave";
            this.SmFileSave.ShortcutKeyDisplayString = "";
            this.SmFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SmFileSave.Size = new System.Drawing.Size(148, 22);
            this.SmFileSave.Text = "Save";
            this.SmFileSave.Click += new System.EventHandler(this.Command_FileSave);
            // 
            // SmFileSaveAs
            // 
            this.SmFileSaveAs.Name = "SmFileSaveAs";
            this.SmFileSaveAs.Size = new System.Drawing.Size(148, 22);
            this.SmFileSaveAs.Text = "Save As ...";
            this.SmFileSaveAs.Click += new System.EventHandler(this.Command_FileSaveAs);
            // 
            // SmFileExport
            // 
            this.SmFileExport.Name = "SmFileExport";
            this.SmFileExport.ShortcutKeyDisplayString = "";
            this.SmFileExport.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.SmFileExport.Size = new System.Drawing.Size(148, 22);
            this.SmFileExport.Text = "Export";
            this.SmFileExport.Click += new System.EventHandler(this.Command_FileExport);
            // 
            // SmEdit
            // 
            this.SmEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmEditCut,
            this.SmEditCopy,
            this.SmEditPaste,
            this.SmEditDelete,
            this.SmEditSeparator1,
            this.SmEditSelectAll,
            this.SmEditDeleteAll});
            this.SmEdit.Name = "SmEdit";
            this.SmEdit.Size = new System.Drawing.Size(39, 20);
            this.SmEdit.Text = "Edit";
            // 
            // SmEditCut
            // 
            this.SmEditCut.Name = "SmEditCut";
            this.SmEditCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.SmEditCut.Size = new System.Drawing.Size(164, 22);
            this.SmEditCut.Text = "Cut";
            // 
            // SmEditCopy
            // 
            this.SmEditCopy.Name = "SmEditCopy";
            this.SmEditCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.SmEditCopy.Size = new System.Drawing.Size(164, 22);
            this.SmEditCopy.Text = "Copy";
            // 
            // SmEditPaste
            // 
            this.SmEditPaste.Name = "SmEditPaste";
            this.SmEditPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.SmEditPaste.Size = new System.Drawing.Size(164, 22);
            this.SmEditPaste.Text = "Paste";
            // 
            // SmEditDelete
            // 
            this.SmEditDelete.Name = "SmEditDelete";
            this.SmEditDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.SmEditDelete.Size = new System.Drawing.Size(164, 22);
            this.SmEditDelete.Text = "Delete";
            this.SmEditDelete.Click += new System.EventHandler(this.Command_EditDelete);
            // 
            // SmEditSeparator1
            // 
            this.SmEditSeparator1.Name = "SmEditSeparator1";
            this.SmEditSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // SmEditSelectAll
            // 
            this.SmEditSelectAll.Name = "SmEditSelectAll";
            this.SmEditSelectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SmEditSelectAll.Size = new System.Drawing.Size(164, 22);
            this.SmEditSelectAll.Text = "Select All";
            this.SmEditSelectAll.Click += new System.EventHandler(this.Command_EditSelectAll);
            // 
            // SmEditDeleteAll
            // 
            this.SmEditDeleteAll.Name = "SmEditDeleteAll";
            this.SmEditDeleteAll.Size = new System.Drawing.Size(164, 22);
            this.SmEditDeleteAll.Text = "Delete All";
            this.SmEditDeleteAll.Click += new System.EventHandler(this.Command_EditDeleteAll);
            // 
            // SmView
            // 
            this.SmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmViewStatusBar,
            this.SmViewReportScheme});
            this.SmView.Name = "SmView";
            this.SmView.Size = new System.Drawing.Size(44, 20);
            this.SmView.Text = "View";
            // 
            // SmViewStatusBar
            // 
            this.SmViewStatusBar.Checked = true;
            this.SmViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmViewStatusBar.Name = "SmViewStatusBar";
            this.SmViewStatusBar.Size = new System.Drawing.Size(154, 22);
            this.SmViewStatusBar.Text = "Status Bar";
            // 
            // SmViewReportScheme
            // 
            this.SmViewReportScheme.Checked = true;
            this.SmViewReportScheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmViewReportScheme.Name = "SmViewReportScheme";
            this.SmViewReportScheme.Size = new System.Drawing.Size(154, 22);
            this.SmViewReportScheme.Text = "Report Scheme";
            // 
            // SmTools
            // 
            this.SmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmToolsRegisterFileExt,
            this.SmToolsUnregisterFileExt});
            this.SmTools.Name = "SmTools";
            this.SmTools.Size = new System.Drawing.Size(46, 20);
            this.SmTools.Text = "Tools";
            // 
            // SmToolsRegisterFileExt
            // 
            this.SmToolsRegisterFileExt.Name = "SmToolsRegisterFileExt";
            this.SmToolsRegisterFileExt.Size = new System.Drawing.Size(201, 22);
            this.SmToolsRegisterFileExt.Text = "Register file extension";
            this.SmToolsRegisterFileExt.Click += new System.EventHandler(this.Command_ToolsRegisterFileExt);
            // 
            // SmToolsUnregisterFileExt
            // 
            this.SmToolsUnregisterFileExt.Name = "SmToolsUnregisterFileExt";
            this.SmToolsUnregisterFileExt.Size = new System.Drawing.Size(201, 22);
            this.SmToolsUnregisterFileExt.Text = "Unregister file extension";
            this.SmToolsUnregisterFileExt.Click += new System.EventHandler(this.Command_ToolsUnregisterFileExt);
            // 
            // SmHelp
            // 
            this.SmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmHelpHIDSpec,
            this.SmHelpHIDUsages,
            this.SmHelpSeparator1,
            this.SmHelpAbout});
            this.SmHelp.Name = "SmHelp";
            this.SmHelp.Size = new System.Drawing.Size(44, 20);
            this.SmHelp.Text = "Help";
            // 
            // SmHelpHIDSpec
            // 
            this.SmHelpHIDSpec.Name = "SmHelpHIDSpec";
            this.SmHelpHIDSpec.Size = new System.Drawing.Size(165, 22);
            this.SmHelpHIDSpec.Text = "HID Specification";
            this.SmHelpHIDSpec.Click += new System.EventHandler(this.Command_HelpHIDSpec);
            // 
            // SmHelpHIDUsages
            // 
            this.SmHelpHIDUsages.Name = "SmHelpHIDUsages";
            this.SmHelpHIDUsages.Size = new System.Drawing.Size(165, 22);
            this.SmHelpHIDUsages.Text = "HID Usage Tables";
            this.SmHelpHIDUsages.Click += new System.EventHandler(this.Command_HelpHIDUsages);
            // 
            // SmHelpSeparator1
            // 
            this.SmHelpSeparator1.Name = "SmHelpSeparator1";
            this.SmHelpSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // SmHelpAbout
            // 
            this.SmHelpAbout.Name = "SmHelpAbout";
            this.SmHelpAbout.Size = new System.Drawing.Size(165, 22);
            this.SmHelpAbout.Text = "About";
            this.SmHelpAbout.Click += new System.EventHandler(this.Command_HelpAbout);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarSpring,
            this.StatusBarElementCount,
            this.StatusBarByteCount});
            this.StatusStrip1.Location = new System.Drawing.Point(0, 660);
            this.StatusStrip1.Name = "StatusStrip1";
            this.StatusStrip1.Size = new System.Drawing.Size(1173, 22);
            this.StatusStrip1.TabIndex = 4;
            this.StatusStrip1.Text = "statusStrip1";
            // 
            // StatusBarSpring
            // 
            this.StatusBarSpring.Name = "StatusBarSpring";
            this.StatusBarSpring.Size = new System.Drawing.Size(858, 17);
            this.StatusBarSpring.Spring = true;
            // 
            // StatusBarElementCount
            // 
            this.StatusBarElementCount.AutoSize = false;
            this.StatusBarElementCount.Name = "StatusBarElementCount";
            this.StatusBarElementCount.Size = new System.Drawing.Size(150, 17);
            this.StatusBarElementCount.Text = "StatusBarElementCount";
            // 
            // StatusBarByteCount
            // 
            this.StatusBarByteCount.AutoSize = false;
            this.StatusBarByteCount.Name = "StatusBarByteCount";
            this.StatusBarByteCount.Size = new System.Drawing.Size(150, 17);
            this.StatusBarByteCount.Text = "StatusBarByteCount";
            // 
            // ListItemPalet
            // 
            this.ListItemPalet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListItemPalet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnItemName});
            this.ListItemPalet.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListItemPalet.FullRowSelect = true;
            this.ListItemPalet.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListItemPalet.HideSelection = false;
            this.ListItemPalet.LabelWrap = false;
            this.ListItemPalet.Location = new System.Drawing.Point(12, 27);
            this.ListItemPalet.MultiSelect = false;
            this.ListItemPalet.Name = "ListItemPalet";
            this.ListItemPalet.Size = new System.Drawing.Size(174, 630);
            this.ListItemPalet.TabIndex = 5;
            this.ListItemPalet.UseCompatibleStateImageBehavior = false;
            this.ListItemPalet.View = System.Windows.Forms.View.Details;
            this.ListItemPalet.DoubleClick += new System.EventHandler(this.ListItemPalet_DoubleClick);
            // 
            // ColumnItemName
            // 
            this.ColumnItemName.Width = 170;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 682);
            this.Controls.Add(this.ListItemPalet);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ListItems);
            this.Controls.Add(this.MainMenuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HID Report Descriptor Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ContextMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListItems;
        private System.Windows.Forms.MenuStrip MainMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SmFile;
        private System.Windows.Forms.ToolStripMenuItem SmFileOpen;
        private System.Windows.Forms.ToolStripMenuItem SmFileSave;
        private System.Windows.Forms.ToolStripMenuItem SmFileSaveAs;
        private System.Windows.Forms.ColumnHeader ColumnItem;
        private System.Windows.Forms.ColumnHeader ColumnHex;
        private System.Windows.Forms.ContextMenuStrip ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CmdEditMoveDown;
        private System.Windows.Forms.ToolStripMenuItem SmHelp;
        private System.Windows.Forms.ToolStripMenuItem SmFileExport;
        private System.Windows.Forms.ListView ListItemPalet;
        private System.Windows.Forms.ColumnHeader ColumnItemName;
        private System.Windows.Forms.ToolStripMenuItem CmdEditDelete;
        private System.Windows.Forms.ToolStripMenuItem CmdEditMoveUp;
        private System.Windows.Forms.StatusStrip StatusStrip1;
        private System.Windows.Forms.ToolStripMenuItem SmView;
        private System.Windows.Forms.ToolStripMenuItem SmViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem SmViewReportScheme;
        private System.Windows.Forms.ToolStripMenuItem SmEdit;
        private System.Windows.Forms.ToolStripMenuItem SmEditCut;
        private System.Windows.Forms.ToolStripMenuItem SmEditCopy;
        private System.Windows.Forms.ToolStripMenuItem SmEditPaste;
        private System.Windows.Forms.ToolStripMenuItem SmEditDelete;
        private System.Windows.Forms.ToolStripMenuItem SmEditDeleteAll;
        private System.Windows.Forms.ToolStripMenuItem SmEditSelectAll;
        private System.Windows.Forms.ToolStripSeparator SmEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SmHelpHIDSpec;
        private System.Windows.Forms.ToolStripMenuItem SmHelpHIDUsages;
        private System.Windows.Forms.ToolStripMenuItem SmHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem SmTools;
        private System.Windows.Forms.ToolStripMenuItem SmToolsRegisterFileExt;
        private System.Windows.Forms.ToolStripMenuItem SmToolsUnregisterFileExt;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarSpring;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarElementCount;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarByteCount;
        private System.Windows.Forms.ColumnHeader СolumnComment;
        private System.Windows.Forms.ToolStripSeparator SmHelpSeparator1;
    }
}


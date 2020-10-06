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
            this.ListReportItems = new System.Windows.Forms.ListView();
            this.ColumnItem = new System.Windows.Forms.ColumnHeader();
            this.ColumnHex = new System.Windows.Forms.ColumnHeader();
            this.СolumnComment = new System.Windows.Forms.ColumnHeader();
            this.ContextMenuEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SmEditComment = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SmEditCut = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SmEditMoveUp = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditMoveDown = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SmEditSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEditDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.SmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.SmFileExport = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ListPaletteItems = new System.Windows.Forms.ListView();
            this.ColumnItemName = new System.Windows.Forms.ColumnHeader();
            this.BtnAddLongItem = new System.Windows.Forms.Button();
            this.ContextMenuEdit.SuspendLayout();
            this.MainMenuStrip1.SuspendLayout();
            this.StatusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListReportItems
            // 
            resources.ApplyResources(this.ListReportItems, "ListReportItems");
            this.ListReportItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnItem,
            this.ColumnHex,
            this.СolumnComment});
            this.ListReportItems.ContextMenuStrip = this.ContextMenuEdit;
            this.ListReportItems.FullRowSelect = true;
            this.ListReportItems.HideSelection = false;
            this.ListReportItems.Name = "ListReportItems";
            this.ListReportItems.UseCompatibleStateImageBehavior = false;
            this.ListReportItems.View = System.Windows.Forms.View.Details;
            this.ListReportItems.SelectedIndexChanged += new System.EventHandler(this.ListItems_SelectedIndexChanged);
            this.ListReportItems.DoubleClick += new System.EventHandler(this.ListReportItems_DoubleClick);
            // 
            // ColumnItem
            // 
            resources.ApplyResources(this.ColumnItem, "ColumnItem");
            // 
            // ColumnHex
            // 
            resources.ApplyResources(this.ColumnHex, "ColumnHex");
            // 
            // СolumnComment
            // 
            resources.ApplyResources(this.СolumnComment, "СolumnComment");
            // 
            // ContextMenuEdit
            // 
            this.ContextMenuEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmEditComment,
            this.SmEditSeparator1,
            this.SmEditCut,
            this.SmEditCopy,
            this.SmEditPaste,
            this.SmEditDelete,
            this.SmEditSeparator2,
            this.SmEditMoveUp,
            this.SmEditMoveDown,
            this.SmEditSeparator3,
            this.SmEditSelectAll,
            this.SmEditDeleteAll});
            this.ContextMenuEdit.Name = "ContextMenuStrip";
            resources.ApplyResources(this.ContextMenuEdit, "ContextMenuEdit");
            // 
            // SmEditComment
            // 
            this.SmEditComment.Name = "SmEditComment";
            resources.ApplyResources(this.SmEditComment, "SmEditComment");
            this.SmEditComment.Click += new System.EventHandler(this.SmEditComment_Click);
            // 
            // SmEditSeparator1
            // 
            this.SmEditSeparator1.Name = "SmEditSeparator1";
            resources.ApplyResources(this.SmEditSeparator1, "SmEditSeparator1");
            // 
            // SmEditCut
            // 
            this.SmEditCut.Name = "SmEditCut";
            resources.ApplyResources(this.SmEditCut, "SmEditCut");
            // 
            // SmEditCopy
            // 
            this.SmEditCopy.Name = "SmEditCopy";
            resources.ApplyResources(this.SmEditCopy, "SmEditCopy");
            // 
            // SmEditPaste
            // 
            this.SmEditPaste.Name = "SmEditPaste";
            resources.ApplyResources(this.SmEditPaste, "SmEditPaste");
            // 
            // SmEditDelete
            // 
            this.SmEditDelete.Name = "SmEditDelete";
            resources.ApplyResources(this.SmEditDelete, "SmEditDelete");
            this.SmEditDelete.Click += new System.EventHandler(this.SmEditDelete_Click);
            // 
            // SmEditSeparator2
            // 
            this.SmEditSeparator2.Name = "SmEditSeparator2";
            resources.ApplyResources(this.SmEditSeparator2, "SmEditSeparator2");
            // 
            // SmEditMoveUp
            // 
            this.SmEditMoveUp.Name = "SmEditMoveUp";
            resources.ApplyResources(this.SmEditMoveUp, "SmEditMoveUp");
            // 
            // SmEditMoveDown
            // 
            this.SmEditMoveDown.Name = "SmEditMoveDown";
            resources.ApplyResources(this.SmEditMoveDown, "SmEditMoveDown");
            // 
            // SmEditSeparator3
            // 
            this.SmEditSeparator3.Name = "SmEditSeparator3";
            resources.ApplyResources(this.SmEditSeparator3, "SmEditSeparator3");
            // 
            // SmEditSelectAll
            // 
            this.SmEditSelectAll.Name = "SmEditSelectAll";
            resources.ApplyResources(this.SmEditSelectAll, "SmEditSelectAll");
            this.SmEditSelectAll.Click += new System.EventHandler(this.SmEditSelectAll_Click);
            // 
            // SmEditDeleteAll
            // 
            this.SmEditDeleteAll.Name = "SmEditDeleteAll";
            resources.ApplyResources(this.SmEditDeleteAll, "SmEditDeleteAll");
            this.SmEditDeleteAll.Click += new System.EventHandler(this.SmEditDeleteAll_Click);
            // 
            // SmEdit
            // 
            this.SmEdit.Name = "SmEdit";
            resources.ApplyResources(this.SmEdit, "SmEdit");
            // 
            // MainMenuStrip1
            // 
            this.MainMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmFile,
            this.SmEdit,
            this.SmView,
            this.SmTools,
            this.SmHelp});
            resources.ApplyResources(this.MainMenuStrip1, "MainMenuStrip1");
            this.MainMenuStrip1.Name = "MainMenuStrip1";
            // 
            // SmFile
            // 
            this.SmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmFileOpen,
            this.SmFileSave,
            this.SmFileSaveAs,
            this.SmFileExport});
            this.SmFile.Name = "SmFile";
            resources.ApplyResources(this.SmFile, "SmFile");
            // 
            // SmFileOpen
            // 
            this.SmFileOpen.Name = "SmFileOpen";
            resources.ApplyResources(this.SmFileOpen, "SmFileOpen");
            this.SmFileOpen.Click += new System.EventHandler(this.SmFileOpen_Click);
            // 
            // SmFileSave
            // 
            this.SmFileSave.Name = "SmFileSave";
            resources.ApplyResources(this.SmFileSave, "SmFileSave");
            this.SmFileSave.Click += new System.EventHandler(this.SmFileSave_Click);
            // 
            // SmFileSaveAs
            // 
            this.SmFileSaveAs.Name = "SmFileSaveAs";
            resources.ApplyResources(this.SmFileSaveAs, "SmFileSaveAs");
            this.SmFileSaveAs.Click += new System.EventHandler(this.SmFileSaveAs_Click);
            // 
            // SmFileExport
            // 
            this.SmFileExport.Name = "SmFileExport";
            resources.ApplyResources(this.SmFileExport, "SmFileExport");
            this.SmFileExport.Click += new System.EventHandler(this.SmFileExport_Click);
            // 
            // SmView
            // 
            this.SmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmViewStatusBar,
            this.SmViewReportScheme});
            this.SmView.Name = "SmView";
            resources.ApplyResources(this.SmView, "SmView");
            // 
            // SmViewStatusBar
            // 
            this.SmViewStatusBar.Checked = true;
            this.SmViewStatusBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmViewStatusBar.Name = "SmViewStatusBar";
            resources.ApplyResources(this.SmViewStatusBar, "SmViewStatusBar");
            // 
            // SmViewReportScheme
            // 
            this.SmViewReportScheme.Checked = true;
            this.SmViewReportScheme.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SmViewReportScheme.Name = "SmViewReportScheme";
            resources.ApplyResources(this.SmViewReportScheme, "SmViewReportScheme");
            // 
            // SmTools
            // 
            this.SmTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmToolsRegisterFileExt,
            this.SmToolsUnregisterFileExt});
            this.SmTools.Name = "SmTools";
            resources.ApplyResources(this.SmTools, "SmTools");
            // 
            // SmToolsRegisterFileExt
            // 
            this.SmToolsRegisterFileExt.Name = "SmToolsRegisterFileExt";
            resources.ApplyResources(this.SmToolsRegisterFileExt, "SmToolsRegisterFileExt");
            this.SmToolsRegisterFileExt.Click += new System.EventHandler(this.SmToolsRegisterFileExt_Click);
            // 
            // SmToolsUnregisterFileExt
            // 
            this.SmToolsUnregisterFileExt.Name = "SmToolsUnregisterFileExt";
            resources.ApplyResources(this.SmToolsUnregisterFileExt, "SmToolsUnregisterFileExt");
            this.SmToolsUnregisterFileExt.Click += new System.EventHandler(this.SmToolsUnregisterFileExt_Click);
            // 
            // SmHelp
            // 
            this.SmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SmHelpHIDSpec,
            this.SmHelpHIDUsages,
            this.SmHelpSeparator1,
            this.SmHelpAbout});
            this.SmHelp.Name = "SmHelp";
            resources.ApplyResources(this.SmHelp, "SmHelp");
            // 
            // SmHelpHIDSpec
            // 
            this.SmHelpHIDSpec.Name = "SmHelpHIDSpec";
            resources.ApplyResources(this.SmHelpHIDSpec, "SmHelpHIDSpec");
            this.SmHelpHIDSpec.Click += new System.EventHandler(this.SmHelpHIDSpec_Click);
            // 
            // SmHelpHIDUsages
            // 
            this.SmHelpHIDUsages.Name = "SmHelpHIDUsages";
            resources.ApplyResources(this.SmHelpHIDUsages, "SmHelpHIDUsages");
            this.SmHelpHIDUsages.Click += new System.EventHandler(this.SmHelpHIDUsages_Click);
            // 
            // SmHelpSeparator1
            // 
            this.SmHelpSeparator1.Name = "SmHelpSeparator1";
            resources.ApplyResources(this.SmHelpSeparator1, "SmHelpSeparator1");
            // 
            // SmHelpAbout
            // 
            this.SmHelpAbout.Name = "SmHelpAbout";
            resources.ApplyResources(this.SmHelpAbout, "SmHelpAbout");
            this.SmHelpAbout.Click += new System.EventHandler(this.SmHelpAbout_Click);
            // 
            // StatusStrip1
            // 
            this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarSpring,
            this.StatusBarElementCount,
            this.StatusBarByteCount});
            resources.ApplyResources(this.StatusStrip1, "StatusStrip1");
            this.StatusStrip1.Name = "StatusStrip1";
            // 
            // StatusBarSpring
            // 
            this.StatusBarSpring.Name = "StatusBarSpring";
            resources.ApplyResources(this.StatusBarSpring, "StatusBarSpring");
            this.StatusBarSpring.Spring = true;
            // 
            // StatusBarElementCount
            // 
            resources.ApplyResources(this.StatusBarElementCount, "StatusBarElementCount");
            this.StatusBarElementCount.Name = "StatusBarElementCount";
            // 
            // StatusBarByteCount
            // 
            resources.ApplyResources(this.StatusBarByteCount, "StatusBarByteCount");
            this.StatusBarByteCount.Name = "StatusBarByteCount";
            // 
            // ListPaletteItems
            // 
            resources.ApplyResources(this.ListPaletteItems, "ListPaletteItems");
            this.ListPaletteItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnItemName});
            this.ListPaletteItems.FullRowSelect = true;
            this.ListPaletteItems.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListPaletteItems.HideSelection = false;
            this.ListPaletteItems.MultiSelect = false;
            this.ListPaletteItems.Name = "ListPaletteItems";
            this.ListPaletteItems.UseCompatibleStateImageBehavior = false;
            this.ListPaletteItems.View = System.Windows.Forms.View.Details;
            this.ListPaletteItems.DoubleClick += new System.EventHandler(this.ListPaletteItems_DoubleClick);
            // 
            // ColumnItemName
            // 
            resources.ApplyResources(this.ColumnItemName, "ColumnItemName");
            // 
            // BtnAddLongItem
            // 
            resources.ApplyResources(this.BtnAddLongItem, "BtnAddLongItem");
            this.BtnAddLongItem.Name = "BtnAddLongItem";
            this.BtnAddLongItem.UseVisualStyleBackColor = true;
            this.BtnAddLongItem.Click += new System.EventHandler(this.BtnAddLongItem_Click);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnAddLongItem);
            this.Controls.Add(this.ListPaletteItems);
            this.Controls.Add(this.StatusStrip1);
            this.Controls.Add(this.ListReportItems);
            this.Controls.Add(this.MainMenuStrip1);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ContextMenuEdit.ResumeLayout(false);
            this.MainMenuStrip1.ResumeLayout(false);
            this.MainMenuStrip1.PerformLayout();
            this.StatusStrip1.ResumeLayout(false);
            this.StatusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView ListReportItems;
        private System.Windows.Forms.MenuStrip MainMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SmFile;
        private System.Windows.Forms.ToolStripMenuItem SmFileOpen;
        private System.Windows.Forms.ToolStripMenuItem SmFileSave;
        private System.Windows.Forms.ToolStripMenuItem SmFileSaveAs;
        private System.Windows.Forms.ColumnHeader ColumnItem;
        private System.Windows.Forms.ColumnHeader ColumnHex;
        private System.Windows.Forms.ContextMenuStrip ContextMenuEdit;
        private System.Windows.Forms.ToolStripMenuItem SmHelp;
        private System.Windows.Forms.ToolStripMenuItem SmFileExport;
        private System.Windows.Forms.ListView ListPaletteItems;
        private System.Windows.Forms.ColumnHeader ColumnItemName;
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
        private System.Windows.Forms.ToolStripMenuItem SmEditComment;
        private System.Windows.Forms.ToolStripSeparator SmEditSeparator2;

        private System.Windows.Forms.ToolStripMenuItem SmHelpHIDSpec;
        private System.Windows.Forms.ToolStripMenuItem SmHelpHIDUsages;
        private System.Windows.Forms.ToolStripMenuItem SmHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem SmTools;
        private System.Windows.Forms.ToolStripMenuItem SmToolsRegisterFileExt;
        private System.Windows.Forms.ToolStripMenuItem SmToolsUnregisterFileExt;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarSpring;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarElementCount;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarByteCount;
        private System.Windows.Forms.ToolStripSeparator SmHelpSeparator1;
        private System.Windows.Forms.ToolStripSeparator SmEditSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SmEditMoveUp;
        private System.Windows.Forms.ToolStripMenuItem SmEditMoveDown;
        private System.Windows.Forms.ToolStripSeparator SmEditSeparator3;
        private System.Windows.Forms.Button BtnAddLongItem;
        private System.Windows.Forms.ColumnHeader СolumnComment;
    }
}


namespace CryptoGUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuBase = new System.Windows.Forms.MainMenu(this.components);
            this.menuFile = new System.Windows.Forms.MenuItem();
            this.menuOpen = new System.Windows.Forms.MenuItem();
            this.menuSave = new System.Windows.Forms.MenuItem();
            this.menuFileSeparator = new System.Windows.Forms.MenuItem();
            this.menuExit = new System.Windows.Forms.MenuItem();
            this.menuAction = new System.Windows.Forms.MenuItem();
            this.menuGenerate = new System.Windows.Forms.MenuItem();
            this.menuSwap = new System.Windows.Forms.MenuItem();
            this.menuActionSeparator = new System.Windows.Forms.MenuItem();
            this.menuProcess = new System.Windows.Forms.MenuItem();
            this.menuHelp = new System.Windows.Forms.MenuItem();
            this.menuAbout = new System.Windows.Forms.MenuItem();
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.textSource = new System.Windows.Forms.TextBox();
            this.textSourceContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textSourceContextMenuNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.textSourceContextMenuClear = new System.Windows.Forms.ToolStripMenuItem();
            this.textResult = new System.Windows.Forms.TextBox();
            this.panelIntstrument = new System.Windows.Forms.Panel();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonShowFile = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textKey = new System.Windows.Forms.TextBox();
            this.groupMode = new System.Windows.Forms.GroupBox();
            this.radioDecrypt = new System.Windows.Forms.RadioButton();
            this.radioEncrypt = new System.Windows.Forms.RadioButton();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSeparator = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSymbols = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSymbolsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableMain.SuspendLayout();
            this.textSourceContextMenu.SuspendLayout();
            this.panelIntstrument.SuspendLayout();
            this.groupMode.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBase
            // 
            this.menuBase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuFile,
            this.menuAction,
            this.menuHelp});
            // 
            // menuFile
            // 
            this.menuFile.Index = 0;
            this.menuFile.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuOpen,
            this.menuSave,
            this.menuFileSeparator,
            this.menuExit});
            this.menuFile.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Index = 0;
            this.menuOpen.Shortcut = System.Windows.Forms.Shortcut.CtrlO;
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.openFile);
            // 
            // menuSave
            // 
            this.menuSave.Index = 1;
            this.menuSave.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
            this.menuSave.Text = "Save";
            this.menuSave.Click += new System.EventHandler(this.saveFile);
            // 
            // menuFileSeparator
            // 
            this.menuFileSeparator.Index = 2;
            this.menuFileSeparator.Text = "-";
            // 
            // menuExit
            // 
            this.menuExit.Index = 3;
            this.menuExit.Shortcut = System.Windows.Forms.Shortcut.CtrlQ;
            this.menuExit.Text = "Exit";
            this.menuExit.Click += new System.EventHandler(this.exitApplication);
            // 
            // menuAction
            // 
            this.menuAction.Index = 1;
            this.menuAction.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuGenerate,
            this.menuSwap,
            this.menuActionSeparator,
            this.menuProcess});
            this.menuAction.Text = "Action";
            // 
            // menuGenerate
            // 
            this.menuGenerate.Index = 0;
            this.menuGenerate.Shortcut = System.Windows.Forms.Shortcut.CtrlG;
            this.menuGenerate.Text = "Generate";
            this.menuGenerate.Click += new System.EventHandler(this.generateKey);
            // 
            // menuSwap
            // 
            this.menuSwap.Index = 1;
            this.menuSwap.Text = "Swap";
            this.menuSwap.Click += new System.EventHandler(this.swapTexts);
            // 
            // menuActionSeparator
            // 
            this.menuActionSeparator.Index = 2;
            this.menuActionSeparator.Text = "-";
            // 
            // menuProcess
            // 
            this.menuProcess.Index = 3;
            this.menuProcess.Shortcut = System.Windows.Forms.Shortcut.F5;
            this.menuProcess.Text = "Process";
            // 
            // menuHelp
            // 
            this.menuHelp.Index = 2;
            this.menuHelp.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuAbout});
            this.menuHelp.Text = "Help";
            // 
            // menuAbout
            // 
            this.menuAbout.Index = 0;
            this.menuAbout.Shortcut = System.Windows.Forms.Shortcut.CtrlH;
            this.menuAbout.Text = "About";
            this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
            // 
            // tableMain
            // 
            this.tableMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableMain.ColumnCount = 1;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.Controls.Add(this.textSource, 0, 0);
            this.tableMain.Controls.Add(this.textResult, 0, 2);
            this.tableMain.Controls.Add(this.panelIntstrument, 0, 1);
            this.tableMain.Location = new System.Drawing.Point(0, -2);
            this.tableMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Size = new System.Drawing.Size(529, 480);
            this.tableMain.TabIndex = 0;
            // 
            // textSource
            // 
            this.textSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSource.ContextMenuStrip = this.textSourceContextMenu;
            this.textSource.Location = new System.Drawing.Point(3, 3);
            this.textSource.Multiline = true;
            this.textSource.Name = "textSource";
            this.textSource.Size = new System.Drawing.Size(523, 196);
            this.textSource.TabIndex = 0;
            this.textSource.Text = "Source";
            this.textSource.TextChanged += new System.EventHandler(this.textSource_TextChanged);
            this.textSource.DoubleClick += new System.EventHandler(this.openFile);
            // 
            // textSourceContextMenu
            // 
            this.textSourceContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSourceContextMenuNewWindow,
            this.textSourceContextMenuClear});
            this.textSourceContextMenu.Name = "textSourceContextMenu";
            this.textSourceContextMenu.Size = new System.Drawing.Size(187, 48);
            // 
            // textSourceContextMenuNewWindow
            // 
            this.textSourceContextMenuNewWindow.Name = "textSourceContextMenuNewWindow";
            this.textSourceContextMenuNewWindow.Size = new System.Drawing.Size(186, 22);
            this.textSourceContextMenuNewWindow.Text = "Open in new window";
            this.textSourceContextMenuNewWindow.Click += new System.EventHandler(this.textSourceContextMenuNewWindow_Click);
            // 
            // textSourceContextMenuClear
            // 
            this.textSourceContextMenuClear.Name = "textSourceContextMenuClear";
            this.textSourceContextMenuClear.Size = new System.Drawing.Size(186, 22);
            this.textSourceContextMenuClear.Text = "Clear";
            this.textSourceContextMenuClear.Click += new System.EventHandler(this.textContextMenuClear_Click);
            // 
            // textResult
            // 
            this.textResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textResult.Location = new System.Drawing.Point(3, 280);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.Size = new System.Drawing.Size(523, 197);
            this.textResult.TabIndex = 1;
            this.textResult.Text = "Result";
            this.textResult.DoubleClick += new System.EventHandler(this.saveFile);
            // 
            // panelIntstrument
            // 
            this.panelIntstrument.Controls.Add(this.labelKey);
            this.panelIntstrument.Controls.Add(this.buttonShowFile);
            this.panelIntstrument.Controls.Add(this.buttonSave);
            this.panelIntstrument.Controls.Add(this.buttonOpen);
            this.panelIntstrument.Controls.Add(this.buttonSwap);
            this.panelIntstrument.Controls.Add(this.buttonGenerate);
            this.panelIntstrument.Controls.Add(this.textKey);
            this.panelIntstrument.Controls.Add(this.groupMode);
            this.panelIntstrument.Controls.Add(this.buttonProcess);
            this.panelIntstrument.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntstrument.Location = new System.Drawing.Point(0, 202);
            this.panelIntstrument.Margin = new System.Windows.Forms.Padding(0);
            this.panelIntstrument.Name = "panelIntstrument";
            this.panelIntstrument.Size = new System.Drawing.Size(529, 75);
            this.panelIntstrument.TabIndex = 2;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(3, 9);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(28, 13);
            this.labelKey.TabIndex = 8;
            this.labelKey.Text = "Key:";
            // 
            // buttonShowFile
            // 
            this.buttonShowFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonShowFile.Location = new System.Drawing.Point(4, 33);
            this.buttonShowFile.Name = "buttonShowFile";
            this.buttonShowFile.Size = new System.Drawing.Size(157, 39);
            this.buttonShowFile.TabIndex = 7;
            this.buttonShowFile.Text = "File";
            this.buttonShowFile.UseVisualStyleBackColor = true;
            this.buttonShowFile.Click += new System.EventHandler(this.buttonShowFile_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(86, 33);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 39);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.saveFile);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOpen.Location = new System.Drawing.Point(4, 33);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 39);
            this.buttonOpen.TabIndex = 5;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Visible = false;
            this.buttonOpen.Click += new System.EventHandler(this.openFile);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSwap.Location = new System.Drawing.Point(167, 33);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(84, 39);
            this.buttonSwap.TabIndex = 4;
            this.buttonSwap.Text = "Swap";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.swapTexts);
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(167, 4);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(84, 23);
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.generateKey);
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(37, 6);
            this.textKey.MaxLength = 9;
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(124, 20);
            this.textKey.TabIndex = 2;
            this.textKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyNumbers);
            // 
            // groupMode
            // 
            this.groupMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupMode.Controls.Add(this.radioDecrypt);
            this.groupMode.Controls.Add(this.radioEncrypt);
            this.groupMode.Location = new System.Drawing.Point(311, 3);
            this.groupMode.Name = "groupMode";
            this.groupMode.Size = new System.Drawing.Size(134, 69);
            this.groupMode.TabIndex = 1;
            this.groupMode.TabStop = false;
            this.groupMode.Text = "Mode";
            // 
            // radioDecrypt
            // 
            this.radioDecrypt.AutoSize = true;
            this.radioDecrypt.Location = new System.Drawing.Point(7, 44);
            this.radioDecrypt.Name = "radioDecrypt";
            this.radioDecrypt.Size = new System.Drawing.Size(62, 17);
            this.radioDecrypt.TabIndex = 1;
            this.radioDecrypt.Text = "Decrypt";
            this.radioDecrypt.UseVisualStyleBackColor = true;
            // 
            // radioEncrypt
            // 
            this.radioEncrypt.AutoSize = true;
            this.radioEncrypt.Checked = true;
            this.radioEncrypt.Location = new System.Drawing.Point(7, 20);
            this.radioEncrypt.Name = "radioEncrypt";
            this.radioEncrypt.Size = new System.Drawing.Size(61, 17);
            this.radioEncrypt.TabIndex = 0;
            this.radioEncrypt.TabStop = true;
            this.radioEncrypt.Text = "Encrypt";
            this.radioEncrypt.UseVisualStyleBackColor = true;
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Location = new System.Drawing.Point(451, 3);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 69);
            this.buttonProcess.TabIndex = 0;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSeparator,
            this.toolStripStatusLabelSymbols,
            this.toolStripStatusLabelSymbolsCount});
            this.statusMain.Location = new System.Drawing.Point(0, 478);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(529, 22);
            this.statusMain.SizingGrip = false;
            this.statusMain.TabIndex = 1;
            this.statusMain.Text = "statusStrip1";
            // 
            // toolStripStatusSeparator
            // 
            this.toolStripStatusSeparator.Name = "toolStripStatusSeparator";
            this.toolStripStatusSeparator.Size = new System.Drawing.Size(446, 17);
            this.toolStripStatusSeparator.Spring = true;
            // 
            // toolStripStatusLabelSymbols
            // 
            this.toolStripStatusLabelSymbols.Name = "toolStripStatusLabelSymbols";
            this.toolStripStatusLabelSymbols.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabelSymbols.Text = "Symbols:";
            // 
            // toolStripStatusLabelSymbolsCount
            // 
            this.toolStripStatusLabelSymbolsCount.Name = "toolStripStatusLabelSymbolsCount";
            this.toolStripStatusLabelSymbolsCount.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabelSymbolsCount.Text = "6";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 500);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.tableMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.menuBase;
            this.MinimumSize = new System.Drawing.Size(500, 320);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CryptoGUI";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.textSourceContextMenu.ResumeLayout(false);
            this.panelIntstrument.ResumeLayout(false);
            this.panelIntstrument.PerformLayout();
            this.groupMode.ResumeLayout(false);
            this.groupMode.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu menuBase;
        private System.Windows.Forms.MenuItem menuFile;
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Panel panelIntstrument;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.GroupBox groupMode;
        private System.Windows.Forms.RadioButton radioDecrypt;
        private System.Windows.Forms.RadioButton radioEncrypt;
        private System.Windows.Forms.MenuItem menuOpen;
        private System.Windows.Forms.MenuItem menuSave;
        private System.Windows.Forms.MenuItem menuExit;
        private System.Windows.Forms.MenuItem menuFileSeparator;
        private System.Windows.Forms.MenuItem menuAction;
        private System.Windows.Forms.MenuItem menuGenerate;
        private System.Windows.Forms.MenuItem menuSwap;
        private System.Windows.Forms.MenuItem menuActionSeparator;
        private System.Windows.Forms.MenuItem menuProcess;
        private System.Windows.Forms.MenuItem menuHelp;
        private System.Windows.Forms.MenuItem menuAbout;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textKey;
        private System.Windows.Forms.Button buttonShowFile;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSeparator;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSymbols;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSymbolsCount;
        private System.Windows.Forms.ContextMenuStrip textSourceContextMenu;
        private System.Windows.Forms.ToolStripMenuItem textSourceContextMenuNewWindow;
        private System.Windows.Forms.ToolStripMenuItem textSourceContextMenuClear;
        public System.Windows.Forms.TextBox textSource;
    }
}


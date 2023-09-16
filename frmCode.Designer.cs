namespace SCOToolBox
{
    partial class frmCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCode));
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupBoxGlobals = new System.Windows.Forms.GroupBox();
            this.buttonClearG = new System.Windows.Forms.Button();
            this.buttonUpG = new System.Windows.Forms.Button();
            this.buttonDownG = new System.Windows.Forms.Button();
            this.buttonEditG = new System.Windows.Forms.Button();
            this.buttonDeleteG = new System.Windows.Forms.Button();
            this.buttonAddG = new System.Windows.Forms.Button();
            this.listViewGlobals = new System.Windows.Forms.ListView();
            this.columnHeaderCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxFlags = new System.Windows.Forms.GroupBox();
            this.checkedListBox = new System.Windows.Forms.CheckedListBox();
            this.groupBoxPublics = new System.Windows.Forms.GroupBox();
            this.buttonClearP = new System.Windows.Forms.Button();
            this.buttonUpP = new System.Windows.Forms.Button();
            this.buttonDownP = new System.Windows.Forms.Button();
            this.buttonEditP = new System.Windows.Forms.Button();
            this.buttonDeleteP = new System.Windows.Forms.Button();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.listViewPublics = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.syntaxDocument = new Alsing.SourceCode.SyntaxDocument(this.components);
            this.syntaxBoxControl = new Alsing.Windows.Forms.SyntaxBoxControl();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonSaveAs = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripButtonSaveAsSCO = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonSaveAsSCOEncoded = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSaveAsText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonSaveAsHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrintPreview = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCut = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonSelectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOutdent = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonIndent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonGoTo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFind = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReplace = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonToggleBookmark = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPreviousBookmark = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextBookmark = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonInsertFunction = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonInsertNative = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxNatType = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripButtonNatType = new System.Windows.Forms.ToolStripButton();
            this.listBoxNatives = new System.Windows.Forms.ListBox();
            this.listBoxFunctions = new System.Windows.Forms.ListBox();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.backgroundWorkerCompile1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerCompile2 = new System.ComponentModel.BackgroundWorker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.timerStartUp = new System.Windows.Forms.Timer(this.components);
            this.timerProgress = new System.Windows.Forms.Timer(this.components);
            this.timerProgressRead = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogSCO = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogSCOEncoded = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogText = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogHTML = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorkerRead1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerRead2 = new System.ComponentModel.BackgroundWorker();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxGlobals.SuspendLayout();
            this.groupBoxFlags.SuspendLayout();
            this.groupBoxPublics.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Location = new System.Drawing.Point(832, 613);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 25);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // groupBoxGlobals
            // 
            this.groupBoxGlobals.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxGlobals.Controls.Add(this.buttonClearG);
            this.groupBoxGlobals.Controls.Add(this.buttonUpG);
            this.groupBoxGlobals.Controls.Add(this.buttonDownG);
            this.groupBoxGlobals.Controls.Add(this.buttonEditG);
            this.groupBoxGlobals.Controls.Add(this.buttonDeleteG);
            this.groupBoxGlobals.Controls.Add(this.buttonAddG);
            this.groupBoxGlobals.Controls.Add(this.listViewGlobals);
            this.groupBoxGlobals.Location = new System.Drawing.Point(710, 12);
            this.groupBoxGlobals.Name = "groupBoxGlobals";
            this.groupBoxGlobals.Size = new System.Drawing.Size(202, 218);
            this.groupBoxGlobals.TabIndex = 20;
            this.groupBoxGlobals.TabStop = false;
            this.groupBoxGlobals.Text = "Global Variables";
            // 
            // buttonClearG
            // 
            this.buttonClearG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClearG.Location = new System.Drawing.Point(101, 183);
            this.buttonClearG.Name = "buttonClearG";
            this.buttonClearG.Size = new System.Drawing.Size(25, 25);
            this.buttonClearG.TabIndex = 28;
            this.buttonClearG.Text = "XX";
            this.buttonClearG.UseVisualStyleBackColor = true;
            this.buttonClearG.Click += new System.EventHandler(this.buttonClearG_Click);
            // 
            // buttonUpG
            // 
            this.buttonUpG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUpG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpG.Location = new System.Drawing.Point(138, 183);
            this.buttonUpG.Name = "buttonUpG";
            this.buttonUpG.Size = new System.Drawing.Size(25, 25);
            this.buttonUpG.TabIndex = 23;
            this.buttonUpG.Text = "▲";
            this.buttonUpG.UseVisualStyleBackColor = true;
            this.buttonUpG.Visible = false;
            // 
            // buttonDownG
            // 
            this.buttonDownG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDownG.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownG.Location = new System.Drawing.Point(169, 183);
            this.buttonDownG.Name = "buttonDownG";
            this.buttonDownG.Size = new System.Drawing.Size(25, 25);
            this.buttonDownG.TabIndex = 22;
            this.buttonDownG.Text = "▼";
            this.buttonDownG.UseVisualStyleBackColor = true;
            this.buttonDownG.Visible = false;
            // 
            // buttonEditG
            // 
            this.buttonEditG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditG.Location = new System.Drawing.Point(39, 183);
            this.buttonEditG.Name = "buttonEditG";
            this.buttonEditG.Size = new System.Drawing.Size(25, 25);
            this.buttonEditG.TabIndex = 21;
            this.buttonEditG.Text = "E";
            this.buttonEditG.UseVisualStyleBackColor = true;
            this.buttonEditG.Click += new System.EventHandler(this.buttonEditG_Click);
            // 
            // buttonDeleteG
            // 
            this.buttonDeleteG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDeleteG.Location = new System.Drawing.Point(70, 183);
            this.buttonDeleteG.Name = "buttonDeleteG";
            this.buttonDeleteG.Size = new System.Drawing.Size(25, 25);
            this.buttonDeleteG.TabIndex = 20;
            this.buttonDeleteG.Text = "X";
            this.buttonDeleteG.UseVisualStyleBackColor = true;
            this.buttonDeleteG.Click += new System.EventHandler(this.buttonDeleteG_Click);
            // 
            // buttonAddG
            // 
            this.buttonAddG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddG.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddG.Location = new System.Drawing.Point(8, 183);
            this.buttonAddG.Name = "buttonAddG";
            this.buttonAddG.Size = new System.Drawing.Size(25, 25);
            this.buttonAddG.TabIndex = 19;
            this.buttonAddG.Text = "+";
            this.buttonAddG.UseVisualStyleBackColor = true;
            this.buttonAddG.Click += new System.EventHandler(this.buttonAddG_Click);
            // 
            // listViewGlobals
            // 
            this.listViewGlobals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewGlobals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCount,
            this.columnHeaderValue});
            this.listViewGlobals.FullRowSelect = true;
            this.listViewGlobals.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewGlobals.Location = new System.Drawing.Point(9, 20);
            this.listViewGlobals.Name = "listViewGlobals";
            this.listViewGlobals.Size = new System.Drawing.Size(184, 157);
            this.listViewGlobals.TabIndex = 0;
            this.listViewGlobals.UseCompatibleStateImageBehavior = false;
            this.listViewGlobals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCount
            // 
            this.columnHeaderCount.Text = "#";
            this.columnHeaderCount.Width = 50;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            this.columnHeaderValue.Width = 100;
            // 
            // groupBoxFlags
            // 
            this.groupBoxFlags.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFlags.Controls.Add(this.checkedListBox);
            this.groupBoxFlags.Location = new System.Drawing.Point(710, 444);
            this.groupBoxFlags.Name = "groupBoxFlags";
            this.groupBoxFlags.Size = new System.Drawing.Size(202, 163);
            this.groupBoxFlags.TabIndex = 21;
            this.groupBoxFlags.TabStop = false;
            this.groupBoxFlags.Text = "Script Flags";
            // 
            // checkedListBox
            // 
            this.checkedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.checkedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox.FormattingEnabled = true;
            this.checkedListBox.Items.AddRange(new object[] {
            "Unknown Flag 1",
            "Unknown Flag 2",
            "Unknown Flag 3",
            "Unknown Flag 4",
            "Unknown Flag 5",
            "Unknown Flag 6",
            "Unknown Flag 7",
            "Unknown Flag 8",
            "Unknown Flag 9",
            "Unknown Flag 10",
            "Unknown Flag 11",
            "Unknown Flag 12",
            "Unknown Flag 13",
            "Unknown Flag 14",
            "Unknown Flag 15",
            "Unknown Flag 16",
            "Unknown Flag 17",
            "Unknown Flag 18",
            "Unknown Flag 19",
            "Unknown Flag 20",
            "Unknown Flag 21",
            "Unknown Flag 22",
            "Unknown Flag 23",
            "Unknown Flag 24",
            "Unknown Flag 25",
            "Unknown Flag 26",
            "Unknown Flag 27",
            "Unknown Flag 28",
            "Unknown Flag 29",
            "Unknown Flag 30",
            "Unknown Flag 31",
            "Unknown Flag 32"});
            this.checkedListBox.Location = new System.Drawing.Point(9, 20);
            this.checkedListBox.Name = "checkedListBox";
            this.checkedListBox.Size = new System.Drawing.Size(184, 128);
            this.checkedListBox.TabIndex = 0;
            // 
            // groupBoxPublics
            // 
            this.groupBoxPublics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxPublics.Controls.Add(this.buttonClearP);
            this.groupBoxPublics.Controls.Add(this.buttonUpP);
            this.groupBoxPublics.Controls.Add(this.buttonDownP);
            this.groupBoxPublics.Controls.Add(this.buttonEditP);
            this.groupBoxPublics.Controls.Add(this.buttonDeleteP);
            this.groupBoxPublics.Controls.Add(this.buttonAddP);
            this.groupBoxPublics.Controls.Add(this.listViewPublics);
            this.groupBoxPublics.Location = new System.Drawing.Point(710, 239);
            this.groupBoxPublics.Name = "groupBoxPublics";
            this.groupBoxPublics.Size = new System.Drawing.Size(202, 196);
            this.groupBoxPublics.TabIndex = 21;
            this.groupBoxPublics.TabStop = false;
            this.groupBoxPublics.Text = "Public Variables";
            // 
            // buttonClearP
            // 
            this.buttonClearP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonClearP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClearP.Location = new System.Drawing.Point(101, 161);
            this.buttonClearP.Name = "buttonClearP";
            this.buttonClearP.Size = new System.Drawing.Size(25, 25);
            this.buttonClearP.TabIndex = 27;
            this.buttonClearP.Text = "XX";
            this.buttonClearP.UseVisualStyleBackColor = true;
            this.buttonClearP.Click += new System.EventHandler(this.buttonClearP_Click);
            // 
            // buttonUpP
            // 
            this.buttonUpP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonUpP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpP.Location = new System.Drawing.Point(138, 161);
            this.buttonUpP.Name = "buttonUpP";
            this.buttonUpP.Size = new System.Drawing.Size(25, 25);
            this.buttonUpP.TabIndex = 26;
            this.buttonUpP.Text = "▲";
            this.buttonUpP.UseVisualStyleBackColor = true;
            this.buttonUpP.Visible = false;
            // 
            // buttonDownP
            // 
            this.buttonDownP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDownP.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDownP.Location = new System.Drawing.Point(169, 161);
            this.buttonDownP.Name = "buttonDownP";
            this.buttonDownP.Size = new System.Drawing.Size(25, 25);
            this.buttonDownP.TabIndex = 25;
            this.buttonDownP.Text = "▼";
            this.buttonDownP.UseVisualStyleBackColor = true;
            this.buttonDownP.Visible = false;
            // 
            // buttonEditP
            // 
            this.buttonEditP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonEditP.Location = new System.Drawing.Point(39, 161);
            this.buttonEditP.Name = "buttonEditP";
            this.buttonEditP.Size = new System.Drawing.Size(25, 25);
            this.buttonEditP.TabIndex = 24;
            this.buttonEditP.Text = "E";
            this.buttonEditP.UseVisualStyleBackColor = true;
            this.buttonEditP.Click += new System.EventHandler(this.buttonEditP_Click);
            // 
            // buttonDeleteP
            // 
            this.buttonDeleteP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDeleteP.Location = new System.Drawing.Point(70, 161);
            this.buttonDeleteP.Name = "buttonDeleteP";
            this.buttonDeleteP.Size = new System.Drawing.Size(25, 25);
            this.buttonDeleteP.TabIndex = 23;
            this.buttonDeleteP.Text = "X";
            this.buttonDeleteP.UseVisualStyleBackColor = true;
            this.buttonDeleteP.Click += new System.EventHandler(this.buttonDeleteP_Click);
            // 
            // buttonAddP
            // 
            this.buttonAddP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAddP.Location = new System.Drawing.Point(8, 161);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(25, 25);
            this.buttonAddP.TabIndex = 22;
            this.buttonAddP.Text = "+";
            this.buttonAddP.UseVisualStyleBackColor = true;
            this.buttonAddP.Click += new System.EventHandler(this.buttonAddP_Click);
            // 
            // listViewPublics
            // 
            this.listViewPublics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewPublics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewPublics.FullRowSelect = true;
            this.listViewPublics.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPublics.Location = new System.Drawing.Point(9, 20);
            this.listViewPublics.Name = "listViewPublics";
            this.listViewPublics.Size = new System.Drawing.Size(184, 135);
            this.listViewPublics.TabIndex = 21;
            this.listViewPublics.UseCompatibleStateImageBehavior = false;
            this.listViewPublics.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 100;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Function.ico");
            this.imageList.Images.SetKeyName(1, "Native.ico");
            // 
            // syntaxDocument
            // 
            this.syntaxDocument.Lines = new string[] {
        " "};
            this.syntaxDocument.MaxUndoBufferSize = 1000;
            this.syntaxDocument.Modified = false;
            this.syntaxDocument.UndoStep = 0;
            // 
            // syntaxBoxControl
            // 
            this.syntaxBoxControl.ActiveView = Alsing.Windows.Forms.ActiveView.BottomRight;
            this.syntaxBoxControl.AllowBreakPoints = false;
            this.syntaxBoxControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.syntaxBoxControl.AutoListPosition = null;
            this.syntaxBoxControl.AutoListSelectedText = "a123";
            this.syntaxBoxControl.AutoListVisible = false;
            this.syntaxBoxControl.BackColor = System.Drawing.Color.White;
            this.syntaxBoxControl.BorderStyle = Alsing.Windows.Forms.BorderStyle.None;
            this.syntaxBoxControl.CopyAsRTF = false;
            this.syntaxBoxControl.FontName = "Consolas";
            this.syntaxBoxControl.FontSize = 12F;
            this.syntaxBoxControl.GutterMarginWidth = 18;
            this.syntaxBoxControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.syntaxBoxControl.InfoTipCount = 1;
            this.syntaxBoxControl.InfoTipPosition = null;
            this.syntaxBoxControl.InfoTipSelectedIndex = 1;
            this.syntaxBoxControl.InfoTipVisible = false;
            this.syntaxBoxControl.LineNumberBackColor = System.Drawing.Color.White;
            this.syntaxBoxControl.LineNumberBorderColor = System.Drawing.Color.DimGray;
            this.syntaxBoxControl.LineNumberForeColor = System.Drawing.Color.Gray;
            this.syntaxBoxControl.Location = new System.Drawing.Point(9, 37);
            this.syntaxBoxControl.LockCursorUpdate = false;
            this.syntaxBoxControl.Name = "syntaxBoxControl";
            this.syntaxBoxControl.ShowScopeIndicator = false;
            this.syntaxBoxControl.Size = new System.Drawing.Size(689, 569);
            this.syntaxBoxControl.SmoothScroll = false;
            this.syntaxBoxControl.SplitView = false;
            this.syntaxBoxControl.SplitviewH = -4;
            this.syntaxBoxControl.SplitviewV = -4;
            this.syntaxBoxControl.TabGuideColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.syntaxBoxControl.TabIndex = 23;
            this.syntaxBoxControl.Text = "syntaxBoxControl1";
            this.syntaxBoxControl.WhitespaceColor = System.Drawing.SystemColors.ControlDark;
            this.syntaxBoxControl.CaretChange += new System.EventHandler(this.syntaxBoxControl_CaretChange);
            this.syntaxBoxControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.syntaxBoxControl_KeyPress);
            // 
            // toolStrip
            // 
            this.toolStrip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip.AutoSize = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonReload,
            this.toolStripSplitButtonSaveAs,
            this.toolStripSeparator1,
            this.toolStripButtonPrint,
            this.toolStripButtonPrintPreview,
            this.toolStripSeparator2,
            this.toolStripButtonCut,
            this.toolStripButtonCopy,
            this.toolStripButtonPaste,
            this.toolStripSeparator3,
            this.toolStripButtonSelectAll,
            this.toolStripSeparator4,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripSeparator5,
            this.toolStripButtonOutdent,
            this.toolStripButtonIndent,
            this.toolStripSeparator6,
            this.toolStripButtonGoTo,
            this.toolStripButtonFind,
            this.toolStripButtonReplace,
            this.toolStripSeparator7,
            this.toolStripButtonToggleBookmark,
            this.toolStripButtonPreviousBookmark,
            this.toolStripButtonNextBookmark,
            this.toolStripSeparator8,
            this.toolStripButtonInsertFunction,
            this.toolStripButtonInsertNative,
            this.toolStripComboBoxNatType,
            this.toolStripButtonNatType});
            this.toolStrip.Location = new System.Drawing.Point(9, 12);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(689, 25);
            this.toolStrip.TabIndex = 24;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReload.Image")));
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReload.Text = "Reload...";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // toolStripSplitButtonSaveAs
            // 
            this.toolStripSplitButtonSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonSaveAs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSaveAsSCO,
            this.toolStripButtonSaveAsSCOEncoded,
            this.toolStripMenuItem1,
            this.toolStripButtonSaveAsText,
            this.toolStripButtonSaveAsHTML});
            this.toolStripSplitButtonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonSaveAs.Image")));
            this.toolStripSplitButtonSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSaveAs.Name = "toolStripSplitButtonSaveAs";
            this.toolStripSplitButtonSaveAs.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonSaveAs.Text = "Save As...";
            this.toolStripSplitButtonSaveAs.ButtonClick += new System.EventHandler(this.toolStripButtonSaveAsSCO_Click);
            // 
            // toolStripButtonSaveAsSCO
            // 
            this.toolStripButtonSaveAsSCO.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAsSCO.Image")));
            this.toolStripButtonSaveAsSCO.Name = "toolStripButtonSaveAsSCO";
            this.toolStripButtonSaveAsSCO.Size = new System.Drawing.Size(185, 22);
            this.toolStripButtonSaveAsSCO.Text = "SCO File (Decoded)...";
            this.toolStripButtonSaveAsSCO.Click += new System.EventHandler(this.toolStripButtonSaveAsSCO_Click);
            // 
            // toolStripButtonSaveAsSCOEncoded
            // 
            this.toolStripButtonSaveAsSCOEncoded.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAsSCOEncoded.Image")));
            this.toolStripButtonSaveAsSCOEncoded.Name = "toolStripButtonSaveAsSCOEncoded";
            this.toolStripButtonSaveAsSCOEncoded.Size = new System.Drawing.Size(185, 22);
            this.toolStripButtonSaveAsSCOEncoded.Text = "SCO File (Encoded)...";
            this.toolStripButtonSaveAsSCOEncoded.ToolTipText = "SCO File (Encoded)...";
            this.toolStripButtonSaveAsSCOEncoded.Click += new System.EventHandler(this.toolStripButtonSaveAsSCOEncoded_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(182, 6);
            // 
            // toolStripButtonSaveAsText
            // 
            this.toolStripButtonSaveAsText.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAsText.Image")));
            this.toolStripButtonSaveAsText.Name = "toolStripButtonSaveAsText";
            this.toolStripButtonSaveAsText.Size = new System.Drawing.Size(185, 22);
            this.toolStripButtonSaveAsText.Text = "Text File...";
            this.toolStripButtonSaveAsText.Click += new System.EventHandler(this.toolStripButtonSaveAsText_Click);
            // 
            // toolStripButtonSaveAsHTML
            // 
            this.toolStripButtonSaveAsHTML.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSaveAsHTML.Image")));
            this.toolStripButtonSaveAsHTML.Name = "toolStripButtonSaveAsHTML";
            this.toolStripButtonSaveAsHTML.Size = new System.Drawing.Size(185, 22);
            this.toolStripButtonSaveAsHTML.Text = "HTML File...";
            this.toolStripButtonSaveAsHTML.Click += new System.EventHandler(this.toolStripButtonSaveAsHTML_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrint
            // 
            this.toolStripButtonPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrint.Enabled = false;
            this.toolStripButtonPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrint.Image")));
            this.toolStripButtonPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrint.Name = "toolStripButtonPrint";
            this.toolStripButtonPrint.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrint.Text = "Print...";
            this.toolStripButtonPrint.Click += new System.EventHandler(this.toolStripButtonPrint_Click);
            // 
            // toolStripButtonPrintPreview
            // 
            this.toolStripButtonPrintPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrintPreview.Enabled = false;
            this.toolStripButtonPrintPreview.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrintPreview.Image")));
            this.toolStripButtonPrintPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrintPreview.Name = "toolStripButtonPrintPreview";
            this.toolStripButtonPrintPreview.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrintPreview.Text = "Print Preview...";
            this.toolStripButtonPrintPreview.Click += new System.EventHandler(this.toolStripButtonPrintPreview_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCut
            // 
            this.toolStripButtonCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCut.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCut.Image")));
            this.toolStripButtonCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCut.Name = "toolStripButtonCut";
            this.toolStripButtonCut.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCut.Text = "Cut";
            this.toolStripButtonCut.Click += new System.EventHandler(this.toolStripButtonCut_Click);
            // 
            // toolStripButtonCopy
            // 
            this.toolStripButtonCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCopy.Image")));
            this.toolStripButtonCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCopy.Name = "toolStripButtonCopy";
            this.toolStripButtonCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonCopy.Text = "Copy";
            this.toolStripButtonCopy.Click += new System.EventHandler(this.toolStripButtonCopy_Click);
            // 
            // toolStripButtonPaste
            // 
            this.toolStripButtonPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPaste.Image")));
            this.toolStripButtonPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPaste.Name = "toolStripButtonPaste";
            this.toolStripButtonPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPaste.Text = "Paste";
            this.toolStripButtonPaste.Click += new System.EventHandler(this.toolStripButtonPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonSelectAll
            // 
            this.toolStripButtonSelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSelectAll.Image")));
            this.toolStripButtonSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSelectAll.Name = "toolStripButtonSelectAll";
            this.toolStripButtonSelectAll.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSelectAll.Text = "Select All";
            this.toolStripButtonSelectAll.Click += new System.EventHandler(this.toolStripButtonSelectAll_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonUndo.Text = "Undo";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.toolStripButtonUndo_Click);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRedo.Text = "Redo";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.toolStripButtonRedo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOutdent
            // 
            this.toolStripButtonOutdent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOutdent.Enabled = false;
            this.toolStripButtonOutdent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOutdent.Image")));
            this.toolStripButtonOutdent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOutdent.Name = "toolStripButtonOutdent";
            this.toolStripButtonOutdent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOutdent.Text = "Outdent";
            this.toolStripButtonOutdent.Click += new System.EventHandler(this.toolStripButtonOutdent_Click);
            // 
            // toolStripButtonIndent
            // 
            this.toolStripButtonIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonIndent.Enabled = false;
            this.toolStripButtonIndent.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonIndent.Image")));
            this.toolStripButtonIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonIndent.Name = "toolStripButtonIndent";
            this.toolStripButtonIndent.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonIndent.Text = "Indent";
            this.toolStripButtonIndent.Click += new System.EventHandler(this.toolStripButtonIndent_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonGoTo
            // 
            this.toolStripButtonGoTo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGoTo.Enabled = false;
            this.toolStripButtonGoTo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGoTo.Image")));
            this.toolStripButtonGoTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGoTo.Name = "toolStripButtonGoTo";
            this.toolStripButtonGoTo.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGoTo.Text = "Go To";
            this.toolStripButtonGoTo.Click += new System.EventHandler(this.toolStripButtonGoTo_Click);
            // 
            // toolStripButtonFind
            // 
            this.toolStripButtonFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFind.Enabled = false;
            this.toolStripButtonFind.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFind.Image")));
            this.toolStripButtonFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFind.Name = "toolStripButtonFind";
            this.toolStripButtonFind.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFind.Text = "Find...";
            this.toolStripButtonFind.Click += new System.EventHandler(this.toolStripButtonFind_Click);
            // 
            // toolStripButtonReplace
            // 
            this.toolStripButtonReplace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReplace.Enabled = false;
            this.toolStripButtonReplace.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonReplace.Image")));
            this.toolStripButtonReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReplace.Name = "toolStripButtonReplace";
            this.toolStripButtonReplace.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonReplace.Text = "Find && Replace...";
            this.toolStripButtonReplace.ToolTipText = "Find & Replace...";
            this.toolStripButtonReplace.Click += new System.EventHandler(this.toolStripButtonReplace_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonToggleBookmark
            // 
            this.toolStripButtonToggleBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonToggleBookmark.Enabled = false;
            this.toolStripButtonToggleBookmark.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonToggleBookmark.Image")));
            this.toolStripButtonToggleBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonToggleBookmark.Name = "toolStripButtonToggleBookmark";
            this.toolStripButtonToggleBookmark.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonToggleBookmark.Text = "Toggle Bookmark";
            this.toolStripButtonToggleBookmark.Click += new System.EventHandler(this.toolStripButtonToggleBookmark_Click);
            // 
            // toolStripButtonPreviousBookmark
            // 
            this.toolStripButtonPreviousBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPreviousBookmark.Enabled = false;
            this.toolStripButtonPreviousBookmark.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPreviousBookmark.Image")));
            this.toolStripButtonPreviousBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPreviousBookmark.Name = "toolStripButtonPreviousBookmark";
            this.toolStripButtonPreviousBookmark.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPreviousBookmark.Text = "Previous Bookmark";
            this.toolStripButtonPreviousBookmark.Click += new System.EventHandler(this.toolStripButtonPreviousBookmark_Click);
            // 
            // toolStripButtonNextBookmark
            // 
            this.toolStripButtonNextBookmark.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextBookmark.Enabled = false;
            this.toolStripButtonNextBookmark.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNextBookmark.Image")));
            this.toolStripButtonNextBookmark.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextBookmark.Name = "toolStripButtonNextBookmark";
            this.toolStripButtonNextBookmark.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNextBookmark.Text = "Next Bookmark";
            this.toolStripButtonNextBookmark.Click += new System.EventHandler(this.toolStripButtonNextBookmark_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonInsertFunction
            // 
            this.toolStripButtonInsertFunction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertFunction.Enabled = false;
            this.toolStripButtonInsertFunction.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertFunction.Image")));
            this.toolStripButtonInsertFunction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertFunction.Name = "toolStripButtonInsertFunction";
            this.toolStripButtonInsertFunction.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInsertFunction.Text = "Insert Function...";
            this.toolStripButtonInsertFunction.Click += new System.EventHandler(this.toolStripButtonInsertFunction_Click);
            // 
            // toolStripButtonInsertNative
            // 
            this.toolStripButtonInsertNative.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonInsertNative.Enabled = false;
            this.toolStripButtonInsertNative.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonInsertNative.Image")));
            this.toolStripButtonInsertNative.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonInsertNative.Name = "toolStripButtonInsertNative";
            this.toolStripButtonInsertNative.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonInsertNative.Text = "Insert Native...";
            this.toolStripButtonInsertNative.Click += new System.EventHandler(this.toolStripButtonInsertNative_Click);
            // 
            // toolStripComboBoxNatType
            // 
            this.toolStripComboBoxNatType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxNatType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxNatType.Items.AddRange(new object[] {
            "Old (1.0.4.0)",
            "New (1.0.7.0+)"});
            this.toolStripComboBoxNatType.Name = "toolStripComboBoxNatType";
            this.toolStripComboBoxNatType.Size = new System.Drawing.Size(95, 25);
            this.toolStripComboBoxNatType.ToolTipText = "Natives Mode";
            this.toolStripComboBoxNatType.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxNatType_SelectedIndexChanged);
            // 
            // toolStripButtonNatType
            // 
            this.toolStripButtonNatType.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonNatType.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNatType.Enabled = false;
            this.toolStripButtonNatType.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNatType.Image")));
            this.toolStripButtonNatType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNatType.Name = "toolStripButtonNatType";
            this.toolStripButtonNatType.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNatType.Text = "Natives Mode";
            // 
            // listBoxNatives
            // 
            this.listBoxNatives.FormattingEnabled = true;
            this.listBoxNatives.Location = new System.Drawing.Point(692, 621);
            this.listBoxNatives.Name = "listBoxNatives";
            this.listBoxNatives.Size = new System.Drawing.Size(69, 17);
            this.listBoxNatives.TabIndex = 26;
            this.listBoxNatives.Visible = false;
            // 
            // listBoxFunctions
            // 
            this.listBoxFunctions.FormattingEnabled = true;
            this.listBoxFunctions.Location = new System.Drawing.Point(617, 621);
            this.listBoxFunctions.Name = "listBoxFunctions";
            this.listBoxFunctions.Size = new System.Drawing.Size(69, 17);
            this.listBoxFunctions.TabIndex = 25;
            this.listBoxFunctions.Visible = false;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.ShowIcon = false;
            this.printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // backgroundWorkerCompile1
            // 
            this.backgroundWorkerCompile1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCompile1_DoWork);
            // 
            // backgroundWorkerCompile2
            // 
            this.backgroundWorkerCompile2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCompile2_DoWork);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 619);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(819, 15);
            this.labelStatus.TabIndex = 27;
            this.labelStatus.Text = "Please wait...";
            // 
            // timerStartUp
            // 
            this.timerStartUp.Interval = 50;
            this.timerStartUp.Tick += new System.EventHandler(this.timerStartUp_Tick);
            // 
            // timerProgress
            // 
            this.timerProgress.Interval = 500;
            this.timerProgress.Tick += new System.EventHandler(this.timerProgress_Tick);
            // 
            // timerProgressRead
            // 
            this.timerProgressRead.Interval = 500;
            this.timerProgressRead.Tick += new System.EventHandler(this.timerProgressRead_Tick);
            // 
            // saveFileDialogSCO
            // 
            this.saveFileDialogSCO.Filter = "SCO Files (*.sco)|*.sco";
            this.saveFileDialogSCO.Title = "Save SCO File (Decoded)...";
            // 
            // saveFileDialogSCOEncoded
            // 
            this.saveFileDialogSCOEncoded.Filter = "SCO Files (*.sco)|*.sco";
            this.saveFileDialogSCOEncoded.Title = "Save SCO File (Encoded)...";
            // 
            // saveFileDialogText
            // 
            this.saveFileDialogText.Filter = "Text Files (*.txt)|*.txt";
            this.saveFileDialogText.Title = "Save Text File...";
            // 
            // saveFileDialogHTML
            // 
            this.saveFileDialogHTML.Filter = "HTML Files (*.html;*.htm)|*.html;*.htm";
            this.saveFileDialogHTML.Title = "Save HTML File...";
            // 
            // backgroundWorkerRead1
            // 
            this.backgroundWorkerRead1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRead1_DoWork);
            // 
            // backgroundWorkerRead2
            // 
            this.backgroundWorkerRead2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerRead2_DoWork);
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.Location = new System.Drawing.Point(9, 37);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox.Size = new System.Drawing.Size(690, 570);
            this.richTextBox.TabIndex = 28;
            this.richTextBox.Text = "";
            // 
            // frmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 647);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.listBoxNatives);
            this.Controls.Add(this.listBoxFunctions);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.syntaxBoxControl);
            this.Controls.Add(this.groupBoxPublics);
            this.Controls.Add(this.groupBoxFlags);
            this.Controls.Add(this.groupBoxGlobals);
            this.Controls.Add(this.buttonClose);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Editor";
            this.Load += new System.EventHandler(this.frmCode_Load);
            this.groupBoxGlobals.ResumeLayout(false);
            this.groupBoxFlags.ResumeLayout(false);
            this.groupBoxPublics.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.GroupBox groupBoxGlobals;
        private System.Windows.Forms.GroupBox groupBoxFlags;
        private System.Windows.Forms.GroupBox groupBoxPublics;
        private System.Windows.Forms.Button buttonUpG;
        private System.Windows.Forms.Button buttonDownG;
        private System.Windows.Forms.Button buttonEditG;
        private System.Windows.Forms.Button buttonDeleteG;
        private System.Windows.Forms.Button buttonAddG;
        private System.Windows.Forms.ListView listViewGlobals;
        private System.Windows.Forms.ColumnHeader columnHeaderCount;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Button buttonUpP;
        private System.Windows.Forms.Button buttonDownP;
        private System.Windows.Forms.Button buttonEditP;
        private System.Windows.Forms.Button buttonDeleteP;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.ListView listViewPublics;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList;
        private Alsing.SourceCode.SyntaxDocument syntaxDocument;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrint;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrintPreview;
        private System.Windows.Forms.ToolStripButton toolStripButtonCut;
        private System.Windows.Forms.ListBox listBoxNatives;
        private System.Windows.Forms.ListBox listBoxFunctions;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonCopy;
        private System.Windows.Forms.ToolStripButton toolStripButtonPaste;
        private System.Windows.Forms.ToolStripMenuItem toolStripButtonSaveAsSCO;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripButtonSaveAsText;
        private System.Windows.Forms.ToolStripMenuItem toolStripButtonSaveAsHTML;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonUndo;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedo;
        private System.Windows.Forms.ToolStripButton toolStripButtonSelectAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonOutdent;
        private System.Windows.Forms.ToolStripButton toolStripButtonIndent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButtonFind;
        private System.Windows.Forms.ToolStripButton toolStripButtonGoTo;
        private System.Windows.Forms.ToolStripButton toolStripButtonReplace;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButtonToggleBookmark;
        private System.Windows.Forms.ToolStripButton toolStripButtonPreviousBookmark;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextBookmark;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertFunction;
        private System.Windows.Forms.ToolStripButton toolStripButtonInsertNative;
        private System.Windows.Forms.CheckedListBox checkedListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCompile1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCompile2;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Timer timerStartUp;
        private System.Windows.Forms.ToolStripMenuItem toolStripButtonSaveAsSCOEncoded;
        private System.Windows.Forms.Timer timerProgress;
        private System.Windows.Forms.Timer timerProgressRead;
        public System.Windows.Forms.ToolStripComboBox toolStripComboBoxNatType;
        private System.Windows.Forms.ToolStripButton toolStripButtonNatType;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSCO;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSCOEncoded;
        private System.Windows.Forms.SaveFileDialog saveFileDialogText;
        private System.Windows.Forms.SaveFileDialog saveFileDialogHTML;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRead1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerRead2;
        public Alsing.Windows.Forms.SyntaxBoxControl syntaxBoxControl;
        public System.Windows.Forms.ToolStrip toolStrip;
        public System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button buttonClearG;
        private System.Windows.Forms.Button buttonClearP;
    }
}
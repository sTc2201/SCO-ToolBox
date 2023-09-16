namespace SCOToolBox
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.buttonProcessAll = new System.Windows.Forms.Button();
            this.buttonQuit = new System.Windows.Forms.Button();
            this.checkBoxSelfAll = new System.Windows.Forms.CheckBox();
            this.buttonBrowseDir = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelSignature = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelPublics = new System.Windows.Forms.Label();
            this.labelGlobals = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCodeSize = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBoxDir = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.openFileDialogMulti = new System.Windows.Forms.OpenFileDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSCOType = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageMulti = new System.Windows.Forms.TabPage();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.tabPageSingle = new System.Windows.Forms.TabPage();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.panelEditorType = new System.Windows.Forms.Panel();
            this.radioButtonBasic = new System.Windows.Forms.RadioButton();
            this.radioButtonAdvanced = new System.Windows.Forms.RadioButton();
            this.panelNatType = new System.Windows.Forms.Panel();
            this.radioButtonOld = new System.Windows.Forms.RadioButton();
            this.radioButtonNew = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labelAction = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labelFlags = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonCode = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxSelf = new System.Windows.Forms.CheckBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonBrowseTarget = new System.Windows.Forms.Button();
            this.textBoxTargetSCO = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxSCO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageDebug = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonDebug = new System.Windows.Forms.Button();
            this.textBoxDebugLog = new System.Windows.Forms.TextBox();
            this.buttonDebugCompare = new System.Windows.Forms.Button();
            this.checkBoxWriteHashes = new System.Windows.Forms.CheckBox();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.backgroundWorkerAll = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.tabPageMulti.SuspendLayout();
            this.tabPageSingle.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panelEditorType.SuspendLayout();
            this.panelNatType.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPageDebug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProcessAll
            // 
            this.buttonProcessAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcessAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProcessAll.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcessAll.Location = new System.Drawing.Point(444, 176);
            this.buttonProcessAll.Name = "buttonProcessAll";
            this.buttonProcessAll.Size = new System.Drawing.Size(80, 23);
            this.buttonProcessAll.TabIndex = 14;
            this.buttonProcessAll.Text = "Process!";
            this.buttonProcessAll.UseVisualStyleBackColor = true;
            this.buttonProcessAll.Click += new System.EventHandler(this.buttonProcessAll_Click);
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonQuit.Location = new System.Drawing.Point(469, 375);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(80, 25);
            this.buttonQuit.TabIndex = 5;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // checkBoxSelfAll
            // 
            this.checkBoxSelfAll.AutoSize = true;
            this.checkBoxSelfAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxSelfAll.Location = new System.Drawing.Point(61, 204);
            this.checkBoxSelfAll.Name = "checkBoxSelfAll";
            this.checkBoxSelfAll.Size = new System.Drawing.Size(148, 18);
            this.checkBoxSelfAll.TabIndex = 13;
            this.checkBoxSelfAll.Text = "Or: Save to the same file";
            this.checkBoxSelfAll.UseVisualStyleBackColor = true;
            this.checkBoxSelfAll.CheckedChanged += new System.EventHandler(this.checkBoxSelfAll_CheckedChanged);
            // 
            // buttonBrowseDir
            // 
            this.buttonBrowseDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowseDir.Location = new System.Drawing.Point(361, 176);
            this.buttonBrowseDir.Name = "buttonBrowseDir";
            this.buttonBrowseDir.Size = new System.Drawing.Size(80, 23);
            this.buttonBrowseDir.TabIndex = 12;
            this.buttonBrowseDir.Text = "Browse...";
            this.buttonBrowseDir.UseVisualStyleBackColor = true;
            this.buttonBrowseDir.Click += new System.EventHandler(this.buttonBrowseDir_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAdd.Location = new System.Drawing.Point(422, 22);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(102, 28);
            this.buttonAdd.TabIndex = 15;
            this.buttonAdd.Text = "Add...";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelSignature
            // 
            this.labelSignature.AutoEllipsis = true;
            this.labelSignature.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSignature.Location = new System.Drawing.Point(105, 138);
            this.labelSignature.Name = "labelSignature";
            this.labelSignature.Size = new System.Drawing.Size(245, 16);
            this.labelSignature.TabIndex = 20;
            this.labelSignature.Text = "N/A";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDelete.Location = new System.Drawing.Point(422, 53);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(102, 28);
            this.buttonDelete.TabIndex = 16;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelPublics
            // 
            this.labelPublics.AutoEllipsis = true;
            this.labelPublics.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPublics.Location = new System.Drawing.Point(105, 76);
            this.labelPublics.Name = "labelPublics";
            this.labelPublics.Size = new System.Drawing.Size(245, 16);
            this.labelPublics.TabIndex = 19;
            this.labelPublics.Text = "N/A";
            // 
            // labelGlobals
            // 
            this.labelGlobals.AutoEllipsis = true;
            this.labelGlobals.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGlobals.Location = new System.Drawing.Point(105, 58);
            this.labelGlobals.Name = "labelGlobals";
            this.labelGlobals.Size = new System.Drawing.Size(245, 16);
            this.labelGlobals.TabIndex = 18;
            this.labelGlobals.Text = "N/A";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(207, 17);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(301, 20);
            this.progressBar.TabIndex = 25;
            // 
            // labelCodeSize
            // 
            this.labelCodeSize.AutoEllipsis = true;
            this.labelCodeSize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodeSize.Location = new System.Drawing.Point(105, 40);
            this.labelCodeSize.Name = "labelCodeSize";
            this.labelCodeSize.Size = new System.Drawing.Size(245, 16);
            this.labelCodeSize.TabIndex = 16;
            this.labelCodeSize.Text = "N/A";
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClear.Location = new System.Drawing.Point(422, 84);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 28);
            this.buttonClear.TabIndex = 17;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoEllipsis = true;
            this.labelStatus.Location = new System.Drawing.Point(7, 21);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(194, 13);
            this.labelStatus.TabIndex = 24;
            this.labelStatus.Text = "Click Process to begin!";
            // 
            // textBoxDir
            // 
            this.textBoxDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDir.Location = new System.Drawing.Point(61, 177);
            this.textBoxDir.Name = "textBoxDir";
            this.textBoxDir.Size = new System.Drawing.Size(295, 21);
            this.textBoxDir.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Save to:";
            // 
            // openFileDialogMulti
            // 
            this.openFileDialogMulti.Filter = "SCO Files (*.sco)|*.sco";
            this.openFileDialogMulti.Multiselect = true;
            this.openFileDialogMulti.Title = "Open SCO Files...";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(9, 22);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox.Size = new System.Drawing.Size(407, 147);
            this.listBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Files:";
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelHeader.BackgroundImage")));
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(558, 60);
            this.panelHeader.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "SCO Files (*.sco)|*.sco";
            this.openFileDialog.Title = "Open SCO File...";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "SCO Files (*.sco)|*.sco";
            this.saveFileDialog.Title = "Save SCO File...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Location = new System.Drawing.Point(6, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 47);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress";
            // 
            // labelSCOType
            // 
            this.labelSCOType.AutoEllipsis = true;
            this.labelSCOType.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSCOType.Location = new System.Drawing.Point(105, 22);
            this.labelSCOType.Name = "labelSCOType";
            this.labelSCOType.Size = new System.Drawing.Size(245, 16);
            this.labelSCOType.TabIndex = 8;
            this.labelSCOType.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.Location = new System.Drawing.Point(6, 138);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Signature:";
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.Location = new System.Drawing.Point(6, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "# of Public Vars:";
            // 
            // label7
            // 
            this.label7.AutoEllipsis = true;
            this.label7.Location = new System.Drawing.Point(6, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "# of Global Vars:";
            // 
            // label4
            // 
            this.label4.AutoEllipsis = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Code Size:";
            // 
            // tabPageMulti
            // 
            this.tabPageMulti.BackColor = System.Drawing.Color.White;
            this.tabPageMulti.Controls.Add(this.groupBox1);
            this.tabPageMulti.Controls.Add(this.buttonClear);
            this.tabPageMulti.Controls.Add(this.buttonDelete);
            this.tabPageMulti.Controls.Add(this.buttonAdd);
            this.tabPageMulti.Controls.Add(this.buttonProcessAll);
            this.tabPageMulti.Controls.Add(this.checkBoxSelfAll);
            this.tabPageMulti.Controls.Add(this.buttonBrowseDir);
            this.tabPageMulti.Controls.Add(this.textBoxDir);
            this.tabPageMulti.Controls.Add(this.label16);
            this.tabPageMulti.Controls.Add(this.listBox);
            this.tabPageMulti.Controls.Add(this.label6);
            this.tabPageMulti.Location = new System.Drawing.Point(4, 22);
            this.tabPageMulti.Name = "tabPageMulti";
            this.tabPageMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMulti.Size = new System.Drawing.Size(530, 278);
            this.tabPageMulti.TabIndex = 1;
            this.tabPageMulti.Text = "Multiple Files";
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Enabled = false;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonClose.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(444, 65);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 23);
            this.buttonClose.TabIndex = 18;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonOpen.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(444, 11);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(80, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open!";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // tabPageSingle
            // 
            this.tabPageSingle.BackColor = System.Drawing.Color.White;
            this.tabPageSingle.Controls.Add(this.buttonClose);
            this.tabPageSingle.Controls.Add(this.groupBox);
            this.tabPageSingle.Controls.Add(this.checkBoxSelf);
            this.tabPageSingle.Controls.Add(this.buttonProcess);
            this.tabPageSingle.Controls.Add(this.buttonBrowseTarget);
            this.tabPageSingle.Controls.Add(this.textBoxTargetSCO);
            this.tabPageSingle.Controls.Add(this.label2);
            this.tabPageSingle.Controls.Add(this.buttonBrowse);
            this.tabPageSingle.Controls.Add(this.textBoxSCO);
            this.tabPageSingle.Controls.Add(this.label1);
            this.tabPageSingle.Controls.Add(this.buttonOpen);
            this.tabPageSingle.Location = new System.Drawing.Point(4, 22);
            this.tabPageSingle.Name = "tabPageSingle";
            this.tabPageSingle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSingle.Size = new System.Drawing.Size(530, 278);
            this.tabPageSingle.TabIndex = 0;
            this.tabPageSingle.Text = "Single File";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.panelEditorType);
            this.groupBox.Controls.Add(this.panelNatType);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.labelAction);
            this.groupBox.Controls.Add(this.label17);
            this.groupBox.Controls.Add(this.labelFlags);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.labelSignature);
            this.groupBox.Controls.Add(this.labelPublics);
            this.groupBox.Controls.Add(this.labelGlobals);
            this.groupBox.Controls.Add(this.labelCodeSize);
            this.groupBox.Controls.Add(this.buttonCode);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.labelSCOType);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(6, 92);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(517, 180);
            this.groupBox.TabIndex = 10;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "SCO Properties";
            // 
            // panelEditorType
            // 
            this.panelEditorType.Controls.Add(this.radioButtonBasic);
            this.panelEditorType.Controls.Add(this.radioButtonAdvanced);
            this.panelEditorType.Location = new System.Drawing.Point(358, 146);
            this.panelEditorType.Name = "panelEditorType";
            this.panelEditorType.Size = new System.Drawing.Size(155, 26);
            this.panelEditorType.TabIndex = 31;
            // 
            // radioButtonBasic
            // 
            this.radioButtonBasic.AutoEllipsis = true;
            this.radioButtonBasic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonBasic.Location = new System.Drawing.Point(89, 5);
            this.radioButtonBasic.Name = "radioButtonBasic";
            this.radioButtonBasic.Size = new System.Drawing.Size(56, 18);
            this.radioButtonBasic.TabIndex = 29;
            this.radioButtonBasic.Text = "Basic";
            this.radioButtonBasic.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdvanced
            // 
            this.radioButtonAdvanced.AutoEllipsis = true;
            this.radioButtonAdvanced.Checked = true;
            this.radioButtonAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonAdvanced.Location = new System.Drawing.Point(3, 5);
            this.radioButtonAdvanced.Name = "radioButtonAdvanced";
            this.radioButtonAdvanced.Size = new System.Drawing.Size(82, 18);
            this.radioButtonAdvanced.TabIndex = 28;
            this.radioButtonAdvanced.TabStop = true;
            this.radioButtonAdvanced.Text = "Advanced";
            this.radioButtonAdvanced.UseVisualStyleBackColor = true;
            this.radioButtonAdvanced.CheckedChanged += new System.EventHandler(this.radioButtonAdvanced_CheckedChanged);
            // 
            // panelNatType
            // 
            this.panelNatType.Controls.Add(this.radioButtonOld);
            this.panelNatType.Controls.Add(this.radioButtonNew);
            this.panelNatType.Location = new System.Drawing.Point(358, 85);
            this.panelNatType.Name = "panelNatType";
            this.panelNatType.Size = new System.Drawing.Size(155, 47);
            this.panelNatType.TabIndex = 30;
            // 
            // radioButtonOld
            // 
            this.radioButtonOld.AutoEllipsis = true;
            this.radioButtonOld.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonOld.Location = new System.Drawing.Point(3, 3);
            this.radioButtonOld.Name = "radioButtonOld";
            this.radioButtonOld.Size = new System.Drawing.Size(143, 18);
            this.radioButtonOld.TabIndex = 27;
            this.radioButtonOld.TabStop = true;
            this.radioButtonOld.Text = "Old (1.0.4.0)";
            this.radioButtonOld.UseVisualStyleBackColor = true;
            // 
            // radioButtonNew
            // 
            this.radioButtonNew.AutoEllipsis = true;
            this.radioButtonNew.Checked = true;
            this.radioButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButtonNew.Location = new System.Drawing.Point(3, 22);
            this.radioButtonNew.Name = "radioButtonNew";
            this.radioButtonNew.Size = new System.Drawing.Size(143, 18);
            this.radioButtonNew.TabIndex = 28;
            this.radioButtonNew.Text = "New (1.0.7.0+)";
            this.radioButtonNew.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoEllipsis = true;
            this.label11.Location = new System.Drawing.Point(359, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 29;
            this.label11.Text = "Editor mode:";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.Location = new System.Drawing.Point(359, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Natives mode:";
            // 
            // labelAction
            // 
            this.labelAction.AutoEllipsis = true;
            this.labelAction.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAction.Location = new System.Drawing.Point(105, 156);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(245, 16);
            this.labelAction.TabIndex = 26;
            this.labelAction.Text = "N/A";
            // 
            // label17
            // 
            this.label17.AutoEllipsis = true;
            this.label17.Location = new System.Drawing.Point(6, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 16);
            this.label17.TabIndex = 25;
            this.label17.Text = "Action to do:";
            // 
            // labelFlags
            // 
            this.labelFlags.AutoEllipsis = true;
            this.labelFlags.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFlags.Location = new System.Drawing.Point(105, 94);
            this.labelFlags.Name = "labelFlags";
            this.labelFlags.Size = new System.Drawing.Size(245, 44);
            this.labelFlags.TabIndex = 22;
            this.labelFlags.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.Location = new System.Drawing.Point(6, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Script Flags:";
            // 
            // buttonCode
            // 
            this.buttonCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCode.Image = ((System.Drawing.Image)(resources.GetObject("buttonCode.Image")));
            this.buttonCode.Location = new System.Drawing.Point(360, 33);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(143, 25);
            this.buttonCode.TabIndex = 13;
            this.buttonCode.Text = "Open Code Editor...";
            this.buttonCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.Location = new System.Drawing.Point(359, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 9;
            this.label12.Text = "Code:";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "SCO Type:";
            // 
            // checkBoxSelf
            // 
            this.checkBoxSelf.AutoSize = true;
            this.checkBoxSelf.Enabled = false;
            this.checkBoxSelf.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxSelf.Location = new System.Drawing.Point(61, 66);
            this.checkBoxSelf.Name = "checkBoxSelf";
            this.checkBoxSelf.Size = new System.Drawing.Size(152, 18);
            this.checkBoxSelf.TabIndex = 9;
            this.checkBoxSelf.Text = "Or: Save to the same file";
            this.checkBoxSelf.UseVisualStyleBackColor = true;
            this.checkBoxSelf.CheckedChanged += new System.EventHandler(this.checkBoxSelf_CheckedChanged);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProcess.Enabled = false;
            this.buttonProcess.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonProcess.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(444, 38);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(80, 23);
            this.buttonProcess.TabIndex = 8;
            this.buttonProcess.Text = "Process!";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonBrowseTarget
            // 
            this.buttonBrowseTarget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowseTarget.Enabled = false;
            this.buttonBrowseTarget.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowseTarget.Location = new System.Drawing.Point(361, 38);
            this.buttonBrowseTarget.Name = "buttonBrowseTarget";
            this.buttonBrowseTarget.Size = new System.Drawing.Size(80, 23);
            this.buttonBrowseTarget.TabIndex = 7;
            this.buttonBrowseTarget.Text = "Browse...";
            this.buttonBrowseTarget.UseVisualStyleBackColor = true;
            this.buttonBrowseTarget.Click += new System.EventHandler(this.buttonBrowseTarget_Click);
            // 
            // textBoxTargetSCO
            // 
            this.textBoxTargetSCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTargetSCO.Enabled = false;
            this.textBoxTargetSCO.Location = new System.Drawing.Point(61, 39);
            this.textBoxTargetSCO.Name = "textBoxTargetSCO";
            this.textBoxTargetSCO.Size = new System.Drawing.Size(295, 21);
            this.textBoxTargetSCO.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Save as:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonBrowse.Location = new System.Drawing.Point(361, 11);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(80, 23);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxSCO
            // 
            this.textBoxSCO.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSCO.Location = new System.Drawing.Point(61, 12);
            this.textBoxSCO.Name = "textBoxSCO";
            this.textBoxSCO.Size = new System.Drawing.Size(295, 21);
            this.textBoxSCO.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SCO File:";
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageSingle);
            this.tabControl.Controls.Add(this.tabPageMulti);
            this.tabControl.Controls.Add(this.tabPageDebug);
            this.tabControl.Location = new System.Drawing.Point(11, 65);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(538, 304);
            this.tabControl.TabIndex = 8;
            // 
            // tabPageDebug
            // 
            this.tabPageDebug.BackColor = System.Drawing.Color.White;
            this.tabPageDebug.Controls.Add(this.label14);
            this.tabPageDebug.Controls.Add(this.pictureBox);
            this.tabPageDebug.Controls.Add(this.buttonDebug);
            this.tabPageDebug.Controls.Add(this.textBoxDebugLog);
            this.tabPageDebug.Controls.Add(this.buttonDebugCompare);
            this.tabPageDebug.Controls.Add(this.checkBoxWriteHashes);
            this.tabPageDebug.Location = new System.Drawing.Point(4, 22);
            this.tabPageDebug.Name = "tabPageDebug";
            this.tabPageDebug.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDebug.Size = new System.Drawing.Size(530, 278);
            this.tabPageDebug.TabIndex = 2;
            this.tabPageDebug.Text = "Debug";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(18, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(203, 35);
            this.label14.TabIndex = 11;
            this.label14.Text = "Congrats! You\'ve found my Debug Panel where I test stuff.";
            // 
            // pictureBox
            // 
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(239, 207);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(255, 71);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            // 
            // buttonDebug
            // 
            this.buttonDebug.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDebug.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDebug.Location = new System.Drawing.Point(6, 175);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(518, 25);
            this.buttonDebug.TabIndex = 9;
            this.buttonDebug.Text = "Execute Debug Function...";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // textBoxDebugLog
            // 
            this.textBoxDebugLog.Location = new System.Drawing.Point(6, 30);
            this.textBoxDebugLog.Multiline = true;
            this.textBoxDebugLog.Name = "textBoxDebugLog";
            this.textBoxDebugLog.ReadOnly = true;
            this.textBoxDebugLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDebugLog.Size = new System.Drawing.Size(518, 108);
            this.textBoxDebugLog.TabIndex = 8;
            // 
            // buttonDebugCompare
            // 
            this.buttonDebugCompare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDebugCompare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonDebugCompare.Location = new System.Drawing.Point(6, 144);
            this.buttonDebugCompare.Name = "buttonDebugCompare";
            this.buttonDebugCompare.Size = new System.Drawing.Size(518, 25);
            this.buttonDebugCompare.TabIndex = 7;
            this.buttonDebugCompare.Text = "Compare OutputHashes1040.log and OutputHashes1070.log and write to Data\\HashesNew" +
    ".dat...";
            this.buttonDebugCompare.UseVisualStyleBackColor = true;
            this.buttonDebugCompare.Click += new System.EventHandler(this.buttonDebugCompare_Click);
            // 
            // checkBoxWriteHashes
            // 
            this.checkBoxWriteHashes.AutoSize = true;
            this.checkBoxWriteHashes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxWriteHashes.Location = new System.Drawing.Point(6, 6);
            this.checkBoxWriteHashes.Name = "checkBoxWriteHashes";
            this.checkBoxWriteHashes.Size = new System.Drawing.Size(96, 18);
            this.checkBoxWriteHashes.TabIndex = 0;
            this.checkBoxWriteHashes.Text = "Write Hashes";
            this.checkBoxWriteHashes.UseVisualStyleBackColor = true;
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCopyright.Enabled = false;
            this.labelCopyright.Location = new System.Drawing.Point(12, 381);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(362, 19);
            this.labelCopyright.TabIndex = 7;
            this.labelCopyright.Text = "© 2011 FlitskikkerSoftware. All rights reserved.";
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAbout.Location = new System.Drawing.Point(383, 375);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(80, 25);
            this.buttonAbout.TabIndex = 6;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // backgroundWorkerAll
            // 
            this.backgroundWorkerAll.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerAll_DoWork);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 409);
            this.Controls.Add(this.buttonQuit);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.buttonAbout);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCO ToolBox";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabPageMulti.ResumeLayout(false);
            this.tabPageMulti.PerformLayout();
            this.tabPageSingle.ResumeLayout(false);
            this.tabPageSingle.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.panelEditorType.ResumeLayout(false);
            this.panelNatType.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPageDebug.ResumeLayout(false);
            this.tabPageDebug.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessAll;
        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.CheckBox checkBoxSelfAll;
        private System.Windows.Forms.Button buttonBrowseDir;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelSignature;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelPublics;
        private System.Windows.Forms.Label labelGlobals;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelCodeSize;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxDir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.OpenFileDialog openFileDialogMulti;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelSCOType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageMulti;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.TabPage tabPageSingle;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxSelf;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Button buttonBrowseTarget;
        private System.Windows.Forms.TextBox textBoxTargetSCO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxSCO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Button buttonAbout;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAll;
        private System.Windows.Forms.Label labelFlags;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAction;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButtonNew;
        private System.Windows.Forms.RadioButton radioButtonOld;
        private System.Windows.Forms.Panel panelEditorType;
        private System.Windows.Forms.RadioButton radioButtonBasic;
        private System.Windows.Forms.RadioButton radioButtonAdvanced;
        private System.Windows.Forms.Panel panelNatType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPageDebug;
        private System.Windows.Forms.CheckBox checkBoxWriteHashes;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.TextBox textBoxDebugLog;
        private System.Windows.Forms.Button buttonDebugCompare;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label14;

    }
}


namespace SSR
{
    partial class Options
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Projects / Solutions");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Log File");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Teal");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Logs", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Environment", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.treeViewOptions = new System.Windows.Forms.TreeView();
            this.panelProjGeneral = new System.Windows.Forms.Panel();
            this.tableLayoutPanelProjGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.labelProjectsFolderLocation = new System.Windows.Forms.Label();
            this.textBoxProjectsFolderPath = new System.Windows.Forms.TextBox();
            this.labelProjectSchemasLocation = new System.Windows.Forms.Label();
            this.textBoxProjectSchemasLocation = new System.Windows.Forms.TextBox();
            this.checkBoxStopSequence = new System.Windows.Forms.CheckBox();
            this.numericUpDownSequenceFailures = new System.Windows.Forms.NumericUpDown();
            this.labelSequenceFailures = new System.Windows.Forms.Label();
            this.labelFlashVersions = new System.Windows.Forms.Label();
            this.textBoxFlashVersions = new System.Windows.Forms.TextBox();
            this.buttonFlashVersionsLocation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panelLogFile = new System.Windows.Forms.Panel();
            this.tableLayoutPanelLogFile = new System.Windows.Forms.TableLayoutPanel();
            this.labelLogFilePath = new System.Windows.Forms.Label();
            this.textBoxLogFileFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelLogFileStatus = new System.Windows.Forms.Label();
            this.checkBoxLogFileStatus = new System.Windows.Forms.CheckBox();
            this.labelLogFileProjectName = new System.Windows.Forms.Label();
            this.textBoxLogFileProjectName = new System.Windows.Forms.TextBox();
            this.textBoxLogFileTesterID = new System.Windows.Forms.TextBox();
            this.labelLogFileTesterID = new System.Windows.Forms.Label();
            this.labelLogFileHeaderFileds = new System.Windows.Forms.Label();
            this.textBoxLogFileHeaderFileds = new System.Windows.Forms.TextBox();
            this.richTextBoxLogFileHeaderFiledsPreview = new System.Windows.Forms.RichTextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.labelLogFileSeparator = new System.Windows.Forms.Label();
            this.textBoxLogFileSeparator = new System.Windows.Forms.TextBox();
            this.panelTeal = new System.Windows.Forms.Panel();
            this.tableLayoutPanelTeal = new System.Windows.Forms.TableLayoutPanel();
            this.labelTealFolderPath = new System.Windows.Forms.Label();
            this.textBoxTealFolder = new System.Windows.Forms.TextBox();
            this.buttonBrowseTeal = new System.Windows.Forms.Button();
            this.labelTealStatus = new System.Windows.Forms.Label();
            this.checkBoxTealStatus = new System.Windows.Forms.CheckBox();
            this.labelTealTesterID = new System.Windows.Forms.Label();
            this.textBoxTealTesterID = new System.Windows.Forms.TextBox();
            this.labelTealLineID = new System.Windows.Forms.Label();
            this.textBoxTealLineID = new System.Windows.Forms.TextBox();
            this.labelTealConnString = new System.Windows.Forms.Label();
            this.labelTealStoredProcedure = new System.Windows.Forms.Label();
            this.textBoxTealConnString = new System.Windows.Forms.TextBox();
            this.textBoxTealStoredProcedure = new System.Windows.Forms.TextBox();
            this.checkBoxiTAC = new System.Windows.Forms.CheckBox();
            this.panelProjGeneral.SuspendLayout();
            this.tableLayoutPanelProjGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequenceFailures)).BeginInit();
            this.panelLogFile.SuspendLayout();
            this.tableLayoutPanelLogFile.SuspendLayout();
            this.panelTeal.SuspendLayout();
            this.tableLayoutPanelTeal.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeViewOptions
            // 
            this.treeViewOptions.Indent = 10;
            this.treeViewOptions.Location = new System.Drawing.Point(12, 12);
            this.treeViewOptions.Name = "treeViewOptions";
            treeNode1.Name = "Nodo0";
            treeNode1.Text = "Projects / Solutions";
            treeNode2.Name = "Nodo0";
            treeNode2.Text = "Log File";
            treeNode3.Name = "Nodo2";
            treeNode3.Text = "Teal";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "Logs";
            treeNode5.Name = "NodoEnvironment";
            treeNode5.Text = "Environment";
            this.treeViewOptions.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeViewOptions.ShowLines = false;
            this.treeViewOptions.Size = new System.Drawing.Size(182, 310);
            this.treeViewOptions.TabIndex = 1;
            this.treeViewOptions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewOptions_AfterSelect);
            // 
            // panelProjGeneral
            // 
            this.panelProjGeneral.Controls.Add(this.tableLayoutPanelProjGeneral);
            this.panelProjGeneral.Location = new System.Drawing.Point(204, 12);
            this.panelProjGeneral.Name = "panelProjGeneral";
            this.panelProjGeneral.Size = new System.Drawing.Size(431, 311);
            this.panelProjGeneral.TabIndex = 9;
            // 
            // tableLayoutPanelProjGeneral
            // 
            this.tableLayoutPanelProjGeneral.ColumnCount = 3;
            this.tableLayoutPanelProjGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelProjGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanelProjGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelProjGeneral.Controls.Add(this.labelProjectsFolderLocation, 0, 0);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.textBoxProjectsFolderPath, 0, 2);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.labelProjectSchemasLocation, 0, 4);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.textBoxProjectSchemasLocation, 0, 6);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.checkBoxStopSequence, 0, 12);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.numericUpDownSequenceFailures, 0, 14);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.labelSequenceFailures, 1, 14);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.labelFlashVersions, 0, 8);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.textBoxFlashVersions, 0, 10);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.buttonFlashVersionsLocation, 2, 10);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.label1, 0, 15);
            this.tableLayoutPanelProjGeneral.Controls.Add(this.comboBox1, 1, 15);
            this.tableLayoutPanelProjGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelProjGeneral.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelProjGeneral.Name = "tableLayoutPanelProjGeneral";
            this.tableLayoutPanelProjGeneral.RowCount = 16;
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelProjGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelProjGeneral.Size = new System.Drawing.Size(431, 311);
            this.tableLayoutPanelProjGeneral.TabIndex = 0;
            // 
            // labelProjectsFolderLocation
            // 
            this.labelProjectsFolderLocation.AutoSize = true;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.labelProjectsFolderLocation, 2);
            this.labelProjectsFolderLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectsFolderLocation.Location = new System.Drawing.Point(3, 0);
            this.labelProjectsFolderLocation.Name = "labelProjectsFolderLocation";
            this.labelProjectsFolderLocation.Size = new System.Drawing.Size(390, 30);
            this.labelProjectsFolderLocation.TabIndex = 0;
            this.labelProjectsFolderLocation.Text = "Project location:";
            this.labelProjectsFolderLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProjectsFolderPath
            // 
            this.textBoxProjectsFolderPath.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.textBoxProjectsFolderPath, 2);
            this.textBoxProjectsFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProjectsFolderPath.Enabled = false;
            this.textBoxProjectsFolderPath.Location = new System.Drawing.Point(3, 38);
            this.textBoxProjectsFolderPath.Name = "textBoxProjectsFolderPath";
            this.textBoxProjectsFolderPath.Size = new System.Drawing.Size(390, 22);
            this.textBoxProjectsFolderPath.TabIndex = 1;
            this.textBoxProjectsFolderPath.Text = "C:\\RTCFlashProgrammer";
            // 
            // labelProjectSchemasLocation
            // 
            this.labelProjectSchemasLocation.AutoSize = true;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.labelProjectSchemasLocation, 2);
            this.labelProjectSchemasLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProjectSchemasLocation.Location = new System.Drawing.Point(3, 70);
            this.labelProjectSchemasLocation.Name = "labelProjectSchemasLocation";
            this.labelProjectSchemasLocation.Size = new System.Drawing.Size(390, 30);
            this.labelProjectSchemasLocation.TabIndex = 3;
            this.labelProjectSchemasLocation.Text = "Project XML schemas:";
            this.labelProjectSchemasLocation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxProjectSchemasLocation
            // 
            this.textBoxProjectSchemasLocation.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.textBoxProjectSchemasLocation, 2);
            this.textBoxProjectSchemasLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxProjectSchemasLocation.Enabled = false;
            this.textBoxProjectSchemasLocation.Location = new System.Drawing.Point(3, 108);
            this.textBoxProjectSchemasLocation.Name = "textBoxProjectSchemasLocation";
            this.textBoxProjectSchemasLocation.Size = new System.Drawing.Size(390, 22);
            this.textBoxProjectSchemasLocation.TabIndex = 3;
            this.textBoxProjectSchemasLocation.Text = "C:\\RTCFlashProgrammer\\XML schemas";
            // 
            // checkBoxStopSequence
            // 
            this.checkBoxStopSequence.AutoSize = true;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.checkBoxStopSequence, 2);
            this.checkBoxStopSequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxStopSequence.Location = new System.Drawing.Point(3, 213);
            this.checkBoxStopSequence.Name = "checkBoxStopSequence";
            this.checkBoxStopSequence.Size = new System.Drawing.Size(390, 24);
            this.checkBoxStopSequence.TabIndex = 5;
            this.checkBoxStopSequence.Text = "Stop sequence after:";
            this.checkBoxStopSequence.UseVisualStyleBackColor = true;
            // 
            // numericUpDownSequenceFailures
            // 
            this.numericUpDownSequenceFailures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownSequenceFailures.Location = new System.Drawing.Point(24, 248);
            this.numericUpDownSequenceFailures.Name = "numericUpDownSequenceFailures";
            this.numericUpDownSequenceFailures.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownSequenceFailures.TabIndex = 6;
            // 
            // labelSequenceFailures
            // 
            this.labelSequenceFailures.AutoSize = true;
            this.labelSequenceFailures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSequenceFailures.Location = new System.Drawing.Point(85, 245);
            this.labelSequenceFailures.Name = "labelSequenceFailures";
            this.labelSequenceFailures.Size = new System.Drawing.Size(308, 30);
            this.labelSequenceFailures.TabIndex = 8;
            this.labelSequenceFailures.Text = "failures";
            this.labelSequenceFailures.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFlashVersions
            // 
            this.labelFlashVersions.AutoSize = true;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.labelFlashVersions, 3);
            this.labelFlashVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFlashVersions.Location = new System.Drawing.Point(3, 140);
            this.labelFlashVersions.Name = "labelFlashVersions";
            this.labelFlashVersions.Size = new System.Drawing.Size(425, 30);
            this.labelFlashVersions.TabIndex = 9;
            this.labelFlashVersions.Text = "Flash versions:";
            this.labelFlashVersions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFlashVersions
            // 
            this.textBoxFlashVersions.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelProjGeneral.SetColumnSpan(this.textBoxFlashVersions, 2);
            this.textBoxFlashVersions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFlashVersions.Enabled = false;
            this.textBoxFlashVersions.Location = new System.Drawing.Point(3, 178);
            this.textBoxFlashVersions.Name = "textBoxFlashVersions";
            this.textBoxFlashVersions.ReadOnly = true;
            this.textBoxFlashVersions.Size = new System.Drawing.Size(390, 22);
            this.textBoxFlashVersions.TabIndex = 10;
            this.textBoxFlashVersions.Text = "C:\\RTCFlashProgrammer\\Flash";
            // 
            // buttonFlashVersionsLocation
            // 
            this.buttonFlashVersionsLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonFlashVersionsLocation.Enabled = false;
            this.buttonFlashVersionsLocation.Image = global::SSR.Properties.Resources.srch_24x24;
            this.buttonFlashVersionsLocation.Location = new System.Drawing.Point(396, 175);
            this.buttonFlashVersionsLocation.Margin = new System.Windows.Forms.Padding(0);
            this.buttonFlashVersionsLocation.Name = "buttonFlashVersionsLocation";
            this.buttonFlashVersionsLocation.Size = new System.Drawing.Size(35, 30);
            this.buttonFlashVersionsLocation.TabIndex = 11;
            this.buttonFlashVersionsLocation.UseVisualStyleBackColor = true;
            this.buttonFlashVersionsLocation.Click += new System.EventHandler(this.buttonFlashVersionsLocation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Device Diagnostic";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 22);
            this.comboBox1.TabIndex = 12;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(436, 331);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(96, 30);
            this.buttonOk.TabIndex = 10;
            this.buttonOk.Text = "&OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(538, 331);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 30);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Canc&el";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelLogFile
            // 
            this.panelLogFile.Controls.Add(this.tableLayoutPanelLogFile);
            this.panelLogFile.Location = new System.Drawing.Point(204, 11);
            this.panelLogFile.Name = "panelLogFile";
            this.panelLogFile.Size = new System.Drawing.Size(431, 310);
            this.panelLogFile.TabIndex = 12;
            this.panelLogFile.Visible = false;
            // 
            // tableLayoutPanelLogFile
            // 
            this.tableLayoutPanelLogFile.ColumnCount = 3;
            this.tableLayoutPanelLogFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelLogFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelLogFile.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFilePath, 0, 0);
            this.tableLayoutPanelLogFile.Controls.Add(this.textBoxLogFileFolder, 1, 0);
            this.tableLayoutPanelLogFile.Controls.Add(this.buttonBrowse, 2, 0);
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFileStatus, 0, 2);
            this.tableLayoutPanelLogFile.Controls.Add(this.checkBoxLogFileStatus, 1, 2);
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFileProjectName, 0, 6);
            this.tableLayoutPanelLogFile.Controls.Add(this.textBoxLogFileProjectName, 1, 6);
            this.tableLayoutPanelLogFile.Controls.Add(this.textBoxLogFileTesterID, 1, 8);
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFileTesterID, 0, 8);
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFileHeaderFileds, 0, 10);
            this.tableLayoutPanelLogFile.Controls.Add(this.textBoxLogFileHeaderFileds, 1, 10);
            this.tableLayoutPanelLogFile.Controls.Add(this.richTextBoxLogFileHeaderFiledsPreview, 0, 12);
            this.tableLayoutPanelLogFile.Controls.Add(this.buttonGo, 2, 10);
            this.tableLayoutPanelLogFile.Controls.Add(this.labelLogFileSeparator, 0, 4);
            this.tableLayoutPanelLogFile.Controls.Add(this.textBoxLogFileSeparator, 1, 4);
            this.tableLayoutPanelLogFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLogFile.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelLogFile.Name = "tableLayoutPanelLogFile";
            this.tableLayoutPanelLogFile.RowCount = 13;
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelLogFile.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelLogFile.Size = new System.Drawing.Size(431, 310);
            this.tableLayoutPanelLogFile.TabIndex = 6;
            // 
            // labelLogFilePath
            // 
            this.labelLogFilePath.AutoSize = true;
            this.labelLogFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFilePath.Location = new System.Drawing.Point(3, 0);
            this.labelLogFilePath.Name = "labelLogFilePath";
            this.labelLogFilePath.Size = new System.Drawing.Size(127, 30);
            this.labelLogFilePath.TabIndex = 0;
            this.labelLogFilePath.Text = "Folder Path:";
            this.labelLogFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogFileFolder
            // 
            this.textBoxLogFileFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogFileFolder.Location = new System.Drawing.Point(136, 3);
            this.textBoxLogFileFolder.Name = "textBoxLogFileFolder";
            this.textBoxLogFileFolder.Size = new System.Drawing.Size(241, 22);
            this.textBoxLogFileFolder.TabIndex = 1;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowse.Image = global::SSR.Properties.Resources.srch_24x24;
            this.buttonBrowse.Location = new System.Drawing.Point(380, 0);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(51, 30);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelLogFileStatus
            // 
            this.labelLogFileStatus.AutoSize = true;
            this.labelLogFileStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFileStatus.Location = new System.Drawing.Point(3, 35);
            this.labelLogFileStatus.Name = "labelLogFileStatus";
            this.labelLogFileStatus.Size = new System.Drawing.Size(127, 30);
            this.labelLogFileStatus.TabIndex = 4;
            this.labelLogFileStatus.Text = "Log File Status:";
            this.labelLogFileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxLogFileStatus
            // 
            this.checkBoxLogFileStatus.AutoSize = true;
            this.checkBoxLogFileStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxLogFileStatus.Location = new System.Drawing.Point(136, 38);
            this.checkBoxLogFileStatus.Name = "checkBoxLogFileStatus";
            this.checkBoxLogFileStatus.Size = new System.Drawing.Size(241, 24);
            this.checkBoxLogFileStatus.TabIndex = 5;
            this.checkBoxLogFileStatus.Text = "Inactive";
            this.checkBoxLogFileStatus.UseVisualStyleBackColor = true;
            this.checkBoxLogFileStatus.CheckedChanged += new System.EventHandler(this.checkBoxLogFileStatus_CheckedChanged);
            // 
            // labelLogFileProjectName
            // 
            this.labelLogFileProjectName.AutoSize = true;
            this.labelLogFileProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFileProjectName.Location = new System.Drawing.Point(3, 105);
            this.labelLogFileProjectName.Name = "labelLogFileProjectName";
            this.labelLogFileProjectName.Size = new System.Drawing.Size(127, 30);
            this.labelLogFileProjectName.TabIndex = 6;
            this.labelLogFileProjectName.Text = "Project Name:";
            this.labelLogFileProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogFileProjectName
            // 
            this.textBoxLogFileProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogFileProjectName.Location = new System.Drawing.Point(136, 108);
            this.textBoxLogFileProjectName.Name = "textBoxLogFileProjectName";
            this.textBoxLogFileProjectName.Size = new System.Drawing.Size(241, 22);
            this.textBoxLogFileProjectName.TabIndex = 7;
            // 
            // textBoxLogFileTesterID
            // 
            this.textBoxLogFileTesterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogFileTesterID.Location = new System.Drawing.Point(136, 143);
            this.textBoxLogFileTesterID.Name = "textBoxLogFileTesterID";
            this.textBoxLogFileTesterID.Size = new System.Drawing.Size(241, 22);
            this.textBoxLogFileTesterID.TabIndex = 8;
            // 
            // labelLogFileTesterID
            // 
            this.labelLogFileTesterID.AutoSize = true;
            this.labelLogFileTesterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFileTesterID.Location = new System.Drawing.Point(3, 140);
            this.labelLogFileTesterID.Name = "labelLogFileTesterID";
            this.labelLogFileTesterID.Size = new System.Drawing.Size(127, 30);
            this.labelLogFileTesterID.TabIndex = 9;
            this.labelLogFileTesterID.Text = "Tester ID:";
            this.labelLogFileTesterID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLogFileHeaderFileds
            // 
            this.labelLogFileHeaderFileds.AutoSize = true;
            this.labelLogFileHeaderFileds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFileHeaderFileds.Location = new System.Drawing.Point(3, 175);
            this.labelLogFileHeaderFileds.Name = "labelLogFileHeaderFileds";
            this.labelLogFileHeaderFileds.Size = new System.Drawing.Size(127, 30);
            this.labelLogFileHeaderFileds.TabIndex = 10;
            this.labelLogFileHeaderFileds.Text = "Header Fields:";
            this.labelLogFileHeaderFileds.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogFileHeaderFileds
            // 
            this.textBoxLogFileHeaderFileds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogFileHeaderFileds.Location = new System.Drawing.Point(136, 178);
            this.textBoxLogFileHeaderFileds.Name = "textBoxLogFileHeaderFileds";
            this.textBoxLogFileHeaderFileds.Size = new System.Drawing.Size(241, 22);
            this.textBoxLogFileHeaderFileds.TabIndex = 11;
            // 
            // richTextBoxLogFileHeaderFiledsPreview
            // 
            this.tableLayoutPanelLogFile.SetColumnSpan(this.richTextBoxLogFileHeaderFiledsPreview, 3);
            this.richTextBoxLogFileHeaderFiledsPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLogFileHeaderFiledsPreview.Font = new System.Drawing.Font("Calibri", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxLogFileHeaderFiledsPreview.Location = new System.Drawing.Point(3, 213);
            this.richTextBoxLogFileHeaderFiledsPreview.Name = "richTextBoxLogFileHeaderFiledsPreview";
            this.richTextBoxLogFileHeaderFiledsPreview.ReadOnly = true;
            this.richTextBoxLogFileHeaderFiledsPreview.Size = new System.Drawing.Size(425, 94);
            this.richTextBoxLogFileHeaderFiledsPreview.TabIndex = 12;
            this.richTextBoxLogFileHeaderFiledsPreview.Text = "";
            // 
            // buttonGo
            // 
            this.buttonGo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonGo.Image = global::SSR.Properties.Resources.down_24x24;
            this.buttonGo.Location = new System.Drawing.Point(380, 175);
            this.buttonGo.Margin = new System.Windows.Forms.Padding(0);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(51, 30);
            this.buttonGo.TabIndex = 13;
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // labelLogFileSeparator
            // 
            this.labelLogFileSeparator.AutoSize = true;
            this.labelLogFileSeparator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLogFileSeparator.Location = new System.Drawing.Point(3, 70);
            this.labelLogFileSeparator.Name = "labelLogFileSeparator";
            this.labelLogFileSeparator.Size = new System.Drawing.Size(127, 30);
            this.labelLogFileSeparator.TabIndex = 14;
            this.labelLogFileSeparator.Text = "Separator:";
            this.labelLogFileSeparator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxLogFileSeparator
            // 
            this.textBoxLogFileSeparator.Location = new System.Drawing.Point(136, 73);
            this.textBoxLogFileSeparator.Name = "textBoxLogFileSeparator";
            this.textBoxLogFileSeparator.Size = new System.Drawing.Size(40, 22);
            this.textBoxLogFileSeparator.TabIndex = 15;
            // 
            // panelTeal
            // 
            this.panelTeal.Controls.Add(this.tableLayoutPanelTeal);
            this.panelTeal.Location = new System.Drawing.Point(202, 11);
            this.panelTeal.Name = "panelTeal";
            this.panelTeal.Size = new System.Drawing.Size(431, 310);
            this.panelTeal.TabIndex = 13;
            // 
            // tableLayoutPanelTeal
            // 
            this.tableLayoutPanelTeal.ColumnCount = 3;
            this.tableLayoutPanelTeal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelTeal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelTeal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealFolderPath, 0, 0);
            this.tableLayoutPanelTeal.Controls.Add(this.textBoxTealFolder, 1, 0);
            this.tableLayoutPanelTeal.Controls.Add(this.buttonBrowseTeal, 2, 0);
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealStatus, 0, 2);
            this.tableLayoutPanelTeal.Controls.Add(this.checkBoxTealStatus, 1, 2);
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealTesterID, 0, 8);
            this.tableLayoutPanelTeal.Controls.Add(this.textBoxTealTesterID, 1, 8);
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealLineID, 0, 10);
            this.tableLayoutPanelTeal.Controls.Add(this.textBoxTealLineID, 1, 10);
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealConnString, 0, 4);
            this.tableLayoutPanelTeal.Controls.Add(this.labelTealStoredProcedure, 0, 6);
            this.tableLayoutPanelTeal.Controls.Add(this.textBoxTealConnString, 1, 4);
            this.tableLayoutPanelTeal.Controls.Add(this.textBoxTealStoredProcedure, 1, 6);
            this.tableLayoutPanelTeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTeal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTeal.Name = "tableLayoutPanelTeal";
            this.tableLayoutPanelTeal.RowCount = 12;
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelTeal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelTeal.Size = new System.Drawing.Size(431, 310);
            this.tableLayoutPanelTeal.TabIndex = 0;
            // 
            // labelTealFolderPath
            // 
            this.labelTealFolderPath.AutoSize = true;
            this.labelTealFolderPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealFolderPath.Location = new System.Drawing.Point(3, 0);
            this.labelTealFolderPath.Name = "labelTealFolderPath";
            this.labelTealFolderPath.Size = new System.Drawing.Size(127, 30);
            this.labelTealFolderPath.TabIndex = 0;
            this.labelTealFolderPath.Text = "Folder Path:";
            this.labelTealFolderPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTealFolder
            // 
            this.textBoxTealFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTealFolder.Location = new System.Drawing.Point(136, 3);
            this.textBoxTealFolder.Name = "textBoxTealFolder";
            this.textBoxTealFolder.Size = new System.Drawing.Size(241, 22);
            this.textBoxTealFolder.TabIndex = 1;
            // 
            // buttonBrowseTeal
            // 
            this.buttonBrowseTeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBrowseTeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseTeal.Image = global::SSR.Properties.Resources.srch_24x24;
            this.buttonBrowseTeal.Location = new System.Drawing.Point(380, 0);
            this.buttonBrowseTeal.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBrowseTeal.Name = "buttonBrowseTeal";
            this.buttonBrowseTeal.Size = new System.Drawing.Size(51, 30);
            this.buttonBrowseTeal.TabIndex = 2;
            this.buttonBrowseTeal.UseVisualStyleBackColor = true;
            this.buttonBrowseTeal.Click += new System.EventHandler(this.buttonBrowseTeal_Click);
            // 
            // labelTealStatus
            // 
            this.labelTealStatus.AutoSize = true;
            this.labelTealStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealStatus.Location = new System.Drawing.Point(3, 35);
            this.labelTealStatus.Name = "labelTealStatus";
            this.labelTealStatus.Size = new System.Drawing.Size(127, 30);
            this.labelTealStatus.TabIndex = 3;
            this.labelTealStatus.Text = "Teal Status:";
            this.labelTealStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxTealStatus
            // 
            this.checkBoxTealStatus.AutoSize = true;
            this.checkBoxTealStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxTealStatus.Location = new System.Drawing.Point(136, 38);
            this.checkBoxTealStatus.Name = "checkBoxTealStatus";
            this.checkBoxTealStatus.Size = new System.Drawing.Size(241, 24);
            this.checkBoxTealStatus.TabIndex = 4;
            this.checkBoxTealStatus.Text = "Inactive";
            this.checkBoxTealStatus.UseVisualStyleBackColor = true;
            this.checkBoxTealStatus.CheckedChanged += new System.EventHandler(this.checkBoxTealStatus_CheckedChanged);
            // 
            // labelTealTesterID
            // 
            this.labelTealTesterID.AutoSize = true;
            this.labelTealTesterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealTesterID.Location = new System.Drawing.Point(3, 140);
            this.labelTealTesterID.Name = "labelTealTesterID";
            this.labelTealTesterID.Size = new System.Drawing.Size(127, 30);
            this.labelTealTesterID.TabIndex = 6;
            this.labelTealTesterID.Text = "Tester ID:";
            this.labelTealTesterID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTealTesterID
            // 
            this.textBoxTealTesterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTealTesterID.Location = new System.Drawing.Point(136, 143);
            this.textBoxTealTesterID.Name = "textBoxTealTesterID";
            this.textBoxTealTesterID.Size = new System.Drawing.Size(241, 22);
            this.textBoxTealTesterID.TabIndex = 8;
            // 
            // labelTealLineID
            // 
            this.labelTealLineID.AutoSize = true;
            this.labelTealLineID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealLineID.Location = new System.Drawing.Point(3, 175);
            this.labelTealLineID.Name = "labelTealLineID";
            this.labelTealLineID.Size = new System.Drawing.Size(127, 30);
            this.labelTealLineID.TabIndex = 5;
            this.labelTealLineID.Text = "Line ID:";
            this.labelTealLineID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTealLineID
            // 
            this.textBoxTealLineID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTealLineID.Location = new System.Drawing.Point(136, 178);
            this.textBoxTealLineID.Name = "textBoxTealLineID";
            this.textBoxTealLineID.Size = new System.Drawing.Size(241, 22);
            this.textBoxTealLineID.TabIndex = 7;
            // 
            // labelTealConnString
            // 
            this.labelTealConnString.AutoSize = true;
            this.labelTealConnString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealConnString.Location = new System.Drawing.Point(3, 70);
            this.labelTealConnString.Name = "labelTealConnString";
            this.labelTealConnString.Size = new System.Drawing.Size(127, 30);
            this.labelTealConnString.TabIndex = 9;
            this.labelTealConnString.Text = "Connection String:";
            this.labelTealConnString.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTealStoredProcedure
            // 
            this.labelTealStoredProcedure.AutoSize = true;
            this.labelTealStoredProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTealStoredProcedure.Location = new System.Drawing.Point(3, 105);
            this.labelTealStoredProcedure.Name = "labelTealStoredProcedure";
            this.labelTealStoredProcedure.Size = new System.Drawing.Size(127, 30);
            this.labelTealStoredProcedure.TabIndex = 10;
            this.labelTealStoredProcedure.Text = "Stored Procedure:";
            this.labelTealStoredProcedure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxTealConnString
            // 
            this.textBoxTealConnString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTealConnString.Location = new System.Drawing.Point(136, 73);
            this.textBoxTealConnString.Name = "textBoxTealConnString";
            this.textBoxTealConnString.Size = new System.Drawing.Size(241, 22);
            this.textBoxTealConnString.TabIndex = 11;
            // 
            // textBoxTealStoredProcedure
            // 
            this.textBoxTealStoredProcedure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTealStoredProcedure.Location = new System.Drawing.Point(136, 108);
            this.textBoxTealStoredProcedure.Name = "textBoxTealStoredProcedure";
            this.textBoxTealStoredProcedure.Size = new System.Drawing.Size(241, 22);
            this.textBoxTealStoredProcedure.TabIndex = 12;
            // 
            // checkBoxiTAC
            // 
            this.checkBoxiTAC.AutoSize = true;
            this.checkBoxiTAC.Location = new System.Drawing.Point(204, 329);
            this.checkBoxiTAC.Name = "checkBoxiTAC";
            this.checkBoxiTAC.Size = new System.Drawing.Size(48, 18);
            this.checkBoxiTAC.TabIndex = 14;
            this.checkBoxiTAC.Text = "iTAC";
            this.checkBoxiTAC.UseVisualStyleBackColor = true;
            this.checkBoxiTAC.CheckedChanged += new System.EventHandler(this.checkBoxiTAC_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 374);
            this.Controls.Add(this.checkBoxiTAC);
            this.Controls.Add(this.panelProjGeneral);
            this.Controls.Add(this.panelTeal);
            this.Controls.Add(this.panelLogFile);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.treeViewOptions);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.panelProjGeneral.ResumeLayout(false);
            this.tableLayoutPanelProjGeneral.ResumeLayout(false);
            this.tableLayoutPanelProjGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSequenceFailures)).EndInit();
            this.panelLogFile.ResumeLayout(false);
            this.tableLayoutPanelLogFile.ResumeLayout(false);
            this.tableLayoutPanelLogFile.PerformLayout();
            this.panelTeal.ResumeLayout(false);
            this.tableLayoutPanelTeal.ResumeLayout(false);
            this.tableLayoutPanelTeal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewOptions;
        private System.Windows.Forms.Panel panelProjGeneral;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelProjGeneral;
        private System.Windows.Forms.Label labelProjectsFolderLocation;
        private System.Windows.Forms.Label labelProjectSchemasLocation;
        internal System.Windows.Forms.CheckBox checkBoxStopSequence;
        internal System.Windows.Forms.NumericUpDown numericUpDownSequenceFailures;
        private System.Windows.Forms.Label labelSequenceFailures;
        internal System.Windows.Forms.Button buttonOk;
        internal System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panelLogFile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLogFile;
        private System.Windows.Forms.Label labelLogFilePath;
        internal System.Windows.Forms.TextBox textBoxLogFileFolder;
        internal System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelLogFileStatus;
        internal System.Windows.Forms.CheckBox checkBoxLogFileStatus;
        private System.Windows.Forms.Label labelLogFileProjectName;
        internal System.Windows.Forms.TextBox textBoxLogFileProjectName;
        internal System.Windows.Forms.TextBox textBoxLogFileTesterID;
        private System.Windows.Forms.Label labelLogFileTesterID;
        private System.Windows.Forms.Label labelLogFileHeaderFileds;
        internal System.Windows.Forms.TextBox textBoxLogFileHeaderFileds;
        internal System.Windows.Forms.RichTextBox richTextBoxLogFileHeaderFiledsPreview;
        internal System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.Label labelLogFileSeparator;
        internal System.Windows.Forms.TextBox textBoxLogFileSeparator;
        private System.Windows.Forms.Panel panelTeal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTeal;
        private System.Windows.Forms.Label labelTealFolderPath;
        internal System.Windows.Forms.TextBox textBoxTealFolder;
        internal System.Windows.Forms.Button buttonBrowseTeal;
        private System.Windows.Forms.Label labelTealStatus;
        internal System.Windows.Forms.CheckBox checkBoxTealStatus;
        private System.Windows.Forms.Label labelTealTesterID;
        internal System.Windows.Forms.TextBox textBoxTealTesterID;
        private System.Windows.Forms.Label labelTealLineID;
        internal System.Windows.Forms.TextBox textBoxTealLineID;
        private System.Windows.Forms.Label labelTealConnString;
        private System.Windows.Forms.Label labelTealStoredProcedure;
        internal System.Windows.Forms.TextBox textBoxTealConnString;
        internal System.Windows.Forms.TextBox textBoxTealStoredProcedure;
        private System.Windows.Forms.Label labelFlashVersions;
        internal System.Windows.Forms.Button buttonFlashVersionsLocation;
        internal System.Windows.Forms.TextBox textBoxFlashVersions;
        internal System.Windows.Forms.TextBox textBoxProjectsFolderPath;
        internal System.Windows.Forms.TextBox textBoxProjectSchemasLocation;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.CheckBox checkBoxiTAC;
    }
}
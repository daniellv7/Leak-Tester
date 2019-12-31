namespace SSR
{
    partial class NestConfiguration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlDUTConfiguration = new System.Windows.Forms.TabControl();
            this.tabPageTests = new System.Windows.Forms.TabPage();
            this.dataGridViewTests = new System.Windows.Forms.DataGridView();
            this.ColTestName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTestType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColSkipTest = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColTestLimit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColLowLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHighLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLimitUnits = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColTestCommand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTestResponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTestParams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTestProcedure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripTests = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveTest = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveTests = new System.Windows.Forms.ToolStripButton();
            this.tabPageVariables = new System.Windows.Forms.TabPage();
            this.dataGridViewVariables = new System.Windows.Forms.DataGridView();
            this.ColVariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVarValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColVariableDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripVariables = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddVariable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveVariable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveVariables = new System.Windows.Forms.ToolStripButton();
            this.tabPageSignals = new System.Windows.Forms.TabPage();
            this.dataGridViewSignals = new System.Windows.Forms.DataGridView();
            this.ColSignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSignalType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColRelayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSignalChannel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSignalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSignalDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSignals = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddSignal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveSignal = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveSignals = new System.Windows.Forms.ToolStripButton();
            this.tabPageInstruments = new System.Windows.Forms.TabPage();
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.toolStripInstruments = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddInstrument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveInstrument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveInstruments = new System.Windows.Forms.ToolStripButton();
            this.ColInstrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrAssembly = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabControlDUTConfiguration.SuspendLayout();
            this.tabPageTests.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).BeginInit();
            this.toolStripTests.SuspendLayout();
            this.tabPageVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).BeginInit();
            this.toolStripVariables.SuspendLayout();
            this.tabPageSignals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignals)).BeginInit();
            this.toolStripSignals.SuspendLayout();
            this.tabPageInstruments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            this.toolStripInstruments.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDUTConfiguration
            // 
            this.tabControlDUTConfiguration.Controls.Add(this.tabPageTests);
            this.tabControlDUTConfiguration.Controls.Add(this.tabPageVariables);
            this.tabControlDUTConfiguration.Controls.Add(this.tabPageSignals);
            this.tabControlDUTConfiguration.Controls.Add(this.tabPageInstruments);
            this.tabControlDUTConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDUTConfiguration.Location = new System.Drawing.Point(0, 0);
            this.tabControlDUTConfiguration.Name = "tabControlDUTConfiguration";
            this.tabControlDUTConfiguration.SelectedIndex = 0;
            this.tabControlDUTConfiguration.Size = new System.Drawing.Size(1243, 212);
            this.tabControlDUTConfiguration.TabIndex = 0;
            // 
            // tabPageTests
            // 
            this.tabPageTests.Controls.Add(this.dataGridViewTests);
            this.tabPageTests.Controls.Add(this.toolStripTests);
            this.tabPageTests.Location = new System.Drawing.Point(4, 23);
            this.tabPageTests.Name = "tabPageTests";
            this.tabPageTests.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTests.Size = new System.Drawing.Size(1235, 185);
            this.tabPageTests.TabIndex = 0;
            this.tabPageTests.Text = "Tests";
            this.tabPageTests.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTests
            // 
            this.dataGridViewTests.AllowDrop = true;
            this.dataGridViewTests.AllowUserToAddRows = false;
            this.dataGridViewTests.AllowUserToDeleteRows = false;
            this.dataGridViewTests.AllowUserToResizeColumns = false;
            this.dataGridViewTests.AllowUserToResizeRows = false;
            this.dataGridViewTests.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTests.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColTestName,
            this.ColTestType,
            this.ColSkipTest,
            this.ColTestLimit,
            this.ColLowLimit,
            this.ColHighLimit,
            this.ColLimitUnits,
            this.ColTestCommand,
            this.ColTestResponse,
            this.ColTestParams,
            this.ColTestProcedure});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTests.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewTests.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewTests.Name = "dataGridViewTests";
            this.dataGridViewTests.RowHeadersVisible = false;
            this.dataGridViewTests.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTests.ShowCellErrors = false;
            this.dataGridViewTests.ShowRowErrors = false;
            this.dataGridViewTests.Size = new System.Drawing.Size(1229, 148);
            this.dataGridViewTests.TabIndex = 3;
            this.dataGridViewTests.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewTests_DragDrop);
            this.dataGridViewTests.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewTests_DragEnter);
            this.dataGridViewTests.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewTests_MouseMove);
            // 
            // ColTestName
            // 
            this.ColTestName.HeaderText = "Name";
            this.ColTestName.Name = "ColTestName";
            this.ColTestName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTestName.Width = 283;
            // 
            // ColTestType
            // 
            this.ColTestType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColTestType.HeaderText = "Type";
            this.ColTestType.Items.AddRange(new object[] {
            "Pre",
            "Test",
            "Post",
            "Delay"});
            this.ColTestType.Name = "ColTestType";
            this.ColTestType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestType.Width = 60;
            // 
            // ColSkipTest
            // 
            this.ColSkipTest.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColSkipTest.FalseValue = "0";
            this.ColSkipTest.HeaderText = "Skip";
            this.ColSkipTest.IndeterminateValue = "0";
            this.ColSkipTest.Name = "ColSkipTest";
            this.ColSkipTest.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSkipTest.TrueValue = "1";
            this.ColSkipTest.Width = 36;
            // 
            // ColTestLimit
            // 
            this.ColTestLimit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColTestLimit.HeaderText = "Limit";
            this.ColTestLimit.Items.AddRange(new object[] {
            "",
            "LT",
            "GT",
            "LE",
            "GE",
            "EQ",
            "GELE",
            "GTLT",
            "NEQ"});
            this.ColTestLimit.Name = "ColTestLimit";
            this.ColTestLimit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestLimit.Width = 60;
            // 
            // ColLowLimit
            // 
            this.ColLowLimit.HeaderText = "Low";
            this.ColLowLimit.Name = "ColLowLimit";
            this.ColLowLimit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLowLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColLowLimit.Width = 80;
            // 
            // ColHighLimit
            // 
            this.ColHighLimit.HeaderText = "High";
            this.ColHighLimit.Name = "ColHighLimit";
            this.ColHighLimit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColHighLimit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColHighLimit.Width = 80;
            // 
            // ColLimitUnits
            // 
            this.ColLimitUnits.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColLimitUnits.HeaderText = "Units";
            this.ColLimitUnits.Items.AddRange(new object[] {
            "",
            "A",
            "mA",
            "V",
            "mV",
            "Ohm",
            "KOhm",
            "MOhm",
            "Hz",
            "KHz",
            "MHz",
            "GHz",
            "°C",
            "%"});
            this.ColLimitUnits.Name = "ColLimitUnits";
            this.ColLimitUnits.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColLimitUnits.Width = 60;
            // 
            // ColTestCommand
            // 
            this.ColTestCommand.HeaderText = "Command";
            this.ColTestCommand.Name = "ColTestCommand";
            this.ColTestCommand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestCommand.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTestCommand.Width = 180;
            // 
            // ColTestResponse
            // 
            this.ColTestResponse.HeaderText = "Response";
            this.ColTestResponse.Name = "ColTestResponse";
            this.ColTestResponse.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestResponse.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTestResponse.Width = 150;
            // 
            // ColTestParams
            // 
            this.ColTestParams.HeaderText = "Params";
            this.ColTestParams.Name = "ColTestParams";
            this.ColTestParams.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestParams.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTestParams.Width = 172;
            // 
            // ColTestProcedure
            // 
            this.ColTestProcedure.HeaderText = "Procedure";
            this.ColTestProcedure.Name = "ColTestProcedure";
            this.ColTestProcedure.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColTestProcedure.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColTestProcedure.Width = 67;
            // 
            // toolStripTests
            // 
            this.toolStripTests.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTests.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripTests.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddTest,
            this.toolStripButtonRemoveTest,
            this.toolStripButtonSaveTests});
            this.toolStripTests.Location = new System.Drawing.Point(3, 3);
            this.toolStripTests.Name = "toolStripTests";
            this.toolStripTests.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripTests.Size = new System.Drawing.Size(1229, 31);
            this.toolStripTests.TabIndex = 2;
            // 
            // toolStripButtonAddTest
            // 
            this.toolStripButtonAddTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddTest.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddTest.Name = "toolStripButtonAddTest";
            this.toolStripButtonAddTest.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddTest.Text = "Add test";
            this.toolStripButtonAddTest.Click += new System.EventHandler(this.toolStripButtonAddTest_Click);
            // 
            // toolStripButtonRemoveTest
            // 
            this.toolStripButtonRemoveTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveTest.Image = global::SSR.Properties.Resources.remov_24x24;
            this.toolStripButtonRemoveTest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveTest.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveTest.Name = "toolStripButtonRemoveTest";
            this.toolStripButtonRemoveTest.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveTest.Text = "Remove test";
            this.toolStripButtonRemoveTest.Click += new System.EventHandler(this.toolStripButtonRemoveTest_Click);
            // 
            // toolStripButtonSaveTests
            // 
            this.toolStripButtonSaveTests.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveTests.Image = global::SSR.Properties.Resources.save_24x24;
            this.toolStripButtonSaveTests.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveTests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveTests.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonSaveTests.Name = "toolStripButtonSaveTests";
            this.toolStripButtonSaveTests.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveTests.Text = "Save tests";
            this.toolStripButtonSaveTests.Click += new System.EventHandler(this.toolStripButtonSaveTests_Click);
            // 
            // tabPageVariables
            // 
            this.tabPageVariables.Controls.Add(this.dataGridViewVariables);
            this.tabPageVariables.Controls.Add(this.toolStripVariables);
            this.tabPageVariables.Location = new System.Drawing.Point(4, 23);
            this.tabPageVariables.Name = "tabPageVariables";
            this.tabPageVariables.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVariables.Size = new System.Drawing.Size(1235, 185);
            this.tabPageVariables.TabIndex = 1;
            this.tabPageVariables.Text = "Variables";
            this.tabPageVariables.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVariables
            // 
            this.dataGridViewVariables.AllowDrop = true;
            this.dataGridViewVariables.AllowUserToAddRows = false;
            this.dataGridViewVariables.AllowUserToDeleteRows = false;
            this.dataGridViewVariables.AllowUserToResizeColumns = false;
            this.dataGridViewVariables.AllowUserToResizeRows = false;
            this.dataGridViewVariables.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVariables.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColVariableName,
            this.ColVarValue,
            this.ColVariableDescription});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewVariables.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVariables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewVariables.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewVariables.MultiSelect = false;
            this.dataGridViewVariables.Name = "dataGridViewVariables";
            this.dataGridViewVariables.RowHeadersVisible = false;
            this.dataGridViewVariables.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVariables.ShowCellErrors = false;
            this.dataGridViewVariables.ShowEditingIcon = false;
            this.dataGridViewVariables.ShowRowErrors = false;
            this.dataGridViewVariables.Size = new System.Drawing.Size(1229, 148);
            this.dataGridViewVariables.TabIndex = 7;
            this.dataGridViewVariables.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewVariables_DragDrop);
            this.dataGridViewVariables.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewVariables_DragEnter);
            this.dataGridViewVariables.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewVariables_MouseMove);
            // 
            // ColVariableName
            // 
            this.ColVariableName.HeaderText = "Name";
            this.ColVariableName.Name = "ColVariableName";
            this.ColVariableName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColVariableName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVariableName.Width = 170;
            // 
            // ColVarValue
            // 
            this.ColVarValue.HeaderText = "Value";
            this.ColVarValue.Name = "ColVarValue";
            this.ColVarValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColVarValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVarValue.Width = 750;
            // 
            // ColVariableDescription
            // 
            this.ColVariableDescription.HeaderText = "Description";
            this.ColVariableDescription.Name = "ColVariableDescription";
            this.ColVariableDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColVariableDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColVariableDescription.Width = 308;
            // 
            // toolStripVariables
            // 
            this.toolStripVariables.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripVariables.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripVariables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddVariable,
            this.toolStripButtonRemoveVariable,
            this.toolStripButtonSaveVariables});
            this.toolStripVariables.Location = new System.Drawing.Point(3, 3);
            this.toolStripVariables.Name = "toolStripVariables";
            this.toolStripVariables.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripVariables.Size = new System.Drawing.Size(1229, 31);
            this.toolStripVariables.TabIndex = 6;
            // 
            // toolStripButtonAddVariable
            // 
            this.toolStripButtonAddVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddVariable.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddVariable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddVariable.Name = "toolStripButtonAddVariable";
            this.toolStripButtonAddVariable.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddVariable.Text = "Add Variable";
            this.toolStripButtonAddVariable.Click += new System.EventHandler(this.toolStripButtonAddVariable_Click);
            // 
            // toolStripButtonRemoveVariable
            // 
            this.toolStripButtonRemoveVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveVariable.Image = global::SSR.Properties.Resources.remov_24x24;
            this.toolStripButtonRemoveVariable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveVariable.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveVariable.Name = "toolStripButtonRemoveVariable";
            this.toolStripButtonRemoveVariable.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveVariable.Text = "Remove Variable";
            this.toolStripButtonRemoveVariable.Click += new System.EventHandler(this.toolStripButtonRemoveVariable_Click);
            // 
            // toolStripButtonSaveVariables
            // 
            this.toolStripButtonSaveVariables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveVariables.Image = global::SSR.Properties.Resources.save_24x24;
            this.toolStripButtonSaveVariables.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveVariables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveVariables.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonSaveVariables.Name = "toolStripButtonSaveVariables";
            this.toolStripButtonSaveVariables.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveVariables.Text = "Save variables";
            this.toolStripButtonSaveVariables.Click += new System.EventHandler(this.toolStripButtonSaveVariables_Click);
            // 
            // tabPageSignals
            // 
            this.tabPageSignals.Controls.Add(this.dataGridViewSignals);
            this.tabPageSignals.Controls.Add(this.toolStripSignals);
            this.tabPageSignals.Location = new System.Drawing.Point(4, 23);
            this.tabPageSignals.Name = "tabPageSignals";
            this.tabPageSignals.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSignals.Size = new System.Drawing.Size(1235, 185);
            this.tabPageSignals.TabIndex = 2;
            this.tabPageSignals.Text = "Signals";
            this.tabPageSignals.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSignals
            // 
            this.dataGridViewSignals.AllowDrop = true;
            this.dataGridViewSignals.AllowUserToAddRows = false;
            this.dataGridViewSignals.AllowUserToDeleteRows = false;
            this.dataGridViewSignals.AllowUserToResizeColumns = false;
            this.dataGridViewSignals.AllowUserToResizeRows = false;
            this.dataGridViewSignals.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSignals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSignals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSignals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSignalName,
            this.ColSignalType,
            this.ColRelayName,
            this.ColSignalChannel,
            this.ColSignalValue,
            this.ColSignalDescription});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSignals.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSignals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSignals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewSignals.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewSignals.MultiSelect = false;
            this.dataGridViewSignals.Name = "dataGridViewSignals";
            this.dataGridViewSignals.RowHeadersVisible = false;
            this.dataGridViewSignals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSignals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSignals.ShowCellErrors = false;
            this.dataGridViewSignals.ShowEditingIcon = false;
            this.dataGridViewSignals.ShowRowErrors = false;
            this.dataGridViewSignals.Size = new System.Drawing.Size(1229, 148);
            this.dataGridViewSignals.TabIndex = 3;
            this.dataGridViewSignals.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewSignals_DragDrop);
            this.dataGridViewSignals.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewSignals_DragEnter);
            this.dataGridViewSignals.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewSignals_MouseMove);
            // 
            // ColSignalName
            // 
            this.ColSignalName.HeaderText = "Name";
            this.ColSignalName.Name = "ColSignalName";
            this.ColSignalName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSignalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSignalName.Width = 150;
            // 
            // ColSignalType
            // 
            this.ColSignalType.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColSignalType.HeaderText = "Type";
            this.ColSignalType.Items.AddRange(new object[] {
            "",
            "Input",
            "Output"});
            this.ColSignalType.Name = "ColSignalType";
            // 
            // ColRelayName
            // 
            this.ColRelayName.HeaderText = "Relay name";
            this.ColRelayName.Name = "ColRelayName";
            this.ColRelayName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColRelayName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSignalChannel
            // 
            this.ColSignalChannel.HeaderText = "Signal channel";
            this.ColSignalChannel.Name = "ColSignalChannel";
            this.ColSignalChannel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSignalChannel.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColSignalValue
            // 
            this.ColSignalValue.HeaderText = "Value";
            this.ColSignalValue.Name = "ColSignalValue";
            this.ColSignalValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSignalValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSignalValue.Width = 178;
            // 
            // ColSignalDescription
            // 
            this.ColSignalDescription.HeaderText = "Description";
            this.ColSignalDescription.Name = "ColSignalDescription";
            this.ColSignalDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSignalDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSignalDescription.Width = 600;
            // 
            // toolStripSignals
            // 
            this.toolStripSignals.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSignals.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSignals.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddSignal,
            this.toolStripButtonRemoveSignal,
            this.toolStripButtonSaveSignals});
            this.toolStripSignals.Location = new System.Drawing.Point(3, 3);
            this.toolStripSignals.Name = "toolStripSignals";
            this.toolStripSignals.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripSignals.Size = new System.Drawing.Size(1229, 31);
            this.toolStripSignals.TabIndex = 2;
            // 
            // toolStripButtonAddSignal
            // 
            this.toolStripButtonAddSignal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddSignal.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddSignal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddSignal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddSignal.Name = "toolStripButtonAddSignal";
            this.toolStripButtonAddSignal.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddSignal.Text = "Add signal";
            this.toolStripButtonAddSignal.Click += new System.EventHandler(this.toolStripButtonAddSignal_Click);
            // 
            // toolStripButtonRemoveSignal
            // 
            this.toolStripButtonRemoveSignal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveSignal.Image = global::SSR.Properties.Resources.remov_24x24;
            this.toolStripButtonRemoveSignal.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveSignal.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveSignal.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveSignal.Name = "toolStripButtonRemoveSignal";
            this.toolStripButtonRemoveSignal.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveSignal.Text = "Remove signal";
            this.toolStripButtonRemoveSignal.Click += new System.EventHandler(this.toolStripButtonRemoveSignal_Click);
            // 
            // toolStripButtonSaveSignals
            // 
            this.toolStripButtonSaveSignals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveSignals.Image = global::SSR.Properties.Resources.save_24x24;
            this.toolStripButtonSaveSignals.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveSignals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveSignals.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonSaveSignals.Name = "toolStripButtonSaveSignals";
            this.toolStripButtonSaveSignals.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveSignals.Text = "Save signals";
            this.toolStripButtonSaveSignals.Click += new System.EventHandler(this.toolStripButtonSaveSignals_Click);
            // 
            // tabPageInstruments
            // 
            this.tabPageInstruments.Controls.Add(this.dataGridViewDevices);
            this.tabPageInstruments.Controls.Add(this.toolStripInstruments);
            this.tabPageInstruments.Location = new System.Drawing.Point(4, 23);
            this.tabPageInstruments.Name = "tabPageInstruments";
            this.tabPageInstruments.Size = new System.Drawing.Size(1235, 185);
            this.tabPageInstruments.TabIndex = 3;
            this.tabPageInstruments.Text = "Instruments";
            this.tabPageInstruments.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDevices
            // 
            this.dataGridViewDevices.AllowUserToAddRows = false;
            this.dataGridViewDevices.AllowUserToDeleteRows = false;
            this.dataGridViewDevices.AllowUserToResizeColumns = false;
            this.dataGridViewDevices.AllowUserToResizeRows = false;
            this.dataGridViewDevices.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColInstrName,
            this.ColInstrPort,
            this.ColInstrAttributes,
            this.ColInstrAssembly});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDevices.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDevices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewDevices.Location = new System.Drawing.Point(0, 31);
            this.dataGridViewDevices.MultiSelect = false;
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.RowHeadersVisible = false;
            this.dataGridViewDevices.RowHeadersWidth = 50;
            this.dataGridViewDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDevices.ShowCellErrors = false;
            this.dataGridViewDevices.ShowEditingIcon = false;
            this.dataGridViewDevices.ShowRowErrors = false;
            this.dataGridViewDevices.Size = new System.Drawing.Size(1235, 154);
            this.dataGridViewDevices.TabIndex = 8;
            this.dataGridViewDevices.DragDrop += new System.Windows.Forms.DragEventHandler(this.dataGridViewDevices_DragDrop);
            this.dataGridViewDevices.DragEnter += new System.Windows.Forms.DragEventHandler(this.dataGridViewDevices_DragEnter);
            this.dataGridViewDevices.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDevices_MouseMove);
            // 
            // toolStripInstruments
            // 
            this.toolStripInstruments.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripInstruments.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripInstruments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddInstrument,
            this.toolStripButtonRemoveInstrument,
            this.toolStripButtonSaveInstruments});
            this.toolStripInstruments.Location = new System.Drawing.Point(0, 0);
            this.toolStripInstruments.Name = "toolStripInstruments";
            this.toolStripInstruments.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripInstruments.Size = new System.Drawing.Size(1235, 31);
            this.toolStripInstruments.TabIndex = 7;
            // 
            // toolStripButtonAddInstrument
            // 
            this.toolStripButtonAddInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddInstrument.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddInstrument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddInstrument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddInstrument.Name = "toolStripButtonAddInstrument";
            this.toolStripButtonAddInstrument.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddInstrument.Text = "Add Instruments";
            this.toolStripButtonAddInstrument.Click += new System.EventHandler(this.toolStripButtonAddInstrument_Click);
            // 
            // toolStripButtonRemoveInstrument
            // 
            this.toolStripButtonRemoveInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveInstrument.Image = global::SSR.Properties.Resources.remov_24x24;
            this.toolStripButtonRemoveInstrument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveInstrument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveInstrument.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveInstrument.Name = "toolStripButtonRemoveInstrument";
            this.toolStripButtonRemoveInstrument.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveInstrument.Text = "Remove Instruments";
            this.toolStripButtonRemoveInstrument.Click += new System.EventHandler(this.toolStripButtonRemoveInstrument_Click);
            // 
            // toolStripButtonSaveInstruments
            // 
            this.toolStripButtonSaveInstruments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveInstruments.Image = global::SSR.Properties.Resources.save_24x24;
            this.toolStripButtonSaveInstruments.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveInstruments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveInstruments.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonSaveInstruments.Name = "toolStripButtonSaveInstruments";
            this.toolStripButtonSaveInstruments.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveInstruments.Text = "Save Instruments";
            this.toolStripButtonSaveInstruments.Click += new System.EventHandler(this.toolStripButtonSaveInstruments_Click);
            // 
            // ColInstrName
            // 
            this.ColInstrName.HeaderText = "Name";
            this.ColInstrName.Name = "ColInstrName";
            this.ColInstrName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColInstrName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColInstrName.Width = 150;
            // 
            // ColInstrPort
            // 
            this.ColInstrPort.HeaderText = "Port";
            this.ColInstrPort.Name = "ColInstrPort";
            this.ColInstrPort.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColInstrPort.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColInstrAttributes
            // 
            this.ColInstrAttributes.HeaderText = "Attributes";
            this.ColInstrAttributes.Name = "ColInstrAttributes";
            this.ColInstrAttributes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColInstrAttributes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColInstrAttributes.Width = 400;
            // 
            // ColInstrAssembly
            // 
            this.ColInstrAssembly.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.ColInstrAssembly.FillWeight = 250F;
            this.ColInstrAssembly.HeaderText = "Assembly";
            this.ColInstrAssembly.Name = "ColInstrAssembly";
            this.ColInstrAssembly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColInstrAssembly.Width = 200;
            // 
            // NestConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1243, 212);
            this.Controls.Add(this.tabControlDUTConfiguration);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(1259, 140);
            this.Name = "NestConfiguration";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nest configuration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DUTConfiguration_FormClosing);
            this.Load += new System.EventHandler(this.DUTConfiguration_Load);
            this.SizeChanged += new System.EventHandler(this.DUTConfiguration_SizeChanged);
            this.Resize += new System.EventHandler(this.DUTConfiguration_Resize);
            this.tabControlDUTConfiguration.ResumeLayout(false);
            this.tabPageTests.ResumeLayout(false);
            this.tabPageTests.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTests)).EndInit();
            this.toolStripTests.ResumeLayout(false);
            this.toolStripTests.PerformLayout();
            this.tabPageVariables.ResumeLayout(false);
            this.tabPageVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVariables)).EndInit();
            this.toolStripVariables.ResumeLayout(false);
            this.toolStripVariables.PerformLayout();
            this.tabPageSignals.ResumeLayout(false);
            this.tabPageSignals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSignals)).EndInit();
            this.toolStripSignals.ResumeLayout(false);
            this.toolStripSignals.PerformLayout();
            this.tabPageInstruments.ResumeLayout(false);
            this.tabPageInstruments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.toolStripInstruments.ResumeLayout(false);
            this.toolStripInstruments.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDUTConfiguration;
        private System.Windows.Forms.TabPage tabPageTests;
        private System.Windows.Forms.TabPage tabPageVariables;
        private System.Windows.Forms.ToolStrip toolStripTests;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddTest;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveTest;
        private System.Windows.Forms.ToolStrip toolStripVariables;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddVariable;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveVariable;
        private System.Windows.Forms.TabPage tabPageSignals;
        private System.Windows.Forms.ToolStrip toolStripSignals;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddSignal;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveSignal;
        public System.Windows.Forms.DataGridView dataGridViewVariables;
        public System.Windows.Forms.DataGridView dataGridViewTests;
        public System.Windows.Forms.DataGridView dataGridViewSignals;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveTests;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveVariables;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveSignals;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTestName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTestType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSkipTest;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTestLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLowLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHighLimit;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColLimitUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTestCommand;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTestResponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTestParams;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTestProcedure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVariableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVarValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColVariableDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSignalName;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColSignalType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColRelayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSignalChannel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSignalValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSignalDescription;
        private System.Windows.Forms.TabPage tabPageInstruments;
        private System.Windows.Forms.ToolStrip toolStripInstruments;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddInstrument;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveInstrument;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveInstruments;
        internal System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrAttributes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColInstrAssembly;
    }
}
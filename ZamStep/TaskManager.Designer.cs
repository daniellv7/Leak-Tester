namespace SSR
{
    partial class TaskManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripVariables = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddVariable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveVariable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditVariable = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReload = new System.Windows.Forms.ToolStripButton();
            this.dgvControlTask = new System.Windows.Forms.DataGridView();
            this.colSignalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSignalDesription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isPresent = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvNiTasks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWarning = new System.Windows.Forms.Label();
            this.toolStripVariables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripVariables
            // 
            this.toolStripVariables.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripVariables.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripVariables.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripVariables.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripVariables.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddVariable,
            this.toolStripButtonRemoveVariable,
            this.toolStripButtonEditVariable,
            this.toolStripButtonReload});
            this.toolStripVariables.Location = new System.Drawing.Point(0, 0);
            this.toolStripVariables.Name = "toolStripVariables";
            this.toolStripVariables.Size = new System.Drawing.Size(598, 31);
            this.toolStripVariables.TabIndex = 1;
            this.toolStripVariables.Text = "toolStrip1";
            // 
            // toolStripButtonAddVariable
            // 
            this.toolStripButtonAddVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddVariable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAddVariable.Image")));
            this.toolStripButtonAddVariable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddVariable.Name = "toolStripButtonAddVariable";
            this.toolStripButtonAddVariable.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddVariable.ToolTipText = "Add task";
            this.toolStripButtonAddVariable.Click += new System.EventHandler(this.toolStripButtonAddVariable_Click);
            // 
            // toolStripButtonRemoveVariable
            // 
            this.toolStripButtonRemoveVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveVariable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRemoveVariable.Image")));
            this.toolStripButtonRemoveVariable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveVariable.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveVariable.Name = "toolStripButtonRemoveVariable";
            this.toolStripButtonRemoveVariable.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveVariable.ToolTipText = "Remove task";
            this.toolStripButtonRemoveVariable.Click += new System.EventHandler(this.toolStripButtonRemoveVariable_Click);
            // 
            // toolStripButtonEditVariable
            // 
            this.toolStripButtonEditVariable.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditVariable.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEditVariable.Image")));
            this.toolStripButtonEditVariable.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditVariable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditVariable.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonEditVariable.Name = "toolStripButtonEditVariable";
            this.toolStripButtonEditVariable.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonEditVariable.ToolTipText = "Edit task";
            this.toolStripButtonEditVariable.Click += new System.EventHandler(this.toolStripButtonEditVariable_Click);
            // 
            // toolStripButtonReload
            // 
            this.toolStripButtonReload.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReload.Image = global::SSR.Properties.Resources.ref_24x24;
            this.toolStripButtonReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReload.Name = "toolStripButtonReload";
            this.toolStripButtonReload.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonReload.Text = "toolStripButton1";
            this.toolStripButtonReload.ToolTipText = "Reload Tasks";
            this.toolStripButtonReload.Click += new System.EventHandler(this.toolStripButtonReload_Click);
            // 
            // dgvControlTask
            // 
            this.dgvControlTask.AllowDrop = true;
            this.dgvControlTask.AllowUserToAddRows = false;
            this.dgvControlTask.AllowUserToDeleteRows = false;
            this.dgvControlTask.AllowUserToOrderColumns = true;
            this.dgvControlTask.AllowUserToResizeColumns = false;
            this.dgvControlTask.AllowUserToResizeRows = false;
            this.dgvControlTask.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvControlTask.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvControlTask.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvControlTask.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvControlTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSignalName,
            this.colSignalDesription,
            this.isPresent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvControlTask.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvControlTask.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvControlTask.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvControlTask.Location = new System.Drawing.Point(87, 31);
            this.dgvControlTask.Margin = new System.Windows.Forms.Padding(0);
            this.dgvControlTask.MultiSelect = false;
            this.dgvControlTask.Name = "dgvControlTask";
            this.dgvControlTask.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvControlTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvControlTask.RowHeadersVisible = false;
            this.dgvControlTask.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvControlTask.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvControlTask.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlTask.ShowCellErrors = false;
            this.dgvControlTask.ShowEditingIcon = false;
            this.dgvControlTask.ShowRowErrors = false;
            this.dgvControlTask.Size = new System.Drawing.Size(511, 413);
            this.dgvControlTask.TabIndex = 2;
            this.dgvControlTask.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvControlTask_DragDrop);
            this.dgvControlTask.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvControlTask_DragEnter);
            this.dgvControlTask.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvControlTask_MouseDoubleClick);
            this.dgvControlTask.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvControlTask_MouseMove);
            // 
            // colSignalName
            // 
            this.colSignalName.HeaderText = "Task Name";
            this.colSignalName.Name = "colSignalName";
            this.colSignalName.ReadOnly = true;
            this.colSignalName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSignalName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSignalName.Width = 170;
            // 
            // colSignalDesription
            // 
            this.colSignalDesription.HeaderText = "Task Description";
            this.colSignalDesription.Name = "colSignalDesription";
            this.colSignalDesription.ReadOnly = true;
            this.colSignalDesription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSignalDesription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSignalDesription.Width = 280;
            // 
            // isPresent
            // 
            this.isPresent.HeaderText = "Status";
            this.isPresent.Name = "isPresent";
            this.isPresent.ReadOnly = true;
            this.isPresent.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isPresent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.isPresent.Width = 60;
            // 
            // dgvNiTasks
            // 
            this.dgvNiTasks.AllowDrop = true;
            this.dgvNiTasks.AllowUserToAddRows = false;
            this.dgvNiTasks.AllowUserToDeleteRows = false;
            this.dgvNiTasks.AllowUserToOrderColumns = true;
            this.dgvNiTasks.AllowUserToResizeColumns = false;
            this.dgvNiTasks.AllowUserToResizeRows = false;
            this.dgvNiTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvNiTasks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvNiTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNiTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNiTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNiTasks.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNiTasks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvNiTasks.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNiTasks.EnableHeadersVisualStyles = false;
            this.dgvNiTasks.GridColor = System.Drawing.Color.White;
            this.dgvNiTasks.Location = new System.Drawing.Point(0, 31);
            this.dgvNiTasks.Margin = new System.Windows.Forms.Padding(0);
            this.dgvNiTasks.MultiSelect = false;
            this.dgvNiTasks.Name = "dgvNiTasks";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Calibri", 9.75F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNiTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNiTasks.RowHeadersVisible = false;
            this.dgvNiTasks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNiTasks.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNiTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNiTasks.ShowCellErrors = false;
            this.dgvNiTasks.ShowEditingIcon = false;
            this.dgvNiTasks.ShowRowErrors = false;
            this.dgvNiTasks.Size = new System.Drawing.Size(87, 413);
            this.dgvNiTasks.TabIndex = 3;
            this.dgvNiTasks.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvNiTasks_MouseDoubleClick);
            this.dgvNiTasks.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dgvNiTasks_MouseMove);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NI Tasks";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.dataGridViewTextBoxColumn1.Width = 84;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Red;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.Location = new System.Drawing.Point(90, 191);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(496, 42);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "Tasks not loaded in NI Max";
            this.lblWarning.Visible = false;
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(598, 444);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.dgvNiTasks);
            this.Controls.Add(this.dgvControlTask);
            this.Controls.Add(this.toolStripVariables);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TaskManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Task Manager";
            this.Activated += new System.EventHandler(this.TaskManager_Activated);
            this.Deactivate += new System.EventHandler(this.TaskManager_Deactivate);
            this.Load += new System.EventHandler(this.SignalsControl_Load);
            this.toolStripVariables.ResumeLayout(false);
            this.toolStripVariables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip toolStripVariables;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddVariable;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveVariable;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditVariable;
        internal System.Windows.Forms.DataGridView dgvControlTask;
        private System.Windows.Forms.ToolStripButton toolStripButtonReload;
        internal System.Windows.Forms.DataGridView dgvNiTasks;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSignalDesription;
        private System.Windows.Forms.DataGridViewImageColumn isPresent;
    }
}
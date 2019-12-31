namespace SSR
{
    partial class Devices
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
            this.dataGridViewDevices = new System.Windows.Forms.DataGridView();
            this.toolStripDevices = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddInstrument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveInstrument = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSaveInstrument = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ColInstrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrAttributes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInstrAssembly = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).BeginInit();
            this.toolStripDevices.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDevices.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDevices.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataGridViewDevices.Location = new System.Drawing.Point(3, 37);
            this.dataGridViewDevices.MultiSelect = false;
            this.dataGridViewDevices.Name = "dataGridViewDevices";
            this.dataGridViewDevices.RowHeadersVisible = false;
            this.dataGridViewDevices.RowHeadersWidth = 50;
            this.dataGridViewDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDevices.ShowCellErrors = false;
            this.dataGridViewDevices.ShowEditingIcon = false;
            this.dataGridViewDevices.ShowRowErrors = false;
            this.dataGridViewDevices.Size = new System.Drawing.Size(806, 459);
            this.dataGridViewDevices.TabIndex = 5;
            // 
            // toolStripDevices
            // 
            this.toolStripDevices.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripDevices.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDevices.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddInstrument,
            this.toolStripButtonRemoveInstrument,
            this.toolStripButtonSaveInstrument});
            this.toolStripDevices.Location = new System.Drawing.Point(0, 0);
            this.toolStripDevices.Name = "toolStripDevices";
            this.toolStripDevices.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripDevices.Size = new System.Drawing.Size(812, 31);
            this.toolStripDevices.TabIndex = 6;
            // 
            // toolStripButtonAddInstrument
            // 
            this.toolStripButtonAddInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddInstrument.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddInstrument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddInstrument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddInstrument.Name = "toolStripButtonAddInstrument";
            this.toolStripButtonAddInstrument.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddInstrument.Text = "Add device";
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
            this.toolStripButtonRemoveInstrument.Text = "Remove device";
            this.toolStripButtonRemoveInstrument.Click += new System.EventHandler(this.toolStripButtonRemoveInstrument_Click);
            // 
            // toolStripButtonSaveInstrument
            // 
            this.toolStripButtonSaveInstrument.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSaveInstrument.Image = global::SSR.Properties.Resources.save_24x24;
            this.toolStripButtonSaveInstrument.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSaveInstrument.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSaveInstrument.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonSaveInstrument.Name = "toolStripButtonSaveInstrument";
            this.toolStripButtonSaveInstrument.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonSaveInstrument.Text = "Save device";
            this.toolStripButtonSaveInstrument.ToolTipText = "Save devices";
            this.toolStripButtonSaveInstrument.Click += new System.EventHandler(this.toolStripButtonSaveInstrument_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDevices, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStripDevices, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 465F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(812, 499);
            this.tableLayoutPanel1.TabIndex = 7;
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
            this.ColInstrAssembly.HeaderText = "Assembly";
            this.ColInstrAssembly.Name = "ColInstrAssembly";
            this.ColInstrAssembly.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColInstrAssembly.Width = 140;
            // 
            // Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 499);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Devices";
            this.ShowIcon = false;
            this.Text = "Devices";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Devices_FormClosing);
            this.Load += new System.EventHandler(this.Devices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDevices)).EndInit();
            this.toolStripDevices.ResumeLayout(false);
            this.toolStripDevices.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripDevices;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddInstrument;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveInstrument;
        private System.Windows.Forms.ToolStripButton toolStripButtonSaveInstrument;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.DataGridView dataGridViewDevices;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInstrAttributes;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColInstrAssembly;
    }
}
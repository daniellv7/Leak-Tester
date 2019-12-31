namespace SSR
{
    partial class ControlTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlTask));
            this.tableLayoutPanelSignals = new System.Windows.Forms.TableLayoutPanel();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblTaskDescription = new System.Windows.Forms.Label();
            this.txtTasklName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.buttonAddTask = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tableLayoutPanelSignals.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelSignals
            // 
            this.tableLayoutPanelSignals.ColumnCount = 2;
            this.tableLayoutPanelSignals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.03743F));
            this.tableLayoutPanelSignals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.96257F));
            this.tableLayoutPanelSignals.Controls.Add(this.lblTaskName, 0, 1);
            this.tableLayoutPanelSignals.Controls.Add(this.lblTaskDescription, 0, 3);
            this.tableLayoutPanelSignals.Controls.Add(this.txtTasklName, 1, 1);
            this.tableLayoutPanelSignals.Controls.Add(this.txtDescription, 1, 3);
            this.tableLayoutPanelSignals.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanelSignals.Name = "tableLayoutPanelSignals";
            this.tableLayoutPanelSignals.RowCount = 11;
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanelSignals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanelSignals.Size = new System.Drawing.Size(379, 74);
            this.tableLayoutPanelSignals.TabIndex = 2;
            this.tableLayoutPanelSignals.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelSignals_Paint);
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskName.Location = new System.Drawing.Point(3, 5);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(141, 30);
            this.lblTaskName.TabIndex = 1;
            this.lblTaskName.Text = "Name:";
            this.lblTaskName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTaskDescription
            // 
            this.lblTaskDescription.AutoSize = true;
            this.lblTaskDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaskDescription.Location = new System.Drawing.Point(3, 40);
            this.lblTaskDescription.Name = "lblTaskDescription";
            this.lblTaskDescription.Size = new System.Drawing.Size(141, 30);
            this.lblTaskDescription.TabIndex = 2;
            this.lblTaskDescription.Text = "Description:";
            this.lblTaskDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTaskDescription.Click += new System.EventHandler(this.lblSignalType_Click);
            // 
            // txtTasklName
            // 
            this.txtTasklName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTasklName.Location = new System.Drawing.Point(150, 8);
            this.txtTasklName.Name = "txtTasklName";
            this.txtTasklName.ReadOnly = true;
            this.txtTasklName.Size = new System.Drawing.Size(226, 20);
            this.txtTasklName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 43);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(226, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // buttonAddTask
            // 
            this.buttonAddTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAddTask.Location = new System.Drawing.Point(82, 88);
            this.buttonAddTask.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.buttonAddTask.Name = "buttonAddTask";
            this.buttonAddTask.Size = new System.Drawing.Size(96, 36);
            this.buttonAddTask.TabIndex = 3;
            this.buttonAddTask.Text = "Edit";
            this.buttonAddTask.UseVisualStyleBackColor = true;
            this.buttonAddTask.Click += new System.EventHandler(this.buttonAddSignal_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(204, 88);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(96, 36);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ControlTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 130);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddTask);
            this.Controls.Add(this.tableLayoutPanelSignals);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Control Task";
            this.Load += new System.EventHandler(this.ControlSignalTask_Load);
            this.tableLayoutPanelSignals.ResumeLayout(false);
            this.tableLayoutPanelSignals.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSignals;
        private System.Windows.Forms.Label lblTaskName;
        internal System.Windows.Forms.TextBox txtTasklName;
        internal System.Windows.Forms.Button buttonAddTask;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label lblTaskDescription;
        private System.Windows.Forms.TextBox txtDescription;
    }
}
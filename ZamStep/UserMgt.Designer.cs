namespace SSR
{
    partial class UserMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMgt));
            this.toolStripUserMgt = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRemoveUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditUserInfo = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanelUserInfoContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelUserInfo = new System.Windows.Forms.TableLayoutPanel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUserInfo = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripUserMgt.SuspendLayout();
            this.tableLayoutPanelUserInfoContainer.SuspendLayout();
            this.tableLayoutPanelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripUserMgt
            // 
            this.toolStripUserMgt.BackColor = System.Drawing.Color.Transparent;
            this.toolStripUserMgt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripUserMgt.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripUserMgt.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAddUser,
            this.toolStripButtonRemoveUser,
            this.toolStripButtonEditUserInfo});
            this.toolStripUserMgt.Location = new System.Drawing.Point(0, 0);
            this.toolStripUserMgt.Name = "toolStripUserMgt";
            this.toolStripUserMgt.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripUserMgt.Size = new System.Drawing.Size(629, 31);
            this.toolStripUserMgt.TabIndex = 5;
            // 
            // toolStripButtonAddUser
            // 
            this.toolStripButtonAddUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAddUser.Image = global::SSR.Properties.Resources.add_24x24;
            this.toolStripButtonAddUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonAddUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAddUser.Name = "toolStripButtonAddUser";
            this.toolStripButtonAddUser.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonAddUser.ToolTipText = "Add user";
            // 
            // toolStripButtonRemoveUser
            // 
            this.toolStripButtonRemoveUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRemoveUser.Image = global::SSR.Properties.Resources.remov_24x24;
            this.toolStripButtonRemoveUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonRemoveUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRemoveUser.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonRemoveUser.Name = "toolStripButtonRemoveUser";
            this.toolStripButtonRemoveUser.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonRemoveUser.ToolTipText = "Remove user";
            // 
            // toolStripButtonEditUserInfo
            // 
            this.toolStripButtonEditUserInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEditUserInfo.Image = global::SSR.Properties.Resources.edit_24x24;
            this.toolStripButtonEditUserInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonEditUserInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEditUserInfo.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonEditUserInfo.Name = "toolStripButtonEditUserInfo";
            this.toolStripButtonEditUserInfo.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonEditUserInfo.ToolTipText = "Edit user";
            // 
            // tableLayoutPanelUserInfoContainer
            // 
            this.tableLayoutPanelUserInfoContainer.ColumnCount = 2;
            this.tableLayoutPanelUserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanelUserInfoContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserInfoContainer.Controls.Add(this.tableLayoutPanelUserInfo, 0, 0);
            this.tableLayoutPanelUserInfoContainer.Controls.Add(this.dataGridViewUserInfo, 1, 0);
            this.tableLayoutPanelUserInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserInfoContainer.Location = new System.Drawing.Point(0, 31);
            this.tableLayoutPanelUserInfoContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUserInfoContainer.Name = "tableLayoutPanelUserInfoContainer";
            this.tableLayoutPanelUserInfoContainer.RowCount = 1;
            this.tableLayoutPanelUserInfoContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelUserInfoContainer.Size = new System.Drawing.Size(629, 331);
            this.tableLayoutPanelUserInfoContainer.TabIndex = 6;
            // 
            // tableLayoutPanelUserInfo
            // 
            this.tableLayoutPanelUserInfo.ColumnCount = 3;
            this.tableLayoutPanelUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.55463F));
            this.tableLayoutPanelUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.44537F));
            this.tableLayoutPanelUserInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelPassword, 0, 3);
            this.tableLayoutPanelUserInfo.Controls.Add(this.labelType, 0, 5);
            this.tableLayoutPanelUserInfo.Controls.Add(this.comboBoxType, 1, 5);
            this.tableLayoutPanelUserInfo.Controls.Add(this.textBoxPassword, 1, 3);
            this.tableLayoutPanelUserInfo.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelUserInfo.Controls.Add(this.buttonAddUser, 1, 7);
            this.tableLayoutPanelUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelUserInfo.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelUserInfo.Name = "tableLayoutPanelUserInfo";
            this.tableLayoutPanelUserInfo.RowCount = 9;
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelUserInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelUserInfo.Size = new System.Drawing.Size(270, 331);
            this.tableLayoutPanelUserInfo.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 30);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPassword.Location = new System.Drawing.Point(3, 40);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 30);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelType.Location = new System.Drawing.Point(3, 75);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(78, 30);
            this.labelType.TabIndex = 2;
            this.labelType.Text = "Type:";
            this.labelType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            this.comboBoxType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Administrator",
            "Operator"});
            this.comboBoxType.Location = new System.Drawing.Point(87, 78);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(140, 22);
            this.comboBoxType.TabIndex = 3;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxPassword.Location = new System.Drawing.Point(87, 43);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(140, 22);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(87, 8);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(140, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddUser.Location = new System.Drawing.Point(155, 125);
            this.buttonAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(75, 30);
            this.buttonAddUser.TabIndex = 4;
            this.buttonAddUser.Text = "Add";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUserInfo
            // 
            this.dataGridViewUserInfo.AllowUserToAddRows = false;
            this.dataGridViewUserInfo.AllowUserToDeleteRows = false;
            this.dataGridViewUserInfo.AllowUserToResizeColumns = false;
            this.dataGridViewUserInfo.AllowUserToResizeRows = false;
            this.dataGridViewUserInfo.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUserInfo.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewUserInfo.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dataGridViewUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUserInfo.ColumnHeadersHeight = 30;
            this.dataGridViewUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colType});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUserInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUserInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewUserInfo.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewUserInfo.Location = new System.Drawing.Point(273, 3);
            this.dataGridViewUserInfo.MultiSelect = false;
            this.dataGridViewUserInfo.Name = "dataGridViewUserInfo";
            this.dataGridViewUserInfo.ReadOnly = true;
            this.dataGridViewUserInfo.RowHeadersVisible = false;
            this.dataGridViewUserInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUserInfo.ShowCellErrors = false;
            this.dataGridViewUserInfo.ShowCellToolTips = false;
            this.dataGridViewUserInfo.ShowEditingIcon = false;
            this.dataGridViewUserInfo.ShowRowErrors = false;
            this.dataGridViewUserInfo.Size = new System.Drawing.Size(353, 325);
            this.dataGridViewUserInfo.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colName.Width = 200;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colType.HeaderText = "User type";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UserMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 362);
            this.Controls.Add(this.tableLayoutPanelUserInfoContainer);
            this.Controls.Add(this.toolStripUserMgt);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserMgt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserMgt";
            this.toolStripUserMgt.ResumeLayout(false);
            this.toolStripUserMgt.PerformLayout();
            this.tableLayoutPanelUserInfoContainer.ResumeLayout(false);
            this.tableLayoutPanelUserInfo.ResumeLayout(false);
            this.tableLayoutPanelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUserInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripUserMgt;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonRemoveUser;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditUserInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserInfoContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelUserInfo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddUser;
        internal System.Windows.Forms.DataGridView dataGridViewUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;

    }
}
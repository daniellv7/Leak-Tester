namespace SSR
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this.tableLayoutPanelDUTSequence = new System.Windows.Forms.TableLayoutPanel();
            this.labelStatusPiece = new System.Windows.Forms.Label();
            this.richTextBoxDUTTrace = new System.Windows.Forms.RichTextBox();
            this.listViewDUTSequence = new System.Windows.Forms.ListView();
            this.labelDUTSequenceStatus = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabeleElapsedTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelElapsed = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSerialNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.stateMachineTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanelDUTSequence.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelDUTSequence
            // 
            this.tableLayoutPanelDUTSequence.AutoScroll = true;
            this.tableLayoutPanelDUTSequence.ColumnCount = 1;
            this.tableLayoutPanelDUTSequence.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDUTSequence.Controls.Add(this.labelStatusPiece, 0, 4);
            this.tableLayoutPanelDUTSequence.Controls.Add(this.richTextBoxDUTTrace, 0, 2);
            this.tableLayoutPanelDUTSequence.Controls.Add(this.listViewDUTSequence, 0, 0);
            this.tableLayoutPanelDUTSequence.Controls.Add(this.labelDUTSequenceStatus, 0, 3);
            this.tableLayoutPanelDUTSequence.Controls.Add(this.statusStrip, 0, 5);
            this.tableLayoutPanelDUTSequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDUTSequence.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelDUTSequence.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelDUTSequence.Name = "tableLayoutPanelDUTSequence";
            this.tableLayoutPanelDUTSequence.RowCount = 6;
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 182F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 91F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanelDUTSequence.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelDUTSequence.Size = new System.Drawing.Size(264, 628);
            this.tableLayoutPanelDUTSequence.TabIndex = 8;
            // 
            // labelStatusPiece
            // 
            this.labelStatusPiece.AutoSize = true;
            this.labelStatusPiece.BackColor = System.Drawing.Color.Yellow;
            this.labelStatusPiece.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStatusPiece.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusPiece.Location = new System.Drawing.Point(3, 507);
            this.labelStatusPiece.Name = "labelStatusPiece";
            this.labelStatusPiece.Size = new System.Drawing.Size(258, 91);
            this.labelStatusPiece.TabIndex = 10;
            this.labelStatusPiece.Text = "ESPERANDO...";
            this.labelStatusPiece.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxDUTTrace
            // 
            this.richTextBoxDUTTrace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDUTTrace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDUTTrace.Location = new System.Drawing.Point(0, 228);
            this.richTextBoxDUTTrace.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.richTextBoxDUTTrace.Name = "richTextBoxDUTTrace";
            this.richTextBoxDUTTrace.ReadOnly = true;
            this.richTextBoxDUTTrace.Size = new System.Drawing.Size(264, 179);
            this.richTextBoxDUTTrace.TabIndex = 6;
            this.richTextBoxDUTTrace.Text = "";
            // 
            // listViewDUTSequence
            // 
            this.listViewDUTSequence.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewDUTSequence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewDUTSequence.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDUTSequence.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewDUTSequence.FullRowSelect = true;
            this.listViewDUTSequence.GridLines = true;
            this.listViewDUTSequence.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewDUTSequence.HideSelection = false;
            this.listViewDUTSequence.Location = new System.Drawing.Point(0, 3);
            this.listViewDUTSequence.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.listViewDUTSequence.MultiSelect = false;
            this.listViewDUTSequence.Name = "listViewDUTSequence";
            this.listViewDUTSequence.Size = new System.Drawing.Size(264, 221);
            this.listViewDUTSequence.TabIndex = 7;
            this.listViewDUTSequence.UseCompatibleStateImageBehavior = false;
            this.listViewDUTSequence.View = System.Windows.Forms.View.Details;
            // 
            // labelDUTSequenceStatus
            // 
            this.labelDUTSequenceStatus.AutoSize = true;
            this.labelDUTSequenceStatus.BackColor = System.Drawing.Color.Orange;
            this.labelDUTSequenceStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDUTSequenceStatus.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDUTSequenceStatus.Location = new System.Drawing.Point(3, 410);
            this.labelDUTSequenceStatus.Name = "labelDUTSequenceStatus";
            this.labelDUTSequenceStatus.Size = new System.Drawing.Size(258, 97);
            this.labelDUTSequenceStatus.TabIndex = 8;
            this.labelDUTSequenceStatus.Text = "DETENIDO";
            this.labelDUTSequenceStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabeleElapsedTime,
            this.toolStripStatusLabelElapsed,
            this.toolStripStatusLabelSerialNumber,
            this.toolStripStatusSerial});
            this.statusStrip.Location = new System.Drawing.Point(0, 606);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(264, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabeleElapsedTime
            // 
            this.toolStripStatusLabeleElapsedTime.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabeleElapsedTime.Name = "toolStripStatusLabeleElapsedTime";
            this.toolStripStatusLabeleElapsedTime.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabeleElapsedTime.Text = "ELAPSED TIME:";
            // 
            // toolStripStatusLabelElapsed
            // 
            this.toolStripStatusLabelElapsed.Name = "toolStripStatusLabelElapsed";
            this.toolStripStatusLabelElapsed.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelSerialNumber
            // 
            this.toolStripStatusLabelSerialNumber.Name = "toolStripStatusLabelSerialNumber";
            this.toolStripStatusLabelSerialNumber.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabelSerialNumber.Text = "Serial Number:";
            // 
            // toolStripStatusSerial
            // 
            this.toolStripStatusSerial.Name = "toolStripStatusSerial";
            this.toolStripStatusSerial.Size = new System.Drawing.Size(0, 17);
            // 
            // stateMachineTimer
            // 
            this.stateMachineTimer.Interval = 250;
            this.stateMachineTimer.Tick += new System.EventHandler(this.stateMachineTimer_Tick);
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(264, 628);
            this.Controls.Add(this.tableLayoutPanelDUTSequence);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Test sequence";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.tableLayoutPanelDUTSequence.ResumeLayout(false);
            this.tableLayoutPanelDUTSequence.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDUTSequence;
        public System.Windows.Forms.Label labelDUTSequenceStatus;
        public System.Windows.Forms.RichTextBox richTextBoxDUTTrace;
        internal System.Windows.Forms.ListView listViewDUTSequence;
        internal System.Windows.Forms.Timer stateMachineTimer;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabeleElapsedTime;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelElapsed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSerialNumber;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusSerial;
        public System.Windows.Forms.Label labelStatusPiece;
    }
}
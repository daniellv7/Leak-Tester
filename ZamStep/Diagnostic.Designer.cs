namespace SSR
{
    partial class Diagnostic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diagnostic));
            this.toolStripDiagnostic = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanelDO = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelDI = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelAI = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBoxAO = new System.Windows.Forms.PictureBox();
            this.pictureBoxAI = new System.Windows.Forms.PictureBox();
            this.pictureBoxDO = new System.Windows.Forms.PictureBox();
            this.pictureBoxDI = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelAO = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelDevice = new System.Windows.Forms.ToolStripLabel();
            this.toolStripDiagnostic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDI)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripDiagnostic
            // 
            this.toolStripDiagnostic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripDiagnostic.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripDiagnostic.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripDiagnostic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripDiagnostic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonStop,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabelStatus,
            this.toolStripSeparator2,
            this.toolStripButtonReset,
            this.toolStripSeparator3,
            this.toolStripLabel2,
            this.toolStripLabelDevice});
            this.toolStripDiagnostic.Location = new System.Drawing.Point(0, 0);
            this.toolStripDiagnostic.Name = "toolStripDiagnostic";
            this.toolStripDiagnostic.Size = new System.Drawing.Size(1047, 31);
            this.toolStripDiagnostic.TabIndex = 6;
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlay.Image")));
            this.toolStripButtonPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonPlay.ToolTipText = "Play Sequence";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonStop.ToolTipText = "Stop Sequence";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStopSequence_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(53, 28);
            this.toolStripLabel1.Text = "Status:";
            // 
            // toolStripLabelStatus
            // 
            this.toolStripLabelStatus.Name = "toolStripLabelStatus";
            this.toolStripLabelStatus.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonReset.Image = global::SSR.Properties.Resources.ref_24x24;
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(24, 28);
            this.toolStripButtonReset.Text = "Reset";
            this.toolStripButtonReset.Click += new System.EventHandler(this.toolStripButtonReset_Click);
            // 
            // flowLayoutPanelDO
            // 
            this.flowLayoutPanelDO.AutoScroll = true;
            this.flowLayoutPanelDO.AutoSize = true;
            this.flowLayoutPanelDO.Location = new System.Drawing.Point(987, 313);
            this.flowLayoutPanelDO.MaximumSize = new System.Drawing.Size(822, 306);
            this.flowLayoutPanelDO.Name = "flowLayoutPanelDO";
            this.flowLayoutPanelDO.Size = new System.Drawing.Size(822, 306);
            this.flowLayoutPanelDO.TabIndex = 7;
            this.flowLayoutPanelDO.Visible = false;
            // 
            // flowLayoutPanelDI
            // 
            this.flowLayoutPanelDI.AutoScroll = true;
            this.flowLayoutPanelDI.AutoSize = true;
            this.flowLayoutPanelDI.Location = new System.Drawing.Point(191, 365);
            this.flowLayoutPanelDI.MaximumSize = new System.Drawing.Size(805, 321);
            this.flowLayoutPanelDI.Name = "flowLayoutPanelDI";
            this.flowLayoutPanelDI.Size = new System.Drawing.Size(805, 321);
            this.flowLayoutPanelDI.TabIndex = 8;
            this.flowLayoutPanelDI.Visible = false;
            // 
            // flowLayoutPanelAI
            // 
            this.flowLayoutPanelAI.AutoScroll = true;
            this.flowLayoutPanelAI.AutoSize = true;
            this.flowLayoutPanelAI.Location = new System.Drawing.Point(1044, 40);
            this.flowLayoutPanelAI.MaximumSize = new System.Drawing.Size(868, 282);
            this.flowLayoutPanelAI.Name = "flowLayoutPanelAI";
            this.flowLayoutPanelAI.Size = new System.Drawing.Size(868, 282);
            this.flowLayoutPanelAI.TabIndex = 9;
            this.flowLayoutPanelAI.Visible = false;
            // 
            // pictureBoxAO
            // 
            this.pictureBoxAO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAO.Image = global::SSR.Properties.Resources.itemsAO;
            this.pictureBoxAO.Location = new System.Drawing.Point(0, 282);
            this.pictureBoxAO.Name = "pictureBoxAO";
            this.pictureBoxAO.Size = new System.Drawing.Size(172, 84);
            this.pictureBoxAO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAO.TabIndex = 15;
            this.pictureBoxAO.TabStop = false;
            this.pictureBoxAO.Click += new System.EventHandler(this.pictureBoxAO_Click);
            this.pictureBoxAO.MouseEnter += new System.EventHandler(this.pictureBoxAO_MouseEnter);
            this.pictureBoxAO.MouseLeave += new System.EventHandler(this.pictureBoxAO_MouseLeave);
            // 
            // pictureBoxAI
            // 
            this.pictureBoxAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAI.Image = global::SSR.Properties.Resources.itemsAI;
            this.pictureBoxAI.Location = new System.Drawing.Point(0, 198);
            this.pictureBoxAI.Name = "pictureBoxAI";
            this.pictureBoxAI.Size = new System.Drawing.Size(172, 84);
            this.pictureBoxAI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAI.TabIndex = 14;
            this.pictureBoxAI.TabStop = false;
            this.pictureBoxAI.Click += new System.EventHandler(this.pictureBoxAI_Click);
            this.pictureBoxAI.MouseEnter += new System.EventHandler(this.pictureBoxAI_MouseEnter);
            this.pictureBoxAI.MouseLeave += new System.EventHandler(this.pictureBoxAI_MouseLeave);
            // 
            // pictureBoxDO
            // 
            this.pictureBoxDO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDO.Image = global::SSR.Properties.Resources.itemsDO;
            this.pictureBoxDO.Location = new System.Drawing.Point(0, 115);
            this.pictureBoxDO.Name = "pictureBoxDO";
            this.pictureBoxDO.Size = new System.Drawing.Size(172, 84);
            this.pictureBoxDO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDO.TabIndex = 13;
            this.pictureBoxDO.TabStop = false;
            this.pictureBoxDO.Click += new System.EventHandler(this.pictureBoxDO_Click);
            this.pictureBoxDO.MouseEnter += new System.EventHandler(this.pictureBoxDO_MouseEnter);
            this.pictureBoxDO.MouseLeave += new System.EventHandler(this.pictureBoxDO_MouseLeave);
            // 
            // pictureBoxDI
            // 
            this.pictureBoxDI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDI.Image = global::SSR.Properties.Resources.itemsDI;
            this.pictureBoxDI.Location = new System.Drawing.Point(0, 31);
            this.pictureBoxDI.Name = "pictureBoxDI";
            this.pictureBoxDI.Size = new System.Drawing.Size(172, 84);
            this.pictureBoxDI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDI.TabIndex = 12;
            this.pictureBoxDI.TabStop = false;
            this.pictureBoxDI.Click += new System.EventHandler(this.pictureBoxDI_Click);
            this.pictureBoxDI.MouseEnter += new System.EventHandler(this.pictureBoxDI_MouseEnter);
            this.pictureBoxDI.MouseLeave += new System.EventHandler(this.pictureBoxDI_MouseLeave);
            // 
            // flowLayoutPanelAO
            // 
            this.flowLayoutPanelAO.AutoScroll = true;
            this.flowLayoutPanelAO.Location = new System.Drawing.Point(178, 45);
            this.flowLayoutPanelAO.MaximumSize = new System.Drawing.Size(827, 277);
            this.flowLayoutPanelAO.Name = "flowLayoutPanelAO";
            this.flowLayoutPanelAO.Size = new System.Drawing.Size(827, 277);
            this.flowLayoutPanelAO.TabIndex = 16;
            this.flowLayoutPanelAO.Visible = false;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(57, 28);
            this.toolStripLabel2.Text = "Device:";
            // 
            // toolStripLabelDevice
            // 
            this.toolStripLabelDevice.Name = "toolStripLabelDevice";
            this.toolStripLabelDevice.Size = new System.Drawing.Size(0, 28);
            // 
            // Diagnostic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 366);
            this.Controls.Add(this.pictureBoxAO);
            this.Controls.Add(this.pictureBoxAI);
            this.Controls.Add(this.pictureBoxDO);
            this.Controls.Add(this.pictureBoxDI);
            this.Controls.Add(this.flowLayoutPanelAI);
            this.Controls.Add(this.flowLayoutPanelDO);
            this.Controls.Add(this.flowLayoutPanelDI);
            this.Controls.Add(this.toolStripDiagnostic);
            this.Controls.Add(this.flowLayoutPanelAO);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Diagnostic";
            this.Text = "Diagnostic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Diagnostic_FormClosed);
            this.Load += new System.EventHandler(this.Diagnostic_Load);
            this.toolStripDiagnostic.ResumeLayout(false);
            this.toolStripDiagnostic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.ToolStrip toolStripDiagnostic;
        internal System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        internal System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDO;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAI;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStatus;
        private System.Windows.Forms.PictureBox pictureBoxDI;
        private System.Windows.Forms.PictureBox pictureBoxDO;
        private System.Windows.Forms.PictureBox pictureBoxAI;
        private System.Windows.Forms.PictureBox pictureBoxAO;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelAO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel toolStripLabelDevice;
    }
}
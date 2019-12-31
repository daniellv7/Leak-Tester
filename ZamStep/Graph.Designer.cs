namespace SSR
{
    partial class Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.textBoxMeas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripGraphic = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStopSequence = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelStatus = new System.Windows.Forms.ToolStripLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStripGraphic.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(0, 34);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(479, 328);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // textBoxMeas
            // 
            this.textBoxMeas.Location = new System.Drawing.Point(377, 368);
            this.textBoxMeas.Name = "textBoxMeas";
            this.textBoxMeas.Size = new System.Drawing.Size(84, 20);
            this.textBoxMeas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Measure:";
            // 
            // toolStripGraphic
            // 
            this.toolStripGraphic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripGraphic.Font = new System.Drawing.Font("Calibri", 12F);
            this.toolStripGraphic.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripGraphic.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripGraphic.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonStopSequence,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.toolStripLabelStatus});
            this.toolStripGraphic.Location = new System.Drawing.Point(0, 0);
            this.toolStripGraphic.Name = "toolStripGraphic";
            this.toolStripGraphic.Size = new System.Drawing.Size(494, 31);
            this.toolStripGraphic.TabIndex = 7;
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
            // toolStripButtonStopSequence
            // 
            this.toolStripButtonStopSequence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStopSequence.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStopSequence.Image")));
            this.toolStripButtonStopSequence.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStopSequence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStopSequence.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonStopSequence.Name = "toolStripButtonStopSequence";
            this.toolStripButtonStopSequence.Size = new System.Drawing.Size(28, 28);
            this.toolStripButtonStopSequence.ToolTipText = "Stop Sequence";
            this.toolStripButtonStopSequence.Click += new System.EventHandler(this.toolStripButtonStopSequence_Click);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(465, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "V";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 419);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStripGraphic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMeas);
            this.Controls.Add(this.cartesianChart1);
            this.Name = "Graph";
            this.Text = "Graph";
            this.toolStripGraphic.ResumeLayout(false);
            this.toolStripGraphic.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TextBox textBoxMeas;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ToolStrip toolStripGraphic;
        internal System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        internal System.Windows.Forms.ToolStripButton toolStripButtonStopSequence;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelStatus;
        private System.Windows.Forms.Label label2;
    }
}
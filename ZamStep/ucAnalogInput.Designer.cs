namespace SSR
{
    partial class ucAnalogInput
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMeas = new System.Windows.Forms.TextBox();
            this.labelPhysicalName = new System.Windows.Forms.Label();
            this.labelVirtualName = new System.Windows.Forms.Label();
            this.labelNameTask = new System.Windows.Forms.Label();
            this.contextMenuStripGraph = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.graphAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerAI = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStripGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "V";
            // 
            // textBoxMeas
            // 
            this.textBoxMeas.Location = new System.Drawing.Point(3, 46);
            this.textBoxMeas.Name = "textBoxMeas";
            this.textBoxMeas.ReadOnly = true;
            this.textBoxMeas.Size = new System.Drawing.Size(81, 20);
            this.textBoxMeas.TabIndex = 11;
            // 
            // labelPhysicalName
            // 
            this.labelPhysicalName.AutoSize = true;
            this.labelPhysicalName.Location = new System.Drawing.Point(7, 69);
            this.labelPhysicalName.Name = "labelPhysicalName";
            this.labelPhysicalName.Size = new System.Drawing.Size(77, 13);
            this.labelPhysicalName.TabIndex = 10;
            this.labelPhysicalName.Text = "Physical Name";
            // 
            // labelVirtualName
            // 
            this.labelVirtualName.AutoSize = true;
            this.labelVirtualName.Location = new System.Drawing.Point(9, 28);
            this.labelVirtualName.Name = "labelVirtualName";
            this.labelVirtualName.Size = new System.Drawing.Size(67, 13);
            this.labelVirtualName.TabIndex = 9;
            this.labelVirtualName.Text = "Virtual Name";
            // 
            // labelNameTask
            // 
            this.labelNameTask.AutoSize = true;
            this.labelNameTask.Location = new System.Drawing.Point(7, 9);
            this.labelNameTask.Name = "labelNameTask";
            this.labelNameTask.Size = new System.Drawing.Size(62, 13);
            this.labelNameTask.TabIndex = 12;
            this.labelNameTask.Text = "Name Task";
            // 
            // contextMenuStripGraph
            // 
            this.contextMenuStripGraph.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphAIToolStripMenuItem});
            this.contextMenuStripGraph.Name = "contextMenuStripGraph";
            this.contextMenuStripGraph.Size = new System.Drawing.Size(121, 26);
            // 
            // graphAIToolStripMenuItem
            // 
            this.graphAIToolStripMenuItem.Name = "graphAIToolStripMenuItem";
            this.graphAIToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.graphAIToolStripMenuItem.Text = "Graph AI";
            this.graphAIToolStripMenuItem.Click += new System.EventHandler(this.graphAIToolStripMenuItem_Click);
            // 
            // timerAI
            // 
            this.timerAI.Interval = 250;
            this.timerAI.Tick += new System.EventHandler(this.timerAI_Tick);
            // 
            // ucAnalogInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ContextMenuStrip = this.contextMenuStripGraph;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMeas);
            this.Controls.Add(this.labelPhysicalName);
            this.Controls.Add(this.labelVirtualName);
            this.Controls.Add(this.labelNameTask);
            this.Name = "ucAnalogInput";
            this.Size = new System.Drawing.Size(114, 88);
            this.Load += new System.EventHandler(this.ucAnalogInput_Load);
            this.contextMenuStripGraph.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMeas;
        private System.Windows.Forms.Label labelPhysicalName;
        public System.Windows.Forms.Label labelVirtualName;
        private System.Windows.Forms.Label labelNameTask;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripGraph;
        private System.Windows.Forms.ToolStripMenuItem graphAIToolStripMenuItem;
        public System.Windows.Forms.Timer timerAI;
    }
}

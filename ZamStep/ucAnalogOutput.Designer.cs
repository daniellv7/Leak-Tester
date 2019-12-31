namespace SSR
{
    partial class ucAnalogOutput
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
            this.labelTaskName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelVirtualName = new System.Windows.Forms.Label();
            this.labelPhysicalName = new System.Windows.Forms.Label();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTaskName
            // 
            this.labelTaskName.AutoSize = true;
            this.labelTaskName.Location = new System.Drawing.Point(14, 2);
            this.labelTaskName.Name = "labelTaskName";
            this.labelTaskName.Size = new System.Drawing.Size(62, 13);
            this.labelTaskName.TabIndex = 8;
            this.labelTaskName.Text = "Task Name";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelVirtualName);
            this.panel1.Controls.Add(this.labelPhysicalName);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(1, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 94);
            this.panel1.TabIndex = 7;
            // 
            // labelVirtualName
            // 
            this.labelVirtualName.AutoSize = true;
            this.labelVirtualName.Location = new System.Drawing.Point(3, 5);
            this.labelVirtualName.Name = "labelVirtualName";
            this.labelVirtualName.Size = new System.Drawing.Size(64, 13);
            this.labelVirtualName.TabIndex = 6;
            this.labelVirtualName.Text = "VirtualName";
            // 
            // labelPhysicalName
            // 
            this.labelPhysicalName.AutoSize = true;
            this.labelPhysicalName.Location = new System.Drawing.Point(17, 76);
            this.labelPhysicalName.Name = "labelPhysicalName";
            this.labelPhysicalName.Size = new System.Drawing.Size(77, 13);
            this.labelPhysicalName.TabIndex = 5;
            this.labelPhysicalName.Text = "Physical Name";
            // 
            // buttonStop
            // 
            this.buttonStop.BackColor = System.Drawing.Color.Red;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.Location = new System.Drawing.Point(73, 48);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(64, 25);
            this.buttonStop.TabIndex = 2;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(102, 5);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Voltage:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Location = new System.Drawing.Point(10, 48);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(64, 25);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Set";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ucAnalogOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelTaskName);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "ucAnalogOutput";
            this.Size = new System.Drawing.Size(155, 117);
            this.Load += new System.EventHandler(this.ucAnalogOutput_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTaskName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelVirtualName;
        private System.Windows.Forms.Label labelPhysicalName;
        private System.Windows.Forms.Button buttonStop;
        public System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonStart;
    }
}

namespace SSR
{
    partial class ucDigitalInput
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
            this.labelNameTask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPhysicalName = new System.Windows.Forms.Label();
            this.labelVirtualName = new System.Windows.Forms.Label();
            this.timerReader = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameTask
            // 
            this.labelNameTask.AutoSize = true;
            this.labelNameTask.Location = new System.Drawing.Point(5, 6);
            this.labelNameTask.Name = "labelNameTask";
            this.labelNameTask.Size = new System.Drawing.Size(62, 13);
            this.labelNameTask.TabIndex = 9;
            this.labelNameTask.Text = "Name Task";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelPhysicalName);
            this.panel1.Controls.Add(this.labelVirtualName);
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 71);
            this.panel1.TabIndex = 8;
            // 
            // labelPhysicalName
            // 
            this.labelPhysicalName.AutoSize = true;
            this.labelPhysicalName.Location = new System.Drawing.Point(1, 53);
            this.labelPhysicalName.Name = "labelPhysicalName";
            this.labelPhysicalName.Size = new System.Drawing.Size(77, 13);
            this.labelPhysicalName.TabIndex = 6;
            this.labelPhysicalName.Text = "Physical Name";
            // 
            // labelVirtualName
            // 
            this.labelVirtualName.AutoSize = true;
            this.labelVirtualName.Location = new System.Drawing.Point(9, 1);
            this.labelVirtualName.Name = "labelVirtualName";
            this.labelVirtualName.Size = new System.Drawing.Size(67, 13);
            this.labelVirtualName.TabIndex = 1;
            this.labelVirtualName.Text = "Virtual Name";
            // 
            // timerReader
            // 
            this.timerReader.Interval = 250;
            this.timerReader.Tick += new System.EventHandler(this.timerReader_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SSR.Properties.Resources.led_off;
            this.pictureBox1.Location = new System.Drawing.Point(27, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ucDigitalInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelNameTask);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "ucDigitalInput";
            this.Size = new System.Drawing.Size(109, 101);
            this.Load += new System.EventHandler(this.ucDigitalInput_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPhysicalName;
        public System.Windows.Forms.Label labelVirtualName;
        public System.Windows.Forms.Timer timerReader;
    }
}

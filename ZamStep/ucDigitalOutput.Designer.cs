namespace SSR
{
    partial class ucDigitalOutput
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
            this.labelNameTask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPhysicalName = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelVirtualName = new System.Windows.Forms.Label();
            this.pictureBoxSwitch = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwitch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNameTask
            // 
            this.labelNameTask.AutoSize = true;
            this.labelNameTask.Location = new System.Drawing.Point(11, 5);
            this.labelNameTask.Name = "labelNameTask";
            this.labelNameTask.Size = new System.Drawing.Size(62, 13);
            this.labelNameTask.TabIndex = 7;
            this.labelNameTask.Text = "Name Task";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelPhysicalName);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.pictureBoxSwitch);
            this.panel1.Controls.Add(this.labelVirtualName);
            this.panel1.Location = new System.Drawing.Point(3, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 71);
            this.panel1.TabIndex = 6;
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
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Red;
            this.labelStatus.Location = new System.Drawing.Point(57, 24);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(41, 20);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "OFF";
            // 
            // labelVirtualName
            // 
            this.labelVirtualName.AutoSize = true;
            this.labelVirtualName.Location = new System.Drawing.Point(9, 3);
            this.labelVirtualName.Name = "labelVirtualName";
            this.labelVirtualName.Size = new System.Drawing.Size(67, 13);
            this.labelVirtualName.TabIndex = 1;
            this.labelVirtualName.Text = "Virtual Name";
            // 
            // pictureBoxSwitch
            // 
            this.pictureBoxSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSwitch.Image = global::SSR.Properties.Resources.if_button_off_352905;
            this.pictureBoxSwitch.Location = new System.Drawing.Point(13, 19);
            this.pictureBoxSwitch.Name = "pictureBoxSwitch";
            this.pictureBoxSwitch.Size = new System.Drawing.Size(41, 30);
            this.pictureBoxSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSwitch.TabIndex = 4;
            this.pictureBoxSwitch.TabStop = false;
            this.pictureBoxSwitch.Click += new System.EventHandler(this.pictureBoxSwitch_Click);
            // 
            // ucDigitalOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.labelNameTask);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Name = "ucDigitalOutput";
            this.Size = new System.Drawing.Size(109, 96);
            this.Load += new System.EventHandler(this.ucDigitalOutput_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSwitch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNameTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPhysicalName;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.PictureBox pictureBoxSwitch;
        public System.Windows.Forms.Label labelVirtualName;
    }
}

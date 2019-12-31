namespace SSR
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dUT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dUT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosticPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolStripPrincipal = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlay = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelVariant = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBoxVariant = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabelMessage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelResult = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelUserImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelActiveUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTealStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTealStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLogFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLogFileStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripStatusLabelTestedUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel7 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripStatusLabelPassedUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripStatusLabelFailedUnits = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripStatusLabelYield = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.fileSystemWatcher = new System.IO.FileSystemWatcher();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dut3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStripPrincipal.SuspendLayout();
            this.statusStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(40, 20);
            this.fileMenu.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::SSR.Properties.Resources.close_24x24;
            this.exitToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(101, 30);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dUT1ToolStripMenuItem,
            this.dUT2ToolStripMenuItem,
            this.dut3ToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(40, 20);
            this.editMenu.Text = "&Edit";
            // 
            // dUT1ToolStripMenuItem
            // 
            this.dUT1ToolStripMenuItem.Name = "dUT1ToolStripMenuItem";
            this.dUT1ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dUT1ToolStripMenuItem.Text = "Nest 1 Configuration";
            this.dUT1ToolStripMenuItem.Click += new System.EventHandler(this.dUT1ToolStripMenuItem_Click);
            // 
            // dUT2ToolStripMenuItem
            // 
            this.dUT2ToolStripMenuItem.Name = "dUT2ToolStripMenuItem";
            this.dUT2ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dUT2ToolStripMenuItem.Text = "Nest 2 Configuration";
            this.dUT2ToolStripMenuItem.Click += new System.EventHandler(this.dUT2ToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(46, 20);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.toolBarToolStripMenuItem.Text = "&Tools bar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.statusBarToolStripMenuItem.Text = "&Status bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.instrumentsToolStripMenuItem,
            this.diagnosticToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(48, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Image = global::SSR.Properties.Resources.prefs_24x24;
            this.optionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // instrumentsToolStripMenuItem
            // 
            this.instrumentsToolStripMenuItem.Enabled = false;
            this.instrumentsToolStripMenuItem.Image = global::SSR.Properties.Resources.calc_24x24;
            this.instrumentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.instrumentsToolStripMenuItem.Name = "instrumentsToolStripMenuItem";
            this.instrumentsToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.instrumentsToolStripMenuItem.Text = "Instruments";
            this.instrumentsToolStripMenuItem.Click += new System.EventHandler(this.instrumentsToolStripMenuItem_Click);
            // 
            // diagnosticToolStripMenuItem
            // 
            this.diagnosticToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksManagerToolStripMenuItem,
            this.diagnosticPanelToolStripMenuItem});
            this.diagnosticToolStripMenuItem.Image = global::SSR.Properties.Resources.if_params_115702;
            this.diagnosticToolStripMenuItem.Name = "diagnosticToolStripMenuItem";
            this.diagnosticToolStripMenuItem.Size = new System.Drawing.Size(148, 30);
            this.diagnosticToolStripMenuItem.Text = "Diagnostic";
            // 
            // tasksManagerToolStripMenuItem
            // 
            this.tasksManagerToolStripMenuItem.Name = "tasksManagerToolStripMenuItem";
            this.tasksManagerToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.tasksManagerToolStripMenuItem.Text = "Tasks Manager";
            this.tasksManagerToolStripMenuItem.Click += new System.EventHandler(this.tasksManagerToolStripMenuItem_Click);
            // 
            // diagnosticPanelToolStripMenuItem
            // 
            this.diagnosticPanelToolStripMenuItem.Name = "diagnosticPanelToolStripMenuItem";
            this.diagnosticPanelToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.diagnosticPanelToolStripMenuItem.Text = "Diagnostic Panel";
            this.diagnosticPanelToolStripMenuItem.Click += new System.EventHandler(this.diagnosticPanelToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllWindowsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(70, 20);
            this.windowsMenu.Text = "Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &vertically";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &horizontally";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllWindowsToolStripMenuItem
            // 
            this.closeAllWindowsToolStripMenuItem.Name = "closeAllWindowsToolStripMenuItem";
            this.closeAllWindowsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.closeAllWindowsToolStripMenuItem.Text = "Close all windows";
            this.closeAllWindowsToolStripMenuItem.Click += new System.EventHandler(this.closeAllWindowsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(45, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::SSR.Properties.Resources.about_24x24;
            this.aboutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 30);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // toolStripPrincipal
            // 
            this.toolStripPrincipal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripPrincipal.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlay,
            this.toolStripButtonStop,
            this.toolStripLabel1,
            this.toolStripLabelVariant,
            this.toolStripComboBoxVariant,
            this.toolStripLabelMessage,
            this.toolStripLabelResult,
            this.toolStripSeparator1});
            this.toolStripPrincipal.Location = new System.Drawing.Point(0, 24);
            this.toolStripPrincipal.Name = "toolStripPrincipal";
            this.toolStripPrincipal.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStripPrincipal.Size = new System.Drawing.Size(1235, 42);
            this.toolStripPrincipal.TabIndex = 6;
            this.toolStripPrincipal.Text = "toolStripPrincipal";
            // 
            // toolStripButtonPlay
            // 
            this.toolStripButtonPlay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlay.Image = global::SSR.Properties.Resources.play_24x24;
            this.toolStripButtonPlay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonPlay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlay.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonPlay.Name = "toolStripButtonPlay";
            this.toolStripButtonPlay.Size = new System.Drawing.Size(28, 39);
            this.toolStripButtonPlay.Text = "Play";
            this.toolStripButtonPlay.Click += new System.EventHandler(this.toolStripButtonPlay_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = global::SSR.Properties.Resources.splay_24x24;
            this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(28, 39);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 39);
            // 
            // toolStripLabelVariant
            // 
            this.toolStripLabelVariant.Name = "toolStripLabelVariant";
            this.toolStripLabelVariant.Padding = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.toolStripLabelVariant.Size = new System.Drawing.Size(55, 39);
            this.toolStripLabelVariant.Text = "VARIANT:";
            this.toolStripLabelVariant.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBoxVariant
            // 
            this.toolStripComboBoxVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxVariant.Name = "toolStripComboBoxVariant";
            this.toolStripComboBoxVariant.Size = new System.Drawing.Size(121, 42);
            // 
            // toolStripLabelMessage
            // 
            this.toolStripLabelMessage.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelMessage.Name = "toolStripLabelMessage";
            this.toolStripLabelMessage.Size = new System.Drawing.Size(81, 39);
            this.toolStripLabelMessage.Text = "Mensaje:";
            this.toolStripLabelMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripLabelResult
            // 
            this.toolStripLabelResult.BackColor = System.Drawing.Color.MediumTurquoise;
            this.toolStripLabelResult.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabelResult.Name = "toolStripLabelResult";
            this.toolStripLabelResult.Size = new System.Drawing.Size(72, 39);
            this.toolStripLabelResult.Text = "FLM";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelUserImage,
            this.toolStripStatusLabelActiveUser,
            this.toolStripStatusLabelTealStatus,
            this.toolStripStatusLabelTealStatusText,
            this.toolStripStatusLabelLogFileStatus,
            this.toolStripStatusLabelLogFileStatusText,
            this.toolStripLabel5,
            this.toolStripStatusLabelTestedUnits,
            this.toolStripLabel7,
            this.toolStripStatusLabelPassedUnits,
            this.toolStripLabel2,
            this.toolStripStatusLabelFailedUnits,
            this.toolStripLabel4,
            this.toolStripStatusLabelYield,
            this.toolStripLabel3});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 438);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(1235, 33);
            this.statusStripPrincipal.TabIndex = 9;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // toolStripStatusLabelUserImage
            // 
            this.toolStripStatusLabelUserImage.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabelUserImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStatusLabelUserImage.Image = global::SSR.Properties.Resources.user_24x24;
            this.toolStripStatusLabelUserImage.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabelUserImage.Name = "toolStripStatusLabelUserImage";
            this.toolStripStatusLabelUserImage.Size = new System.Drawing.Size(28, 28);
            // 
            // toolStripStatusLabelActiveUser
            // 
            this.toolStripStatusLabelActiveUser.Name = "toolStripStatusLabelActiveUser";
            this.toolStripStatusLabelActiveUser.Size = new System.Drawing.Size(82, 28);
            this.toolStripStatusLabelActiveUser.Text = "Administrator";
            // 
            // toolStripStatusLabelTealStatus
            // 
            this.toolStripStatusLabelTealStatus.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabelTealStatus.Name = "toolStripStatusLabelTealStatus";
            this.toolStripStatusLabelTealStatus.Size = new System.Drawing.Size(69, 28);
            this.toolStripStatusLabelTealStatus.Text = "iTAC status:";
            // 
            // toolStripStatusLabelTealStatusText
            // 
            this.toolStripStatusLabelTealStatusText.Name = "toolStripStatusLabelTealStatusText";
            this.toolStripStatusLabelTealStatusText.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripStatusLabelLogFileStatus
            // 
            this.toolStripStatusLabelLogFileStatus.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
            this.toolStripStatusLabelLogFileStatus.Name = "toolStripStatusLabelLogFileStatus";
            this.toolStripStatusLabelLogFileStatus.Size = new System.Drawing.Size(86, 28);
            this.toolStripStatusLabelLogFileStatus.Text = "LogFile status:";
            // 
            // toolStripStatusLabelLogFileStatusText
            // 
            this.toolStripStatusLabelLogFileStatusText.Name = "toolStripStatusLabelLogFileStatusText";
            this.toolStripStatusLabelLogFileStatusText.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(100, 31);
            this.toolStripLabel5.Text = "PCB Tested Units:";
            // 
            // toolStripStatusLabelTestedUnits
            // 
            this.toolStripStatusLabelTestedUnits.Name = "toolStripStatusLabelTestedUnits";
            this.toolStripStatusLabelTestedUnits.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel7
            // 
            this.toolStripLabel7.Name = "toolStripLabel7";
            this.toolStripLabel7.Size = new System.Drawing.Size(103, 31);
            this.toolStripLabel7.Text = "PCB Passed Units:";
            // 
            // toolStripStatusLabelPassedUnits
            // 
            this.toolStripStatusLabelPassedUnits.Name = "toolStripStatusLabelPassedUnits";
            this.toolStripStatusLabelPassedUnits.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(99, 31);
            this.toolStripLabel2.Text = "PCB Failed Units:";
            // 
            // toolStripStatusLabelFailedUnits
            // 
            this.toolStripStatusLabelFailedUnits.Name = "toolStripStatusLabelFailedUnits";
            this.toolStripStatusLabelFailedUnits.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(60, 31);
            this.toolStripLabel4.Text = "PCB Yield:";
            // 
            // toolStripStatusLabelYield
            // 
            this.toolStripStatusLabelYield.Name = "toolStripStatusLabelYield";
            this.toolStripStatusLabelYield.Size = new System.Drawing.Size(0, 28);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(89, 31);
            this.toolStripLabel3.Text = "Reset Counters";
            this.toolStripLabel3.Click += new System.EventHandler(this.toolStripLabel3_Click_1);
            // 
            // fileSystemWatcher
            // 
            this.fileSystemWatcher.EnableRaisingEvents = true;
            this.fileSystemWatcher.SynchronizingObject = this;
            // 
            // dut3ToolStripMenuItem
            // 
            this.dut3ToolStripMenuItem.Name = "dut3ToolStripMenuItem";
            this.dut3ToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.dut3ToolStripMenuItem.Text = "Nest 3 Configuration";
            this.dut3ToolStripMenuItem.Click += new System.EventHandler(this.dut3ToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 471);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.toolStripPrincipal);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.SizeChanged += new System.EventHandler(this.MDIPrincipal_SizeChanged);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripPrincipal.ResumeLayout(false);
            this.toolStripPrincipal.PerformLayout();
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem dUT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dUT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripPrincipal;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserImage;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelActiveUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTealStatus;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTealStatusText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileStatus;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLogFileStatusText;
        private System.Windows.Forms.ToolStripMenuItem closeAllWindowsToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher;
        public System.Windows.Forms.MenuStrip menuStrip;
        public System.Windows.Forms.ToolStripButton toolStripButtonPlay;
        public System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolStripMenuItem instrumentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabelVariant;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxVariant;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTestedUnits;
        private System.Windows.Forms.ToolStripLabel toolStripLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelPassedUnits;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelFailedUnits;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelYield;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabelMessage;
        private System.Windows.Forms.ToolStripLabel toolStripLabelResult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem diagnosticToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosticPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dut3ToolStripMenuItem;
    }
}




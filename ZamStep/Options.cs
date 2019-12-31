using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
namespace SSR
{
    public partial class Options : Form
    {
        private static Options singleton = null;
        private static readonly object padlock = new object();

        public static Options Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new Options();
                    return singleton;
                }
            }
        }

        private static XMLUtils xmlUtils = new XMLUtils();

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            foreach(string temp in  DaqSystem.Local.Devices)
            {
                comboBox1.Items.Add(temp);
            }
            this.treeViewOptions.ExpandAll();
            if (!xmlUtils.LoadProjectSettings(this))
                this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (!this.SaveProjectSettings())
                return;
            this.Close();
        }
       

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void buttonBrowseProjectsFolder_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textBoxProjectsFolderPath.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void buttonProjectSchemasLocation_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                textBoxProjectSchemasLocation.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void buttonFlashVersionsLocation_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textBoxFlashVersions.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textBoxLogFileFolder.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            if (this.textBoxLogFileHeaderFileds.Text != "")
            {
                this.richTextBoxLogFileHeaderFiledsPreview.Clear();
                string[] data = this.textBoxLogFileHeaderFileds.Text.Split(',');
                foreach (string s in data)
                {
                    this.richTextBoxLogFileHeaderFiledsPreview.AppendText(s + "    ");
                }
            }
        }

        private void buttonBrowseTeal_Click(object sender, EventArgs e)
        {
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog.ShowNewFolderButton = false;
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                this.textBoxTealFolder.Text = this.folderBrowserDialog.SelectedPath;
        }

        private void treeViewOptions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Text)
            {
                case "Log File":
                    {
                        HideOptionsFormPanels();
                        this.panelLogFile.Visible = true;
                        break;
                    }
                case "Teal":
                    {
                        HideOptionsFormPanels();
                        this.panelTeal.Visible = true;
                        break;
                    }
                case "Projects / Solutions":
                    {
                        HideOptionsFormPanels();
                        this.panelProjGeneral.Visible = true;
                        break;
                    }
                default:
                    {
                        HideOptionsFormPanels();
                        this.panelProjGeneral.Visible = true;
                        break;
                    }
            }
        }

        private void HideOptionsFormPanels()
        {
            foreach (Control panel in this.Controls)
            {
                if (panel is Panel)
                    panel.Visible = false;
            }
        }

        private bool SaveProjectSettings()
        {
            if (this.checkBoxTealStatus.Checked && (this.textBoxTealFolder.Text == "" || this.textBoxTealConnString.Text == "" || this.textBoxTealStoredProcedure.Text == "" || this.textBoxTealTesterID.Text == "" || this.textBoxTealLineID.Text == ""))
            {
                MessageBox.Show("It is necessary to fill the proper values when Teal is active", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (this.checkBoxLogFileStatus.Checked && (this.textBoxLogFileFolder.Text == "" || this.textBoxLogFileSeparator.Text == "" || this.textBoxLogFileProjectName.Text == "" || this.textBoxLogFileTesterID.Text == "" || this.textBoxLogFileHeaderFileds.Text == ""))
            {
                MessageBox.Show("It is necessary to fill the proper values when Log is active", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (checkBoxStopSequence.Checked && this.numericUpDownSequenceFailures.Value == 0)
            {
                MessageBox.Show("Failures value must be greater than 0 when Stop sequence is activated", "Sequence failures");
                return false;
            }
            if ((this.textBoxLogFileFolder.Text != "" || this.textBoxLogFileFolder.Text != string.Empty) && !Directory.Exists(this.textBoxLogFileFolder.Text))
            {
                DialogResult result = MessageBox.Show("Folder " + this.textBoxLogFileFolder.Text + " doesn't exist, do you want to create it?", "User action", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        Directory.CreateDirectory(this.textBoxLogFileFolder.Text);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show(ex.Message, "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    this.textBoxLogFileFolder.Text = "";
            }
            if ((this.textBoxTealFolder.Text != "" || this.textBoxTealFolder.Text != string.Empty) && !Directory.Exists(this.textBoxTealFolder.Text))
            {
                DialogResult result = MessageBox.Show("Folder " + this.textBoxTealFolder.Text + " doesn't exist, do you want to create it?", "User action", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    try
                    {
                        Directory.CreateDirectory(this.textBoxTealFolder.Text);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.Message, "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    catch (UnauthorizedAccessException ex)
                    {
                        MessageBox.Show(ex.Message, "System error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    this.textBoxTealFolder.Text = "";
            }
            object[] data = { 
                                    this.textBoxProjectsFolderPath.Text, 
                                    this.textBoxProjectSchemasLocation.Text, 
                                    //this.textBoxFlashVersions.Text,
                                    this.checkBoxStopSequence.Checked, 
                                    this.numericUpDownSequenceFailures.Value, 

                                    this.textBoxLogFileFolder.Text, 
                                    this.checkBoxLogFileStatus.Checked, 
                                    this.textBoxLogFileSeparator.Text,
                                    this.textBoxLogFileProjectName.Text, 
                                    this.textBoxLogFileTesterID.Text, 
                                    this.textBoxLogFileHeaderFileds.Text, 
                                    this.textBoxTealFolder.Text, 
                                    this.checkBoxTealStatus.Checked, 
                                    this.textBoxTealConnString.Text, 
                                    this.textBoxTealStoredProcedure.Text, 
                                    this.textBoxTealTesterID.Text, 
                                    this.textBoxTealLineID.Text ,
                                    this.comboBox1.SelectedItem.ToString(),
                                    this.checkBoxiTAC.Checked
                                };
            if (!xmlUtils.SaveProjectSettings(data))
                return false;
            return true;
        }

        private void checkBoxLogFileStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxLogFileStatus.Checked)
            {
                MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.ForeColor = Color.FromArgb(0, 192, 0);
                MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.Text = "Active";
                this.checkBoxLogFileStatus.Text = "Active";
            }
            else
            {
                MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.ForeColor = Color.Red;
                MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.Text = "Inactive";
                this.checkBoxLogFileStatus.Text = "Inactive";
            }
        }

        private void checkBoxTealStatus_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBoxiTAC_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxiTAC.Checked)
            {
                MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.ForeColor = Color.FromArgb(0, 192, 0);
                MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.Text = "Active";
                this.checkBoxTealStatus.Text = "Active";
            }
            else
            {
                MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.ForeColor = Color.Red;
                MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.Text = "Inactive";
                this.checkBoxTealStatus.Text = "Inactive";
            }
        }
    }
}

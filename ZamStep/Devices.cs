using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SSR
{
    public partial class Devices : Form
    {
        public Devices()
        {
            InitializeComponent();
        }

        private bool instrumentCellContentChanged;
        private XMLUtils xmlUtils = new XMLUtils();
        private string[] deviceAssembly = null;

        private void Devices_Load(object sender, EventArgs e)
        {
            instrumentCellContentChanged = false;
            dataGridViewDevices.Rows.Clear();
            deviceAssembly = Directory.GetFiles((Path.Combine(Directory.GetCurrentDirectory(), @"Assemblies")).ToString(), "*.dll");
            foreach (string assembly in deviceAssembly)
            {
                DirectoryInfo info = new DirectoryInfo(assembly);
                (dataGridViewDevices.Columns[3] as DataGridViewComboBoxColumn).Items.Add(info.Name);
            }
            xmlUtils.LoadInstruments(this);
            this.dataGridViewDevices.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDevices_CellValueChanged);
            this.dataGridViewDevices.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDevices_RowsAdded);
            this.dataGridViewDevices.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewDevices_RowsRemoved);
        }

        private void toolStripButtonSaveInstrument_Click(object sender, EventArgs e)
        {
            //if (instrumentCellContentChanged)
            //{
            //    if (!xmlUtils.SaveInstruments(this))
            //        Close();
            //    instrumentCellContentChanged = false;
            //}
        }

        private void dataGridViewDevices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            instrumentCellContentChanged = true;
        }

        private void dataGridViewDevices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            instrumentCellContentChanged = true;
        }

        private void dataGridViewDevices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            instrumentCellContentChanged = true;
        }

        private void Devices_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (instrumentCellContentChanged)
            {
                if (MessageBox.Show("Changes have been made.\nDo you want to save them?", "User action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    toolStripButtonSaveInstrument_Click(null, null);
                    Dispose(true);
                    this.Close();
                }
                else
                {
                    instrumentCellContentChanged = false;
                    Dispose(true);
                    this.Close();
                }
            }
            else
            {
                instrumentCellContentChanged = false;
                Dispose(true);
                this.Close();
            }
        }

        private void toolStripButtonAddInstrument_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridViewDevices.Rows.Add();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void toolStripButtonRemoveInstrument_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevices.SelectedRows.Count < 1)
                MessageBox.Show("Select first the signal to remove", "User action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    dataGridViewDevices.Rows.Remove(dataGridViewDevices.SelectedRows[0]);
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }
    }
}

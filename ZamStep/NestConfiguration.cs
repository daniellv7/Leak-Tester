using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SSR
{
    public partial class NestConfiguration : Form
    {
        public enum Nest
        {
            NEST1 = 1,
            NEST2,
            NEST3
        };

        private static NestConfiguration singleton = null;
        private static readonly object padlock = new object();

        public static NestConfiguration Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new NestConfiguration();
                    return singleton;
                }
            }
        }

        private Nest nest;
        private bool signalCellContentChanged;
        private bool testCellContentChanged;
        private bool variableCellContentChanged;
        private bool instrumentsContentChanged;
        private bool testsSaved;
        private bool variablesSaved;
        private bool signalsSaved;
        private string[] deviceAssembly = { };
        private XMLUtils xmlUtils = new XMLUtils();

        //Add XMLUtils instance variable for each DUT***************************

        public Nest nestConfig
        {
            set { nest = value; }
        }

        public NestConfiguration()
        {
            InitializeComponent();
        }

        private void DUTConfiguration_Load(object sender, EventArgs e)
        {
            ClearDataGrids();
            Text = nest.ToString() + " Configuration";
            string variant = MDIPrincipal.Singleton.selectedVariant;
            deviceAssembly = Directory.GetFiles((Path.Combine(Directory.GetCurrentDirectory(), @"Assemblies")).ToString(), "*.dll");
            foreach (string assembly in deviceAssembly)
            {
                DirectoryInfo info = new DirectoryInfo(assembly);
                (dataGridViewDevices.Columns[3] as DataGridViewComboBoxColumn).Items.Add(info.Name);
            }
            if (!xmlUtils.LoadDUTSettings(nest.ToString(), variant , this))
            {
                MessageBox.Show(xmlUtils.GetError, "Internal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            dataGridViewTests.CellValueChanged += new DataGridViewCellEventHandler(dataGridViewTests_CellValueChanged);
            dataGridViewTests.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridViewTests_RowsAdded);
            dataGridViewTests.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridViewTests_RowsRemoved);

            dataGridViewVariables.CellValueChanged += new DataGridViewCellEventHandler(dataGridViewVariables_CellValueChanged);
            dataGridViewVariables.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridViewVariables_RowsAdded);
            dataGridViewVariables.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridViewVariables_RowsRemoved);

            dataGridViewSignals.CellValueChanged += new DataGridViewCellEventHandler(dataGridViewSignals_CellValueChanged);
            dataGridViewSignals.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridViewSignals_RowsAdded);
            dataGridViewSignals.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridViewSignals_RowsRemoved);

            dataGridViewDevices.CellValueChanged += new DataGridViewCellEventHandler(dataGridViewDevices_CellValueChanged);
            dataGridViewDevices.RowsAdded += new DataGridViewRowsAddedEventHandler(dataGridViewDevices_RowsAdded);
            dataGridViewDevices.RowsRemoved += new DataGridViewRowsRemovedEventHandler(dataGridViewDevices_RowsRemoved);
        }

        private void toolStripButtonAddTest_Click(object sender, EventArgs e)
        {
            dataGridViewTests.Rows.Add();
        }

        private void toolStripButtonRemoveTest_Click(object sender, EventArgs e)
        {
            if (dataGridViewTests.SelectedRows.Count < 1)
                MessageBox.Show("Select first the test to remove", "User action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dataGridViewTests.Rows.Remove(dataGridViewTests.SelectedRows[0]);
        }

        private void dataGridViewTests_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewTests.Rows.Count >= 1)
                    dataGridViewTests.DoDragDrop(dataGridViewTests.CurrentRow, DragDropEffects.Move);
            }
        }

        private void dataGridViewTests_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridViewTests.PointToClient(Cursor.Position);
            int rowIndexToDrop = dataGridViewTests.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexToDrop != -1)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridViewTests.Rows.RemoveAt(rowToMove.Index);
                dataGridViewTests.Rows.Insert(rowIndexToDrop, rowToMove);
                foreach (DataGridViewRow r in dataGridViewTests.Rows)
                    r.Selected = false;
                dataGridViewTests.Rows[rowIndexToDrop].Selected = true;
            }
        }

        private void dataGridViewTests_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void toolStripButtonAddVariable_Click(object sender, EventArgs e)
        {
            dataGridViewVariables.Rows.Add();
        }

        private void toolStripButtonRemoveVariable_Click(object sender, EventArgs e)
        {
            if (dataGridViewVariables.SelectedRows.Count < 1)
                MessageBox.Show("Select first the variable to remove", "User action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dataGridViewVariables.Rows.Remove(dataGridViewVariables.SelectedRows[0]);
        }

        private void toolStripButtonAddSignal_Click(object sender, EventArgs e)
        {
            dataGridViewSignals.Rows.Add();
        }

        private void toolStripButtonRemoveSignal_Click(object sender, EventArgs e)
        {
            if (dataGridViewSignals.SelectedRows.Count < 1)
                MessageBox.Show("Select first the signal to remove", "User action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dataGridViewSignals.Rows.Remove(dataGridViewSignals.SelectedRows[0]);
        }

        private void dataGridViewVariables_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewVariables.Rows.Count > 1)
                    dataGridViewVariables.DoDragDrop(dataGridViewVariables.CurrentRow, DragDropEffects.Move);
            }
        }

        private void dataGridViewVariables_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridViewVariables.PointToClient(Cursor.Position);
            int rowIndexToDrop = dataGridViewVariables.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexToDrop != -1)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridViewVariables.Rows.RemoveAt(rowToMove.Index);
                dataGridViewVariables.Rows.Insert(rowIndexToDrop, rowToMove);
                dataGridViewVariables.Rows[rowIndexToDrop].Selected = true;
            }
        }

        private void dataGridViewVariables_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void dataGridViewSignals_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewSignals.Rows.Count > 1)
                    dataGridViewSignals.DoDragDrop(dataGridViewSignals.CurrentRow, DragDropEffects.Move);
            }
        }

        private void dataGridViewSignals_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridViewSignals.PointToClient(Cursor.Position);
            int rowIndexToDrop = dataGridViewSignals.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexToDrop != -1)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridViewSignals.Rows.RemoveAt(rowToMove.Index);
                dataGridViewSignals.Rows.Insert(rowIndexToDrop, rowToMove);
                dataGridViewSignals.Rows[rowIndexToDrop].Selected = true;
            }
        }

        private void dataGridViewSignals_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void ClearDataGrids()
        {
            try
            {
                dataGridViewSignals.Rows.Clear();
                dataGridViewTests.Rows.Clear();
                dataGridViewVariables.Rows.Clear();
                dataGridViewDevices.Rows.Clear();
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

        private void dataGridViewTests_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            testCellContentChanged = true;  
        }

        private void dataGridViewTests_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            testCellContentChanged = true;
        }

        private void dataGridViewTests_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            testCellContentChanged = true;
        }

        private void dataGridViewVariables_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            variableCellContentChanged = true;
        }

        private void dataGridViewVariables_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            variableCellContentChanged = true;
        }

        private void dataGridViewVariables_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            variableCellContentChanged = true;
        }

        private void dataGridViewSignals_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            signalCellContentChanged = true;
        }

        private void dataGridViewSignals_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            signalCellContentChanged = true;
        }

        private void dataGridViewSignals_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            signalCellContentChanged = true;
        }
        private void dataGridViewDevices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            instrumentsContentChanged = true;
        }

        private void dataGridViewDevices_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            instrumentsContentChanged = true;
        }

        private void dataGridViewDevices_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            instrumentsContentChanged = true;
        }

        private void DUTConfiguration_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (testCellContentChanged || signalCellContentChanged || variableCellContentChanged || instrumentsContentChanged)
            {
                if (MessageBox.Show("Changes have been made.\nDo you want to save them?", "User action", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveNestSettings();
                    Dispose(true);
                    Close();
                }
                else
                {
                    Dispose(true);
                    Close();
                }
            }
            else
            {
                Dispose(true);
                Close();
            }
            MDIPrincipal.Singleton.PaintNests();
        }

        private void toolStripButtonSaveTests_Click(object sender, EventArgs e)
        {
            SaveNestSettings();
            MessageBox.Show("Tests saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonSaveVariables_Click(object sender, EventArgs e)
        {
            SaveNestSettings();
            MessageBox.Show("Variables saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonSaveSignals_Click(object sender, EventArgs e)
        {
            SaveNestSettings();
            MessageBox.Show("Signals saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void SaveNestSettings()
        {
            if (variableCellContentChanged)
            {
                if (!xmlUtils.SaveDUTVariables(nest.ToString(), this))
                    Close();
                variableCellContentChanged = false;
            }
            
            if (signalCellContentChanged)
            {
                if (!xmlUtils.SaveDUTSignals(nest.ToString(), this))
                    Close();
                signalCellContentChanged = false;
            }
            
            if (testCellContentChanged)
            {
                if (!xmlUtils.SaveDUTTests(nest.ToString(), this))
                {
                    Dispose(true);
                    Close();
                }
                testCellContentChanged = false;
            }
            if(instrumentsContentChanged)
            {
                if (!xmlUtils.SaveDUTInstruments(nest.ToString(), this))
                {
                    Dispose(true);
                    Close();
                }
                instrumentsContentChanged = false;
            }
        }
        
        private void DUTConfiguration_Resize(object sender, EventArgs e)
        {
            try
            {
                if (WindowState == FormWindowState.Maximized)
                {
                    dataGridViewTests.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewSignals.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewVariables.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dataGridViewDevices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
                if (WindowState == FormWindowState.Normal)
                {
                    dataGridViewTests.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dataGridViewTests.Columns[10].Width = 130;
                    dataGridViewSignals.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dataGridViewVariables.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                    dataGridViewDevices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DUTConfiguration_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridViewTests.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewSignals.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewVariables.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridViewDevices.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void dataGridViewDevices_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dataGridViewDevices.PointToClient(Cursor.Position);
            int rowIndexToDrop = dataGridViewDevices.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (rowIndexToDrop != -1)
            {
                DataGridViewRow rowToMove = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                dataGridViewDevices.Rows.RemoveAt(rowToMove.Index);
                dataGridViewDevices.Rows.Insert(rowIndexToDrop, rowToMove);
                dataGridViewDevices.Rows[rowIndexToDrop].Selected = true;
            }
        }

        private void dataGridViewDevices_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
                e.Effect = DragDropEffects.Move;
        }

        private void dataGridViewDevices_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (dataGridViewDevices.Rows.Count > 1)
                    dataGridViewDevices.DoDragDrop(dataGridViewDevices.CurrentRow, DragDropEffects.Move);
            }
        }

        private void toolStripButtonAddInstrument_Click(object sender, EventArgs e)
        {
            dataGridViewDevices.Rows.Add();
        }

        private void toolStripButtonRemoveInstrument_Click(object sender, EventArgs e)
        {
            if (dataGridViewDevices.SelectedRows.Count < 1)
                MessageBox.Show("Select first the instruments to remove", "User action", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                dataGridViewDevices.Rows.Remove(dataGridViewDevices.SelectedRows[0]);
        }

        private void toolStripButtonSaveInstruments_Click(object sender, EventArgs e)
        {
            SaveNestSettings();
            MessageBox.Show("Instruments saved successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

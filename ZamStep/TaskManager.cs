using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using NationalInstruments.DAQmx;

namespace SSR
{
    public partial class TaskManager : Form
    {
        List<ControlTaskType> CtrlTaskList = new List<ControlTaskType>();
        List<string> NiTasks = new List<string>();
        JSonUtilities Json = new JSonUtilities();
        ControlTask controlTask;
        bool foco;
        int rowSelected = 0;
        static Bitmap trans = new Bitmap(25, 25);
        Graphics g = Graphics.FromImage(trans);
        public TaskManager()
        {
            InitializeComponent();
        }

        internal void SignalsControl_Load(object sender, EventArgs e)
        {
            foco = true;            
            Json.CreateFile($@"{Directory.GetCurrentDirectory()}\controlTask.json");
            if (Json.GetTasks() != null)
            {
                CtrlTaskList = Json.GetTasks();
            }
            VerifTasksExist();
            dgvControlTask.Rows.Clear();
        }

        internal bool VerifTasksExist()
        {
            if (!LoadDgvNiTasks() && CtrlTaskList.Count == 0)
            {
                lblWarning.Visible = true;
                toolStripButtonAddVariable.Enabled = false;
                toolStripButtonEditVariable.Enabled = false;
                toolStripButtonRemoveVariable.Enabled = false;
                toolStripButtonReload.Enabled = true;
                dgvControlTask.Enabled = false;
                dgvNiTasks.Enabled = false;                
                return false;
            }
            else
            {
                lblWarning.Visible = false;
                toolStripButtonAddVariable.Enabled = true;
                toolStripButtonEditVariable.Enabled = true;
                toolStripButtonRemoveVariable.Enabled = true;
                toolStripButtonReload.Enabled = true;
                dgvControlTask.Enabled = true;
                dgvNiTasks.Enabled = true;
                return true;
            }                
        }

        internal bool LoadDgvNiTasks()
        {
            try
            {
                dgvNiTasks.Rows.Clear();
                if (DaqSystem.Local.Tasks.ToArray().Length >0)
                {                    
                    NiTasks = DaqSystem.Local.Tasks.ToList();
                    for (int c=0; c< NiTasks.Count(); c++)
                    {
                        if (CtrlTaskList.Find(x => x.Name.Contains(NiTasks[c])) == null)
                            dgvNiTasks.Rows.Add(NiTasks[c]);
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool LoadDgvCtrlTasks()
        {
            try
            {
                dgvControlTask.Rows.Clear();
                if (VerifyTasks())
                {
                    CtrlTaskList = Json.GetTasks();
                    for (int c = 0; c < CtrlTaskList.Count; c++)
                    {
                        if (CtrlTaskList[c].IsPresent == true)
                        {
                            dgvControlTask.Rows.Add(CtrlTaskList[c].Name, CtrlTaskList[c].Description, Properties.Resources.confirm);
                            dgvControlTask.Rows[c].Cells[2].ToolTipText = "Success: Task found in NI Max";
                        }
                        else if (CtrlTaskList[c].IsPresent == false)
                        {
                            dgvControlTask.Rows.Add(CtrlTaskList[c].Name, CtrlTaskList[c].Description, Properties.Resources.close_24x24);
                            dgvControlTask.Rows[c].Cells[2].ToolTipText = "Error: Task not found in NI Max";
                        }

                    }
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool MoveControlTask(int sourceRowIndex, int destRowIndex)
        {
            try
            {
                ControlTaskType aux = new ControlTaskType();
                aux = CtrlTaskList[sourceRowIndex];
                CtrlTaskList.RemoveAt(sourceRowIndex);
                CtrlTaskList.Insert(destRowIndex, aux);
                Json.SetTasks(CtrlTaskList);
                LoadDgvCtrlTasks();
                dgvControlTask.Rows[destRowIndex].Selected = true;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        internal bool DeleteControlTask(int index)
        {
            try
            {
                CtrlTaskList.RemoveAt(index);
                Json.SetTasks(CtrlTaskList);
                return true;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return false;
            }
        }

        internal bool VerifyTasks ()
        {
            try
            {
                if (Json.GetTasks() != null)
                {
                    CtrlTaskList = Json.GetTasks();
                    for (int c = 0; c < CtrlTaskList.Count; c++)
                    {
                        if (DaqSystem.Local.Tasks.FirstOrDefault(x => x.Equals(CtrlTaskList[c].Name)) == null)
                            CtrlTaskList[c].IsPresent = false;
                        else
                            CtrlTaskList[c].IsPresent = true;
                    }
                    Json.SetTasks(CtrlTaskList);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void toolStripButtonAddVariable_Click(object sender, EventArgs e)
        {
            if (dgvNiTasks.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a task first", "Add Task");
            }
            else
            {
                CtrlTaskList.Add(new ControlTaskType()
                {
                    Name = dgvNiTasks.SelectedRows[0].Cells[0].Value.ToString(),
                    Description = "",
                });
                Json.SetTasks(CtrlTaskList);
                LoadDgvCtrlTasks();
                LoadDgvNiTasks();
            }
        }

        private void TaskManager_Activated(object sender, EventArgs e)
        {
            if (!foco)
            {
                foco = true;
                if (VerifTasksExist())
                {
                    LoadDgvCtrlTasks();
                    LoadDgvNiTasks();
                }
                if (dgvControlTask.Rows.Count > 0)
                    dgvControlTask.Rows[rowSelected].Selected = true;
            }
            else if (CtrlTaskList.Count > 0)
            {
                LoadDgvCtrlTasks();
                LoadDgvNiTasks();
                VerifTasksExist();
                if (dgvControlTask.Rows.Count > 0)
                    dgvControlTask.Rows[rowSelected].Selected = true;
            }
        }

        private void TaskManager_Deactivate(object sender, EventArgs e)
        {           
            foco = false;
            if(dgvControlTask.Rows.Count > 0)
            {
                rowSelected = dgvControlTask.SelectedRows[0].Index;
            }
        }

        private void toolStripButtonRemoveVariable_Click(object sender, EventArgs e)
        {
            if (dgvControlTask.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a task first", "Remove Task");
            }
            else
            {
                if (DeleteControlTask(dgvControlTask.SelectedRows[0].Index))
                {
                    LoadDgvCtrlTasks();
                    LoadDgvNiTasks();
                }
            }
        }    

        private void toolStripButtonEditVariable_Click(object sender, EventArgs e)
        {
            if (dgvControlTask.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a task first", "Edit Task");
            }
            else
            {
                controlTask = new ControlTask();
                controlTask.index = dgvControlTask.SelectedRows[0].Index;
                controlTask.ShowDialog();
                foco = false;
            }            
        }

        private void dgvControlTask_DragDrop(object sender, DragEventArgs e)
        {
            Point clientPoint = dgvControlTask.PointToClient(new Point(e.X, e.Y));
            int destRowIndex = dgvControlTask.HitTest(clientPoint.X, clientPoint.Y).RowIndex;
            if (destRowIndex != -1)
            {
                DataGridViewRow sourceRowIndex = e.Data.GetData(typeof(DataGridViewRow)) as DataGridViewRow;
                if (destRowIndex == sourceRowIndex.Index)
                    return;
                MoveControlTask(sourceRowIndex.Index, destRowIndex);
            }
        }

        private void dgvControlTask_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = e.Data.GetDataPresent(DataFormats.StringFormat) ? DragDropEffects.Copy : DragDropEffects.None;
            }
        }

        private void dgvControlTask_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (dgvControlTask.Rows.Count > 1)
                {
                    dgvControlTask.DoDragDrop(dgvControlTask.CurrentRow, DragDropEffects.All);
                }
            }
        }

        private void dgvControlTask_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvControlTask.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a task first", "Edit Task");
            }
            else
            {
                ControlTask controlTask = new ControlTask();
                controlTask.index = dgvControlTask.SelectedRows[0].Index;
                controlTask.ShowDialog();
            }
        }

        private void toolStripButtonReload_Click(object sender, EventArgs e)
        {
            LoadDgvCtrlTasks();
            LoadDgvNiTasks();
            VerifTasksExist();
        }        

        private void dgvNiTasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvNiTasks.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a task first", "Add Task");
            }
            else
            {
                CtrlTaskList.Add(new ControlTaskType()
                {
                    Name = dgvNiTasks.SelectedRows[0].Cells[0].Value.ToString(),
                    Description = "",
                });
                Json.SetTasks(CtrlTaskList);
                LoadDgvCtrlTasks();
                LoadDgvNiTasks();
            }
        }

        private void dgvNiTasks_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

using NationalInstruments.DAQmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Threading;
using System.Reflection;
using System.Security.Policy;

namespace SSR
{
    public partial class Diagnostic : Form
    {
        public List<ControlTaskType> controlTaskList;
        public List<NationalInstruments.DAQmx.Task> tasksList;
        public List<ucDigitalOutput> listUCDigitalOutput;
        public List<ucDigitalInput> listUCDigitalInput;
        public List<ucAnalogInput> listUCAnalogInputs;
        public List<ucAnalogOutput> listUCAnalgOutput;
        public Device daq;
        public Color focus = Color.FromArgb(255, 23, 167, 251);
        public Color defaultColor = Color.FromArgb(255, 9, 109, 167);
        public bool IsRunningDiagnostic { get; set; }
        enum ITEM_SELECTED
        {
            DI = 1,
            DO,
            AI,
            AO
        }
        internal int itemSelected = 0;
        public Diagnostic()
        {
            InitializeComponent();
            toolStripLabelDevice.Text = Properties.Settings.Default.DiagnosticDevice;
            toolStripLabelDevice.ForeColor = defaultColor;
            tasksList = new List<NationalInstruments.DAQmx.Task>();
            controlTaskList = new List<ControlTaskType>();
            listUCDigitalOutput = new List<ucDigitalOutput>();
            listUCDigitalInput = new List<ucDigitalInput>();
            listUCAnalogInputs = new List<ucAnalogInput>();
            listUCAnalgOutput = new List<ucAnalogOutput>();
            try
            {
                daq = DaqSystem.Local.LoadDevice(Properties.Settings.Default.DiagnosticDevice);
            }
            catch(DaqException)
            {
                MessageBox.Show("Error when loading the device, check if it is connected correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }           
            string jsonContent = File.ReadAllText($@"{Directory.GetCurrentDirectory()}\controlTask.json");
            controlTaskList = JsonConvert.DeserializeObject<List<ControlTaskType>>(jsonContent);
            
            toolStripLabelStatus.Text = "Stoped";
            toolStripLabelStatus.ForeColor = Color.Red;
            toolStripButtonStop.Enabled = false;
        }
        public void FillListTasks()
        {
            try
            {
                foreach (ControlTaskType controltask in controlTaskList)
                {
                    var found = DaqSystem.Local.Tasks.FirstOrDefault(x => x.Equals(controltask.Name));
                    if (found != null)
                    {
                        NationalInstruments.DAQmx.Task temp = DaqSystem.Local.LoadTask(controltask.Name);
                        temp.Start();
                        temp.Stop();
                        tasksList.Add(temp);
                        if (temp.DOChannels.Count != 0)
                        {
                            ucDigitalOutput ucTemp = new ucDigitalOutput();
                            ucTemp.TaskName = controltask.Name;
                            ucTemp.Signal = temp.DOChannels[0].PhysicalName;
                            ucTemp.VirtualName = temp.DOChannels[0].VirtualName;
                            listUCDigitalOutput.Add(ucTemp);
                        }
                        if (temp.DIChannels.Count != 0)
                        {
                            ucDigitalInput ucTemp = new ucDigitalInput();
                            ucTemp.TaskName = controltask.Name;
                            ucTemp.Signal = temp.DIChannels[0].PhysicalName;
                            ucTemp.VirtualName = temp.DIChannels[0].VirtualName;
                            listUCDigitalInput.Add(ucTemp);
                        }
                        if (temp.AIChannels.Count != 0)
                        {
                            ucAnalogInput ucTemp = new ucAnalogInput();
                            ucTemp.TaskName = controltask.Name;
                            ucTemp.Signal = temp.AIChannels[0].PhysicalName;
                            ucTemp.VirtualName = temp.AIChannels[0].VirtualName;
                            listUCAnalogInputs.Add(ucTemp);
                        }
                        if (temp.AOChannels.Count != 0)
                        {
                            ucAnalogOutput ucTemp = new ucAnalogOutput();
                            ucTemp.TaskName = controltask.Name;
                            ucTemp.Signal = temp.AOChannels[0].PhysicalName;
                            ucTemp.VirtualName = temp.AOChannels[0].VirtualName;
                            listUCAnalgOutput.Add(ucTemp);
                        }
                    }
                    else
                        continue;
                }
            }
            catch(DaqException ex)
            {
                MessageBox.Show("Check settings for device in NI-MAX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            IsRunningDiagnostic = true;
            toolStripLabelStatus.Text = "Running";
            toolStripLabelStatus.ForeColor = Color.Green;
            toolStripButtonStop.Enabled = true;
            toolStripButtonPlay.Enabled = false;
            foreach (ucDigitalInput input in listUCDigitalInput)
            {
                input.timerReader.Start();
                input.Enabled = true;
            }
            foreach(ucAnalogInput inputAI in listUCAnalogInputs)
            {
                inputAI.timerAI.Start();
                inputAI.Enabled = true;
            }
            foreach (ucDigitalOutput inputDO in listUCDigitalOutput)
            {
                inputDO.Enabled = true;
            }
            foreach(ucAnalogOutput outAo in listUCAnalgOutput)
            {
                outAo.Enabled = true;
            }
        }
        private void toolStripButtonStopSequence_Click(object sender, EventArgs e)
        {
            IsRunningDiagnostic = false;
            toolStripLabelStatus.Text = "Stoped";
            toolStripLabelStatus.ForeColor = Color.Red;
            toolStripButtonStop.Enabled = false;
            toolStripButtonPlay.Enabled = true;
            foreach (ucDigitalInput input in listUCDigitalInput)
            {
                input.timerReader.Stop();
                input.Enabled = false;
            }
            foreach (ucAnalogInput inputAI in listUCAnalogInputs)
            {
                inputAI.timerAI.Stop();
                inputAI.Enabled = false;
            }
            foreach (ucDigitalOutput inputDO in listUCDigitalOutput)
            {
                inputDO.Enabled = false;
            }
            foreach (ucAnalogOutput outAo in listUCAnalgOutput)
            {
                outAo.Enabled = false;
            }
        }
        private void Diagnostic_Load(object sender, EventArgs e)
        {
            FillListTasks();
            foreach (NationalInstruments.DAQmx.Task controltask in tasksList)
            {
                if (controltask.AIChannels.Count != 0)
                {
                    foreach (ucAnalogInput temp in listUCAnalogInputs)
                    {
                        flowLayoutPanelAI.Controls.Add(temp);
                    }

                }
                if (controltask.DOChannels.Count != 0)
                {
                    foreach(ucDigitalOutput temp in listUCDigitalOutput)
                    {
                        flowLayoutPanelDO.Controls.Add(temp);
                    }
                }
                if (controltask.DIChannels.Count != 0)
                {
                    foreach (ucDigitalInput temp in listUCDigitalInput)
                    {
                        flowLayoutPanelDI.Controls.Add(temp);
                    }
                }
                if(controltask.AOChannels.Count != 0)
                {
                    foreach(ucAnalogOutput temp in listUCAnalgOutput)
                    {
                        flowLayoutPanelAO.Controls.Add(temp);
                    }
                }
            }
        }
        private void Diagnostic_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (IsRunningDiagnostic)
                toolStripButtonStopSequence_Click(null, null);
            
            daq.Dispose();
            GC.SuppressFinalize(controlTaskList);
            GC.SuppressFinalize(listUCDigitalOutput);
            GC.SuppressFinalize(listUCDigitalInput);
            GC.SuppressFinalize(listUCAnalogInputs);
            GC.SuppressFinalize(listUCAnalgOutput);
            foreach (NationalInstruments.DAQmx.Task temp in tasksList)
            {
                temp.Dispose();
            }
            GC.SuppressFinalize(tasksList);
            this.Cursor = Cursors.Default;
        }
        private void pictureBoxDI_Click(object sender, EventArgs e)
        {
            itemSelected = (int)ITEM_SELECTED.DI;
            SetImageItemsSelected();
            flowLayoutPanelDI.Location = new Point(173, 30);
            flowLayoutPanelDI.Refresh();
            flowLayoutPanelDI.Visible = true;
            flowLayoutPanelDO.Visible = false;
            flowLayoutPanelAI.Visible = false;
            flowLayoutPanelAO.Visible = false;
        }
        private void pictureBoxDO_Click(object sender, EventArgs e)
        {
            itemSelected = (int)ITEM_SELECTED.DO;
            SetImageItemsSelected();
            flowLayoutPanelDO.Location = new Point(173, 30);
            flowLayoutPanelDO.Refresh();
            flowLayoutPanelDO.Visible = true;
            flowLayoutPanelDI.Visible = false;
            flowLayoutPanelAI.Visible = false;
            flowLayoutPanelAO.Visible = false;
        }
        private void pictureBoxAI_Click(object sender, EventArgs e)
        {
            itemSelected = (int)ITEM_SELECTED.AI;
            SetImageItemsSelected();
            flowLayoutPanelAI.Location = new Point(173, 30);
            flowLayoutPanelAI.Refresh();
            flowLayoutPanelAI.Visible = true;
            flowLayoutPanelDI.Visible = false;
            flowLayoutPanelDO.Visible = false;
            flowLayoutPanelAO.Visible = false;
        }
        private void pictureBoxAO_Click(object sender, EventArgs e)
        {
            itemSelected = (int)ITEM_SELECTED.AO;
            SetImageItemsSelected();
            flowLayoutPanelAO.Location = new Point(173, 30);
            flowLayoutPanelAO.Refresh();
            flowLayoutPanelAO.Visible = true;
            flowLayoutPanelDI.Visible = false;
            flowLayoutPanelDO.Visible = false;
            flowLayoutPanelAI.Visible = false;
        }
        #region SET ITEMS MENU
        public void SetImageItemsSelected()
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
           
            string currentDirectory = di.Parent.Parent.FullName;

            if (itemSelected == (int)ITEM_SELECTED.DI)
            {
                pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI_selected.jpg";
                pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
                pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
                pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
            }
            else if (itemSelected == (int)ITEM_SELECTED.DO)
            {
                pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
                pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO_selected.jpg";
                pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
                pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
            }
            else if(itemSelected == (int)ITEM_SELECTED.AI)
            {
                pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
                pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
                pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI_selected.jpg";
                pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
            }
            else if(itemSelected == (int)ITEM_SELECTED.AO)
            {
                pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
                pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
                pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
                pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO_selected.jpg";
            }
        }
        
        private void pictureBoxDI_MouseLeave(object sender, EventArgs e)
        {
            SetImageItemsSelected();
        }

        private void pictureBoxDI_MouseEnter(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string currentDirectory = di.Parent.Parent.FullName;
            pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
            pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI_focus.jpg";
            pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
            pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
        }

        private void pictureBoxDO_MouseEnter(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string currentDirectory = di.Parent.Parent.FullName;
            pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO_focus.jpg";
            pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
            pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
            pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
        }

        private void pictureBoxDO_MouseLeave(object sender, EventArgs e)
        {
            SetImageItemsSelected();
        }

        private void pictureBoxAI_MouseEnter(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string currentDirectory = di.Parent.Parent.FullName;
            pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
            pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
            pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI_focus.jpg";
            pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO.jpg";
        }

        private void pictureBoxAI_MouseLeave(object sender, EventArgs e)
        {
            SetImageItemsSelected();
        }

        private void pictureBoxAO_MouseEnter(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string currentDirectory = di.Parent.Parent.FullName;
            pictureBoxDO.ImageLocation = $@"{currentDirectory}\Resources\itemsDO.jpg";
            pictureBoxDI.ImageLocation = $@"{currentDirectory}\Resources\itemsDI.jpg";
            pictureBoxAI.ImageLocation = $@"{currentDirectory}\Resources\itemsAI.jpg";
            pictureBoxAO.ImageLocation = $@"{currentDirectory}\Resources\itemsAO_focus.jpg";
        }

        private void pictureBoxAO_MouseLeave(object sender, EventArgs e)
        {
            SetImageItemsSelected();
        }
        #endregion
        public void ClearLists()
        {
            listUCAnalgOutput.Clear();
            listUCAnalogInputs.Clear();
            listUCDigitalInput.Clear();
            listUCDigitalOutput.Clear();
            
            foreach (NationalInstruments.DAQmx.Task temp in tasksList)
            {
                temp.Dispose();
            }
            tasksList.Clear();
        }
        private void toolStripButtonReset_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            daq.Reset();
            ClearLists();
            FillListTasks();
            flowLayoutPanelDO.Controls.Clear();
            flowLayoutPanelDI.Controls.Clear();
            flowLayoutPanelAI.Controls.Clear();
            flowLayoutPanelAO.Controls.Clear();
            foreach (NationalInstruments.DAQmx.Task controltask in tasksList)
            {
                if (controltask.AIChannels.Count != 0)
                {
                    foreach (ucAnalogInput temp in listUCAnalogInputs)
                    {
                        if (IsRunningDiagnostic)
                        {
                            temp.Enabled = true;
                            temp.timerAI.Start();
                        }
                        flowLayoutPanelAI.Controls.Add(temp);
                    }

                }
                if (controltask.DOChannels.Count != 0)
                {
                    foreach (ucDigitalOutput temp in listUCDigitalOutput)
                    {
                        if (IsRunningDiagnostic)
                            temp.Enabled = true;
                        flowLayoutPanelDO.Controls.Add(temp);
                    }
                }
                if (controltask.DIChannels.Count != 0)
                {
                    foreach (ucDigitalInput temp in listUCDigitalInput)
                    {
                        if (IsRunningDiagnostic)
                        {
                            temp.Enabled = true;
                            temp.timerReader.Start();
                        }
                        flowLayoutPanelDI.Controls.Add(temp);
                    }
                }
                if (controltask.AOChannels.Count != 0)
                {
                    foreach (ucAnalogOutput temp in listUCAnalgOutput)
                    {
                        if (IsRunningDiagnostic)
                            temp.Enabled = true;
                        flowLayoutPanelAO.Controls.Add(temp);
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using Newtonsoft.Json;
using System.IO;

namespace SSR
{
    public partial class ControlTask : Form
    {
        List<ControlTaskType> CtrlTaskList = new List<ControlTaskType>();
        JSonUtilities Json = new JSonUtilities();
        public ControlTask()
        {
            InitializeComponent();
        }
        internal int index;
        private void ControlSignalTask_Load(object sender, EventArgs e)
        {
            if (Json.GetTasks() != null)
            {
                CtrlTaskList = Json.GetTasks();
                txtTasklName.Text = CtrlTaskList[index].Name;
                txtDescription.Text = CtrlTaskList[index].Description;
            }            
            //cmbDevice.DataSource = DaqSystem.Local.Devices;
        }

        private void lblSignalType_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSignal_Click(object sender, EventArgs e)
        {
            if (txtTasklName.Text != "")
            {
                CtrlTaskList[index] = (new ControlTaskType()
                {
                    Name = txtTasklName.Text,
                    Description = txtDescription.Text,
                    IsPresent = true,
                });
                if (Json.SetTasks(CtrlTaskList))
                {
                    this.DialogResult = DialogResult.OK;
                }
                
            }            
        }                 

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanelSignals_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

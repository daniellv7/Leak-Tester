using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
namespace SSR
{
    public partial class ucAnalogOutput : UserControl
    {
        public string TaskName { get; set; }
        public string Signal { get; set; }
        public string VirtualName { get; set; }
        public NationalInstruments.DAQmx.Task taskTemp;
        AnalogSingleChannelWriter writer;
        public ucAnalogOutput()
        {
            InitializeComponent();
            labelStatus.Text = "Stoped";
            labelStatus.ForeColor = Color.Red;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Device deviceLoaded = DaqSystem.Local.LoadDevice(Properties.Settings.Default.DiagnosticDevice);
                var voltRanges = deviceLoaded.AOVoltageRanges;
                taskTemp = new NationalInstruments.DAQmx.Task();

                taskTemp.AOChannels.CreateVoltageChannel(Signal, "", voltRanges[0], voltRanges[1], AOVoltageUnits.Volts);
                writer = new AnalogSingleChannelWriter(taskTemp.Stream);
                writer.WriteSingleSample(true, Convert.ToDouble(textBox1.Text));
                labelStatus.Text = "Running";
                labelStatus.ForeColor = Color.Green;
            }
            else
            {
                labelStatus.Text = "Error";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void ucAnalogOutput_Load(object sender, EventArgs e)
        {
            labelTaskName.Text = TaskName;
            labelPhysicalName.Text = Signal;
            labelVirtualName.Text = VirtualName;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            writer.WriteSingleSample(true, 0);
            taskTemp.Dispose();
            labelStatus.Text = "Stoped";
            labelStatus.ForeColor = Color.Red;
        }
    }
}

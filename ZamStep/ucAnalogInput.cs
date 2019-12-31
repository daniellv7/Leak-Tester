using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using System.Globalization;
namespace SSR
{
    public partial class ucAnalogInput : UserControl
    {
        public string TaskName { get; set; }
        public string Signal { get; set; }
        public string VirtualName { get; set; }
        public double Meas { get; set; }
        public ucAnalogInput()
        {
            InitializeComponent();
        }
        public void SetComponents()
        {
            labelNameTask.Text = TaskName;
            labelVirtualName.Text = VirtualName;
            labelPhysicalName.Text = Signal;
        }

        private void timerAI_Tick(object sender, EventArgs e)
        {
            using (NationalInstruments.DAQmx.Task temp = new NationalInstruments.DAQmx.Task())
            {
                temp.AIChannels.CreateVoltageChannel(Signal, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
                AnalogSingleChannelReader reader = new AnalogSingleChannelReader(temp.Stream);
                Meas = reader.ReadSingleSample();
                textBoxMeas.Text = Meas.ToString("F6", CultureInfo.InvariantCulture);
            }
        }

        private void graphAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph(Signal);
            string[] numberAI = Signal.Split('/');
            graph.Text = "Graph " + numberAI[1].ToUpper();
            graph.Show();
        }

        private void ucAnalogInput_Load(object sender, EventArgs e)
        {
            SetComponents();
        }
    }
}

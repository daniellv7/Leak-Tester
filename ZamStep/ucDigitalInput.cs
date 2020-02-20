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
    public partial class ucDigitalInput : UserControl
    {
        public string TaskName { get; set; }
        public string Signal { get; set; }
        public string VirtualName { get; set; }
        public bool IsActive { get; set; }
        public ucDigitalInput()
        {
            InitializeComponent();
        }
        public void SetComponents()
        {
            labelNameTask.Text = TaskName;
            labelVirtualName.Text = VirtualName;
            labelPhysicalName.Text = Signal;
        }

        private void ucDigitalInput_Load(object sender, EventArgs e)
        {
            SetComponents();
        }

        private void timerReader_Tick(object sender, EventArgs e)
        {
            using (NationalInstruments.DAQmx.Task temp = new NationalInstruments.DAQmx.Task())
            {
                temp.DIChannels.CreateChannel(Signal, "", NationalInstruments.DAQmx.ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelReader reader = new DigitalSingleChannelReader(temp.Stream);
                IsActive = reader.ReadSingleSampleSingleLine();
                if (IsActive)
                    pictureBox1.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\led-on.png";
                else
                    pictureBox1.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\led-off.png";
            }
        }
    }
}

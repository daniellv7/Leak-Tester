using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NationalInstruments.DAQmx;
using System.Threading.Tasks;
namespace SSR
{
    public partial class ucDigitalOutput : UserControl
    {
        public string TaskName { get; set; }
        public string Signal { get; set; }
        public string VirtualName { get; set; }
        public bool IsActive { get; set; }
        private bool Status { get; set; }
        public ucDigitalOutput()
        {
            InitializeComponent();
            IsActive = false;
        }
        public void SetComponents()
        {
            labelNameTask.Text = TaskName;
            labelVirtualName.Text = VirtualName;
            labelPhysicalName.Text = Signal;
        }

        private void pictureBoxSwitch_Click(object sender, EventArgs e)
        {
            using (NationalInstruments.DAQmx.Task t = new NationalInstruments.DAQmx.Task())
            {
                t.DOChannels.CreateChannel(Signal, "", ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(t.Stream);
                if (IsActive)
                {
                    IsActive = false;
                    writer.WriteSingleSampleSingleLine(true, false);
                    labelStatus.Text = "OFF";
                    labelStatus.ForeColor = Color.Red;
                    pictureBoxSwitch.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\if_button_off_352905.png";
                }
                else
                {
                    IsActive = true;
                    writer.WriteSingleSampleSingleLine(true, true);
                    labelStatus.Text = "ON";
                    labelStatus.ForeColor = Color.Green;
                    pictureBoxSwitch.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\if_button_on_352904.png";
                }
            }
        }

        private void ucDigitalOutput_Load(object sender, EventArgs e)
        {
            SetComponents();
            using (NationalInstruments.DAQmx.Task t = new NationalInstruments.DAQmx.Task())
            {
                t.DOChannels.CreateChannel(Signal, "", ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelReader reader = new DigitalSingleChannelReader(t.Stream);
                t.Start();
                Status = reader.ReadSingleSampleSingleLine();
                t.Stop();
            }
            if (Status)
            {
                labelStatus.Text = "ON";
                labelStatus.ForeColor = Color.Green;
                IsActive = true;
                pictureBoxSwitch.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\if_button_on_352904.png";
            }
            else
            {
                IsActive = false;
                labelStatus.Text = "OFF";
                labelStatus.ForeColor = Color.Red;
                pictureBoxSwitch.ImageLocation = @"C:\Users\Lear\Documents\Leak Tester\Software\Leak Tester\ZamStep\Resources\if_button_off_352905.png";

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;

namespace ZamStep
{
    class ReadDigitalInput
    {
        public bool readDISignals(string signal)
        {
            using (Task task = new Task())
            {
                task.DIChannels.CreateChannel(signal, "", ChannelLineGrouping.OneChannelForAllLines);
                DigitalSingleChannelReader reader = new DigitalSingleChannelReader(task.Stream);
                return reader.ReadSingleSampleSingleLine();
            }
        }
    }
}

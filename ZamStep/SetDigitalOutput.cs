using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;
namespace ZamStep
{
    class SetDigitalOutput
    {

        /// <summary>
        /// Abre o cierra una señal discreta.
        /// </summary>
        /// <param name="signal"></param>
        /// <param name="status"></param>
        public void setDOSignals(string signal, bool status)
        {
            using (Task task = new Task())
            {
                task.DOChannels.CreateChannel(signal, "", ChannelLineGrouping.OneChannelForEachLine);
                DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(task.Stream);
                writer.WriteSingleSampleSingleLine(true, status);
            }
        }
    }
}

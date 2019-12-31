using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using NationalInstruments.DAQmx;
using System.Globalization;

namespace SSR
{
    public partial class Graph : Form
    {
        AnalogSingleChannelReader aiVoltage;
        public Graph(string signal)
        {
            InitializeComponent();

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)
                .Y(model => model.Value);
            Charting.For<MeasureModel>(mapper);
            ChartValues = new ChartValues<MeasureModel>();
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Values = ChartValues,
                    PointGeometrySize = 18,
                    StrokeThickness = 4
                }
            };
            cartesianChart1.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                LabelFormatter = value => new System.DateTime((long)value).ToString("mm:ss"),
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                DisableAnimations = true,
                MaxValue = 10,
                MinValue = -2,


            });
            SetAxisLimits(System.DateTime.Now);
            Timer = new Timer
            {
                Interval = 250
            };
            Timer.Tick += TimerOnTick;
            //DaqSystem.Local.LoadDevice("DIO1").Reset();
            //NationalInstruments.DAQmx.Task activeDO = new NationalInstruments.DAQmx.Task();
            //activeDO.DOChannels.CreateChannel("DIO1/port1/line0", "", ChannelLineGrouping.OneChannelForEachLine);
            //DigitalSingleChannelWriter writer = new DigitalSingleChannelWriter(activeDO.Stream);
            //writer.WriteSingleSampleSingleLine(true, true);
            NationalInstruments.DAQmx.Task tasktest = new NationalInstruments.DAQmx.Task();
            tasktest.AIChannels.CreateVoltageChannel(signal, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
            aiVoltage = new AnalogSingleChannelReader(tasktest.Stream);
            toolStripLabelStatus.Text = "Stoped";
            toolStripLabelStatus.ForeColor = Color.Red;
        }
        public ChartValues<MeasureModel> ChartValues { get; set; }
        public Timer Timer { get; set; }

        private void SetAxisLimits(System.DateTime now)
        {
            cartesianChart1.AxisX[0].MaxValue = now.Ticks + TimeSpan.FromSeconds(1).Ticks;
            cartesianChart1.AxisX[0].MinValue = now.Ticks - TimeSpan.FromSeconds(8).Ticks;
        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            var now = System.DateTime.Now;
            double meas = aiVoltage.ReadSingleSample();
            lock (aiVoltage)
            {
                ChartValues.Add(new MeasureModel
                {
                    DateTime = now,
                    Value = meas
                });
                textBoxMeas.Text = meas.ToString("F6", CultureInfo.InvariantCulture);
                SetAxisLimits(now);
                if (ChartValues.Count > 30) ChartValues.RemoveAt(0);
            }
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            ChartValues.Clear();
            Timer.Start();
            toolStripLabelStatus.Text = "Running";
            toolStripLabelStatus.ForeColor = Color.Green;
        }

        private void toolStripButtonStopSequence_Click(object sender, EventArgs e)
        {
            toolStripLabelStatus.Text = "Stoped";
            toolStripLabelStatus.ForeColor = Color.Red;
            Timer.Stop();
        }

    }
}

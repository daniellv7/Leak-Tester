using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NationalInstruments.DAQmx;
using System.Threading;

namespace SSR
{
    public static class SliderSMC
    {
        public static Task Driver;
        public static DigitalSingleChannelWriter doDriver;
        public static Task In0_SliderTask, In1_SliderTask, In2_SliderTask, In3_SliderTask, In4_SliderTask, In5_SliderTask;
        public static DigitalSingleChannelWriter DOIn1, DOIn2, DOIn3, DOIn4, DOIn5, DOIn0;
        public static Task Setup_SliderTask, Hold_SliderTask, Drive_SliderTask, Reset_SliderTask, Svon_SliderTask;
        public static DigitalSingleChannelWriter DOSetup_Slider, DOHold_Slider, DODriver_Slider, DOReset_Slider, DOSvon_Slider;

        public static Task INPTask;
        public static DigitalSingleChannelReader DIINP;
        public static Task Busy_SliderTask, SVRESliderTask, AlarmSliderTask, SetOnTask;
        public static DigitalSingleChannelReader DIBusySlider, DISVRESlider, DIAlarmSlider, DISetOn;
        public static Task CortinasTask;
        public static DigitalSingleChannelReader DICortinas;

        public static bool MoveToHome()
        {
            //NationalInstruments.DAQmx.DaqSystem.Local.LoadDevice("DIO1");
            SVRESliderTask = new Task();
            SVRESliderTask.DIChannels.CreateChannel("DIO1/port1/line6", "", ChannelLineGrouping.OneChannelForEachLine);
            DISVRESlider = new DigitalSingleChannelReader(SVRESliderTask.Stream);
            
            INPTask= new Task();
            INPTask.DIChannels.CreateChannel("DIO1/port1/line5", "", ChannelLineGrouping.OneChannelForEachLine);
            DIINP = new DigitalSingleChannelReader(INPTask.Stream);
            Svon_SliderTask = new Task();
            Svon_SliderTask.DOChannels.CreateChannel("DIO1/port5/line6", "", ChannelLineGrouping.OneChannelForEachLine);
            DOSvon_Slider = new DigitalSingleChannelWriter(Svon_SliderTask.Stream);
            Setup_SliderTask = new Task();
            Setup_SliderTask.DOChannels.CreateChannel("DIO1/port5/line2", "", ChannelLineGrouping.OneChannelForEachLine);
            DOSetup_Slider = new DigitalSingleChannelWriter(Setup_SliderTask.Stream);
            Busy_SliderTask = new Task();
            Busy_SliderTask.DIChannels.CreateChannel("DIO1/port1/line3", "", ChannelLineGrouping.OneChannelForEachLine);
            DIBusySlider = new DigitalSingleChannelReader(Busy_SliderTask.Stream);
            SetOnTask = new Task();
            SetOnTask.DIChannels.CreateChannel("DIO1/port1/line4", "", ChannelLineGrouping.OneChannelForEachLine);
            DISetOn = new DigitalSingleChannelReader(SetOnTask.Stream);
            AlarmSliderTask = new Task();
            AlarmSliderTask.DIChannels.CreateChannel("DIO1/port1/line7", "", ChannelLineGrouping.OneChannelForEachLine);
            DIAlarmSlider = new DigitalSingleChannelReader(AlarmSliderTask.Stream);
            Reset_SliderTask = new Task();
            Reset_SliderTask.DOChannels.CreateChannel("DIO1/port5/line5", "", ChannelLineGrouping.OneChannelForEachLine);
            DOReset_Slider = new DigitalSingleChannelWriter(Reset_SliderTask.Stream);
            Drive_SliderTask = new Task();
            Drive_SliderTask.DOChannels.CreateChannel("DIO1/port5/line4", "", ChannelLineGrouping.OneChannelForEachLine);
            DODriver_Slider = new DigitalSingleChannelWriter(Drive_SliderTask.Stream);
            CortinasTask = new Task();
            CortinasTask.DIChannels.CreateChannel("DIO1/port0/line6", "", ChannelLineGrouping.OneChannelForEachLine);
            DICortinas = new DigitalSingleChannelReader(CortinasTask.Stream);
            Hold_SliderTask = new Task();
            Hold_SliderTask.DOChannels.CreateChannel("DIO1/port5/line3", "", ChannelLineGrouping.OneChannelForEachLine);
            DOHold_Slider = new DigitalSingleChannelWriter(Hold_SliderTask.Stream);
            NationalInstruments.DAQmx.DaqSystem.Local.LoadDevice("DIO1").Reset();

            while (true)
            {
                if (DIAlarmSlider.ReadSingleSampleSingleLine())
                {
                    DOSvon_Slider.WriteSingleSampleSingleLine(true, true);
                    if (DISVRESlider.ReadSingleSampleSingleLine())
                    {
                        Thread.Sleep(500);
                        DOSetup_Slider.WriteSingleSampleSingleLine(true, true);
                        if (DIBusySlider.ReadSingleSampleSingleLine())
                        {
                            if (DICortinas.ReadSingleSampleSingleLine())
                            {
                                DOHold_Slider.WriteSingleSampleSingleLine(true, false);
                                continue;
                            }
                            else
                                DOHold_Slider.WriteSingleSampleSingleLine(true, true);
                        }
                        else if (DISetOn.ReadSingleSampleSingleLine() && DIINP.ReadSingleSampleSingleLine())
                        {
                            DOSvon_Slider.WriteSingleSampleSingleLine(true, false);
                            DOSetup_Slider.WriteSingleSampleSingleLine(true, false);
                            break;
                        }
                    }
                }
                else
                {
                    DOReset_Slider.WriteSingleSampleSingleLine(true, true);
                    Thread.Sleep(1500);
                    DOReset_Slider.WriteSingleSampleSingleLine(true, false);
                }
            }
            //Thread.Sleep(500);
            //DOReset_Slider.WriteSingleSampleSingleLine(true, true);
            //Thread.Sleep(1500);
            //DOReset_Slider.WriteSingleSampleSingleLine(true, false);
            //Thread.Sleep(1500);
            //DOSvon_Slider.WriteSingleSampleSingleLine(true, true);
            //Thread.Sleep(1500);
            //DOSetup_Slider.WriteSingleSampleSingleLine(true, true);
            //Thread.Sleep(1500);
            //while (true)
            //{
            //    if (DICortinas.ReadSingleSampleSingleLine())
            //    {
            //        DOHold_Slider.WriteSingleSampleSingleLine(true, false);
            //        if (DIAlarmSlider.ReadSingleSampleSingleLine())
            //        {
            //            if (DIBusySlider.ReadSingleSampleSingleLine())
            //            {
            //                DOSvon_Slider.WriteSingleSampleSingleLine(true, true);
            //                DOSetup_Slider.WriteSingleSampleSingleLine(true, true);

            //            }
            //            else
            //            {
            //                DOSvon_Slider.WriteSingleSampleSingleLine(true, false);
            //                DOSetup_Slider.WriteSingleSampleSingleLine(true, false);
            //                break;
            //            }

            //        }
            //        else
            //        {
            //            DOReset_Slider.WriteSingleSampleSingleLine(true, true);
            //            Thread.Sleep(1000);
            //            DOReset_Slider.WriteSingleSampleSingleLine(true, false);
            //        }
            //    }
            //    else
            //    {
            //        DOHold_Slider.WriteSingleSampleSingleLine(true, true);
            //    }
            //}
            Thread.Sleep(300);
            MoveToPosition(0);
            return true;
        }

        public static bool MoveToPosition(int position)//arreglo de bits que representa a cada posicion del slider.
        {
            DOSvon_Slider.WriteSingleSampleSingleLine(true,true);
            Thread.Sleep(500);
            Driver = new Task();
            Driver.DOChannels.CreateChannel("DIO1/port7", "", ChannelLineGrouping.OneChannelForAllLines);
            doDriver = new DigitalSingleChannelWriter(Driver.Stream);
            doDriver.WriteSingleSamplePort(true, position);
            Thread.Sleep(500);
            
            while (true)
            {
               
                if (DICortinas.ReadSingleSampleSingleLine())
                {
                    DOHold_Slider.WriteSingleSampleSingleLine(true, false);
                    DODriver_Slider.WriteSingleSampleSingleLine(true, true);
                    Thread.Sleep(500);
                    if (DIBusySlider.ReadSingleSampleSingleLine())
                    {
                        DODriver_Slider.WriteSingleSampleSingleLine(true, true);
                        DOSvon_Slider.WriteSingleSampleSingleLine(true, true);
                    }
                    else
                    {
                        DODriver_Slider.WriteSingleSampleSingleLine(true, false);
                        DOSvon_Slider.WriteSingleSampleSingleLine(true, false);
                        break;
                    }

                }
                else
                    DOHold_Slider.WriteSingleSampleSingleLine(true, true);
            }
            DOSvon_Slider.WriteSingleSampleSingleLine(true, false);
            DODriver_Slider.WriteSingleSampleSingleLine(true, false);
            return true;
        }
        
    }
}

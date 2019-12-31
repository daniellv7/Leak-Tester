using System;
using System.Collections.Generic;
using EpsonTMU220;
using System.IO.Ports;
using NationalInstruments.DAQmx;
using System.Windows.Forms;
using Zamtest.Cognex.DMXX;
using NationalInstruments.ModularInstruments.NIDmm;
using AVT;
using AVT.Enums;
using AVT.CAN;
using AVT.CAN.Enums;
using Zamtest.Generic.RS232;
using System.Diagnostics;
using Zamtest.Keyence.SR;
namespace SSR
{
    public class Instruments
    {
        //private static Instruments singleton = null;
        //private static readonly object padlock = new object();

        //public static Instruments Singleton
        //{
        //    get
        //    {
        //        lock (padlock)
        //        {
        //            if (singleton == null)
        //                singleton = new Instruments();
        //            return singleton;
        //        }
        //    }
        //}

        internal epsonTMU220 epson;
        internal Scanner scanner;
        internal RS232 rs232;
        //internal NIDmm dmm;
        //internal KeithleySerial keithley;
        //internal AVT852 avt;
        //internal Frame canFrame;
        //internal CANBus can0;
        //AGREGAR METODO PARA INICIAR TAREAS DE CADA ESTACION!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        public Result InitInstruments(Dictionary<string, TestForm.InstrParam> instr, Form f)
        {
            
            foreach (/*KeyValuePair<string, TestForm.InstrParam> instr in instruments*/KeyValuePair<string, TestForm.InstrParam> instrTemp in instr)
            {
                switch (instrTemp.Value.assembly)
                {
                    case "NationalInstruments.DAQmx.dll":
                        {
                            try
                            {
                                DaqSystem.Local.LoadDevice(instrTemp.Value.port).Reset();
                                break;
                            }
                            catch (DaqException)
                            {
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                            }
                        }
                    case "EpsonTMU220.dll":
                        {
                            string[] attributes = instrTemp.Value.attributes.Split(',');
                            epson = epsonTMU220.Instance;
                            if (!epson.Open(instrTemp.Value.port, Convert.ToInt32(attributes[0]), (Parity)Enum.Parse(typeof(Parity), attributes[1]), Convert.ToInt32(attributes[2]), (StopBits)Enum.Parse(typeof(StopBits), attributes[3]), (Handshake)Enum.Parse(typeof(Handshake), attributes[4])))
                            {
                                //WriteLog(richTextBoxDUTTrace, "There was an error while trying to initialize " + instr.Key, TraceLevel.Error);
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                            }
                            break;
                        }
                    case "Zamtest.Keyence.SR.dll":
                        {
                            scanner = new Scanner();
                            if(!scanner.Connect(instrTemp.Value.port, 9004))
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                            break;
                        }
                    
                    case "Zamtest.Generic.RS232.dll":
                        {
                            try
                            {
                                Debug.WriteLine(f.Name);
                                rs232 = new RS232();
                                if(!rs232.OpenDevice(instrTemp.Value.port))
                                    return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                                break;
                                //avt = new AVT852();
                                //can0 = avt.CAN0;
                                //if (avt.Utility.Connect(instr.Value.port))
                                //{
                                //    avt.Utility.Reset();
                                //    if (avt.Utility.SwitchMode(BusMode.CAN))
                                //    {
                                //        avt.Utility.SetSecondaryMode(SecondaryBus.DisableAll);
                                //        can0.QueryOperationalMode();
                                //        can0.SetSpeed(BaudRate.CAN_500Kbps);
                                //        can0.Filters.SetIDMaskMode(IDMaskMode.Mode4);
                                //        can0.Filters.SetAcceptanceID(0, new byte[] { 0x07, 0xff });
                                //        can0.Filters.SetMask(0, new byte[] { 0x07, 0xff });
                                //        can0.SetOperationalMode(AVT.CAN.Enums.OperationMode.Normal);
                                //    }
                                //}
                                //else
                                //    return false;

                                ////avt.CAN0.Send("", "");
                                ////canFrame = avt.Events.CAN.GetByID(0x200, AVT.Enums.Channel.CAN_0, 5000);
                                ////avt.Utility.Disconnect();
                                //break;
                            }
                            catch (Exception)
                            {
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                            }
                        }
                    //case "NationalInstruments.ModularInstruments.NIDmm.Fx40.dll":
                    //    {
                    //        dmm = new NIDmm(instr.Value.port, true, true, "");
                    //        dmm.ConfigureMeasurementDigits(DmmMeasurementFunction.DCCurrent, DmmAuto.Auto, 0.001);
                    //        dmm.Calibration.SelfCalibrate();
                    //        break;
                        //}
                }
            }
            return new Result { Failed = false, Message = "Hecho" };
        }

        public void CloseInstruments()
        {
            try
            {
                
                
                if (rs232 != null)
                {
                    rs232.CloseDevice();
                    rs232 = null;
                }
                //if (dmm != null)
                //{
                //    dmm.Dispose();
                //    keithley = null;
                //}
                //if(avt != null)
                //{
                //    avt = null;
                //    can0 = null;
                //    canFrame = null;
                //}
                DaqSystem.Local.LoadDevice("DIO1").Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool ResetInstruments()
        {
            //if (keithley != null)
            //{
            //    keithley.Send("*RST\n");
            //}
            return true;
        }
    }
}

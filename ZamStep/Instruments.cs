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

        public Result InitInstruments(Dictionary<string, TestForm.InstrParam> instr, Form f)
        {
            
            foreach (KeyValuePair<string, TestForm.InstrParam> instrTemp in instr)
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
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
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
                            }
                            catch (Exception)
                            {
                                return new Result { Failed = true, Message = $"REVISE {instrTemp.Value.port}" };
                            }
                        }
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

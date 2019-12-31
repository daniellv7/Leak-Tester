using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using NationalInstruments.DAQmx;
using Zamtest.Cognex.DMXX;
using Zamtest.PEMicro.CycloneUniversal;
using Zamtest.Keysight.E3644A;
using System.Windows.Forms;
using System.Timers;
using System.Text;
using CL_200A_LIB;
using Zamtest.Generic.RS232;

namespace SSR
{
    class Sequence
    {
        private TestForm form;

        public Sequence(TestForm DUTForm)
        {
            this.form = DUTForm;
        }

        public bool InitInstruments()
        {
            return true;
        }
        //private enum CHASSIS_BOARDS
        //{
        //    PXI_6365 = 1,
        //    PXI_6254,
        //    PXI_4065

        //}

        string result;
        double resultTemp;
        //internal Task Paro;
        //internal DigitalSingleChannelReader DIParo;


        public object[] SetDigitalOutput()
        {

            if (form.Test[form.testCounter].response == "close")
            {

                MDIPrincipal.Singleton.setDigitalOutput.setDOSignals(form.Signal[form.Test[form.testCounter].param].relay, true);
                Thread.Sleep(50);
                //MDIPrincipal.Singleton.setDigitalOutput.setDOSignals(form.Signal[form.Test[form.testCounter].param].relay, false);
            }

            else
            {
                MDIPrincipal.Singleton.setDigitalOutput.setDOSignals(form.Signal[form.Test[form.testCounter].param].relay, false);
                Thread.Sleep(50);

            }
            return new object[] { true, "Digital Output Set" };
        }

        public object[] ReadDigitalInput()
        {
            bool statusExpected = Convert.ToBoolean(form.Test[form.testCounter].response);
            //bool status = MDIPrincipal.Singleton.readDigitalInput.readDISignals(form.Signal[form.Test[form.testCounter].param].relay);
            if (statusExpected)
            {
                return new object[] { true, "Successful digital read" };
            }
            else
            {
                return new object[] { true, "Fail in digital read" };
            }
        }

        public object[] ReadRS232()
        {
            form.InstrumentsInstance.rs232.buffer.Clear();
            form.InstrumentsInstance.rs232.response = null;
            form.InstrumentsInstance.rs232.Response = null;
            bool r = form.InstrumentsInstance.rs232.SendCommand("");
            if (!r)
            {
                // Error
                return new object[] { false, "Bad response." };
            }
            do
            {
            }
            while (form.InstrumentsInstance.rs232.Response == null);
            string[] leak = {""};
            string[] leak2 = {""};
            //if (leak2[1] != "ACK,\n")
            //{
            //    string temp = leak2[1].Replace("mbar", "")/*.Replace("Pa", "")*/;
            //    resultTemp = Convert.ToDouble(temp);
            //}
            //else
            //{
            //    resultTemp = 0;
            //}
            try
            {
                leak = form.InstrumentsInstance.rs232.Response.Split('(');
                if (leak[1].Contains(":"))
                {
                    leak2 = leak[1].Split(':');
                }
                else
                    return new object[] { false, "Response unexpected" };
                if (form.InstrumentsInstance.rs232.Response.Contains("(OK)"))
                {


                    string temp = leak2[1]/*.Replace("mbar", "")*/.Replace("Pa/s\r\n", "");
                    if (temp.Contains("Pa"))
                    {
                        resultTemp = Convert.ToDouble(temp);
                    }
                    if (leak[1].Contains("OK"))
                    {
                        result = "Leak magnitude ";
                        if (!Utils.Singleton.MathOperator[form.Test[form.testCounter].limit].Invoke(double.Parse(form.Test[form.testCounter].low), resultTemp, double.Parse(form.Test[form.testCounter].high)))
                        {
                            return new object[] { false, result + " " + temp + "Pa/s" };
                        }
                        else
                            return new object[] { true, result + " " + temp + "Pa/s" };
                    }
                    else if (leak[1].Contains("AL"))
                        result = "Alarm activated";
                    else if (leak[1].Contains("DR"))
                        result = "NOK Piece";
                    else if (leak[1].Contains("TD"))
                        result = "Over full scale";
                }
                else if (form.InstrumentsInstance.rs232.Response.Contains("(TD)"))
                    return new object[] { false, "Over full scale " + leak2[1] };

                return new object[] { false, " " + result + " " + leak2[1] };
            }
            catch (IndexOutOfRangeException)
            {
                return new object[] { false, "Pressure Low" };
            }

        }

        //    private string response = string.Empty;

        //    public object[] SetDigitalOutput()
        //    {
        //        if (form.Test[form.testCounter].response == "close")
        //        {

        //            MDIPrincipal.Singleton.setDigitalOutput.setDOSignals(form.Signal[form.Test[form.testCounter].param].relay, true);
        //            Thread.Sleep(50);
        //        }

        //        else
        //        {
        //            MDIPrincipal.Singleton.setDigitalOutput.setDOSignals(form.Signal[form.Test[form.testCounter].param].relay, false);
        //            Thread.Sleep(50);

        //        }
        //        return new object[] { true, "Digital Output Set" };
        //    }

        //public object[] ScanQRCodeModule()
        //{
        //    int counter = 0;
        //    while (counter < 5 && TestForm.barCode == "")
        //    {
        //        TestForm.barCode = Instruments.Singleton.scanner.Scan();
        //        counter++;
        //    }
        //    if (TestForm.barCode.Contains(MDIPrincipal.Singleton.selectedVariant))
        //        return new object[] { true, "QR Code ok, Code: " + TestForm.barCode };
        //    else
        //        return new object[] { false, "QR Code Incorrect, Code: " + TestForm.barCode };
        //}
        //    public object[] SendAndReadTramaCAN()
        //    {
        //        string[] tramaInfo = form.Test[form.testCounter].command.Split(',');
        //        string[] responseInfo = form.Test[form.testCounter].response.Split(',');
        //        Instruments.Singleton.avt.CAN0.Send(tramaInfo[0], tramaInfo[1]);
        //        Instruments.Singleton.canFrame = Instruments.Singleton.avt.Events.CAN.GetByID(Convert.ToUInt32(responseInfo[0]), AVT.Enums.Channel.CAN_0, 2000);
        //        if (responseInfo[1] == Instruments.Singleton.canFrame.Data)
        //            return new object[] { true, "Expected: " + responseInfo[1] + " Recived: " + Instruments.Singleton.canFrame.Data };
        //        else
        //            return new object[] { false, "Expected: " + responseInfo[1] + " Recived: " + Instruments.Singleton.canFrame.Data };
        //    }
        //    public object[] MeasAIVoltage()
        //    {
        //        int ElapsedTime = Convert.ToInt32(form.Test[form.testCounter].command);
        //        double meas = 0;
        //        int cycle = 0;
        //        double average = 0;
        //        Task measTask = new Task();
        //        measTask.AIChannels.CreateVoltageChannel(form.Signal[form.Test[form.testCounter].param].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AnalogSingleChannelReader AImeas = new AnalogSingleChannelReader(measTask.Stream);

        //        Stopwatch watcher = new Stopwatch();
        //        do
        //        {
        //            meas += AImeas.ReadSingleSample();
        //            cycle++;
        //        } while (watcher.ElapsedMilliseconds <= ElapsedTime);
        //        average = meas / cycle;
        //        if (!Utils.Singleton.MathOperator[form.Test[form.testCounter].limit].Invoke(double.Parse(form.Test[form.testCounter].low), average, double.Parse(form.Test[form.testCounter].high)))
        //        {
        //            measTask.Dispose();
        //            return new object[] { false, "Average: " + average.ToString("D4") };
        //        }
        //        else
        //        {
        //            measTask.Dispose();
        //            return new object[] { true, "Average: " + average.ToString("D4") };
        //        }
        //    }
        //    public object[] MeasCurrentDMM()
        //    {
        //        int ElapsedTime = Convert.ToInt32(form.Test[form.testCounter].command);
        //        double meas = 0;
        //        int cycle = 0;
        //        double average = 0;

        //        Stopwatch watcher = new Stopwatch();
        //        do
        //        {
        //            meas += Instruments.Singleton.dmm.Measurement.Read();
        //            cycle++;
        //        } while (watcher.ElapsedMilliseconds <= ElapsedTime);
        //        average = meas / cycle;
        //        if (!Utils.Singleton.MathOperator[form.Test[form.testCounter].limit].Invoke(double.Parse(form.Test[form.testCounter].low), average, double.Parse(form.Test[form.testCounter].high)))
        //            return new object[] { false, "Average: " + average.ToString("D4") };
        //        else
        //            return new object[] { true, "Average: " + average.ToString("D4") };
        //    }
    }
}
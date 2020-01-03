using System;
using System.Threading;
using NationalInstruments.DAQmx;

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

        string result;
        double resultTemp;

        public object[] SetDigitalOutput()
        {
            try
            {
                using (Task myTask = DaqSystem.Local.LoadTask(form.Signal[form.Test[form.testCounter].param].relay))
                {
                    DigitalSingleChannelWriter dscw = new DigitalSingleChannelWriter(myTask.Stream);
                    if (form.Test[form.testCounter].response == "close")
                        dscw.WriteSingleSampleSingleLine(false, true);
                    else
                        dscw.WriteSingleSampleSingleLine(false, true);
                }
                Thread.Sleep(50);
                return new object[] { true, "Digital Output Set" };
            }
            catch (Exception ex)
            {
                return new object[] { false, ex.ToString() };
            }
        }

        public object[] ToggleDigitalOutput()
        {
            try
            {
                using (Task myTask = DaqSystem.Local.LoadTask(form.Signal[form.Test[form.testCounter].param].value))
                {
                    DigitalSingleChannelWriter dscw = new DigitalSingleChannelWriter(myTask.Stream);
                    dscw.WriteSingleSampleSingleLine(false, true);
                    Thread.Sleep(20);
                    dscw.WriteSingleSampleSingleLine(false, false);
                    Thread.Sleep(20);
                }
                return new object[] { true, "Digital Output Set" };
            }
            catch(Exception ex)
            {
                return new object[] { false, ex.ToString() };
            }
        }

        public object[] ReadDigitalInput()
        {
            try
            {
                bool expectedStatus = Convert.ToBoolean(form.Test[form.testCounter].response);
                using (Task myTask = DaqSystem.Local.LoadTask(form.Signal[form.Test[form.testCounter].param].relay))
                {
                    DigitalSingleChannelReader dscr = new DigitalSingleChannelReader(myTask.Stream);
                    bool status = dscr.ReadSingleSampleSingleLine();
                    if (expectedStatus == status)
                        return new object[] { true, "Successful digital read" };
                    else
                        return new object[] { true, "Fail in digital read" };
                }
            }
            catch (Exception ex)
            {
                return new object[] { false, ex.ToString() };
            }
        }

        public object[] ReadRS232()
        {
            form.InstrumentsInstance.rs232.buffer.Clear();
            form.InstrumentsInstance.rs232.response = null;
            form.InstrumentsInstance.rs232.Response = null;
            if (form.InstrumentsInstance.rs232.SendCommand(""))
                return new object[] { false, "Bad response." };
            while (form.InstrumentsInstance.rs232.Response == null)
            {
                Thread.Sleep(0);
            }
            string[] leak = {""};
            string[] leak2 = {""};
            try
            {
                leak = form.InstrumentsInstance.rs232.Response.Split('(');
                if (leak[1].Contains(":"))
                {
                    leak2 = leak[1].Split(':');
                }
                else
                    return new object[] { false, "Unexpected response" };
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
    }
}
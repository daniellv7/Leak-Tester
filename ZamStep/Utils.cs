using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading;

namespace SSR
{
    public class Utils
    {
        private static Utils singleton = null;
        private static readonly object padlock = new object();

        public static Utils Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new Utils();
                    return singleton;
                }
            }
        }

        //public Dictionary<string, SignalParam> Signal = new Dictionary<string, SignalParam>();
        //public struct SignalParam
        //{
        //    public string type;
        //    public string channel;
        //    public string relay;
        //    public string value;
        //    public string description;
        //};

        //public Dictionary<string, InstrParam> Instrument = new Dictionary<string, InstrParam>();
        //public struct InstrParam
        //{
        //    public string port;
        //    public string attributes;
        //    public string assembly;
        //};

        //public Dictionary<string, TestParam> Test = new Dictionary<string, TestParam>();
        //public struct TestParam
        //{
        //    public string type;
        //    public string skip;
        //    public string limit;
        //    public string low;
        //    public string high;
        //    public string units;
        //    public string command;
        //    public string response;
        //    public string param;
        //    public string procedure;
        //};

        //public Dictionary<string, VariableParam> Variable = new Dictionary<string, VariableParam>();
        //public struct VariableParam
        //{
        //    public string value;
        //    public string description;
        //}

        public Dictionary<string, Func<double, double, double, bool>> MathOperator
        {
            get
            {
                return new Dictionary<string, Func<double, double, double, bool>>
                {
                    {"GTLT", GTLT},
                    {"GELE", GELE},
                    {"GT", GT},
                    {"LT", LT},
                    {"GE", GE},
                    {"LE", LE},
                    {"EQ", EQ},
                };
            }
        }

        private static bool GTLT(double num1, double num2, double num3)
        {
            if (num1 < num2 && num2 < num3)
                return true;
            return false;
        }

        private static bool GELE(double num1, double num2, double num3)
        {
            if (num1 <= num2 && num2 <= num3)
                return true;
            return false;
        }

        private static bool GT(double num1, double num2, double num3)
        {
            if (num1 < num2)
                return true;
            return false;
        }

        private static bool LT(double num1, double num2, double num3)
        {
            if (num1 > num2)
                return true;
            return false;
        }

        private static bool GE(double num1, double num2, double num3)
        {
            if (num1 <= num2)
                return true;
            return false;
        }

        private static bool LE(double num1, double num2, double num3)
        {
            if (num1 >= num2)
                return true;
            return false;
        }

        private static bool EQ(double num1, double num2, double num3)
        {
            if (num1 == num2)
                return true;
            return false;
        }

        public void SaveCountersWhenPassed(string nest)
        {
            //if (nest == "PCB1")
            //{
                Properties.Settings.Default.PCBTestedUnits++;
                Properties.Settings.Default.PCBPassedUnits++;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.PCBYield = Convert.ToDecimal(((decimal)Properties.Settings.Default.PCBPassedUnits / (decimal)Properties.Settings.Default.PCBTestedUnits) * 100);
            //}
            //else
            //{
            //    Properties.Settings.Default.PCB2TestedUnits++;
            //    Properties.Settings.Default.PCB2PassedUnits++;
            //    Properties.Settings.Default.Save();
            //    Properties.Settings.Default.PCB2Yield = Convert.ToDecimal(((decimal)Properties.Settings.Default.PCB2PassedUnits / (decimal)Properties.Settings.Default.PCB2TestedUnits) * 100);
            //}
            Properties.Settings.Default.Save();
        }

        public void SaveCountersWhenFailed(string nest)
        {
            //if (nest == "PCB1")
            //{
                Properties.Settings.Default.PCBTestedUnits++;
                Properties.Settings.Default.PCBFailedUnits++;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.PCBYield = Convert.ToDecimal(((decimal)Properties.Settings.Default.PCBPassedUnits / (decimal)Properties.Settings.Default.PCBTestedUnits) * 100);
            //}
            //else
            //{
            //    Properties.Settings.Default.PCB2TestedUnits++;
            //    Properties.Settings.Default.PCB2FailedUnits++;
            //    Properties.Settings.Default.Save();
            //    Properties.Settings.Default.PCB2Yield = Convert.ToDecimal(((decimal)Properties.Settings.Default.PCB2PassedUnits / (decimal)Properties.Settings.Default.PCB2TestedUnits) * 100);
            //}
            Properties.Settings.Default.Save();
        }
    }
}

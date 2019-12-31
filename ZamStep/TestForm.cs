using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;
using EpsonTMU220;
using NationalInstruments.DAQmx;
using ServerConnection;
using Logger;
using Zamtest.Cognex.DMXX;
using ITAC;
using Zamtest.Utilities.Itac;
namespace SSR
{
    public partial class TestForm : Form
    { 
        NationalInstruments.DAQmx.Task OutputTask;
        DigitalSingleChannelWriter Writer1;

        //OutputTask = new NationalInstruments.DAQmx.Task();
        //OutputTask.DOChannels.CreateChannel("Dev2/Port1/Line0", "", ChannelLineGrouping.OneChannelForEachLine);
        //Writer = new DigitalSingleChannelWriter(OutputTask.Stream);

        [DllImport("user32")]
        private static extern int GetSystemMenu(IntPtr hWnd, bool bRevert);

        [DllImport("user32")]
        private static extern bool DeleteMenu(int hMenu, int uPosition, int uFlags);
        private int s_SystemMenuHandle = 0;
        public Instruments InstrumentsInstance = new Instruments();
        public ManagementEventApplication eventsManager = ManagementEventApplication.Singleton;
        public Utils utilsInstance = new Utils();
        public XMLUtils xmlInstance = new XMLUtils();
        private Mutex mutexPassed = new Mutex();
        private Mutex mutexFailed = new Mutex();
        private const int ResultItem = 2;
        internal Color SKIPPED = Color.Blue;
        internal Color PASSED = Color.FromArgb(0, 192, 0);
        internal Color FAILED = Color.Red;
        internal Color WAITING = Color.Orange;
        internal Color TESTING = Color.Yellow;
        private Stopwatch elapsedTimeStopWatch;
        private TimeSpan elapsedTimeSpan;
        public int mState;
        public int mState2;
        //internal AutoResetEvent sync;
        public object[] testResult = new object[1];
        private object[] result = { };
        public static string barCode = string.Empty;
        internal int testCounter;
        private int failsCounter;
        private bool barCodeFlag = false;
        private bool invalidBarCode = false;
        private int isComplete = 0;
        private EnvironmentItac itac = new EnvironmentItac();
        private bool loop = true;
        public bool error = false;
        public bool threadSignal = false;
        public string[] seed;
        public string[] key;
        public string[] secret;
        public Thread LauncherSequence { get; set; }
        public bool IsRunning { get; set; }
        internal bool IsTerminated { get; set; }
        string fileToFaultNote;

        private delegate void SetControlPropertyCallBack(Control control, string property, object value);
        private delegate object GetFormPropertyCallBack(Form control, string property);
        private delegate void SetListViewItemValuesCallBack(ListView listView, int item, int subItem, string text, Color color);
        private delegate void SetListViewItemForeColorCallBack(ListView listView, int item, int subItem, Color foreColor);
        private delegate void ClearListViewItemsCallBack();
        private ClearListViewItemsCallBack clearListView;
        private delegate void ClearRichTextBoxCallBack();
        private ClearRichTextBoxCallBack clearRichTextBox;
        private delegate void SetElapsedTimeCallBack(string elapsed);
        private SetElapsedTimeCallBack setElapsedTime;
        private delegate void SetCountersTextCallBack();
        private SetCountersTextCallBack setTesterCounters;
        internal static string serialNumber = string.Empty;
        internal DMXX scanner;
        static string TesterId = Properties.Settings.Default.StationName;
        private string PartNumber = "";
        private string SerialNumberItac = "";
        private float cycleTime = 0;
        private string failName = "";
        private int statusItac = 0;
        bool Result = false;
        string[] tempString;
        string[] nestvalue;
        int COUNTER123 = 0;
        //var output = new Classes.TraceMessage();
        //iTACController controller_arv = new iTACController(TesterId, ref output);
        static Classes.TraceMessage output = new Classes.TraceMessage();
        //iTACController controller_arv = new iTACController(TesterId, ref output);
        List<Classes.Failure> failures = new List<Classes.Failure>();
        List<Classes.Measure> measurements = new List<Classes.Measure>();
        public bool IsNest1Running;
        public bool IsNest2Running;
        //
        // Summary:
        //     Gets an array of forms that represent the multiple-document interface (MDI) child
        //     forms that are parented to this form.
        //
        // Returns:
        //     An array of System.Windows.Forms.Form objects, each of which identifies one of
        //     this form's MDI child forms.
        public Form[] Sequencechildren { get; }

        private LogFile log;
        private serverConnection server = new serverConnection();

        ///*SEÑALES DE CONTROL AQUI*/
        //internal Task PistonOffTask, PistonOnTask, PresenciaTask, TapaCerradaTask, ParoTask;
        //internal AnalogSingleChannelReader AIPistonOff, AIPistonOn, AIPresencia, AITapaCerrada, AIParoEmergencia;

        ////OUTPUTS FOR CONTROL EQUIPMENT
        //internal Task InterlockTask, ElectrovalvulaTask;
        //internal DigitalSingleChannelWriter DOInterlock, DOElectrovalvula;

        //OUTPUTS FOR CONTROL EQUIPMENT
        internal Task GreenLight, RedLight, YellowLight, PistonON, PistonOFF, Start, Reset;
        internal DigitalSingleChannelWriter DOGreenLight, DORedLight, DOYellowLight, DOPistonON, DOPistonOFF, DOStart, DOReset;

        internal Task Paro, Optos, Pieza, Empaque, CarreraOFF, CarreraON, PiezaCorrecta, PiezaDefectuosa, Alarma, FinCiclo;
        internal DigitalSingleChannelReader DIParo, DIOptos, DIPieza, DIEmpaque, DICarreraOFF, DICarreraON, DIPiezaCorrecta, DIPiezaDefectuosa, DIAlarma, DIFinCiclo;



        public Dictionary<string, SignalParam> Signal = new Dictionary<string, SignalParam>();
        public struct SignalParam
        {
            public string type;
            public string channel;
            public string relay;
            public string value;
            public string description;
        };

        public Dictionary<int, TestParam> Test = new Dictionary<int, TestParam>();
        public struct TestParam
        {
            public string name;
            public string type;
            public string skip;
            public string limit;
            public string low;
            public string high;
            public string units;
            public string command;
            public string response;
            public string param;
            public string procedure;
        };

        public Dictionary<string, VariableParam> Variable = new Dictionary<string, VariableParam>();
        public struct VariableParam
        {
            public string value;
            public string description;
        }

        public Dictionary<string, InstrParam> Instrument = new Dictionary<string, InstrParam>();

        public struct InstrParam
        {
            public string port;
            public string attributes;
            public string assembly;
        };


        public class TestCompletedEventArgs : EventArgs
        {
            public bool IsAllOk
            {
                get; set;
            }
        }

        public delegate void TestCompletedEventDelegate(object sender, TestCompletedEventArgs e);
        public event TestCompletedEventDelegate TestCompleted;
        public void ContinueTesting() { _continueFlag = true; }
        public void PauseTesting() { _continueFlag = false; }
        public bool WaitForContinueOrder = false;
        public bool _continueFlag = true;

        private void DisableXButton()
        {
            s_SystemMenuHandle = GetSystemMenu(Handle, false);
            DeleteMenu(s_SystemMenuHandle, 6, 1024);
        }

        private void EnableX()
        {
            s_SystemMenuHandle = GetSystemMenu(Handle, true);
            DeleteMenu(s_SystemMenuHandle, 6, 1024);
        }

        public TestForm()
        {
            InitializeComponent();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            clearListView = new ClearListViewItemsCallBack(ClearListView);
            clearRichTextBox = new ClearRichTextBoxCallBack(ClearRichTextBox);
            setElapsedTime = new SetElapsedTimeCallBack(SetElapsedTime);
            setTesterCounters = new SetCountersTextCallBack(SetTesterCounters);
            DisableXButton();
            CreateListView();
            IsTerminated = false;
            IsRunning = false;
            //sync = new AutoResetEvent(false);
            //Thread.CurrentThread.Name = Name + " thread";
            LoadDictionaries();
            //StateMachineThread = new Thread(new ThreadStart(StateMachine));

            eventsManager.log.Info(this.Name + " loaded successfully");
            //Launcher = new Thread(new ThreadStart(timerStateMachine_Tick));
        }

        public enum State : int
        {
            INITIALIZATION = 0,
            HOME,
            REMOVE_PIECE,
            PLACE_PIECE,
            PACKAGE,
            SCAN,
            ITAC,
            OPTOS,
            PISTON_ON,
            TEST,
            WAITING,
            RESULTS,
            PARO
        }

            //IsTerminated = true;
            //matar hilo y esperarlo
            //int counter = 0;
            //while (IsRunning)
            //{
            //    while (IsNest1Running)
            //    {
            //        switch(mState)
            //        {
            //            case 0:
            //                SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INICIADO 1 " + counter.ToString());
            //                SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //                break;
            //        }

            //        counter++;
            //    }
            //    while (IsNest2Running)
            //    {
            //        switch (mState2)
            //        {
            //            case 0:
            //                SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INICIADO 2 " + counter.ToString());
            //                SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //                break;
            //        }
            //        //Debug.WriteLine(Thread.CurrentThread.Name + " " + counter.ToString());
            //        //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INICIADO 2 " + counter.ToString());
            //        //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //        counter++;
            //        //MDIPrincipal.Singleton.SetControlsStateWhenStopped();
            //    }
            //    while (IsNest3Running)
            //    {
            //        switch (mState3)
            //        {
            //            case 0:
            //                SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INICIADO 2 " + counter.ToString());
            //                SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //                break;
            //        }
            //        //Debug.WriteLine(Thread.CurrentThread.Name + " " + counter.ToString());
            //        //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INICIADO 3 " + counter.ToString());
            //        //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", PASSED);
            //        counter++;
            //    }
            //}

        private void ClearControls()
        {
            listViewDUTSequence.Clear();
            richTextBoxDUTTrace.Clear();
        }

        private void CreateListView()
        {
            listViewDUTSequence.AllowColumnReorder = false;
            int listViewWidth = listViewDUTSequence.Width;
            listViewDUTSequence.Columns.Add("colTestNumber", "N°", 40);
            listViewDUTSequence.Columns.Add("colTestName", "Name", 200);
            listViewDUTSequence.Columns.Add("colTestStatus", "Status", -2);
            listViewDUTSequence.Columns[1].Width = listViewWidth - (listViewDUTSequence.Columns[0].Width +listViewDUTSequence.Columns[2].Width);
        }

        public void LoadDictionaries()
        {
            TestForm f = this;
            XMLUtils.Singleton.LoadSignalsToDictionary(this.Name, ref f);
            XMLUtils.Singleton.LoadTestsToDictionary(this.Name, ref f);
            XMLUtils.Singleton.LoadVariablesToDictionary(this.Name, ref f);
            XMLUtils.Singleton.LoadInstrumentsToDictionary(this.Name, ref f);
            xmlInstance.LoadSettings();
            InitializingSignals();
        }

        public void StartSequence()
        {
            isComplete = 1;
            Debug.WriteLine("Run Thread " + Name);
            TestForm f = this;
            barCodeFlag = true;
            invalidBarCode = false;
            elapsedTimeStopWatch = new Stopwatch();
            elapsedTimeSpan = new TimeSpan();
            log = new LogFile();
            loop = true;
            //barCode = string.Empty;
            f.Invoke(new Action(() => f.richTextBoxDUTTrace.Text = ""));
            //XMLUtils.Singleton.LoadSignalsToDictionary(this.Name, ref f);
            //XMLUtils.Singleton.LoadTestsToDictionary(this.Name, ref f);
            //XMLUtils.Singleton.LoadVariablesToDictionary(this.Name, ref f);
            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PROBANDO...");
            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            SetControlPropertyValue(labelStatusPiece, "Text", "ESPERANDO...");
            SetControlPropertyValue(labelStatusPiece, "BackColor", TESTING);

            Assembly currentAssembly = Assembly.GetExecutingAssembly();
            Type sequenceType = currentAssembly.GetType("SSR.Sequence");
            object assemblyInstance = Activator.CreateInstance(sequenceType, this);


            //if (!DIParo.ReadSingleSampleSingleLine())
            //{
            //    DOReset.WriteSingleSampleSingleLine(true, true);
            //    mState = (int)estado.PARO;
            //}

            while (loop)
            {
                this.Invoke(setElapsedTime, new object[] { "" });
                this.Invoke(clearListView);
                this.Invoke(clearRichTextBox);
                testCounter = -1;
                failsCounter = 0;
                error = false;
                //TESTS START HERE!!!
                elapsedTimeStopWatch.Reset();
                elapsedTimeStopWatch.Start();
                if (Properties.Settings.Default.LogFileStatus)
                {
                    log.LogPath = Properties.Settings.Default.LogFileFolder;
                    log.LogSeparator = Properties.Settings.Default.LogFileSeparator;
                    log.CreateLogFile("[" + barCode.Replace("\r", "") + "]_" +  DateTime.Now.ToString("HH_mm_ss_fff") + ".txt");
                    log.WriteLogHeader(Properties.Settings.Default.LogFileProjectName, Properties.Settings.Default.LogFileTesterID, DateTime.Now, Properties.Settings.Default.LogFileHeaderFileds);
                    eventsManager.log.Info(this.Name + " loaded successfully");
                }
                foreach (KeyValuePair<int, TestParam> test in this.Test)
                {
                    MethodInfo methodToCall = sequenceType.GetMethod(test.Value.procedure);
                    testCounter++;
                    if (test.Value.skip == "1")
                    {
                        SetTestResultStatus(listViewDUTSequence, testCounter, ResultItem, "skipped", SKIPPED);
                        WriteLog(richTextBoxDUTTrace, test.Key + " skipped", TraceLevel.Info);
                        continue;
                    }
                    try
                    {
                        object[] result = (object[])methodToCall.Invoke(assemblyInstance, null);
                        if (!(bool)result[0])
                        {
                            failsCounter++;
                            int fails = Properties.Settings.Default.StopSequenceAfter;
                            if (failsCounter == Properties.Settings.Default.StopSequenceAfter)
                            {
                                SetTestResultStatus(listViewDUTSequence, testCounter, ResultItem, "failed", FAILED);
                                failName = test.Value.name;
                                if (Properties.Settings.Default.LogFileStatus)
                                {
                                    if (result.Length > 4)
                                    {
                                        log.WriteLogTestData(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), result[4].ToString(), test.Value.response, result[1].ToString(), result[2].ToString() });
                                        eventsManager.log.Info(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), result[4].ToString(), test.Value.response, result[1].ToString(), result[2].ToString() });
                                    }////////////////////////////////////////////////////
                                    else
                                    {
                                        log.WriteLogTestData(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString()});
                                        eventsManager.log.Info(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString() });
                                    }////////////////////////////////////////////////////
                                }
                                //PrintError(test.Value.procedure, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString());
                                data(test.Value.name, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString());
                                if (Properties.Settings.Default.TealStatus)
                                {
                                    if (!TealProcess(barCode, Properties.Settings.Default.TealLineID, Properties.Settings.Default.TealTesterID, 0, testCounter, testCounter.ToString() + " , " + test.Value.procedure + " , " + result[0].ToString() + " , " + test.Value.high.ToString() + " , " + test.Value.low.ToString()))
                                    {
                                        error = true;
                                        break;
                                    }
                                }
                                error = true;
                                WriteLog(richTextBoxDUTTrace, " " + result[1] + " failed", TraceLevel.Info);
                                break;
                            }
                        }
                        else
                        {
                            SetTestResultStatus(listViewDUTSequence, testCounter, ResultItem, "passed", PASSED);
                            if (Properties.Settings.Default.LogFileStatus)
                            {
                                if (result.Length > 4)
                                {
                                    log.WriteLogTestData(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), result[4].ToString(), test.Value.response, result[1].ToString(), result[2].ToString() });
                                    eventsManager.log.Info(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), result[4].ToString(), test.Value.response, result[1].ToString() });
                                }////////////////////////////////////////////////////
                                else
                                {
                                    log.WriteLogTestData(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString() });
                                    eventsManager.log.Info(new string[] { testCounter.ToString(), test.Value.name, test.Value.limit, test.Value.low, test.Value.high, result[0].ToString(), test.Value.command, test.Value.response, result[1].ToString() });
                                }////////////////////////////////////////////////////
                            }
                            WriteLog(richTextBoxDUTTrace, " " + result[1] + " passed", TraceLevel.Info);
                        }
                    }
                    catch (System.Reflection.TargetInvocationException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (MethodAccessException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (MissingFieldException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (MissingMethodException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (TargetException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                    catch (NullReferenceException ex)
                    {
                        MessageBox.Show(ex.Message + ex.InnerException);
                        eventsManager.log.Error(ex.Message);
                        return;
                    }
                }
                Error:
                log.FinalizeLogFile();
                //if (barCode != "")
                //{
                //    log.OverWriteSerialNumber(barCode);
                //}
                if (error)
                {
                    if (!barCodeFlag || invalidBarCode)
                    {
                        InstrumentsInstance.ResetInstruments();
                        elapsedTimeStopWatch.Stop();
                        elapsedTimeSpan = elapsedTimeStopWatch.Elapsed;
                        this.Invoke(setElapsedTime, new object[] { elapsedTimeSpan.ToString() });
                    }
                    else
                    {
                        //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "FALLÓ");
                        //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                        //Thread.Sleep(100);
                        elapsedTimeStopWatch.Stop();
                        elapsedTimeSpan = elapsedTimeStopWatch.Elapsed;
                        this.Invoke(setElapsedTime, new object[] { elapsedTimeSpan.ToString() });
                        utilsInstance.SaveCountersWhenFailed(Thread.CurrentThread.Name);
                        this.Invoke(setTesterCounters);
                        MDIPrincipal.Singleton.loteStatus++;
                        if (Properties.Settings.Default.LogFileStatus)
                        {
                            log.OverWriteFileNameWithTestResult(serialNumber, false);
                            log.OverWriteTestTime(elapsedTimeSpan.ToString());
                        }
                        //if(f is TestForm)
                        //{
                        //    ((TestForm)f).Signal.Clear();
                        //    ((TestForm)f).Test.Clear();
                        //    ((TestForm)f).Variable.Clear();
                        //}
                        //mState = 9;
                        break;
                    }
                }
                else
                {
                    if (Properties.Settings.Default.TealStatus)
                    {
                        if (!TealProcess(barCode, Properties.Settings.Default.TealLineID, Properties.Settings.Default.TealTesterID, 1, -1, "NA"))
                        {
                            error = true;
                            goto Error;
                        }
                    }
                    //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASÓ");
                    //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", PASSED);
                    //Thread.Sleep(3000);
                    elapsedTimeStopWatch.Stop();
                    elapsedTimeSpan = elapsedTimeStopWatch.Elapsed;
                    this.Invoke(setElapsedTime, new object[] { elapsedTimeSpan.ToString() });
                    utilsInstance.SaveCountersWhenPassed(Thread.CurrentThread.Name);
                    this.Invoke(setTesterCounters);
                    if (Properties.Settings.Default.LogFileStatus)
                    {
                        log.OverWriteFileNameWithTestResult(serialNumber, true);
                        log.OverWriteTestTime(elapsedTimeSpan.ToString());
                    }
                    //if (f is TestForm)
                    //{
                    //    ((TestForm)f).Signal.Clear();
                    //    ((TestForm)f).Test.Clear();
                    //    ((TestForm)f).Variable.Clear();
                    //}
                   
                    break;
                }
            }
            cycleTime = elapsedTimeStopWatch.ElapsedMilliseconds;
            isComplete = 2;
        }

        public string data (string testName, string read, string command, string response, string received)
        {
            fileToFaultNote = "Date: " + string.Format("{0:dd/MMMM/yyyy_HH:mm:ss}", DateTime.Now) + "\n"
            + "Tester ID: " + Properties.Settings.Default.TealTesterID + "\n"
            + "Serial number: " + barCode + "\n"
            + "Nest: " + this.Name + "\n"
            + "Test number: " + (testCounter - 1) + "\n"
            + "Test name: " + testName + "\n"
            + "Read: " + read + "\n"
            + "Command: " + command + "\n"
            + "Response: " + response + "\n"
            + "Received: " + received;

            return fileToFaultNote;
        }

        private void PrintError(string testName, string limit, string low, string high, string read, string command, string response, string received)
        {
            InstrumentsInstance.epson.PrintData("======================================\n"
                + "Date: " + string.Format("{0:dd/MMMM/yyyy_HH:mm:ss}", DateTime.Now) + "\n"
                + "Tester ID: " + Properties.Settings.Default.TealTesterID + "\n"
                + "Serial number: " + barCode + "\n"
                + "Nest: " + this.Name + "\n"
                + "======================================\n"
                + "Test number: " + (testCounter - 1) + "\n"
                + "Test name: " + testName + "\n"
                + "Limit: " + limit + "\n"
                + "Low limit: " + low + "\n"
                + "High limit: " + high + "\n"
                + "Read: " + read + "\n"
                + "Command: " + command + "\n"
                + "Response: " + response + "\n"
                + "Received: " + received, epsonTMU220.PrintColor.Red);
        }

        public bool InitializingSignals()
        {
            try
            {
                ////OUTPUTS FOR CONTROL EQUIPMENT
                Reset = new Task();
                Reset.DOChannels.CreateChannel(Signal["RESET"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOReset = new DigitalSingleChannelWriter(Reset.Stream);

                Start = new Task();
                Start.DOChannels.CreateChannel(Signal["START"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOStart = new DigitalSingleChannelWriter(Reset.Stream);

                GreenLight = new Task();
                GreenLight.DOChannels.CreateChannel(Signal["LUZVERDE"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOGreenLight = new DigitalSingleChannelWriter(GreenLight.Stream);

                RedLight = new Task();
                RedLight.DOChannels.CreateChannel(Signal["LUZROJA"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DORedLight = new DigitalSingleChannelWriter(RedLight.Stream);

                YellowLight = new Task();
                YellowLight.DOChannels.CreateChannel(Signal["LUZAMBAR"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOYellowLight = new DigitalSingleChannelWriter(YellowLight.Stream);

                PistonOFF = new Task();
                PistonOFF.DOChannels.CreateChannel(Signal["PistonOFF"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOPistonOFF = new DigitalSingleChannelWriter(PistonOFF.Stream);

                PistonON = new Task();
                PistonON.DOChannels.CreateChannel(Signal["PistonON"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DOPistonON = new DigitalSingleChannelWriter(PistonON.Stream);

                Paro = new Task();
                Paro.DIChannels.CreateChannel(Signal["PARO"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DIParo = new DigitalSingleChannelReader(Paro.Stream);

                //Paro1 = new Task();
                //Paro1.DIChannels.CreateChannel(Signal["PARO"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                //DIParo1 = new DigitalSingleChannelReader(Paro1.Stream);

                //ParoN2 = new Task();
                //ParoN2.DIChannels.CreateChannel(Signal["DIO1/Port1/Line2"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                //DIParoN2 = new DigitalSingleChannelReader(ParoN2.Stream);

                Optos = new Task();
                Optos.DIChannels.CreateChannel(Signal["OPTOS"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DIOptos = new DigitalSingleChannelReader(Optos.Stream);

                Pieza = new Task();
                Pieza.DIChannels.CreateChannel(Signal["PIEZA"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DIPieza = new DigitalSingleChannelReader(Pieza.Stream);

                Empaque = new Task();
                Empaque.DIChannels.CreateChannel(Signal["EMPAQUE"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DIEmpaque = new DigitalSingleChannelReader(Empaque.Stream);

                CarreraOFF = new Task();
                CarreraOFF.DIChannels.CreateChannel(Signal["CarreraOFF"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DICarreraOFF = new DigitalSingleChannelReader(CarreraOFF.Stream);

                CarreraON = new Task();
                CarreraON.DIChannels.CreateChannel(Signal["CarreraON"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
                DICarreraON = new DigitalSingleChannelReader(CarreraON.Stream);

                return true;
            }
            catch (DaqException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //private bool InitializingSignals()
        //{
        //    try
        //    {
        //        ////OUTPUTS FOR CONTROL EQUIPMENT
        //        PistonOffTask = new Task();
        //        PistonOffTask.AIChannels.CreateVoltageChannel(Signal["SENSOR_PISTON_OFF"].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AIPistonOff = new AnalogSingleChannelReader(PistonOffTask.Stream);

        //        PistonOnTask = new Task();
        //        PistonOnTask.AIChannels.CreateVoltageChannel(Signal["SENSOR_PISTON_ON"].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AIPistonOn = new AnalogSingleChannelReader(PistonOnTask.Stream);

        //        PresenciaTask = new Task();
        //        PresenciaTask.AIChannels.CreateVoltageChannel(Signal["SENSOR_PRESENCIA"].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AIPresencia = new AnalogSingleChannelReader(PresenciaTask.Stream);

        //        TapaCerradaTask = new Task();
        //        TapaCerradaTask.AIChannels.CreateVoltageChannel(Signal["SENSOR_TAPA_CERRADA"].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AITapaCerrada = new AnalogSingleChannelReader(TapaCerradaTask.Stream);

        //        ParoTask = new Task();
        //        ParoTask.AIChannels.CreateVoltageChannel(Signal["PARO_EMERGENCIA"].relay, "", AITerminalConfiguration.Rse, -10, 10, AIVoltageUnits.Volts);
        //        AIParoEmergencia = new AnalogSingleChannelReader(ParoTask.Stream);

        //        ElectrovalvulaTask = new Task();
        //        ElectrovalvulaTask.DOChannels.CreateChannel(Signal["ELECTROVALVULA"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
        //        DOElectrovalvula = new DigitalSingleChannelWriter(ElectrovalvulaTask.Stream);

        //        InterlockTask = new Task();
        //        InterlockTask.DOChannels.CreateChannel(Signal["INTERLOCK"].relay, "", ChannelLineGrouping.OneChannelForEachLine);
        //        DOInterlock = new DigitalSingleChannelWriter(InterlockTask.Stream);

        //        return true;
        //    }
        //    catch (DaqException ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        return false;
        //    }
        //}

        private void CheckInitialState()
        {
            //DOInterlock.WriteSingleSampleSingleLine(true, true);
            //while (!DIPistonOff.ReadSingleSampleSingleLine())
            //{
            //    DOEVMain.WriteSingleSampleSingleLine(true, true);
            //    DOEVPiston.WriteSingleSampleSingleLine(true, false);
            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ACTIVANDO AIRE PRINCIPAL");
            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //}
            //while (!DIInterlockSensor.ReadSingleSampleSingleLine() && !DIPresenceSensor.ReadSingleSampleSingleLine())
            //{
            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "NO HAY PIEZA DENTRO DEL NIDO");
            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //    //DOInterlock.WriteSingleSampleSingleLine(true, true);
            //}
            //while (true)
            //{
            //    DOInterlock.WriteSingleSampleSingleLine(true, true);//Libero el interlock
            //    if (!DIPistonOff.ReadSingleSampleSingleLine()) //Verifica si el piston está contraído
            //        DOEVPiston.WriteSingleSampleSingleLine(true, false);
            //    if (!DIPresenceSensor.ReadSingleSampleSingleLine() && DIInterlockSensor.ReadSingleSampleSingleLine()) //Si el sensor de pieza no detecta y la compuerta no está cerrada
            //    {
            //        SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INSERTE UNA PIEZA Y CIERRE LA COMPUERTA");
            //        SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //    }
            //    else if (DIPresenceSensor.ReadSingleSampleSingleLine() && DIInterlockSensor.ReadSingleSampleSingleLine()) //Si la pieza es sensada y la compuerta no está cerrada
            //    {
            //        SetControlPropertyValue(labelDUTSequenceStatus, "Text", "CIERRE LA COMPUERTA");
            //        SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //    }
            //    else if (!DIPresenceSensor.ReadSingleSampleSingleLine() && !DIInterlockSensor.ReadSingleSampleSingleLine()) //Si la pieza no es sensada y la compuerta está cerrada
            //    {
            //        SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INSERTE UNA PIEZA");
            //        SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //    }
            //    else
            //    {
            //        DOInterlock.WriteSingleSampleSingleLine(true, false); //Anclo el interlock
            //        DORedLight.WriteSingleSampleSingleLine(true, false);
            //        DOGreenLight.WriteSingleSampleSingleLine(true, false);
            //        DOYellowLight.WriteSingleSampleSingleLine(true, true); //Enciendo la luz amarilla
            //        break;
            //    }
            //}
        }

        private bool ReadBarcode(string scanner)
        {
            barCode = string.Empty;
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    //if ("Flasher1" == scanner)
                    //    barCode = InstrumentsInstance.scanner.Scan();
                    //else
                    //    barCode = Instruments.Singleton.RightScanner.Scan();
                    if (!string.IsNullOrEmpty(barCode))
                        break;
                    Thread.Sleep(200);
                }
                if (string.IsNullOrEmpty(barCode))
                    return false;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //private object[] ActivatePiston()
        //{
            //try
            //{
            //    DOEVMain.WriteSingleSampleSingleLine(true, true);
            //    Thread.Sleep(100);
            //    DOEVPiston.WriteSingleSampleSingleLine(true, true);
            //    WriteLog(richTextBoxDUTTrace, "Activing piston", TraceLevel.Info);
            //    return new object[] { true, "Piston activated" };
            //}
            //catch (Exception ex)
            //{
            //    WriteLog(richTextBoxDUTTrace, "Piston cannot be activated -" + ex.Message, TraceLevel.Error);
            //    return new object[] { false, "Error activing piston" + ex.Message };
            //}
        //}

        private void CheckFinishStateWhenBarCodeFails()
        {

            //while (true)
            //{
            //    if (!barCodeFlag)
            //    {
            //        DOInterlock.WriteSingleSampleSingleLine(true, true);
            //        if (!DIPistonOff.ReadSingleSampleSingleLine())
            //            DOEVPiston.WriteSingleSampleSingleLine(true, false);
            //        if (DIPresenceSensor.ReadSingleSampleSingleLine() && !DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", " ERROR DE ETIQUETA, ABRA LA COMPUERTA Y RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //        }
            //        else if (DIPresenceSensor.ReadSingleSampleSingleLine() && DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR DE ETIQUETA, RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //        }
            //        else
            //        {
            //            DOYellowLight.WriteSingleSampleSingleLine(true, false);
            //            DORedLight.WriteSingleSampleSingleLine(true, true);
            //            DOInterlock.WriteSingleSampleSingleLine(true, false);
            //            //if (WaitForContinueOrder)
            //            //{
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASAR AL OTRO NIDO");
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //            //    if (this.TestCompleted != null)
            //            //        this.TestCompleted.Invoke(this, new TestCompletedEventArgs() { IsAllOk = false });
            //            //}
            //            return;
            //        }
            //    }
            //}
        }

        private void CheckFinishState()
        {
            //while (true)
            //{
            //    if (error)
            //    {
            //        DOYellowLight.WriteSingleSampleSingleLine(true, false);
            //        DORedLight.WriteSingleSampleSingleLine(true, true);
            //        DOInterlock.WriteSingleSampleSingleLine(true, true);
            //        DOEVPiston.WriteSingleSampleSingleLine(true, false);
            //        if (!DIPresenceSensor.ReadSingleSampleSingleLine() && !DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "FALLO, ABRA LA COMPUERTA Y RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //        }
            //        else if (DIPresenceSensor.ReadSingleSampleSingleLine() && !DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "FALLO, RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
            //        }
            //        else
            //        {
            //            //if (WaitForContinueOrder)
            //            //{
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASAR AL OTRO NIDO");
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //            //    if (this.TestCompleted != null)
            //            //        this.TestCompleted.Invoke(this, new TestCompletedEventArgs() { IsAllOk = false });
            //            //}
            //            return;
            //        }
            //    }
            //    else
            //    {
            //        DOYellowLight.WriteSingleSampleSingleLine(true, false);
            //        DOGreenLight.WriteSingleSampleSingleLine(true, true);
            //        DOInterlock.WriteSingleSampleSingleLine(true, true);
            //        DOEVPiston.WriteSingleSampleSingleLine(true, false);
            //        if (DIPresenceSensor.ReadSingleSampleSingleLine() && !DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASO, ABRA LA COMPUERTA Y RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", PASSED);
            //        }
            //        else if (DIPresenceSensor.ReadSingleSampleSingleLine() && DIInterlockSensor.ReadSingleSampleSingleLine())
            //        {
            //            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASO, RETIRE LA PIEZA");
            //            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", PASSED);
            //        }
            //        else
            //        {
            //            //if (WaitForContinueOrder)
            //            //{
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASAR AL OTRO NIDO");
            //            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
            //            //    if (this.TestCompleted != null)
            //            //        this.TestCompleted.Invoke(this, new TestCompletedEventArgs() { IsAllOk = true });
            //            //}
            //            return;
            //        }
            //    }
            //}
        }

        private void SetTestResultStatus(ListView listView, int item, int subItem, string text, Color color)
        {
            SetListViewSubItemValues(listView, item, subItem, text, color);
        }

        private void SetListViewSubItemValues(ListView listView, int item, int subItem, string text, Color color)
        {
            if (listView.InvokeRequired)
                listView.Invoke(new SetListViewItemValuesCallBack(SetListViewSubItemValues), new object[] { listView, item, subItem, text, color });
            else
            {
                listView.Items[item].SubItems[subItem].Text = text;
                listView.Items[item].SubItems[subItem].ForeColor = color;
                listView.Items[item].Focused = true;
                listView.Items[item].Selected = true;
                listView.EnsureVisible(item);
            }
        }

        private void SetTesterCounters()
        {
            //if (this.Text.Contains("PCB1"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCBTestedUnits.ToString();
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCBPassedUnits.ToString();
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCBFailedUnits.ToString();
            //    this.lblYieldDesc.Text = String.Format("{0:0.00}%", Properties.Settings.Default.PCBYield);
            //}
            //if (this.Text.Contains("PCB2"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB2TestedUnits.ToString();
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB2PassedUnits.ToString();
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB2FailedUnits.ToString();
            //    this.lblYieldDesc.Text = String.Format("{0:0.00}%", Properties.Settings.Default.PCB2Yield);
            //}
            //if (this.Text.Contains("PCB3"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB3TestedUnits.ToString();
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB3PassedUnits.ToString();
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB3FailedUnits.ToString();
            //    this.lblYieldDesc.Text = String.Format("{0:0.00}%", Properties.Settings.Default.PCB3Yield);
            //}
            //if (this.Text.Contains("PCB4"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB4TestedUnits.ToString();
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB4PassedUnits.ToString();
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB4FailedUnits.ToString();
            //    this.lblYieldDesc.Text = String.Format("{0:0.00}%", Properties.Settings.Default.PCB4Yield);
            //}
            //if (this.Text.Contains("PCB5"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB5TestedUnits.ToString();
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB5PassedUnits.ToString();
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB5FailedUnits.ToString();
            //    this.lblYieldDesc.Text = String.Format("{0:0.00}%", Properties.Settings.Default.PCB5Yield);
            //}
        }

        internal void SetControlPropertyValue(Control control, string property, object value)
        {
            if (control.InvokeRequired)
                control.Invoke(new SetControlPropertyCallBack(SetControlPropertyValue), new object[] { control, property, value });
            else
            {
                PropertyInfo pi = control.GetType().GetProperty(property);
                pi.SetValue(control, value, null);
            }   
        }

        private void SetElapsedTime(string elapsed)
        {
            toolStripStatusLabelElapsed.Text = elapsed;
        }

        private object GetFormPropertyValue(Form form, string property)
        {
            if (form.InvokeRequired)
            {
                return form.Invoke(new GetFormPropertyCallBack(GetFormPropertyValue), new object[] { form, property });
            }
            else
            {
                PropertyInfo pi = form.GetType().GetProperty(property);
                return pi.GetValue(form, null);
            }
        }

        private void SetResultRichTextBoxText(RichTextBox rText, string text)
        {
            if (rText.InvokeRequired)
                rText.BeginInvoke(new MethodInvoker(() => SetResultRichTextBoxText(rText, text)));
            else
            {
                rText.AppendText(text);
                rText.ScrollToCaret();
            }
        }

        private void timerStateMachine_Tick(object sender, EventArgs e)
        {
            //Application.DoEvents();
            
        }

        private void stateMachineTimer_Tick(object sender, EventArgs e)
        {
            //var output = new Classes.TraceMessage();
            //iTACController controller_arv = new iTACController(TesterId, ref output);
            //List<Classes.Failure> failures = new List<Classes.Failure>();
            //var measurements = new List<Classes.Measure>();
    
            if (IsRunning)
            {    
                if (!DIParo.ReadSingleSampleSingleLine())
                {
                    mState = (int)State.PARO;
                }
                
                switch (mState)
                {   
                    case 0: //Inicialización de instrumentos
                        Result result = InstrumentsInstance.InitInstruments(Instrument, this);
                        if (result.Failed)
                            mState = (int)State.HOME;
                        else
                        {
                            mState = (int)State.INITIALIZATION;
                            SetControlPropertyValue(labelDUTSequenceStatus, "Text", result.Message);
                            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
                        }
                        break;

                    case 1://Home       
                        if (DICarreraOFF.ReadSingleSampleSingleLine() && !DICarreraON.ReadSingleSampleSingleLine())
                        {
                            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
                            DOPistonOFF.WriteSingleSampleSingleLine(true, true);
                            DOPistonON.WriteSingleSampleSingleLine(true, false);
                            mState = (int)State.REMOVE_PIECE;
                            //Thread.Sleep(50);
                        }
                        else
                        {
                            DOPistonOFF.WriteSingleSampleSingleLine(true, true);
                            DOPistonON.WriteSingleSampleSingleLine(true, false);
                        }
                        break;

                    case 2: //Retirar pieza
                        if (!DIPieza.ReadSingleSampleSingleLine())
                        {
                            toolStripStatusSerial.Text = "";
                            toolStripStatusLabelElapsed.Text = "";
                            SetControlPropertyValue(richTextBoxDUTTrace, "Text", "");
                            SetControlPropertyValue(labelStatusPiece, "Text", "ESPERANDO...");
                            SetControlPropertyValue(labelStatusPiece, "BackColor", TESTING);
                            mState = (int)State.PLACE_PIECE;
                        }
                        else
                        {
                            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "RETIRE PIEZA");
                            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
                        }
                        break;

                    case 3: //Poner pieza
                        if (!DIPieza.ReadSingleSampleSingleLine())
                        {
                            mState = (int)State.PLACE_PIECE;
                            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "INSERTE PIEZA");
                            SetControlPropertyValue(labelStatusPiece, "Text", "ESPERANDO...");
                            SetControlPropertyValue(labelStatusPiece, "BackColor", TESTING);
                        }
                        else if (DIPieza.ReadSingleSampleSingleLine())
                            mState = (int)State.OPTOS;
                        break;


                    
                    case 5: //Escanner
                        {
                            barCode = "";
                            //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ESCANEANDO CODIGO");
                            int i = 0;
                            do
                            {
                                InstrumentsInstance.scanner.Scan();
                                if (!InstrumentsInstance.scanner.Response.Contains("ERROR"))
                                    serialNumber = InstrumentsInstance.scanner.Response;
                                i++;
                            } while (i < 5 && serialNumber == "");
                            if (serialNumber != "" && serialNumber.Contains("5"))
                            {
                                toolStripStatusSerial.Text = serialNumber;
                                barCode = serialNumber;
                                //scanner.Close();
                                mState = (int)State.ITAC;
                                break;
                            }
                            else
                            {
                                //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR EN ETIQUETA");
                                //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                SetControlPropertyValue(labelStatusPiece, "Text", "ERROR EN ETIQUETA");
                                SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                Thread.Sleep(3000);
                                mState = (int)State.REMOVE_PIECE;
                                break;
                            }
                        }
                    case 6:
                        {
                            if (Properties.Settings.Default.iTac)
                            {
                                nestvalue = this.Name.Split('T');
                                LauncherSequence = null;
                                DOYellowLight.WriteSingleSampleSingleLine(true, false);
                                tempString = serialNumber.Split('#');
                                lock (MDIPrincipal.Singleton.itac)
                                {
                                    if (MDIPrincipal.Singleton.itac.OpenConexion(EnvironmentItac.REGISTRATION_TYPE.STATION))
                                    {
                                        string[] code = serialNumber.Split('#');
                                        SerialNumberItac = code[0];
                                        PartNumber = code[0].Substring(0, 9);
                                        if (MDIPrincipal.Singleton.itac.CheckSerialNumberState(SerialNumberItac))
                                        {
                                            if (MDIPrincipal.Singleton.itac.CheckHistoryFromModule(SerialNumberItac, Variable["StationNumberBefore"].value, Variable["StationNumber"].value))
                                            {
                                                statusItac = 1;
                                                mState = (int)State.PISTON_ON;
                                            }
                                            else
                                            {
                                                SetControlPropertyValue(richTextBoxDUTTrace, "Text", "ERROR: " + MDIPrincipal.Singleton.itac.MessageItac);
                                                Application.DoEvents();
                                                mState = (int)State.HOME;
                                            }
                                        }
                                        else
                                        {
                                            SetControlPropertyValue(richTextBoxDUTTrace, "Text", "NO SE PUEDE PROBAR");
                                            mState = (int)State.HOME;
                                        }
                                    }
                                    else
                                    {
                                        //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR ITAC");
                                        //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                        SetControlPropertyValue(labelStatusPiece, "Text", "ERROR ITAC");
                                        SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                        Thread.Sleep(2000);
                                        mState = (int)State.HOME;
                                    }
                                    MDIPrincipal.Singleton.itac.CloseConexion();
                                }
                            }
                            else
                            {
                                statusItac = 1;
                                mState = (int)State.PISTON_ON;
                            }
                            break;
                        }
                    case 7: //Optos
                        {
                            if (!DIPieza.ReadSingleSampleSingleLine())
                            {
                                mState = (int)State.PLACE_PIECE;
                                break;
                            }
                            if (!DIOptos.ReadSingleSampleSingleLine())
                            {
                                SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PRESIONE OPTOS CONTINUAMENTE");
                                mState = (int)State.OPTOS;
                                break;
                            }
                            else
                            {
                                if (statusItac == 0)
                                    mState = (int)State.SCAN;
                                else
                                    mState = (int)State.PISTON_ON;
                                break;
                            }
                        }
                    case 8: //Piston ON
                        {
                            if (DIOptos.ReadSingleSampleSingleLine())
                            {
                                if (DICarreraOFF.ReadSingleSampleSingleLine() && !DICarreraON.ReadSingleSampleSingleLine())
                                {
                                    DOPistonON.WriteSingleSampleSingleLine(true, true);
                                    DOPistonOFF.WriteSingleSampleSingleLine(true, false);
                                    break;
                                }
                                else if (!DICarreraOFF.ReadSingleSampleSingleLine() && !DICarreraON.ReadSingleSampleSingleLine())
                                    break;
                                else
                                {
                                    
                                    mState = (int)State.TEST;
                                    break;
                                }
                            }
                            else
                            {
                                DOPistonON.WriteSingleSampleSingleLine(true, false);
                                DOPistonOFF.WriteSingleSampleSingleLine(true, true);
                                mState = (int)State.OPTOS;
                                break;
                            }
                        }
                    case 9: //Test
                        {
                            DOGreenLight.WriteSingleSampleSingleLine(true, false);
                            DORedLight.WriteSingleSampleSingleLine(true, false);
                            DOYellowLight.WriteSingleSampleSingleLine(true, true);
                            //Thread.Sleep(1000);
                            Thread.SpinWait(100);
                            //DOPistonON.WriteSingleSampleSingleLine(true, true);
                            //tempString = serialNumber.Split('#');
                            //var interlock = controller_arv.Interlocking(tempString[0], ref output);
                            //if (interlock == Enums.SerialState.PASS)
                            //{
                                if (DICarreraON.ReadSingleSampleSingleLine() && !DICarreraOFF.ReadSingleSampleSingleLine())
                                {
                                    //LauncherSequence.Start();
                                    LauncherSequence = new Thread(new ThreadStart(StartSequence));
                                    LauncherSequence.Name = this.Name + " Sequence";
                                    Thread.Sleep(80);
                                    LauncherSequence.Start();
                                    Debug.WriteLine(LauncherSequence.ThreadState.ToString());
                                    //StartSequence();
                                    //Application.DoEvents();
                                    mState = (int)State.WAITING;
                                }
                                else
                                {
                                    //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR AL INICIAR SECUENCIA");
                                    //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                    SetControlPropertyValue(labelStatusPiece, "Text", "ERROR AL INICIAR SECUENCIA");
                                    SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                    mState = (int)State.HOME;
                                }
                            //}
                            //else
                            //{
                            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "VERIFICAR SERIAL EN ITAC");
                            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                            //    mState = (int)estado.HOME;
                            //}
                            break;
                        }
                    case 10://VACIO
                        {
                            if (isComplete == 1)
                            {
                                break;
                            }
                            else
                            {
                                mState = (int)State.RESULTS;
                            }
                            //DOStart.WriteSingleSampleSingleLine(true, false);
                            
                        }
                        break;

                    case 11: //Resultados
                        {

                            DOReset.WriteSingleSampleSingleLine(true, true);
                            Thread.Sleep(50);
                            DOReset.WriteSingleSampleSingleLine(true, false);
                            LauncherSequence = null;
                            isComplete = 0;
                            statusItac = 0;
                            InstrumentsInstance.ResetInstruments();
                            if (Properties.Settings.Default.iTac)
                            {
                                lock (MDIPrincipal.Singleton.itac)
                                {
                                    if (MDIPrincipal.Singleton.itac.OpenConexion(EnvironmentItac.REGISTRATION_TYPE.STATION))
                                    {
                                        if (error)
                                        {
                                            DOGreenLight.WriteSingleSampleSingleLine(true, false);
                                            DORedLight.WriteSingleSampleSingleLine(true, true);
                                            DOYellowLight.WriteSingleSampleSingleLine(true, false);
                                            //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "FALLÓ");
                                            //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                            SetControlPropertyValue(labelStatusPiece, "Text", "FALLÓ");
                                            SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                            //if (MDIPrincipal.Singleton.itac.UploadState(PartNumber, SerialNumberItac, 1, cycleTime))
                                            //{
                                            //if (MDIPrincipal.Singleton.itac.UploadFailureAndResultData(PartNumber, 1, cycleTime, SerialNumberItac, "NEST", nestvalue.ToString(), 0, "", failName, fileToFaultNote, ""))
                                            //{
                                            //mState = (int)estado.HOME;
                                            //}
                                            //else
                                            //{
                                            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR EN ITAC");
                                            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                            //    Thread.Sleep(2000);
                                            //    mState = (int)estado.HOME;
                                            //}
                                            //}
                                            //else
                                            //{
                                            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR EN ITAC");
                                            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                            Thread.Sleep(2000);
                                            mState = (int)State.HOME;
                                            //}
                                        }
                                        else
                                        {
                                            DOGreenLight.WriteSingleSampleSingleLine(true, true);
                                            DORedLight.WriteSingleSampleSingleLine(true, false);
                                            DOYellowLight.WriteSingleSampleSingleLine(true, false);
                                            //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PASÓ");
                                            //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", PASSED);
                                            SetControlPropertyValue(labelStatusPiece, "Text", "PASÓ");
                                            SetControlPropertyValue(labelStatusPiece, "BackColor", PASSED);
                                            if (MDIPrincipal.Singleton.itac.UploadState(PartNumber, SerialNumberItac, 0, cycleTime))
                                            {
                                                mState = (int)State.HOME;
                                            }
                                            else
                                            {
                                                //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR EN ITAC");
                                                //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                                SetControlPropertyValue(labelStatusPiece, "Text", "ERROR RN ITAC");
                                                SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                                mState = (int)State.HOME;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //SetControlPropertyValue(labelDUTSequenceStatus, "Text", "ERROR ITAC");
                                        //SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                                        SetControlPropertyValue(labelStatusPiece, "Text", "ERROR EN ITAC");
                                        SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);

                                    }
                                    MDIPrincipal.Singleton.itac.CloseConexion();
                                }
                            }
                            else
                            {
                                if (error)
                                {
                                    DOGreenLight.WriteSingleSampleSingleLine(true, false);
                                    DORedLight.WriteSingleSampleSingleLine(true, true);
                                    DOYellowLight.WriteSingleSampleSingleLine(true, false);
                                    SetControlPropertyValue(labelStatusPiece, "Text", "FALLÓ");
                                    SetControlPropertyValue(labelStatusPiece, "BackColor", FAILED);
                                    mState = (int)State.HOME;
                                }
                                else
                                {
                                    DOGreenLight.WriteSingleSampleSingleLine(true, true);
                                    DORedLight.WriteSingleSampleSingleLine(true, false);
                                    DOYellowLight.WriteSingleSampleSingleLine(true, false);
                                    SetControlPropertyValue(labelStatusPiece, "Text", "PASÓ");
                                    SetControlPropertyValue(labelStatusPiece, "BackColor", PASSED);
                                    mState = (int)State.HOME;
                                }
                            }
                            break;
                        }
                    

                    case 12: //Paro de emergencia
                        {
                            SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PARO DE EMERGENCIA");
                            SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                            DOPistonON.WriteSingleSampleSingleLine(true, false);
                            DOPistonOFF.WriteSingleSampleSingleLine(true, true);
                            //string name = Paro.DIChannels.All.VirtualName;
                            //if (name == "DIO1/Port1/Line2" && this.Name == "NEST1")
                            //{
                            //    SetControlPropertyValue(labelDUTSequenceStatus, "Text", "PARO DE EMERGENCIA");
                            //    SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", FAILED);
                            //    if (this.Name == "NEST1" && name == "DIO1/Port0/Line2")
                            //    {
                            //        LauncherSequence = null;
                            //        mState = 0;
                            //    }
                            //    InstrumentsInstance.CloseInstruments();
                            //    mState = 0;
                            //}
                            mState = (int)State.HOME;
                            break;
                        }
                }

            }
            else
            {
                Console.WriteLine($"Cerrando Form {Name}");
                Thread.Sleep(200);
                stateMachineTimer.Enabled = false;
                Signal.Clear();
                Test.Clear();
                Variable.Clear();
                SetControlPropertyValue(labelDUTSequenceStatus, "BackColor", WAITING);
                SetControlPropertyValue(labelDUTSequenceStatus, "Text", "DETENIDO");
                IsTerminated = true;
                InstrumentsInstance.CloseInstruments();
                //matar hilo y esperarlo
            }
        }

        private void ClearListView()
        {
            for (int i = 0; i < listViewDUTSequence.Items.Count; i++)
            {
                listViewDUTSequence.Items[i].SubItems[2].Text = string.Empty;
            }
        }

        private void ClearRichTextBox()
        {
            richTextBoxDUTTrace.Clear();
        }

        public void WriteLog(RichTextBox rText, string message, TraceLevel traceLevel)
        {

            switch (traceLevel)
            {
                case TraceLevel.Error:
                    {
                        SetResultRichTextBoxText(rText, DateTime.Now.ToString("[hh:mm:ss] ") + traceLevel.ToString().ToUpper() + " " + message + "\n");
                        break;
                    }
                default:
                    {
                        SetResultRichTextBoxText(rText, DateTime.Now.ToString("[hh:mm:ss] ") + " " + message + "\n");
                        break;
                    }
            }
        }

        private bool TealProcess(string barCode, string tealLineID, string tealTesterID, short passed, int failCode, string testString)
        {
            server.TealConnectionString = Properties.Settings.Default.TealConnectionString;
            server.TealStoredProcedure = Properties.Settings.Default.TealStoredProcedure;
            string[] data = new string[7];
            data[1] = barCode;
            data[2] = passed.ToString();
            data[3] = tealLineID;
            data[4] = tealTesterID;
            data[5] = failCode.ToString();
            data[6] = testString;
            for (int i = 0; i < 3; i++)
            {
                if (server.InsertTEALData(data) == 1)
                    return true;
            }
            return false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //if (this.Text.Contains("PCB1"))
            //{
            //    Properties.Settings.Default.PCBTestedUnits = 0;
            //    Properties.Settings.Default.PCBPassedUnits = 0;
            //    Properties.Settings.Default.PCBFailedUnits = 0;
            //    Properties.Settings.Default.PCBYield = 0;
            //    Properties.Settings.Default.Save();
            //}
            //if (this.Text.Contains("PCB2"))
            //{
            //    Properties.Settings.Default.PCB2TestedUnits = 0;
            //    Properties.Settings.Default.PCB2PassedUnits = 0;
            //    Properties.Settings.Default.PCB2FailedUnits = 0;
            //    Properties.Settings.Default.PCB2Yield = 0;
            //    Properties.Settings.Default.Save();
            //}
            //if (this.Text.Contains("PCB3"))
            //{
            //    Properties.Settings.Default.PCB3TestedUnits = 0;
            //    Properties.Settings.Default.PCB3PassedUnits = 0;
            //    Properties.Settings.Default.PCB3FailedUnits = 0;
            //    Properties.Settings.Default.PCB3Yield = 0;
            //    Properties.Settings.Default.Save();
            //}
            //if (this.Text.Contains("PCB4"))
            //{
            //    Properties.Settings.Default.PCB4TestedUnits = 0;
            //    Properties.Settings.Default.PCB4PassedUnits = 0;
            //    Properties.Settings.Default.PCB4FailedUnits = 0;
            //    Properties.Settings.Default.PCB4Yield = 0;
            //    Properties.Settings.Default.Save();
            //}
            //if (this.Text.Contains("PCB5"))
            //{
            //    Properties.Settings.Default.PCB5TestedUnits = 0;
            //    Properties.Settings.Default.PCB5PassedUnits = 0;
            //    Properties.Settings.Default.PCB5FailedUnits = 0;
            //    Properties.Settings.Default.PCB5Yield = 0;
            //    Properties.Settings.Default.Save();
            //}
            //LoadTestCounters();
        }

        private void LoadTestCounters()
        {
            //if (this.Text.Contains("PCB1"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCBTestedUnits.ToString() + "   [0%]";
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCBPassedUnits.ToString() + "   [0%]";
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCBFailedUnits.ToString() + "   [0%]";
            //    this.lblYieldDesc.Text = Properties.Settings.Default.PCBYield.ToString() + "   [0%]";
            //}
            //if (this.Text.Contains("PCB2"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB2TestedUnits.ToString() + "   [0%]";
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB2PassedUnits.ToString() + "   [0%]";
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB2FailedUnits.ToString() + "   [0%]";
            //    this.lblYieldDesc.Text = Properties.Settings.Default.PCB2Yield.ToString() + "   [0%]";
            //}
            //if (this.Text.Contains("PCB3"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB3TestedUnits.ToString() + "   [0%]";
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB3PassedUnits.ToString() + "   [0%]";
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB3FailedUnits.ToString() + "   [0%]";
            //    this.lblYieldDesc.Text = Properties.Settings.Default.PCB3Yield.ToString() + "   [0%]";
            //}
            //if (this.Text.Contains("PCB4"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB4TestedUnits.ToString() + "   [0%]";
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB4PassedUnits.ToString() + "   [0%]";
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB4FailedUnits.ToString() + "   [0%]";
            //    this.lblYieldDesc.Text = Properties.Settings.Default.PCB4Yield.ToString() + "   [0%]";
            //}
            //if (this.Text.Contains("PCB5"))
            //{
            //    this.lblTestedDesc.Text = Properties.Settings.Default.PCB5TestedUnits.ToString() + "   [0%]";
            //    this.lblGoodDesc.Text = Properties.Settings.Default.PCB5PassedUnits.ToString() + "   [0%]";
            //    this.lblBadDesc.Text = Properties.Settings.Default.PCB5FailedUnits.ToString() + "   [0%]";
            //    this.lblYieldDesc.Text = Properties.Settings.Default.PCB5Yield.ToString() + "   [0%]";
            //}
        }

        private void chkStatus_CheckedChanged(object sender, EventArgs e)
        {
            //if (this.Text.Contains("PCB1"))
            //{
            //    Properties.Settings.Default.PCBStatus = chkStatus.Checked;
            //    SetControlsStatus(this, chkStatus.Checked);
                //foreach (Form f in MDIPrincipal.Singleton.MdiChildren)
                //{
                //    if (f.Name == "Flasher2")
                //    {
                //        if (f is TestForm)
                //        {
                //            if (this.chkStatus.Checked && ((TestForm)f).chkStatus.Checked)
                //            {
                //                ((TestForm)f).chkStatus.Checked = false;
                //                SetControlsStatus((TestForm)f, false);
                //            }
                //        }
                //    }
                //}
            //}
            //if (this.Text.Contains("PCB2"))
            //{
            //    Properties.Settings.Default.PCB2Status = chkStatus.Checked;
            //    SetControlsStatus(this, chkStatus.Checked);
                //foreach (Form f in MDIPrincipal.Singleton.MdiChildren)
                //{
                //    if (f.Name == "Flasher1")
                //    {
                //        if (f is TestForm)
                //        {
                //            if (this.chkStatus.Checked && ((TestForm)f).chkStatus.Checked)
                //            {
                //                ((TestForm)f).chkStatus.Checked = false;
                //                SetControlsStatus((TestForm)f, false);
                //            }
                //        }
                //    }
                //}
            //}
            //if (this.Text.Contains("PCB3"))
            //{
            //    Properties.Settings.Default.PCB3Status = chkStatus.Checked;
            //    SetControlsStatus(this, chkStatus.Checked);
                //foreach (Form f in MDIPrincipal.Singleton.MdiChildren)
                //{
                //    if (f.Name == "Flasher1")
                //    {
                //        if (f is TestForm)
                //        {
                //            if (this.chkStatus.Checked && ((TestForm)f).chkStatus.Checked)
                //            {
                //                ((TestForm)f).chkStatus.Checked = false;
                //                SetControlsStatus((TestForm)f, false);
                //            }
                //        }
                //    }
                //}
            //}
            //if (this.Text.Contains("PCB4"))
            //{
            //    Properties.Settings.Default.PCB4Status = chkStatus.Checked;
            //    SetControlsStatus(this, chkStatus.Checked);
                //foreach (Form f in MDIPrincipal.Singleton.MdiChildren)
                //{
                //    if (f.Name == "Flasher1")
                //    {
                //        if (f is TestForm)
                //        {
                //            if (this.chkStatus.Checked && ((TestForm)f).chkStatus.Checked)
                //            {
                //                ((TestForm)f).chkStatus.Checked = false;
                //                SetControlsStatus((TestForm)f, false);
                //            }
                //        }
                //    }
                //}
            //}
            //if (this.Text.Contains("PCB5"))
            //{
            //    Properties.Settings.Default.PCB5Status = chkStatus.Checked;
            //    SetControlsStatus(this, chkStatus.Checked);
                //foreach (Form f in MDIPrincipal.Singleton.MdiChildren)
                //{
                //    if (f.Name == "Flasher1")
                //    {
                //        if (f is TestForm)
                //        {
                //            if (this.chkStatus.Checked && ((TestForm)f).chkStatus.Checked)
                //            {
                //                ((TestForm)f).chkStatus.Checked = false;
                //                SetControlsStatus((TestForm)f, false);
                //            }
                //        }
                //    }
                //}
            //}
            //Properties.Settings.Default.Save();
        }

        private void SetControlsStatus(TestForm form, bool status)
        {
            form.listViewDUTSequence.Enabled = status;
            form.richTextBoxDUTTrace.Enabled = status;
            //form.btnReset.Enabled = status;
        }
    }
}

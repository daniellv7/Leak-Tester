using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using NationalInstruments.ModularInstruments.NISwitch;
using NationalInstruments.DAQmx;
using System.Windows.Forms;
using ITAC;
using Zamtest.Utilities.Itac;

namespace SSR
{
    public partial class MDIPrincipal : Form
    {
        private static MDIPrincipal singleton = null;
        private static readonly object padlock = new object();
        private int state = 0;
        private bool stopBtbFlag = false;

        public static MDIPrincipal Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new MDIPrincipal();
                    return singleton;
                }
            }
        }

        public struct ThreadNest
        {
            public Thread threadNest
            {
                get; set;
            }
            public bool isActive
            {
                set; get;
            }
        }
        public EnvironmentItac itac = new EnvironmentItac();
        private List<BackgroundWorker> backgroundworkerForms;
        public int loteStatus = 0;
        private Dictionary<string, Thread> Threads = new Dictionary<string, Thread>();
        private XMLUtils xmlUtils = new XMLUtils();
        private delegate object GetFormPropertyCallBack(Form control, string property);
        private string[] nestInfo;
        private string[] variants;
        internal string selectedVariant = string.Empty;
        public string activeUser;

        internal int mState = 0;
        public Dictionary<string, InstrParam> Instrument = new Dictionary<string, InstrParam>();
        internal TestForm instanceForm = new TestForm();
        internal string serialNumber = string.Empty;
        internal ZamStep.SetDigitalOutput setDigitalOutput = new ZamStep.SetDigitalOutput();
        internal ZamStep.ReadDigitalInput readDigitalInput = new ZamStep.ReadDigitalInput();
        internal delegate void SetControlPropertyThreadSafe(Control control, string property, object propertyValue);
        internal int pState;
        internal Color SKIPPED = Color.Blue;
        internal Color PASSED = Color.FromArgb(0, 192, 0);
        internal Color FAILED = Color.Red;
        internal Color WAITING = Color.Orange;
        internal Color TESTING = Color.Yellow;

        public struct InstrParam
        {
            public string port;
            public string attributes;
            public string assembly;
        };
        public enum STATE_APPLICATION_OF_FORMS
        {
            INITIALIZE = 0,
            SET,
            SHOWED,
            WAITING,
            RUNNING,
            CLOSED
        }
        public MDIPrincipal()
        {
            InitializeComponent();
        }
        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Leak Tester"))
            {
                Directory.SetCurrentDirectory(@"C:\Leak Tester");
                if (!xmlUtils.CheckLogs())
                    Application.Exit();
                if (!xmlUtils.GetVariants(out variants))
                    return;
                toolStripComboBoxVariant.ComboBox.DataSource = variants;
                toolStripComboBoxVariant.SelectedIndex = -1;
                toolStripComboBoxVariant.SelectedIndexChanged += new EventHandler(toolStripComboBoxVariant_SelectedIndexChanged);

                toolStripLabelResult.BackColor = WAITING;
                DisableStartControls();
                XMLUtils.Singleton.LoadSettings();
                LoadCounters();
                backgroundworkerForms = new List<BackgroundWorker>();
                windowsMenu.Enabled = false;
                itac.User = "";
                itac.Password = "";
                itac.SystemIdentifier = "10.103.45.23";
                string sationnnamee = Properties.Settings.Default.StationName;
                itac.StationName = sationnnamee;

                itac.StationPassword = "";
                pState = (int)STATE_APPLICATION_OF_FORMS.INITIALIZE;
            }
            else
            {
                MessageBox.Show("The project folder is not available, check the path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void DisableStartControls()
        {
            toolStripButtonPlay.Enabled = true;
            toolStripButtonStop.Enabled = false;
        }

        internal void PaintNests()
        {
            Size s = new Size();
            int xPos = 0;
            int counterForms = nestInfo.Length; //invertir contador para sentido de forms
            int countBack = 0;
            foreach (Control c in Controls)//Para obtener el tamaño delárea de trabajo
            {
                if (c is MdiClient)
                    s = c.Size;
            }

            int childrenWidth = s.Width / nestInfo.Length;//Para obtener el width de cada TestForm, en este caso son 5
            xPos = childrenWidth - 3;
            foreach (Form child in MdiChildren)
                child.Close();
            foreach (string nest in nestInfo)
            {
                TestForm testForm = new TestForm();
                testForm.Name = nest;
                testForm.Text = nest + " sequence";
                testForm.MdiParent = this;
                testForm.Height = s.Height - 26;//Restar unos cuantos pixeles para que se ajuste mejor
                testForm.Width = xPos;
                LoadSequenceTests(testForm, selectedVariant, nest);
                testForm.Invalidate();//Importante
                testForm.Show();
                testForm.Refresh();//Importante
                testForm.Location = new Point(s.Width - (childrenWidth * counterForms) - 1, 0);//Importante, el - 1 tiene que ser igual a lo que se resta en
               
                counterForms--;//invertir contador para sentido de forms
                pState = (int)STATE_APPLICATION_OF_FORMS.SHOWED;
                countBack++;
            }
        }

        void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            TestForm temp = (TestForm)e.Argument;
            temp.Show();
        }

        private void LoadSequenceTests(TestForm dut, string variant, string dutNumber)
        {
            if (!xmlUtils.GetNestTests("Leak Tester.xml", variant, dutNumber, dut.listViewDUTSequence))
            {
                MessageBox.Show("There where some errors while trying to load DUT tests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos XML (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.xml)|*.xml|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            SemaphoreOff();
            Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripPrincipal.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStripPrincipal.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void toolStripLabel3_Click_1(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCBTestedUnits = 0;
            Properties.Settings.Default.PCBPassedUnits = 0;
            Properties.Settings.Default.PCBFailedUnits = 0;
            Properties.Settings.Default.PCBYield = 0;
            Properties.Settings.Default.Save();
            LoadCounters();
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void dUT1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (selectedVariant != "")
                {
                    NestConfiguration Nest1 = new NestConfiguration();
                    Nest1.MdiParent = this;
                    Nest1.nestConfig = NestConfiguration.Nest.NEST1;
                    Nest1.Show();
                    f.BringToFront();
                    Nest1.WindowState = FormWindowState.Maximized;
                    return;
                }
                else
                {
                    MessageBox.Show("Seleccione una variante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dUT2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (selectedVariant != "")
                {
                    NestConfiguration Nest2 = new NestConfiguration();
                    Nest2.MdiParent = this;
                    Nest2.nestConfig = NestConfiguration.Nest.NEST2;
                    Nest2.Show();
                    f.BringToFront();
                    Nest2.WindowState = FormWindowState.Maximized;
                    return;
                }
                else
                {
                    MessageBox.Show("Seleccione una variante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options options = new Options();
            options.ShowDialog();
        }

        private void toolStripButtonPlay_Click(object sender, EventArgs e)
        {
            if (selectedVariant != "")
            {
                state = 0;
                StateMachine.Enabled = true;
            }
            else
                MessageBox.Show("Seleccione una variante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void InitChildrenStateMachine()
        {
            if (!stopBtbFlag)
            {
                toolStripLabelResult.Text = "NIDOS EN EJECUCIÓN...";
                foreach (Form child in Application.OpenForms)
                {
                    if (child is TestForm)
                    {
                        ((TestForm)child).stateMachineTimer.Enabled = true;
                        ((TestForm)child).state = 0;
                    }
                }
            }
            else
            {
                toolStripLabelResult.Text = "NIDOS EN EJECUCIÓN...";
                foreach (Form child in Application.OpenForms)
                {
                    if (child is TestForm)
                    {
                        ((TestForm)child).stateMachineTimer.Enabled = true;
                        ((TestForm)child).state = 1;
                    }
                }
                stopBtbFlag = false;
            }
        }

        private void StopChildrenStateMachine()
        {
            foreach (Form child in Application.OpenForms)
            {
                if (child is TestForm)
                    ((TestForm)child).state = 12;
            }
            StateMachine.Enabled = false;
        }

        internal void LoadCounters()
        {
            toolStripStatusLabelTestedUnits.Text = Properties.Settings.Default.PCBTestedUnits.ToString();
            toolStripStatusLabelPassedUnits.Text = Properties.Settings.Default.PCBPassedUnits.ToString();
            toolStripStatusLabelFailedUnits.Text = Properties.Settings.Default.PCBFailedUnits.ToString();
            toolStripStatusLabelYield.Text = Properties.Settings.Default.PCBYield.ToString("0.000")+"%";
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

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            toolStripLabelResult.Text = "DETENIENDO PROCESOS, ESPERE...";
            state = 5;
            SetControlsStateWhenStopped();
            toolStripLabelResult.Text = "DETENIDO";
            Cursor = Cursors.Default;
        }

        private void closeAllWindowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in MdiChildren)
            {
                form.Close();
            }
        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form children in MdiChildren)
            {
                if (children is TestForm)
                    children.Close();
            }
            GC.Collect();
        }

        public void SetControlsStateWhenStopped()
        {
            toolStripButtonPlay.Enabled = true;
            toolStripButtonStop.Enabled = false;
            menuStrip.Enabled = true;
            toolStripComboBoxVariant.Enabled = true;
            toolsMenu.Enabled = true;
            editMenu.Enabled = true;
            fileMenu.Enabled = true;
        }

        public void SetControlsStateWhenRunning()
        {
            toolStripButtonPlay.Enabled = false;
            toolStripButtonStop.Enabled = true;
            //menuStrip.Enabled = false;
            toolStripComboBoxVariant.Enabled = false;
            //toolsMenu.Enabled = false;
            editMenu.Enabled = false;
            fileMenu.Enabled = false;
        }

        public void SetControlsStateWhenEStop()
        {
            toolStripButtonPlay.Enabled = false;
            toolStripButtonStop.Enabled = false;
            toolStripComboBoxVariant.Enabled = false;
            editMenu.Enabled = false;
            fileMenu.Enabled = false;
        }

        private void toolStripButtonResetCounters_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.PCBTestedUnits = 0;
            Properties.Settings.Default.PCBPassedUnits = 0;
            Properties.Settings.Default.PCBFailedUnits = 0;
            Properties.Settings.Default.PCBYield = 0;
            Properties.Settings.Default.Save();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void instrumentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Devices d = new Devices();
            d.Show();
        }

        private void MDIPrincipal_SizeChanged(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
            //if(toolStripComboBoxVariant.SelectedIndex != -1)
            //    PaintSequenceWindows();
        }

        private void toolStripComboBoxVariant_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedVariant = toolStripComboBoxVariant.SelectedItem.ToString();
            if (!xmlUtils.GetNestInfo(selectedVariant, out nestInfo))
                return;
            PaintNests();
        }
        internal void SetControlPropertyTS(Control control, string propertyName, object propertyValue)
        {
            if (control.InvokeRequired)
                control.Invoke(new SetControlPropertyThreadSafe(SetControlPropertyTS), new object[] { control, propertyName, propertyValue });
            else
                control.GetType().InvokeMember(propertyName, BindingFlags.SetProperty, null, control, new object[] { propertyValue });
            //control.GetType().GetProperty(propertyName).SetValue(control, propertyValue, null);
        }

        private void tasksManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager manager = new TaskManager();
            manager.ShowDialog();
        }

        private void diagnosticPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Diagnostic diagnostic = new Diagnostic())
            {
                try
                {
                    diagnostic.ShowDialog();
                }
                catch (DaqException ex)
                {
                    diagnostic.Dispose();
                    Debug.WriteLine(ex.Message);
                }
                catch (ObjectDisposedException)
                {
                    diagnostic.Dispose();
                }
            }
        }

        private void dut3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (selectedVariant != "")
                {
                    NestConfiguration Nest3 = new NestConfiguration();
                    Nest3.MdiParent = this;
                    Nest3.nestConfig = NestConfiguration.Nest.NEST3;
                    Nest3.Show();
                    f.BringToFront();
                    Nest3.WindowState = FormWindowState.Maximized;
                    return;
                }
                else
                {
                    MessageBox.Show("Seleccione una variante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void StateMachineTimer_Tick(object sender, EventArgs e)
        {
            using (Task ESTOP = DaqSystem.Local.LoadTask("SENS_ESTOP"))
            {
                DigitalSingleChannelReader dscr = new DigitalSingleChannelReader(ESTOP.Stream);
                if (!dscr.ReadSingleSampleSingleLine())
                    state = 100;
            }

            switch (state)
            {
                case 0:
                    {
                        SetControlsStateWhenRunning();
                        InitChildrenStateMachine();
                        state = 1;
                        break;
                    }
                case 1://Idle
                    {
                        SemaphoreGreen();
                        Thread.Sleep(0);
                        break;
                    }
                case 5://Stop button
                    {
                        SemaphoreAmbar();
                        StopChildrenStateMachine();
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f is TestForm)
                                ((TestForm)f).state = 13;
                        }
                        stopBtbFlag = true;
                        break;
                    }
                case 100://ESTOP button
                    {
                        SemaphoreRed();
                        SetControlsStateWhenEStop();
                        foreach (Form f in Application.OpenForms)
                        {
                            if (f is TestForm)
                                ((TestForm)f).state = 12;
                        }
                        break;
                    }
            }
        }

        private void SetNIOutTask(bool state, string taskName)
        {
            using (Task task = DaqSystem.Local.LoadTask(taskName))
            {
                DigitalSingleChannelWriter dscw = new DigitalSingleChannelWriter(task.Stream);
                dscw.WriteSingleSampleSingleLine(true, state);
            }
        }

        private void SemaphoreRed()
        {
            SetNIOutTask(true, "ACT_SEMAPHORE_RED");
            SetNIOutTask(false, "ACT_SEMAPHORE_GREEN");
            SetNIOutTask(false, "ACT_SEMAPHORE_AMBER");
        }

        private void SemaphoreGreen()
        {
            SetNIOutTask(false, "ACT_SEMAPHORE_RED");
            SetNIOutTask(true, "ACT_SEMAPHORE_GREEN");
            SetNIOutTask(false, "ACT_SEMAPHORE_AMBER");
        }

        private void SemaphoreAmbar()
        {
            SetNIOutTask(false, "ACT_SEMAPHORE_RED");
            SetNIOutTask(false, "ACT_SEMAPHORE_GREEN");
            SetNIOutTask(true, "ACT_SEMAPHORE_AMBER");
        }

        private void SemaphoreOff()
        {
            SetNIOutTask(false, "ACT_SEMAPHORE_RED");
            SetNIOutTask(false, "ACT_SEMAPHORE_GREEN");
            SetNIOutTask(false, "ACT_SEMAPHORE_AMBER");
        }
    }
}

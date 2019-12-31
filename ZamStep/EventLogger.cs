using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace SSR
{
    class EventLoggerListener
    {
        private static EventLoggerListener instance = null;
        private static readonly object padlock = new object();
        public static EventLoggerListener Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new EventLoggerListener();
                    return instance;
                }
            }
        }

        private static readonly object lockObject = new object();
        private string logPath = string.Empty;
        private string error = string.Empty;
        private static RichTextBoxTraceListener richTextBoxTraceListener;
        private TextWriterTraceListener fileTraceListener;

        public string LogPath
        {
            get { return this.logPath; }
            set { this.logPath = value; }
        }

        public string Error
        {
            get { return this.error; }
        }

        private bool AddFileTraceListener()
        {
            try
            {
                Trace.Listeners.Add(this.fileTraceListener);
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        private bool AddTextBoxTraceListener()
        {
            try
            {
                Trace.Listeners.Add(richTextBoxTraceListener);
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        internal bool CreateFileTraceListener()
        {
            try
            {
                this.fileTraceListener = new TextWriterTraceListener(this.logPath);
                this.AddFileTraceListener();
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        internal bool CreateTextBoxTraceListener(RichTextBox textbox)
        {
            try
            {
                richTextBoxTraceListener = new RichTextBoxTraceListener(textbox);
                this.AddTextBoxTraceListener();
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        internal bool SetAutoFlush(bool state)
        {
            try
            {
                Trace.AutoFlush = state;
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        internal bool WriteEvent(string data, TraceLevel level)
        {
            try
            {
                
                switch (level)
                {
                    case TraceLevel.Info:
                        {
                            Application.DoEvents();
                                Trace.UseGlobalLock = true;
                                Trace.WriteLine(DateTime.Now.ToString("[dd/MM/yyyy hh:mm:ss]  ") + data);
                            break;
                        }
                    case TraceLevel.Error:
                        {
                            Application.DoEvents();
                                Trace.UseGlobalLock = true;
                                Trace.WriteLine(DateTime.Now.ToString("[dd/MM/yyyy hh:mm:ss]  ERROR: ") + data);
                            break;
                        }
                }
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }

        internal bool CloseEventLogger()
        {
            try
            {
                Trace.WriteLine("");
                Trace.Close();
                return true;
            }
            catch (Exception ex)
            {
                this.error = ex.Message + ex.StackTrace;
                return false;
            }
        }
    }

    class RichTextBoxTraceListener : TextWriterTraceListener
    {
        private RichTextBox target;
        private SendTextBoxTrace invokeWrite;
        public RichTextBoxTraceListener(RichTextBox textbox)
        {
            this.target = textbox;
            this.invokeWrite = new SendTextBoxTrace(this.SendText);
        }

        public override void Write(string message)
        {
            this.target.Invoke(this.invokeWrite, new object[] { message });
        }

        public override void WriteLine(string message)
        {
            this.target.Invoke(this.invokeWrite, new object[] { message + Environment.NewLine });
        }

        private delegate void SendTextBoxTrace(string messge);
        private void SendText(string message)
        {
            this.target.Text += message;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;
using System.Xml.Schema;
using System.Windows.Forms;
using System.IO;
//using Zamtest.Generic.RS232;

namespace SSR
{
    public class XMLUtils
    {
        private static XMLUtils singleton = null;
        private static readonly object padlock = new object();

        public static XMLUtils Singleton
        {
            get
            {
                lock (padlock)
                {
                    if (singleton == null)
                        singleton = new XMLUtils();
                    return singleton;
                }
            }
        }

        private Utils utils = new Utils();
        private static XmlDocument doc;

        //Variables for XML validaiton process
        private static XmlTextReader xmlReader;
        private static XmlValidatingReader xmlValidating;
        private static bool xmlValidationStatus = true;
        private static string errorMessage = string.Empty;
        //========================================

        public string GetError
        {
            get { return errorMessage; }
        }

        public bool ValidateXMLFile(string path)
        {
            object lockObject = new object();
            xmlValidationStatus = true;
            errorMessage = string.Empty;
            try
            {
                
                lock (lockObject)
                {
                    xmlReader = new XmlTextReader(path);
                    xmlValidating = new XmlValidatingReader(xmlReader);
                    xmlValidating.ValidationType = ValidationType.Schema;
                    xmlValidating.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);
                    while (xmlValidating.Read())
                    { }
                }
            }
            catch (XmlException ex)
            {
                MessageBox.Show(path + "\n" + ex.Message, "XML error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                xmlValidationStatus = false;
                return xmlValidationStatus;
            }
            finally
            {
                xmlValidating.Close();
                xmlReader.Close();
            }
            if (!xmlValidationStatus)
                MessageBox.Show(path + "\n" + errorMessage, "XML validation");
            return xmlValidationStatus;
        }

        private static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            xmlValidationStatus = false;
            errorMessage += e.Message;
        }

        public bool LoadDUTSettings(string dutNumber,string variant, NestConfiguration dutForm)
        {
            XmlNode DUTroot;
            doc = new XmlDocument();
            variant = MDIPrincipal.Singleton.selectedVariant;
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load("Leak Tester.xml");
                //Load tests
                //string test = "/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/tests";
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant +"']/NEST[@id='" + dutNumber + "']/tests");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                    {
                        for (int row = 0; row < DUTroot.ChildNodes.Count; row++)
                        {
                            if (DUTroot.ChildNodes[row].HasChildNodes)
                            {
                                dutForm.dataGridViewTests.Rows.Add();
                                dutForm.dataGridViewTests.Rows[row].Cells[0].Value = DUTroot.ChildNodes[row].ChildNodes[0].InnerText;
                                (dutForm.dataGridViewTests.Rows[row].Cells[1] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[1].InnerText;
                                if (DUTroot.ChildNodes[row].ChildNodes[2].InnerText.Equals("0"))
                                    (dutForm.dataGridViewTests.Rows[row].Cells[2] as DataGridViewCheckBoxCell).Value = 0;
                                else
                                    (dutForm.dataGridViewTests.Rows[row].Cells[2] as DataGridViewCheckBoxCell).Value = 1;
                                (dutForm.dataGridViewTests.Rows[row].Cells[3] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[3].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[4].Value = DUTroot.ChildNodes[row].ChildNodes[4].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[5].Value = DUTroot.ChildNodes[row].ChildNodes[5].InnerText;
                                (dutForm.dataGridViewTests.Rows[row].Cells[6] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[6].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[7].Value = DUTroot.ChildNodes[row].ChildNodes[7].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[8].Value = DUTroot.ChildNodes[row].ChildNodes[8].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[9].Value = DUTroot.ChildNodes[row].ChildNodes[9].InnerText;
                                dutForm.dataGridViewTests.Rows[row].Cells[10].Value = DUTroot.ChildNodes[row].ChildNodes[10].InnerText;
                            }
                        }
                    }
                }

                //Load instruments
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/instruments");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                    {
                        for (int row = 0; row < DUTroot.ChildNodes.Count; row++)
                        {
                            if (DUTroot.ChildNodes[row].HasChildNodes)
                            {
                                dutForm.dataGridViewDevices.Rows.Add();
                                dutForm.dataGridViewDevices.Rows[row].Cells[0].Value = DUTroot.ChildNodes[row].ChildNodes[0].InnerText;
                                dutForm.dataGridViewDevices.Rows[row].Cells[1].Value = DUTroot.ChildNodes[row].ChildNodes[1].InnerText;
                                dutForm.dataGridViewDevices.Rows[row].Cells[2].Value = DUTroot.ChildNodes[row].ChildNodes[2].InnerText;
                                (dutForm.dataGridViewDevices.Rows[row].Cells[3] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[3].InnerText;
                            }
                        }
                    }
                }
                //Load variables
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/variables");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                    {
                        foreach (XmlElement variable in DUTroot.ChildNodes)
                        {
                            if (variable.HasChildNodes)
                                dutForm.dataGridViewVariables.Rows.Add(new object[] { variable.ChildNodes[0].InnerText, variable.ChildNodes[1].InnerText, variable.ChildNodes[2].InnerText });
                        }
                    }
                }
                //Load signals
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/signals");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                    {
                        for (int row = 0; row < DUTroot.ChildNodes.Count; row++)
                        {
                            if (DUTroot.ChildNodes[row].HasChildNodes)
                            {
                                dutForm.dataGridViewSignals.Rows.Add();
                                dutForm.dataGridViewSignals.Rows[row].Cells[0].Value = DUTroot.ChildNodes[row].ChildNodes[0].InnerText;
                                (dutForm.dataGridViewSignals.Rows[row].Cells[1] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[1].InnerText;
                                dutForm.dataGridViewSignals.Rows[row].Cells[2].Value = DUTroot.ChildNodes[row].ChildNodes[2].InnerText;
                                dutForm.dataGridViewSignals.Rows[row].Cells[3].Value = DUTroot.ChildNodes[row].ChildNodes[3].InnerText;
                                dutForm.dataGridViewSignals.Rows[row].Cells[4].Value = DUTroot.ChildNodes[row].ChildNodes[4].InnerText;
                                dutForm.dataGridViewSignals.Rows[row].Cells[5].Value = DUTroot.ChildNodes[row].ChildNodes[5].InnerText;
                            }
                        }
                    }
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public void LoadInstruments(Devices d)
        {
            XmlNode DUTroot;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return;
                doc.Load("settings.xml");
                DUTroot = doc.SelectSingleNode("/settings/instruments");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                    {
                        for (int row = 0; row < DUTroot.ChildNodes.Count; row++)
                        {
                            if (DUTroot.ChildNodes[row].HasChildNodes)
                            {
                                d.dataGridViewDevices.Rows.Add();
                                d.dataGridViewDevices.Rows[row].Cells[0].Value = DUTroot.ChildNodes[row].ChildNodes[0].InnerText;
                                d.dataGridViewDevices.Rows[row].Cells[1].Value = DUTroot.ChildNodes[row].ChildNodes[1].InnerText;
                                d.dataGridViewDevices.Rows[row].Cells[2].Value = DUTroot.ChildNodes[row].ChildNodes[2].InnerText;
                                (d.dataGridViewDevices.Rows[row].Cells[3] as DataGridViewComboBoxCell).Value = DUTroot.ChildNodes[row].ChildNodes[3].InnerText;
                            }
                        }
                    }
                }
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool SaveDUTInstruments(string dutNumber, NestConfiguration form)
        { 
            XmlNode root;
            XmlNode node;
            string variant = MDIPrincipal.Singleton.selectedVariant;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load("Leak Tester.xml");
                root = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/instruments");
                if (root != null)
                {
                    if (root.HasChildNodes)
                        root.RemoveAll();
                    foreach (DataGridViewRow row in form.dataGridViewDevices.Rows)
                    {
                        node = doc.CreateNode(XmlNodeType.Element, "device", null);
                        root.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "name", null);
                        node.InnerText = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
                        root.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "port", null);
                        node.InnerText = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString();
                        root.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "attributes", null);
                        node.InnerText = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                        root.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "assembly", null);
                        if ((row.Cells[3] as DataGridViewComboBoxCell).Value == null)
                            node.InnerText = "";
                        else
                            node.InnerText = (row.Cells[3] as DataGridViewComboBoxCell).Value.ToString();
                        root.LastChild.AppendChild(node);
                    }
                }
                doc.Save("Leak Tester.xml");
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool SaveDUTVariables(string dutNumber, NestConfiguration dut)
        {
            XmlNode DUTroot;
            XmlNode node;
            string variant = MDIPrincipal.Singleton.selectedVariant;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load("Leak Tester.xml");
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant +"']/NEST[@id='" + dutNumber + "']/variables");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                        DUTroot.RemoveAll();
                    foreach (DataGridViewRow row in dut.dataGridViewVariables.Rows)
                    {
                        node = doc.CreateNode(XmlNodeType.Element, "variable", null);
                        DUTroot.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "name", null);
                        node.InnerText = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "value", null);
                        node.InnerText = row.Cells[1].Value == null ? "" : row.Cells[1].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "description", null);
                        node.InnerText = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                    }
                }
                doc.Save("Leak Tester.xml");
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool SaveDUTSignals(string dutNumber, NestConfiguration dut)
        {
            XmlNode DUTroot;
            XmlNode node;
            string variant = MDIPrincipal.Singleton.selectedVariant;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load("Leak Tester.xml");
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/signals");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                        DUTroot.RemoveAll();
                    foreach (DataGridViewRow row in dut.dataGridViewSignals.Rows)
                    {
                        node = doc.CreateNode(XmlNodeType.Element, "signal", null);
                        DUTroot.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "name", null);
                        node.InnerText = row.Cells[0].Value == null ? "" : row.Cells[0].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "type", null);
                        if ((row.Cells[1] as DataGridViewComboBoxCell).Value == null)
                            node.InnerText = "";
                        else
                            node.InnerText = row.Cells[1].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "channel", null);
                        node.InnerText = row.Cells[2].Value == null ? "" : row.Cells[2].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "relay", null);
                        node.InnerText = row.Cells[3].Value == null ? "" : row.Cells[3].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "value", null);
                        node.InnerText = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "description", null);
                        node.InnerText = row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                    }
                }
                doc.Save("Leak Tester.xml");
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool SaveDUTTests(string dutNumber, NestConfiguration dut)
        {
            XmlNode DUTroot;
            XmlNode node;
            doc = new XmlDocument();
            string variant = MDIPrincipal.Singleton.selectedVariant;
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load("Leak Tester.xml");
                DUTroot = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/tests");
                if (DUTroot != null)
                {
                    if (DUTroot.HasChildNodes)
                        DUTroot.RemoveAll();
                    foreach (DataGridViewRow row in dut.dataGridViewTests.Rows)
                    {
                        node = doc.CreateNode(XmlNodeType.Element, "test", null);
                        DUTroot.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "name", null);
                        node.InnerText = row.Cells[0].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "type", null);
                        node.InnerText = (row.Cells[1] as DataGridViewComboBoxCell).Value == null ? "" : (row.Cells[1] as DataGridViewComboBoxCell).Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "skip", null);
                        if ((row.Cells[2] as DataGridViewCheckBoxCell).Value == null)
                            node.InnerText = "0";
                        else if ((row.Cells[2] as DataGridViewCheckBoxCell).Value.ToString() == "0")
                            node.InnerText = "0";
                        else
                            node.InnerText = "1";
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "limit", null);
                        node.InnerText = (row.Cells[3] as DataGridViewComboBoxCell).Value == null ? "" : (row.Cells[3] as DataGridViewComboBoxCell).Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "low", null);
                        node.InnerText = row.Cells[4].Value == null ? "" : row.Cells[4].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "high", null);
                        node.InnerText = row.Cells[5].Value == null ? "" : row.Cells[5].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "units", null);
                        node.InnerText = (row.Cells[6] as DataGridViewComboBoxCell).Value == null ? "" : (row.Cells[6] as DataGridViewComboBoxCell).Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "command", null);
                        node.InnerText = row.Cells[7].Value == null ? "" : row.Cells[7].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "response", null);
                        node.InnerText = row.Cells[8].Value == null ? "" : row.Cells[8].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "params", null);
                        node.InnerText = row.Cells[9].Value == null ? "" : row.Cells[9].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                        node = doc.CreateNode(XmlNodeType.Element, "procedure", null); // change to combobox
                        node.InnerText = row.Cells[10].Value == null ? "" : row.Cells[10].Value.ToString();
                        DUTroot.LastChild.AppendChild(node);
                    }
                }
                doc.Save("Leak Tester.xml");
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool LoadSettings()
        {
            XmlNode root;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return false;
                doc.Load("settings.xml");
                root = doc.SelectSingleNode("/settings/projects");
                if (root.HasChildNodes)
                {
                    if (root.ChildNodes[2].Equals("0"))
                        Properties.Settings.Default.StopSequence = false;
                    else
                        Properties.Settings.Default.StopSequence = true;
                    Properties.Settings.Default.StopSequenceAfter = Convert.ToInt32(root.ChildNodes[3].InnerText);
                    Properties.Settings.Default.OptoStatus = root.ChildNodes[4].InnerText == "0" ? false : true;
                    Properties.Settings.Default.DiagnosticDevice = root.ChildNodes[4].InnerText;
                    Properties.Settings.Default.iTac = root.ChildNodes[5].InnerText == "0" ? false : true;
                }
                root = doc.SelectSingleNode("/settings/logFile");
                if (root.HasChildNodes)
                {
                    Properties.Settings.Default.LogFileFolder = root.ChildNodes[0].InnerText;
                    if (root.ChildNodes[1].InnerText.Equals("0"))
                        Properties.Settings.Default.LogFileStatus = false;
                    else
                        Properties.Settings.Default.LogFileStatus = true;
                    Properties.Settings.Default.LogFileSeparator = root.ChildNodes[2].InnerText;
                    Properties.Settings.Default.LogFileProjectName = root.ChildNodes[3].InnerText;
                    Properties.Settings.Default.LogFileTesterID = root.ChildNodes[4].InnerText;
                    Properties.Settings.Default.LogFileHeaderFileds = root.ChildNodes[5].InnerText;
                }
                root = doc.SelectSingleNode("/settings/teal");
                if (root.HasChildNodes)
                {
                    Properties.Settings.Default.TealFolder = root.ChildNodes[0].InnerText;
                    if (root.ChildNodes[1].InnerText.Equals("0"))
                        Properties.Settings.Default.TealStatus = false;
                    else
                        Properties.Settings.Default.TealStatus = true;
                    Properties.Settings.Default.TealConnectionString = root.ChildNodes[2].InnerText;
                    Properties.Settings.Default.TealStoredProcedure = root.ChildNodes[3].InnerText;
                    Properties.Settings.Default.TealTesterID = root.ChildNodes[4].InnerText;
                    Properties.Settings.Default.TealLineID = root.ChildNodes[5].InnerText;
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool LoadProjectSettings(Options options)
        {
            XmlNode root;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return false;
                doc.Load("settings.xml");
                root = doc.SelectSingleNode("/settings/projects");
                if (root.HasChildNodes)
                {
                    options.textBoxProjectsFolderPath.Text = root.ChildNodes[0].InnerText;
                    options.textBoxProjectSchemasLocation.Text = root.ChildNodes[1].InnerText;
                    options.textBoxFlashVersions.Text = root.ChildNodes[2].InnerText;
                    if (root.ChildNodes[2].Equals("0"))
                        options.checkBoxStopSequence.Checked = false;
                    else
                        options.checkBoxStopSequence.Checked = true;
                    if (root.ChildNodes[5].InnerText.Equals("0"))
                        options.checkBoxiTAC.Checked = false;
                    else
                        options.checkBoxiTAC.Checked = true;
                    options.numericUpDownSequenceFailures.Value = Convert.ToDecimal(root.ChildNodes[3].InnerText);
                    options.comboBox1.SelectedIndex = options.comboBox1.Items.IndexOf(root.ChildNodes[4].InnerText);
                }
                root = doc.SelectSingleNode("/settings/logFile");
                if (root.HasChildNodes)
                {
                    options.textBoxLogFileFolder.Text = root.ChildNodes[0].InnerText;
                    if (root.ChildNodes[1].InnerText.Equals("0"))
                        options.checkBoxLogFileStatus.Checked = false;
                    else
                        options.checkBoxLogFileStatus.Checked = true;
                    options.textBoxLogFileSeparator.Text = root.ChildNodes[2].InnerText;
                    options.textBoxLogFileProjectName.Text = root.ChildNodes[3].InnerText;
                    options.textBoxLogFileTesterID.Text = root.ChildNodes[4].InnerText;
                    options.textBoxLogFileHeaderFileds.Text = root.ChildNodes[5].InnerText;
                }
                root = doc.SelectSingleNode("/settings/teal");
                if (root.HasChildNodes)
                {
                    Properties.Settings.Default.TealFolder = options.textBoxTealFolder.Text = root.ChildNodes[0].InnerText;
                    if (root.ChildNodes[1].InnerText.Equals("0"))
                        options.checkBoxTealStatus.Checked = false;
                    else
                        options.checkBoxTealStatus.Checked = true;
                    options.textBoxTealConnString.Text = root.ChildNodes[2].InnerText;
                    options.textBoxTealStoredProcedure.Text = root.ChildNodes[3].InnerText;
                    options.textBoxTealTesterID.Text = root.ChildNodes[4].InnerText;
                    options.textBoxTealLineID.Text = root.ChildNodes[5].InnerText;
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool SaveProjectSettings(object[] data)
        {
            XmlNode root;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return false;
                doc.Load("settings.xml");
                root = doc.SelectSingleNode("/settings/projects");
                root.ChildNodes[0].InnerText = data[0].ToString();
                root.ChildNodes[1].InnerText = data[1].ToString();
                root.ChildNodes[2].InnerText = (bool)data[2] == false ? "0" : "1";
                root.ChildNodes[3].InnerText = data[3].ToString();
                root.ChildNodes[4].InnerText = data[16].ToString();
                root.ChildNodes[5].InnerText = (bool)data[17] == false ? "0" : "1";
                Properties.Settings.Default.DiagnosticDevice = data[16].ToString();
                Properties.Settings.Default.iTac = (bool)data[17];
                Properties.Settings.Default.StopSequence = (bool)data[2];
                Properties.Settings.Default.StopSequenceAfter = Convert.ToInt32(data[3]);
                
                root = doc.SelectSingleNode("/settings/logFile");
                Properties.Settings.Default.LogFileFolder = root.ChildNodes[0].InnerText = data[4].ToString();
                root.ChildNodes[1].InnerText = (bool)data[5] == false ? "0" : "1";
                Properties.Settings.Default.LogFileStatus = (bool)data[5];
                Properties.Settings.Default.LogFileSeparator = root.ChildNodes[2].InnerText = data[6].ToString();
                Properties.Settings.Default.LogFileProjectName = root.ChildNodes[3].InnerText = data[7].ToString();
                Properties.Settings.Default.LogFileTesterID = root.ChildNodes[4].InnerText = data[8].ToString();
                Properties.Settings.Default.LogFileHeaderFileds = root.ChildNodes[5].InnerText = data[9].ToString();
                root = doc.SelectSingleNode("/settings/teal");
                Properties.Settings.Default.TealFolder = root.ChildNodes[0].InnerText = data[10].ToString();
                root.ChildNodes[1].InnerText = (bool)data[11] == false ? "0" : "1";
                Properties.Settings.Default.TealStatus = (bool)data[11];
                Properties.Settings.Default.TealConnectionString = root.ChildNodes[2].InnerText = data[12].ToString();
                Properties.Settings.Default.TealStoredProcedure = root.ChildNodes[3].InnerText = data[13].ToString();
                Properties.Settings.Default.TealTesterID = root.ChildNodes[4].InnerText = data[14].ToString();
                Properties.Settings.Default.TealLineID = root.ChildNodes[5].InnerText = data[15].ToString();
                doc.Save("settings.xml");
                Properties.Settings.Default.Save();
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool CheckLogs()
        {
            XmlNode root;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return false;
                doc.Load("settings.xml");
                root = doc.SelectSingleNode("/settings/logFile");
                if (root.ChildNodes[1].InnerText.Equals("1"))
                {
                    MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.ForeColor = Color.FromArgb(0, 192, 0);
                    MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.Text = "Active";
                }
                else
                {
                    MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.ForeColor = Color.Red;
                    MDIPrincipal.Singleton.toolStripStatusLabelLogFileStatusText.Text = "Inactive";
                }
                root = doc.SelectSingleNode("/settings/projects");
                if (root.ChildNodes[5].InnerText.Equals("1"))
                {
                    MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.ForeColor = Color.FromArgb(0, 192, 0);
                    MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.Text = "Active";
                }
                else
                {
                    MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.ForeColor = Color.Red;
                    MDIPrincipal.Singleton.toolStripStatusLabelTealStatusText.Text = "Inactive";
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool LoadTestsToDictionary(string dutNumber, ref TestForm form)
        {
            FileStream fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlNode rootNode;
            doc = new XmlDocument();
            string variant = MDIPrincipal.Singleton.selectedVariant;

            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/tests");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            if (rootNode.ChildNodes[i].HasChildNodes)
                            {
                                //if (!form.Test.ContainsKey(rootNode.ChildNodes[i].ChildNodes[0].InnerText))
                                    form.Test.Add(i, new TestForm.TestParam() { name = rootNode.ChildNodes[i].ChildNodes[0].InnerText, type = rootNode.ChildNodes[i].ChildNodes[1].InnerText, skip = rootNode.ChildNodes[i].ChildNodes[2].InnerText, limit = rootNode.ChildNodes[i].ChildNodes[3].InnerText, low = rootNode.ChildNodes[i].ChildNodes[4].InnerText, high = rootNode.ChildNodes[i].ChildNodes[5].InnerText, units = rootNode.ChildNodes[i].ChildNodes[6].InnerText, command = rootNode.ChildNodes[i].ChildNodes[7].InnerText, response = rootNode.ChildNodes[i].ChildNodes[8].InnerText, param = rootNode.ChildNodes[i].ChildNodes[9].InnerText, procedure = rootNode.ChildNodes[i].ChildNodes[10].InnerText });
                            }
                        }
                    }
                }
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FormatException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool LoadVariablesToDictionary(string dutNumber, ref TestForm form)
        {
            FileStream fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlNode rootNode;
            doc = new XmlDocument();
            string variant = MDIPrincipal.Singleton.selectedVariant;
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/variables");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            if (rootNode.ChildNodes[i].HasChildNodes)
                            {
                                form.Variable.Add(rootNode.ChildNodes[i].ChildNodes[0].InnerText, new TestForm.VariableParam() { value = rootNode.ChildNodes[i].ChildNodes[1].InnerText, description = rootNode.ChildNodes[i].ChildNodes[2].InnerText });
                            }
                        }
                    }
                }
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FormatException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool LoadSignalsToDictionary(string dutNumber, ref TestForm form)
        {
            FileStream fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlNode rootNode;
            doc = new XmlDocument();
            string variant = MDIPrincipal.Singleton.selectedVariant;
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/signals");
                try
                {
                    if (rootNode != null)
                    {
                        if (rootNode.HasChildNodes)
                        {
                            for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                            {
                                if (rootNode.ChildNodes[i].HasChildNodes)
                                {
                                    form.Signal.Add(rootNode.ChildNodes[i].ChildNodes[0].InnerText, new TestForm.SignalParam() { type = rootNode.ChildNodes[i].ChildNodes[1].InnerText, channel = rootNode.ChildNodes[i].ChildNodes[2].InnerText, relay = rootNode.ChildNodes[i].ChildNodes[3].InnerText, value = rootNode.ChildNodes[i].ChildNodes[4].InnerText, description = rootNode.ChildNodes[i].ChildNodes[5].InnerText });
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FormatException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool LoadInstrumentsToDictionary(string dutNumber, ref TestForm form)
        {
            FileStream fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            XmlNode rootNode;
            string variant = MDIPrincipal.Singleton.selectedVariant;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + dutNumber + "']/instruments");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            if (rootNode.ChildNodes[i].HasChildNodes)
                            {
                             form.Instrument.Add(rootNode.ChildNodes[i].ChildNodes[0].InnerText, new TestForm.InstrParam { port = rootNode.ChildNodes[i].ChildNodes[1].InnerText, attributes = rootNode.ChildNodes[i].ChildNodes[2].InnerText, assembly = rootNode.ChildNodes[i].ChildNodes[3].InnerText });
                            }
                        }
                    }
                }
                fs.Close();
                fs.Dispose();
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FormatException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch(ArgumentException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool GetNestInfo(string variant, out string[] dutNames)
        {
            dutNames = null;
            FileStream fs = null;
            XmlNode rootNode;
            fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        Array.Resize<string>(ref dutNames, rootNode.ChildNodes.Count);
                        dutNames.Initialize();
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            dutNames.SetValue(rootNode.ChildNodes[i].Attributes[0].Value.ToString(), i);
                        }
                    }
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool GetVariants(out string[] variants)
        {
            variants = null;
            FileStream fs = null;
            XmlNode rootNode;
            fs = new FileStream("Leak Tester.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("Leak Tester.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/LeakTester");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        Array.Resize<string>(ref variants, rootNode.ChildNodes.Count);
                        variants.Initialize();
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            variants.SetValue(rootNode.ChildNodes[i].Attributes[0].Value.ToString(), i);
                        }
                    }
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public bool GetFlashPath(ref string flashPath)
        {
            FileStream fs = null;
            XmlNode rootNode;
            fs = new FileStream("settings.xml", FileMode.Open, FileAccess.Read, FileShare.Read);
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile("settings.xml"))
                    return false;
                doc.Load(fs);
                rootNode = doc.SelectSingleNode("/settings/projects/flashVersions");
                if (rootNode != null)
                    flashPath = rootNode.InnerText;
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }

        public string GetDeviceFlashVersionsPath(string filePath)
        {
            XmlNode rootNode;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile(filePath))
                    return string.Empty;
                doc.Load(filePath);
                rootNode = doc.SelectSingleNode("/settings/projects/flashVersions");
                if (rootNode != null)
                {
                    return rootNode.InnerText;
                }
                return string.Empty;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return string.Empty;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return string.Empty;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return string.Empty;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return string.Empty;
            }
        }

        public bool GetNestTests(string filePath, string variant, string nest, ListView list)
        {
            XmlNode rootNode;
            doc = new XmlDocument();
            try
            {
                if (!ValidateXMLFile(filePath))
                    return false;
                doc.Load(filePath);
                list.Items.Clear();
                rootNode = doc.SelectSingleNode("/LeakTester/VARIANT[@id='" + variant + "']/NEST[@id='" + nest + "']/tests");
                if (rootNode != null)
                {
                    if (rootNode.HasChildNodes)
                    {
                        for (int i = 0; i < rootNode.ChildNodes.Count; i++)
                        {
                            if (rootNode.ChildNodes[i].HasChildNodes)
                            {
                                ListViewItem item = new ListViewItem((i + 1).ToString());
                                item.UseItemStyleForSubItems = false;
                                item.SubItems.Add(rootNode.ChildNodes[i].ChildNodes[0].InnerText);
                                item.SubItems.Add("");
                                list.Items.Add(item);
                                item.EnsureVisible();
                            }
                        }
                    }
                }
                return true;
            }
            catch (XmlException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (NullReferenceException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (System.Xml.XPath.XPathException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
            catch (FileNotFoundException ex)
            {
                errorMessage = ex.Message + ex.StackTrace;
                return false;
            }
        }
    }
}

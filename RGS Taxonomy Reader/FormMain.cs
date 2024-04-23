using System;
using System.Drawing;
using System.Windows.Forms;
using System.Globalization;
using System.Xml.Schema;
using FastColoredTextBoxNS;
using Xbrl.Discovery;
using System.IO;
using RGS.Mapping.Model;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace RGS.Taxonomy.Reader
{
    public partial class FormMain : Form
    {
        public static TextStyle InfoStyle { get; } = new TextStyle(Brushes.Blue, null, FontStyle.Regular);
        public static TextStyle WarningStyle { get; } = new TextStyle(Brushes.Orange, null, FontStyle.Regular);
        public static TextStyle ErrorStyle { get; } = new TextStyle(Brushes.Red, null, FontStyle.Regular);

        protected int InfoCount { get; set; } = 0;
        protected int WarningCount { get; set; } = 0;
        protected int ErrorCount { get; set; } = 0;

        protected CultureInfo CultureInfoNl { get; } = CultureInfo.CreateSpecificCulture("nl-NL");

        protected string CurrentAction { get; set; } = "";

        protected Dts Dts { get; set; }

        protected TextWriter TextWriter { get; set; }

        public FormMain()
        {
            InitializeComponent();
        }

        public void ShowProgress(string text, Style style)
        {
            lblStatus.Text = text;

            //some stuffs for best performance
            fastColoredTextBox.BeginUpdate();
            fastColoredTextBox.Selection.BeginUpdate();
            //remember user selection
            var userSelection = fastColoredTextBox.Selection.Clone();
            //goto end of the text
            fastColoredTextBox.Selection.Start = fastColoredTextBox.LinesCount > 0 ? new Place(fastColoredTextBox[fastColoredTextBox.LinesCount - 1].Count, fastColoredTextBox.LinesCount - 1) : new Place(0, 0);
            //add text with predefined style
            if (CurrentAction != "")
                text = DateTime.Now + ": " + CurrentAction + "\r\n" + DateTime.Now + ": " + text + "\r\n";
            else
                text = DateTime.Now + ": " + text + "\r\n";
            CurrentAction = "";
            fastColoredTextBox.InsertText(text, style);
            //restore user selection
            if (userSelection.Start != userSelection.End || userSelection.Start.iLine < fastColoredTextBox.LinesCount - 2)
            {
                fastColoredTextBox.Selection.Start = userSelection.Start;
                fastColoredTextBox.Selection.End = userSelection.End;
            }
            else
            {
                //scroll to end of the text
                fastColoredTextBox.DoCaretVisible();
            }
            fastColoredTextBox.Selection.EndUpdate();
            fastColoredTextBox.EndUpdate();

            if (style == InfoStyle)
                InfoCount++;
            else if (style == WarningStyle)
                WarningCount++;
            else if (style == ErrorStyle)
                ErrorCount++;

            Application.DoEvents();
        }

        private void ClearProgress()
        {
            fastColoredTextBox.Clear();
            InfoCount = 0;
            WarningCount = 0;
            ErrorCount = 0;
        }

        public bool AllNeededInformationAvailable()
        {
            return
                textBoxRgsEntrypoint.Text != "" &&
                (textBoxOutputJson.Text != "" || textBoxOutputXml.Text != "");
        }

        private void buttonRgsEntrypoint_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Xsd|*.xsd|All|*.*";
            dialog.FileName = textBoxRgsEntrypoint.Text;
            if (dialog.ShowDialog(this) == DialogResult.OK)
                textBoxRgsEntrypoint.Text = dialog.FileName;
        }
        private void buttonOutputJson_Click(object sender, EventArgs e)
        {
            SaveFileDialog openDlg = new SaveFileDialog();
            openDlg.Filter = "Json|*.json|All|*.*";
            openDlg.FileName = textBoxOutputJson.Text;
            if (openDlg.ShowDialog(this) == DialogResult.OK)
                textBoxOutputJson.Text = openDlg.FileName;
        }
        private void buttonOutputXml_Click(object sender, EventArgs e)
        {
            SaveFileDialog openDlg = new SaveFileDialog();
            openDlg.Filter = "Xml|*.xml|All|*.*";
            openDlg.FileName = textBoxOutputXml.Text;
            if (openDlg.ShowDialog(this) == DialogResult.OK)
                textBoxOutputXml.Text = openDlg.FileName;
        }

        private void textBoxRgsEntrypoint_TextChanged(object sender, EventArgs e) => buttonStart.Enabled = AllNeededInformationAvailable();
        private void textBoxOutputJson_TextChanged(object sender, EventArgs e) => buttonStart.Enabled = AllNeededInformationAvailable();
        private void textBoxOutputXml_TextChanged(object sender, EventArgs e) => buttonStart.Enabled = AllNeededInformationAvailable();

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            string cache = @"C:\Cache";

            Dts = new Dts();

            if (Directory.Exists(cache))
                Dts.Cache = cache;

            if (buttonStart.Text == "&Start")
            {
                try
                {
                    buttonStart.Text = "&Cancel";
                    if (!AllNeededInformationAvailable())
                    {
                        MessageBox.Show("Generation aborted!", "Generate csv", MessageBoxButtons.OK);
                        return;
                    }

                    ClearProgress();

                    lblStatus.Text = "Started";
                    progressBar.Style = ProgressBarStyle.Marquee;
                    progressBar.MarqueeAnimationSpeed = 100;
                    Application.DoEvents();

                    progressBar.Style = ProgressBarStyle.Continuous;
                    progressBar.Value = 0;
                    progressBar.Maximum = 4;

                    Dts.DiscoverInfo += DtsOnDiscoverInfo;
                    Dts.DiscoverWarning += DtsOnDiscoverWarning;
                    Dts.DiscoverError += DtsOnDiscoverError;
                    Dts.DiscoverReady += DtsOnReady;
                    Dts.ValidationProblem += DtsOnValidationProblem;
                    Dts.LoadFile(textBoxRgsEntrypoint.Text, checkBoxSimpleReport.Checked);

                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Formatting = Formatting.Indented;
                    serializer.NullValueHandling = NullValueHandling.Ignore;
                    serializer.DefaultValueHandling = DefaultValueHandling.Ignore;
                    serializer.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    serializer.ContractResolver = ShouldSerializeContractResolver.Instance;
                    if (textBoxOutputJson.Text != "")
                    {
                        ShowProgress(string.Format("Writing: {0}", textBoxOutputJson.Text), InfoStyle);
                        using (StreamWriter file = File.CreateText(textBoxOutputJson.Text))
                        {
                            serializer.Serialize(file, Dts.Report);
                        }
                    }
                    if (textBoxOutputXml.Text != "")
                    {
                        ShowProgress(string.Format("Writing: {0}", textBoxOutputXml.Text), InfoStyle);
                        using (StreamWriter file = File.CreateText(textBoxOutputXml.Text))
                        {
                            JsonConvert.DeserializeXmlNode(JsonConvert.SerializeObject(Dts.Report, serializer.Formatting), Dts.Report.GetType().Name).Save(file);
                        }
                    }
                    ShowProgress("Completed", InfoStyle);
                    progressBar.Value = progressBar.Maximum;
                    MessageBox.Show(string.Format("Ready with messages of Info {0}, Warning {1} and Error {2}.", InfoCount, WarningCount, ErrorCount), "RGS.Taxonomy.Reader");
                }
                catch (Exception ex)
                {
                    ShowProgress(ex.Message, ErrorStyle);
                    MessageBox.Show(ex.Message, "Write", MessageBoxButtons.OK);
                }
                finally
                {
                    if (Dts.Cancelled)
                        lblStatus.Text = "Canceled";
                    else
                        lblStatus.Text = "Ready";
                    buttonStart.Text = "&Start";
                }
            }
            else
            {
                Dts.Cancelled = true;
            }

            Application.DoEvents();
        }

        private void DtsOnDiscoverInfo(object sender, ActivityEventArgs e)
        {
            ShowProgress(e.Action + ": " + e.Message, InfoStyle);
        }

        private void DtsOnDiscoverWarning(object sender, ActivityEventArgs e)
        {
            ShowProgress(e.Action + ": " + e.Message, WarningStyle);
        }

        private void DtsOnDiscoverError(object sender, ActivityEventArgs e)
        {
            ShowProgress(e.Action + ": " + e.Message, ErrorStyle);
        }

        private void DtsOnReady(object sender, ActivityEventArgs e)
        {
            //ShowProgress(e.Action + ": " + e.Message, InfoStyle);
            //progressBar.Value = progressBar.Maximum;
            //MessageBox.Show(string.Format("Ready with messages of Info {0}, Warning {1} and Error {2}.", InfoCount, WarningCount, ErrorCount), "RGS.Taxonomy.Reader");
            //if (Dts.Cancelled)
            //    lblStatus.Text = "Canceled";
            //else
            //    lblStatus.Text = "Ready";
            //buttonStart.Text = "&Start";
        }

        private void DtsOnValidationProblem(object sender, ValidationEventArgs e)
        {
            ShowProgress("Validation: " + e.Message, e.Severity == XmlSeverityType.Error ? ErrorStyle : WarningStyle);
            TextWriter.WriteLine(e.Severity + " " + e.Message);
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemHelpAbout_Click(object sender, EventArgs e)
        {
            AboutWindow aw = new AboutWindow();
            aw.ShowDialog(this);
        }
    }
}

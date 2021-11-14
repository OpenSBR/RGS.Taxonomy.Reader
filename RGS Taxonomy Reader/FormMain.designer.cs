namespace RGS.Taxonomy.Reader
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.DirectoryServices.SortOption sortOption1 = new System.DirectoryServices.SortOption();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.progressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.fastColoredTextBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRgsEntrypoint = new System.Windows.Forms.Button();
            this.textBoxRgsEntrypoint = new System.Windows.Forms.TextBox();
            this.labelRgsEntrypoint = new System.Windows.Forms.Label();
            this.labelOutputJson = new System.Windows.Forms.Label();
            this.textBoxOutputJson = new System.Windows.Forms.TextBox();
            this.buttonOutputJson = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.buttonOutputXml = new System.Windows.Forms.Button();
            this.textBoxOutputXml = new System.Windows.Forms.TextBox();
            this.labelOutputXml = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.labelSimpleReport = new System.Windows.Forms.Label();
            this.checkBoxSimpleReport = new System.Windows.Forms.CheckBox();
            this.menuStripMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBoxActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).BeginInit();
            this.groupBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFile,
            this.menuItemHelp});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1122, 24);
            this.menuStripMain.TabIndex = 3;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // menuItemFile
            // 
            this.menuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.menuItemClose});
            this.menuItemFile.Name = "menuItemFile";
            this.menuItemFile.Size = new System.Drawing.Size(37, 20);
            this.menuItemFile.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // menuItemClose
            // 
            this.menuItemClose.Name = "menuItemClose";
            this.menuItemClose.Size = new System.Drawing.Size(103, 22);
            this.menuItemClose.Text = "Close";
            this.menuItemClose.Click += new System.EventHandler(this.menuItemClose_Click);
            // 
            // menuItemHelp
            // 
            this.menuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHelpAbout});
            this.menuItemHelp.Name = "menuItemHelp";
            this.menuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.menuItemHelp.Text = "Help";
            // 
            // menuItemHelpAbout
            // 
            this.menuItemHelpAbout.Name = "menuItemHelpAbout";
            this.menuItemHelpAbout.Size = new System.Drawing.Size(116, 22);
            this.menuItemHelpAbout.Text = "About...";
            this.menuItemHelpAbout.Click += new System.EventHandler(this.menuItemHelpAbout_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressBar,
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 611);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(1122, 26);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // progressBar
            // 
            this.progressBar.MarqueeAnimationSpeed = 0;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(88, 20);
            // 
            // lblStatus
            // 
            this.lblStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(39, 21);
            this.lblStatus.Text = "Ready";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.fastColoredTextBox);
            this.groupBoxActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxActivity.Location = new System.Drawing.Point(0, 200);
            this.groupBoxActivity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxActivity.Size = new System.Drawing.Size(1122, 411);
            this.groupBoxActivity.TabIndex = 8;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Messages";
            // 
            // fastColoredTextBox
            // 
            this.fastColoredTextBox.AllowInsertRemoveLines = true;
            this.fastColoredTextBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox.AutoIndentCharsPatterns = "^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>[^;=]+);\r\n^\\s*(case|default)\\s*[^:]*" +
    "(?<range>:)\\s*(?<range>[^;]+);";
            this.fastColoredTextBox.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox.BackBrush = null;
            this.fastColoredTextBox.CharHeight = 14;
            this.fastColoredTextBox.CharWidth = 8;
            this.fastColoredTextBox.CurrentPenSize = 3;
            this.fastColoredTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fastColoredTextBox.DocumentPath = null;
            this.fastColoredTextBox.IsReplaceMode = false;
            this.fastColoredTextBox.Location = new System.Drawing.Point(4, 19);
            this.fastColoredTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.fastColoredTextBox.Name = "fastColoredTextBox";
            this.fastColoredTextBox.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox.SelectionChangedDelayedEnabled = false;
            this.fastColoredTextBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fastColoredTextBox.ServiceColors")));
            this.fastColoredTextBox.Size = new System.Drawing.Size(1114, 389);
            this.fastColoredTextBox.TabIndex = 14;
            this.fastColoredTextBox.TextHeight = 14;
            this.fastColoredTextBox.Zoom = 100;
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(1010, 128);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(104, 37);
            this.buttonStart.TabIndex = 13;
            this.buttonStart.Text = "&Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonRgsEntrypoint
            // 
            this.buttonRgsEntrypoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRgsEntrypoint.Image = ((System.Drawing.Image)(resources.GetObject("buttonRgsEntrypoint.Image")));
            this.buttonRgsEntrypoint.Location = new System.Drawing.Point(1086, 18);
            this.buttonRgsEntrypoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRgsEntrypoint.Name = "buttonRgsEntrypoint";
            this.buttonRgsEntrypoint.Size = new System.Drawing.Size(28, 28);
            this.buttonRgsEntrypoint.TabIndex = 6;
            this.buttonRgsEntrypoint.UseVisualStyleBackColor = true;
            this.buttonRgsEntrypoint.Click += new System.EventHandler(this.buttonRgsEntrypoint_Click);
            // 
            // textBoxRgsEntrypoint
            // 
            this.textBoxRgsEntrypoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRgsEntrypoint.Location = new System.Drawing.Point(107, 22);
            this.textBoxRgsEntrypoint.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxRgsEntrypoint.Name = "textBoxRgsEntrypoint";
            this.textBoxRgsEntrypoint.Size = new System.Drawing.Size(973, 23);
            this.textBoxRgsEntrypoint.TabIndex = 5;
            this.textBoxRgsEntrypoint.TextChanged += new System.EventHandler(this.textBoxRgsEntrypoint_TextChanged);
            // 
            // labelRgsEntrypoint
            // 
            this.labelRgsEntrypoint.AutoSize = true;
            this.labelRgsEntrypoint.Location = new System.Drawing.Point(9, 25);
            this.labelRgsEntrypoint.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRgsEntrypoint.Name = "labelRgsEntrypoint";
            this.labelRgsEntrypoint.Size = new System.Drawing.Size(86, 15);
            this.labelRgsEntrypoint.TabIndex = 4;
            this.labelRgsEntrypoint.Text = "RGS entrypoint";
            // 
            // labelOutputJson
            // 
            this.labelOutputJson.AutoSize = true;
            this.labelOutputJson.Location = new System.Drawing.Point(9, 55);
            this.labelOutputJson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutputJson.Name = "labelOutputJson";
            this.labelOutputJson.Size = new System.Drawing.Size(70, 15);
            this.labelOutputJson.TabIndex = 7;
            this.labelOutputJson.Text = "Output json";
            // 
            // textBoxOutputJson
            // 
            this.textBoxOutputJson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputJson.Location = new System.Drawing.Point(107, 52);
            this.textBoxOutputJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxOutputJson.Name = "textBoxOutputJson";
            this.textBoxOutputJson.Size = new System.Drawing.Size(973, 23);
            this.textBoxOutputJson.TabIndex = 8;
            this.textBoxOutputJson.TextChanged += new System.EventHandler(this.textBoxOutputJson_TextChanged);
            // 
            // buttonOutputJson
            // 
            this.buttonOutputJson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputJson.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutputJson.Image")));
            this.buttonOutputJson.Location = new System.Drawing.Point(1086, 47);
            this.buttonOutputJson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOutputJson.Name = "buttonOutputJson";
            this.buttonOutputJson.Size = new System.Drawing.Size(28, 28);
            this.buttonOutputJson.TabIndex = 9;
            this.buttonOutputJson.UseVisualStyleBackColor = true;
            this.buttonOutputJson.Click += new System.EventHandler(this.buttonOutputJson_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Controls.Add(this.checkBoxSimpleReport);
            this.groupBoxOutput.Controls.Add(this.labelSimpleReport);
            this.groupBoxOutput.Controls.Add(this.buttonOutputXml);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputXml);
            this.groupBoxOutput.Controls.Add(this.labelOutputXml);
            this.groupBoxOutput.Controls.Add(this.buttonOutputJson);
            this.groupBoxOutput.Controls.Add(this.textBoxOutputJson);
            this.groupBoxOutput.Controls.Add(this.labelOutputJson);
            this.groupBoxOutput.Controls.Add(this.labelRgsEntrypoint);
            this.groupBoxOutput.Controls.Add(this.textBoxRgsEntrypoint);
            this.groupBoxOutput.Controls.Add(this.buttonRgsEntrypoint);
            this.groupBoxOutput.Controls.Add(this.buttonStart);
            this.groupBoxOutput.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOutput.Location = new System.Drawing.Point(0, 24);
            this.groupBoxOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxOutput.Size = new System.Drawing.Size(1122, 176);
            this.groupBoxOutput.TabIndex = 1;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // buttonOutputXml
            // 
            this.buttonOutputXml.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOutputXml.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutputXml.Image")));
            this.buttonOutputXml.Location = new System.Drawing.Point(1086, 77);
            this.buttonOutputXml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOutputXml.Name = "buttonOutputXml";
            this.buttonOutputXml.Size = new System.Drawing.Size(28, 28);
            this.buttonOutputXml.TabIndex = 11;
            this.buttonOutputXml.UseVisualStyleBackColor = true;
            this.buttonOutputXml.Click += new System.EventHandler(this.buttonOutputXml_Click);
            // 
            // textBoxOutputXml
            // 
            this.textBoxOutputXml.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOutputXml.Location = new System.Drawing.Point(107, 82);
            this.textBoxOutputXml.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxOutputXml.Name = "textBoxOutputXml";
            this.textBoxOutputXml.Size = new System.Drawing.Size(973, 23);
            this.textBoxOutputXml.TabIndex = 10;
            this.textBoxOutputXml.TextChanged += new System.EventHandler(this.textBoxOutputXml_TextChanged);
            // 
            // labelOutputXml
            // 
            this.labelOutputXml.AutoSize = true;
            this.labelOutputXml.Location = new System.Drawing.Point(9, 85);
            this.labelOutputXml.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOutputXml.Name = "labelOutputXml";
            this.labelOutputXml.Size = new System.Drawing.Size(68, 15);
            this.labelOutputXml.TabIndex = 13;
            this.labelOutputXml.Text = "Output xml";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.Sort = sortOption1;
            // 
            // labelSimpleReport
            // 
            this.labelSimpleReport.AutoSize = true;
            this.labelSimpleReport.Location = new System.Drawing.Point(9, 115);
            this.labelSimpleReport.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSimpleReport.Name = "labelSimpleReport";
            this.labelSimpleReport.Size = new System.Drawing.Size(78, 15);
            this.labelSimpleReport.TabIndex = 19;
            this.labelSimpleReport.Text = "Simple report";
            // 
            // checkBoxSimpleReport
            // 
            this.checkBoxSimpleReport.AutoSize = true;
            this.checkBoxSimpleReport.Location = new System.Drawing.Point(107, 116);
            this.checkBoxSimpleReport.Name = "checkBoxSimpleReport";
            this.checkBoxSimpleReport.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSimpleReport.TabIndex = 12;
            this.checkBoxSimpleReport.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.groupBoxActivity);
            this.Controls.Add(this.groupBoxOutput);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStripMain);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormMain";
            this.Text = "RGS.Taxonomy.Reader";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBoxActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox)).EndInit();
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuItemClose;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpAbout;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripProgressBar progressBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private FastColoredTextBoxNS.FastColoredTextBox fastColoredTextBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRgsEntrypoint;
        private System.Windows.Forms.TextBox textBoxRgsEntrypoint;
        private System.Windows.Forms.Label labelRgsEntrypoint;
        private System.Windows.Forms.Label labelOutputJson;
        private System.Windows.Forms.TextBox textBoxOutputJson;
        private System.Windows.Forms.Button buttonOutputJson;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button buttonOutputXml;
        private System.Windows.Forms.TextBox textBoxOutputXml;
        private System.Windows.Forms.Label labelOutputXml;
        private System.Windows.Forms.CheckBox checkBoxSimpleReport;
        private System.Windows.Forms.Label labelSimpleReport;
    }
}


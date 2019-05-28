namespace Piksel.SMHISharp.Example
{
    partial class FormSMHISharpExample
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bPrevious = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.gbContainer = new System.Windows.Forms.GroupBox();
            this.wizard = new Piksel.Controls.TabWizard.TabWizardControl();
            this.tpIntro = new System.Windows.Forms.TabPage();
            this.lIntro = new System.Windows.Forms.Label();
            this.tpParameters = new System.Windows.Forms.TabPage();
            this.olvParameters = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pLoadParameters = new System.Windows.Forms.Panel();
            this.lParameters = new System.Windows.Forms.Label();
            this.pbParameters = new System.Windows.Forms.ProgressBar();
            this.tpStations = new System.Windows.Forms.TabPage();
            this.scStations = new System.Windows.Forms.SplitContainer();
            this.cbExcludeOld = new System.Windows.Forms.CheckBox();
            this.lLatitude = new System.Windows.Forms.Label();
            this.lLongitude = new System.Windows.Forms.Label();
            this.tbLatitude = new System.Windows.Forms.TextBox();
            this.bFindNearest = new System.Windows.Forms.Button();
            this.tbLongitude = new System.Windows.Forms.TextBox();
            this.olvStations = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn3 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn4 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn5 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pLoadStations = new System.Windows.Forms.Panel();
            this.lStations = new System.Windows.Forms.Label();
            this.pbStations = new System.Windows.Forms.ProgressBar();
            this.tpPeriods = new System.Windows.Forms.TabPage();
            this.olvPeriods = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn6 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn8 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pLoadPeriods = new System.Windows.Forms.Panel();
            this.lPeriods = new System.Windows.Forms.Label();
            this.pbPeriods = new System.Windows.Forms.ProgressBar();
            this.tpData = new System.Windows.Forms.TabPage();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pLoadData = new System.Windows.Forms.Panel();
            this.lData = new System.Windows.Forms.Label();
            this.pbData = new System.Windows.Forms.ProgressBar();
            this.gbContainer.SuspendLayout();
            this.wizard.SuspendLayout();
            this.tpIntro.SuspendLayout();
            this.tpParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).BeginInit();
            this.pLoadParameters.SuspendLayout();
            this.tpStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scStations)).BeginInit();
            this.scStations.Panel1.SuspendLayout();
            this.scStations.Panel2.SuspendLayout();
            this.scStations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvStations)).BeginInit();
            this.pLoadStations.SuspendLayout();
            this.tpPeriods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olvPeriods)).BeginInit();
            this.pLoadPeriods.SuspendLayout();
            this.tpData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.pLoadData.SuspendLayout();
            this.SuspendLayout();
            // 
            // bPrevious
            // 
            this.bPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bPrevious.Location = new System.Drawing.Point(16, 500);
            this.bPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bPrevious.Name = "bPrevious";
            this.bPrevious.Size = new System.Drawing.Size(177, 53);
            this.bPrevious.TabIndex = 1;
            this.bPrevious.Text = "&Previous";
            this.bPrevious.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.Location = new System.Drawing.Point(719, 500);
            this.bNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(177, 53);
            this.bNext.TabIndex = 3;
            this.bNext.Text = "&Next";
            this.bNext.UseVisualStyleBackColor = true;
            this.bNext.Click += new System.EventHandler(this.BNext_Click);
            // 
            // gbContainer
            // 
            this.gbContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbContainer.BackColor = System.Drawing.SystemColors.Window;
            this.gbContainer.Controls.Add(this.wizard);
            this.gbContainer.Location = new System.Drawing.Point(0, -7);
            this.gbContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContainer.Name = "gbContainer";
            this.gbContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbContainer.Size = new System.Drawing.Size(915, 500);
            this.gbContainer.TabIndex = 5;
            this.gbContainer.TabStop = false;
            // 
            // wizard
            // 
            this.wizard.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.wizard.Controls.Add(this.tpIntro);
            this.wizard.Controls.Add(this.tpParameters);
            this.wizard.Controls.Add(this.tpStations);
            this.wizard.Controls.Add(this.tpPeriods);
            this.wizard.Controls.Add(this.tpData);
            this.wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizard.Location = new System.Drawing.Point(4, 19);
            this.wizard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wizard.Name = "wizard";
            this.wizard.NextButton = this.bNext;
            this.wizard.NextButtonLastText = "Close";
            this.wizard.PreviousButton = this.bPrevious;
            this.wizard.SelectedIndex = 0;
            this.wizard.Size = new System.Drawing.Size(907, 477);
            this.wizard.TabIndex = 4;
            this.wizard.Text = null;
            this.wizard.LastButtonClicked += new System.EventHandler(this.wizard_LastButtonClicked);
            // 
            // tpIntro
            // 
            this.tpIntro.Controls.Add(this.lIntro);
            this.tpIntro.Location = new System.Drawing.Point(4, 25);
            this.tpIntro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpIntro.Name = "tpIntro";
            this.tpIntro.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpIntro.Size = new System.Drawing.Size(899, 448);
            this.tpIntro.TabIndex = 0;
            this.tpIntro.Text = "Intro";
            this.tpIntro.UseVisualStyleBackColor = true;
            // 
            // lIntro
            // 
            this.lIntro.AutoSize = true;
            this.lIntro.Location = new System.Drawing.Point(23, 27);
            this.lIntro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIntro.Name = "lIntro";
            this.lIntro.Size = new System.Drawing.Size(195, 17);
            this.lIntro.TabIndex = 0;
            this.lIntro.Text = "Click \"Next\" to get parameters";
            // 
            // tpParameters
            // 
            this.tpParameters.Controls.Add(this.olvParameters);
            this.tpParameters.Controls.Add(this.pLoadParameters);
            this.tpParameters.Location = new System.Drawing.Point(4, 25);
            this.tpParameters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpParameters.Name = "tpParameters";
            this.tpParameters.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpParameters.Size = new System.Drawing.Size(899, 448);
            this.tpParameters.TabIndex = 1;
            this.tpParameters.Text = "Parameters";
            this.tpParameters.UseVisualStyleBackColor = true;
            // 
            // olvParameters
            // 
            this.olvParameters.AllColumns.Add(this.olvColumn1);
            this.olvParameters.AllColumns.Add(this.olvColumn2);
            this.olvParameters.CellEditUseWholeCell = false;
            this.olvParameters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.olvParameters.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvParameters.FullRowSelect = true;
            this.olvParameters.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.olvParameters.Location = new System.Drawing.Point(4, 4);
            this.olvParameters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olvParameters.Name = "olvParameters";
            this.olvParameters.Size = new System.Drawing.Size(891, 440);
            this.olvParameters.TabIndex = 0;
            this.olvParameters.UseCompatibleStateImageBehavior = false;
            this.olvParameters.View = System.Windows.Forms.View.Details;
            this.olvParameters.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Title";
            this.olvColumn1.Width = 200;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Summary";
            this.olvColumn2.FillsFreeSpace = true;
            // 
            // pLoadParameters
            // 
            this.pLoadParameters.Controls.Add(this.lParameters);
            this.pLoadParameters.Controls.Add(this.pbParameters);
            this.pLoadParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadParameters.Location = new System.Drawing.Point(4, 4);
            this.pLoadParameters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pLoadParameters.Name = "pLoadParameters";
            this.pLoadParameters.Size = new System.Drawing.Size(891, 440);
            this.pLoadParameters.TabIndex = 1;
            // 
            // lParameters
            // 
            this.lParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lParameters.Location = new System.Drawing.Point(5, 227);
            this.lParameters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lParameters.Name = "lParameters";
            this.lParameters.Size = new System.Drawing.Size(882, 28);
            this.lParameters.TabIndex = 2;
            this.lParameters.Text = "Getting parameters...";
            this.lParameters.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbParameters
            // 
            this.pbParameters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbParameters.Location = new System.Drawing.Point(304, 179);
            this.pbParameters.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbParameters.Name = "pbParameters";
            this.pbParameters.Size = new System.Drawing.Size(284, 44);
            this.pbParameters.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbParameters.TabIndex = 1;
            // 
            // tpStations
            // 
            this.tpStations.Controls.Add(this.scStations);
            this.tpStations.Controls.Add(this.pLoadStations);
            this.tpStations.Location = new System.Drawing.Point(4, 25);
            this.tpStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpStations.Name = "tpStations";
            this.tpStations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpStations.Size = new System.Drawing.Size(899, 448);
            this.tpStations.TabIndex = 2;
            this.tpStations.Text = "Stations";
            this.tpStations.UseVisualStyleBackColor = true;
            // 
            // scStations
            // 
            this.scStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scStations.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scStations.IsSplitterFixed = true;
            this.scStations.Location = new System.Drawing.Point(4, 4);
            this.scStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scStations.Name = "scStations";
            this.scStations.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scStations.Panel1
            // 
            this.scStations.Panel1.Controls.Add(this.cbExcludeOld);
            this.scStations.Panel1.Controls.Add(this.lLatitude);
            this.scStations.Panel1.Controls.Add(this.lLongitude);
            this.scStations.Panel1.Controls.Add(this.tbLatitude);
            this.scStations.Panel1.Controls.Add(this.bFindNearest);
            this.scStations.Panel1.Controls.Add(this.tbLongitude);
            // 
            // scStations.Panel2
            // 
            this.scStations.Panel2.Controls.Add(this.olvStations);
            this.scStations.Size = new System.Drawing.Size(891, 440);
            this.scStations.SplitterDistance = 36;
            this.scStations.SplitterWidth = 5;
            this.scStations.TabIndex = 4;
            // 
            // cbExcludeOld
            // 
            this.cbExcludeOld.AutoSize = true;
            this.cbExcludeOld.Location = new System.Drawing.Point(479, 7);
            this.cbExcludeOld.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbExcludeOld.Name = "cbExcludeOld";
            this.cbExcludeOld.Size = new System.Drawing.Size(102, 21);
            this.cbExcludeOld.TabIndex = 2;
            this.cbExcludeOld.Text = "Exclude old";
            this.cbExcludeOld.UseVisualStyleBackColor = true;
            // 
            // lLatitude
            // 
            this.lLatitude.AutoSize = true;
            this.lLatitude.Location = new System.Drawing.Point(257, 9);
            this.lLatitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLatitude.Name = "lLatitude";
            this.lLatitude.Size = new System.Drawing.Size(63, 17);
            this.lLatitude.TabIndex = 4;
            this.lLatitude.Text = "Latitude:";
            // 
            // lLongitude
            // 
            this.lLongitude.AutoSize = true;
            this.lLongitude.Location = new System.Drawing.Point(17, 9);
            this.lLongitude.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLongitude.Name = "lLongitude";
            this.lLongitude.Size = new System.Drawing.Size(75, 17);
            this.lLongitude.TabIndex = 3;
            this.lLongitude.Text = "Longitude:";
            // 
            // tbLatitude
            // 
            this.tbLatitude.Location = new System.Drawing.Point(329, 5);
            this.tbLatitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLatitude.Name = "tbLatitude";
            this.tbLatitude.Size = new System.Drawing.Size(132, 22);
            this.tbLatitude.TabIndex = 1;
            // 
            // bFindNearest
            // 
            this.bFindNearest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bFindNearest.Location = new System.Drawing.Point(708, 2);
            this.bFindNearest.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bFindNearest.Name = "bFindNearest";
            this.bFindNearest.Size = new System.Drawing.Size(176, 31);
            this.bFindNearest.TabIndex = 3;
            this.bFindNearest.Text = "Find closest station";
            this.bFindNearest.UseVisualStyleBackColor = true;
            this.bFindNearest.Click += new System.EventHandler(this.bFindNearest_Click);
            // 
            // tbLongitude
            // 
            this.tbLongitude.Location = new System.Drawing.Point(101, 5);
            this.tbLongitude.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLongitude.Name = "tbLongitude";
            this.tbLongitude.Size = new System.Drawing.Size(132, 22);
            this.tbLongitude.TabIndex = 0;
            // 
            // olvStations
            // 
            this.olvStations.AllColumns.Add(this.olvColumn3);
            this.olvStations.AllColumns.Add(this.olvColumn4);
            this.olvStations.AllColumns.Add(this.olvColumn5);
            this.olvStations.CellEditUseWholeCell = false;
            this.olvStations.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn3,
            this.olvColumn4,
            this.olvColumn5});
            this.olvStations.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvStations.FullRowSelect = true;
            this.olvStations.HideSelection = false;
            this.olvStations.Location = new System.Drawing.Point(0, 0);
            this.olvStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olvStations.Name = "olvStations";
            this.olvStations.ShowGroups = false;
            this.olvStations.Size = new System.Drawing.Size(891, 399);
            this.olvStations.TabIndex = 2;
            this.olvStations.UseCompatibleStateImageBehavior = false;
            this.olvStations.View = System.Windows.Forms.View.Details;
            this.olvStations.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // olvColumn3
            // 
            this.olvColumn3.AspectName = "Name";
            this.olvColumn3.FillsFreeSpace = true;
            this.olvColumn3.Text = "Name";
            // 
            // olvColumn4
            // 
            this.olvColumn4.AspectName = "Summary";
            this.olvColumn4.Text = "Summary";
            this.olvColumn4.Width = 280;
            // 
            // olvColumn5
            // 
            this.olvColumn5.AspectName = "Updated";
            this.olvColumn5.Text = "Updated";
            this.olvColumn5.Width = 180;
            // 
            // pLoadStations
            // 
            this.pLoadStations.Controls.Add(this.lStations);
            this.pLoadStations.Controls.Add(this.pbStations);
            this.pLoadStations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadStations.Location = new System.Drawing.Point(4, 4);
            this.pLoadStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pLoadStations.Name = "pLoadStations";
            this.pLoadStations.Size = new System.Drawing.Size(891, 440);
            this.pLoadStations.TabIndex = 3;
            // 
            // lStations
            // 
            this.lStations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lStations.Location = new System.Drawing.Point(5, 227);
            this.lStations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lStations.Name = "lStations";
            this.lStations.Size = new System.Drawing.Size(882, 28);
            this.lStations.TabIndex = 2;
            this.lStations.Text = "Getting stations...";
            this.lStations.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbStations
            // 
            this.pbStations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStations.Location = new System.Drawing.Point(304, 179);
            this.pbStations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbStations.Name = "pbStations";
            this.pbStations.Size = new System.Drawing.Size(284, 44);
            this.pbStations.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbStations.TabIndex = 1;
            // 
            // tpPeriods
            // 
            this.tpPeriods.Controls.Add(this.olvPeriods);
            this.tpPeriods.Controls.Add(this.pLoadPeriods);
            this.tpPeriods.Location = new System.Drawing.Point(4, 25);
            this.tpPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpPeriods.Name = "tpPeriods";
            this.tpPeriods.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpPeriods.Size = new System.Drawing.Size(899, 447);
            this.tpPeriods.TabIndex = 3;
            this.tpPeriods.Text = "Periods";
            this.tpPeriods.UseVisualStyleBackColor = true;
            // 
            // olvPeriods
            // 
            this.olvPeriods.AllColumns.Add(this.olvColumn6);
            this.olvPeriods.AllColumns.Add(this.olvColumn8);
            this.olvPeriods.CellEditUseWholeCell = false;
            this.olvPeriods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn6,
            this.olvColumn8});
            this.olvPeriods.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvPeriods.FullRowSelect = true;
            this.olvPeriods.Location = new System.Drawing.Point(4, 4);
            this.olvPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.olvPeriods.Name = "olvPeriods";
            this.olvPeriods.ShowGroups = false;
            this.olvPeriods.Size = new System.Drawing.Size(891, 439);
            this.olvPeriods.TabIndex = 3;
            this.olvPeriods.UseCompatibleStateImageBehavior = false;
            this.olvPeriods.View = System.Windows.Forms.View.Details;
            this.olvPeriods.SelectedIndexChanged += new System.EventHandler(this.StateControlChanged);
            // 
            // olvColumn6
            // 
            this.olvColumn6.AspectName = "Title";
            this.olvColumn6.FillsFreeSpace = true;
            this.olvColumn6.Text = "Description";
            // 
            // olvColumn8
            // 
            this.olvColumn8.AspectName = "Updated";
            this.olvColumn8.Text = "Updated";
            this.olvColumn8.Width = 180;
            // 
            // pLoadPeriods
            // 
            this.pLoadPeriods.Controls.Add(this.lPeriods);
            this.pLoadPeriods.Controls.Add(this.pbPeriods);
            this.pLoadPeriods.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadPeriods.Location = new System.Drawing.Point(4, 4);
            this.pLoadPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pLoadPeriods.Name = "pLoadPeriods";
            this.pLoadPeriods.Size = new System.Drawing.Size(891, 439);
            this.pLoadPeriods.TabIndex = 4;
            // 
            // lPeriods
            // 
            this.lPeriods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lPeriods.Location = new System.Drawing.Point(5, 226);
            this.lPeriods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPeriods.Name = "lPeriods";
            this.lPeriods.Size = new System.Drawing.Size(882, 28);
            this.lPeriods.TabIndex = 2;
            this.lPeriods.Text = "Getting periods...";
            this.lPeriods.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbPeriods
            // 
            this.pbPeriods.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbPeriods.Location = new System.Drawing.Point(304, 178);
            this.pbPeriods.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPeriods.Name = "pbPeriods";
            this.pbPeriods.Size = new System.Drawing.Size(284, 44);
            this.pbPeriods.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbPeriods.TabIndex = 1;
            // 
            // tpData
            // 
            this.tpData.BackColor = System.Drawing.SystemColors.Window;
            this.tpData.Controls.Add(this.chartData);
            this.tpData.Controls.Add(this.pLoadData);
            this.tpData.Location = new System.Drawing.Point(4, 25);
            this.tpData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpData.Name = "tpData";
            this.tpData.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpData.Size = new System.Drawing.Size(899, 448);
            this.tpData.TabIndex = 4;
            this.tpData.Text = "Data";
            // 
            // chartData
            // 
            this.chartData.BackColor = System.Drawing.SystemColors.Window;
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            this.chartData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartData.Location = new System.Drawing.Point(4, 4);
            this.chartData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chartData.Name = "chartData";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.BackwardDiagonal;
            series1.BackSecondaryColor = System.Drawing.SystemColors.GradientActiveCaption;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.SystemColors.HotTrack;
            series1.IsVisibleInLegend = false;
            series1.MarkerBorderColor = System.Drawing.SystemColors.HotTrack;
            series1.MarkerColor = System.Drawing.SystemColors.Highlight;
            series1.Name = "Series1";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(891, 440);
            this.chartData.TabIndex = 6;
            this.chartData.Text = "chart1";
            // 
            // pLoadData
            // 
            this.pLoadData.Controls.Add(this.lData);
            this.pLoadData.Controls.Add(this.pbData);
            this.pLoadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pLoadData.Location = new System.Drawing.Point(4, 4);
            this.pLoadData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pLoadData.Name = "pLoadData";
            this.pLoadData.Size = new System.Drawing.Size(891, 440);
            this.pLoadData.TabIndex = 5;
            // 
            // lData
            // 
            this.lData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lData.Location = new System.Drawing.Point(5, 227);
            this.lData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lData.Name = "lData";
            this.lData.Size = new System.Drawing.Size(882, 28);
            this.lData.TabIndex = 2;
            this.lData.Text = "Getting data...";
            this.lData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbData
            // 
            this.pbData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbData.Location = new System.Drawing.Point(304, 179);
            this.pbData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbData.Name = "pbData";
            this.pbData.Size = new System.Drawing.Size(284, 44);
            this.pbData.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbData.TabIndex = 1;
            // 
            // FormSMHISharpExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.gbContainer);
            this.Controls.Add(this.bNext);
            this.Controls.Add(this.bPrevious);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(661, 605);
            this.Name = "FormSMHISharpExample";
            this.Text = "SMHISharp Example";
            this.gbContainer.ResumeLayout(false);
            this.wizard.ResumeLayout(false);
            this.tpIntro.ResumeLayout(false);
            this.tpIntro.PerformLayout();
            this.tpParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvParameters)).EndInit();
            this.pLoadParameters.ResumeLayout(false);
            this.tpStations.ResumeLayout(false);
            this.scStations.Panel1.ResumeLayout(false);
            this.scStations.Panel1.PerformLayout();
            this.scStations.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scStations)).EndInit();
            this.scStations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvStations)).EndInit();
            this.pLoadStations.ResumeLayout(false);
            this.tpPeriods.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.olvPeriods)).EndInit();
            this.pLoadPeriods.ResumeLayout(false);
            this.tpData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.pLoadData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvParameters;
        private System.Windows.Forms.Button bPrevious;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button bNext;
        private Controls.TabWizard.TabWizardControl wizard;
        private System.Windows.Forms.TabPage tpIntro;
        private System.Windows.Forms.TabPage tpParameters;
        private System.Windows.Forms.TabPage tpStations;
        private System.Windows.Forms.GroupBox gbContainer;
        private System.Windows.Forms.Label lIntro;
        private System.Windows.Forms.TabPage tpPeriods;
        private System.Windows.Forms.TabPage tpData;
        private BrightIdeasSoftware.ObjectListView olvPeriods;
        private BrightIdeasSoftware.OLVColumn olvColumn6;
        private BrightIdeasSoftware.OLVColumn olvColumn8;
        private System.Windows.Forms.Panel pLoadParameters;
        private System.Windows.Forms.Label lParameters;
        private System.Windows.Forms.ProgressBar pbParameters;
        private System.Windows.Forms.Panel pLoadStations;
        private System.Windows.Forms.Label lStations;
        private System.Windows.Forms.ProgressBar pbStations;
        private System.Windows.Forms.Panel pLoadPeriods;
        private System.Windows.Forms.Label lPeriods;
        private System.Windows.Forms.ProgressBar pbPeriods;
        private System.Windows.Forms.Panel pLoadData;
        private System.Windows.Forms.Label lData;
        private System.Windows.Forms.ProgressBar pbData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
        private System.Windows.Forms.SplitContainer scStations;
        private System.Windows.Forms.Label lLatitude;
        private System.Windows.Forms.Label lLongitude;
        private System.Windows.Forms.TextBox tbLatitude;
        private System.Windows.Forms.Button bFindNearest;
        private System.Windows.Forms.TextBox tbLongitude;
        private BrightIdeasSoftware.ObjectListView olvStations;
        private BrightIdeasSoftware.OLVColumn olvColumn3;
        private BrightIdeasSoftware.OLVColumn olvColumn4;
        private BrightIdeasSoftware.OLVColumn olvColumn5;
        private System.Windows.Forms.CheckBox cbExcludeOld;
    }
}


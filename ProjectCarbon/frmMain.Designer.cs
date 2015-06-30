namespace ProjectCarbon
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenCaptureFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpenAndAppend = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSaveCaptureFile = new System.Windows.Forms.ToolStripMenuItem();
            this.savePacketDumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStartCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStopCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClearCapturedPackets = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDisplayWinsockInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDnsLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVisitWebsite = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMainToolbar = new System.Windows.Forms.ToolStrip();
            this.btnLoadCaptureFile = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCaptureFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslInterface = new System.Windows.Forms.ToolStripLabel();
            this.tscbInterface = new System.Windows.Forms.ToolStripComboBox();
            this.btnStartCapture = new System.Windows.Forms.ToolStripButton();
            this.btnStopCapture = new System.Windows.Forms.ToolStripButton();
            this.btnClearCaptureLog = new System.Windows.Forms.ToolStripButton();
            this.btnCaptureSettings = new System.Windows.Forms.ToolStripButton();
            this.btnCaptureFilters = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShowHelp = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.spynetStatusPanel = new System.Windows.Forms.ToolStripStatusLabel();
            this.packetsInBufferStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.packetCaptureList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tvwPacketHeaderInfo = new System.Windows.Forms.TreeView();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDisplayMode = new System.Windows.Forms.Label();
            this.chkStripHeaders = new System.Windows.Forms.CheckBox();
            this.cboDisplayMode = new System.Windows.Forms.ComboBox();
            this.niTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuTrayStartCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrayStopCapture = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuTraySettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrayFilters = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPacketSize = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tsMainToolbar.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmsTrayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.mnuCapture,
            this.mnuTools,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(929, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenCaptureFile,
            this.mnuOpenAndAppend,
            this.toolStripMenuItem2,
            this.mnuSaveCaptureFile,
            this.savePacketDumpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuOpenCaptureFile
            // 
            this.mnuOpenCaptureFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuOpenCaptureFile.Image")));
            this.mnuOpenCaptureFile.Name = "mnuOpenCaptureFile";
            this.mnuOpenCaptureFile.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenCaptureFile.Text = "Open";
            this.mnuOpenCaptureFile.Click += new System.EventHandler(this.mnuOpenCaptureFile_Click);
            // 
            // mnuOpenAndAppend
            // 
            this.mnuOpenAndAppend.Name = "mnuOpenAndAppend";
            this.mnuOpenAndAppend.Size = new System.Drawing.Size(186, 22);
            this.mnuOpenAndAppend.Text = "Open && Append...";
            this.mnuOpenAndAppend.Click += new System.EventHandler(this.mnuOpenAndAppend_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuSaveCaptureFile
            // 
            this.mnuSaveCaptureFile.Image = ((System.Drawing.Image)(resources.GetObject("mnuSaveCaptureFile.Image")));
            this.mnuSaveCaptureFile.Name = "mnuSaveCaptureFile";
            this.mnuSaveCaptureFile.Size = new System.Drawing.Size(186, 22);
            this.mnuSaveCaptureFile.Text = "Save";
            this.mnuSaveCaptureFile.Click += new System.EventHandler(this.mnuSaveCaptureFile_Click);
            // 
            // savePacketDumpToolStripMenuItem
            // 
            this.savePacketDumpToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("savePacketDumpToolStripMenuItem.Image")));
            this.savePacketDumpToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.savePacketDumpToolStripMenuItem.Name = "savePacketDumpToolStripMenuItem";
            this.savePacketDumpToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.savePacketDumpToolStripMenuItem.Text = "Save Packet Dump...";
            this.savePacketDumpToolStripMenuItem.Click += new System.EventHandler(this.savePacketDumpToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(183, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(186, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuCapture
            // 
            this.mnuCapture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStartCapture,
            this.mnuStopCapture,
            this.mnuClearCapturedPackets,
            this.toolStripMenuItem3,
            this.mnuSettings,
            this.mnuFilters});
            this.mnuCapture.Name = "mnuCapture";
            this.mnuCapture.Size = new System.Drawing.Size(58, 24);
            this.mnuCapture.Text = "Capture";
            // 
            // mnuStartCapture
            // 
            this.mnuStartCapture.Image = ((System.Drawing.Image)(resources.GetObject("mnuStartCapture.Image")));
            this.mnuStartCapture.Name = "mnuStartCapture";
            this.mnuStartCapture.Size = new System.Drawing.Size(198, 22);
            this.mnuStartCapture.Text = "Start Capture";
            this.mnuStartCapture.Click += new System.EventHandler(this.mnuStartCapture_Click);
            // 
            // mnuStopCapture
            // 
            this.mnuStopCapture.Image = ((System.Drawing.Image)(resources.GetObject("mnuStopCapture.Image")));
            this.mnuStopCapture.Name = "mnuStopCapture";
            this.mnuStopCapture.Size = new System.Drawing.Size(198, 22);
            this.mnuStopCapture.Text = "Stop Capture";
            this.mnuStopCapture.Click += new System.EventHandler(this.mnuStopCapture_Click);
            // 
            // mnuClearCapturedPackets
            // 
            this.mnuClearCapturedPackets.Image = ((System.Drawing.Image)(resources.GetObject("mnuClearCapturedPackets.Image")));
            this.mnuClearCapturedPackets.Name = "mnuClearCapturedPackets";
            this.mnuClearCapturedPackets.Size = new System.Drawing.Size(198, 22);
            this.mnuClearCapturedPackets.Text = "Clear Captured Packets";
            this.mnuClearCapturedPackets.Click += new System.EventHandler(this.mnuClearCapturedPackets_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(195, 6);
            // 
            // mnuSettings
            // 
            this.mnuSettings.Image = ((System.Drawing.Image)(resources.GetObject("mnuSettings.Image")));
            this.mnuSettings.Name = "mnuSettings";
            this.mnuSettings.Size = new System.Drawing.Size(198, 22);
            this.mnuSettings.Text = "Settings...";
            this.mnuSettings.Click += new System.EventHandler(this.mnuSettings_Click);
            // 
            // mnuFilters
            // 
            this.mnuFilters.Image = ((System.Drawing.Image)(resources.GetObject("mnuFilters.Image")));
            this.mnuFilters.Name = "mnuFilters";
            this.mnuFilters.Size = new System.Drawing.Size(198, 22);
            this.mnuFilters.Text = "Filters...";
            this.mnuFilters.Click += new System.EventHandler(this.mnuFilters_Click);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDisplayWinsockInfo,
            this.mnuDnsLookup});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(44, 24);
            this.mnuTools.Text = "Tools";
            // 
            // mnuDisplayWinsockInfo
            // 
            this.mnuDisplayWinsockInfo.Name = "mnuDisplayWinsockInfo";
            this.mnuDisplayWinsockInfo.Size = new System.Drawing.Size(232, 22);
            this.mnuDisplayWinsockInfo.Text = "Display Winsock Information...";
            this.mnuDisplayWinsockInfo.Click += new System.EventHandler(this.mnuDisplayWinsockInfo_Click);
            // 
            // mnuDnsLookup
            // 
            this.mnuDnsLookup.Name = "mnuDnsLookup";
            this.mnuDnsLookup.Size = new System.Drawing.Size(232, 22);
            this.mnuDnsLookup.Text = "DNS Lookup...";
            this.mnuDnsLookup.Click += new System.EventHandler(this.mnuDnsLookup_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVisitWebsite,
            this.toolStripMenuItem4,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // mnuVisitWebsite
            // 
            this.mnuVisitWebsite.Name = "mnuVisitWebsite";
            this.mnuVisitWebsite.Size = new System.Drawing.Size(202, 22);
            this.mnuVisitWebsite.Text = "Visit Xeon Productions...";
            this.mnuVisitWebsite.Click += new System.EventHandler(this.mnuVisitWebsite_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.Size = new System.Drawing.Size(202, 22);
            this.mnuAbout.Text = "About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // tsMainToolbar
            // 
            this.tsMainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoadCaptureFile,
            this.btnSaveCaptureFile,
            this.toolStripSeparator2,
            this.tslInterface,
            this.tscbInterface,
            this.btnStartCapture,
            this.btnStopCapture,
            this.btnClearCaptureLog,
            this.btnCaptureSettings,
            this.btnCaptureFilters,
            this.toolStripSeparator4,
            this.btnShowHelp});
            this.tsMainToolbar.Location = new System.Drawing.Point(0, 24);
            this.tsMainToolbar.Name = "tsMainToolbar";
            this.tsMainToolbar.Size = new System.Drawing.Size(929, 25);
            this.tsMainToolbar.TabIndex = 10;
            // 
            // btnLoadCaptureFile
            // 
            this.btnLoadCaptureFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoadCaptureFile.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadCaptureFile.Image")));
            this.btnLoadCaptureFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadCaptureFile.Name = "btnLoadCaptureFile";
            this.btnLoadCaptureFile.Size = new System.Drawing.Size(23, 22);
            this.btnLoadCaptureFile.Text = "Open";
            this.btnLoadCaptureFile.Click += new System.EventHandler(this.btnLoadCaptureFile_Click);
            // 
            // btnSaveCaptureFile
            // 
            this.btnSaveCaptureFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveCaptureFile.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCaptureFile.Image")));
            this.btnSaveCaptureFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCaptureFile.Name = "btnSaveCaptureFile";
            this.btnSaveCaptureFile.Size = new System.Drawing.Size(23, 22);
            this.btnSaveCaptureFile.Text = "Save";
            this.btnSaveCaptureFile.Click += new System.EventHandler(this.btnSaveCaptureFile_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tslInterface
            // 
            this.tslInterface.Name = "tslInterface";
            this.tslInterface.Size = new System.Drawing.Size(56, 22);
            this.tslInterface.Text = "Interface:";
            // 
            // tscbInterface
            // 
            this.tscbInterface.CausesValidation = false;
            this.tscbInterface.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbInterface.Name = "tscbInterface";
            this.tscbInterface.Size = new System.Drawing.Size(200, 25);
            // 
            // btnStartCapture
            // 
            this.btnStartCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStartCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnStartCapture.Image")));
            this.btnStartCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStartCapture.Name = "btnStartCapture";
            this.btnStartCapture.Size = new System.Drawing.Size(23, 22);
            this.btnStartCapture.Text = "Start Capture";
            this.btnStartCapture.Click += new System.EventHandler(this.btnStartCapture_Click);
            // 
            // btnStopCapture
            // 
            this.btnStopCapture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStopCapture.Image = ((System.Drawing.Image)(resources.GetObject("btnStopCapture.Image")));
            this.btnStopCapture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStopCapture.Name = "btnStopCapture";
            this.btnStopCapture.Size = new System.Drawing.Size(23, 22);
            this.btnStopCapture.Text = "Stop Capture";
            this.btnStopCapture.Click += new System.EventHandler(this.btnStopCapture_Click);
            // 
            // btnClearCaptureLog
            // 
            this.btnClearCaptureLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClearCaptureLog.Image = ((System.Drawing.Image)(resources.GetObject("btnClearCaptureLog.Image")));
            this.btnClearCaptureLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearCaptureLog.Name = "btnClearCaptureLog";
            this.btnClearCaptureLog.Size = new System.Drawing.Size(23, 22);
            this.btnClearCaptureLog.Text = "Clear Captured Packets";
            this.btnClearCaptureLog.Click += new System.EventHandler(this.btnClearCaptureLog_Click);
            // 
            // btnCaptureSettings
            // 
            this.btnCaptureSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCaptureSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnCaptureSettings.Image")));
            this.btnCaptureSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCaptureSettings.Name = "btnCaptureSettings";
            this.btnCaptureSettings.Size = new System.Drawing.Size(23, 22);
            this.btnCaptureSettings.Text = "Capture Settings";
            this.btnCaptureSettings.Click += new System.EventHandler(this.btnCaptureSettings_Click);
            // 
            // btnCaptureFilters
            // 
            this.btnCaptureFilters.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCaptureFilters.Image = ((System.Drawing.Image)(resources.GetObject("btnCaptureFilters.Image")));
            this.btnCaptureFilters.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCaptureFilters.Name = "btnCaptureFilters";
            this.btnCaptureFilters.Size = new System.Drawing.Size(23, 22);
            this.btnCaptureFilters.Text = "Capture Filters";
            this.btnCaptureFilters.Click += new System.EventHandler(this.btnCaptureFilters_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnShowHelp
            // 
            this.btnShowHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShowHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnShowHelp.Image")));
            this.btnShowHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShowHelp.Name = "btnShowHelp";
            this.btnShowHelp.Size = new System.Drawing.Size(23, 22);
            this.btnShowHelp.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spynetStatusPanel,
            this.packetsInBufferStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // spynetStatusPanel
            // 
            this.spynetStatusPanel.Image = ((System.Drawing.Image)(resources.GetObject("spynetStatusPanel.Image")));
            this.spynetStatusPanel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.spynetStatusPanel.Name = "spynetStatusPanel";
            this.spynetStatusPanel.Size = new System.Drawing.Size(809, 17);
            this.spynetStatusPanel.Spring = true;
            this.spynetStatusPanel.Text = "Network Adapter Placeholder";
            this.spynetStatusPanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // packetsInBufferStatus
            // 
            this.packetsInBufferStatus.Name = "packetsInBufferStatus";
            this.packetsInBufferStatus.Size = new System.Drawing.Size(105, 17);
            this.packetsInBufferStatus.Text = "Captured Packets: 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.packetCaptureList);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 467);
            this.splitContainer1.SplitterDistance = 221;
            this.splitContainer1.TabIndex = 12;
            // 
            // packetCaptureList
            // 
            this.packetCaptureList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.packetCaptureList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.packetCaptureList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.packetCaptureList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetCaptureList.FullRowSelect = true;
            this.packetCaptureList.HideSelection = false;
            this.packetCaptureList.Location = new System.Drawing.Point(0, 0);
            this.packetCaptureList.MultiSelect = false;
            this.packetCaptureList.Name = "packetCaptureList";
            this.packetCaptureList.Size = new System.Drawing.Size(929, 221);
            this.packetCaptureList.TabIndex = 1;
            this.packetCaptureList.UseCompatibleStateImageBehavior = false;
            this.packetCaptureList.View = System.Windows.Forms.View.Details;
            this.packetCaptureList.SelectedIndexChanged += new System.EventHandler(this.packetCaptureList_SelectedIndexChanged);
            this.packetCaptureList.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.packetCaptureList_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 52;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Time";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Source MAC";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Dest MAC";
            this.columnHeader4.Width = 110;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Protocol";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Source IP";
            this.columnHeader6.Width = 105;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Destination IP";
            this.columnHeader7.Width = 105;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Port Source";
            this.columnHeader8.Width = 70;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Port Dest";
            this.columnHeader9.Width = 70;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tvwPacketHeaderInfo);
            this.splitContainer2.Panel1Collapsed = true;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtbDisplay);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(929, 242);
            this.splitContainer2.SplitterDistance = 217;
            this.splitContainer2.TabIndex = 2;
            // 
            // tvwPacketHeaderInfo
            // 
            this.tvwPacketHeaderInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwPacketHeaderInfo.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvwPacketHeaderInfo.Location = new System.Drawing.Point(0, 0);
            this.tvwPacketHeaderInfo.Name = "tvwPacketHeaderInfo";
            this.tvwPacketHeaderInfo.ShowRootLines = false;
            this.tvwPacketHeaderInfo.Size = new System.Drawing.Size(217, 242);
            this.tvwPacketHeaderInfo.TabIndex = 2;
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.BackColor = System.Drawing.Color.White;
            this.rtbDisplay.DetectUrls = false;
            this.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbDisplay.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDisplay.Location = new System.Drawing.Point(0, 24);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbDisplay.ShowSelectionMargin = true;
            this.rtbDisplay.Size = new System.Drawing.Size(929, 218);
            this.rtbDisplay.TabIndex = 1;
            this.rtbDisplay.Text = "";
            this.rtbDisplay.WordWrap = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblPacketSize);
            this.panel1.Controls.Add(this.lblDisplayMode);
            this.panel1.Controls.Add(this.chkStripHeaders);
            this.panel1.Controls.Add(this.cboDisplayMode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 24);
            this.panel1.TabIndex = 2;
            // 
            // lblDisplayMode
            // 
            this.lblDisplayMode.AutoSize = true;
            this.lblDisplayMode.Location = new System.Drawing.Point(8, 4);
            this.lblDisplayMode.Name = "lblDisplayMode";
            this.lblDisplayMode.Size = new System.Drawing.Size(74, 13);
            this.lblDisplayMode.TabIndex = 1;
            this.lblDisplayMode.Text = "Display Mode:";
            // 
            // chkStripHeaders
            // 
            this.chkStripHeaders.AutoSize = true;
            this.chkStripHeaders.Location = new System.Drawing.Point(232, 2);
            this.chkStripHeaders.Name = "chkStripHeaders";
            this.chkStripHeaders.Size = new System.Drawing.Size(91, 17);
            this.chkStripHeaders.TabIndex = 14;
            this.chkStripHeaders.Text = "Strip Headers";
            this.chkStripHeaders.UseVisualStyleBackColor = true;
            this.chkStripHeaders.CheckStateChanged += new System.EventHandler(this.chkStripTCPIPHeaders_CheckStateChanged);
            this.chkStripHeaders.CheckedChanged += new System.EventHandler(this.chkStripTCPIPHeaders_CheckedChanged);
            // 
            // cboDisplayMode
            // 
            this.cboDisplayMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDisplayMode.FormattingEnabled = true;
            this.cboDisplayMode.Items.AddRange(new object[] {
            "Hex + Text",
            "Hex only",
            "Decimal + Text",
            "Decimal Only",
            "Text Mode"});
            this.cboDisplayMode.Location = new System.Drawing.Point(88, 0);
            this.cboDisplayMode.Name = "cboDisplayMode";
            this.cboDisplayMode.Size = new System.Drawing.Size(136, 21);
            this.cboDisplayMode.TabIndex = 0;
            this.cboDisplayMode.SelectedIndexChanged += new System.EventHandler(this.cboDisplayModes_SelectedIndexChanged);
            // 
            // niTrayIcon
            // 
            this.niTrayIcon.ContextMenuStrip = this.cmsTrayMenu;
            this.niTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("niTrayIcon.Icon")));
            this.niTrayIcon.Text = "Project Carbon";
            this.niTrayIcon.Visible = true;
            this.niTrayIcon.DoubleClick += new System.EventHandler(this.niTrayIcon_DoubleClick);
            // 
            // cmsTrayMenu
            // 
            this.cmsTrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrayStartCapture,
            this.mnuTrayStopCapture,
            this.toolStripMenuItem8,
            this.mnuTraySettings,
            this.mnuTrayFilters,
            this.toolStripMenuItem5,
            this.exitToolStripMenuItem});
            this.cmsTrayMenu.Name = "cmsTrayMenu";
            this.cmsTrayMenu.Size = new System.Drawing.Size(152, 126);
            // 
            // mnuTrayStartCapture
            // 
            this.mnuTrayStartCapture.Name = "mnuTrayStartCapture";
            this.mnuTrayStartCapture.Size = new System.Drawing.Size(151, 22);
            this.mnuTrayStartCapture.Text = "Start Capture";
            this.mnuTrayStartCapture.Click += new System.EventHandler(this.mnuTrayStartCapture_Click);
            // 
            // mnuTrayStopCapture
            // 
            this.mnuTrayStopCapture.Name = "mnuTrayStopCapture";
            this.mnuTrayStopCapture.Size = new System.Drawing.Size(151, 22);
            this.mnuTrayStopCapture.Text = "Stop Capture";
            this.mnuTrayStopCapture.Click += new System.EventHandler(this.mnuTrayStopCapture_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(148, 6);
            // 
            // mnuTraySettings
            // 
            this.mnuTraySettings.Name = "mnuTraySettings";
            this.mnuTraySettings.Size = new System.Drawing.Size(151, 22);
            this.mnuTraySettings.Text = "Settings...";
            this.mnuTraySettings.Click += new System.EventHandler(this.mnuTraySettings_Click);
            // 
            // mnuTrayFilters
            // 
            this.mnuTrayFilters.Name = "mnuTrayFilters";
            this.mnuTrayFilters.Size = new System.Drawing.Size(151, 22);
            this.mnuTrayFilters.Text = "Filters...";
            this.mnuTrayFilters.Click += new System.EventHandler(this.mnuTrayFilters_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(148, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblPacketSize
            // 
            this.lblPacketSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPacketSize.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPacketSize.Location = new System.Drawing.Point(744, 0);
            this.lblPacketSize.Name = "lblPacketSize";
            this.lblPacketSize.Size = new System.Drawing.Size(184, 21);
            this.lblPacketSize.TabIndex = 15;
            this.lblPacketSize.Text = "Packet Size: 0";
            this.lblPacketSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 538);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsMainToolbar);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Carbon (Beta 5)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tsMainToolbar.ResumeLayout(false);
            this.tsMainToolbar.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsTrayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenCaptureFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpenAndAppend;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuSaveCaptureFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuStartCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuStopCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuSettings;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuDisplayWinsockInfo;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tsMainToolbar;
        private System.Windows.Forms.ToolStripButton btnStartCapture;
        private System.Windows.Forms.ToolStripButton btnStopCapture;
        private System.Windows.Forms.ToolStripButton btnCaptureFilters;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnLoadCaptureFile;
        private System.Windows.Forms.ToolStripButton btnSaveCaptureFile;
        private System.Windows.Forms.ToolStripButton btnClearCaptureLog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCaptureSettings;
        private System.Windows.Forms.ToolStripButton btnShowHelp;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel spynetStatusPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView packetCaptureList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ToolStripMenuItem mnuFilters;
        private System.Windows.Forms.ToolStripMenuItem mnuVisitWebsite;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuClearCapturedPackets;
        private System.Windows.Forms.CheckBox chkStripHeaders;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TreeView tvwPacketHeaderInfo;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.NotifyIcon niTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsTrayMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuTrayStartCapture;
        private System.Windows.Forms.ToolStripMenuItem mnuTrayStopCapture;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem mnuTraySettings;
        private System.Windows.Forms.ToolStripMenuItem mnuTrayFilters;
        private System.Windows.Forms.ToolStripMenuItem savePacketDumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDnsLookup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDisplayMode;
        private System.Windows.Forms.ComboBox cboDisplayMode;
        private System.Windows.Forms.ToolStripStatusLabel packetsInBufferStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tslInterface;
        private System.Windows.Forms.ToolStripComboBox tscbInterface;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblPacketSize;



    }
}

